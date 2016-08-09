/// <reference path="./_reference.ts" />

namespace AnalyticsApp {

    export class Request {

        private static Handler(method: string, url: string, data: any): JQueryXHR {
            return $.ajax({
                type: method,
                url: url,
                data: JSON.stringify(data),
                dataType: "json",
                contentType: "application/json; charset=utf-8",
            });
        }

        public static Get(url: string, data: any): JQueryXHR {
            return Request.Handler("GET", url, data);
        }

        public static Put(url: string, data: any): JQueryXHR {
            return Request.Handler("PUT", url, data);
        }

        public static Delete(url: string, data: any): JQueryXHR {
            return Request.Handler("DELETE", url, data);
        }

        public static Post(url: string, data: any): JQueryXHR {
            return Request.Handler("POST", url, data);
        }
    }
}
