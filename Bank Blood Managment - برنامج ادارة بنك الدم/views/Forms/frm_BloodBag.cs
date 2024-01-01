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
    public partial class frm_BloodBag : DevExpress.XtraEditors.XtraForm,IBloodBag
    {
      

        public int id { get => Convert.ToInt32(txt_ID.Text); set => txt_ID.Text = value.ToString(); }
        public string dname { get => txt_DanerName.Text; set => txt_DanerName.Text = value; }
        public string donerID { get => txt_DanerID.Text; set =>txt_DanerID.Text = value; }
        public int techID { get => Convert.ToInt32(cbx_technicalID.SelectedValue); set => cbx_technicalID.SelectedValue = value; }
        public int Bloodtype { get => Convert.ToInt32(cbx_blood.SelectedValue); set => cbx_blood.SelectedValue = value; }

        public string startdate { get => dtp_datestart.Text     ; set =>dtp_datestart.Text=value      ; }
        public string endtdate { get =>dtp_dateend.Text      ; set => dtp_dateend.Text=value     ; }
        public string note { get => txt_note.Text     ; set =>  txt_note.Text=value    ; }
        public string statubag { get => txt_statubag.Text; set =>txt_statubag.Text=value; }

        public object cbx_techID { get => cbx_technicalID.DataSource; set =>cbx_technicalID.DataSource=value; }
        public object cbx_Bloodtype { get => cbx_blood.DataSource; set => cbx_blood.DataSource = value; }

        public string cbx_techIDDisplaymember { get =>cbx_technicalID.DisplayMember; set =>cbx_technicalID.DisplayMember=value      ; }
        public string cbx_techIDvaluemember { get => cbx_technicalID.ValueMember     ; set =>cbx_technicalID.ValueMember=value      ; }

        public string cbx_BloodtypeDisplaymember { get => cbx_blood.DisplayMember; set => cbx_blood.DisplayMember = value; }
        public string cbx_Bloodtypevaluemember { get => cbx_blood.ValueMember; set => cbx_blood.ValueMember = value; }


        public int cbx_techIDSelectedIndex { get => cbx_technicalID.SelectedIndex; set => cbx_technicalID.SelectedIndex = value; }
        public int cbx_techIDSelectedvalue { get => Convert.ToInt32(cbx_technicalID.SelectedValue); set => cbx_technicalID.SelectedValue = value; }

        public int cbx_BloodtypeSelectedIndex { get => cbx_blood.SelectedIndex; set => cbx_blood.SelectedIndex = value; }
        public int cbx_BloodtypeSelectedvalue { get => Convert.ToInt32(cbx_blood.SelectedValue); set => cbx_blood.SelectedValue = value; }




        object IBloodBag.btn_add { get => btn_add.Enabled; set => btn_add.Enabled = Convert.ToBoolean(value); }
        object IBloodBag.btn_new { get => btn_new.Enabled; set => btn_new.Enabled = Convert.ToBoolean(value); }
        object IBloodBag.btn_save { get => btn_save.Enabled; set => btn_save.Enabled = Convert.ToBoolean(value); }
        object IBloodBag.btn_delete { get => btn_delete.Enabled; set => btn_delete.Enabled = Convert.ToBoolean(value); }
        object IBloodBag.btn_deleteall { get => btn_deleteall.Enabled; set => btn_deleteall.Enabled = Convert.ToBoolean(value); }

        public int row;
        BloodBagPresenter bloodbagPresenter;
        public frm_BloodBag()
        {
            InitializeComponent();
            bloodbagPresenter = new BloodBagPresenter(this);
        }
        private void frm_BloodBag_Load(object sender, EventArgs e)
        {
            bloodbagPresenter.fillcbxtech();
            bloodbagPresenter.fillcbxBlood();
            bloodbagPresenter.AutoNumber();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (txt_DanerName.Text == "")
            {
                MessageBox.Show("من فضلك ادخل اسم المتبرع", "تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }
            if (txt_DanerID.Text == "")
            {
                MessageBox.Show("من فضلك ادخل هوية المتبرع", "تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }
          
            bool check = bloodbagPresenter.BloodBagInsert();
            if (check)
            {
                MessageBox.Show("تم اضافة كيس الدم ", "تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);
                bloodbagPresenter.AutoNumber();
            }
            else
            {
                MessageBox.Show("هناك خطأ لم يتم اضافة الكيس ", "تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (txt_DanerName.Text == "")
            {
                MessageBox.Show("من فضلك ادخل اسم المتبرع", "تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }
            if (txt_DanerID.Text == "")
            {
                MessageBox.Show("من فضلك ادخل هوية المتبرع", "تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

            bool check = bloodbagPresenter.BloodBagUpdate();
            if (check)
            {
                MessageBox.Show("تم تعديل بيانات كيس الدم ", "تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);
                bloodbagPresenter.AutoNumber();
            }
            else
            {
                MessageBox.Show("هناك خطأ لم يتم  تعديل بيانات الكيس ", "تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            bool check = bloodbagPresenter.BloodBagdelete();
            if (check)
            {
                MessageBox.Show("تم حذف بيانات كيس الدم ", "تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);
                bloodbagPresenter.AutoNumber();
            }
            else
            {
                MessageBox.Show("هناك خطأ لم يتم  حذف بيانات الكيس ", "تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_deleteall_Click(object sender, EventArgs e)
        {
            bool check = bloodbagPresenter.BloodBagdeleteall();
            if (check)
            {
                MessageBox.Show("تم حذف الكل ", "تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);
                bloodbagPresenter.AutoNumber();
            }
            else
            {
                MessageBox.Show("هناك خطأ لم يتم حذف الكل ", "تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_new_Click(object sender, EventArgs e)
        {
            frm_BloodBag_Load(null, null);
        }

        private void btn_first_Click(object sender, EventArgs e)
        {
            try
            {
                row = 0;
                bloodbagPresenter.getrow(row);
            }
            catch (Exception) { }
        }

        private void btn_priv_Click(object sender, EventArgs e)
        {
            try
            {
                int countrow = Convert.ToInt32(bloodbagPresenter.Getlastrow().Rows[0][0]) - 1;
                if (row == 0)
                {
                    row = countrow;
                }
                else
                {
                    row = row - 1;

                }

                bloodbagPresenter.getrow(row);
            }
            catch (Exception) { }
        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            try
            {
                int countrow = Convert.ToInt32(bloodbagPresenter.Getlastrow().Rows[0][0]) - 1;
                if (countrow == row)
                {
                    row = 0;
                }
                else
                {
                    row = row + 1;

                }

                bloodbagPresenter.getrow(row);
            }
            catch (Exception) { }
        }

        private void btn_last_Click(object sender, EventArgs e)
        {

            try
            {
                int countlastrow = Convert.ToInt32(bloodbagPresenter.Getlastrow().Rows[0][0]) - 1;
                row = countlastrow;

                bloodbagPresenter.getrow(row);
            }
            catch (Exception) { }
        }
    }
}