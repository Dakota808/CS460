CREATE TABLE Buyers(
 BuyersID int IDENTITY (1,1) NOT NULL PRIMARY KEY,
 BuyersName varchar(50) not null,
  
);

CREATE TABLE Sellers(
SellersID int IDENTITY(1,1) not null PRIMARY KEY, 
SellersName varchar(50) not null, 
);

CREATE TABLE Items(
ItemID int IDENTITY(1,1) not null PRIMARY KEY,
seller int FOREIGN KEY REFERENCES Sellers(SellersID),
itemName varchar(255) not null,
itemDescription varchar(255)not null, 

);

CREATE TABLE Bids(
itemBidID int IDENTITY(1,1) not null PRIMARY KEY,
itemID int FOREIGN KEY REFERENCES Items(ItemID),
bider int FOREIGN KEY REFERENCES Buyers(BuyersID),
timeStamps Date not null, 
prices varchar(255) not null,
);

INSERT INTO Buyers(BuyersName)
    VALUES
	('Jane Stone' ),
	('Tom McMasters'),
	('Otto VanderWall');

INSERT INTO Sellers(SellersName)
    VALUES
	('Gayle Hardy'),
	('Lyle Banks'),
	('Pearl Greene');

INSERT INTO Items(itemName, itemDescription, seller)
    VALUES
	('Abraham Lincoln Hammer', 'A bench mallet from a broken rail-splitting maul in 1829 and owned by Abraham Lincoln', '3'),
	('Albert Einstiens Telescope', 'A brass telescope owned by Albert Einstein in Germany, Circa 1927', '1'),
	('Bob Dylan Love Poems', 'Five versions of an original unpublished, handwritten, love poem by Bob Dylan', '2');

INSERT INTO Bids(itemID, bider, prices, timeStamps)
    VALUES
	('1','3', '$250,000', '12/04/2017 09:04:22'),
	('3', '1', '$95,000', '12/04/2017 08:44:03');

GO

-- testing
select * from Buyers;
select * from Sellers;
select *  from Sellers JOIN Items on Items.seller=Sellers.SellersID;
select  *  from Buyers JOIN Bids on Bids.bider=Buyers.BuyersID;
--select   from JOIN  on 