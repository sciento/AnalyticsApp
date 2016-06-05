declare var Chart: any;

Rx.Observable.fromEvent(document, "DOMContentLoaded").subscribe(evt => {
    console.log("Hello from dashboard.ts");

    const canvas = <HTMLCanvasElement>document.getElementById("exampleChart");
    const ctx = <CanvasRenderingContext2D>canvas.getContext("2d");

    const visitsByCountryChart = new Chart(ctx, {
        type: "horizontalBar",
        data: {
            labels: ["Australia", "Austria", "Germany", "Italy", "USA"],
            datasets: [{
                label: "Visits by Country",
                data: [230, 210, 310, 280, 370],
                backgroundColor: [
                    'rgba(255, 99, 132, 0.2)',
                    'rgba(54, 162, 235, 0.2)',
                    'rgba(255, 206, 86, 0.2)',
                    'rgba(75, 192, 192, 0.2)',
                    'rgba(153, 102, 255, 0.2)',
                ],
                borderColor: [
                    'rgba(255,99,132,1)',
                    'rgba(54, 162, 235, 1)',
                    'rgba(255, 206, 86, 1)',
                    'rgba(75, 192, 192, 1)',
                    'rgba(153, 102, 255, 1)',
                ],
                borderWidth: 1
            }]
        },
        options: {
            scales: {
                yAxes: [{
                    ticks: {
                        beginAtZero: true
                    }
                }]
            }
        }
    });
});
