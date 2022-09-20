import { Component } from '@angular/core';
import { Router } from '@angular/router';
import { JwtHelperService } from '@auth0/angular-jwt';
import { User } from '../../models/user';
import { AuthGuard } from '../authguard.service';
import { ExpInlfuDataService } from '../exp-inlfu-data-service.service';
import { Chart, ChartOptions, ChartType, } from 'chart.js';
import { TransactionService } from 'src/app/transaction.service'

import { TransactionCategory } from '../../models/transaction';




@Component({
  selector: 'app-homepage',
  templateUrl: './homepage.component.html',
  styleUrls: ['./homepage.component.css']
})
export class HomepageComponent {
  public barChartOptions: ChartOptions = {
    responsive: true
  }
  public pieChartType: ChartType = 'pie';
  public chart: any;
  public activity:any;
  public xData: any;
  public label: any;
  options: any;
  loginUser!: User;
  constructor(private jwtHelper: JwtHelperService, private router: Router, private authguardService: AuthGuard, private _emp: ExpInlfuDataService, private serviceTransaction: TransactionService) {}
  test: any;

          //{ y: 120, name: TransactionCategory.FoodAndHouseholdChemistry },
          //{ y: 300, name: TransactionCategory.Crossings },
          //{ y: 800, name: TransactionCategory.Influences },
          //{ y: 150, name: TransactionCategory.AccessoriesEquipment },
          //{ y: 150, name: TransactionCategory.EatingOut },
          //{ y: 250, name: TransactionCategory.Uncategorized },
          //{ y: 120, name: TransactionCategory.OutingsAndEvents },
          //{ y: 300, name: TransactionCategory.Current },
          //{ y: 800, name: TransactionCategory.GiftsAndSupport },
          //{ y: 150, name: TransactionCategory.Renumeration },
          //{ y: 150, name: TransactionCategory.RegularSaving },
          //{ y: 250, name: TransactionCategory.Flue },
          //{ y: 120, name: TransactionCategory.RenovationAndGarden },
          //{ y: 300, name: TransactionCategory.MultimediaBooksAndPress },
          //{ y: 800, name: TransactionCategory.ClothingFootwear },
          //{ y: 150, name: TransactionCategory.TvInternetTelephone },
      
  pieChartOptions = {
    responsiev: true
  }

  pieChartLabels = [TransactionCategory.FoodAndHouseholdChemistry, TransactionCategory.Crossings, TransactionCategory.Influences, TransactionCategory.AccessoriesEquipment, TransactionCategory.EatingOut
    , TransactionCategory.Uncategorized, TransactionCategory.OutingsAndEvents, TransactionCategory.Current, TransactionCategory.GiftsAndSupport, TransactionCategory.Renumeration, TransactionCategory.RegularSaving
    , TransactionCategory.Flue, TransactionCategory.RenovationAndGarden, TransactionCategory.MultimediaBooksAndPress, TransactionCategory.ClothingFootwear, TransactionCategory.TvInternetTelephone];
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

pieChartData: any = [
  {
    data: []
  }
];

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
    this.serviceTransaction.getTotalPositiveAmounts().subscribe(positiveAmounts => {
      this.serviceTransaction.getTotalNegativeAmounts().subscribe(negativeAmouts => this.createChart(positiveAmounts, negativeAmouts))
    this.serviceTransaction.getTransactionsByCatergory().subscribe(data => this.pieChartData = data as any [])
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
