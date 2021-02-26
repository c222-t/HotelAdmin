using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using HotelDAL;
using HotelModel;

namespace HotelBLL
{
    public class ExpenditureTableManager
    {
        ExpenditureTableService ets = new ExpenditureTableService();
        public DataTable ExpenditureTable(string kai = "", string jie = "")
        {
            return ets.ExpenditureTable(kai,jie);
        }

    }
}
