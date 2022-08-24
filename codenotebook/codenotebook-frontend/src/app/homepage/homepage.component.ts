import { Component } from '@angular/core';
import { Router } from '@angular/router';
import { JwtHelperService } from '@auth0/angular-jwt';
import { User } from '../../models/user';
import { AuthGuard } from '../authguard.service';
import { ExpInlfuDataService } from '../exp-inlfu-data-service.service';

@Component({
  selector: 'app-homepage',
  templateUrl: './homepage.component.html',
  styleUrls: ['./homepage.component.css']
})
export class HomepageComponent {
  loginUser!: User;
  constructor(private jwtHelper: JwtHelperService, private router: Router, private authguardService: AuthGuard, private _emp: ExpInlfuDataService) {
  }
  barChartOptions: any = {
    scaleShowVerticalLines: false,
    responsive: true
  };
  barChartLabels!: string[];
  barChartType: string = 'bar';
  barChartLegend: boolean = true;
  test: any;

  barChartData: any[] = [
    { data: [], label: 'Volume Sales' },
    { data: [], label: 'Value Sales' }
  ];  
  ngOnInit() {
    this.loginUser = this.authguardService.getUser();
    this._emp.getExpInfluData().subscribe(data => {
      this.barChartLabels = Object.keys(data);
      this.test = data;
      this.barChartLabels.forEach(label => {
        this.barChartData[0].data.push(this.test[label]['volumeExpenses']);
        this.barChartData[1].data.push(this.test[label]['valueInfluence']);
      });
    });
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
