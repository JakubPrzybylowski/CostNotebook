import { first } from "rxjs";

export class User {
  id!: any;
  userEmail!: string;
  firstName!: string;
  lastName!: string;

  constructor(id: string, userEmail: string, firstName:string, lastName : string) {
    this.id = id,this.userEmail = userEmail,this.firstName = firstName,this.lastName = lastName
  }
}
