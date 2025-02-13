using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using POS_Program.Classes;

namespace POS_Program.DatabaseTransactions
{
    public class SalesReportTransactions
    {
        public static List<Order> DailyOrders()
        {
            List<Order> orders = new List<Order>();
            var conn = DatabaseConnection.ConnectToSchema();
            string commandText = "SELECT * FROM `Order` WHERE day(`date`) = day(CURRENT_DATE())";
            conn.Open();
            try
            {
                using (MySqlCommand dailyOrders = new MySqlCommand(commandText, conn))
                {
                    using (MySqlDataReader reader = dailyOrders.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Order order = new Order();
                            order.ID = Convert.ToInt32(reader["ID"]);
                            order.Date = Convert.ToDateTime(reader["Date"]);
                            order.CustomerID = Convert.ToInt32(reader["CUSTOMERID"]);
                            order.Name = reader["Name"].ToString();
                            order.Total = Convert.ToDecimal(reader["Total"]);
                            orders.Add(order);
                        }
                    }
                }
                conn.Close();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
            return orders;
        }

        public static List<Order> MonthlyOrders()
        {
            List<Order> orders = new List<Order>();
            var conn = DatabaseConnection.ConnectToSchema();
            string commandText = "SELECT * FROM `Order` WHERE MONTH(`date`) = MONTH(CURRENT_DATE()) AND YEAR(CURRENT_DATE())";
            conn.Open();
            try
            {
                using (MySqlCommand dailyOrders = new MySqlCommand(commandText, conn))
                {
                    using (MySqlDataReader reader = dailyOrders.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Order order = new Order();
                            order.ID = Convert.ToInt32(reader["ID"]);
                            order.Date = Convert.ToDateTime(reader["Date"]);
                            order.CustomerID = Convert.ToInt32(reader["CUSTOMERID"]);
                            order.Name = reader["Name"].ToString();
                            order.Total = Convert.ToDecimal(reader["Total"]);
                            orders.Add(order);
                        }
                    }
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
            return orders;
        }

        public static List<Order> YearlyOrders()
        {
            List<Order> orders = new List<Order>();
            var conn = DatabaseConnection.ConnectToSchema();
            string commandText = "SELECT * FROM `Order` WHERE YEAR(`date`) = YEAR(CURRENT_DATE())";
            conn.Open();
            try
            {
                using (MySqlCommand dailyOrders = new MySqlCommand(commandText, conn))
                {
                    using (MySqlDataReader reader = dailyOrders.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Order order = new Order();
                            order.ID = Convert.ToInt32(reader["ID"]);
                            order.Date = Convert.ToDateTime(reader["Date"]);
                            order.CustomerID = Convert.ToInt32(reader["CUSTOMERID"]);
                            order.Name = reader["Name"].ToString();
                            order.Total = Convert.ToDecimal(reader["Total"]);
                            orders.Add(order);
                        }
                    }
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
            return orders;
        }
    }
}
