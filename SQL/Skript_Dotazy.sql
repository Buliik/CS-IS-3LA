/*1;1;4;Výpis zákazníkù */
SELECT idZak, Jmeno, Prijmeni, email, Datum_narozeni FROM Zakaznik

/*1;2;5;Výpis zbraní setøídìných podle ráže*/
SELECT idZbr, Nazev, Typ_zbrane, Raze, Rok_Vyroby FROM Zbran ORDER By Raze

/*1;3;4;Vypis id zbrani a poctu, kolikkrat byly pouzity pri strelbe*/
SELECT Zbran_idZbr, COUNT(Zbran_idZbr) as pocetPouziti FROM Strelba
GROUP BY Zbran_idZbr
ORDER BY COUNT(Zbran_idZbr)

/*1;4;4;Vypis poctu rezervaci pro kazdeho zakaznika*/
SELECT Zakaznik_idZak, COUNT(Zakaznik_idZak) as pocetRezervaci FROM Rezervace
GROUP BY Zakaznik_idZak
ORDER BY Zakaznik_idZak DESC

/*2;1;2;Vypis zbrani, ktere jsou z tohoto tisicileti*/
SELECT idZbr, Nazev, Typ_zbrane, Raze, Rok_Vyroby FROM Zbran
WHERE Rok_vyroby >= 2000

/*2;2;1;Vypis zamestnancu, kteri maji cesky email a vice nez 30 nebo mene nez 25 let*/
SELECT idZam, Jmeno, Prijmeni, email, Datum_narozeni, DATEDIFF(YEAR, Datum_narozeni, GETDATE()) as Vek FROM Zamestnanec
WHERE email LIKE '%.cz' AND (DATEDIFF(YEAR, Datum_narozeni, GETDATE()) > 30 OR DATEDIFF(YEAR, Datum_narozeni, GETDATE()) < 25)

/*2;3;3;Zbrane, ktere nejsou samopaly*/
SELECT idZbr, Nazev, Typ_zbrane, Raze, Rok_Vyroby FROM Zbran
WHERE Typ_zbrane NOT LIKE '%Samopal%'

/*2;4;3;Strelby delsi nez hodinu*/
SELECT idStr, Zacatek, Konec, DATEDIFF(Minute, Zacatek, Konec) as delkaStrelby FROM Strelba
WHERE DATEDIFF(Minute, Zacatek, Konec) > 60

/*3;1;3;Výpis zbraní, které maji unikatni razi pomoci IN*/
SELECT idZbr, Nazev, Typ_zbrane, Raze, Rok_Vyroby FROM Zbran z1
WHERE Raze NOT IN 
(	
	SELECT Raze FROM Zbran z2
	WHERE z1.idZbr <> z2.idZbr 
)

/*3;2;3;EXISTS*/
SELECT idZbr, Nazev, Typ_zbrane, Raze, Rok_Vyroby FROM Zbran z1
WHERE NOT EXISTS 
(
	SELECT * FROM Zbran z2
	WHERE z1.idZbr <> z2.idZbr and z1.Raze = z2.Raze
)

/*3;3;3;ALL*/
SELECT idZbr, Nazev, Typ_zbrane, Raze, Rok_Vyroby FROM Zbran z1
WHERE Raze <> ALL (
	SELECT Raze FROM Zbran z2
	WHERE z1.idZbr <> z2.idZbr
)

/*3;4;3;EXCEPT*/
SELECT idZbr, Nazev, Typ_zbrane, Raze, Rok_Vyroby FROM Zbran z1
EXCEPT
SELECT idZbr, Nazev, Typ_zbrane, Raze, Rok_Vyroby FROM Zbran z2
WHERE z2.Raze = ANY
(
	SELECT z3.Raze FROM Zbran z3
	WHERE z3.idZbr <> z2.idZbr
)

/*4;1;1;Prumerny vek zamestnancu*/
SELECT AVG(DATEDIFF(YEAR, Datum_narozeni, GETDATE())) as PrumernyVek
FROM Zamestnanec

/*4;2;4;Kolik strelnych prostoru existuje pro kazdou vzdalenost*/
SELECT Vzdalenost, COUNT(Vzdalenost) as pocet
FROM Prostor
GROUP BY Vzdalenost

/*4;3;4;Zakaznici serazeni podle casu straveneho na strelnici*/
SELECT Zakaznik_idZak, SUM(DATEDIFF(MINUTE, Zacatek, Konec)) as celkovyCas
FROM Strelba
GROUP BY Zakaznik_idZak
ORDER BY SUM(DATEDIFF(MINUTE, Zacatek, Konec))

/*4;4;3;Zbrane, ze kterych se strilelo jednou*/
SELECT Zbran_idZbr
FROM Strelba
GROUP BY Zbran_idZbr
HAVING COUNT(Zbran_idZbr) = 1

/*5;1;4;Zakaznici, kteri provedli rezervaci*/
SELECT z.idZak, z.Jmeno, z.Prijmeni
FROM Zakaznik z
JOIN Rezervace r ON z.idZak = r.Zakaznik_idZak
GROUP BY z.idZak, z.Jmeno, z.Prijmeni

/*5;2;4;POMOCI IN*/
SELECT z.idZak, z.Jmeno, z.Prijmeni
FROM Zakaznik z
WHERE z.idZak IN
(
	SELECT Zakaznik_idZak
	FROM Rezervace
)

/*5;3;5;Detailnejsi informace o zbranich, ktere byly pouzity k dane strelbe.*/
SELECT z.idZbr, z.Nazev, z.Typ_zbrane, z.Raze, COUNT(s.Zbran_idZbr) as pocetPouziti
FROM Zbran z
LEFT OUTER JOIN Strelba s ON s.Zbran_idZbr = z.idZbr
GROUP BY z.idZbr, z.Nazev, z.Typ_zbrane, z.Raze

/*5;4;3;Vypis rezervaci na strelne prostory, kde je vzdalenost k cili vetsi nez 75m*/
SELECT  r.idRez, r.Prostor_idSpr, p.Vzdalenost
FROM Rezervace r
LEFT OUTER JOIN Prostor p ON r.Prostor_idSpr = p.idSpr
WHERE p.Vzdalenost > 75
GROUP BY r.idRez, r.Prostor_idSpr, p.Vzdalenost

/*6;1;5;U každého zamìstnance výpis prùmìrné doby strávené kontrolováním støelby a poèet rùzných obsloužených zákazníkù.*/
SELECT zam.idZam, zam.Jmeno, zam.Prijmeni,
(
	SELECT AVG(DATEDIFF(MINUTE, s.Zacatek, s.Konec))
	FROM Strelba s
	WHERE s.Zamestnanec_idZam = zam.idZam
) as prumernyCasDozoru, 
(
	SELECT COUNT(DISTINCT zak.idZak)
	FROM Zakaznik zak
	JOIN Strelba S ON zak.idZak = s.Zakaznik_idZak
	WHERE S.Zamestnanec_idZam = zam.idZam
) as pocetZakazniku
FROM Zamestnanec zam

/*6;2;4;Vypsani streleb, na ktere byly rezervace a zakazniku, na ktere byly vypsany*/
SELECT s.idStr, s.Zakaznik_idZak, zak.Jmeno, zak.Prijmeni
FROM Strelba s
JOIN Zakaznik zak on s.Zakaznik_idZak = zak.idZak
WHERE EXISTS
(
	SELECT *
	FROM Rezervace r
	WHERE s.Zakaznik_idZak = r.Zakaznik_idZak AND s.Prostor_idSpr = r.Prostor_idSpr AND s.Zbran_idZbr = r.Zbran_idZbr AND s.Zacatek = r.datumStrelby
)
