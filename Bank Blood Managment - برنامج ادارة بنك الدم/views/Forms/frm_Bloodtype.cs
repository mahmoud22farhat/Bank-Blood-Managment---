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
    public partial class frm_Bloodtype : DevExpress.XtraEditors.XtraForm,IBloodtype
    {
      

        public int id { get => Convert.ToInt32(txt_ID.Text) ; set =>txt_ID.Text=value.ToString() ; }
        public int Row { get => row; set => row=value; }
        public string BloodName { get => txt_Blood.Text; set => txt_Blood.Text=value; }

        object IBloodtype.btn_add { get => btn_add.Enabled; set => btn_add.Enabled = Convert.ToBoolean(value); }
        object IBloodtype.btn_new { get => btn_new.Enabled; set => btn_new.Enabled = Convert.ToBoolean(value); }
        object IBloodtype.btn_save { get => btn_save.Enabled; set => btn_save.Enabled = Convert.ToBoolean(value); }
        object IBloodtype.btn_delete { get => btn_delete.Enabled; set => btn_delete.Enabled = Convert.ToBoolean(value); }
        object IBloodtype.btn_deleteall { get => btn_deleteall.Enabled; set => btn_deleteall.Enabled = Convert.ToBoolean(value); }

        public object dataGridView { get => Dgv_search.DataSource; set => Dgv_search.DataSource = value; }

        public  int row;
        BloodtypePresenter bloodtyprpresenter;
        public frm_Bloodtype()
        {
            InitializeComponent();
            bloodtyprpresenter = new BloodtypePresenter(this);

        }
        private void frm_Bloodtype_Load(object sender, EventArgs e)
        {
            bloodtyprpresenter.AutoNumber();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (txt_Blood.Text == "")
            {
                MessageBox.Show("من فضلك ادخل اسم فصيلة الدم", "تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

            bool check = bloodtyprpresenter.BloodtypeInsert();
            if (check)
            {
                MessageBox.Show("تم اضافة فصيلة الدم ", "تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);
                bloodtyprpresenter.AutoNumber();
            }
            else
            {
                MessageBox.Show("هناك خطأ لم يتم اضافة فصيلة الدم ", "تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (txt_Blood.Text == "")
            {
                MessageBox.Show("من فضلك ادخل اسم فصيلة الدم", "تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

            bool check = bloodtyprpresenter.BloodtypeUpdate();
            if (check)
            {
                MessageBox.Show("تم تعديل فصيلة الدم ", "تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);
                bloodtyprpresenter.AutoNumber();
            }
            else
            {
                MessageBox.Show("هناك خطأ لم يتم تعديل فصيلة الدم ", "تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            bool check = bloodtyprpresenter.Bloodtypedelete();
            if (check)
            {
                MessageBox.Show("تم حذف فصيلة الدم ", "تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);
                bloodtyprpresenter.AutoNumber();
            }
            else
            {
                MessageBox.Show("هناك خطأ لم يتم حذف فصيلة الدم ", "تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_deleteall_Click(object sender, EventArgs e)
        {
            bool check = bloodtyprpresenter.Bloodtypedeleteall();
            if (check)
            {
                MessageBox.Show("تم حذف الكل ", "تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);
                bloodtyprpresenter.AutoNumber();
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
                bloodtyprpresenter.getrow(row);
            }
            catch (Exception) { }
        }

        private void btn_priv_Click(object sender, EventArgs e)
        {
            try
            {
                int countrow = Convert.ToInt32(bloodtyprpresenter.Getlastrow().Rows[0][0]) - 1;
                if (row == 0)
                {
                    row = countrow;
                }
                else
                {
                    row = row - 1;

                }

                bloodtyprpresenter.getrow(row);
            }
            catch (Exception) { }
        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            try
            {
                int countrow = Convert.ToInt32(bloodtyprpresenter.Getlastrow().Rows[0][0]) - 1;
                if (countrow == row)
                {
                    row = 0;
                }
                else
                {
                    row = row + 1;

                }

                bloodtyprpresenter.getrow(row);
            }
            catch (Exception) { }
        }

        private void btn_last_Click(object sender, EventArgs e)
        {
            try
            {
                int countlastrow = Convert.ToInt32(bloodtyprpresenter.Getlastrow().Rows[0][0]) - 1;
                row = countlastrow;

                bloodtyprpresenter.getrow(row);
            }
            catch (Exception) { }
        }

        private void btn_new_Click(object sender, EventArgs e)
        {
            frm_Bloodtype_Load(null, null);
        }
    }
}