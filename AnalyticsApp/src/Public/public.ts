/// <reference path="../common/_reference.ts" />

namespace AnalyticsApp {
    export namespace Public {

        export class Login {

            private authLogin: Model.ApiRequest<Model.Auth>;
            private loginUri: string;
            private apiResponse: Model.ApiResponse<Model.User>;

            constructor() {
                this.AddEvents();
            }

            private AddEvents(): void {
                $("#login").unbind("click").click(this.Login)
            }

            private Response(data: any, status: string, jqXhr: JQueryXHR): void {
                this.apiResponse = data;
                if (this.apiResponse.error.message != null) {
                    Notification.Error(this.apiResponse.error.message);
                } else {
                    location.reload();
                }
            }

            private Validate(): boolean {
                if (this.authLogin.data.username.length < 3) {
                    Notification.Warn("Please enter a username!");
                    return false;
                }
                if (this.authLogin.data.secret.length < 3) {
                    Notification.Warn("Please enter a password!");
                    return false;
                }
                return true;
            }

            private Login(e: Event): void {
                e.stopPropagation();
                e.preventDefault();

                var that = new Public.Login();
                that.authLogin = {
                    data: {
                        username: $("#login-username").val(),
                        secret: $("#login-password").val()
                    }
                };

                if (that.Validate()) {
                    Request.Post(AnalyticsApp.Routes.Login, that.authLogin)
                        .then(that.Response);
                }
            }
        }

        export class Registration {

            constructor() {
                this.AddEvents();
                //this.registerRequest.data = this.newUser;

            }

            private registerRequest: Model.ApiRequest<Model.Registration>;

            private AddEvents(): void {
                $("#register").unbind("click").click(this.Registration)
            }

            private Registration(e: Event): void {
                e.stopPropagation();
                e.preventDefault();
                var that = new Public.Registration();
                that.registerRequest = {
                    data: {
                        username: $("#registration-username").val(),
                        password: $("#registration-password").val(),
                        email: $("#registration-email").val()
                    }
                };

                if (that.Validate()) {
                    Request.Post(AnalyticsApp.Routes.Registration, that.registerRequest)
                        .then(that.Response);
                }
            }

            private Response(data: any, status: string, jqXhr: JQueryXHR) {
                console.log(data);
            }

            private Validate(): boolean {
                if ($("#registration-username").val() <= 4) {
                    Notification.Warn("Username must be at least 4 characters!");
                    return false;
                }
                if ($("#registration-password").val() <= 6) {
                    Notification.Warn("Password must be at least 6 characters!");
                    return false;
                }
                if ($("#registration-password").val() != $("#registration-password-validate").val()) {
                    Notification.Warn("Passwords do not match!");
                    return false;
                }
                if (!this.ValidateEmail($("#registration-email").val())) {
                    Notification.Warn("Enter a correct E-Mail!");
                    return false;
                }


                return true;
            }

            private ValidateEmail(email: string): boolean {
                var re = /^(([^<>()\[\]\\.,;:\s@"]+(\.[^<>()\[\]\\.,;:\s@"]+)*)|(".+"))@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}])|(([a-zA-Z\-0-9]+\.)+[a-zA-Z]{2,}))$/;
                return re.test(email);
            }
        }
    }
}

new AnalyticsApp.Public.Login()
new AnalyticsApp.Public.Registration()
