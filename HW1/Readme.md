Lab 1

This first lab assignment was to create the git repository and create our very own webpage using Html. Though the first this is to make the Directory and to do this you need to follow these simple commands. Note: this is done through my command prompt on my computer.

Step 1. Create the repository

cd Desktop, mkdir CS460, cd CS460, git clone https://github.com/dakota808/CS460 , cd CS460

Step 2. Webpage desgin/development

<!doctype html>

   <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css">
<link rel="stylesheet" type="text/css" href="Style.css"/>
		
<head>
	<title>Dakota Koki Profile</title>


</head>

<body style="background-color:lightblue"> 
<!-- This was collaberated with Nathen Stark-->
<div id="container">
  
	<div id="header">
		<h1> Dakota Koki </h1>
		<h2> 95-1100 Ahoka St. Mililani, HI 96789<h2>
		<h2> Email: Dakotakoki808@gmail.com</h2>
	 
	</div>
	
	<div id="profile">
	 <h2> Profile</h2>
	 <p> Looking to jumpstart a career in IT risk management and Network Security.<br/>
		Looking at the latest pieces of technology, always imporving my understanding about<br/>
		the latest in cyber security and how to repel these types of online situations.<p>
		
	</div>

	<div id="education">
	 <h2>Education</h2>
	 <h3> Western Oregon University<br/>
	 Bachelor of Science in Computer Science<br/>
	 </h3>
	 
	
	</div>
	
	<div id="experience1">
	<h2> Professional Experience</h2>
	<h3> Bank of Hawaii</h3>
	<h4> Intern IT Infastructure & Network Group<h4>
	<ul>
		<li>Project: Configuration firewall system to increrase Bank's and vendor network's security systems</li> 
		<li>Configured routers for ATM network deployment</li>

	</ul>
	</div>
	
	<div id="experience2">
	<h2> Personal Experience</h2>
	<ul>
		<li> Developed code to create MP3 software</li>
		<li> Developed prototype multiplayer video game</li>
		
	</ul>
	</div>
	
	<div id="links">
	 <a href="index1.html">Extra </a>
	
	</div>
	
	

`</div>
 

 </body>
This is all for the first page of the Webpage this is just the start of the building and improving upon this webpage. next is the second page which will contain links to different locations and cites.

They way I add a background image to the page is through the html body.
<!doctype html>

<head>
    <title> Hobbies </title>
    <link rel="stylesheet" type="text/css" href="Style.css"/>

</head>

<body style="background-image:url('Servamp.png')">

<div id="container1">

   <h2>Some of my interest are as follows: </h2>
   <ul>
    <li>Watch Anime
    <li>Video games
    <li>Trading Card Games
   </ul>
</div>
    <div id="Links">
       <h4>Try looking at these sights if you are interested in any:</h4>
       <a href="https://kissanime.ru">Kissanime </a> <br/>
       <a href="https://jpopsuki.eu">Jpopsuki </a> <br/>
       <a href="http://www.ideal808.com">Ideal808 </a>
    </div>
  <div id="pages">
<a href="index.html">Home </a>

  </div>
</div>

</body>
Finally the Styles.css desgins the background for the webpages.

#header{ color: black;

} #profile{ color: gold;

} #education{ color: black }

#experience1{ color: black }

#experience2{ color: black }

#container1{ color: gold } #Links{ color: Blue }
