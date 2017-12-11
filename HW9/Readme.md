## How to Deploy on Azure

The deployment of Azure is quite simple. 

## Setup the Database

So first you must create an account on Azure usually to make this account is free. 
Then you have to add the a database to your account so go to the SQL Databases tab the click Add at the top left conner which then,
give your database a name, make sure your using the free trial, you then need to add a database to connect to in this case use the 
folder that holds the information of the database.

## Add the Application

After that you can build the App so to this is the similar to the Database but with a few more strings to attach.
Go to App Services and click on add, after that you will need to give it a name and an I database for it to use. 
When this is done the last part is important for the app to work.
Go to the sql database that would want to use with the app, take the connection string of the database. Then take the 
string to the App you just made and go to the application settings, head to the section where you add connection strings and paste the 
connection string from the SQL Database into your values of the connection string.


Note: You need to give the username and password of your database which is usually,
the Admin and the password you made when you created the account.

After that value is inputed into the connection string in the App you then have to connect the to the database in the name which 
I have called it ArtistContext and that will link your databases.
once you have completed that then your app is ready to deploy.

So then you go to your visual Studio and in the solution explorer right click on the entire project, this means second to the top of the 
solution and click on publish. 
Then go it will ask where to publish this so select the Azure sql database and then use existing which is "Select Existing". Finally you then 
go to your resource and go the folder and click on the app you made. Then all you have to do is publish it and you are done.

Then app should be running and heres a link to the app:

[App](http://homework9.azurewebsites.net/):_
