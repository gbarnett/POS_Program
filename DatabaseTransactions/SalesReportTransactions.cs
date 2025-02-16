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
        public static List<Order> DailyOrders(Employee employee)
        {
            List<Order> orders = new List<Order>();
            var conn = DatabaseConnection.ConnectToSchema();
            string commandText = "SELECT * FROM ORDERS WHERE DAY(`date`) = DAY(CURRENT_DATE()) AND EmployeeID = @id";
            conn.Open();
            try
            {
                using (MySqlCommand dailyOrders = new MySqlCommand(commandText, conn))
                {
                    if (employee != null)
                    {
                        dailyOrders.Parameters.AddWithValue("@id", employee.ID);
                    }
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

        public static List<Order> MonthlyOrders(Employee employee)
        {
            List<Order> orders = new List<Order>();
            var conn = DatabaseConnection.ConnectToSchema();
            string commandText = "SELECT * FROM ORDERS WHERE MONTH(`date`) = MONTH(CURRENT_DATE()) AND EmployeeID = @id";
            conn.Open();
            try
            {
                using (MySqlCommand monthlyOrders = new MySqlCommand(commandText, conn))
                {
                    monthlyOrders.Parameters.AddWithValue("@id", employee.ID);
                    using (MySqlDataReader reader = monthlyOrders.ExecuteReader())
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

        public static List<Order> YearlyOrders(Employee employee)
        {
            List<Order> orders = new List<Order>();
            var conn = DatabaseConnection.ConnectToSchema();
            string commandText = "SELECT * FROM ORDERS WHERE YEAR(`date`) = YEAR(CURRENT_DATE()) AND EmployeeID = @id";
            conn.Open();
            
            try
            {
                using (MySqlCommand yearlyOrders = new MySqlCommand(commandText, conn))
                {
                    if (employee != null)
                    {
                        yearlyOrders.Parameters.AddWithValue("@id", employee.ID);
                    }
                    using (MySqlDataReader reader = yearlyOrders.ExecuteReader())
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
