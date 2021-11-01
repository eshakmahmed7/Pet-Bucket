using Pet_Bucket.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.SqlClient;

namespace Pet_Bucket.Controllers
{
    public class AgencyController : Controller
    {
        // GET: Agency
        public ActionResult Index()
        {
            String connString = @"Server=LAPTOP-6HJ3MM96; Database=Agency_ Details; Integrated Security=true";
            SqlConnection conn = new SqlConnection(connString);
            String query = "select* from Agencys";
            SqlCommand cmd = new SqlCommand(query, conn);
            conn.Open();
            
            SqlDataReader reader = cmd.ExecuteReader();
            List<Agency> Agencys = new List<Agency>();
            while (reader.Read()){
                Agency a =new Agency(){
                    Id= reader.GetInt32(reader.GetOrdinal("Id")),
                    Name= reader.GetString(reader.GetOrdinal("Name")),
                    Dob= reader.GetString(reader.GetOrdinal("Dob")),
                    Gender= reader.GetString(reader.GetOrdinal("Gender")),
                    Address= reader.GetString(reader.GetOrdinal("Address")),
                };
                Agencys.Add(a);
            }
        conn.Close();
        return View (Agencys);
        

             
    }
        [HttpGet]
        public ActionResult Create() {
            return View();
        }
        [HttpPost] 
        public ActionResult Create(Agency a)
        {
            String connString = @"Server=LAPTOP-6HJ3MM96; Database=Agency_ Details; Integrated Security=true";
            SqlConnection conn = new SqlConnection(connString);
            String query = string.Format("Insert into Agencys values ('{0}','{1}','{2}','{3})", a.Name, a.Dob, a.Gender, a.Address);
            SqlCommand cmd = new SqlCommand(query, conn);
            conn.Open();
            int r=cmd.ExecuteNonQuery(); 
            conn.Close();
            return RedirectToAction ("Index");
        }

    }
}