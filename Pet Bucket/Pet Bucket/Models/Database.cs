 using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;

namespace Pet_Bucket.Models
{
    public class Database
    {
        public Agencys Agencys { get; set; }
        public Database()
        {
            String connString = @"Server=LAPTOP-6HJ3MM96; Database=Agency_ Details; Integrated Security=true";
            SqlConnection conn = new SqlConnection(connString);
            Agencys = new Agencys();
          
        }
       

    }
} 