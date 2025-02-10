using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using POS_Program.Classes;

namespace POS_Program.DatabaseTransactions
{
    public class EmployeeTransactions
    {
        public static BindingList<Employee> GetAllEmployees()
        {
            BindingList<Employee> employees = new BindingList<Employee>();
            string commandText = "SELECT * FROM Employee";

            var conn = DatabaseConnection.ConnectToSchema();
            conn.Open();
            try
            {
                using (MySqlCommand command = new MySqlCommand(commandText, conn))
                {
                    MySqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        Employee employee = new Employee();
                        employee.ID = Convert.ToInt32(reader["ID"]);
                        employee.Name = reader["Name"].ToString();
                        employee.Phone = reader["Phone"].ToString();
                        employee.Address = reader["Address"].ToString();
                        employee.City = reader["City"].ToString();
                        employee.State = reader["State"].ToString();
                        employee.Zip = reader["Zip"].ToString();
                        employee.Position = reader["Position"].ToString();
                        employee.Salary = Convert.ToDecimal(reader["Salary"]);

                        employees.Add(employee);
                    }
                }
                conn.Close();
                return employees;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                conn.Close();
                return null;
            }
        }


        public static bool AddEmployee(Employee employee)
        {
            var conn = DatabaseConnection.ConnectToSchema();
            conn.Open();
            string commandText = "INSERT INTO Employee (Name, Phone, Address, City, State, Zip, Position, Salary) " +
            "VALUES (@Name, @Phone, @Address, @City, @State, @Zip, @Position, @Salary);";
            using (MySqlCommand insertEmployee = new MySqlCommand(commandText, conn))
            {
                try
                {
                    insertEmployee.Parameters.AddWithValue("@Name", employee.Name);
                    insertEmployee.Parameters.AddWithValue("@Phone", employee.Phone);
                    insertEmployee.Parameters.AddWithValue("@Address", employee.Address);
                    insertEmployee.Parameters.AddWithValue("@City", employee.City);
                    insertEmployee.Parameters.AddWithValue("@State", employee.State);
                    insertEmployee.Parameters.AddWithValue("@Zip", employee.Zip);
                    insertEmployee.Parameters.AddWithValue("@Position", employee.Position);
                    insertEmployee.Parameters.AddWithValue("@Salary", employee.Salary);
                    insertEmployee.ExecuteNonQuery();
                    conn.Close();
                    return true;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    conn.Close();
                    return false;
                }
                finally
                {
                    conn.Close();
                }
            }

        }

        public static bool DeleteEmployee(Employee employee)
        {
            var conn = DatabaseConnection.ConnectToSchema();
            conn.Open();
            string commandText = "DELETE FROM Employee " +
                                 "WHERE ID = @id";
            using (MySqlCommand deleteEmployee = new MySqlCommand(commandText, conn))
            {
                try
                {
                    deleteEmployee.Parameters.AddWithValue("@id", employee.ID);
                    deleteEmployee.ExecuteNonQuery();
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


        public static bool EditEmployee(Employee employee)
        {
            var conn = DatabaseConnection.ConnectToSchema();
            conn.Open();
            string commandText = "UPDATE Employee " +
            "SET Name = @Name, Phone = @Phone, Address = @Address, City = @City, State = @State, Zip = @Zip, Position = @Postion, Salary = @Salary " +
            "WHERE ID = @id;";

            try
            {
                using (MySqlCommand editEmployee = new MySqlCommand(commandText, conn))
                {
                    editEmployee.Parameters.AddWithValue("@Name", employee.Name);
                    editEmployee.Parameters.AddWithValue("@Phone", employee.Phone);
                    editEmployee.Parameters.AddWithValue("@Address", employee.Address);
                    editEmployee.Parameters.AddWithValue("@City", employee.City);
                    editEmployee.Parameters.AddWithValue("@State", employee.State);
                    editEmployee.Parameters.AddWithValue("@Zip", employee.Zip);
                    editEmployee.Parameters.AddWithValue("@Position", employee.Position);
                    editEmployee.Parameters.AddWithValue("@Salary", employee.Salary);

                    editEmployee.ExecuteNonQuery();
                    conn.Close();
                    return true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Failed to edit employee " + ex.Message);
                conn.Close();
                return false;
            }
        }
    }
}
