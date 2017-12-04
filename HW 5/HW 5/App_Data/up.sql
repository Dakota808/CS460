CREATE TABLE Requests(
    -- unique ID for the change of the request. This is not identified by the user that requested the transfer.
	-- This will auto-increment as new requests are added to the database.
	ID int IDENTITY(0,1) PRIMARY KEY,
	-- The ODL number identifying the person that wants the address change.
	ODL int NOT NULL,
	-- The name of the person requesting the change of address
	Name VARCHAR(255) NOT NULL,
	-- The date of birth of the person requesting the change.
	DOB DATE NOT NULL,
	-- Street address
	Street VARCHAR(255) NOT NULL,
	-- City
	City VARCHAR(255) NOT NULL,
	-- State 
	State VARCHAR(2) NOT NULL,
	-- zip
	Zip int NOT NULL,
	-- County
	County VARCHAR(100) NOT NULL,
	DateStamp DATE NOT NULL

);

INSERT INTO Requests (ODL, Name, DOB, Street, City, State, Zip, County, DateStamp) 
	VALUES (1000000, 
			'John Smith', 
			'1970-02-26', 
			'123 NE Rainwater Drive', 
			'Albany', 
			'OR', 
			97321, 
			'Linn',
			'2017-06-15'
);

INSERT INTO Requests (ODL, Name, DOB, Street, City, State, Zip, County, DateStamp) 
	VALUES (1000000, 
			'Jake Sal', 
			'1986-02-28', 
			'567 NE Rainwater st', 
			'Millani', 
			'HI', 
			96789, 
			'Dap',
			'2017-08-31'
);

INSERT INTO Requests (ODL, Name, DOB, Street, City, State, Zip, County, DateStamp) 
	VALUES (1000000, 
			'Kai Toshiki', 
			'1995-06-20', 
			'91-001 Kaze Drive', 
			'Yokohama', 
			'JP', 
			99341, 
			'Cards',
			'2017-06-15'
);

SELECT * FROM Requests;