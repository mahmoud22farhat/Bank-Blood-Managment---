using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;

namespace Bank_Blood_Managment___برنامج_ادارة_بنك_الدم.views.Forms
{
    public partial class frm_main : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public frm_main()
        {
            InitializeComponent();
        }

        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
            frm_technical frm = new frm_technical();
            frm.ShowDialog();
        }
    }
}