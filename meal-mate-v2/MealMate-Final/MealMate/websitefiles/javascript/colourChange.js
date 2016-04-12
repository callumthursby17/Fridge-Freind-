/**
* Created with Meal Mate V2.
* User: Liam Palmer
* Date: 2016-04-06
* Time: 10:40 AM
* To change this template use Tools | Templates.
*/

function colourChange(selectTag) {
    var colourValue = selectTag.options[selectTag.selectedIndex].text;
    if (colourValue === "Black and White") {
        document.getElementById("body").style.backgroundColor = "black";
        document.getElementById("body").style.color = "white";
        document.getElementById("footer").style.backgroundColor = "black";
        document.getElementById("header").style.backgroundColor = "black";
        document.getElementById("visImp").style.backgroundColor = "black";
        document.getElementById("visImp").style.color = "white";
        document.getElementById("MainContent_Button1").style.backgroundColor = "white";
        document.getElementById("MainContent_Button1").style.color = "black";
        document.getElementById("resetBtn").style.color = "black";
        document.getElementById("resetBtn").style.backgroundColor = "white";
        document.getElementById("submitBtn2").style.backgroundColor = "white";
        document.getElementById("submitBtn2").style.color = "black";
        document.bgColor = "black";
    }
    else {
        document.getElementById("body").style.backgroundColor = "white";
        document.getElementById("body").style.color = "black";
        document.getElementById("footer").style.backgroundColor = "lightgray";
        document.getElementById("header").style.backgroundColor = "white";
        document.getElementById("visImp").style.backgroundColor = "white";
        document.getElementById("visImp").style.color = "black";
        document.getElementById("MainContent_Button1").style.backgroundColor = "green";
        document.getElementById("MainContent_Button1").style.color = "white";
        document.getElementById("resetBtn").style.color = "white";
        document.getElementById("resetBtn").style.backgroundColor = "green";
        document.getElementById("submitBtn2").style.backgroundColor = "green";
        document.getElementById("submitBtn2").style.color = "white";
        document.bgColor = "white";
    }
}