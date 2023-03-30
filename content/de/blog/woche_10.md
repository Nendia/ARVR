---
author: "Nadine Völkl"
title: "Woche 10"
date: 2023-01-25T12:00:00+01:00
lastmod: 2023-03-27T18:57:00+01:00
description: "Umzug in Git und Finalisierung der Posenerkennung"
tags: ["Umzug in Git, Posenerkennung, Rattenmodelsuche"]
thumbnail: #/img/woche_1/vr_ar_setup.png
---

Dank der Vorlesung ist mir nun bewusst: Haptisches Feedback in VR wird in die Bereiche activ haptics, passive haptics und pseudo haptics aufgesplittet. Zusätzlich wurden die Themen Tracking Devices und Interaction Techniques erneut aufgegriffen. 

Für mein Projekt musste zuerst noch eine passende Ratte gefunden werden. Hierbei wurde der Fokus darauf gelegt, diese Ratte nicht noch animieren, bzw. riggen zu müssen. Nach längerer Recherche fand sich folgende Ratte:

{{< rawhtml >}} 

<video controls>
    <source src="/img/woche_10/rat_pr_1.mp4" type="video/mp4">
    Your browser does not support the video tag.  
</video>

<video controls>
    <source src="/img/woche_10/rat_pr_2.mp4" type="video/mp4">
    Your browser does not support the video tag.  
</video>

{{< /rawhtml >}}

[Animierte Ratte auf renderhub.com](https://www.renderhub.com/mikserart/rat-12-animations-game-ready-props-low-poly-3d-model)

Das tollste: Sie kam direkt mit Animationen und war komplett gerigged. 
Ein Nachteil der Animationen war allerdings, dass die Ratte diese Animationen nicht auf der Stelle macht, sondern sich das Model tatsächlich bewegt, also die Position in Unity verändert wird. Hierauf musste geachtet werden, sobald es an die Bewegung der Ratte in VR ging.

Einen Tag später waren dann auch alle Animationen geschnitten und passend benannt. 

![alt text](/img/woche_10/animationen.png "Screenshot aller Animationen im Explorer")

Der nächste Schritt war, die Ratte "auf Befehle horchen zu lassen". 
Sofern der GestureDetector die Handposition für "Laufen" erkennt sollte also die Animation für "Laufen" abgespielt werden. Das gleiche gilt für "Mach Männchen", "Aufheben", "Links drehen", "Rechts drehen", "Such".

{{< rawhtml >}} 

<ul>
<li>"Laufen" bewegte die Ratte nach vorne, bis die Handpose geändert wurde. </li>
<li>"nach Links drehen" lässt die Ratte einen Bogen nach links laufen.</li> 
<li>"nach Rechts drehen" macht das selbe nach rechts. </li>
<li>"Such" lässt die Ratte nach der nächsten Münze suchen und, falls eine in der Nähe ist, zu dieser laufen. </li>
<li>"Mach Männchen" lässt sie auf die Hinterbeine gehen und diese Münze aufheben. </li>
<li>"Aufheben" wird lediglich für die Interaction Tasks benötigt. Damit wird dann das T aufgehoben und mit der Drehung der Hand in die richtige Position gedreht. </li>
</ul>

{{< /rawhtml >}} 

![alt text](/img/woche_10/switchCase.png "Screenshot des switch-case das unten beschrieben wird")

Laufen, sowie links und rechts drehen waren recht schnell implementiert. Zu diesem Zeitpunkt war alles noch mit einem if-else modelliert, dies wurde später allerdings in ein switch-case geändert, um die Übersichtlichkeit zu wahren. Alle drei Befehle rufen die gleiche Funktion auf, mit dem einzigen Unterschied, dass eine Rotationsvariable verändert übergeben wird. 

![alt text](/img/woche_10/bewegung.png "Screenshot der oben beschriebenen Funktion Bewegung")

"Such" wurde mit Hilfe von weiteren Collidern, welche sich an den Münzen befinden, umgesetzt. Sofern die Ratte mit ihrem Collider die Münze und deren Collider trifft, wird die Münze in die Liste coinpositions hinzugefügt. 

![alt text](/img/woche_10/findNearestCoin_script.png "Screenshot der unten beschriebenen Funktion findNearestCoin")

Die Funktion "findNearestCoin" kontrolliert dann, ob in der Liste eine Münze existiert und gibt die Position der Münze mit der kürzesten Distanz zur Ratte zurück. Dieser Rückgabewert ist dann die Position an die die Ratte bewegt wird. "Mach Männchen" setzt die Münze dann auf inaktiv und zählt den Counter hoch.
"Aufheben" sollte ein komplexeres Thema werden und wurde zuerst einmal auf der ToDo Liste weiter nach unten gesetzt.

![alt text](/img/woche_10/such.png "Ratte in VR, die unter einem Stück Käse auf allen Vieren steht.")

Da das Spiel ja als Lernspiel gedacht war, wurde die spontane Idee, die Münzen durch Käse zu ersetzen umgesetzt und erweitert. Die Münzen wurden also alle in Käsestücke umgewandelt und an Stelle der Münzen befinden sich nun Textboxen mit Rattenfakten. Diese tauchen auf, sobald der dazugehörige Käse "gegessen" wurde. Um anschließend die Tipps im Spiel wiederfinden zu können wurden aus den Käsestücke Käseleiber. Sobald die Ratte den Käseleib "gefressen" hatte wurde er ausgeblendet und stattdessen ein Käsestück eingeblendet. Damit wurde nach dem Belohnungsprinzip gearbeitet und die Teilnehmer\*innen, bzw. Spieler\*innen werden mit Fakten "belohnt", wenn sie die Ratte dazu bringen den Käse zu essen. 

![alt text](/img/woche_10/machMännchen_script.png "Screenshot der oben beschriebenen Funktion machMännchen")

![alt text](/img/woche_10/machMännchen.png "Ratte in VR, die unter einer Textbox auf den Hinterbeinen steht.")
