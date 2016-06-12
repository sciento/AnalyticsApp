/// <reference path="./Common/_reference.ts" />
var AnalyticsApp;
(function (AnalyticsApp) {
    "use strict";
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
                return getContentOf("/api/visits/" + userId + "/" + siteId, function (o) { return ({
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
                }); });
            };
            VisitStatistics.getAllByUserId = function (userId, config) {
                if (config === void 0) { config = defaultConfig; }
                return getContentOf("/api/visits/" + userId, function (o) { return ({
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
                }); });
            };
            return VisitStatistics;
        }());
        StatisticsService.VisitStatistics = VisitStatistics;
        var CountryStatistics = (function () {
            function CountryStatistics() {
            }
            CountryStatistics.getByUserId = function (userId, siteId, config) {
                if (config === void 0) { config = defaultConfig; }
                return getContentOf("/api/countries/" + userId + "/" + siteId, function (o) { return ({
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
                }); });
            };
            return CountryStatistics;
        }());
        StatisticsService.CountryStatistics = CountryStatistics;
        var BrowserStatistics = (function () {
            function BrowserStatistics() {
            }
            BrowserStatistics.getByUserId = function (userId, siteId, config) {
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
            OperatingSystemStatistics.getByUserId = function (userId, siteId, config) {
                if (config === void 0) { config = defaultConfig; }
                // TODO
                return Observable.empty();
            };
            return OperatingSystemStatistics;
        }());
        StatisticsService.OperatingSystemStatistics = OperatingSystemStatistics;
        function getContentOf(uri, transformer) {
            return Observable.create(function (subscriber) {
                fetch(uri)
                    .then(function (response) { return response.json(); })
                    .then(function (jsonResponse) {
                    if (jsonResponse.error) {
                        subscriber.onError(new Error(jsonResponse.error.message));
                    }
                    else {
                        subscriber.onNext(jsonResponse);
                        subscriber.onCompleted();
                    }
                })
                    .catch(function (e) { return subscriber.onError(new Error(e)); });
            }).flatMap(function (jsonResponse) { return Observable.from(jsonResponse.items); })
                .map(transformer);
        }
    })(StatisticsService = AnalyticsApp.StatisticsService || (AnalyticsApp.StatisticsService = {}));
})(AnalyticsApp || (AnalyticsApp = {}));
//# sourceMappingURL=statisticsservice.js.map