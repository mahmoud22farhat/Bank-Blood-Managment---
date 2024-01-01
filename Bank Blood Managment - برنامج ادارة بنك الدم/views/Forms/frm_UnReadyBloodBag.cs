using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Bank_Blood_Managment___برنامج_ادارة_بنك_الدم.views.interfaace;
using Bank_Blood_Managment___برنامج_ادارة_بنك_الدم.Logic.presenter;

namespace Bank_Blood_Managment___برنامج_ادارة_بنك_الدم.views.Forms
{
    public partial class frm_UnReadyBloodBag : DevExpress.XtraEditors.XtraForm,IUnreadyBloodBag
    {
       

        public string dtpto { get =>dtp_dateto.Text; set => dtp_dateto.Text=value; }
        public string dtpfrom { get =>dtp_datefrom.Text; set =>dtp_datefrom.Text=value; }
        public int techid { get => Convert.ToInt32(cbx_technical.SelectedValue); set => cbx_technical.SelectedValue = Convert.ToInt32(value); }
        public int Bloodtype { get => Convert.ToInt32(cbx_Bloodtype.SelectedValue); set => cbx_Bloodtype.SelectedValue = Convert.ToInt32(value); }
        public int BloodtypeUpdate { get => Convert.ToInt32(cbx_BloodTypeUpdate.SelectedValue); set => cbx_BloodTypeUpdate.SelectedValue = Convert.ToInt32(value); }
        public int techcontrol { get => Convert.ToInt32(cbx_technicalcontrol.SelectedValue); set => cbx_technicalcontrol.SelectedValue = Convert.ToInt32(value); }

        public object cbxtechnical { get =>cbx_technical.DataSource; set =>cbx_technical.DataSource=value; }
        public string cbxtechnicaldisplaymember { get =>cbx_technical.DisplayMember; set =>cbx_technical.DisplayMember=value; }
        public string cbxtechnicalvaluemember { get => cbx_technical.ValueMember; set => cbx_technical.ValueMember = value; }
        public int cbxtechnicalselectedvalue { get => Convert.ToInt32(cbx_technical.SelectedValue); set => cbx_technical.SelectedValue = value; }
        public int cbxtechnicalselectedindex { get => cbx_technical.SelectedIndex; set => cbx_technical.SelectedIndex = value; }
      
        public object cbxbloodtype { get =>cbx_Bloodtype.DataSource; set =>cbx_Bloodtype.DataSource=value; }
        public string cbxbloodtypedisplaymember { get =>cbx_Bloodtype.DisplayMember; set =>cbx_Bloodtype.DisplayMember=value; }
        public string cbxbloodtypevaluemember { get => cbx_Bloodtype.ValueMember; set => cbx_Bloodtype.ValueMember = value; }
         public int cbxbloodtypeselectedvalue { get => Convert.ToInt32(cbx_Bloodtype.SelectedValue); set => cbx_Bloodtype.SelectedValue = value; }
        public int cbxbloodtypeselectedindex { get => cbx_Bloodtype.SelectedIndex; set => cbx_Bloodtype.SelectedIndex = value; }


        public object cbxbloodtypeUpdate { get => cbx_BloodTypeUpdate.DataSource; set => cbx_BloodTypeUpdate.DataSource = value; }
        public string cbxbloodtypeUpdatedisplaymember { get => cbx_BloodTypeUpdate.DisplayMember; set => cbx_BloodTypeUpdate.DisplayMember = value; }
        public string cbxbloodtypeUpdatevaluemember { get => cbx_BloodTypeUpdate.ValueMember; set => cbx_BloodTypeUpdate.ValueMember = value; }
        public int cbxbloodtypeUpdateselectedvalue { get => Convert.ToInt32(cbx_BloodTypeUpdate.SelectedValue); set => cbx_BloodTypeUpdate.SelectedValue = value; }
        public int cbxbloodtypeUpdateselectedindex { get => cbx_BloodTypeUpdate.SelectedIndex; set => cbx_BloodTypeUpdate.SelectedIndex = value; }


        public object cbxtechnicalcontral { get => cbx_technicalcontrol.DataSource; set => cbx_technicalcontrol.DataSource = value; }
        public string cbxtechnicalcontraldisplaymember { get => cbx_technicalcontrol.DisplayMember; set => cbx_technicalcontrol.DisplayMember = value; }
        public string cbxtechnicalcontralvaluemember { get => cbx_technicalcontrol.ValueMember; set => cbx_technicalcontrol.ValueMember = value; }
        public int cbxtechnicalcontralselectedvalue { get => Convert.ToInt32(cbx_technicalcontrol.SelectedValue); set => cbx_technicalcontrol.SelectedValue = value; }
        public int cbxtechnicalcontralselectedindex { get => cbx_technicalcontrol.SelectedIndex; set => cbx_technicalcontrol.SelectedIndex = value; }


        object IUnreadyBloodBag.btn_search { get =>btn_search.Enabled; set => btn_search.Enabled=Convert.ToBoolean(value); }
        object IUnreadyBloodBag.btn_save { get =>btn_save.Enabled; set => btn_save.Enabled=Convert.ToBoolean(value); }
        object IUnreadyBloodBag.btn_waitforResult { get =>btn_waitforResult.Enabled; set =>btn_waitforResult.Enabled=Convert.ToBoolean(value); }
        object IUnreadyBloodBag.btn_saveandgetreadr { get =>btn_saveandgetreadr.Enabled; set =>btn_saveandgetreadr.Enabled=Convert.ToBoolean(value); }
        object IUnreadyBloodBag.btn_bagdamade { get =>btn_bagdamade.Enabled; set =>btn_bagdamade.Enabled=Convert.ToBoolean(value); }
        public object dataGridView { get => Dgv_search.DataSource; set => Dgv_search.DataSource = value; }

        UnreadyBloodBagPresenter unreadybloodbagPresenter;
        public frm_UnReadyBloodBag()
        {
            InitializeComponent();
            unreadybloodbagPresenter = new UnreadyBloodBagPresenter(this);

        }
        private void frm_UnReadyBloodBag_Load(object sender, EventArgs e)
        {
            unreadybloodbagPresenter.fillcbxBlood();
            unreadybloodbagPresenter.fillcbxtech();
            unreadybloodbagPresenter.fillcbxBloodupdate();
            unreadybloodbagPresenter.fillcbxtechcontrol();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            if (rptnalldata.Checked == true)
            {
                unreadybloodbagPresenter.fillDGV();
            }else if(rptnbloodtype.Checked==true)
            {
                unreadybloodbagPresenter.fillDGVByBlood();
            }
            else if (rptntechnical.Checked == true)
            {
                unreadybloodbagPresenter.fillDGVBytech();
            }
        }

        private void Dgv_search_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}