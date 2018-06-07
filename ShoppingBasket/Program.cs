using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using BasketLibrary;
using System.Data.SqlClient;

namespace ShoppingBasket
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Initialise ShoppingBasket class
            BasketLibrary.ShoppingBasket basket = new BasketLibrary.ShoppingBasket();

            // Load products from database
            using (SqlConnection conn = new SqlConnection())
            {
                conn.ConnectionString = "Data Source=.\\SQLEXPRESS;Initial Catalog=Supermarket;Integrated Security=True";
                conn.Open();

                // Read rows from products table
                SqlCommand command = new SqlCommand("SELECT * FROM dbo.Products", conn);

                // Loop through each row in the results
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        // Add a unique product for each row, setting quantity to 0
                        basket.AddProduct((String)reader[2], Convert.ToDouble(reader[3]), 0);
                    }
                }
            }

            foreach(BasketItem item in basket.Items)
            {
                Console.WriteLine(item.ProductName);
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

        }
    }
}
