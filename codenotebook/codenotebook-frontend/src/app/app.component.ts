import { HttpClient } from '@angular/common/http';
import { Component } from '@angular/core';
import { FormControl, FormGroup, Validators, FormBuilder } from '@angular/forms';
import { Router } from '@angular/router';
@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})



export class AppComponent {
  public loginForm!: FormGroup
  //Form Validables 
  registerForm: any = FormGroup;
  submitted = false;
  constructor(private formBuilder: FormBuilder, private http: HttpClient, private router : Router) { }
  //Add user form actions
  get f() { return this.registerForm.controls; }
  onSubmit() {
    this.http.get<any>("https://localhost:5001/api/Test")
      .subscribe(res => {
        const user = res.find((a: any) => {
          return a.userEmail === this.registerForm.value.email && a.password === this.registerForm.value.password
        });
        if (user) {
          alert('Login Succesful');
        } else {
          alert("user not found")
        }
      }, err => {
        alert("Something went wrong")
      })
    // stop here if form is invalid
    if (this.registerForm.invalid) {
      return;
    }
    //True if all the fields are filled
    if (this.submitted) {
      alert("Great!!");
    }

  }
  ngOnInit() {
    //Add User form validations
    this.registerForm = this.formBuilder.group({
      email: ['', [Validators.required, Validators.email]],
      password: ['', [Validators.required]]
    });
  }  
 }
