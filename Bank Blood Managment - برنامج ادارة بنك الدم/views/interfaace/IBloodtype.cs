using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Blood_Managment___برنامج_ادارة_بنك_الدم.views.interfaace
{
    interface IBloodtype
    {

        int id { get; set; }
        string BloodName { get; set; }
        int Row { get; set; }
        object dataGridView { get; set; }


        object btn_add { get; set; }
        object btn_new { get; set; }
        object btn_save { get; set; }
        object btn_delete { get; set; }
        object btn_deleteall { get; set; }
    }
}
