# AnalyticsApp
> __Projekt Arbeit__   
> HS Flensburg - VWW - 2016

###__Content__
- [TODO](#to-dos)
- [Routing Plan](#routing-plan-api)
- [Models](#models)
- [JSON-Response](#json-response)


##To-Dos

##Routing Plan __(API)__

| Method        | Route           | Info  |Permission|
|:-------------:|:-------------|:-----|:-------:|
|__Users__|-|-|-|
|`[POST]`| /users |Speichern eines Benutzers |_Public_|
|`[GET]`| /users/{id}|Persönliche Account Informationen|_Authorize_|
|`[DELETE]`|/users/{id}|Benutzer löschen|_Authorize_|
|`[PUT]`|/users/{id}|Ändern von Account Information|_Authorize_|
|__Sites__|-|-|-|
|`[POST]`|/users/sites/{id}|Hinzufügen einer Seite|_Authorize_|
|`[GET]`|/users/sites/{id}|Alle Seiten eines Benutzers|_Authorize_|
|`[GET]`|/users/sites/{id}/{pid}|Seite eines Benutzers|_Authorize_|
|`[PUT]`|/users/sites/{id}/{pid}|Änderung einer Seite|_Authorize_|
|`[DELETE]`|/users/sites/{id}/{pid}|Löschen einer Seite|_Authorize_|
|__Analyse File__|-|-|-|
|`[GET]`|/visit/{pid}|JavaScript Analyser File|_Public_|
|__Analyse__|-|-|-|
|`[POST]`|/visit/{uid}/{pid}|Eintrag eines Besuchs|_Public_|
|`[GET]`|/visit/{uid}|Gesamtanzahl Besucher aller Websites des Users|_Authorize_|
|`[GET]`|/visit/{uid}/{pid}|Gesamtanzahl Besucher einer Seite|_Authorize_|
|`[GET]`|/visit/{uid}/{pid}/{date}|Anzahl Besucher einer Seite an einem Tag|_Authorize_|
|`[GET]`|/visit/{uid}/{pid}/{week}|Anzahl Besucher einer Seite in einer Woche|_Authorize_|
|__Most Visit Data__|-|-|-|
|`[GET]`|/analyse/most/{uid}/{pid}|Meistbesuchte Seiten|_Authorize_|
|`[GET]`|/analyse/most/{uid}/{pid}/{date}|Meistbesuchte Seiten des Tages|_Authorize_|
|`[GET]`|/analyse/most/{uid}/{pid}/{week}|Meistbesuchte Seiten der Woche|_Authorize_|
|__Vists by Time__|-|-|-|
|`[GET]`|/analyse/time/{uid}/{pid}|Besucher Uhrzeit Gesamt|_Authorize_|
|`[GET]`|/analyse/time/{uid}/{pid}/{day}|Besucher Uhrzeit Tag|_Authorize_|
|`[GET]`|/analyse/time/{uid}/{pid}/{week}|Besucher Uhrzeit Woche|_Authorize_|
|__Others__|-|-|-|
|`[GET]`|/analyse/browser/{uid}/{pid}|Browser Statistik|_Authorize_|
|`[GET]`|/analyse/os/{uid}/{pid}|OS Statistik|_Authorize_|
|`[GET]`|/analyse/country/{uid}/{pid}|Länder Statistik|_Authorize_|
|`[GET]`|/analyse/referral/{uid}/{pid}|Aufruf Herkunft|_Authorize_|
____
##Models

###Users
| Name        | Type           | Info  |
|:-------------:|:-------------|:-----|
|__UserId__|_Guid_| User ID|
|__Email__|_string_| Benutzername|
|__Password__|_string_| Password Hash|

###Sites
| Name        | Type           | Info  |
|:-------------:|:-------------|:-----|
|__SiteId__|_Guid_| Site ID|
|__UserId__|_Guid_|User ID (Owner)|
|__Url__|_string_|Website URL|

###Visits
| Name        | Type           | Info  |
|:-------------:|:-------------|:-----|
|__VisitId__|_Guid_| Visit ID|
|__SiteId__|_Guid_| Site ID|
|__Ip__|_string_| Visitor IP-Adress|
|__Browser__|_string_| Visitor Browser|
|__PageUrl__|_string_|Page URL|
|__CallTime__|_DateTime_|Zeit Seitenaufruf|
|__ExitTime__|_DateTime_|Zeit Absprung|
|__Referral__|_string_|URL der vorher besuchten Seite|
|__Os__|_string_|Betriebssystem|

##JSON-Response

###Wrapper-Object
Allgemeines Wrapper-Object, welches bei jedem Response verwendet wird.
Die eigentlichen Nachrichten befinden sich in *items*. 
```json
{
    "items": [],
    "error": {
        "error_id": 0,
        "name": "",
        "message": ""
    }
}
```

###User
Informationen zu einem User.
```json
{
    "user_id": "",
    "display_name: ""
}
```

###Visit
Besuchsstatistik zu einer Seite.
```json
{
    "site": {
        "site_id": "",
        "link": "",
        "owner": {
            "user_id": "",
            "display_name": ""
        }
    },
    "call_time": "",
    "exit_time": ""
}
```

###Most-Visit
Meistbesuchte Seiten.
```json
{
    "site": {
        "site_id": "",
        "link": "",
        "owner": {
            "user_id": "",
            "display_name": ""
        }
    },
    "visits": 0
}
```

###Browser Statistics
Besucherstatistiken nach verwendeten Browser.
```json
{
    "name": "",
    "version": "",
    "user_agent": "",
    "language": "",
    "site": {
        "site_id": "",
        "link": "",
        "owner": {
            "user_id": "",
            "display_name": ""
        }
    },
    "visits": 0
}
```

###Operating System Statistics
Besucherstatistiken nach verwendeten Betriebssytem.
```json
{
    "name": "",
    "version": "",
    "site": {
        "site_id": "",
        "link": "",
        "owner": {
            "user_id": "",
            "display_name": ""
        }
    },
    "visits": 0
}
```

###Country Statistics
Besucherstatistiken einer Seite nach Länder.
```json
{
    "country": "",
    "site": {
        "site_id": "",
        "link": "",
        "owner": {
            "user_id": "",
            "display_name": ""
        }
    },
    "visits": 0
}
```

###Aufruf Herkunft Statisiken
Statistiken von welcher Seite die Besucher auf diese kamen.
```json
{
    "site": {
        "site_id": "",
        "link": "",
        "owner": {
            "user_id": "",
            "display_name": ""
        }
    },
    "previous_site": {
        "site_id": "",
        "link": "",
        "owner": {
            "user_id": "",
            "display_name": ""
        }
    },
    "count": 0
}
```
