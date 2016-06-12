/// <reference path="./Common/_reference.ts" />
var AnalyticsApp;
(function (AnalyticsApp) {
    var Observable = Rx.Observable;
    var Statistics = AnalyticsApp.StatisticsService;
    Observable.fromEvent(document, "DOMContentLoaded").subscribe(function (evt) {
        var canvas = document.getElementById("exampleChart");
        var ctx = canvas.getContext("2d");
        // TODO this is just example data
        Statistics.VisitStatistics.getAllByUserId(1).subscribe(function (x) { return console.log(x); }, function (e) { return console.log(e); });
        Statistics.VisitStatistics.getByUserId(1, 2).subscribe(function (x) { return console.log(x); }, function (e) { return console.log(e); });
        Statistics.CountryStatistics.getByUserId(1, 2)
            .reduce(function (acc, data) {
            acc.labels.push(data.country);
            acc.data.push(data.visits);
            var rgb = "rgba(" + Math.round(Math.random() * 255) + "," + Math.round(Math.random() * 255) + "," + Math.round(Math.random() * 255);
            acc.backgroundColors.push(rgb + ",0.2)");
            acc.borderColors.push(rgb + ",1.0)");
            return acc;
        }, {
            labels: [],
            data: [],
            backgroundColors: [],
            borderColors: []
        })
            .map(function (chartData) { return ({
            type: "horizontalBar",
            data: {
                labels: chartData.labels,
                datasets: [{
                        label: "Visits By Country",
                        data: chartData.data,
                        backgroundColor: chartData.backgroundColors,
                        borderColor: chartData.borderColors,
                        borderWidth: 1
                    }]
            },
            options: {
                scales: {
                    xAxes: [{
                            ticks: {
                                beginAtZero: true
                            }
                        }]
                }
            }
        }); })
            .subscribe(function (chartConfig) {
            console.log(chartConfig);
            var chart = new Chart(ctx, chartConfig);
        }, function (e) { return console.log(e); });
    });
})(AnalyticsApp || (AnalyticsApp = {}));
//# sourceMappingURL=dashboard.js.map