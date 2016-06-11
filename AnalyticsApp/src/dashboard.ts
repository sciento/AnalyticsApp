namespace AnalyticsApp {
    import Observable = Rx.Observable;
    import Statistics = AnalyticsApp.StatisticsService;

    declare var Chart: any;

    Observable.fromEvent(document, "DOMContentLoaded").subscribe(evt => {
        const canvas: HTMLCanvasElement = <HTMLCanvasElement>document.getElementById("exampleChart");
        const ctx: CanvasRenderingContext2D = <CanvasRenderingContext2D>canvas.getContext("2d");

        // TODO this is just example data
        Statistics.CountryStatistics.getByUserId("USER_1", "SITE_2")
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
            e => console.log(e));
    });
}
