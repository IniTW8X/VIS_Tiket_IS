select * from tiket

SELECT t.t_ID, t.popis, t.priorita, t.vytvoreno, t.lhuta, t.Zamestnanec_z_ID, t.Kategorie_kat_ID, t.Skupina_skup_ID, k.nazev 
From Tiket t 
JOIN Kategorie k ON k.kat_ID = t.Kategorie_kat_ID 
WHERE t.lhuta <= GETDATE() AND t.status = "Přiřazeno" ORDER BY t.lhuta DESC


SELECT t.t_ID, t.nazev, t.popis, t.priorita, t.vytvoreno, t.lhuta, t.status, t.uzav_pozn, t.Zamestnanec_z_ID, t.Kategorie_kat_ID, t.Skupina_skup_ID 
From Tiket t WHERE t.lhuta <= GETDATE() AND t.status = 'Prirazen' ORDER BY t.lhuta DESC


SELECT t.t_ID, t.nazev, t.popis, t.priorita, t.vytvoreno, t.lhuta, t.status, t.uzav_pozn, t.Zamestnanec_z_ID, t.Kategorie_kat_ID, t.Skupina_skup_ID 
FROM Tiket t WHERE t.status = 'Novy'

select * from tiket
where status = 'Prirazen'

