/// <reference path="./_reference.ts" />
var AnalyticsApp;
(function (AnalyticsApp) {
    var Public;
    (function (Public) {
        var Login = (function () {
            function Login() {
                this.loginUri = "/api/auth";
                this.AddEvents();
            }
            Login.prototype.AddEvents = function () {
                $("#login").unbind("click").click(this.Login);
            };
            Login.prototype.Request = function (data, status, message) {
                console.log(data);
                console.log(status);
                console.log(message);
            };
            Login.prototype.Validate = function () {
                if (this.authLogin.username.length < 3) {
                    console.error("Please entry a username!");
                    return false;
                }
                if (this.authLogin.secret.length < 3) {
                    console.error("Please entry a password!");
                    return false;
                }
                return true;
            };
            Login.prototype.Login = function (e) {
                var that = new Public.Login();
                that.authLogin = {
                    username: $("#login-username").val(),
                    secret: $("#login-password").val()
                };
                if (that.Validate()) {
                    $.ajax({
                        type: "POST",
                        url: that.loginUri,
                        data: JSON.stringify(that.authLogin),
                        dataType: 'json',
                        contentType: "application/json; charset=utf-8",
                    }).done(that.Request);
                }
            };
            return Login;
        }());
        Public.Login = Login;
        var Registration = (function () {
            function Registration() {
                console.log("Registration");
            }
            return Registration;
        }());
        Public.Registration = Registration;
    })(Public = AnalyticsApp.Public || (AnalyticsApp.Public = {}));
})(AnalyticsApp || (AnalyticsApp = {}));
var public = AnalyticsApp.Public;
new public.Login();
new public.Registration();
//# sourceMappingURL=public.js.map