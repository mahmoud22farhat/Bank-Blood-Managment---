using Bank_Blood_Managment___برنامج_ادارة_بنك_الدم.Models;
using Bank_Blood_Managment___برنامج_ادارة_بنك_الدم.views.interfaace;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Blood_Managment___برنامج_ادارة_بنك_الدم.Logic.services
{
  static  class BloodBagServices
    {
        //this method to add into BloodBag table in DB

        public static bool BloodBagInsert(int id, string dname, string donerID, int techID, int bloodtype, string startdate,string enddate, string note,string statubag)
        {

            return DBHelper.excutdata("BloodBagInsert", () => BloodBagparmaterinsert(id, dname, donerID, techID, bloodtype, startdate, enddate, note,statubag, DBHelper.command));

        }
        //this method to add insert parameter into stored procedure
        private static void BloodBagparmaterinsert(int id, string dname, string donerID, int techID, int bloodtype, string startdate, string enddate, string note,string statubag, SqlCommand commmand)
        {
            commmand.Parameters.Add("@id", SqlDbType.Int).Value = id;
            commmand.Parameters.Add("@dname", SqlDbType.NVarChar).Value = dname;
            commmand.Parameters.Add("@DonarID", SqlDbType.NVarChar).Value = donerID;
            commmand.Parameters.Add("@techID", SqlDbType.Int).Value = techID;
            commmand.Parameters.Add("@Bloodtype", SqlDbType.Int).Value = bloodtype;
            commmand.Parameters.Add("@startdate", SqlDbType.NVarChar).Value = startdate;
            commmand.Parameters.Add("@enddate", SqlDbType.NVarChar).Value = enddate;
            commmand.Parameters.Add("@note", SqlDbType.NVarChar).Value = note;
            commmand.Parameters.Add("@statubag", SqlDbType.NVarChar).Value = statubag;

        }
        //this method to update into BloodBag table in DB

        public static bool BloodBagUpdate(int id, string dname, string donerID, int techID, int bloodtype, string startdate, string enddate, string note, string statubag)
        {

            return DBHelper.excutdata("BloodBagUpdate", () => BloodBagparmaterUpdate(id, dname, donerID, techID, bloodtype, startdate, enddate, note, statubag, DBHelper.command));

        }
        //this method to add update parameter into stored procedure
        private static void BloodBagparmaterUpdate(int id, string dname, string donerID, int techID, int bloodtype, string startdate, string enddate, string note,string statubag, SqlCommand commmand)
        {
            commmand.Parameters.Add("@id", SqlDbType.Int).Value = id;
            commmand.Parameters.Add("@dname", SqlDbType.NVarChar).Value = dname;
            commmand.Parameters.Add("@DonarID", SqlDbType.NVarChar).Value = donerID;
            commmand.Parameters.Add("@techID", SqlDbType.Int).Value = techID;
            commmand.Parameters.Add("@Bloodtype", SqlDbType.Int).Value = bloodtype;
            commmand.Parameters.Add("@startdate", SqlDbType.NVarChar).Value = startdate;
            commmand.Parameters.Add("@enddate", SqlDbType.NVarChar).Value = enddate;
            commmand.Parameters.Add("@note", SqlDbType.NVarChar).Value = note;
            commmand.Parameters.Add("@statubag", SqlDbType.NVarChar).Value = statubag;

        }
        public static bool BloodBagdelete(int id)
        {

            return DBHelper.excutdata("BloodBagDelete", () => BloodBagparmaterdelete(id, DBHelper.command));

        }
        //this method to add update parameter into stored procedure
        private static void BloodBagparmaterdelete(int id, SqlCommand commmand)
        {
            commmand.Parameters.Add("@id", SqlDbType.Int).Value = id;
           
        }
        public static bool BloodBagdeleteall(int id)
        {

            return DBHelper.excutdata("BloodBagDeleteall", () => BloodBagparmaterdeleteall());

        }
        //this method to add update parameter into stored procedure
        private static void BloodBagparmaterdeleteall()
        {
          

        }
        public static DataTable Getallmaxid()
        {

            return DBHelper.getData("BloodBagMaxID", () => { });
        }
        public static DataTable Getallbloodtype()
        {

            return DBHelper.getData("BloodTypegetall2", () => { });
        }
        public static DataTable getallBloodBaglastrow()
        {

            return DBHelper.getData("BloodBaggetlastRow", () => { });
        }
        public static DataTable BloodBaggetall()
        {
            return DBHelper.getData("BloodBaggetall", () => { });
        }
    }
}
