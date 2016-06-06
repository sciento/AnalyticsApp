namespace AnalyticsApp {
    export namespace StatisticsServices {
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
        }

        export interface Site {
            id: string;
            link: string;
            owner: User;
        }

        export interface VisitsByCountryData {
            site: Site;
            country: string;
            visits: number;
        }

        export class Visits {
            static getAllByCountry(userId: string): Observable<VisitsByCountryData> {
                // TODO replace parameter of 'getContentOf' with actual server address
                return getContentOf("urlToService")
                    .flatMap(response => Observable.from(response.items))
                    .map(dataObj => ({
                        country: dataObj.country,
                        visits: dataObj.visits,
                        site: {
                            id: dataObj.site.site_id,
                            link: dataObj.site.link,
                            owner: {
                                id: dataObj.site.owner.user_id,
                                displayName: dataObj.site.owner.display_name
                            }
                        }
                    }));
            }
        }

        const getContentOf = function (url: string): Observable<ApiResponse<any>> {
            // TODO make http request to server to get the actual data; call observer#onError() in case of an error
            return Observable.just(JSON.stringify({
                items: [
                    {
                        country: "Australia",
                        visits: Math.round(Math.random() * 500),
                        site: {
                            site_id: "1",
                            link: "http://www.example.com",
                            owner: {
                                user_id: "1",
                                display_name: "Homer J."
                            }
                        }
                    },
                    {
                        country: "Austria",
                        visits: Math.round(Math.random() * 500),
                        site: {
                            site_id: "1",
                            link: "http://www.example.com",
                            owner: {
                                user_id: "1",
                                display_name: "Homer J."
                            }
                        }
                    },
                    {
                        country: "Germany",
                        visits: Math.round(Math.random() * 500),
                        site: {
                            site_id: "1",
                            link: "http://www.example.com",
                            owner: {
                                user_id: "1",
                                display_name: "Homer J."
                            }
                        }
                    },
                    {
                        country: "Italy",
                        visits: Math.round(Math.random() * 500),
                        site: {
                            site_id: "1",
                            link: "http://www.example.com",
                            owner: {
                                user_id: "1",
                                display_name: "Homer J."
                            }
                        }
                    },
                    {
                        country: "USA",
                        visits: Math.round(Math.random() * 500),
                        site: {
                            site_id: "1",
                            link: "http://www.example.com",
                            owner: {
                                user_id: "1",
                                display_name: "Homer J."
                            }
                        }
                    }
                ]
            })).map(response => JSON.parse(response))
                .map(responseObj => {
                    if (responseObj.error) {
                        return {
                            items: [],
                            error: {
                                id: responseObj.error.error_id,
                                name: responseObj.error.name,
                                message: responseObj.error.message
                            }
                        };
                    } else {
                        return {
                            items: responseObj.items
                        };
                    }
                });
        }
    }
}
