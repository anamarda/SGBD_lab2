CREATE DATABASE ClientProdusSGBD
GO 

USE ClientProdusSGBD
GO

CREATE TABLE Client(
	Cid INT PRIMARY KEY,
	Nume VARCHAR(20),
	Gen VARCHAR(20),
	DataNasterii VARCHAR(20), 
)

CREATE TABLE Produs(
	Pid INT PRIMARY KEY,
	Denumire VARCHAR(20),
	Cantitate INT,
	Pret INT,
	Cid INT FOREIGN KEY REFERENCES Client(Cid)
)