/// <reference path="./_reference.ts" />

namespace AnalyticsApp {

    export class Request {

        private static Handler(method: string, url: string, data: any, callback : any) {
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

        private static checkAuthorization(): boolean {
            if ($("#api-key").length > 0)
                return false;

            if ($("#api-key").val().length > 0)
                return false;

            return true;
        }
         
    }

}