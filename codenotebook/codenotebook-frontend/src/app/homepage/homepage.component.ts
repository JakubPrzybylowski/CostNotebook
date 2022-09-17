import { Component } from '@angular/core';
import { Router } from '@angular/router';
import { JwtHelperService } from '@auth0/angular-jwt';
import { User } from '../../models/user';
import { AuthGuard } from '../authguard.service';
import { ExpInlfuDataService } from '../exp-inlfu-data-service.service';
import { Chart, ChartDataset, ChartOptions, ChartType } from 'chart.js';
import { BaseChartDirective } from 'ng2-charts';
import {TransactionService} from 'src/app/transaction.service'

import * as Highcharts from 'highcharts';

import highcharts3D from 'highcharts/highcharts-3d';
highcharts3D(Highcharts);



@Component({
  selector: 'app-homepage',
  templateUrl: './homepage.component.html',
  styleUrls: ['./homepage.component.css']
})
export class HomepageComponent {
  public barChartOptions: ChartOptions = {
    responsive: true
  }
  public chart: any;
  public activity:any;
  public xData: any;
  public label: any;
  options: any;
  loginUser!: User;
  constructor(private jwtHelper: JwtHelperService, private router: Router, private authguardService: AuthGuard, private _emp: ExpInlfuDataService, private serviceTransaction: TransactionService) {
    this.options = {
      chart: {
        type: 'pie',
        options3d: {
          enabled: true,
          alpha: 45,
          beta: 0
        }
      },
      title: {
        text: 'Monthly expenses with categories'
      },
      accessibility: {
        point: {
          valueSuffix: '%'
        }
      },
      tooltip: {
        pointFormat: '{series.name}: {point.percentage:.1f}%'
      },
      plotOptions: {
        pie: {
          allowPointSelect: true,
          cursor: 'pointer',
          depth: 35,
          dataLabels: {
            enabled: true,
            format: '{point.name}'
          }
        }
      },
      series: [{
        type: 'pie',
        name: 'Expenses',
        data: [
          {
            name: 'Groceries',
            y: 45.0,
            sliced: true,
            selected: true
      },
          ['Chemical articles', 26.8],
          ['Petrol station',12.8],
          ['Attractions', 8.5],
          ['Internet payments', 6.2],
          ['Others', 0.7]
        ]
      }]
    };
}
  test: any;

  createChart(positiveAmounts: number[],negativeAmounts: number[]) {
    this.chart = new Chart("AmountTransactionBarChart", {
      type: 'bar',

      data: {
        labels: ['2022-01', '2022-02', '2022-03', '2022-04', '2022-05', '2022-06', '2022-07', '2022-08',
          '2022-09', '2022-10', '2022-11', '2022-12'],

        datasets: [
          {
            label: "Profit",
            data: positiveAmounts,
            backgroundColor: '#309618'
          },
          {
            label: "Expenses",
            data: negativeAmounts,
            backgroundColor: '#C5451C'
          }
        ]
      },
      options: {
        aspectRatio:2.5
      }
    })
  }
  ngOnInit() {
    this.loginUser = this.authguardService.getUser();
    Highcharts.chart('pieChart', this.options);
    this.serviceTransaction.getTotalPositiveAmounts().subscribe(positiveAmounts => {
      this.serviceTransaction.getTotalNegativeAmounts().subscribe(negativeAmouts => this.createChart(positiveAmounts, negativeAmouts))
    })

  }
  ngOnChanges() {
    this.loginUser = this.authguardService.getUser();
  }

  isUserAuthenticated() {
    const token = localStorage.getItem("jwt");
    if (token && !this.jwtHelper.isTokenExpired(token)) {
      return true;
    }
    else {
      return false;
    }
  }

  public logOut = () => {
    localStorage.removeItem("jwt");
  }

}
