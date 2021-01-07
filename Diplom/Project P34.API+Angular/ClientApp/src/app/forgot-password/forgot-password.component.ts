import { Component, OnInit } from '@angular/core';
import { NotifierService } from 'angular-notifier';
import { NgxSpinnerService } from 'ngx-spinner';
import { ForgotPasswordModel } from './Model/forgot-password.model';
import { ForgotPasswordService } from './Service/forgot-password.service';
import { ApiResult } from '../Models/result.model';
import { Router, ActivatedRoute, Params } from '@angular/router';



@Component({
  selector: 'app-forgot-password',
  templateUrl: './forgot-password.component.html',
  styleUrls: ['./forgot-password.component.css']
})
export class ForgotPasswordComponent implements OnInit {

  isError: boolean;
  email: string;
  model: ForgotPasswordModel;
  constructor(  private spinner: NgxSpinnerService,
    private notifier: NotifierService, 
    private ForgotPasswordService: ForgotPasswordService,
    private router: Router,
    private route: ActivatedRoute) { }

  

  sendMail(){
    this.spinner.show();

    if(this.model == null){
      this.notifier.notify('error', 'Please, enter email!');
      this.isError = true;
    }

    if (this.isError === false) {
      this.ForgotPasswordService.recoverPassword(this.email, this.model).subscribe(
      (data: ApiResult) => {
        if (data.status === 200) {
          this.notifier.notify('success', 'Mail sended successfuly');
          this.router.navigate(['/home']);
        }
      },
      (error) => {
        this.notifier.notify('error', 'Server error');
      }
    );
  }

  this.isError = false;
  this.spinner.hide();


  }


  ngOnInit() {
  }
  
  

}
