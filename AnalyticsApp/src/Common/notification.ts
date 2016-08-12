/// <reference path="./_reference.ts" />

namespace AnalyticsApp {
    "use strict";

    export class Notification {
        private static time: number = 5000;

        private static Handler(type: string, message: string) {
            const id = Notification.GetRandomId();
            const newNotification = document.createElement("div");
            const newNotificationButton = document.createElement("button");
            const notification = document.createTextNode(message);
            const closeButton = document.createTextNode("x");

            newNotificationButton.setAttribute("class", "close");
            newNotificationButton.setAttribute("data-dismiss", "alert");
            newNotificationButton.setAttribute("type", "button");
            newNotification.setAttribute("class", `notification alert alert-${type}`);
            newNotification.setAttribute("id", id);

            newNotificationButton.appendChild(closeButton);
            newNotification.appendChild(notification);
            newNotification.appendChild(newNotificationButton);
            document.getElementById("notification-frame").appendChild(newNotification);

            Notification.Timeout(id);
        }

        private static Timeout(id: string) {
            const $element = $(`#${id}`);

            $element.fadeIn("slow");
            setTimeout(() =>
                $element.fadeOut("slow", () =>
                    $element.remove()),
                Notification.time);
        }

        private static GetRandomId(): string {
            const id = Math.floor((Math.random() * 1000) + 1);

            if ($(`#notification${id}`).length < 1) {
                return `notification${id}`;
            } else {
                return Notification.GetRandomId();
            }
        }

        public static Success(message: string) {
            console.log("[Success] " + message);
            Notification.Handler("success", message);
        }

        public static Error(message: string) {
            console.error("[Error] " + message);
            Notification.Handler("danger", message);
        }

        public static Info(message: string) {
            console.info("[Info] " + message);
            Notification.Handler("info", message);
        }

        public static Warn(message: string) {
            console.warn("[Warn] " + message);
            Notification.Handler("warning", message);
        }
    }
}
