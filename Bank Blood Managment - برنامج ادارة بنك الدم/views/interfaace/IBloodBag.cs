using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Blood_Managment___برنامج_ادارة_بنك_الدم.views.interfaace
{
    interface IBloodBag
    {
        int id { get; set; }
        string dname { get; set; }
        string donerID { get; set; }
        int techID { get; set; }
        string startdate { get; set; }
        string endtdate { get; set; }
        int Bloodtype { get; set; }
        string note { get; set; }
        string statubag { get; set; }


        object cbx_techID { get; set; }
        string cbx_techIDDisplaymember { get; set; }
        string cbx_techIDvaluemember { get; set; }

        object cbx_Bloodtype { get; set; }
        string cbx_BloodtypeDisplaymember { get; set; }
        string cbx_Bloodtypevaluemember { get; set; }



        int cbx_techIDSelectedIndex { get; set; }
        int cbx_techIDSelectedvalue { get; set; }

        int cbx_BloodtypeSelectedIndex { get; set; }
        int cbx_BloodtypeSelectedvalue { get; set; }

        object btn_add { get; set; }
        object btn_new { get; set; }
        object btn_save { get; set; }
        object btn_delete { get; set; }
        object btn_deleteall { get; set; }


    }
}
