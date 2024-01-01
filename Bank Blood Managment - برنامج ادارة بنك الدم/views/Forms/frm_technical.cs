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
    public partial class frm_technical : DevExpress.XtraEditors.XtraForm ,Itechnical
    {
       

        public int id { get =>Convert.ToInt32(txt_ID.Text) ; set =>txt_ID.Text=value.ToString() ; }
        public int Row { get => row; set =>row=value ; }
        public string tename { get =>txt_Name.Text ; set => txt_Name.Text=value; }
        public string tephone { get => txt_phone.Text; set => txt_phone.Text = value; }
        public string teaddress { get => txt_address.Text; set => txt_address.Text = value; }
        public string tedate { get => dtp.Text; set => dtp.Text = value; }
        public string note { get =>txt_note.Text; set =>txt_note.Text=value; }

        object Itechnical.btn_add { get => btn_add.Enabled; set => btn_add.Enabled = Convert.ToBoolean(value); }
        object Itechnical.btn_new { get => btn_new.Enabled; set => btn_new.Enabled = Convert.ToBoolean(value); }
        object Itechnical.btn_save { get => btn_save.Enabled; set => btn_save.Enabled = Convert.ToBoolean(value); }
        object Itechnical.btn_delete { get => btn_delete.Enabled; set => btn_delete.Enabled = Convert.ToBoolean(value); }
        object Itechnical.btn_deleteall { get => btn_deleteall.Enabled; set => btn_deleteall.Enabled = Convert.ToBoolean(value); }
        public object dataGridView { get => Dgv_search.DataSource; set => Dgv_search.DataSource=value; }

        public int row;
        TechnicalPresenter TechPresenter;
        public frm_technical()
        {
            InitializeComponent();
            TechPresenter = new TechnicalPresenter(this);

        }

        private void frm_technical_Load(object sender, EventArgs e)
        {
            TechPresenter.AutoNumber();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (txt_Name.Text == "")
            {
                MessageBox.Show("من فضلك ادخل اسم الفني", "تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }
            if (txt_phone.Text == "")
            {
                MessageBox.Show("من فضلك ادخل هاتف الفني", "تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }
            if (txt_address.Text == "")
            {
                MessageBox.Show("من فضلك ادخل عنوان الفني", "تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }
            bool check = TechPresenter.technicalInsert();
            if (check)
            {
                MessageBox.Show("تم اضافة الفني ", "تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TechPresenter.AutoNumber();
            }
            else
            {
                MessageBox.Show("هناك خطأ لم يتم اضافة الفني ", "تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (txt_Name.Text == "")
            {
                MessageBox.Show("من فضلك ادخل اسم الفني", "تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }
            if (txt_phone.Text == "")
            {
                MessageBox.Show("من فضلك ادخل هاتف الفني", "تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }
            if (txt_address.Text == "")
            {
                MessageBox.Show("من فضلك ادخل عنوان الفني", "تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }
            bool check = TechPresenter.technicalUpdate();
            if (check)
            {
                MessageBox.Show("تم تعديل بيانات الفني ", "تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TechPresenter.AutoNumber();
            }
            else
            {
                MessageBox.Show("هناك خطأ لم يتم تعديل بيانات الفني ", "تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            bool check = TechPresenter.technicaldelete();
            if (check)
            {
                MessageBox.Show("تم حذف بيانات الفني ", "تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TechPresenter.AutoNumber();
            }
            else
            {
                MessageBox.Show("هناك خطأ لم يتم حذف بيانات الفني ", "تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_deleteall_Click(object sender, EventArgs e)
        {
            bool check = TechPresenter.technicaldeleteall();
            if (check)
            {
                MessageBox.Show("تم حذف  الكل ", "تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TechPresenter.AutoNumber();
            }
            else
            {
                MessageBox.Show("هناك خطأ لم يتم حذف الكل ", "تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_first_Click(object sender, EventArgs e)
        {

            try
            {
                row = 0;
                TechPresenter.getrow(row);
            }
            catch (Exception) { }
        }

        private void btn_priv_Click(object sender, EventArgs e)
        {

            try
            {
                int countrow = Convert.ToInt32(TechPresenter.Getlastrow().Rows[0][0]) - 1;
                if (row == 0)
                {
                    row = countrow;
                }
                else
                {
                    row = row - 1;

                }

                TechPresenter.getrow(row);
            }
            catch (Exception) { }
        }

        private void btn_next_Click(object sender, EventArgs e)
        {

            try
            {
                int countrow = Convert.ToInt32(TechPresenter.Getlastrow().Rows[0][0]) - 1;
                if (countrow == row)
                {
                    row = 0;
                }
                else
                {
                    row = row + 1;

                }

                TechPresenter.getrow(row);
            }
            catch (Exception) { }
        }

        private void btn_last_Click(object sender, EventArgs e)
        {
            try
            {
                int countlastrow = Convert.ToInt32(TechPresenter.Getlastrow().Rows[0][0]) - 1;
                row = countlastrow;

                TechPresenter.getrow(row);
            }
            catch (Exception) { }
        }

        private void btn_new_Click(object sender, EventArgs e)
        {
            frm_technical_Load(null, null);
        }
    }
}