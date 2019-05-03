USE ClientProdusSGBD
GO

INSERT INTO Client(Cid, Nume, Gen, DataNasterii) VALUES 
	(1, 'McGonagall', 'F', '12/12/2000'), 
	(2, 'Flitwick', 'M', '12/12/1900'),
	(3, 'Jason', 'M', '12/12/1940'),
	(4, 'Steve Jobs', 'M', '10/12/1970'),
	(5, 'Regina Maria', 'F', '29/11/1875')
GO
SELECT * FROM Client

INSERT INTO Produs(Pid, Denumire, Cantitate, Pret, Cid) VALUES
	(1, 'Ceai', 100, 150, 1),
	(2, 'Baghete', 1, 2000, 1),
	(3, 'Spaghete', 5, 10, 2),
	(4, 'Surubelnite', 30, 100, 3),
	(5, 'Multi bani', 9999, 9999, 4),
	(6, 'Rochii', 20, 1000, 5)
GO
SELECT * FROM Produs