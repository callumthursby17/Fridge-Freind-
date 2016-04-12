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

   
   <script type="text/javascript">

       function fadeINpickRep() {
           
               document.getElementById("pickRep").className = "fade-in"
               document.getElementById("pickRepBG").className = "fade-out"
               submitBtn.value = "Reset Ingredients";
           
          
       }
   
   </script>
   
    
    

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
             Adjust Test Size
             
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
             
             <form id="enterIng" name="enterIng" method="post">
                 
                 <label for="ingredient1">Ingredient 1:</label>
                 <input  autofocus type="text" id="ingredient1" name="ingredient1" runat="server" placeholder="e.g Bread..." maxlength="30" size="30" title="e.g Eggs, Milk, Bread etc">
                 <br><br>
                 <label for="ingredient2">Ingredient 2:</label>
                 <input type="text" id="ingredient2" runat="server" placeholder="e.g Eggs..." maxlength="30" size="30" title="e.g Eggs, Milk, Bread etc">
                 <br><br>
                 <label for="ingredient3">Ingredient 3:</label>
                 <input type="text" id="ingredient3" runat="server" placeholder="e.g Milk..." maxlength="30" size="30" title="e.g Eggs, Milk, Bread etc">
                 <br><br>
                 <label for="ingredient4">Ingredient 4:</label>
                 <input type="text" id="ingredient4" runat="server" placeholder="e.g Fish..." maxlength="30" size="30" title="e.g Eggs, Milk, Bread etc">
                 <br><br>
                 <label for="ingredient5">Ingredient 5:</label>
                 <input type="text" id="ingredient5" runat="server" placeholder="e.g Chicken..." maxlength="30" size="30" title="e.g Eggs, Milk, Bread etc">
                 
           <input id="submitBtn" type="submit" value="Submit Ingredients" runat="server" OnClick="validateForm(this); submit_Click;"/>
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
             <br><br>
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
             <br>
             <input id="submitBtn2" type="button" value="Submit Recipe" onclick="fadeINdisplayRep(this);">
         </div>
        
         <div id="displayRepBG">
             <h3>Step 3</h3>
             <h4>(Only available after Step 2)</h4>
             
         </div>
        
         <div id="displayRep">
             <h3> Step 3 <br> <br> Ready, Steady, Cook  </h3>
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
