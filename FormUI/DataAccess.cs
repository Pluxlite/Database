using System;
using System.CodeDom;
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
                var output = connection.Query<CarName>("dbo.genCars_GetByName @Name", new {Name = name}).ToList();
                return output;
            }
        }

        public void InsertCar(string carId, string name, string year, string color)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("SampleDB")))
            {
                List<CarName> car = new List<CarName>();
                
                car.Add(new CarName{ CarId = Convert.ToInt16(carId), Name = name, Year = Convert.ToInt16(year), Color = color});
                connection.Execute("dbo.genCars_Insert @CarId, @Name, @Year, @Color", car);
                

            }
            
        }

        public void DeleteCar(string name)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("SampleDB")))
            {
                List<CarName> car = new List<CarName>();

                connection.Execute("dbo.genCars_DeleteByName @Name", new {Name = name});

            }
        }
    }
}