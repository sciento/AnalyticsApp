namespace AnalyticsApp {
    export namespace StatisticsService {
        import Observable = Rx.Observable;

        interface ApiResponse<T> {
            items: Array<T>;
            error?: Error;
        }

        interface Error {
            id: number;
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

                // TODO
                return Observable.from([
                    {
                        site: {
                            id: "1",
                            title: "Example",
                            link: "http://www.example.com",
                            owner: {
                                id: "1",
                                displayName: "Homer J."
                            }
                        },
                        averageVisitTime: 300,
                        visits: 1337
                    }]);
            }

            static getAllByUserId(userId: string, config: StatisticConfig = defaultConfig): Observable<VisitStatistic> {

                // TODO
                return Observable.from([
                    {
                        site: {
                            id: "1",
                            title: "Example",
                            link: "http://www.example.com",
                            owner: {
                                id: "1",
                                displayName: "Homer J."
                            }
                        },
                        averageVisitTime: 300,
                        visits: 1337
                    },
                    {
                        site: {
                            id: "2",
                            title: "Test",
                            link: "http://www.test.com",
                            owner: {
                                id: "1",
                                displayName: "Homer J."
                            }
                        },
                        averageVisitTime: 210,
                        visits: 456
                    },
                    {
                        site: {
                            id: "3",
                            title: "Lorem Ipsum",
                            link: "http://www.loremipsum.com",
                            owner: {
                                id: "1",
                                displayName: "Homer J."
                            }
                        },
                        averageVisitTime: 426,
                        visits: 1254
                    }]);
            }
        }

        export class CountryStatistics {

            static getByUserId(userId: string, siteId: string, config: StatisticConfig = defaultConfig): Observable<CountryStatistic> {

                // TODO
                return Observable.from([
                    {
                        country: "Australia",
                        visits: Math.round(Math.random() * 500),
                        site: {
                            id: "1",
                            title: "Example",
                            link: "http://www.example.com",
                            owner: {
                                id: "1",
                                displayName: "Homer J."
                            }
                        }
                    },
                    {
                        country: "Austria",
                        visits: Math.round(Math.random() * 500),
                        site: {
                            id: "1",
                            title: "Example",
                            link: "http://www.example.com",
                            owner: {
                                id: "1",
                                displayName: "Homer J."
                            }
                        }
                    },
                    {
                        country: "Germany",
                        visits: Math.round(Math.random() * 500),
                        site: {
                            id: "1",
                            title: "Example",
                            link: "http://www.example.com",
                            owner: {
                                id: "1",
                                displayName: "Homer J."
                            }
                        }
                    },
                    {
                        country: "Italy",
                        visits: Math.round(Math.random() * 500),
                        site: {
                            id: "1",
                            title: "Example",
                            link: "http://www.example.com",
                            owner: {
                                id: "1",
                                displayName: "Homer J."
                            }
                        }
                    },
                    {
                        country: "USA",
                        visits: Math.round(Math.random() * 500),
                        site: {
                            id: "1",
                            title: "Example",
                            link: "http://www.example.com",
                            owner: {
                                id: "1",
                                displayName: "Homer J."
                            }
                        }
                    }]);
            }

            static getAllByUserId(userId: string, config: StatisticConfig = defaultConfig): Observable<CountryStatistic> {

                // TODO
                return Observable.empty<CountryStatistic>();
            }
        }

        export class BrowserStatistics {

            static getByUserId(userId: string, config: StatisticConfig = defaultConfig): Observable<BrowserStatistic> {

                // TODO
                return Observable.empty<BrowserStatistic>();
            }

            static getAllByUserId(userId: string, config: StatisticConfig = defaultConfig): Observable<BrowserStatistic> {

                // TODO
                return Observable.empty<BrowserStatistic>();
            }
        }

        export class OperatingSystemStatistics {

            static getByUserId(userId: string, config: StatisticConfig = defaultConfig): Observable<OperatingSystemStatistic> {

                // TODO
                return Observable.empty<OperatingSystemStatistic>();
            }

            static getAllByUserId(userId: string, config: StatisticConfig = defaultConfig): Observable<OperatingSystemStatistic> {

                // TODO
                return Observable.empty<OperatingSystemStatistic>();
            }
        }

        function getContentOf(url: string): Observable<ApiResponse<any>> {

            // TODO make http request to server to get the actual data; call observer#onError() in case of an error
            return Observable.empty<ApiResponse<any>>();
        }
    }
}
