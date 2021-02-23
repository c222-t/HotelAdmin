using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelDAL;
using HotelModel;

namespace HotelBLL
{
    public class AdministratorManager
    {
        AdministratorService ams = new AdministratorService();

        public int AdministrTable(string password, string AdministratorName)
        {
            return ams.AdministrTable(password, AdministratorName);
        }

    }
}
