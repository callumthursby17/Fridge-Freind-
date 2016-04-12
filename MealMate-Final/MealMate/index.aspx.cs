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
            Button1.Click += new EventHandler(this.Button1_Click); 
        }


   

        protected void Button1_Click(object sender, EventArgs e)
        {

            //THE FINAL ARRAY IS NAMED newFinalArray JUST INDEX THIS AND MATCH TO YOUR OUTPUT

            //string[] userIngredients = new string[5] { "Butter", "Parmesan", "Ciabatta Bread", "Garlic", "Parsely" };
            //string[] userIngredients = new string[5] { "Butter", "Caster Sugar", "Eggs", "Self-Raising Flour", "Baking Powder" };
            // string[] userIngredients = new string[5] { "Whole Milk", "Caster Sugar", "Eggs", "Double Cream", "Baking Powder" };
            string[] userIngredients = new string[5] { ingredient1.Value, ingredient2.Value, ingredient3.Value, ingredient4.Value, ingredient5.Value };
            _Default newProgram = new _Default();

            SqlConnection newConnection = new SqlConnection("Server = tcp:lincolncathedral.database.windows.net,1433; Database = MealMate1; User ID = superadmin@lincolncathedral; Password = Lincolncollege1; Encrypt = True; TrustServerCertificate = False; Connection Timeout = 5000");

            //SqlConnection newConnection = new SqlConnection(@"Data Source=BEN\SQLEXPRESS;Initial Catalog=MealMate;Integrated Security=True");
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
                    // Console.WriteLine("{0}", recipeDatabase[highestScoreRow, i]);
                    finalRecipeArray[i] = recipeDatabase[highestScoreRow, i];
                }
            }
            catch
            {
                // Console.WriteLine("No matches found");
            }

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
            string[] newFinalArray = new string[9999];
            int finalRecipeInt = 8;
            newFinalArray = newProgram.FinalArrayCreator(finalIngredientArray, finalRecipeArray);
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
                            newFinalArray = newProgram.AddToFinalArray(finalIngredientArray, newFinalArray);
                            break;
                        }
                    }
                }

                finalRecipeInt = finalRecipeInt + 2;

            }
            newConnection.Close();

            recipeName.Text = newFinalArray[1];
            amountServe.Text = newFinalArray[2];
            prepTime.Text = newFinalArray[4];
            cookTime.Text = newFinalArray[5];

            //Final Ouput upon diaplaying final recipe 
            recipeName2.Text = newFinalArray[1];
            amountServe2.Text = newFinalArray[2];
            dishType.Text = newFinalArray[3];
            prepTime2.Text = newFinalArray[4];
            cookTime2.Text = newFinalArray[5];
            instructions.Text = newFinalArray[6];
            ing1.Text = newFinalArray[8];
            ing1Q.Text = newFinalArray[9];
            ing2.Text = newFinalArray[10];
            ing2Q.Text = newFinalArray[11];
            ing3.Text = newFinalArray[12];
            ing3Q.Text = newFinalArray[13];
            ing4.Text = newFinalArray[14];
            ing4Q.Text = newFinalArray[15];
            ing5.Text = newFinalArray[16];
            ing5Q.Text = newFinalArray[17];
            ing6.Text = newFinalArray[18];
            ing6Q.Text = newFinalArray[19];
            ing7.Text = newFinalArray[20];
            ing7Q.Text = newFinalArray[21];
            ing8.Text = newFinalArray[22];
            ing8Q.Text = newFinalArray[23];
            ing9.Text = newFinalArray[24];
            ing9Q.Text = newFinalArray[25];
            ing10.Text = newFinalArray[26];
            ing10Q.Text = newFinalArray[27];
            // Final Output nutritional Information
            ing1NI.Text = newFinalArray[28];
            ing1Weight.Text = newFinalArray[29];
            ing1Type.Text = newFinalArray[30];
            ing1Fat.Text = newFinalArray[31];
            ing1Salt.Text = newFinalArray[32];
            ing1Sugar.Text = newFinalArray[33];
            ing1Kcal.Text = newFinalArray[34];
            ing1Sat.Text = newFinalArray[35];
            ing1Carbs.Text = newFinalArray[36];
            ing1Fibre.Text = newFinalArray[37];
            ing1Protein.Text = newFinalArray[38];

            ing2NI.Text = newFinalArray[39];
            ing2Weight.Text = newFinalArray[40];
            ing2Type.Text = newFinalArray[41];
            ing2Fat.Text = newFinalArray[42];
            ing2Salt.Text = newFinalArray[43];
            ing2Sugar.Text = newFinalArray[44];
            ing2Kcal.Text = newFinalArray[45];
            ing2Sat.Text = newFinalArray[46];
            ing2Carbs.Text = newFinalArray[47];
            ing2Fibre.Text = newFinalArray[48];
            ing2Protein.Text = newFinalArray[49];

            ing3NI.Text = newFinalArray[50];
            ing3Weight.Text = newFinalArray[51];
            ing3Type.Text = newFinalArray[52];
            ing3Fat.Text = newFinalArray[53];
            ing3Salt.Text = newFinalArray[54];
            ing3Sugar.Text = newFinalArray[55];
            ing3Kcal.Text = newFinalArray[56];
            ing3Sat.Text = newFinalArray[57];
            ing3Carbs.Text = newFinalArray[58];
            ing3Fibre.Text = newFinalArray[59];
            ing3Protein.Text = newFinalArray[60];

            ing4NI.Text = newFinalArray[61];
            ing4Weight.Text = newFinalArray[62];
            ing4Type.Text = newFinalArray[63];
            ing4Fat.Text = newFinalArray[64];
            ing4Salt.Text = newFinalArray[65];
            ing4Sugar.Text = newFinalArray[66];
            ing4Kcal.Text = newFinalArray[67];
            ing4Sat.Text = newFinalArray[68];
            ing4Carbs.Text = newFinalArray[69];
            ing4Fibre.Text = newFinalArray[70];
            ing4Protein.Text = newFinalArray[71];

            ing5NI.Text = newFinalArray[72];
            ing5Weight.Text = newFinalArray[73];
            ing5Type.Text = newFinalArray[74];
            ing5Fat.Text = newFinalArray[75];
            ing5Salt.Text = newFinalArray[76];
            ing5Sugar.Text = newFinalArray[77];
            ing5Kcal.Text = newFinalArray[78];
            ing5Sat.Text = newFinalArray[79];
            ing5Carbs.Text = newFinalArray[80];
            ing5Fibre.Text = newFinalArray[81];
            ing5Protein.Text = newFinalArray[82];

            ing6NI.Text = newFinalArray[83];
            ing6Weight.Text = newFinalArray[84];
            ing6Type.Text = newFinalArray[85];
            ing6Fat.Text = newFinalArray[86];
            ing6Salt.Text = newFinalArray[87];
            ing6Sugar.Text = newFinalArray[88];
            ing6Kcal.Text = newFinalArray[89];
            ing6Sat.Text = newFinalArray[90];
            ing6Carbs.Text = newFinalArray[91];
            ing6Fibre.Text = newFinalArray[92];
            ing6Protein.Text = newFinalArray[93];

            ing7NI.Text = newFinalArray[94];
            ing7Weight.Text = newFinalArray[95];
            ing7Type.Text = newFinalArray[96];
            ing7Fat.Text = newFinalArray[97];
            ing7Salt.Text = newFinalArray[98];
            ing7Sugar.Text = newFinalArray[99];
            ing7Kcal.Text = newFinalArray[100];
            ing7Sat.Text = newFinalArray[101];
            ing7Carbs.Text = newFinalArray[102];
            ing7Fibre.Text = newFinalArray[103];
            ing7Protein.Text = newFinalArray[104];

            ing8NI.Text = newFinalArray[105];
            ing8Weight.Text = newFinalArray[106];
            ing8Type.Text = newFinalArray[107];
            ing8Fat.Text = newFinalArray[108];
            ing8Salt.Text = newFinalArray[109];
            ing8Sugar.Text = newFinalArray[110];
            ing8Kcal.Text = newFinalArray[111];
            ing8Sat.Text = newFinalArray[112];
            ing8Carbs.Text = newFinalArray[113];
            ing8Fibre.Text = newFinalArray[114];
            ing8Protein.Text = newFinalArray[115];

            ing9NI.Text = newFinalArray[116];
            ing9Weight.Text = newFinalArray[117];
            ing9Type.Text = newFinalArray[118];
            ing9Fat.Text = newFinalArray[119];
            ing9Salt.Text = newFinalArray[120];
            ing9Sugar.Text = newFinalArray[121];
            ing9Kcal.Text = newFinalArray[122];
            ing9Sat.Text = newFinalArray[123];
            ing9Carbs.Text = newFinalArray[124];
            ing9Fibre.Text = newFinalArray[125];
            ing9Protein.Text = newFinalArray[126];

            ing10NI.Text = newFinalArray[127];
            ing10Weight.Text = newFinalArray[128];
            ing10Type.Text = newFinalArray[129];
            ing10Fat.Text = newFinalArray[130];
            ing10Salt.Text = newFinalArray[131];
            ing10Sugar.Text = newFinalArray[132];
            ing10Kcal.Text = newFinalArray[133];
            ing10Sat.Text = newFinalArray[134];
            ing10Carbs.Text = newFinalArray[135];
            ing10Fibre.Text = newFinalArray[136];
            ing10Protein.Text = newFinalArray[137];

        }

        public string[] FinalArrayCreator(string[] ingredientArray, string[] recipeArray)
        {
            string[] newFinalArray = new string[ingredientArray.Count() + recipeArray.Count()];

            for (int i = 0; i < newFinalArray.Length; i++)
            {
                if (i < recipeArray.Length)
                {
                    newFinalArray[i] = recipeArray[i];
                }
                else
                {
                    newFinalArray[i] = ingredientArray[i - recipeArray.Length];
                }
            }

            return newFinalArray;
        }





        public string[] AddToFinalArray(string[] ingredientArray, string[] existingArray)
        {
            string[] newArray = new string[ingredientArray.Count() + existingArray.Count()];

            for (int i = 0; i < ingredientArray.Count() + existingArray.Count(); i++)
            {
                if (i < existingArray.Length)
                {
                    newArray[i] = existingArray[i];
                }
                else
                {
                    newArray[i] = ingredientArray[i - existingArray.Length];
                }
            }
         

            return newArray;


        }
    }
    }




