/**
* Created with Meal Mate V2.
* User: callumthursby
* Date: 2016-03-24
* Time: 12:22 PM
* To change this template use Tools | Templates.
*/

function textSize(selectTag){
    var sizeValue = selectTag.options[selectTag.selectedIndex].text;
    document.getElementById("body").style.fontSize = sizeValue;
}