import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class AuthService {
  currentUser?: User;

  constructor() { }

  loginUser(user: User) {
    console.log("Log in the user with the email " + user.email)
    this.currentUser = user;
  }
}

interface User {
  email?: null |string
}
