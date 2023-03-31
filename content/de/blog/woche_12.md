---
author: "Nadine Völkl"
title: "Woche 12"
date: 2023-02-06T12:00:00+01:00
lastmod: 2023-03-29T16:34:00+01:00
description: "Finale Schliffe und Abschlusspräsentation"
tags: ["Abschlusspräsentation"]
thumbnail: /img/woche_12/abschlusspräsentation.png
---

Da in dieser Woche die finale Vorstellung des Projektes anstand wurden am Projekt nur noch ein paar finale Schliffe gemacht und probeweise ein Proband gebeten den Parcour einmal zu machen.
Der Proband wurde natürlich nicht in die eigentliche Studie einbezogen.

Die Abschlusspräsentation wurde gehalten, bevor die Miniaturstudie durchgeführt wurde, weshalb das Logging erst nach der Abschlusspräsentation in das Projekt eingepflegt wurde.

![Seite 1](/img/woche_12/Abschlusspräsentation_1.png)
![Seite 2](/img/woche_12/Abschlusspräsentation_2.png)
![Seite 3](/img/woche_12/Abschlusspräsentation_3.png)
![Seite 4](/img/woche_12/Abschlusspräsentation_4.png)
![Seite 5](/img/woche_12/Abschlusspräsentation_5.png)
![Seite 6](/img/woche_12/Abschlusspräsentation_6.png)
![Seite 7](/img/woche_12/Abschlusspräsentation_7.png)
![Seite 8](/img/woche_12/Abschlusspräsentation_8.png)
![Seite 9](/img/woche_12/Abschlusspräsentation_9.png)
![Seite 10](/img/woche_12/Abschlusspräsentation_10.png)
![Seite 11](/img/woche_12/Abschlusspräsentation_11.png)
![Seite 12](/img/woche_12/Abschlusspräsentation_12.png)

Das Einbinden des Loggings war dank JSON sehr einfach möglich. Diese kleine Funktion wird aufgerufen, sobald die Handposten gespeichert werden. Sie generiert eine .txt Datei für jede\*n Probanden\*in. In dieser Textdatei befinden sich die Daten für die gespeicherten Handposen mit den dazugehörigen Bewegungsnamen.

![alt text](/img/woche_12/toJSON.png "Screenshot der SaveToFile() Methode aus der GestureDetector.cs.")

Die Studie bestand nur aus vier Participants, da sie nur im Rahmen des Seminars stattfinden sollte.
Den Studienteilnehmer\*innen wurde zu Beginn ein Fragebogen den sie ausfüllen sollten ausgeteilt. Am Ende der Studie erhielten sie erneut den Fragebogen. Beide Fragebögen wurden für die Auswertung verglichen.

![alt text](/img/woche_12/fragebogen.png "Fragebogen zur Studie. Wie gut kennst du dich mit Ratten aus? Findest du Ratten eher abstoßend oder ansprechend? Würdest du eine Ratte in die Hand nehmen? Wie viel Interesse hast du daran dich mit Ratten auseinander zu setzen? Wie viel Interesse hast du daran dir eine Ratte anzuschaffen?")

Es ergibt sich bereits bei der kleinen Gruppe aus zufällig gewählten Teilnehmer\*innen eine leicht positive Tendenz bezüglich dessen, ob die Teilnehmer\*innen eine Ratte anfassen würden und eine etwas stärkere positive Tendenz hinsichtlich des Wissens der Teilnehmer\*innen über Ratten.

![alt text](/img/woche_12/auswertung.png "Auswertung der Studie. Interesse der Teilnehmenden sich eine Ratte anzuschaffen oder eine Ratte in die Hand zu nehmen: 4 von 4 gleichgeblieben. Interesse sich mit Ratten auseinander zu setzen: 1 mehr, 1 gleichgeblieben, 2 weniger. Empfinden, ob Ratten eher abstoßend oder ansprechend sind: 1 mehr Richtung ansprechend, 3 gleichgeblieben. Kenntnisse über Ratten: 2 gesteigert, 1 gleichgeblieben, 1 verschlechtert.")

Aus der Auswertung wird erkenntlich, dass zwei von vier Teilnehmenden sich nun besser mit Ratten auskennen, wohingegen eine Person ihr Wissen nicht verändert hat und eine Person das Empfinden hat, das Wissen wäre schlechter als zuvor eingeschätzt.
Ebenfalls lässt sich erkennen, dass eine Person Ratten nun eher ansprechend findet und sich bei drei Personen das Empfinden gegenüber Ratten nicht verändert hat.
Es lässt sich also vermuten, dass das Spiel Menschen helfen könnte, ihre Abneigung gegenüber Ratten nach und nach etwas abzulegen. 
Ein wesentlicher Unterschied zu einer Begegnung in der "realen Welt" ist vorallem die Möglichkeit, die Ratte zu steuern und sie somit von sich fernhalten zu können.