---
author: "Nadine Völkl"
title: "Woche 9"
date: 2022-12-31T18:00:00+01:00
lastmod: 2023-03-27T18:07:00+01:00
description: "Parcourumbau und Gestenerkennung"
tags: ["Parcourumbau, Gestenerkennung, Posenerkennung"]
thumbnail: #/img/woche_1/vr_ar_setup.png
---

Hauptthemen dieser Woche waren Presence und Perception in VR. Fokus lag hierbei darauf, wieso Perception in VR wichtig ist, als auch welche Faktoren Perception beeinflusst und wie man diese messen kann.

Nachdem in der letzten Woche Feedback zur Projektidee eingeholt wurde, konnte ich nun endlich mit dem Projekt starten.
Step 1 war es, die Vorlage des Parcours in Unity zu laden und diese auf die passende Größe anzupassen. 
Da meine Projektidee darauf basiert, dass man nicht selbst die Spielfigur darstellt, sondern die eigentliche Figur per Gesten steuert benötigte ich einen Parcour der auf Rattengröße geschrumpft ist. Mit dem Wissen, das ich mir in den folgenden Wochen aneignen sollte, wäre diese Aufgabe innerhalb von kürzester Zeit gelöst gewesen. Da ich zu diesem Zeitpunkt allerdings noch nicht viel mit Unity gearbeitet hatte, nahm dieser Umbau einen kompletten Arbeitstag in Anspruch (und sollte zu einem späteren Zeitpunkt erneut wiederholt werden).

![alt text](/img/woche_9/parcour.png "Ein Parcour in Form einer Straße die ringförmig verläuft. Auf der einen Seite läuft sie in S-Linien entlang, auf der anderen in einer geraden Linie. Sie befindet sich auf einer grünen Fläche mit einem Fluss und mehreren Gebäuden.")

Step 2 beinhaltete den komplexesten Teil des Projekts - die Gestenerkennung. Hierbei hangelte ich mich zuerst an diversen Tutorials entlang. Trotz der Tutorials dauerte es mehrere Tage, bis ich eine funktionierende Posenerkennung hatte. Aus der geplanten Gestenerkennung wurde aufgrund der Umsetzbarkeit eine Posenerkennung, die keine Bewegungen beinhaltet, sondern nur die Pose der Hand zu einem bestimmten Zeitpunkt speichert. Die Posenerkennung funktionierte anschließend zwar und Unity gab mir in der Konsole Text aus, sofern es eine Handpose erkannt hatte, mit dieser erkannten Pose eine virtuelle Ratte zu bewegen sollte allerdings noch ein sehr langer Weg sein. 

[Hand Tracking Gesture Detection - Unity Oculus Quest Tutorial von Valem](https://www.youtube.com/watch?v=lBzwUKQ3tbw)
[HAND TRACKING with the Oculus Quest - Unity Tutorial von Valem](https://www.youtube.com/watch?v=vSia7t_WlbQ&list=PLrk7hDwk64-Y7ELKfkw8ox8TaT9y3gNpS&index=11)
[Modified Gesture Detector for Hand Tracking - Unity - Oculus Quest von TotallyNotDevs](https://www.youtube.com/watch?v=TjBIEOFiqoI)

Die auskommentierten Zeilen sind die ursprüngliche Gestenerkennung aus den oben genannten Tutorials. Hieran lässt sich auch erkennen, wie viel von mir angepasst werden musste, um mein Projekt funktionsfähig zu bekommen.

![alt text](/img/woche_9/gestureDetector.png "Screenshot der Datei 'GestureDetector.cs'")
[GestureDetector](/img/woche_9/GestureDetector.cs ':include')

