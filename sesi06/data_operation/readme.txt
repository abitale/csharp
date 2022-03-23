Nama: Nathaniel Alexander
No.Peserta: FSDO003ONL005
Sesi 06
Panduan Penggunaan Aplikasi:
	1) Buka file SQL dengan SQLYog atau MySQL
	2) Jalankan query create database dan use database terlebih dahulu secara terpisah.
	3) Jalankan semua query lainnya yang berada dibawah use database.
Link Github: https://github.com/abitale/csharp/tree/main/sesi06

Soal:
a.Buat Database baru dengan nama staff

CREATE DATABASE staff;

b.Buat Table data_staff dengan desain spt dibawah ini :

CREATE TABLE data_staff(
nik INT NOT NULL,
nama VARCHAR(50),
alamat VARCHAR(200),
handphone VARCHAR(15),
PRIMARY KEY(nik)
);

c.Masukkan data ke dalam table data_staff sesuai dengan table diatas

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

d.Masukkan lebih dari 1 data ke dalam table data masih dalam table diatas.
e.Tambahkan kolom baru pada table data_staff yaitu joindate sekaligus masukan 1 data kedalam table data_staff

ALTER TABLE data_staff ADD joindate DATE;
UPDATE data_staff SET joindate="1994-03-28" WHERE nik=1002;

INSERT INTO data_staff VALUES(
1001,
"Andi",
"Jln.Pemuda",
"03123922",
"1995-05-03"
);

F. Tampilkan 2 data SQL kalian sekarang

SELECT * FROM data_staff LIMIT 2;

G. Tampilkan 3 data SQL kalian sekarang 

SELECT * FROM data_staff LIMIT 3;

H. Buat Table baru staffoutsource dengan isi yang sama seperti data_staff

CREATE TABLE staffoutsource(
nik INT NOT NULL,
nama VARCHAR(50),
alamat VARCHAR(200),
handphone VARCHAR(15),
joindate DATE,
PRIMARY KEY(nik)
);

I.  Masukkan 10 data baru ke table staffoutsource

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

J. Tampilkan data pada 2 Table yang sudah kalian buat dengan joindate yang sama

SELECT * FROM data_staff JOIN staffoutsource WHERE data_staff.joindate=staffoutsource.joindate;

K. Tampilkan seluruh data sebelah kanan yang sama pada table staff_outsource

SELECT * FROM data_staff a RIGHT JOIN staffoutsource b ON a.joindate = b.joindate;

L. Tampilkan seluruh data staff sebelah kiri yang punya nilai tidak sama akan bernilai null

SELECT * FROM data_staff a LEFT JOIN staffoutsource b ON a.joindate=b.joindate;

M. Tampilkan seluruh data antara 2 tabel baik itu tidak punya kesamaan dan bernilai null.

SELECT * FROM data_staff a FULL JOIN staffoutsource b ON a.joindate=b.joindate;
