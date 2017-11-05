var yards = document.getElementById('yd').value;
var meters = document.getElementById('num2').value;

function calculate1(){
	$('#info').remove();
	yards = yards*1.0936;
	document.getElementById('Results').innerHTML = "The result is: " + yards + "<br>";
	$(".Results").append();
}

function calculate2(){
	meters = meters/1.0936;
	document.getElementById("m").innerHTML = "The result is:" + meters + "<br>";
	$("Result")

	
}

