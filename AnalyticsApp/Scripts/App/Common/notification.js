/// <reference path="./_reference.ts" />
var AnalyticsApp;
(function (AnalyticsApp) {
    var Notification = (function () {
        function Notification() {
        }
        Notification.Handler = function (type, message) {
            var id = this.GetRandomId();
            var newNotification = document.createElement("div");
            var newNotificationButton = document.createElement("button");
            var notification = document.createTextNode(message);
            var closeButton = document.createTextNode("x");
            newNotificationButton.setAttribute("class", "close");
            newNotificationButton.setAttribute("data-dismiss", "alert");
            newNotificationButton.setAttribute("type", "button");
            newNotification.setAttribute("class", "notification alert alert-" + type);
            newNotification.setAttribute("id", id);
            newNotificationButton.appendChild(closeButton);
            newNotification.appendChild(notification);
            newNotification.appendChild(newNotificationButton);
            document.getElementById("notification-frame").appendChild(newNotification);
            this.Timeout(id);
        };
        Notification.Timeout = function (id) {
            $("#" + id).fadeIn("slow");
            setTimeout(function () {
                $("#" + id).fadeOut("slow", function () {
                    $("#" + id).remove();
                });
            }, this.time);
        };
        Notification.GetRandomId = function () {
            var id = Math.floor((Math.random() * 1000) + 1);
            if ($("notification").length < 1)
                return "notification" + id;
            return this.GetRandomId();
        };
        Notification.Success = function (message) {
            console.log("[Success] " + message);
            this.Handler("success", message);
        };
        Notification.Error = function (message) {
            console.error("[Error] " + message);
            this.Handler("danger", message);
        };
        Notification.Info = function (message) {
            console.info("[Info] " + message);
            this.Handler("info", message);
        };
        Notification.Warn = function (message) {
            console.warn("[Warn] " + message);
            this.Handler("warning", message);
        };
        Notification.time = 5000;
        return Notification;
    }());
    AnalyticsApp.Notification = Notification;
})(AnalyticsApp || (AnalyticsApp = {}));
//# sourceMappingURL=notification.js.map