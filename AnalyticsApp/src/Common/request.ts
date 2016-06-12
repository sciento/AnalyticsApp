/// <reference path="./_reference.ts" />

namespace AnalyticsApp {

    export class Request {

        private static Handler(method: string, url: string, data: any, callback : any) {
            $.ajax({
                type: method,
                url: url,
                data: JSON.stringify(data),
                dataType: 'json',
                contentType: "application/json; charset=utf-8",
            }).done(callback);
        }  

        public static Get(url: string, data: any, callback: any) {
            this.Handler("GET", url, data, callback);
        }

        public static Put(url: string, data: any, callback: any) {
            this.Handler("PUT", url, data, callback);
        }

        public static Delete(url: string, data: any, callback: any) {
            this.Handler("DELETE", url, data, callback);
        }

        public static Post(url: string, data: any, callback: any) {
            this.Handler("POST", url, data, callback);
        }
         
    }

}