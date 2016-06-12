namespace AnalyticsApp {

    export namespace Model {

        export interface OperatingSystemStatistic {
            name: string;
            version: string;
            site: Site;
            visits: number;
        }
    }
}
