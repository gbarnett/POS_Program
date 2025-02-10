using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace POS_Program.DatabaseTransactions
{
    internal class DatabaseConnection
    {
        public string connectionString = "Server=10.0.0.4;Uid=admin;Pwd=Badboy6376!!;Port=3306;";
        public const string schemaConnection = "Server=10.0.0.4;Database=pos_program;Uid=admin;Pwd=Badboy6376!!;Port=3306;";

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
                "                         Salary Decimal(10,2));";
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
            string commandText = "CREATE TABLE IF NOT EXISTS `Order` (" +
                                 "ID INT NOT NULL PRIMARY KEY AUTO_INCREMENT, " +
                                 "Date DATETIME, " +
                                 "CUSTOMERID INT NOT NULL, " +
                                 "Name varchar(255), " +
                                 "Total DECIMAL(10,2));";

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
                                 "FOREIGN KEY (OrderID) REFERENCES `Order`(ID) ON DELETE CASCADE, " +
                                 "FOREIGN KEY (ProductID) REFERENCES Product(ID) ON DELETE SET NULL)";
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
