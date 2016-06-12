namespace AnalyticsApp {

    export namespace Model {

        export interface ApiResponse<T> {
            items: Array<T>;
            error?: Error;
        }
    }
}
