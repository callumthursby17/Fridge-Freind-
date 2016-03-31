using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace GroupProject
{
    class Program
    {
        static void Main(string[] args)
        {

            //string[] userIngredients = new string[5] { "Butter", "Parmesan", "Ciabatta Bread", "Garlic", "Parsely" };
            //string[] userIngredients = new string[5] { "Butter", "Caster Sugar", "Eggs", "Self-Raising Flour", "Baking Powder" };
            string[] userIngredients = new string[5] { "Whole Milk", "Caster Sugar", "Eggs", "Double Cream", "Baking Powder" };


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
            string[,] totalDatabase = new string[rowCount, columnCount];

            using (SqlDataReader reader = command.ExecuteReader())
            {
                int counter = 0;
                reader.Read();
                for (int dbRow = 0; dbRow < rowCount; dbRow++)
                {
                    for (int dbCol = 0; dbCol < columnCount; dbCol++)
                    {
                        totalDatabase[dbRow, dbCol] = Convert.ToString(reader[counter]);
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

            for (int a = 0; a < totalDatabase.GetLength(0); a++)
            {

                for (int b = 0; b < totalDatabase.GetLength(1); b++)
                {
                    foreach (string index in userIngredients)
                    {
                        if (totalDatabase[a, b] == index)
                        {
                            Console.WriteLine("WE HAVE A MATCH = {0} @ location: {1},{2}", index, a, b);
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
                    Console.WriteLine("{0}", totalDatabase[highestScoreRow, i]);
                    finalRecipeArray[i] = totalDatabase[highestScoreRow, i];
                }
            }
            catch
            {
                Console.WriteLine("No matches found");
            }
            Console.ReadLine();

            SqlCommand ingredientsCommand = new SqlCommand("SELECT * FROM Ingredients", newConnection);

            //Gets the number of Rows and Columns in the database
            int z = 0;
            string[,] ingredientsDatabase = new string[56, 11];
            using (SqlDataReader newReader = ingredientsCommand.ExecuteReader())
            {
                int counter = 0;
                newReader.Read();
                for (int dbRow = 0; dbRow < 56; dbRow++)
                {
                    for (int dbCol = 0; dbCol < 11; dbCol++)
                    {
                        ingredientsDatabase[dbRow, dbCol] = Convert.ToString(newReader[counter]);
                        counter++;
                        if (counter > 10)
                        {
                            newReader.Read();
                            counter = 0;
                        }
                    }
                }
                newReader.Close();
            }

            string[] finalIngredientArray = new string[11];
            //Matches Ingredients in Recipe Database to their properties in the ingredients database
            for (int i = 0; i < 56; i++)
            {
                for (int j = 0; j < 11; j++)
                {
                    if (finalRecipeArray[8] == ingredientsDatabase[i, 0])
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
                    if (finalRecipeArray[10] == ingredientsDatabase[i, 0])
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
                    if (finalRecipeArray[12] == ingredientsDatabase[i, 0])
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
                    if (finalRecipeArray[14] == ingredientsDatabase[i, 0])
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
                    if (finalRecipeArray[16] == ingredientsDatabase[i, 0])
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
                    if (finalRecipeArray[18] == ingredientsDatabase[i, 0])
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
                    if (finalRecipeArray[20] == ingredientsDatabase[i, 0])
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
                    if (finalRecipeArray[22] == ingredientsDatabase[i, 0])
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
                    if (finalRecipeArray[24] == ingredientsDatabase[i, 0])
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
                    if (finalRecipeArray[26] == ingredientsDatabase[i, 0])
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

            Console.ReadLine();

            newConnection.Close();
        }





    }
}
