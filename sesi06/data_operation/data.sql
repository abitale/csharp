CREATE DATABASE staff;

USE staff;

CREATE TABLE data_staff(
nik INT NOT NULL,
nama VARCHAR(50),
alamat VARCHAR(200),
handphone VARCHAR(15),
PRIMARY KEY(nik)
);

INSERT INTO data_staff VALUES(
1002,
"Budi",
"Jln.Pahlawan",
"02142932"
),
(
1001,
"Andi",
"Jln.Pemuda",
"03123922",
"1995-05-03"
);

ALTER TABLE data_staff ADD joindate DATE;

UPDATE data_staff SET joindate="1994-03-28" WHERE nik=1002;

INSERT INTO data_staff VALUES(
1001,
"Andi",
"Jln.Pemuda",
"03123922",
"1995-05-03"
);

INSERT INTO data_staff VALUES(
1003,
"Rani",
"Jln.Sirsak II",
"0253735",
"1994-02-03"
);

SELECT * FROM data_staff LIMIT 2;

SELECT * FROM data_staff LIMIT 3;

CREATE TABLE staffoutsource(
nik INT NOT NULL,
nama VARCHAR(50),
alamat VARCHAR(200),
handphone VARCHAR(15),
joindate DATE,
PRIMARY KEY(nik)
);

INSERT INTO staffoutsource VALUES
(1202,"Rian","Jln.Semangka","02832121","1993-03-04"),
(1132,"Joko","Jln.Pepaya","03134212","1994-12-27"),
(1142,"Siti","Jln.Durian","03112321","1994-02-03"),
(1241,"Hendi","Jln.Surya Emas","02241234","1994-02-03"),
(1242,"Teri","Jln.Pasar Baru"  "02241432"   "1997-12-20"),
(1421,"Ade","Jln.Jaya","03282542","1994-02-03"),
(1432,"Rudi","Jln.Perak","03223143","1994-02-03"),
(1930,"Harry","Jln.Srikaya","02242134","1994-02-03"),
(2142,"Samuel","Jln.Batubara","02342521","1997-12-20"),
(2242,"Nurul","Jln.Simbada","01283242","1994-02-03");

SELECT * FROM data_staff JOIN staffoutsource WHERE data_staff.joindate=staffoutsource.joindate;

SELECT * FROM data_staff a RIGHT JOIN staffoutsource b ON a.joindate = b.joindate;

SELECT * FROM data_staff a LEFT JOIN staffoutsource b ON a.joindate=b.joindate;

SELECT * FROM data_staff a FULL JOIN staffoutsource b ON a.joindate=b.joindate;