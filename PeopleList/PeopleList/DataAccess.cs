using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeopleList
{
    public class DataAccess
    {
        public List<Customer> GetCustomers(string City)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(ConnectionString.CnnVal("MyShopDB")))
            {
                var output= connection.Query<Customer>($"Select * from customer where City = '{City}'").ToList();
                return output;
            }
        }
    }
}
