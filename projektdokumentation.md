# LA_1100
# Projekt-Dokumentation


Eisenring Damian

| Datum | Version | Zusammenfassung                                              |
| ----- | ------- | ------------------------------------------------------------ |
|       | 0.0.1   |  |
|       | ...     |                                                              |
|       | 1.0.0   |                                                              |

## 1 Informieren

### 1.1 Ihr Projekt

Ich programmiere ein Nummererratespiel mit C#

### 1.2 User Stories

| US-№ | Verbindlichkeit | Typ  | Beschreibung                       |
| ---- | --------------- | ---- | ---------------------------------- |
| 1    |  Muss             |   Funktional  | Als ein Benutzer möchte ich eine Zahl erraten können, damit ich die Zahl erraten kann, muss eine Zahl generiert werden. |
| 2 |  Muss               |  Funktional    | Als ein Benutzer möchte ich eine Zahl eingeben können, damit ich die Zahl erraten kann. |
| 3 | Kann     | Qualität | Als ein Benutzer möchte ich Hilfe bekommen nach der ersten Raterunde, damit ich die Zahl früher heraus finden kann. |
| 4 | Kann | Qualität | Als ein Benutzer möchte ich wissen wie viele Versuche ich gebraucht habe, damit ich mich immer steigern kann. |
| 5 | Muss | Funktional | Als ein Computer möchte ich Fehlereingaben erkennen können, damit ich Ihm das Anzeigen kann. |
| 6 | Kann | Qualitätsanforderung| Als ein Benutzer möchte ich einen Fehler erkennen, damit ich weiss obs Higher (z.b Grün) ist.|
.

### 1.3 Testfälle

| TC-№ | Ausgangslage | Eingabe | Erwartete Ausgabe |
| ---- | ------------ | ------- | ----------------- |
| 1.1  | Zahl wird generiert   |  Zahl eingabe      |   Zahl ausgabe  |
| 2.1  | Zahl eingegeben (weite verkürzt)      |  Zahl  | Resultat    |
| 3.1  |  Zahl wird generiert | 80 |  Zahl ist zu gross |
| 3.2  |  Zahl wird generiert |   15 |  Zahl ist zu klein |
| 4.1  |  Zahl wird erraten | 50 (X) | Anzahl Versuche(Y): Y  |
| 5.1  | Programm startet| sechsunddreissig |  Ist keine Zahl!  |
| 6.1  | Zahl wird generiert  | 50   |  Die Zahl ist zu gross/klein, versuche es grösser/kleiner  |
| 7.1  | Zahl wurde erraten |   35   | Gratuliere du hast es geschafft!(in Grün)|
| ...  |              |         |                   |



### 1.4 Diagramme

![image](https://user-images.githubusercontent.com/111045919/186596842-b41ee525-90b4-4de9-9e11-b18a800f7875.png)


## 2 Planen

| AP-№ | Frist | Zuständig | Beschreibung | geplante Zeit |
| ---- | ----- | --------- | ------------ | ------------- |
| 1.A  | 02.09.2022| Damian | US 1, 2  | 4x 45min |
| 2.A |  09.09.2022  | Damian | US 5 |   3x 45min |
| 3.A |  18.09.2022 | Damian | US 3 | 2x 45min |
| 4.A |  27.09.2022 | Damian | US 6, 4| 6x 45min |
Total: 12x 45min

✍️ Die Nummer hat das Format `N.m`, wobei `N` die Nummer der User Story ist, auf die sich das Arbeitspaket bezieht, und `m` von `A` an nach oben buchstabiert. Beispiel: Das dritte Arbeitspaket, das die zweite User Story betrifft, hat also die Nummer `2.C`.

✍️ Ein Arbeitspaket sollte etwa 45' für eine Person in Anspruch nehmen. Die totale Anzahl Arbeitspakete sollte etwa Folgendem entsprechen: `Anzahl R-Sitzungen` ╳ `Anzahl Gruppenmitglieder` ╳ `4`. Wenn Sie also zu dritt an einem Projekt arbeiten, für welches zwei R-Sitzungen geplant sind, sollten Sie auf `2` ╳ `3` ╳`4` = `24` Arbeitspakete kommen. Sollten Sie merken, dass Sie hier nicht genügend Arbeitspakte haben, denken Sie sich weitere "Kann"-User Stories für Kapitel 1.2 aus.

## 3 Entscheiden

✍️ Dokumentieren Sie hier Ihre Entscheidungen und Annahmen, die Sie im Bezug auf Ihre User Stories und die Implementierung getroffen haben.

## 4 Realisieren

| AP-№ | Datum | Zuständig | geplante Zeit | tatsächliche Zeit |
| ---- | ----- | --------- | ------------- | ----------------- |
| 1.A  |       |           |               |                   |
| ...  |       |           |               |                   |

✍️ Tragen Sie jedes Mal, wenn Sie ein Arbeitspaket abschließen, hier ein, wie lang Sie effektiv dafür hatten.

## 5 Kontrollieren

### 5.1 Testprotokoll

| TC-№ | Datum | Resultat | Tester |
| ---- | ----- | -------- | ------ |
| 1.1  |       |          |        |
| ...  |       |          |        |

✍️ Vergessen Sie nicht, ein Fazit hinzuzufügen, welches das Test-Ergebnis einordnet.

### 5.2 Exploratives Testen

| BR-№ | Ausgangslage | Eingabe | Erwartete Ausgabe | Tatsächliche Ausgabe |
| ---- | ------------ | ------- | ----------------- | -------------------- |
| I    |              |         |                   |                      |
| ...  |              |         |                   |                      |

✍️ Verwenden Sie römische Ziffern für Ihre Bug Reports, also I, II, III, IV etc.

## 6 Auswerten

✍️ Fügen Sie hier eine Verknüpfung zu Ihrem Lern-Bericht ein.
