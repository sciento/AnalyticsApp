﻿namespace AnalyticsApp {

    export namespace Model {

        export interface Site {
            id: string;
            title: string;
            link: string;
            owner: { userId: string, displayName: string };
        }
    }
}
