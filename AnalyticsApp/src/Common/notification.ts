/// <reference path="./_reference.ts" />

namespace AnalyticsApp {
    "use strict";

    export class Notification {
        private static time: number = 5000;
        private static Handler(type: string, message: string) {
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
        }

        private static Timeout(id: string) {
            $("#" + id).fadeIn("slow");
            setTimeout(function () {
                $("#" + id).fadeOut("slow", function () {
                    $("#" + id).remove();
                });
            }, this.time);
        }

        private static GetRandomId(): string {
            var id = Math.floor((Math.random() * 1000) + 1);
            if ($("notification").length < 1) {
                return "notification" + id;
            }

            return this.GetRandomId();
        }

        public static Success(message: string) {
            console.log("[Success] " + message);
            this.Handler("success", message);
        }

        public static Error(message: string) {
            console.error("[Error] " + message);
            this.Handler("danger", message);
        }

        public static Info(message: string) {
            console.info("[Info] " + message);
            this.Handler("info", message);
        }

        public static Warn(message: string) {
            console.warn("[Warn] " + message);
            this.Handler("warning", message);
        }
    }
}
