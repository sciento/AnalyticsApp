/// <reference path="../Common/_reference.ts" />

namespace AnalyticsApp {
    export namespace Public {

        export class Login {
            private authLogin: AuthRequest;
            private loginUri: string;

            constructor() {
                this.AddEvents();
           } 

           private AddEvents() {
               $("#login").unbind("click").click(this.Login)
            }

           private Request(data : any, status: any, message: any) {
               console.log(data);
               console.log(status);
               console.log(message);
           }

           private Validate() : boolean  {
               if (this.authLogin.username.length < 3) {
                   AnalyticsApp.Notification.Warn("Please entry a username!");
                   return false;
               }
               if (this.authLogin.secret.length < 3) {
                   AnalyticsApp.Notification.Success("Please entry a password!");
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