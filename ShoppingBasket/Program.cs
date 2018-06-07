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

            // Create list of Offer object
            List<Offer> offers = new List<Offer>();

            // Load offers from database
            using (SqlConnection conn = new SqlConnection())
            {
                conn.ConnectionString = "Data Source=.\\SQLEXPRESS;Initial Catalog=Supermarket;Integrated Security=True";
                conn.Open();

                // Read rows from products table
                SqlCommand command = new SqlCommand("SELECT * FROM dbo.Offers", conn);

                // Loop through each row in the results
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        // Add each offer to the list of offers

                        // Convert potential null in group column to be 0 to avoid type error
                        int realGroup;
                        int realDiscount;
                        if (reader[3] == DBNull.Value)
                        {
                            realGroup = 0;
                        }
                        else
                        {
                            realGroup = Convert.ToInt32(reader[3]);
                        }
                        if (reader[4] == DBNull.Value)
                        {
                            realDiscount = 0;
                        }
                        else
                        {
                            realDiscount = Convert.ToInt32(reader[4]);
                        }

                        Offer newOffer = new Offer(
                            Convert.ToInt32(reader[0]), (string)reader[1], (string)reader[2]
                            , realGroup, realDiscount);
                        offers.Add(newOffer);
                    }
                }
            }

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
                        // get offer details for each product
                        basket.AddProduct((String)reader[2], Convert.ToDouble(reader[3]), 0);

                        // Add product name to drop down list of options
                        //ProductComboBox.
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
