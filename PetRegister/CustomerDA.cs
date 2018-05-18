using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PetRegister
{
    public class CustomerDA
    {
        public static List<Customer> GetAllCustomers()
        {
            List<Customer> ourCustomers = new List<Customer>();

            //ourCustomers.Add(new Customer("Bob", "Smith", "me@you.com", "402-111-1111", Convert.ToDateTime("11/11/11"), "8800 O Street"));
            //ourCustomers.Add(new Customer("Fred", "Flintstone", "fred@you.com", "402-222-1111", Convert.ToDateTime("12/5/21"), "12 Bedrock Street"));
            //ourCustomers.Add(new Customer("Barney", "Rubble", "Barney@you.com", "402-333-1111", Convert.ToDateTime("2/29/12"), "14 Bedrock Street"));
            //ourCustomers.Add(new Customer("George", "Jetson", "George@you.com", "402-444-1111", Convert.ToDateTime("11/11/11"), "231 Skyway Drive"));

            // need a connection
            SqlConnection conn = PetRegistryDB.GetPetRegistryConnection();

            // new a select statement
            string selectStatement = "SELECT * from Customer";

            // need a command object
            SqlCommand selectCommand = new SqlCommand(selectStatement, conn);

            try
            {
                conn.Open();
                SqlDataReader reader = selectCommand.ExecuteReader();

                while (reader.Read())
                {
                    Customer c = new PetRegister.Customer();
                    c.CustId = (int)reader["Id"];
                    c.FirstName = reader["FirstName"].ToString();
                    c.LastName = reader["LastName"].ToString();
                    c.Email = reader["Email"].ToString();
                    c.Balance = Convert.ToDecimal(reader["Balance"]);
                    c.DateOfBirth = Convert.ToDateTime(reader["DateofBirth"]);
                    c.Address = reader["Address"].ToString();
                    c.Phone = reader["Phone"].ToString();

                    ourCustomers.Add(c);

                }
                reader.Close();

            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Well that was wierd");
            }
            finally
            {
                conn.Close();
               

            }


            return ourCustomers;
        }

        public static int AddCustomer(Customer aCust)
        {
            int numRows = 0;

            SqlConnection conn = PetRegistryDB.GetPetRegistryConnection();

            string insertStatment = "insert Customer (FirstName, LastName, Email, Balance, DateofBirth, Address, Phone)" +
                                               " values(@firstName, @LastName, @Email, @Balance, @DateofBirth, @Address, @Phone)";

            SqlCommand insertCommand = new SqlCommand(insertStatment, conn);

            // now fill in the parameters
            insertCommand.Parameters.AddWithValue("@firstName", aCust.FirstName);
            insertCommand.Parameters.AddWithValue("@lastName", aCust.LastName);
            insertCommand.Parameters.AddWithValue("@email", aCust.Email);
            insertCommand.Parameters.AddWithValue("@Balance", aCust.Balance);
            insertCommand.Parameters.AddWithValue("@DateofBirth", aCust.DateOfBirth);
            insertCommand.Parameters.AddWithValue("@Address", aCust.Address);
            insertCommand.Parameters.AddWithValue("@Phone", aCust.Phone);

            try
            {
                conn.Open();
                numRows = insertCommand.ExecuteNonQuery();

                string selStatement = "Select IDENT_CURRENT('Customer') From Customer";
                SqlCommand sqlCommand = new SqlCommand(selStatement, conn);
                int customerId = Convert.ToInt32(sqlCommand.ExecuteScalar());
                aCust.CustId = customerId;

            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }

            return numRows;
        }
    }
}
