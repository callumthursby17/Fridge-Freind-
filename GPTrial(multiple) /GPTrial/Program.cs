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
            string[,] totalDatabase = new string[12, 28];
            //string[] userIngredients = new string[5] { "Butter", "Parmesan", "Ciabatta Bread", "Garlic", "Parsely" };
            string[] userIngredients = new string[5] { "Butter", "Caster Sugar", "Eggs", "Self-Raising Flour", "Baking Powder" };


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

            //Output the Cloest Recipe Match
            for (int i = 0; i < 28; i++)
            {
                Console.WriteLine("{0}", totalDatabase[highestScoreRow, i]);
            }
            Console.ReadLine();

        }





    }
}
