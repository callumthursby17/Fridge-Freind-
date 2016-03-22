/**
* Created with Meal Mate V2.
* User: callumthursby
* Date: 2016-03-21
* Time: 05:17 PM
* To change this template use Tools | Templates.
*/

 $(function() {

        // select all desired input fields and attach tooltips to them
      $("#enterIng :input").tooltip({

      // place tooltip on the right edge
      position: "center right",

      // a little tweaking of the position
      offset: [-2, 10],

      // use the built-in fadeIn/fadeOut effect
      effect: "fade",

      // custom opacity setting
      opacity: 0.7

      });
    });