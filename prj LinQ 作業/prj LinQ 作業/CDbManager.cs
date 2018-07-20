using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prj_LinQ_作業
{
   public class CDbManager
    {
        public static string getConnectionString()
        {return @"Data Source=.;Initial Catalog=Northwind;User ID=sa;Password =P@ssw0rd"; }
    }
}
