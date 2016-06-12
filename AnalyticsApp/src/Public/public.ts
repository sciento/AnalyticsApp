/// <reference path="../common/_reference.ts" />

namespace AnalyticsApp {
    export namespace Public {


        export class Login {

            private authLogin: Model.AuthRequest;
            private loginUri: string;
            private apiResponse: Model.ApiResponse<Model.User>;

            constructor() {
                this.AddEvents();
           } 

           private AddEvents() {
               $("#login").unbind("click").click(this.Login)
            }

           private Request(data: any, status: any, message: any) {
               this.apiResponse = data;
               if (this.apiResponse.error.message != null) {
                   Notification.Error(this.apiResponse.error.message);
               } else {
                   location.reload();
               }

           }

           private Validate() : boolean  {
               if (this.authLogin.username.length < 3) {
                   AnalyticsApp.Notification.Warn("Please enter a username!");
                   return false;
               }
               if (this.authLogin.secret.length < 3) {
                   AnalyticsApp.Notification.Warn("Please enter a password!");
                   return false;
               }
               return true;
            }

           private Login(e: EventListenerObject) {
               var that = new Public.Login();
               that.authLogin = {
                   username: $("#login-username").val(),
                   secret: $("#login-password").val()
               };
               
               if (that.Validate())
                   AnalyticsApp.Request.Post(AnalyticsApp.Routes.Login, that.authLogin, that.Request);

           }
        }

        export class Registration {

            constructor() {
                console.log("Registration");
            }
        }
    }
}

import public = AnalyticsApp.Public
new public.Login()
new public.Registration()
