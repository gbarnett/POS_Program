using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using POS_Program.Classes;

namespace POS_Program.DatabaseTransactions
{
    internal class ProductTransactions
    {
        public static bool AddProduct(Product product)
        {
            DatabaseConnection db = new DatabaseConnection();
            var conn = DatabaseConnection.ConnectToSchema();
            conn.Open();
            string commandText = "INSERT INTO Product (Name, Price, Description) " +
                                 "VALUES(@Name, @Price, @Description);";
            try
            {
                using (MySqlCommand insertProduct = new MySqlCommand(commandText, conn))
                {
                    insertProduct.Parameters.AddWithValue("@Name", product.Name);
                    insertProduct.Parameters.AddWithValue("@Price", product.Price);
                    insertProduct.Parameters.AddWithValue("@Description", product.Description);

                    insertProduct.ExecuteNonQuery();
                    conn.Close();
                    return true;
                }
            }
            catch (Exception ex) { MessageBox.Show("Failed to insert product" + ex.Message); conn.Close(); return false; }
        }

        public bool DeleteProduct(Product product)
        {
            var conn = DatabaseConnection.ConnectToSchema();
            conn.Open();
            string commandText = "DELETE FROM Product WHERE Product.ID = @id;";
            try
            {
                using (MySqlCommand deleteProduct = new MySqlCommand(commandText, conn))
                {
                    deleteProduct.Parameters.AddWithValue("@id",product.ID);
                    deleteProduct.ExecuteNonQuery();
                }
                conn.Close();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to delete product");
                conn.Close();
                return false;
            }
        }

        public static List<Product> GetAllProducts()
        {
            List<Product> products = new List<Product>();
            var conn = DatabaseConnection.ConnectToSchema();
            conn.Open();
            string commandText = "SELECT * FROM Product";
            try
            {
                using (MySqlCommand getProducts = new MySqlCommand(commandText, conn))
                {
                    MySqlDataReader reader = getProducts.ExecuteReader();
                    while (reader.Read())
                    {
                        Product product = new Product();
                        product.ID = Convert.ToInt32(reader["ID"]);
                        product.Name = reader["Name"].ToString();
                        product.Price = Convert.ToDecimal(reader["Price"]);
                        product.Description = reader["Description"].ToString();
                        products.Add(product);
                    }
                }
                return products;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Failed to get Prodcuts");
                return null;
            }
        }

        public static bool EditProduct(Product product)
        {
            var conn = DatabaseConnection.ConnectToSchema();
            conn.Open();
            string commandText = "UPDATE PRODUCT " +
                                 "SET Name = @Name , Price = @Price , Description = @Description " +
                                 "WHERE Product.ID = @id;";
            try
            {
                using (MySqlCommand editProduct = new MySqlCommand(commandText, conn))
                {
                    editProduct.Parameters.AddWithValue("@ID", product.ID);
                    editProduct.Parameters.AddWithValue("@Name",product.Name);
                    editProduct.Parameters.AddWithValue("@Price", product.Price);
                    editProduct.Parameters.AddWithValue("@Description", product.Description);
                    editProduct.ExecuteNonQuery();
                }
                conn.Close();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                conn.Close();
                return false;
            }
        }


    }
}
