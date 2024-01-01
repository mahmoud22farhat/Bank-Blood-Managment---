using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Blood_Managment___برنامج_ادارة_بنك_الدم.Logic.services
{
  static  class BloodTypeServices
    {
        //this method to add into Blood_Type table in DB

        public static bool BloodTypeInsert(int id, string BloodName)
        {

            return DBHelper.excutdata("BloodTypeInsert", () => BloodTypeparmaterinsert(id, BloodName, DBHelper.command));

        }
        //this method to add insert parameter into stored procedure
        private static void BloodTypeparmaterinsert(int id, string BloodName, SqlCommand commmand)
        {
            commmand.Parameters.Add("@id", SqlDbType.Int).Value = id;
            commmand.Parameters.Add("@bloodtype", SqlDbType.NVarChar).Value = BloodName;
        }

        public static bool BloodTypeUpdate(int id, string Blood_Type)
        {

            return DBHelper.excutdata("BloodTypeupdate", () => BloodTypeparmaterUpdate(id, Blood_Type, DBHelper.command));

        }
        //this method to add insert parameter into stored procedure
        private static void BloodTypeparmaterUpdate(int id, string Blood_Type, SqlCommand commmand)
        {
            commmand.Parameters.Add("@id", SqlDbType.Int).Value = id;
            commmand.Parameters.Add("@bloodtype", SqlDbType.NVarChar).Value = Blood_Type;
        }
        public static bool BloodTypedelete(int id)
        {

            return DBHelper.excutdata("bloodtypeDelete", () => BloodTypeparmaterdelete(id, DBHelper.command));

        }
        //this method to add insert parameter into stored procedure
        private static void BloodTypeparmaterdelete(int id, SqlCommand commmand)
        {
            commmand.Parameters.Add("@id", SqlDbType.Int).Value = id;
           
        }
        public static bool BloodTypedeleteall()
        {

            return DBHelper.excutdata("bloodtypeDeleteall", () => BloodTypeparmaterdeleteall());

        }
        //this method to add insert parameter into stored procedure
        private static void BloodTypeparmaterdeleteall()
        {
         

        }
        public static DataTable Getbloodmaxid()
        {

            return DBHelper.getData("BloodtypeMaxID", () => { });
        }
        public static DataTable Getallblooddata()
        {

            return DBHelper.getData("BloodTypegetall", () => { });
        }
        public static DataTable getallbloodlastrow()
        {

            return DBHelper.getData("BloodTypegetlastRow", () => { });
        }
    }
}
