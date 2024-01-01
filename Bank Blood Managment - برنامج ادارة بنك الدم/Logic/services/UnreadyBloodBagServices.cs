using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Blood_Managment___برنامج_ادارة_بنك_الدم.Logic.services
{
   static class UnreadyBloodBagServices
    {
        public static DataTable getallBooks()
        {
            return DBHelper.getData("BooksGetAll", () => { });
        }
        public static DataTable Blooddataall()
        {
            return DBHelper.getData("BloodDGVall", () => { });
        }


        public static DataTable getallBloodBytecnical(int techID)
        {
            return DBHelper.getData("BloodDGVallByTechnicalID", () => BooksSearchtech(techID, DBHelper.command));
        }
        private static void BooksSearchtech(int techID, SqlCommand commmand)
        {
            commmand.Parameters.Add("@technicalID", SqlDbType.Int).Value = techID;

        }
        public static DataTable getallBloodByBloodtype(int BloodID)
        {
            return DBHelper.getData("BloodDGVallByBloodID", () => BooksSearchBlood(BloodID, DBHelper.command));
        }
        private static void BooksSearchBlood(int BloodID, SqlCommand commmand)
        {
            commmand.Parameters.Add("@BloodID", SqlDbType.Int).Value = BloodID;

        }
    }
}
