using System;
using Dapper;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace FormUI
{
    public class DataAccess
    {
        public List<CarName> GetInfo(string name)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("SampleDB")))
            {
               var output = connection.Query<CarName>($"select * from People where '{name}'").ToList();
               return output;
            }
        }
    }
}