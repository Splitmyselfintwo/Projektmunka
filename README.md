# IKT Projekt - Vallási Konfliktusok és Áldozatok

Projektfeladat a 12.C és 12.D osztályok számára.
**Tárgyak:** Asztali alkalmazások, Adatbázis-kezelés és IKT projekt

## Csapat tagjai és szerepkörök
* **Szigeti Patrik** – Adatbázis (XAMPP, MySQL)
* **Nagy Zoltán** – Dokumentáció (Word, Trello)
* **Kiss Attila** – Programozás (C# konzolos alkalmazás)

## A feladat leírása
Csoportban készült projektfeladat, amely egy C# konzolos alkalmazást és egy egytáblás MySQL adatbázist tartalmaz. A program egy `.txt` állomány adatait olvassa be, egy saját objektumosztály (`VallasKonfliktus`) segítségével memóriában tárolja azokat, majd a képernyőre írja és összegzi a vizsgált konfliktusok áldozatainak számát.

## Használt technológiák
* **C# (.NET):** Objektumorientált konzolos alkalmazás
* **MySQL (XAMPP / phpMyAdmin):** Adatbázis és adattárolás
* **Git & GitHub:** Verziókövetés és publikáció
* **Trello:** Munkafolyamatok és feladatok követése

## Futtatás lépései
1. A XAMPP elindítása után a phpMyAdmin felületen (SQL fül) futtasd le a repóban található SQL kódot az adatbázis és a tábla létrehozásához.
2. Nyisd meg a C# projektet a Visual Studio segítségével.
3. Győződj meg róla, hogy az `adatok.txt` fájl a lefordított végrehajtható fájl (`.exe`) mellett, a `bin/Debug` (vagy `bin/Debug/net...`) mappában található.
4. Futtasd a programot.
