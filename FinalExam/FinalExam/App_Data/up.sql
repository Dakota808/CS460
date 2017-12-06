
CREATE TABLE Artist(

   --The Name of the Artist
	Names VARCHAR(50) NOT NULL,
	--The Date of when the Artist was Born
	DOB DATE NOT NULL,
	--The City that this Artist was from
	City VARCHAR (255) NOT NULL,
	--The ID of the Art
	Artkey int IDENTITY(1,1) NOT NULL PRIMARY KEY,
);

CREATE TABLE Artwork(
    --The Name of the Art
	Title VARCHAR(255) NOT NULL,
	--The Artwork primary key
	ArtWkey int IDENTITY (1,1) PRIMARY KEY,
	--This is the connection to give the Artist name.
	ArtKey int FOREIGN KEY REFERENCES Artist(ArtKey),
);

CREATE TABLE Genre(

	 --The Artworks Genre type
	 genre VARCHAR(255) PRIMARY KEY


);

CREATE TABLE Classification(
   
	 --Classification of the art
	 classification int IDENTITY(1,1) PRIMARY KEY, 
	 --Type of Art
	 artwork int FOREIGN KEY REFERENCES ArtWork(ArtWkey),
	 --Genre of the Art
	 genres VARCHAR(255) FOREIGN KEY REFERENCES Genre(genre),
);



INSERT INTO Artist (Names, DOB, City)
     VALUES 
	 ('M.C. Escher', '1898-06-17', 'Leewarden, Netherlands'),
	 ('Leonardo Da Vinci', '1519-05-02', 'Vinci, Italy'),
	 ('Hati Mehmed Efendi', '1680-11-18', 'Unknown'),
	 ('Salvador Dali', '1904-05-11', 'Figueres, Spain');

INSERT INTO Artwork (Title, ArtKey)
     VALUES
	 ('Circle Limit III', '1'),
	 ('Twon Tree', '1'),
	 ('Mona Lisa', '2'),
	 ('The Vitruvian Man', '2'),
	 ('Ebru', '3'),
	 ('Honey Is Sweeter Than Blood', '4');

INSERT INTO Genre(genre)
     VALUES
	 ('Tesselation'),
	 ('Surrealism'),
	 ('Portrait'),
	 ('Renaissance');

INSERT INTO Classification(artwork, genres)
     VALUES
	 ('1','Tesselation'),
	 ('2','Tesselation'),
	 ('2','Surrealism'),
	 ('3','Portrait'),
	 ('3','Renaissance'),
	 ('4','Renaissance'),
	 ('5','Tesselation'),
	 ('6','Surrealism');

GO

-- testing
select * from Artist;
select Title, Names from Artwork JOIN Artist on Artwork.ArtKey=Artist.Artkey;
select Title, genres from Artwork JOIN Classification on Artwork.ArtWkey=Classification.artwork;
select * from Genre;