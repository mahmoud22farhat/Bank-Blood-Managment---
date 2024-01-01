using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Blood_Managment___برنامج_ادارة_بنك_الدم.views.interfaace
{
    interface IUnreadyBloodBag
    {

      string dtpto{ set; get; }
      string dtpfrom { set; get; }
        int techid { set; get; }
        int Bloodtype { set; get; }
        int BloodtypeUpdate { set; get; }
        int techcontrol { set; get; }

        object dataGridView { get; set; }

        object cbxtechnical { get; set; }
        string cbxtechnicaldisplaymember { get; set; }
        string cbxtechnicalvaluemember{ get; set; }
        int cbxtechnicalselectedvalue { get; set; }
        int cbxtechnicalselectedindex { get; set; }

        object cbxbloodtype { get; set; }
        string cbxbloodtypedisplaymember { get; set; }
        string cbxbloodtypevaluemember { get; set; }
        int cbxbloodtypeselectedvalue { get; set; }
        int cbxbloodtypeselectedindex { get; set; }

        object cbxbloodtypeUpdate { get; set; }
        string cbxbloodtypeUpdatedisplaymember { get; set; }
        string cbxbloodtypeUpdatevaluemember { get; set; }
        int cbxbloodtypeUpdateselectedvalue { get; set; }
        int cbxbloodtypeUpdateselectedindex { get; set; }


        object cbxtechnicalcontral { get; set; }
        string cbxtechnicalcontraldisplaymember { get; set; }
        string cbxtechnicalcontralvaluemember { get; set; }
        int cbxtechnicalcontralselectedvalue { get; set; }
        int cbxtechnicalcontralselectedindex { get; set; }

        object btn_search { get; set; }
        object btn_save { get; set; }
        object btn_waitforResult { get; set; }
        object btn_saveandgetreadr { get; set; }
        object btn_bagdamade { get; set; }

    }
}
