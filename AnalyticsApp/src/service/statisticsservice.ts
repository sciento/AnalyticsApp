/// <reference path="../common/_reference.ts" />

namespace AnalyticsApp {
    "use strict";

    export namespace StatisticsService {
        import Observable = Rx.Observable;
        import ApiResponse = Model.ApiResponse;
        import BrowserStatistic = Model.BrowserStatistic;
        import CountryStatistic = Model.CountryStatistic;
        import OperatingSystemStatistic = Model.OperatingSystemStatistic;
        import VisitStatistic = Model.VisitStatistic;

        declare var Headers: any;
        declare var fetch: any;

        export enum Order {
            DESCENDING, ASCENDING
        }

        export interface StatisticConfig {
            order: Order;
            sortBy: "visits" | "date";
            fromDate?: Date;
            toDate?: Date;
        }

        const defaultConfig: StatisticConfig = { order: Order.ASCENDING, sortBy: "visits" };

        export class VisitStatistics {
            private static responseTransformer: (o: any) => VisitStatistic = o => o as VisitStatistic;

            static getByUserId(userId: string, siteId: string, config: StatisticConfig = defaultConfig)
                : Observable<VisitStatistic> {

                return getContentOf(`/api/visits/${userId}/${siteId}`, VisitStatistics.responseTransformer);
            }

            static getAllByUserId(userId: string, config: StatisticConfig = defaultConfig)
                : Observable<VisitStatistic> {

                return getContentOf(`/api/visits/${userId}`, VisitStatistics.responseTransformer);
            }
        }

        export class CountryStatistics {

            static getByUserId(userId: string, siteId: string, config: StatisticConfig = defaultConfig)
                : Observable<CountryStatistic> {

                return getContentOf(`/api/countries/${userId}/${siteId}`, o => o as CountryStatistic);
            }
        }

        export class BrowserStatistics {

            static getByUserId(userId: string, siteId: string, config: StatisticConfig = defaultConfig)
                : Observable<BrowserStatistic> {

                // FIXME create controller
                return getContentOf(`/api/analyse/browser/${userId}/${siteId}`, o => o as BrowserStatistic);
            }
        }

        export class OperatingSystemStatistics {

            static getByUserId(userId: string, siteId: string, config: StatisticConfig = defaultConfig)
                : Observable<OperatingSystemStatistic> {

                // FIXME create controller
                return getContentOf(`/api/analyse/os/${userId}/${siteId}`, o => o as OperatingSystemStatistic);
            }
        }

        function getContentOf<T>(uri: string, transformer: (o: any) => T): Observable<T> {
            const requestHeaders = new Headers();
            requestHeaders.set("Accept", "application/json");
            requestHeaders.set("Accept-Charset", "utf-8");

            return Observable.fromPromise<ApiResponse<any>>(fetch(uri, {
                method: "GET",
                headers: requestHeaders,
                mode: "cors",
                cache: "default"
            }).then((response: any) => response.json())
                .then((jsonResponse: ApiResponse<any>) => {
                    if (jsonResponse.error) {
                        return Promise.reject<ApiResponse<any>>(new Error(jsonResponse.error.message));
                    } else {
                        return Promise.resolve(jsonResponse);
                    }
                }))
                .flatMap(jsonResponse => Observable.from(jsonResponse.items))
                .map(transformer);
        }
    }
}
