
function textSize(selectTag) {
    var sizeValue = selectTag.options[selectTag.selectedIndex].text;
    document.getElementById("pickInText").style.fontSize = sizeValue;
}