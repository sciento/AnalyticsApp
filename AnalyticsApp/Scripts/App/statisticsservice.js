var AnalyticsApp;
(function (AnalyticsApp) {
    var StatisticsService;
    (function (StatisticsService) {
        var Observable = Rx.Observable;
        (function (Order) {
            Order[Order["DESCENDING"] = 0] = "DESCENDING";
            Order[Order["ASCENDING"] = 1] = "ASCENDING";
        })(StatisticsService.Order || (StatisticsService.Order = {}));
        var Order = StatisticsService.Order;
        var defaultConfig = { order: Order.ASCENDING, sortBy: "visits" };
        var VisitStatistics = (function () {
            function VisitStatistics() {
            }
            VisitStatistics.getByUserId = function (userId, siteId, config) {
                if (config === void 0) { config = defaultConfig; }
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
            };
            VisitStatistics.getAllByUserId = function (userId, config) {
                if (config === void 0) { config = defaultConfig; }
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
            };
            return VisitStatistics;
        }());
        StatisticsService.VisitStatistics = VisitStatistics;
        var CountryStatistics = (function () {
            function CountryStatistics() {
            }
            CountryStatistics.getByUserId = function (userId, siteId, config) {
                if (config === void 0) { config = defaultConfig; }
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
            };
            CountryStatistics.getAllByUserId = function (userId, config) {
                if (config === void 0) { config = defaultConfig; }
                // TODO
                return Observable.empty();
            };
            return CountryStatistics;
        }());
        StatisticsService.CountryStatistics = CountryStatistics;
        var BrowserStatistics = (function () {
            function BrowserStatistics() {
            }
            BrowserStatistics.getByUserId = function (userId, config) {
                if (config === void 0) { config = defaultConfig; }
                // TODO
                return Observable.empty();
            };
            BrowserStatistics.getAllByUserId = function (userId, config) {
                if (config === void 0) { config = defaultConfig; }
                // TODO
                return Observable.empty();
            };
            return BrowserStatistics;
        }());
        StatisticsService.BrowserStatistics = BrowserStatistics;
        var OperatingSystemStatistics = (function () {
            function OperatingSystemStatistics() {
            }
            OperatingSystemStatistics.getByUserId = function (userId, config) {
                if (config === void 0) { config = defaultConfig; }
                // TODO
                return Observable.empty();
            };
            OperatingSystemStatistics.getAllByUserId = function (userId, config) {
                if (config === void 0) { config = defaultConfig; }
                // TODO
                return Observable.empty();
            };
            return OperatingSystemStatistics;
        }());
        StatisticsService.OperatingSystemStatistics = OperatingSystemStatistics;
        function getContentOf(url) {
            // TODO make http request to server to get the actual data; call observer#onError() in case of an error
            return Observable.empty();
        }
    })(StatisticsService = AnalyticsApp.StatisticsService || (AnalyticsApp.StatisticsService = {}));
})(AnalyticsApp || (AnalyticsApp = {}));
//# sourceMappingURL=statisticsservice.js.map