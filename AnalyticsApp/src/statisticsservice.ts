/// <reference path="./Common/_reference.ts" />

namespace AnalyticsApp {
    "use strict";

    export namespace StatisticsService {
        import Observable = Rx.Observable;

        declare var fetch: any;

        export interface ApiResponse<T> {
            items: Array<T>;
            error?: Error;
        }

        export interface Error {
            id: string;
            name: string;
            message: string;
        }

        export interface User {
            id: string;
            displayName: string;
            sites?: Array<string>;
        }

        export interface Site {
            id: string;
            title: string;
            link: string;
            owner: User;
        }

        export interface VisitStatistic {
            site: Site;
            averageVisitTime: number;
            visits: number;
        }

        export interface CountryStatistic {
            site: Site;
            country: string;
            visits: number;
        }

        export interface BrowserStatistic {
            name: string;
            version: string;
            userAgent: string;
            language: string;
            site: Site;
            visits: number;
        }

        export interface OperatingSystemStatistic {
            name: string;
            version: string;
            site: Site;
            visits: number;
        }

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
            static getByUserId(userId: string, siteId: string, config: StatisticConfig = defaultConfig): Observable<VisitStatistic> {

                return getContentOf(`/api/visits/${userId}/${siteId}`, o => ({
                    site: {
                        id: o.site.site_id,
                        title: o.site.title,
                        link: o.site.link,
                        owner: {
                            id: o.site.owner.user_id,
                            displayName: o.site.owner.display_name
                        },
                    },
                    averageVisitTime: o.avg_visit_time,
                    visits: o.visits
                }));
            }

            static getAllByUserId(userId: string, config: StatisticConfig = defaultConfig): Observable<VisitStatistic> {

                return getContentOf(`/api/visits/${userId}`, o => ({
                    site: {
                        id: o.site.site_id,
                        title: o.site.title,
                        link: o.site.link,
                        owner: {
                            id: o.site.owner.user_id,
                            displayName: o.site.owner.display_name
                        },
                    },
                    averageVisitTime: o.avg_visit_time,
                    visits: o.visits
                }));
            }
        }

        export class CountryStatistics {

            static getByUserId(userId: string, siteId: string, config: StatisticConfig = defaultConfig): Observable<CountryStatistic> {

                return getContentOf(`/api/countries/${userId}/${siteId}`, o => ({
                    country: o.country,
                    visits: o.visits,
                    site: {
                        id: o.site.site_id,
                        title: o.site.title,
                        link: o.site.link,
                        owner: {
                            id: o.site.owner.user_id,
                            displayName: o.site.owner.display_name
                        }
                    }
                }));
            }
        }

        export class BrowserStatistics {

            static getByUserId(userId: string, siteId: string, config: StatisticConfig = defaultConfig): Observable<BrowserStatistic> {

                // TODO
                return Observable.empty<BrowserStatistic>();
            }
        }

        export class OperatingSystemStatistics {

            static getByUserId(userId: string, siteId: string, config: StatisticConfig = defaultConfig): Observable<OperatingSystemStatistic> {

                // TODO
                return Observable.empty<OperatingSystemStatistic>();
            }
        }

        function getContentOf<T>(uri: string, transformer: (o: any) => T): Observable<T> {
            return Observable.create<ApiResponse<any>>(subscriber => {
                fetch(uri)
                    .then((response: any) => response.json())
                    .then((jsonResponse: ApiResponse<any>) => {
                        if (jsonResponse.error) {
                            subscriber.onError(new Error(jsonResponse.error.message));
                        } else {
                            subscriber.onNext(jsonResponse);
                            subscriber.onCompleted();
                        }
                    })
                    .catch((e: any) => subscriber.onError(new Error(e)));
            }).flatMap(jsonResponse => Observable.from(jsonResponse.items))
                .map(transformer);
        }
    }
}
