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

        public int row;
 public frm_technical()
        {
            InitializeComponent();
        }
    }
}