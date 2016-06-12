/// <reference path="./_reference.ts" />
var AnalyticsApp;
(function (AnalyticsApp) {
    var Routes = (function () {
        function Routes() {
        }
        Routes.Login = "./api/auth";
        Routes.Registration = "./api/users";
        return Routes;
    }());
    AnalyticsApp.Routes = Routes;
})(AnalyticsApp || (AnalyticsApp = {}));
//# sourceMappingURL=routes.js.map