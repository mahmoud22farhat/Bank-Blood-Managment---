using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Blood_Managment___برنامج_ادارة_بنك_الدم.views.interfaace
    {
     interface Itechnical
    {
    
        int id { get; set; }
        int Row { get; set; }
        string tename { get; set; }
        string tephone { get; set; }
        string teaddress { get; set; }
        string tedate { get; set; }
        string note { get; set; }


        object btn_add { get; set; }
        object btn_new { get; set; }
        object btn_save { get; set; }
        object btn_delete { get; set; }
        object btn_deleteall { get; set; }
    }
     }