/// <reference path="./_reference.ts" />
var AnalyticsApp;
(function (AnalyticsApp) {
    var Request = (function () {
        function Request() {
        }
        Request.Handler = function (method, url, data, callback) {
            $.ajax({
                type: method,
                url: url,
                beforeSend: function (request) {
                    // if (AnalyticsApp.Request.checkAuthorization())
                    //    request.setRequestHeader("Authorization", "" +$("#api-key").val());
                },
                data: JSON.stringify(data),
                dataType: 'json',
                contentType: "application/json; charset=utf-8",
            }).done(callback);
        };
        Request.Get = function (url, data, callback) {
            this.Handler("GET", url, data, callback);
        };
        Request.Put = function (url, data, callback) {
            this.Handler("PUT", url, data, callback);
        };
        Request.Delete = function (url, data, callback) {
            this.Handler("DELETE", url, data, callback);
        };
        Request.Post = function (url, data, callback) {
            this.Handler("POST", url, data, callback);
        };
        Request.checkAuthorization = function () {
            if ($("#api-key").length > 0)
                return false;
            if ($("#api-key").val().length > 0)
                return false;
            return true;
        };
        return Request;
    }());
    AnalyticsApp.Request = Request;
})(AnalyticsApp || (AnalyticsApp = {}));
//# sourceMappingURL=request.js.map