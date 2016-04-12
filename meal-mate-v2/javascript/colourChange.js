/**
* Created with Meal Mate V2.
* User: Liam Palmer
* Date: 2016-04-06
* Time: 10:40 AM
* To change this template use Tools | Templates.
*/

function colourChange(selectTag){
    var colourValue = selectTag.options[selectTag.selectedIndex].text; 
    if(colourValue === "Black and White"){
        document.getElementById("body").style.backgroundColor="black";
        document.getElementById("body").style.color="white";
        document.getElementById("footer").style.backgroundColor="black";
        document.getElementById("header").style.backgroundColor="black";
        document.getElementById("visImp").style.backgroundColor="black";
        document.getElementById("visImp").style.color="white";
        document.getElementById("submitBtn").style.backgroundColor="white";
        document.getElementById("submitBtn").style.color="black";
        document.getElementById("resetBtn").style.color="black";
        document.getElementById("resetBtn").style.backgroundColor="white";
        document.getElementById("submitBtn2").style.backgroundColor="white";
        document.getElementById("submitBtn2").style.color="black";
        document.bgColor = "black";
        
        var imgText = document.getElementsByClassName("mealPic")[0];
        if (mealPic.src == "images/meal-mate-.gif") {
            mealPic.src = "Meal Mate";
        }
        else{
            mealPic.src = "images/meal-mate-.gif";
        }
    }
}
