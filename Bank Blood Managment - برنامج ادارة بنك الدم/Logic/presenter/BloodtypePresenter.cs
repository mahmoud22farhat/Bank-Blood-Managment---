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
    class BloodtypePresenter
    {
        IBloodtype ibloodtype;
        BloodtypeModel bloodtypeModel = new BloodtypeModel();

        public BloodtypePresenter(IBloodtype view)
        {
            this.ibloodtype = view;
        }
        private void connectBetweenModelinterface()
        {
            bloodtypeModel.id = ibloodtype.id;
            bloodtypeModel.BloodName = ibloodtype.BloodName;
        }
            public void AutoNumber()
        {

            string val = Convert.ToString(BloodTypeServices.Getbloodmaxid().Rows[0][0]);
            if (val == null || val == "")
            {
                ibloodtype.id = 1;
            }
            else
            {
                ibloodtype.id = Convert.ToInt32(BloodTypeServices.Getbloodmaxid().Rows[0][0]) + 1;
            }
            //  iAuthors.ID = Convert.ToInt32(AuthorServices.getauthormaxid().Rows[0][0])+1;
            ibloodtype.BloodName = "";


            ibloodtype.dataGridView = BloodTypeServices.Getallblooddata();



            ibloodtype.btn_save = false;
            ibloodtype.btn_delete = false;
            ibloodtype.btn_deleteall = false;
            ibloodtype.btn_add = true;

        }
        public DataTable Getlastrow()
        {
            DataTable tbl = new DataTable();
            tbl = BloodTypeServices.getallbloodlastrow();
            return tbl;
        }
        public void getrow(int row)
        {
            DataTable tbl = new DataTable();
            tbl = BloodTypeServices.Getallblooddata();
            ibloodtype.id = Convert.ToInt32(tbl.Rows[row][0]);
            ibloodtype.BloodName = Convert.ToString(tbl.Rows[row][1]);


            ibloodtype.btn_save = true;
            ibloodtype.btn_delete = true;
            ibloodtype.btn_deleteall = true;
            ibloodtype.btn_add = false;
        }
        public bool BloodtypeInsert()
        {
              connectBetweenModelinterface();

            return BloodTypeServices.BloodTypeInsert(bloodtypeModel.id, bloodtypeModel.BloodName);

        }
        public bool BloodtypeUpdate()
        {
            connectBetweenModelinterface();

            return BloodTypeServices.BloodTypeUpdate(bloodtypeModel.id, bloodtypeModel.BloodName);

        }
        public bool Bloodtypedelete()
        {
            connectBetweenModelinterface();

            return BloodTypeServices.BloodTypedelete(bloodtypeModel.id);


        }
        public bool Bloodtypedeleteall()
        {
            //  connectBetweenModelinterface();

            return BloodTypeServices.BloodTypedeleteall();


        }
    }
}
