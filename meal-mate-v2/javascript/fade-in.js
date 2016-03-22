/**
* Created with Meal Mate V2.
* User: callumthursby
* Date: 2016-03-21
* Time: 11:45 AM
* To change this template use Tools | Templates.
*/


 function fadeINpickRep(btnElement){
    if (btnElement.value === "Submit Ingredients") {
        document.getElementById("pickRep").className = "fade-in"
        document.getElementById("pickRepBG").className = "fade-out"
        btnElement.value = "Reset Ingredients";
    }
    else {
        document.getElementById("pickRep").className = "fade-out"
        document.getElementById("pickRepBG").className = "fade-in"
        btnElement.value = "Submit Ingredients";  
    }
       
} 

  function fadeINdisplayRep(btnElement){
    if (btnElement.value === "Submit Recipe") {
        document.getElementById("displayRep").className = "fade-in"
        document.getElementById("displayRepBG").className = "fade-out"
        btnElement.value = "Reset Recipe";
    }
    else {
        document.getElementById("displayRep").className = "fade-out"
        document.getElementById("displayRepBG").className = "fade-in" 
        btnElement.value = "Submit Recipe";  
    }
} 

 