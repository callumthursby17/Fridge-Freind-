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

            //string[] userIngredients = new string[5] { "Bread", "Salt", "Egg", "", "" };

            //string[] recipeTitle = new string[12];

            string[,] totalDatabase = new string[12, 28];
            string[] userIngredients = new string[5] { "Butter", "Parmesan", "Ciabatta Bread", "Garlic", "Parsely" };


            SqlConnection newConnection = new SqlConnection(@"Data Source=BEN\SQLEXPRESS;Initial Catalog=MealMate;Integrated Security=True");
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = newConnection;
            newConnection.Open();
            SqlCommand command = new SqlCommand("SELECT * FROM Recipes", newConnection);

            using (SqlDataReader reader = command.ExecuteReader())
            {

                int counter = 0;
                reader.Read();
                for (int dbRow = 0; dbRow < 12; dbRow++)
                {
                    for (int dbCol = 0; dbCol < 28; dbCol++)
                    {
                        totalDatabase[dbRow, dbCol] = Convert.ToString(reader[counter]);
                        counter++;
                        if (counter > 27)
                        {
                            reader.Read();
                            counter = 0;
                        }

                    }

                }

                reader.Close();
            }
            newConnection.Close();




            for (int j = 0; j < 28; j++)
            {

                for (int k = 0; k < 11; k++)
                {
                    Console.WriteLine("{0}", totalDatabase[k, j]);
                }
            }
            Console.ReadLine();

            //Make a comparison of user input to database ingredients within recipes


            int userIngredientsScore = 0;


            for (int a = 0; a < totalDatabase.GetLength(0); a++)
            {
                for (int b = 0; b < totalDatabase.GetLength(1); b++)
                {
                    foreach (string index in userIngredients)
                    {
                        if (totalDatabase[a, b] == index)
                        {
                            Console.WriteLine("WE HAVE A MATCH = {0} @ location: {1},{2}", index, a, b);
                            userIngredientsScore++;

                        }
                    }
                }

            }
            Console.WriteLine("Score: " + userIngredientsScore);
            Console.ReadLine();

        }



        

    }
}
