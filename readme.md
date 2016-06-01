# AnalyticsApp
> __Projekt Arbeit__   
> HS Flensburg - VWW - 2016

###__Content__
- [Routing Plan](#routing-plan-api)
- [Models](#models)
- [Models](#to-dos)


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
|`[POST]`|/users/{id}/sites|Hinzufügen einer Seite|_Authorize_|
|`[GET]`|/users/{id}/sites|Alle Seiten eines Benutzers|_Authorize_|
|`[GET]`|/users/{id}/sites/{pid}|Seite eines Benutzers|_Authorize_|
|`[PUT]`|/users/{id}/sites/{pid}|Änderung einer Seite|_Authorize_|
|`[DELETE]`|/users/{id}/sites/{pid}|Löschen einer Seite|_Authorize_|
|__Analyse File__|-|-|-|
|`[GET]`|/analyse/{pid}|JavaScript Analyser File|_Public_|
|__Visit Entry__|-|-|-|
|`[POST]`|/{uid}/{pid}/visits|Eintrag eines Besuchs|_Public_|
|__Analyse Data__|-|-|-|
|`[GET]`|/{uid}/{pid}/visitor|Gesamtanzahl Besucher einer Seite|_Authorize_|
|`[GET]`|/{uid}/{pid}/visitor/{date}|Anzahl Besucher einer Seite an einem Tag|_Authorize_|
|`[GET]`|/{uid}/{pid}/visitor/{week}|Anzahl Besucher einer Seite in einer Woche|_Authorize_|
|__Most Visit Data__|-|-|-|
|`[GET]`|/{uid}/{pid}/mostvisit|Meistbesuchte Seiten|_Authorize_|
|`[GET]`|/{uid}/{pid}/mostvisit/{date}|Meistbesuchte Seiten des Tages|_Authorize_|
|`[GET]`|/{uid}/{pid}/mostvisit/{week}|Meistbesuchte Seiten der Woche|_Authorize_|
|__Vists by Time__|-|-|-|
|`[GET]`|/{uid}/{pid}/visittime|Besucher Uhrzeit Gesamt|_Authorize_|
|`[GET]`|/{uid}/{pid}/visittime/{day}|Besucher Uhrzeit Tag|_Authorize_|
|`[GET]`|/{uid}/{pid}/visittime/{week}|Besucher Uhrzeit Woche|_Authorize_|
|__Others__|-|-|-|
|`[GET]`|/{uid}/{pid}/browser|Browser Statistik|_Authorize_|
|`[GET]`|/{uid}/{pid}/os|OS Statistik|_Authorize_|
|`[GET]`|/{uid}/{pid}/country|Länder Statistik|_Authorize_|
|`[GET]`|/{uid}/{pid}/referral|Aufruf Herkunft|_Authorize_|
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

