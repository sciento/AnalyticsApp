﻿/// <reference path="../common/_reference.ts" />

namespace AnalyticsApp {
    "use strict";

    import Observable = Rx.Observable;
    import Statistics = AnalyticsApp.StatisticsService;

    declare var Chart: any;

    /*===============================================================================================================*/

    // TODO: this is only to check that angularjs was setup correctly

    class DashboardController {
        title: string;

        constructor() {
            this.title = "Dashboard";
        }
    }

    angular.module("dashboard")
        .controller("DashboardController", DashboardController);

    /*===============================================================================================================*/

    Observable.fromEvent<Event>(document, "DOMContentLoaded").subscribe(evt => {
        const canvas: HTMLCanvasElement = <HTMLCanvasElement>document.getElementById("exampleChart");
        const ctx: CanvasRenderingContext2D = <CanvasRenderingContext2D>canvas.getContext("2d");

        // TODO this is just example data
        Statistics.VisitStatistics.getAllByUserId("1").subscribe(x => console.log(x), e => console.error(e));

        Statistics.VisitStatistics.getByUserId("1", "2").subscribe(x => console.log(x), e => console.error(e));

        //Statistics.BrowserStatistics.getByUserId("1", "2").subscribe(x => console.log(x), e => console.error(e));

        //Statistics.OperatingSystemStatistics.getByUserId("1", "2").subscribe(x => console.log(x), e => console.error(e));

        Statistics.CountryStatistics.getByUserId("1", "2")
            .reduce((acc, data) => {
                acc.labels.push(data.country);
                acc.data.push(data.visits);

                const rgb = `rgba(${Math.round(Math.random() * 255)},${Math.round(Math.random() * 255)},${Math.round(Math.random() * 255)}`;
                acc.backgroundColors.push(`${rgb},0.2)`);
                acc.borderColors.push(`${rgb},1.0)`);

                return acc;
            }, {
                labels: [] as Array<string>,
                data: [] as Array<number>,
                backgroundColors: [] as Array<string>,
                borderColors: [] as Array<string>
            })
            .map(chartData => ({
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
            }))
            .subscribe(chartConfig => {
                console.log(chartConfig);
                const chart = new Chart(ctx, chartConfig);
            },
            e => console.error(e));
    });
}
