import { Injectable } from '@angular/core';
import { CanActivate, Router } from '@angular/router';
import { JwtHelperService } from '@auth0/angular-jwt';
import { User } from '../models/user';

@Injectable()
export class AuthGuard implements CanActivate {
  public loginUser!: User;
  constructor(private jwtHelper: JwtHelperService, private router: Router) {
  }
  canActivate() {

    //get the jwt token which are present in the local storage
    const token = localStorage.getItem("jwt");

    //Check if the token is expired or not and if token is expired then redirect to login page and return false
    if (token && !this.jwtHelper.isTokenExpired(token)) {
      return true;
    }
    this.router.navigate(["login"]);
    return false;
  }
  getUser(){
    let token = localStorage.getItem('jwt');
    if (token != null) {
      let decodedJWT = JSON.parse(window.atob(token.split('.')[1]));
      let email = decodedJWT['http://schemas.xmlsoap.org/ws/2005/05/identity/claims/emailaddress'];
      let id = decodedJWT['http://schemas.xmlsoap.org/ws/2005/05/identity/claims/nameidentifier'];
      let name = decodedJWT['http://schemas.xmlsoap.org/ws/2005/05/identity/claims/name'];
      let lastName = decodedJWT['http://schemas.xmlsoap.org/ws/2005/05/identity/claims/surname'];
      var user = new User(id, email, name, lastName);
      return user;
    }
    return new User('','','','');
  }
}
