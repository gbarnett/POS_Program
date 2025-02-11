using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using MySql.Data.MySqlClient;
using POS_Program.Classes;

namespace POS_Program.DatabaseTransactions
{
    internal class OrderTransactions
    {
        public static bool CreateNewOrder(Order order)
        {
            var conn = DatabaseConnection.ConnectToSchema();
            string commandText = "INSERT INTO `Order` (Date, CUSTOMERID, Name, Total) " +
                                 "VALUES (@Date, @CustomerID, @Name, @Total);";
            conn.Open();
            try
            {
                using (MySqlCommand insertOrder = new MySqlCommand(commandText, conn))
                {
                    insertOrder.Parameters.AddWithValue("@Date", order.Date);
                    insertOrder.Parameters.AddWithValue("@CustomerID", order.CustomerID);
                    insertOrder.Parameters.AddWithValue("@Name", order.Name);
                    insertOrder.Parameters.AddWithValue("@Total", order.Total);

                    insertOrder.ExecuteNonQuery();

                    conn.Close();
                    return true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                conn.Close();
                return false;
            }
        }

        public static int GetLatestOrderID()
        {
            int orderID;
            var conn = DatabaseConnection.ConnectToSchema();
            string commandText = "SELECT MAX(ID) FROM `ORDER`;";
            conn.Open();
            using(MySqlCommand command = new MySqlCommand(commandText, conn))
            {
                orderID = Convert.ToInt32(command.ExecuteScalar());
            }
            conn.Close();
            return orderID;
        }

        public static List<Order> GetAllOrders()
        {
            List<Order> orders = new List<Order>();
            var conn = DatabaseConnection.ConnectToSchema();
            string commandText = "SELECT * FROM `ORDER`";
            conn.Open();
            try
            {
                using (MySqlCommand command = new MySqlCommand(commandText, conn))
                {
                    MySqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        Order order = new Order();
                        order.ID = Convert.ToInt32(reader["ID"]);
                        order.Date = (DateTime)reader["Date"];
                        order.CustomerID = Convert.ToInt32(reader["CUSTOMERID"]);
                        order.Name = reader["Name"].ToString();
                        order.Total = Convert.ToDecimal(reader["Total"]);
                        orders.Add(order);
                    }
                }
                conn.Close();
                return orders;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                conn.Close();
                return null;
            }
        }

        public static bool AddOrderItem(Product product, int orderID)
        {
            var conn = DatabaseConnection.ConnectToSchema();
            string commandText = "INSERT INTO ORDERITEMS (OrderID , ProductID) " +
                                 "VALUES (@OrderID, @ProductID)";
            conn.Open();
            try
            {
                using (MySqlCommand command = new MySqlCommand(commandText, conn))
                {
                    command.Parameters.AddWithValue("@OrderID", orderID);
                    command.Parameters.AddWithValue("@ProductID", product.ID);
                    command.ExecuteNonQuery();
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

        public static bool DeleteOrder(Order order)
        {
            var conn = DatabaseConnection.ConnectToSchema();
            string commandText = "DELETE FROM `ORDER` WHERE ID = @id";
            conn.Open();
            try
            {
                using (MySqlCommand deleteOrder = new MySqlCommand(commandText, conn))
                {
                    deleteOrder.Parameters.AddWithValue("@id", order.ID);
                    deleteOrder.ExecuteNonQuery();
                }
                conn.Close();
                return true;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                conn.Close();
                return false;
            }
        }

        public static List<Product> GetOrderItems(Order order)
        {
            List<Product> products = new List<Product>();
            string commandText = "SELECT Product.ID, Product.Name, Product.Price, Product.Description " +
                                 "FROM OrderItems " +
                                 "JOIN Product ON orderitems.ProductID = Product.ID " +
                                 "WHERE orderitems.OrderID = @OrderID;";
            MySqlConnection conn = DatabaseConnection.ConnectToSchema();
            conn.Open();
            try
            {
                using(MySqlCommand command = new MySqlCommand(commandText, conn))
                {
                    command.Parameters.AddWithValue("@OrderID", order.ID);
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
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
                }
                conn.Close();
                return products;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                conn.Close();
                return null;
            }
        }
    }
}
