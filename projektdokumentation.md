# LA_1100
# Projekt-Dokumentation


Eisenring Damian

| Datum | Version | Zusammenfassung                                              |
| ----- | ------- | ------------------------------------------------------------ |
| 01.09.2022 | 0.0.1   |Es wird jetzt eine Zahl generiert und der User kann sie erraten mit Hilfe von Higher und Lower.|
| 08.09.2022| 1.0.01  | Falsche Eingaben werden jetzt erkannt und die Zahlen sind nun auch begrenzt. |
| 08.09.2022| 1.0.02   |Die Fehlermeldungen haben nun Farbe das sie erkannt werden|
| 08.09l2022| 2.0.01 | Das Programm hat nun ein Menu und man kann nun zwischen spielen, Spielregeln und Exit entscheiden.|

## 1 Informieren

### 1.1 Ihr Projekt

Ich programmiere ein Nummerratespiel mit C#

### 1.2 User Stories

| US-№ | Verbindlichkeit | Typ  | Beschreibung                       |
| ---- | --------------- | ---- | ---------------------------------- |
| 1    |  Muss             |   Funktional  | Als ein Benutzer möchte ich eine Zahl erraten können, damit ich die Zahl erraten kann, muss eine Zahl generiert werden. |
| 2 |  Muss               |  Funktional    | Als ein Benutzer möchte ich eine Zahl eingeben können, damit ich die Zahl erraten kann. |
| 3 | Kann     | Qualität | Als ein Benutzer möchte ich Hilfe bekommen nach der ersten Raterunde, damit ich die Zahl früher heraus finden kann. |
| 4 | Kann | Qualität | Als ein Benutzer möchte ich wissen wie viele Versuche ich gebraucht habe, damit ich mich immer steigern kann. |
| 5 | Muss | Funktional | Als ein Computer möchte ich Fehlereingaben erkennen können, damit ich Ihm das Anzeigen kann. |
| 6 | Kann | Qualitätsanforderung| Als ein Benutzer möchte ich Hilfe bekommen bei der Erkennung von Nachrichten, damit ich weiss ob es eine Fehlermeldung ist oder etwas anderes.|
| 7 | Kann | Qualitätsanforderung| Als ein Benutzer möchte ich ein Menu haben, damit ich mich besser Orientieren kann im Programm.|
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
| 1.A  | 02.09.2022| Damian | Ich werde Programmieren, dass eine Zahl generiert wird und diese erratet werden kann  | 2x 45min |
| 1.B  | 02.09.2022| Damian | Ich programmiere, dass der User einen Input immer wieder machen kann  | 2x 45min |
| 2.A |  09.09.2022  | Damian | US 5 |   3x 45min |
| 3.A |  18.09.2022 | Damian | US 3 | 2x 45min |
| 4.A |  27.09.2022 | Damian | US 6, 4| 6x 45min |
Total: 12x 45min



## 3 Entscheiden

✍️ Dokumentieren Sie hier Ihre Entscheidungen und Annahmen, die Sie im Bezug auf Ihre User Stories und die Implementierung getroffen haben.

## 4 Realisieren

| AP-№ | Datum | Zuständig | geplante Zeit | tatsächliche Zeit |
| ---- | ----- | --------- | ------------- | ----------------- |
| 1.A  |  01.09.2022     | Damian Eisenring | 2x 45min    |  2x 45min |
| 1.B |  01.09.2022     | Damian Eisenring | 2x 45min    |   45min |
| 2.A  |  08.09.2022     | Damian Eisenring | 4x 45min    |  3x 45min |

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
