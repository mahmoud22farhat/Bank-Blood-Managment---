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
    class UnreadyBloodBagPresenter
    {
        IUnreadyBloodBag iunreadybloodBag;
        UnreadyBloodBagModel unreadybloodBagModel = new UnreadyBloodBagModel();

        public UnreadyBloodBagPresenter(IUnreadyBloodBag view)
        {
            this.iunreadybloodBag = view;


        }
        public void fillcbxtech()
        {

            iunreadybloodBag.cbxtechnical = TechnicalServices.getalltechnicaldata();
            iunreadybloodBag.cbxtechnicaldisplaymember= "اسم الفني";
            iunreadybloodBag.cbxtechnicalvaluemember = "رقم الفني";

        }
        public void fillcbxBlood()
        {

            iunreadybloodBag.cbxbloodtype = BloodBagServices.Getallbloodtype();
            iunreadybloodBag.cbxbloodtypedisplaymember = "Bloodtype";
            iunreadybloodBag.cbxbloodtypevaluemember = "ID";

        }
        public void fillcbxBloodupdate()
        {

            iunreadybloodBag.cbxbloodtypeUpdate = BloodBagServices.Getallbloodtype();
            iunreadybloodBag.cbxbloodtypeUpdatedisplaymember = "Bloodtype";
            iunreadybloodBag.cbxbloodtypeUpdatevaluemember = "ID";

        }
        public void fillcbxtechcontrol()
        {

            iunreadybloodBag.cbxtechnicalcontral = TechnicalServices.getalltechnicaldata();
            iunreadybloodBag.cbxtechnicalcontraldisplaymember = "اسم الفني";
            iunreadybloodBag.cbxtechnicalcontralvaluemember = "رقم الفني";

        }
        public void fillDGV()
        {
            iunreadybloodBag.dataGridView = UnreadyBloodBagServices.Blooddataall();
        }
        public void fillDGVBytech()
        {

            iunreadybloodBag.dataGridView = UnreadyBloodBagServices.getallBloodBytecnical(iunreadybloodBag.techid);
        }
        public void fillDGVByBlood()
        {

            iunreadybloodBag.dataGridView = UnreadyBloodBagServices.getallBloodByBloodtype(iunreadybloodBag.Bloodtype);
        }
    }
}
