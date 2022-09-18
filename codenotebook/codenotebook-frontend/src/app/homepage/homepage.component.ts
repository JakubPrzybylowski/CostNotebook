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
import { TransactionCategory } from '../../models/transaction';
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
  constructor(private jwtHelper: JwtHelperService, private router: Router, private authguardService: AuthGuard, private _emp: ExpInlfuDataService, private serviceTransaction: TransactionService, private categoryTransaction:TransactionCategory) {}
  test: any;

          { y: 120, name: TransactionCategory.FoodAndHouseholdChemistry },
          { y: 300, name: TransactionCategory.Crossings },
          { y: 800, name: TransactionCategory.Influences },
          { y: 150, name: TransactionCategory.AccessoriesEquipment },
          { y: 150, name: TransactionCategory.EatingOut },
          { y: 250, name: TransactionCategory.Uncategorized },
          { y: 120, name: TransactionCategory.OutingsAndEvents },
          { y: 300, name: TransactionCategory.Current },
          { y: 800, name: TransactionCategory.GiftsAndSupport },
          { y: 150, name: TransactionCategory.Renumeration },
          { y: 150, name: TransactionCategory.RegularSaving },
          { y: 250, name: TransactionCategory.Flue },
          { y: 120, name: TransactionCategory.RenovationAndGarden },
          { y: 300, name: TransactionCategory.MultimediaBooksAndPress },
          { y: 800, name: TransactionCategory.ClothingFootwear },
          { y: 150, name: TransactionCategory.TvInternetTelephone },
      
  

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
