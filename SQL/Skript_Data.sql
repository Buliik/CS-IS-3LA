INSERT INTO Zakaznik (Jmeno, Prijmeni, email, Datum_Narozeni)
VALUES  ('Frank', 'Castle'  , 'punisher@micro.com', '19850625'),
		('Jack' , 'Morrison', 'bigbadjack76@gmail.com', '19671113'),
		('Oliver', 'Queen', 'bulletbow@coldmail.com', '19780225'),
		('Franta', 'Kokta', 'nejnejnejlepsi@seznam.cz', '19660606');

INSERT INTO Zamestnanec (Jmeno, Prijmeni, email, Datum_Narozeni)
VALUES  ('Steve', 'Nojobs', 'notworking@microsoft.com', '19890715'),
		('Bill', 'Gates', 'owning@microsoft.com', '19551022'),
		('Jeff', 'Kaplan', 'Heyguys@itsjeff.com', '19721104'),
		('Jan', 'Novak', 'originaljmeno@placeholder.com', '19901010'),
		('Franta', 'Vesely', 'veselec@centrum.cz', '19690420');

INSERT INTO Zbran (Nazev, Typ_zbrane, Raze, Rok_vyroby)
VALUES  ('AK-47 Kalashnikov', 'Utocna puska', 7.62, 1995),
		('P-90', 'Samopal', 5.7, 2003),
		('MP 40', 'Samopal', 9, 1938),
		('Accuracy International Warfare', 'Odstrelovaci puska', 7.62, 1999),
		('M4A1', 'Utocna puska', 5.56, 2009);

INSERT INTO Prostor (Vzdalenost)
VALUES  (25), 
		(100), 
		(300), 
		(50.75);

INSERT INTO Rezervace (datumVytvoreni, datumStrelby, Zakaznik_idZak, Prostor_idSpr, Zbran_idZbr)
VALUES  ('20171210 17:25:46', '20171214 09:00:00', 1, 3, 4), 
		('20170805 13:11:07', '20170807 13:37:00', 2, 1, 1),
		('20171023 08:16:16', '20171026 14:30:00', 3, 4, 2),
		('20171115 22:22:22', '20171122 20:00:00', 4, 2, 3),
		('20171206 23:05:55', '20171208 11:30:00', 1, 2, 3);

INSERT INTO Strelba(Zacatek, Konec, Zbran_idZbr, Zamestnanec_idZam, Zakaznik_idZak, Prostor_idSpr)
VALUES  ('20171214 09:00:00', '20171214 10:30:00', 4, 2, 1, 3),
		('20170807 13:37:00', '20170807 15:21:13', 1, 1, 2, 1),
		('20171026 14:30:00', '20171026 14:45:16', 2, 4, 3, 4),
		('20171122 20:00:00', '20171122 22:00:21', 3, 3, 4, 2),
		('20170414 14:50:20', '20170414 15:32:46', 3, 1, 3, 4);