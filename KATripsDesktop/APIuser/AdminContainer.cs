using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KATripsDesktop.APIuser
{
    class AdminContainer
    {
        public static Admin admin
        {
            get;
            set;
        }

        public AdminContainer()
        {
            admin = new Admin();
        }
    }
}
