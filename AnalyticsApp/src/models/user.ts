namespace AnalyticsApp {

    export namespace Model {

        export interface User {
            id: string;
            displayName: string;
            sites?: Array<string>;
        }
    }
}
