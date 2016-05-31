# AnalyticsApp

##Routing Plan

| Method        | Route           | Info  |Permission|
|:-------------:|:-------------|:-----|:-------:|
|__Users__|-|-|-|
|[POST]| url/users |Speichern eines Benutzers |_Public_|
|[GET]| url/users/{id}|Persönliche Account Informationen|_Authorize_|
|[DELETE]|url/users/{id}|Benutzer Löschen|_Authorize_|
|[PUT]|url/users/{id}|Ändern von Account Information|_Authorize_|
|__Pages__|-|-|-|
|[POST]|url/users/{id}/pages|Hinzufügen einer Seite|_Authorize_|
|[GET]|url/users/{id}/pages|Seiten eines Benutzers|_Authorize_|
|[GET]|url/users{id}/pages/{pid}|Seite eines Benutzers|_Authorize_|
|[PUT]|url/users{id}/pages/{pid}|Änderung einer Seite|_Authorize_|
|[DELETE]|url/users/{id}/pages/{pid}|Löschen einer Seite|_Authorize_|
|__Analyse File__|-|-|-|
|[GET]|url/analyse/{pid}|JavaScript Analyser File|_Public_|
|__Visit Entry__|-|-|-|
|[POST]|url/{uid}/{pid}/visits|Eintrag eines Besuchs|_Public_|
|__Analyse Data__|-|-|-|
|[GET]|url/{uid}/{pid}/visitor|Gesamt Besucher|_Authorize_|
|[GET]|url/{uid}/{pid}/visitor/{date}|Besucher eines Tages|_Authorize_|
|[GET]|url/{uid}/{pid}/visitor/{week}|Besucher einer Woche|_Authorize_|
|__Most Visit Data__|-|-|-|
|[GET]|url/{uid}/{pid}/mostvisit|Meistbesuchten Seite|_Authorize_|
|[GET]|url/{uid}/{pid}/mostvisit/{date}|Meistbesuchten Seiten des Tages|_Authorize_|
|[GET]|url/{uid}/{pid}/mostvisit/{week}|Meistbesuchten Seiten der Woche|_Authorize_|
|__Vists by Time__|-|-|-|
|[GET]|url/{uid}/{pid}/visittime|Besucher Uhrzeit Gesamt|_Authorize_|
|[GET]|url/{uid}/{pid}/visittime/{day}|Besucher Uhrzeit Tag|_Authorize_|
|[GET]|url/{uid}/{pid}/visittime/{week}|Besucher Woche|_Authorize_|
|__Vists by Time__|-|-|-|
|[GET]|url/{uid}/{pid}/browser|Browser Statistik|_Authorize_|
|[GET]|url/{uid}/{pid}/os|OS Statistik|_Authorize_|
|[GET]|url/{uid}/{pid}/country|Länder Statistik|_Authorize_|
|[GET]|url/{uid}/{pid}/referral|Aufruf Herkunft|_Authorize_|
____
##Models

| Name        | Type           | Info  |
|:-------------:|:-------------|:-----|:-------:|
|||||
