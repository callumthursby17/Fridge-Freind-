

function validateForm(){
   
    var ing1 = document.getElementById("MainContent_ingredient1").value;
    var ing2 = document.getElementById("MainContent_ingredient2").value;
    var ing3 = document.getElementById("MainContent_ingredient3").value;
    var ing4 = document.getElementById("MainContent_ingredient4").value;
    var ing5 = document.getElementById("MainContent_ingredient5").value;
    
                if(ing1.length == 0 || ing1.match(/^\s*$/)){
                alert("Please fill in the First Ingredient Field or Make sure there are no spaces");
                return false;
                 }
        else{
                 if ( ing1.match(/[~`!#$%£\^&*+=\-\[\]\\';,/{}|\\":<>\?0-9]/) ) {
                 alert("Please check ingredent 1 for an incorrect character"); 
                 return false; 
                 } /* End of Check for ing1 */ 
        
        else{
                if ( ing2.match(/[~`!#$%£\^&*+=\-\[\]\\';,/{}|\\":<>\?0-9]/)  ) {
                alert("Please check ingredent 2 for an incorrect character"); 
                return false; 
                } /* End of Check for ing2 */ 
            
        
        else{
                if ( ing3.match(/[~`!#$%£\^&*+=\-\[\]\\';,/{}|\\":<>\?0-9]/)  ) {
                alert("Please check ingredent 3 for an incorrect character"); 
                return false; 
                } /* End of Check for ing3 */
            
            
        else{
                if ( ing4.match(/[~`!#$%£\^&*+=\-\[\]\\';,/{}|\\":<>\?0-9]/) ) {
                alert("Please check ingredent 4 for an incorrect character"); 
                return false; 
                } /* End of Check for ing4 */
            
            
        
       else{
                if ( ing5.match(/[~`!#$%£\^&*+=\-\[\]\\';,/{}|\\":<>\?0-9]/)  ) {
                alert("Please check ingredent 5 for an incorrect character"); 
                return false; 
                } /* End of Check for ing5 */
           
            
       else{
               fadeINpickRep(MainContent_submitBtn);
           }
              
        } /* End of Test Field 5 */
        } /* End of Test Field 4 */
        } /* End of Test Field 3 */
        } /* End of Test Field 2 */
        } /* End of Test Field 1 */
    
} /* End of validateForm Function */ 






function fadeINpickRep(submitBtn){
    if (submitBtn.value === "Submit Ingredients") {
        document.getElementById("pickRep").className = "fade-in"
        document.getElementById("pickRepBG").className = "fade-out"
        submitBtn.value = "Reset Ingredients";
    }
    else {
        document.getElementById("pickRep").className = "fade-out"
        document.getElementById("pickRepBG").className = "fade-in"
        submitBtn.value = "Submit Ingredients";  
        }
       
} /* End of fadeINpickRep Function */ 