using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;

using System.Web.UI.HtmlControls; 

namespace MealMate
{
    public partial class _Default : System.Web.UI.Page
    {
        void Page_Load(Object sender, EventArgs e)
        {
            
        }


        protected void submit_Click(object sender, EventArgs e)
        {
          

            string[] ingredients = new string[5] { ingredient1.Value, ingredient2.Value, ingredient3.Value, ingredient4.Value, ingredient5.Value };
        }
    }
}
