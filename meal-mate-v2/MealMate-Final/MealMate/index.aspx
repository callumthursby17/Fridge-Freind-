<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true"
    CodeBehind="/index.aspx.cs" Inherits="MealMate._Default" %>



<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">


    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <meta name="description" content="Meal Mate is a recipe database search engine. Which allows users to add their ingredients and produce multiple recipe ideas for the user to implement.">
    <meta name="author" content="Meal Mate Devlopers">
    
    <!-- Favicons and Icons for all Devices START --->
    
    <link rel="apple-touch-icon" sizes="57x57" href="websitefiles/images/favicons/apple-touch-icon-57x57.png">
    <link rel="apple-touch-icon" sizes="60x60" href="websitefiles/images/favicons/apple-touch-icon-60x60.png">
    <link rel="apple-touch-icon" sizes="72x72" href="websitefiles/images/favicons/apple-touch-icon-72x72.png">
    <link rel="apple-touch-icon" sizes="76x76" href="websitefiles/images/favicons/apple-touch-icon-76x76.png">
    <link rel="apple-touch-icon" sizes="114x114" href="websitefiles/images/favicons/apple-touch-icon-114x114.png">
    <link rel="apple-touch-icon" sizes="120x120" href="websitefiles/images/favicons/apple-touch-icon-120x120.png">
    <link rel="apple-touch-icon" sizes="144x144" href="websitefiles/images/favicons/apple-touch-icon-144x144.png">
    <link rel="apple-touch-icon" sizes="152x152" href="websitefiles/images/favicons/apple-touch-icon-152x152.png">
    <link rel="apple-touch-icon" sizes="180x180" href="websitefiles/images/favicons/apple-touch-icon-180x180.png">
    <link rel="icon" type="image/png" href="websitefiles/images/favicons/favicon-32x32.png" sizes="32x32">
    <link rel="icon" type="image/png" href="websitefiles/images/favicons/favicon-194x194.png" sizes="194x194">
    <link rel="icon" type="image/png" href="websitefiles/images/favicons/favicon-96x96.png" sizes="96x96">
    <link rel="icon" type="image/png" href="websitefiles/images/favicons/android-chrome-192x192.png" sizes="192x192">
    <link rel="icon" type="image/png" href="websitefiles/images/favicons/favicon-16x16.png" sizes="16x16">
    <link rel="manifest" href="websitefiles/images/favicons/manifest.json">
    <link rel="mask-icon" href="websitefiles/images/favicons/safari-pinned-tab.svg">
    <meta name="msapplication-TileColor" content="#da532c">
    <meta name="msapplication-TileImage" content="websitefiles/images/favicons/mstile-144x144.png">
    <meta name="theme-color" content="#ffffff">
    
    <!-- Favicons and Icons for all Devices End --->
    
    <title>Meal Mate - Home</title>
    
    <!-- CSS Style Sheets START -->
     <link rel="stylesheet" type="text/css" href="websitefiles/css/main.css">
     <link rel="stylesheet" type="text/css" href="websitefiles/css/1600.css">
     <link rel="stylesheet" type="text/css" href="websitefiles/css/1200.css">
     <link rel="stylesheet" type="text/css" href="websitefiles/css/992.css">
     <link rel="stylesheet" type="text/css" href="websitefiles/css/768.css">
     <link rel="stylesheet" type="text/css" href="websitefiles/css/480.css">
     <link rel="stylesheet" type="text/css" href="websitefiles/css/320.css">

    <!-- CSS Style Sheets END -->
    
    <!-- Javascript files-->
    <script type="text/javascript" src="websitefiles/javascript/fade-in.js"></script>
   <!-- <script src="javascript/tooltip.js"></script>-->
   <script type="text/javascript" src="websitefiles/javascript/formValidation.js"></script> 
   <script type="text/javascript" src="websitefiles/javascript/visualimpairments.js"></script>
   <script type="text/javascript" src="websitefiles/javascript/colourChange.js"></script>

   
  
   
    
    

</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    <!--
To change this template use Tools | Templates.
-->
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.01 Transitional//EN" "http://www.w3.org/TR/html4/loose.dtd">



    
       <!-- Header Div start --> 
     <div id="header">
         <img src="websitefiles/images/meal-mate-.gif" alt="Meal Mate Logo" title="Meal Mate" width="200px" height="100px">
         
        <div id="visImp">
             Adjust Text Size
             
             <select onchange="textSize(this);">
                  <option value="select" disabled>Please Select an option...</option>
                  <option value="xx-small">xx-small</option>
                  <option value="x-small">x-small</option>
                  <option value="small">small</option>
                  <option value="medium">medium</option>
                  <option value="large">large</option>
                  <option value="x-large">x-large</option>
                  <option value="xx-large">xx-large</option>
                  <option value="100%" selected>100%</option>
                  <option value="250%">250%</option>
                  
             </select>
             
              Adjust Colour Contrast
             
              <select onchange="colourChange(this);">
                  <option value="select" disabled>Please select an option...</option>
                  <option value="black and white">Black and White</option>
                  <option value="100%" selected >Normal</option>
                  
                  
             </select>
        
         </div>
         
    </div> 
        <!-- Header Div End --> 
    
    <!-- Body Div start --> 
     <div id="body">
         
         <div id="pickIn">
             <h3> Step 1 Pick Ingredients </h3>
             <p id=pickInText> Please enter each ingredient into a separate field. <!--or use the Add More button to add another field.--></p> 
             
             <form id="enterIng" runat="server">
                 
                 <label for="ingredient1">Ingredient 1:</label>
                 <input  autofocus="autofocus" type="text" id="ingredient1" name="ingredient1" runat="server" placeholder="e.g Bread..." maxlength="30" size="30" title="e.g Eggs, Milk, Bread etc" alt="Form Field 1" spellcheck="true">
                 <br><br>
                 <label for="ingredient2">Ingredient 2:</label>
                 <input type="text" id="ingredient2" runat="server" placeholder="e.g Eggs..." maxlength="30" size="30" title="e.g Eggs, Milk, Bread etc" spellcheck="true" alt="Form Field 2">
                 <br><br>
                 <label for="ingredient3">Ingredient 3:</label>
                 <input type="text" id="ingredient3" runat="server" placeholder="e.g Milk..." maxlength="30" size="30" title="e.g Eggs, Milk, Bread etc" spellcheck="true" alt="Form Field 3">
                 <br><br>
                 <label for="ingredient4">Ingredient 4:</label>
                 <input type="text" id="ingredient4" runat="server" placeholder="e.g Fish..." maxlength="30" size="30" title="e.g Eggs, Milk, Bread etc" spellcheck="true" alt="Form Field 4">
                 <br><br>
                 <label for="ingredient5">Ingredient 5:</label>
                 <input type="text" id="ingredient5" runat="server" placeholder="e.g Chicken..." maxlength="30" size="30" title="e.g Eggs, Milk, Bread etc" spellcheck="true" alt="Form Field 5">
                 
         <!--  <input id="submitBtn" type="button" value="Submit Ingredients" runat="server" OnClick="submit_Click"/>--> 
                 
                 <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Submit Ingredients"  CssClass="MainContent_submitBtn" ToolTip="Submit Button " />
           
                  <button id="resetBtn" type="reset" value="reset">Reset</button>
          
           
          

             
             </form>
        
             <!--fadeINpickRep(this);-->
         </div>
         
        <div id="pickRepBG">
             <h3>Step 2</h3>
             <h4>(Only available after Step 1)</h4>
             
         </div>
         
         <div id="pickRep">
             <h3> Step 2 <br> <br>Please Pick a Recipe </h3>
            
             <table>
             <tr>
                <th>Recipe Name</th>
                <th>Amount Serves</th>
                <th>Preparation Time</th>
                <th>Cook Time</th>
             </tr>
              <tr>
                <td><asp:Label Text="Recipe Name" ID="recipeName" runat="server" /></td>
                <td><asp:Label Text="Amount Serves" ID="amountServe" runat="server" /></td>
                <td><asp:Label Text="Preparation Time" ID="prepTime" runat="server" /></td>
                <td><asp:Label Text="Cook Time" ID="cookTime" runat="server" /></td>
             </tr>
               <tr>
                <td>Recipe Name</td>
                <td>Amount Serves</td>
                <td>Preparation Time</td>
                <td>Cook Time</td>
             </tr>

             </table>
             <br><br><br><br><br><br><br>
             <input id="submitBtn2" type="button" value="Submit Recipe" onclick="fadeINdisplayRep(this);">
         </div>
        
         <div id="displayRepBG">
             <h3>Step 3</h3>
             <h4>(Only available after Step 2)</h4>
             
         </div>
        
               <div id="displayRep" style="overflow-x:auto">
             <h3> Step 3 <br> <br> Ready, Steady, Cook  </h3>
             

            <table style="width:100%; text-align:center; ">
                 <tr>
                     <td><asp:Label Text="Name" ID="recipeName2" runat="server" /></td>
                     <td><asp:Label Text="Dish Type" ID="dishType" runat="server" /> </td>
                 </tr>
              </table>
              <table style="width:100%; text-align:center;">
                 <tr>
                     <td><asp:Label Text="Serves" ID="amountServe2" runat="server" /></td>
                     <td><asp:Label Text="Preparation Time" ID="prepTime2" runat="server" /></td>
                     <td><asp:Label Text="Cook Time" ID="cookTime2" runat="server" /></td>
                 </tr>
              </table>
              <table style="width:100%; text-align:center">
                 <tr>
                     <th>Ingrednets Needed</th>
                     <th>Qty</th>
                 </tr>
                 <tr>
                     <td><asp:Label Text="Empty" ID="ing1" runat="server" /></td>
                     <td><asp:Label Text="Empty" ID="ing1Q" runat="server" /></td>
                 </tr>
                 <tr>
                     <td><asp:Label Text="Empty" ID="ing2" runat="server" /></td>
                     <td><asp:Label Text="Empty" ID="ing2Q" runat="server" /></td>
                 </tr>
                 <tr>
                     <td><asp:Label Text="Empty" ID="ing3" runat="server" /></td>
                     <td><asp:Label Text="Empty" ID="ing3Q" runat="server" /></td>
                 </tr>
                 <tr>
                     <td><asp:Label Text="Empty" ID="ing4" runat="server" /></td>
                     <td><asp:Label Text="Empty" ID="ing4Q" runat="server" /></td>
                 </tr>
                 <tr>
                     <td><asp:Label Text="Empty" ID="ing5" runat="server" /></td>
                     <td><asp:Label Text="Empty" ID="ing5Q" runat="server" /></td>
                 </tr>
                 <tr>
                     <td><asp:Label Text="Empty" ID="ing6" runat="server" /></td>
                     <td><asp:Label Text="Empty" ID="ing6Q" runat="server" /></td>
                 </tr>
                 <tr>
                     <td><asp:Label Text="Empty" ID="ing7" runat="server" /></td>
                     <td><asp:Label Text="Empty" ID="ing7Q" runat="server" /></td>
                 </tr>
                 <tr>
                     <td><asp:Label Text="Empty" ID="ing8" runat="server" /></td>
                     <td><asp:Label Text="Empty" ID="ing8Q" runat="server" /></td>
                 </tr>
                 <tr>
                     <td><asp:Label Text="Empty" ID="ing9" runat="server" /></td>
                     <td><asp:Label Text="Empty" ID="ing9Q" runat="server" /></td>
                 </tr>
                  <tr>
                     <td><asp:Label Text="Empty" ID="ing10" runat="server" /></td>
                     <td><asp:Label Text="Empty" ID="ing10Q" runat="server" /></td>
                 </tr>
              </table>
              <table style="width:100%;">
                 <tr>
                     <th style="text-align:center">Instructions</th>
                 </tr>
                 <tr>
                     <td style="text-align:left"> <asp:Label Text="Step 1: Do this and this and this" ID="instructions" runat="server" /></td>
                 </tr>
                 <tr>
                     <th>Nutritional Information </th>
                 </tr>
             </table>
              <table style="width:100%; text-align:center;">
                 <tr> 
                  <th>Ingredient</th>
                  <th>Weight</th>
                  <th>Weight Type</th>  
                  <th>Fat</th>
                  <th>Salt</th>
                  <th>Suger</th>
                  <th>kCal</th>
                  <th>Saturates</th>
                  <th>Carbs</th>
                  <th>Fibre</th>
                  <th>Protein</th>
                     </tr>
                   <tr>
                      <td><asp:Label Text="Empty" ID="ing1NI" runat="server" /></td>
                      <td><asp:Label Text="N/A" ID="ing1Weight" runat="server" /></td>
                      <td><asp:Label Text="N/A" ID="ing1Type" runat="server" /></td>
                      <td><asp:Label Text="N/A" ID="ing1Fat" runat="server" /></td>
                      <td><asp:Label Text="N/A" ID="ing1Salt" runat="server" /></td>
                      <td><asp:Label Text="N/A" ID="ing1Sugar" runat="server" /></td>
                      <td><asp:Label Text="N/A" ID="ing1Kcal" runat="server" /></td>
                      <td><asp:Label Text="N/A" ID="ing1Sat" runat="server" /></td>
                      <td><asp:Label Text="N/A" ID="ing1Carbs" runat="server" /></td>
                      <td><asp:Label Text="N/A" ID="ing1Fibre" runat="server" /></td>
                      <td><asp:Label Text="N/A" ID="ing1Protein" runat="server" /></td>
                  </tr>
                  <tr>
                      <td><asp:Label Text="Empty" ID="ing2NI" runat="server" /></td>
                      <td><asp:Label Text="N/A" ID="ing2Weight" runat="server" /></td>
                      <td><asp:Label Text="N/A" ID="ing2Type" runat="server" /></td>
                      <td><asp:Label Text="N/A" ID="ing2Fat" runat="server" /></td>
                      <td><asp:Label Text="N/A" ID="ing2Salt" runat="server" /></td>
                      <td><asp:Label Text="N/A" ID="ing2Sugar" runat="server" /></td>
                      <td><asp:Label Text="N/A" ID="ing2Kcal" runat="server" /></td>
                      <td><asp:Label Text="N/A" ID="ing2Sat" runat="server" /></td>
                      <td><asp:Label Text="N/A" ID="ing2Carbs" runat="server" /></td>
                      <td><asp:Label Text="N/A" ID="ing2Fibre" runat="server" /></td>
                      <td><asp:Label Text="N/A" ID="ing2Protein" runat="server" /></td>
                  </tr>
                    <tr>
                      <td><asp:Label Text="Empty" ID="ing3NI" runat="server" /></td>
                      <td><asp:Label Text="N/A" ID="ing3Weight" runat="server" /></td>
                      <td><asp:Label Text="N/A" ID="ing3Type" runat="server" /></td>
                      <td><asp:Label Text="N/A" ID="ing3Fat" runat="server" /></td>
                      <td><asp:Label Text="N/A" ID="ing3Salt" runat="server" /></td>
                      <td><asp:Label Text="N/A" ID="ing3Sugar" runat="server" /></td>
                      <td><asp:Label Text="N/A" ID="ing3Kcal" runat="server" /></td>
                      <td><asp:Label Text="N/A" ID="ing3Sat" runat="server" /></td>
                      <td><asp:Label Text="N/A" ID="ing3Carbs" runat="server" /></td>
                      <td><asp:Label Text="N/A" ID="ing3Fibre" runat="server" /></td>
                      <td><asp:Label Text="N/A" ID="ing3Protein" runat="server" /></td>
                  </tr>
                  <tr>
                      <td><asp:Label Text="Empty" ID="ing4NI" runat="server" /></td>
                      <td><asp:Label Text="N/A" ID="ing4Weight" runat="server" /></td>
                      <td><asp:Label Text="N/A" ID="ing4Type" runat="server" /></td>
                      <td><asp:Label Text="N/A" ID="ing4Fat" runat="server" /></td>
                      <td><asp:Label Text="N/A" ID="ing4Salt" runat="server" /></td>
                      <td><asp:Label Text="N/A" ID="ing4Sugar" runat="server" /></td>
                      <td><asp:Label Text="N/A" ID="ing4Kcal" runat="server" /></td>
                      <td><asp:Label Text="N/A" ID="ing4Sat" runat="server" /></td>
                      <td><asp:Label Text="N/A" ID="ing4Carbs" runat="server" /></td>
                      <td><asp:Label Text="N/A" ID="ing4Fibre" runat="server" /></td>
                      <td><asp:Label Text="N/A" ID="ing4Protein" runat="server" /></td>
                  </tr>
                 <tr>
                      <td><asp:Label Text="Empty" ID="ing5NI" runat="server" /></td>
                      <td><asp:Label Text="N/A" ID="ing5Weight" runat="server" /></td>
                      <td><asp:Label Text="N/A" ID="ing5Type" runat="server" /></td>
                      <td><asp:Label Text="N/A" ID="ing5Fat" runat="server" /></td>
                      <td><asp:Label Text="N/A" ID="ing5Salt" runat="server" /></td>
                      <td><asp:Label Text="N/A" ID="ing5Sugar" runat="server" /></td>
                      <td><asp:Label Text="N/A" ID="ing5Kcal" runat="server" /></td>
                      <td><asp:Label Text="N/A" ID="ing5Sat" runat="server" /></td>
                      <td><asp:Label Text="N/A" ID="ing5Carbs" runat="server" /></td>
                      <td><asp:Label Text="N/A" ID="ing5Fibre" runat="server" /></td>
                      <td><asp:Label Text="N/A" ID="ing5Protein" runat="server" /></td>
                  </tr>
                     <tr>
                      <td><asp:Label Text="Empty" ID="ing6NI" runat="server" /></td>
                      <td><asp:Label Text="N/A" ID="ing6Weight" runat="server" /></td>
                      <td><asp:Label Text="N/A" ID="ing6Type" runat="server" /></td>
                      <td><asp:Label Text="N/A" ID="ing6Fat" runat="server" /></td>
                      <td><asp:Label Text="N/A" ID="ing6Salt" runat="server" /></td>
                      <td><asp:Label Text="N/A" ID="ing6Sugar" runat="server" /></td>
                      <td><asp:Label Text="N/A" ID="ing6Kcal" runat="server" /></td>
                      <td><asp:Label Text="N/A" ID="ing6Sat" runat="server" /></td>
                      <td><asp:Label Text="N/A" ID="ing6Carbs" runat="server" /></td>
                      <td><asp:Label Text="N/A" ID="ing6Fibre" runat="server" /></td>
                      <td><asp:Label Text="N/A" ID="ing6Protein" runat="server" /></td>
                  </tr>
                    <tr>
                      <td><asp:Label Text="Empty" ID="ing7NI" runat="server" /></td>
                      <td><asp:Label Text="N/A" ID="ing7Weight" runat="server" /></td>
                      <td><asp:Label Text="N/A" ID="ing7Type" runat="server" /></td>
                      <td><asp:Label Text="N/A" ID="ing7Fat" runat="server" /></td>
                      <td><asp:Label Text="N/A" ID="ing7Salt" runat="server" /></td>
                      <td><asp:Label Text="N/A" ID="ing7Sugar" runat="server" /></td>
                      <td><asp:Label Text="N/A" ID="ing7Kcal" runat="server" /></td>
                      <td><asp:Label Text="N/A" ID="ing7Sat" runat="server" /></td>
                      <td><asp:Label Text="N/A" ID="ing7Carbs" runat="server" /></td>
                      <td><asp:Label Text="N/A" ID="ing7Fibre" runat="server" /></td>
                      <td><asp:Label Text="N/A" ID="ing7Protein" runat="server" /></td>
                  </tr>
                   <tr>
                      <td><asp:Label Text="Empty" ID="ing8NI" runat="server" /></td>
                      <td><asp:Label Text="N/A" ID="ing8Weight" runat="server" /></td>
                      <td><asp:Label Text="N/A" ID="ing8Type" runat="server" /></td>
                      <td><asp:Label Text="N/A" ID="ing8Fat" runat="server" /></td>
                      <td><asp:Label Text="N/A" ID="ing8Salt" runat="server" /></td>
                      <td><asp:Label Text="N/A" ID="ing8Sugar" runat="server" /></td>
                      <td><asp:Label Text="N/A" ID="ing8Kcal" runat="server" /></td>
                      <td><asp:Label Text="N/A" ID="ing8Sat" runat="server" /></td>
                      <td><asp:Label Text="N/A" ID="ing8Carbs" runat="server" /></td>
                      <td><asp:Label Text="N/A" ID="ing8Fibre" runat="server" /></td>
                      <td><asp:Label Text="N/A" ID="ing8Protein" runat="server" /></td>
                  </tr>
                   <tr>
                      <td><asp:Label Text="Empty" ID="ing9NI" runat="server" /></td>
                      <td><asp:Label Text="N/A" ID="ing9Weight" runat="server" /></td>
                      <td><asp:Label Text="N/A" ID="ing9Type" runat="server" /></td>
                      <td><asp:Label Text="N/A" ID="ing9Fat" runat="server" /></td>
                      <td><asp:Label Text="N/A" ID="ing9Salt" runat="server" /></td>
                      <td><asp:Label Text="N/A" ID="ing9Sugar" runat="server" /></td>
                      <td><asp:Label Text="N/A" ID="ing9Kcal" runat="server" /></td>
                      <td><asp:Label Text="N/A" ID="ing9Sat" runat="server" /></td>
                      <td><asp:Label Text="N/A" ID="ing9Carbs" runat="server" /></td>
                      <td><asp:Label Text="N/A" ID="ing9Fibre" runat="server" /></td>
                      <td><asp:Label Text="N/A" ID="ing9Protein" runat="server" /></td>
                  </tr>
                    <tr>
                      <td><asp:Label Text="Empty" ID="ing10NI" runat="server" /></td>
                      <td><asp:Label Text="N/A" ID="ing10Weight" runat="server" /></td>
                      <td><asp:Label Text="N/A" ID="ing10Type" runat="server" /></td>
                      <td><asp:Label Text="N/A" ID="ing10Fat" runat="server" /></td>
                      <td><asp:Label Text="N/A" ID="ing10Salt" runat="server" /></td>
                      <td><asp:Label Text="N/A" ID="ing10Sugar" runat="server" /></td>
                      <td><asp:Label Text="N/A" ID="ing10Kcal" runat="server" /></td>
                      <td><asp:Label Text="N/A" ID="ing10Sat" runat="server" /></td>
                      <td><asp:Label Text="N/A" ID="ing10Carbs" runat="server" /></td>
                      <td><asp:Label Text="N/A" ID="ing10Fibre" runat="server" /></td>
                      <td><asp:Label Text="N/A" ID="ing10Protein" runat="server" /></td>
                  </tr>
              </table>


         </div>
         
       
    
    </div> 
        <!-- Body Div End --> 
    
    <!-- Footer Div start --> 
     <div id="footer">
         <div id="fb"><img src="websitefiles/images/Social Media/facebook.png" alt="Facebook" title="Facebook" width="75px" height="75px"></div>
         <div id="twit"><img src="websitefiles/images/Social Media/twitter.png" alt="Twitter" title="Twitter" width="75px" height="75px"></div>
         <div id="gp"><img src="websitefiles/images/Social Media/googleplus.png" alt="Google Plus" title="Google Plus" width="75px" height="75px"></div>
         <div id="insta"><img src="websitefiles/images/Social Media/instagram.png" alt="Instagram" title="Instagram" width="75px" height="75px"></div>    
    </div> 
        <!-- Footer Div End --> 





</asp:Content>
