using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using POS_Program.Classes;

namespace POS_Program.DatabaseTransactions
{
    internal class CustomerTransactions
    {
        public static bool AddCustomer(Customer customer)
        {
            string addCustomerCommand = "INSERT INTO Customer (Name, Phone, Address, City, State, Zip) " +
                "                        VALUES (@Name, @Phone, @Address, @City, @State, @Zip);";

            DatabaseConnection db = new DatabaseConnection();
            var connection = DatabaseConnection.ConnectToSchema();
            try
            {
                connection.Open();
                using (MySqlCommand command = new MySqlCommand(addCustomerCommand, connection))
                {
                    command.Parameters.AddWithValue("@Name", customer.Name);
                    command.Parameters.AddWithValue("@Phone", customer.Phone);
                    command.Parameters.AddWithValue("@Address", customer.Address);
                    command.Parameters.AddWithValue("@City", customer.City);
                    command.Parameters.AddWithValue("@State", customer.State);
                    command.Parameters.AddWithValue("@Zip", customer.Zip);
                    command.ExecuteNonQuery();
                    MessageBox.Show("Customer added");
                    connection.Close();
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                connection.Close();
                return false;
            }
        }

        public static bool DeleteCustomer(Customer customer)
        {
            MySqlConnection connection = new MySqlConnection();

            string commandText = "DELETE FROM Customer WHERE Customer.ID = @id";
            try
            {
                connection = DatabaseConnection.ConnectToSchema();
                connection.Open();
                using (MySqlCommand command = new MySqlCommand(commandText, connection))
                {
                    command.Parameters.AddWithValue("@id", customer.ID);
                    command.ExecuteNonQuery();
                    connection.Close();
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                connection.Close();
                return false;
            }
        }

        public static List<Customer> GetAllCustomers()
        {
            List<Customer> customers = new List<Customer>();
            string commandText = "SELECT * FROM Customer";
            try
            {
                var connection = DatabaseConnection.ConnectToSchema();
                connection.Open();
                using (MySqlCommand sqlCommand = new MySqlCommand(commandText, connection))
                {
                    MySqlDataReader reader = sqlCommand.ExecuteReader();
                    while (reader.Read())
                    {
                        Customer customer = new Customer();
                        customer.ID = Convert.ToInt32(reader["ID"]);
                        customer.Name = reader["Name"].ToString();
                        customer.Phone = reader["Phone"].ToString();
                        customer.Address = reader["Address"].ToString();
                        customer.City = reader["City"].ToString();
                        customer.State = reader["State"].ToString();
                        customer.Zip = reader["Zip"].ToString();
                        customers.Add(customer);
                    }
                }
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
            return customers;
        }

        public static bool EditCustomer(Customer customer)
        {
            var conn = DatabaseConnection.ConnectToSchema();
            conn.Open();
            string commandText = "UPDATE CUSTOMER " +
                                 "SET Name = @Name, Phone = @Phone, Address = @Address, City = @City, State = @State, Zip = @Zip " +
                                 "WHERE Customer.ID = @id;";
            try
            {
                using (MySqlCommand editCustomer = new MySqlCommand(commandText, conn))
                {
                    editCustomer.Parameters.AddWithValue("@id", customer.ID);
                    editCustomer.Parameters.AddWithValue("@Name", customer.Name);
                    editCustomer.Parameters.AddWithValue("@Phone", customer.Phone);
                    editCustomer.Parameters.AddWithValue("@Address", customer.Address);
                    editCustomer.Parameters.AddWithValue("@City", customer.City);
                    editCustomer.Parameters.AddWithValue("@State", customer.State);
                    editCustomer.Parameters.AddWithValue("@Zip", customer.Zip);

                    editCustomer.ExecuteNonQuery();
                    conn.Close();
                    return true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }

        }

        public static readonly List<string> States = new List<string>()
    {
        "AL", "AK", "AZ", "AR", "CA", "CO", "CT", "DE", "FL", "GA",
        "HI", "ID", "IL", "IN", "IA", "KS", "KY", "LA", "ME", "MD",
        "MA", "MI", "MN", "MS", "MO", "MT", "NE", "NV", "NH", "NJ",
        "NM", "NY", "NC", "ND", "OH", "OK", "OR", "PA", "RI", "SC",
        "SD", "TN", "TX", "UT", "VT", "VA", "WA", "WV", "WI", "WY"
    };
    }
}
