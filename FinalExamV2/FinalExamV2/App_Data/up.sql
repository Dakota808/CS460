CREATE TABLE Actors(
ActorName varchar(50) not null,
ActorID int IDENTITY(1,1)not null PRIMARY KEY,
  
);

CREATE TABLE Directors(
DirecName varchar(50),
DirecID int IDENTITY(1,1) not null PRIMARY KEY, 
);

CREATE TABLE Movie (
MovieName varchar(50) not null,
MovieYear varchar(50) not null,
MovieID int IDENTITY (1,1) not null PRIMARY KEY,
Director int FOREIGN KEY REFERENCES Directors(DirecID),

);

CREATE TABLE CastMem (
CastID int IDENTITY (1,1) not null PRIMARY KEY,
castCrew int FOREIGN KEY REFERENCES Actors(ActorID),
MovieType int FOREIGN KEY REFERENCES Movie(MovieID)
);

INSERT INTO Actors(ActorName)
    VALUES
	('Daisy Ridley'),
	('Andy Serkis'),
	('Benicio Del Toro'),
	('Penelope Cruz');


INSERT INTO Directors(DirecName)
    VALUES
	('Rian Johnson'),
	('Kenneth Branagh'),
	('Rob Marshall'),
	('James Marsh');


INSERT INTO Movie(MovieName, MovieYear, Director)
    VALUES
	('Star Wars: The Last Jedi', '2017', '1'),
	('Murder on the Orient Express', '2017','2'),
	('Priates of the Caribbean: On Stranger Tides', '2011', '3'),
	('The Theory of Everything', '2014', '4');

INSERT INTO CastMem(castCrew, MovieType)
    VALUES
	('4','3'),
	('4', '2'),
	('1', '2'),
	('3', '1'),
	('2', '1'),
	('1','1');


GO

-- testing
select * from Actors;
select * from Directors;
select * from Movie JOIN Directors on Movie.Director=Directors.DirecID;
select castCrew, MovieType from CastMem JOIN Actors on CastMem.castCrew=Actors.ActorID;
