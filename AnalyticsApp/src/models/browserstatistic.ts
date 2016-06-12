namespace AnalyticsApp {

    export namespace Model {

        export interface BrowserStatistic {
            name: string;
            version: string;
            userAgent: string;
            language: string;
            site: Site;
            visits: number;
        }
    }
}
