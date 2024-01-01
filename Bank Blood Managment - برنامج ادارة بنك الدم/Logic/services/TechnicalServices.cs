using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Blood_Managment___برنامج_ادارة_بنك_الدم.Logic.services
{
   static class TechnicalServices
    {
        //this method to add into technical table in DB

        public static bool technicalInsert(int id, string name, string address, string phone, string date, string note)
        {

            return DBHelper.excutdata("technicalInsert", () => technicalparmaterinsert(id, name,  address,  phone,  date,  note, DBHelper.command));

        }
        //this method to add insert parameter into stored procedure
        private static void technicalparmaterinsert(int id, string name, string address, string phone, string date, string note, SqlCommand commmand)
        {
            commmand.Parameters.Add("@id", SqlDbType.Int).Value = id;
            commmand.Parameters.Add("@name", SqlDbType.NVarChar).Value = name;
            commmand.Parameters.Add("@address", SqlDbType.NVarChar).Value = address;
            commmand.Parameters.Add("@phone", SqlDbType.NVarChar).Value = phone;
            commmand.Parameters.Add("@date", SqlDbType.NVarChar).Value = date;
            commmand.Parameters.Add("@note", SqlDbType.NVarChar).Value = note;

        }
     
            //this method to update into technical table in DB

            public static bool technicalupdate(int id, string name, string address, string phone, string date, string note)
            {

                return DBHelper.excutdata("TechnicalUpdate", () => technicalparmaterupdate(id, name, address, phone, date, note, DBHelper.command));

            }
        //this method to update insert parameter into stored procedure
        private static void technicalparmaterupdate(int id, string name, string address, string phone, string date, string note, SqlCommand commmand)
            {
                commmand.Parameters.Add("@id", SqlDbType.Int).Value = id;
                commmand.Parameters.Add("@name", SqlDbType.NVarChar).Value = name;
                commmand.Parameters.Add("@address", SqlDbType.NVarChar).Value = address;
                commmand.Parameters.Add("@phone", SqlDbType.NVarChar).Value = phone;
                commmand.Parameters.Add("@date", SqlDbType.NVarChar).Value = date;
                commmand.Parameters.Add("@note", SqlDbType.NVarChar).Value = note;

            }
        //this method to delete into technical table in DB

        public static bool technicaldelete(int id)
        {

            return DBHelper.excutdata("technicalDelete", () => technicalparmaterdelete(id, DBHelper.command));

        }
        //this method to delete insert parameter into stored procedure
        private static void technicalparmaterdelete(int id, SqlCommand commmand)
        {
            commmand.Parameters.Add("@id", SqlDbType.Int).Value = id;
           

        }
        public static bool technicaldeleteall()
        {

            return DBHelper.excutdata("technicalDelete", () => technicalparmaterdeleteall( DBHelper.command));

        }
        //this method to delete insert parameter into stored procedure
        private static void technicalparmaterdeleteall( SqlCommand commmand)
        {
          


        }
        public static DataTable getTechnicalmaxid()
        {

            return DBHelper.getData("TechnicalMaxID", () => { });
        }
        public static DataTable getalltechnicaldata()
        {

            return DBHelper.getData("Technicalgetall", () => { });
        }
      
        public static DataTable getalltechnicallastrow()
        {

            return DBHelper.getData("technicalgetlastRow", () => { });
        }
    }
}
