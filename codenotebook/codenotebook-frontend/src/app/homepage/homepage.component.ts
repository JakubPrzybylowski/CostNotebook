import { Component } from '@angular/core';
import { Router } from '@angular/router';
import { JwtHelperService } from '@auth0/angular-jwt';
import { User } from '../../models/user';
import { AuthGuard } from '../authguard.service';

@Component({
  selector: 'app-homepage',
  templateUrl: './homepage.component.html',
  styleUrls: ['./homepage.component.css']
})
export class HomepageComponent {
  loginUser!: User;
  constructor(private jwtHelper: JwtHelperService, private router: Router, private authguardService: AuthGuard) {
  }

  ngOnInit() {
    this.loginUser = this.authguardService.getUser();
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
