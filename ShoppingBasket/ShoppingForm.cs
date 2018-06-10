using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BasketLibrary;
using System.Data.SqlClient;

namespace ShoppingBasket
{
    public partial class ShoppingForm : Form
    {
        // Instantiate basket class
        BasketLibrary.ShoppingBasket basket = new BasketLibrary.ShoppingBasket();

        public ShoppingForm()
        {
            InitializeComponent();

            // Add data to the the instance of ShoppingBasket
            loadBasketData(basket);
        }

        private void loadBasketData(BasketLibrary.ShoppingBasket basket)
        {
            LoadOffers(basket);
            LoadProducts(basket);

            // Set selected item of product combo box to be the first entry
            productComboBox.SelectedIndex = 0;
        }

        private void LoadOffers(BasketLibrary.ShoppingBasket basket)
        {
            // Load offers from database
            using (SqlConnection conn = new SqlConnection())
            {
                conn.ConnectionString = "Data Source=.\\SQLEXPRESS;Initial Catalog=Supermarket;Integrated Security=True";
                conn.Open();
                SqlCommand command = new SqlCommand("SELECT * FROM dbo.Offers", conn);

                // Loop through each row in the results
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        // Convert potential null in columns to be 0 to avoid type error
                        int realGroup = reader[3] == DBNull.Value ? 0 : Convert.ToInt32(reader[3]);
                        int realDiscount = reader[4] == DBNull.Value ? 0 : Convert.ToInt32(reader[4]);

                        // Add offer to the list of offers
                        Offer newOffer = new Offer(
                            Convert.ToInt32(reader[0]), (string)reader[1], (string)reader[2]
                            , realGroup, realDiscount);
                        basket.Offers.Add(newOffer);
                    }
                }
            }
        }

        private void LoadProducts(BasketLibrary.ShoppingBasket basket)
        {
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
                        string productName = (String)reader[2];
                        int realOfferId = reader[1] == DBNull.Value ? 0 : Convert.ToInt32(reader[1]);

                        basket.AddProduct(productName, 0, Convert.ToDouble(reader[3]), realOfferId);

                        // Add product name to drop down list of options
                        productComboBox.Items.Add(productName);
                    }
                }
            }
        }

        private void productComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox productBox = (ComboBox)sender;
            string productName = (string)productBox.SelectedItem;

            // Update form display to show information relating to selected product
            BasketItem selected = basket.Find(productName);
            priceTextBox.Text = string.Format("£{0:0.00}", selected.LatestPrice);
            offerText.Text = selected.Offer.Description;
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            int quantity = (int)quantityInput.Value;
            BasketItem selected = basket.Find((string)productComboBox.SelectedItem);
            selected.AddItems(quantity);

            DrawBasket();
        }

        private void DrawBasket()
        {
            // Update display to show current state of basket

            // Clear the list so we can add the fresh set of items
            basketList.Items.Clear();

            foreach(BasketItem item in basket.BasketItems)
            {
                // Add another row in the list view for each product that has a quantity more than 0
                if(item.Quantity > 0)
                {
                    ListViewItem listItem = new ListViewItem(new[]
                    {
                        item.ProductName,
                        item.Quantity.ToString(),
                        item.Offer.Description,
                        String.Format("£{0:0.00}", item.LatestPrice),
                        String.Format("£{0:0.00}", item.DiscountedPrice),
                        String.Format("£{0:0.00}", item.TotalItemValue),
                        ""
                    });
                    basketList.Items.Add(listItem);
                }
            }

            totalText.Text = String.Format("£{0:0.00}", basket.BasketTotal);
            noItemsText.Text = Convert.ToString(basket.NumberOfItems);
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            basket.ClearBasket();
            DrawBasket();
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            // Check if any row is selected in the list view
            if (basketList.SelectedItems.Count > 0)
            {
                // Remove the product if a something is selected
                basket.RemoveProduct(basketList.SelectedItems[0].Text);
                DrawBasket();
            }
            else
            {
                MessageBox.Show("No product selected");
            }
        }
    }
}
