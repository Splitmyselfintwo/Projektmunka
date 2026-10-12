-- Adatbázis létrehozása és kiválasztása
CREATE DATABASE IF NOT EXISTS vallasok_db CHARACTER SET utf8mb4 COLLATE utf8mb4_hungarian_ci;
USE vallasok_db;

-- Tábla létrehozása (megfelelő típusokkal és méretekkel, elsődleges kulccsal)
CREATE TABLE konfliktusok (
    id INT PRIMARY KEY,
    esemeny_neve VARCHAR(100) NOT NULL,
    vallas_neve VARCHAR(100) NOT NULL,
    aldozatok_szama BIGINT NOT NULL
);

-- Adatok feltöltése a táblába
INSERT INTO konfliktusok (id, esemeny_neve, vallas_neve, aldozatok_szama) VALUES
(1, 'Keresztes hadjaratok', 'Keresztenyseg', 3000000),
(2, 'Harminceves haboru', 'Keresztenyseg', 8000000),
(3, 'Aztek emberaldozatok', 'Aztek vallas', 1200000),
(4, 'Taiping-felkeles', 'Kereszteny-szinkretikus', 20000000),
(5, 'Francia vallashaboruk', 'Keresztenyseg', 3000000),
(6, 'Mughal hoditasok', 'Iszlam', 10000000),
(7, 'Sri Lanka-i polgarhaboru', 'Buddhizmus', 100000),
(8, 'Kalingai haboru', 'Hinduizmus', 250000),
(9, 'Guzsarati zavargasok', 'Hinduizmus', 2000),
(10, 'Rohingya uldoztetes', 'Buddhizmus', 25000);
