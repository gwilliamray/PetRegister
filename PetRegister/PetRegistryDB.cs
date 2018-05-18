using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetRegister
{
    public static class PetRegistryDB
    {
        public static SqlConnection GetPetRegistryConnection()
        {
            // This is the classroom string
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=N:\1434\Spring2018\PetRegister\PetRegister\PetRegistry.mdf;Integrated Security=True";

            // this is the home string

            SqlConnection conn = new SqlConnection(connectionString);
            return conn;
        }
        
    }
}
