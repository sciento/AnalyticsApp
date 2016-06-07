var AnalyticsApp;
(function (AnalyticsApp) {
    var StatisticsServices;
    (function (StatisticsServices) {
        var Observable = Rx.Observable;
        var Visits = (function () {
            function Visits() {
            }
            Visits.getAllByCountry = function (userId) {
                // TODO replace parameter of 'getContentOf' with actual server address
                return getContentOf("urlToService")
                    .flatMap(function (response) { return Observable.from(response.items); })
                    .map(function (dataObj) { return ({
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
                }); });
            };
            return Visits;
        }());
        StatisticsServices.Visits = Visits;
        var getContentOf = function (url) {
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
            })).map(function (response) { return JSON.parse(response); })
                .map(function (responseObj) {
                if (responseObj.error) {
                    return {
                        items: [],
                        error: {
                            id: responseObj.error.error_id,
                            name: responseObj.error.name,
                            message: responseObj.error.message
                        }
                    };
                }
                else {
                    return {
                        items: responseObj.items
                    };
                }
            });
        };
    })(StatisticsServices = AnalyticsApp.StatisticsServices || (AnalyticsApp.StatisticsServices = {}));
})(AnalyticsApp || (AnalyticsApp = {}));
//# sourceMappingURL=statisticsservices.js.map