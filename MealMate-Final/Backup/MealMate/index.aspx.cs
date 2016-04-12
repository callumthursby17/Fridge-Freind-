using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Data.SqlClient;
using System.Data; 

using System.Web.UI.HtmlControls; 

namespace MealMate
{
    public partial class _Default : System.Web.UI.Page
    {
        void Page_Load(Object sender, EventArgs e)
        {
            string ing1 = ingredient1.Value;

            if (ing1 != "")
            {
                ScriptManager.RegisterStartupScript(this, GetType(), "fadeinPart2", " fadeINpickRep();", true);
            }
        }


        protected void submit_Click(object sender, EventArgs e)
        {
          

            string[] userIngredients = new string[5] { ingredient1.Value, ingredient2.Value, ingredient3.Value, ingredient4.Value, ingredient5.Value };

 
            //string[] userIngredients = new string[5] { "Butter", "Parmesan", "Ciabatta Bread", "Garlic", "Parsely" };
            //string[] userIngredients = new string[5] { "Butter", "Caster Sugar", "Eggs", "Self-Raising Flour", "Baking Powder" };
            //string[] userIngredients = new string[5] {  };


            SqlConnection newConnection = new SqlConnection(@"Data Source=BEN\SQLEXPRESS;Initial Catalog=MealMate;Integrated Security=True");
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = newConnection;
            newConnection.Open();
            SqlCommand command = new SqlCommand("SELECT * FROM Recipes", newConnection);

            int rowCount = 0;
            int columnCount = 0;
            //Gets the number of Rows and Columns in the database
            using (SqlDataReader getRowCount = command.ExecuteReader())
            {
                while (getRowCount.Read())
                {
                    rowCount++;
                }
                columnCount = getRowCount.FieldCount;
            }

            //Allocates the correct amount of memory for the size of the multi-dimentional array
            string[,] recipeDatabase = new string[rowCount, columnCount];

            using (SqlDataReader reader = command.ExecuteReader())
            {
                int counter = 0;
                reader.Read();
                for (int dbRow = 0; dbRow < rowCount; dbRow++)
                {
                    for (int dbCol = 0; dbCol < columnCount; dbCol++)
                    {
                        recipeDatabase[dbRow, dbCol] = Convert.ToString(reader[counter]);
                        counter++;
                        if (counter > columnCount - 1)
                        {
                            reader.Read();
                            counter = 0;
                        }
                    }
                }
                reader.Close();
            }


            //Make a comparison of user input to database ingredients within recipes
            int userIngredientsScore = 0;
            int highestScoreRow = -1;
            int currentRowScore = 0;

            for (int a = 0; a < recipeDatabase.GetLength(0); a++)
            {

                for (int b = 0; b < recipeDatabase.GetLength(1); b++)
                {
                    foreach (string index in userIngredients)
                    {
                        if (recipeDatabase[a, b] == index)
                        {
                       currentRowScore++;
                            if (currentRowScore >= userIngredientsScore)
                            {
                                userIngredientsScore = currentRowScore;
                                highestScoreRow = a;
                            }
                        }
                    }
                }
                currentRowScore = 0;
            }

            string[] finalRecipeArray = new string[columnCount];
            //Output the Cloest Recipe Match
            try
            {
                for (int i = 0; i < columnCount; i++)
                {                 
                    finalRecipeArray[i] = recipeDatabase[highestScoreRow, i];
                }
            }
            catch
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('No Matches Found!')", true);
            }
            Console.ReadLine();

            SqlCommand ingredientsCommand = new SqlCommand("SELECT * FROM Ingredients", newConnection);
            rowCount = 0;
            //Gets the number of Rows and Columns in the database
            using (SqlDataReader getRowCount = ingredientsCommand.ExecuteReader())
            {
                while (getRowCount.Read())
                {
                    rowCount++;
                }
                columnCount = getRowCount.FieldCount;
            }


            //Gets the number of Rows and Columns in the database
            string[,] ingredientsDatabase = new string[rowCount, columnCount];
            using (SqlDataReader newReader = ingredientsCommand.ExecuteReader())
            {
                int counter = 0;
                newReader.Read();
                for (int dbRow = 0; dbRow < rowCount; dbRow++)
                {
                    for (int dbCol = 0; dbCol < columnCount; dbCol++)
                    {
                        ingredientsDatabase[dbRow, dbCol] = Convert.ToString(newReader[counter]);
                        counter++;
                        if (counter > columnCount - 1)
                        {
                            newReader.Read();
                            counter = 0;
                        }
                    }
                }
                newReader.Close();
            }

            //Matches Ingredients in Recipe Database to their properties in the ingredients database
            string[] finalIngredientArray = new string[11];
            int finalRecipeInt = 8;
            while (finalRecipeInt < 28)
            {
                for (int i = 0; i < ingredientsDatabase.GetLength(0); i++)
                {
                    for (int j = 0; j < ingredientsDatabase.GetLength(1); j++)
                    {
                        if (finalRecipeArray[finalRecipeInt] == ingredientsDatabase[i, 0])
                        {
                            for (int index = 0; index < 11; index++)
                            {
                                finalIngredientArray[index] = ingredientsDatabase[i, index];
                            }
                            Console.WriteLine(String.Format("Ingredient:{0} \t | Weight:{1}{2} \t | Fat{3}g \t| Salt:{4}g \t | Sugar:{5} \t | kCal:{6} \t | Saturates:{7}g \t| Carbs:{8}g \t | Fibre:{9}g \t | Protein:{10}g",
                                // call the objects from their index
                        finalIngredientArray[0], finalIngredientArray[1], finalIngredientArray[2], finalIngredientArray[3], finalIngredientArray[4], finalIngredientArray[5], finalIngredientArray[6], finalIngredientArray[7], finalIngredientArray[8], finalIngredientArray[9], finalIngredientArray[10]));
                            break;
                        }
                    }
                }
                finalRecipeInt = finalRecipeInt + 2;
            }
            Console.ReadLine();
            newConnection.Close();

          
            recipeName.Text = finalRecipeArray[1];
            amountServe.Text = finalRecipeArray[2];
            prepTime.Text = finalRecipeArray[3];
            cookTime.Text = finalRecipeArray[4]; 
            

        }
    }
}

           

        
    
