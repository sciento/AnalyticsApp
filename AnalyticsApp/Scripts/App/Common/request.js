/// <reference path="./_reference.ts" />
var AnalyticsApp;
(function (AnalyticsApp) {
    var Request = (function () {
        function Request() {
        }
        Request.Handler = function (method, url, data) {
            return $.ajax({
                type: method,
                url: url,
                data: JSON.stringify(data),
                dataType: "json",
                contentType: "application/json; charset=utf-8",
            });
        };
        Request.Get = function (url, data) {
            return Request.Handler("GET", url, data);
        };
        Request.Put = function (url, data) {
            return Request.Handler("PUT", url, data);
        };
        Request.Delete = function (url, data) {
            return Request.Handler("DELETE", url, data);
        };
        Request.Post = function (url, data) {
            return Request.Handler("POST", url, data);
        };
        return Request;
    }());
    AnalyticsApp.Request = Request;
})(AnalyticsApp || (AnalyticsApp = {}));
//# sourceMappingURL=request.js.map