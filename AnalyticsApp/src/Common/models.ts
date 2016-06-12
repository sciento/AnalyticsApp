/// <reference path="./_reference.ts" />

namespace AnalyticsApp {
        export interface AuthRequest {
            username: string;
            secret: string;
        }
        export interface ApiResponse<T> {
            items: Array<T>;
            error?: Error;
        }
      
} 