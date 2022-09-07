import { Component } from '@angular/core';
import { Router } from '@angular/router';
import { JwtHelperService } from '@auth0/angular-jwt';
import { User } from '../../models/user';
import { AuthGuard } from '../authguard.service';
import { ExpInlfuDataService } from '../exp-inlfu-data-service.service';
import { ChartDataset, ChartOptions, ChartType } from 'chart.js';
import { BaseChartDirective } from 'ng2-charts';

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
  public activity:any;
  public xData: any;
  public label: any;
  options: any;
  loginUser!: User;
  constructor(private jwtHelper: JwtHelperService, private router: Router, private authguardService: AuthGuard, private _emp: ExpInlfuDataService) {
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

  public barChartLabels: BaseChartDirective["labels"] = ['January ', 'February ', 'March', 'April', 'May',
    'June ', 'July', 'August', 'September', 'October ', 'November', 'December'];
  public barChartType: ChartType = 'bar';
  public barChartLegend = true;
  public barChartPlugins = [];
  public barChartData: ChartDataset[] = [
    { data: [5000, 5000, 5000, 5000, 5000, 5000, 5000, 5000, 5000, 5000, 5000, 5000,], label: 'Income' },
    { data: [3000, 3000, 3000, 3000, 3000, 3000, 3000, 3000, 3000, 3000, 3000, 3000,], label: 'Outgoings' },
  ];    
      
  ngOnInit() {
    this.loginUser = this.authguardService.getUser();
    Highcharts.chart('pieChart', this.options);
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
