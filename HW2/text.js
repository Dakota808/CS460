		<!--Input is defined as the information being typed in. -->
		<!-- outputs is the result -->
		function outputText(){
		var inputs, outputs, info, x, y, result;
		inputs = document.getElementById("form1");
		outputs = inputs.elements["input1"].valve;
		document.getElementById("Info").innerHTML="Hi," + outputs +"<br>";
		document.getElementById(Info).innerHTML+= "It's very nice to meet you. " + "<br>";
		document.getElementById(Info).innerHTML+="This is just a simulated text being directed to you " + outputs; 
		}