import { Component } from '@angular/core';
import { Router } from '@angular/router';
import { JwtHelperService } from '@auth0/angular-jwt';
import { User } from '../../models/user';
import { AuthGuard } from '../authguard.service';
import { ExpInlfuDataService } from '../exp-inlfu-data-service.service';
import { Chart, ChartOptions, ChartDataset } from 'chart.js';
import { TransactionService } from 'src/app/transaction.service'
import { TransactionCategory } from '../../models/transaction';
import { ChartConfiguration, ChartData, ChartEvent, ChartType } from 'chart.js';
import { BaseChartDirective } from 'ng2-charts';
import DatalabelsPlugin from 'chartjs-plugin-datalabels';


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
  public activity: any;
  public xData: any;
  public label: any;
  options: any;
  loginUser!: User;
  constructor(private jwtHelper: JwtHelperService, private router: Router, private authguardService: AuthGuard, private _emp: ExpInlfuDataService, private serviceTransaction: TransactionService) { }



  pieChartLabels: string[] = [
    TransactionCategory[0], TransactionCategory[1], TransactionCategory[2], TransactionCategory[3], TransactionCategory[4], TransactionCategory[5], TransactionCategory[6],
    TransactionCategory[7], TransactionCategory[8], TransactionCategory[9], TransactionCategory[10], TransactionCategory[11], TransactionCategory[12], TransactionCategory[13],
    TransactionCategory[14], TransactionCategory[15]];
  //CHART COLOR.
  pieChartColor: any = [
    {
      backgroundColor: ['rgba(30, 169, 224, 0.8)',
        'rgba(255,165,0,0.9)',
        'rgba(139, 136, 136, 0.9)',
        'rgba(255, 161, 181, 0.9)',
        'rgba(255, 102, 0, 0.9)',
      ]
    }
  ]


  public pieChartData1: number[] = [];


  // Pie
  public pieChartPlugins = [DatalabelsPlugin];
  public pieChartOptions: ChartConfiguration['options'] = {
    responsive: true,
    plugins: {
      legend: {
        display: true,
        position: 'top',
      }
    }
  };
  public pieChartData?: ChartData<'pie', number[], string | string[]>;

  public pieChartType: ChartType = 'pie';



  createChart(positiveAmounts: number[], negativeAmounts: number[]) {
    this.chart = new Chart("AmountTransactionBarChart", {
      type: 'bar',

      data: {
        labels: ['2022-01', '2022-02', '2022-03', '2022-04', '2022-05', '2022-06', '2022-07', '2022-08',
          '2022-09', '2022-10', '2022-11', '2022-12'],

        datasets: [
          {
            label: "Profit",
            data: positiveAmounts,
            backgroundColor: '#12492f'
          },
          {
            label: "Expenses",
            data: negativeAmounts,
            backgroundColor: '#f56038'
          }
        ]
      },
      options: {
        aspectRatio: 2.5
      }
    })
  }

  createPieChart(data1: number[]) {
    this.chart = new Chart("AmountPieChart", {
      type: 'pie',

      data: {
        labels: this.pieChartLabels,

        datasets: [
          {
            data: data1,
            backgroundColor: ['#072448', '#54d2d2', '#ffcb00', '#f8aa4b', '#ff6150', '#12492f', '#0a2f35', '#f56038', '#f7a325', '#ffca7a', '#361d32', '#543c52', '#f55951', '#edd2cb', '#f1e8e6', '#f1e8e6']
          }
        ]
      },
      options: {
        aspectRatio: 2.1,
        responsive: true,
        maintainAspectRatio: true,
      },
      plugins: [DatalabelsPlugin],

    })
  }

  ngOnInit() {
    this.loginUser = this.authguardService.getUser();
    this.serviceTransaction.getTotalPositiveAmounts().subscribe(positiveAmounts => {
      this.serviceTransaction.getTotalNegativeAmounts().subscribe(negativeAmouts => this.createChart(positiveAmounts, negativeAmouts))
      this.serviceTransaction.getTransactionsByCatergory().subscribe(data =>
        this.createPieChart(data))
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

  setData(array: number[]) {
    this.pieChartData1 = array;
  }
  public logOut = () => {
    localStorage.removeItem("jwt");
  }

}
