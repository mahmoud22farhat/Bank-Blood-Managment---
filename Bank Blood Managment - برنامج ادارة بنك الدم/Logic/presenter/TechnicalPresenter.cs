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
    class TechnicalPresenter
    {

        Itechnical itechnical;
        technicalModel techModel = new technicalModel();

        public TechnicalPresenter(Itechnical view)
        {
            this.itechnical = view;
        }
        //connect Between technicalModel and interfacecat
        private void connectBetweenModelinterface()
        {
            techModel.id = itechnical.id;
            techModel.tename = itechnical.tename;
            techModel.teaddress = itechnical.teaddress;
            techModel.tephone = itechnical.tephone;
            techModel.tedate = itechnical.tedate;
            techModel.note = itechnical.note;


        }
        public void AutoNumber()
        {

            string val = Convert.ToString(TechnicalServices.getTechnicalmaxid().Rows[0][0]);
            if (val == null || val == "")
            {
                itechnical.id = 1;
            }
            else
            {
                itechnical.id = Convert.ToInt32(TechnicalServices.getTechnicalmaxid().Rows[0][0]) + 1;
            }
            //  iAuthors.ID = Convert.ToInt32(AuthorServices.getauthormaxid().Rows[0][0])+1;
            itechnical.tename = "";
            itechnical.teaddress = "";
            itechnical.tephone = "";
            itechnical.tedate = DateTime.Now.ToShortDateString();
            itechnical.note = "";

            itechnical.dataGridView = TechnicalServices.getalltechnicaldata();



            itechnical.btn_save = false;
            itechnical.btn_delete = false;
            itechnical.btn_deleteall = false;
            itechnical.btn_add = true;

        }
        public DataTable Getlastrow()
        {
            DataTable tbl = new DataTable();
            tbl = TechnicalServices.getalltechnicallastrow();
            return tbl;
        }
        public void getrow(int row)
        {
            DataTable tbl = new DataTable();
            tbl = TechnicalServices.getalltechnicaldata();
            itechnical.id = Convert.ToInt32(tbl.Rows[row][0]);
            itechnical.tename = Convert.ToString(tbl.Rows[row][1]);
            itechnical.teaddress = Convert.ToString(tbl.Rows[row][2]);
            itechnical.tephone = Convert.ToString(tbl.Rows[row][3]);
            try
            {
                DateTime dt = DateTime.ParseExact(Convert.ToString(tbl.Rows[row][4]), "dd/MM/yyyy", null);


                itechnical.tedate = dt.ToString();
            }
            catch (Exception) { }
            itechnical.note = Convert.ToString(tbl.Rows[row][4]);


            itechnical.btn_save = true;
            itechnical.btn_delete = true;
            itechnical.btn_deleteall = true;
            itechnical.btn_add = false;
        }
        public bool technicalInsert()
        {
            connectBetweenModelinterface();
            DateTime d1 = Convert.ToDateTime(techModel.tedate);
            string d2 = d1.ToString("dd/MM/yyyy");
            return TechnicalServices.technicalInsert(techModel.id, techModel.tename,techModel.teaddress,techModel.tephone, d2, techModel.note);

        }
        public bool technicalUpdate()
        {
            connectBetweenModelinterface();
            DateTime d1 = Convert.ToDateTime(techModel.tedate);
            string d2 = d1.ToString("dd/MM/yyyy");
            return TechnicalServices.technicalupdate(techModel.id, techModel.tename, techModel.teaddress, techModel.tephone, d2, techModel.note);

        }
        public bool technicaldelete()
        {
            connectBetweenModelinterface();
           
            return TechnicalServices.technicaldelete(techModel.id);

        }
        public bool technicaldeleteall()
        {
            connectBetweenModelinterface();

            return TechnicalServices.technicaldeleteall();

        }
    }
}
