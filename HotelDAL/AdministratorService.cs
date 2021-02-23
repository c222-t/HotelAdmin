using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelModel;
using System.Data.SqlClient;

namespace HotelDAL
{
    public class AdministratorService
    {
        DBHelper db = new DBHelper();

        public int AdministrTable(string password,string AdministratorName)
        {
            StringBuilder sql = new StringBuilder("SELECT[No],[password],[AdministratorName],[jurisdiction] FROM[AdministratorTable] where password=@password and AdministratorName=@AdministratorName");

            SqlParameter[] sp = {
                new SqlParameter ("@password",password),
                new SqlParameter ("@AdministratorName",AdministratorName)
            };

            return (int)db.ExecuteScalar(sql.ToString(), sp);
        }



    }
}
