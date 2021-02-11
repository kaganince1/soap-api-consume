using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Data;
using System.Data.SqlClient;

namespace Soap_WebForm
{
    /// <summary>
    /// Summary description for WebService1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService1 : System.Web.Services.WebService
    {
        [WebMethod(enableSession: true)]
        public void startSession()
        {
            Session["startTime"] = DateTime.Now;
        }
        [WebMethod(enableSession: true)]
        public DataSet GetDataset(string connStr)
        {
            SqlConnection conn = new SqlConnection(connStr);
            DataSet ds = new DataSet();
            conn.Open();
            string cmdStr = "select * from Odev";
            SqlCommand cmd = new SqlCommand(cmdStr, conn);
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            adp.Fill(ds);
            conn.Close();
            return ds;

        }
        [WebMethod]
        public DataSet GetOneDataset(string connStr, int id)
        {
            SqlConnection conn = new SqlConnection(connStr);
            DataSet ds = new DataSet();
            conn.Open();
            string cmdStr = "select * from Odev where Id= '" + id + "'";
            SqlCommand cmd = new SqlCommand(cmdStr, conn);
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            adp.Fill(ds);
            conn.Close();
            return ds;
        }
        [WebMethod]
        public void AddData(string connStr, string name, string surname, int age, string location)
        {
            SqlConnection conn = new SqlConnection(connStr);
            conn.Open();
            string cmdStr = "insert into Odev (Name, Surname, Age, Location) Values ('" + name + "', '" + surname + "', " + age + ", '" + location + "')";
            SqlCommand cmd = new SqlCommand(cmdStr, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        [WebMethod]
        public void UpdateData(string connStr, int id, string name, string surname, int age, string location)
        {
            SqlConnection conn = new SqlConnection(connStr);
            conn.Open();
            string cmdStr = "update Odev set Name = '" + name + "', Surname = '" + surname + "', Age = '" + age + "', Location = '" + location + "' where Id = '" + id + "';";
            SqlCommand cmd = new SqlCommand(cmdStr, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        [WebMethod]
        public void DeleteData(string connStr, int id)
        {
            SqlConnection conn = new SqlConnection(connStr);
            conn.Open();
            string cmdStr = "delete from Odev where Id = '" + id + "'";
            SqlCommand cmd = new SqlCommand(cmdStr, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        [WebMethod(enableSession: true)]
        public string getSessionTime()
        {
            string time = Session["startTime"].ToString();
            Session.Abandon();
            return time;
        }
    }
}
