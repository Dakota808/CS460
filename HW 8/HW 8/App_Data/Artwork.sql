CREATE TABLE Artist(
   	--The ID of the Art
	Artkey int NOT NULL PRIMARY KEY,
   --The Name of the Artist
	Name VARCHAR(255) NOT NULL,
	--The Date of when the Artist was Born
	DOB DATE NOT NULL,
	--The City that this Artist was from
	City VARCHAR (255) NOT NULL,


);

CREATE TABLE Artwork(
    --The Name of the Art
	Title VARCHAR(255) NOT NULL,
	--the Artists name
	


);