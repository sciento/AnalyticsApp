Rx.Observable.fromEvent(document, "DOMContentLoaded").subscribe(evt => {
    console.log("Hello from dashboard.ts");
});