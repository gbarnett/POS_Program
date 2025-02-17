using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using POS_Program.Classes;

namespace POS_Program.DatabaseTransactions
{
    internal class DatabaseConnection
    {
        // real host : 10.0.0.4
        public string connectionString = "Server=localhost;Uid=admin;Pwd=Password!;Port=3306;";
        public const string schemaConnection = "Server=localhost;Database=pos_program;Uid=admin;Pwd=Password123;Port=3306;";

        public MySqlConnection ConnectToDatabase()
        {
            try
            {
                MySqlConnection connection = new MySqlConnection(connectionString);
                return connection;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to connect to the database : " + ex.Message);
                return null;
            }
        }

        public static MySqlConnection ConnectToSchema()
        {
            try
            {
                MySqlConnection connection = new MySqlConnection(schemaConnection);
                Console.WriteLine("Connected to schema");
                return connection;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Failed to connect to schema");
                return null;
            }
        }

        public bool CheckScheme()
        {
            var connection = ConnectToDatabase();
            connection.Open();
            string databaseName = "pos_program";
            string checkSchemaQuery = "SELECT SCHEMA_NAME FROM information_schema.SCHEMATA WHERE SCHEMA_NAME = @SchemaName;";
            using (MySqlCommand checkCommand = new MySqlCommand(checkSchemaQuery, connection))
            {
                checkCommand.Parameters.AddWithValue("@SchemaName", databaseName);
                object result = checkCommand.ExecuteScalar();
                if (result == null)
                {
                    Console.WriteLine("No Database there");
                    connection.Close();
                    return false;
                }
                else
                {
                    Console.WriteLine("Schema is present");
                    connection.Close();
                    return true;
                }
            }
        }

        public bool CreateSchema()
        {
            var connection = ConnectToDatabase();
            connection.Open();
            string createSchema = "CREATE DATABASE IF NOT EXISTS pos_program";

            MySqlCommand create = new MySqlCommand(createSchema, connection);
            try
            {
                using (MySqlCommand command = new MySqlCommand(createSchema, connection))
                {
                    command.ExecuteNonQuery();
                    Console.WriteLine("Created pos_program");
                }
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Failed to create pos_program Schema");
                return false;
            }
            finally
            {
                connection.Close();
            }

        }

        public bool CreateCustomerTable()
        {
            var connection = ConnectToSchema();
            connection.Open();
            string createCustomerTable = "CREATE TABLE IF NOT EXISTS Customer (" +
                "                         ID INT NOT NULL PRIMARY KEY AUTO_INCREMENT," +
                "                         Name varchar(255)," +
                "                         Phone varchar(255)," +
                "                         Address varchar(255)," +
                "                         City varchar(255)," +
                "                         State varchar(255)," +
                "                         Zip varchar(255));";

            MySqlCommand command = new MySqlCommand(createCustomerTable, connection);
            try
            {
                command.ExecuteNonQuery();
                Console.WriteLine("Created Customer Table");
                connection.Close();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Failed to create customer table\n" + ex.Message);
                connection.Close();
                return false;
            }
        }
        public bool CreateProductTable()
        {
            var connection = ConnectToSchema();
            connection.Open();
            string createCustomerTable = "CREATE TABLE IF NOT EXISTS Product(" +
                "                         ID INT NOT NULL PRIMARY KEY AUTO_INCREMENT," +
                "                         Name varchar(255) NOT NULL," +
                "                         Price decimal(10,2) NOT NULL," +
                "                         Description varchar(255));";

            MySqlCommand command = new MySqlCommand(createCustomerTable, connection);
            try
            {
                command.ExecuteNonQuery();
                Console.WriteLine("Customer table created successfully");
                connection.Close();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Customer table failed to be create  : " + ex.Message);
                connection.Close();
                return false;
            }
        }

        public bool CreateEmployeeTable()
        {
            var conn = ConnectToSchema();
            conn.Open();
            string createEmployeeTable = "CREATE TABLE IF NOT EXISTS Employee (" +
                "                         ID INT NOT NULL PRIMARY KEY AUTO_INCREMENT," +
                "                         Name varchar(255)," +
                "                         Phone varchar(255)," +
                "                         Address varchar(255)," +
                "                         City varchar(255)," +
                "                         State varchar(255)," +
                "                         Zip varchar(255)," +
                "                         Position varchar(255)," +
                "                         Salary Decimal(10,2)," +
                "                         Username varchar(255), " +
                "                         Password varchar(255), " +
                "                         isAdmin INT NOT NULL);";
            try
            {
                using (MySqlCommand command = new MySqlCommand(createEmployeeTable, conn))
                {
                    command.ExecuteNonQuery();
                    Console.WriteLine("Employee Table Create Successfully");
                    conn.Close();
                }
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Failed to create Employee table " + ex.Message);
                conn.Close();
                return false;
            }
        }

        public bool CreateOrderTable()
        {
            var conn = ConnectToSchema();
            conn.Open();
            string commandText = "CREATE TABLE IF NOT EXISTS `Orders` (" +  
                     "ID INT NOT NULL PRIMARY KEY AUTO_INCREMENT, " +
                     "Date DATETIME, " +
                     "CustomerID INT NOT NULL, " +
                     "EmployeeID INT NOT NULL, " +  
                     "Name VARCHAR(255), " +
                     "Total DECIMAL(10,2), " +
                     "FOREIGN KEY (CustomerID) REFERENCES Customer(ID) ON DELETE CASCADE, " +
                     "FOREIGN KEY (EmployeeID) REFERENCES Employee(ID) ON DELETE CASCADE" +
                     ");";


            try
            {
                using (MySqlCommand command = new MySqlCommand(commandText, conn))
                {
                    command.ExecuteNonQuery();
                    Console.WriteLine("Order Table Created");
                    conn.Close();
                }
                return true;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                conn.Close();
                return false;
            }
        }

        public bool CreateOrderItemTable()
        {
            var conn = ConnectToSchema();
            conn.Open();
            string commandText = "CREATE TABLE IF NOT EXISTS OrderItems ( " +
                                 "ID INT NOT NULL PRIMARY KEY AUTO_INCREMENT, " +
                                 "OrderID INT NOT NULL, " +
                                 "ProductID INT, " +
                                 "FOREIGN KEY (OrderID) REFERENCES Orders(ID) ON DELETE CASCADE, " +
                                 "FOREIGN KEY (ProductID) REFERENCES Product(ID) ON DELETE SET NULL);";
            try
            {
                using (MySqlCommand command = new MySqlCommand(commandText, conn))
                {
                    command.ExecuteNonQuery();
                    Console.WriteLine("Created Order Item Table");
                    conn.Close();
                    return true;
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                conn.Close();
                return false;
            }
        }

        public static void CheckAdminAccount()
        {
            int adminAccount = 0;
            var conn = ConnectToSchema();
            conn.Open();
            string commandText = "SELECT EXISTS (SELECT Username FROM EMPLOYEE WHERE Username = 'admin')";
            try
            {
                using (MySqlCommand command = new MySqlCommand(commandText, conn))
                {
                    adminAccount = Convert.ToInt32(command.ExecuteScalar());
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                conn.Close();
            }
            if (adminAccount == 0)
            {
                string adminCommandText = "INSERT INTO Employee (Username, Password, isAdmin) " +
                                     "VALUES ('admin', 'password', '1')";
                conn.Open();
                
                try
                {
                    using (MySqlCommand command = new MySqlCommand(adminCommandText, conn))
                    {
                        command.ExecuteNonQuery();
                    }
                    conn.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    conn.Close();
                }
            }
        }

        public static Employee VerifyLogin(string username, string password)
        {
            var conn = ConnectToSchema();
            conn.Open();
            string commandText = "SELECT ID, Name, Username, isAdmin FROM Employee WHERE Username = @username AND Password = @password";
            Employee employee = new Employee();
            try
            {
                using (MySqlCommand command = new MySqlCommand(commandText, conn))
                {
                    command.Parameters.AddWithValue("@username", username);
                    command.Parameters.AddWithValue("@password", password);
                    using(MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            employee.ID = Convert.ToInt32(reader["ID"]);
                            employee.Name = reader["Name"].ToString();
                            employee.Username = reader["Username"].ToString();
                            employee.isAdmin = Convert.ToInt32(reader["isAdmin"]);
                        }
                    }
                    conn.Close();
                }
                if (employee.ID != 0)
                {
                    return employee;
                }
                else
                {
                    MessageBox.Show("Login Failed");
                    return null;
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                conn.Close();
                return null;
            }
        }

        public bool CheckTables()
        {
            try
            {
                CreateCustomerTable();
                CreateProductTable();
                CreateEmployeeTable();
                CreateOrderTable();
                CreateOrderItemTable();
                Console.WriteLine("ALL TABLES PRESENT");
                return true;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }

    }
}
