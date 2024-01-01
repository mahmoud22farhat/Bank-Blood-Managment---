using Bank_Blood_Managment___برنامج_ادارة_بنك_الدم.Logic.services;
using Bank_Blood_Managment___برنامج_ادارة_بنك_الدم.Models;
using Bank_Blood_Managment___برنامج_ادارة_بنك_الدم.views.interfaace;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Blood_Managment___برنامج_ادارة_بنك_الدم.Logic.presenter
{
    class BloodBagPresenter
    {

        IBloodBag ibloodbag;
        BloodBagModel bloodbagModel = new BloodBagModel();

        public BloodBagPresenter(IBloodBag view)
        {
            this.ibloodbag = view;

        }
        //connect Between technicalModel and interfacecat
        private void connectBetweenModelinterface()
        {
            bloodbagModel.id = ibloodbag.id;
            bloodbagModel.dname = ibloodbag.dname;
            bloodbagModel.donerID = ibloodbag.donerID;
            bloodbagModel.techID = ibloodbag.techID;
            bloodbagModel.Bloodtype = ibloodbag.Bloodtype;
            bloodbagModel.startdate = ibloodbag.startdate;
            bloodbagModel.endtdate = ibloodbag.endtdate;
            bloodbagModel.note = ibloodbag.note;
            bloodbagModel.statubag = ibloodbag.statubag;

        }
        public void AutoNumber()
        {
            string val = Convert.ToString(BloodBagServices.Getallmaxid().Rows[0][0]);
            if (val == null || val == "")
            {
                ibloodbag.id  = 1;
            }
            else
            {
                ibloodbag.id = Convert.ToInt32(BloodBagServices.Getallmaxid().Rows[0][0]) + 1;
            }
            //  iAuthors.ID = Convert.ToInt32(AuthorServices.getauthormaxid().Rows[0][0])+1;
            ibloodbag.dname = "";
            ibloodbag.startdate = DateTime.Now.ToShortDateString();
            ibloodbag.endtdate = DateTime.Now.ToShortDateString();
            //ibloodbag.cbx_techIDSelectedIndex = 0;
            //ibloodbag.cbx_BloodtypeSelectedIndex = 0;



            ibloodbag.note = "";
            ibloodbag.donerID = "";
            ibloodbag.statubag = "غير جاهز";
            ibloodbag.btn_save = false;
            ibloodbag.btn_delete = false;
            ibloodbag.btn_deleteall = false;
            ibloodbag.btn_add = true;

        }
        public DataTable Getlastrow()
        {
            DataTable tbl = new DataTable();
            tbl = BloodBagServices.getallBloodBaglastrow();
            return tbl;
        }
        public void getrow(int row)
        {
            DataTable tbl = new DataTable();
            tbl = BloodBagServices.BloodBaggetall();
            ibloodbag.id = Convert.ToInt32(tbl.Rows[row][0]);
            ibloodbag.dname = Convert.ToString(tbl.Rows[row][1]);
            ibloodbag.donerID = Convert.ToString(tbl.Rows[row][2]);
            ibloodbag.cbx_techIDSelectedIndex = Convert.ToInt32(tbl.Rows[row][3]);
            ibloodbag.cbx_BloodtypeSelectedIndex = Convert.ToInt32(tbl.Rows[row][4]);

            try
            {
                DateTime dt = DateTime.ParseExact(Convert.ToString(tbl.Rows[row][5]), "dd/MM/yyyy", null);
                DateTime dc = DateTime.ParseExact(Convert.ToString(tbl.Rows[row][6]), "dd/MM/yyyy", null);


                ibloodbag.startdate = dt.ToString();
                ibloodbag.endtdate = dt.ToString();

            }
            catch (Exception) { }
            ibloodbag.note = Convert.ToString(tbl.Rows[row][7]);
            ibloodbag.statubag = Convert.ToString(tbl.Rows[row][8]);


            ibloodbag.btn_save = true;
            ibloodbag.btn_delete = true;
            ibloodbag.btn_deleteall = true;
            ibloodbag.btn_add = false;
        }
        public void fillcbxtech()
        {

            ibloodbag.cbx_techID = TechnicalServices.getalltechnicaldata();
            ibloodbag.cbx_techIDDisplaymember = "اسم الفني";
            ibloodbag.cbx_techIDvaluemember = "رقم الفني";

        }
        public void fillcbxBlood()
        {

            ibloodbag.cbx_Bloodtype = BloodBagServices.Getallbloodtype();
            ibloodbag.cbx_BloodtypeDisplaymember = "Bloodtype";
            ibloodbag.cbx_Bloodtypevaluemember = "ID";

        }
        public bool BloodBagInsert()
        {
            connectBetweenModelinterface();
            DateTime d1 = Convert.ToDateTime(bloodbagModel.startdate);
            DateTime d2 = Convert.ToDateTime(bloodbagModel.endtdate);
            string da = d1.ToString("dd/MM/yyyy");
            string db = d2.ToString("dd/MM/yyyy");
            return BloodBagServices.BloodBagInsert(bloodbagModel.id,bloodbagModel.dname,bloodbagModel.donerID,bloodbagModel.techID,bloodbagModel.Bloodtype, da,db,bloodbagModel.note,bloodbagModel.statubag);

        }
        public bool BloodBagUpdate()
        {
            connectBetweenModelinterface();
            DateTime d1 = Convert.ToDateTime(bloodbagModel.startdate);
            DateTime d2 = Convert.ToDateTime(bloodbagModel.endtdate);
            string da = d1.ToString("dd/MM/yyyy");
            string db = d2.ToString("dd/MM/yyyy");
            return BloodBagServices.BloodBagUpdate(bloodbagModel.id, bloodbagModel.dname, bloodbagModel.donerID, bloodbagModel.techID, bloodbagModel.Bloodtype, da, db, bloodbagModel.note,bloodbagModel.statubag);

        }
        public bool BloodBagdelete()
        {
            connectBetweenModelinterface();
           
            return BloodBagServices.BloodBagdelete(bloodbagModel.id);

        }
        public bool BloodBagdeleteall()
        {
            connectBetweenModelinterface();

            return BloodBagServices.BloodBagdeleteall(bloodbagModel.id);

        }
    }
}
