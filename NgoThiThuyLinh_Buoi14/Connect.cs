﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace NgoThiThuyLinh_Buoi14
{
    class Connect
    {
        public static SqlConnection conn = new SqlConnection();
        
        public static SqlConnection Connectdb(string sever, string database, string user, string pass)
        {
            
            return conn;
        }
        public static SqlConnection Connectdb1()
        {
            conn = new SqlConnection("Data Source =A209PC18; Initial Catalog= CSDL; Integrated Security = true");
            return conn;
        }
    }
}
