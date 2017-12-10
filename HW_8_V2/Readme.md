This Lab was a mixture of understanding on how to build a database which has realtional and ajax compents.

Though, this is more of the diffcult party for me is to run the ajax onto the program that I have built.
Where as the database was not so. We are given four different tables for Artist Artwork and this part of the lab is to create those 
connections to make sure that we can take in the data we want and display them into the or data.

## Step 1: Make the SQL / Relational Database
Start by making a drawn out design of the realtional database and pointing out the data types of each table as well as the 
Primary Keys and Foreign Keys.


Once you have completed the Daigram of the realational database you will then build this database.
to do this we will need to make a up sql which will upload the inputs of data from our created data.
Note: This also where we test it to see what results do we recieve.


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

## Step 2 building the application
Building the application is no simple task. It should end up looking like this. With that being located in the models folder of the 
project. The key section for this would be the Context for that is what you will be using when you are deploying the 
entire database as a application. 

namespace HW_8_V2.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class ArtistContext : DbContext
    {
        public ArtistContext()
            : base("name=ArtistContext")
        {
        }

        public virtual DbSet<Artist> Artists { get; set; }
        public virtual DbSet<Artwork> Artworks { get; set; }
        public virtual DbSet<Classification> Classifications { get; set; }
        public virtual DbSet<Genre> Genres { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Artist>()
                .Property(e => e.Names)
                .IsUnicode(false);

            modelBuilder.Entity<Artist>()
                .Property(e => e.City)
                .IsUnicode(false);

            modelBuilder.Entity<Artwork>()
                .Property(e => e.Title)
                .IsUnicode(false);

            modelBuilder.Entity<Artwork>()
                .HasMany(e => e.Classifications)
                .WithOptional(e => e.Artwork1)
                .HasForeignKey(e => e.artwork);

            modelBuilder.Entity<Classification>()
                .Property(e => e.genres)
                .IsUnicode(false);

            modelBuilder.Entity<Genre>()
                .Property(e => e.genre1)
                .IsUnicode(false);

            modelBuilder.Entity<Genre>()
                .HasMany(e => e.Classifications)
                .WithOptional(e => e.Genre)
                .HasForeignKey(e => e.genres);
        }
    }
}

Note: The ajax part of this lab is still being tested to see how to apply them to this lab..

After that almost all of the rest of the program is done in Html format.
