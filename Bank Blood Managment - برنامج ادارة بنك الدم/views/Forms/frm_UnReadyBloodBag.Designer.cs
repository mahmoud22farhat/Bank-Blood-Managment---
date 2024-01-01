namespace Bank_Blood_Managment___برنامج_ادارة_بنك_الدم.views.Forms
{
    partial class frm_UnReadyBloodBag
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Dgv_search = new System.Windows.Forms.DataGridView();
            this.cbx_technical = new System.Windows.Forms.ComboBox();
            this.rptntechnical = new System.Windows.Forms.RadioButton();
            this.rptnbloodtype = new System.Windows.Forms.RadioButton();
            this.cbx_Bloodtype = new System.Windows.Forms.ComboBox();
            this.rptnuser = new System.Windows.Forms.RadioButton();
            this.cbx_BloodTypeUpdate = new System.Windows.Forms.ComboBox();
            this.rptnalldata = new System.Windows.Forms.RadioButton();
            this.txt_user = new System.Windows.Forms.TextBox();
            this.dtp_dateto = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.dtp_datefrom = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_search = new DevExpress.XtraEditors.SimpleButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_waitforResult = new DevExpress.XtraEditors.SimpleButton();
            this.btn_save = new DevExpress.XtraEditors.SimpleButton();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_saveandgetreadr = new DevExpress.XtraEditors.SimpleButton();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btn_bagdamade = new DevExpress.XtraEditors.SimpleButton();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cbx_technicalcontrol = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_search)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // Dgv_search
            // 
            this.Dgv_search.AllowUserToAddRows = false;
            this.Dgv_search.AllowUserToDeleteRows = false;
            this.Dgv_search.AllowUserToResizeColumns = false;
            this.Dgv_search.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Dgv_search.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.Dgv_search.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.Dgv_search.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(31)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Dgv_search.DefaultCellStyle = dataGridViewCellStyle2;
            this.Dgv_search.Location = new System.Drawing.Point(12, 118);
            this.Dgv_search.Name = "Dgv_search";
            this.Dgv_search.ReadOnly = true;
            this.Dgv_search.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Blue;
            this.Dgv_search.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.Dgv_search.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Blue;
            this.Dgv_search.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Dgv_search.Size = new System.Drawing.Size(1135, 266);
            this.Dgv_search.TabIndex = 62;
            this.Dgv_search.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_search_CellContentClick);
            // 
            // cbx_technical
            // 
            this.cbx_technical.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_technical.FormattingEnabled = true;
            this.cbx_technical.Location = new System.Drawing.Point(530, 18);
            this.cbx_technical.Name = "cbx_technical";
            this.cbx_technical.Size = new System.Drawing.Size(118, 33);
            this.cbx_technical.TabIndex = 64;
            // 
            // rptntechnical
            // 
            this.rptntechnical.AutoSize = true;
            this.rptntechnical.Font = new System.Drawing.Font("Droid Arabic Kufi", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rptntechnical.ForeColor = System.Drawing.Color.Crimson;
            this.rptntechnical.Location = new System.Drawing.Point(654, 16);
            this.rptntechnical.Name = "rptntechnical";
            this.rptntechnical.Size = new System.Drawing.Size(67, 32);
            this.rptntechnical.TabIndex = 65;
            this.rptntechnical.TabStop = true;
            this.rptntechnical.Text = "الفني";
            this.rptntechnical.UseVisualStyleBackColor = true;
            // 
            // rptnbloodtype
            // 
            this.rptnbloodtype.AutoSize = true;
            this.rptnbloodtype.Font = new System.Drawing.Font("Droid Arabic Kufi", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rptnbloodtype.ForeColor = System.Drawing.Color.Crimson;
            this.rptnbloodtype.Location = new System.Drawing.Point(408, 19);
            this.rptnbloodtype.Name = "rptnbloodtype";
            this.rptnbloodtype.Size = new System.Drawing.Size(105, 32);
            this.rptnbloodtype.TabIndex = 67;
            this.rptnbloodtype.TabStop = true;
            this.rptnbloodtype.Text = "فصيلة الدم";
            this.rptnbloodtype.UseVisualStyleBackColor = true;
            // 
            // cbx_Bloodtype
            // 
            this.cbx_Bloodtype.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_Bloodtype.FormattingEnabled = true;
            this.cbx_Bloodtype.Location = new System.Drawing.Point(288, 16);
            this.cbx_Bloodtype.Name = "cbx_Bloodtype";
            this.cbx_Bloodtype.Size = new System.Drawing.Size(114, 33);
            this.cbx_Bloodtype.TabIndex = 66;
            // 
            // rptnuser
            // 
            this.rptnuser.AutoSize = true;
            this.rptnuser.Font = new System.Drawing.Font("Droid Arabic Kufi", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rptnuser.ForeColor = System.Drawing.Color.Crimson;
            this.rptnuser.Location = new System.Drawing.Point(154, 17);
            this.rptnuser.Name = "rptnuser";
            this.rptnuser.Size = new System.Drawing.Size(128, 32);
            this.rptnuser.TabIndex = 69;
            this.rptnuser.TabStop = true;
            this.rptnuser.Text = "اسم المستخدم";
            this.rptnuser.UseVisualStyleBackColor = true;
            // 
            // cbx_BloodTypeUpdate
            // 
            this.cbx_BloodTypeUpdate.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_BloodTypeUpdate.FormattingEnabled = true;
            this.cbx_BloodTypeUpdate.Location = new System.Drawing.Point(84, 25);
            this.cbx_BloodTypeUpdate.Name = "cbx_BloodTypeUpdate";
            this.cbx_BloodTypeUpdate.Size = new System.Drawing.Size(105, 33);
            this.cbx_BloodTypeUpdate.TabIndex = 68;
            // 
            // rptnalldata
            // 
            this.rptnalldata.AutoSize = true;
            this.rptnalldata.Font = new System.Drawing.Font("Droid Arabic Kufi", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rptnalldata.ForeColor = System.Drawing.Color.Crimson;
            this.rptnalldata.Location = new System.Drawing.Point(597, 59);
            this.rptnalldata.Name = "rptnalldata";
            this.rptnalldata.Size = new System.Drawing.Size(137, 32);
            this.rptnalldata.TabIndex = 70;
            this.rptnalldata.TabStop = true;
            this.rptnalldata.Text = "عرض كل البيانات";
            this.rptnalldata.UseVisualStyleBackColor = true;
            // 
            // txt_user
            // 
            this.txt_user.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_user.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_user.Location = new System.Drawing.Point(32, 16);
            this.txt_user.Name = "txt_user";
            this.txt_user.Size = new System.Drawing.Size(116, 32);
            this.txt_user.TabIndex = 76;
            this.txt_user.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dtp_dateto
            // 
            this.dtp_dateto.CalendarFont = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_dateto.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_dateto.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_dateto.Location = new System.Drawing.Point(394, 61);
            this.dtp_dateto.Name = "dtp_dateto";
            this.dtp_dateto.Size = new System.Drawing.Size(119, 32);
            this.dtp_dateto.TabIndex = 78;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Droid Arabic Kufi", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Crimson;
            this.label4.Location = new System.Drawing.Point(518, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 28);
            this.label4.TabIndex = 77;
            this.label4.Text = "من:";
            // 
            // dtp_datefrom
            // 
            this.dtp_datefrom.CalendarFont = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_datefrom.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_datefrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_datefrom.Location = new System.Drawing.Point(223, 61);
            this.dtp_datefrom.Name = "dtp_datefrom";
            this.dtp_datefrom.Size = new System.Drawing.Size(119, 32);
            this.dtp_datefrom.TabIndex = 80;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Droid Arabic Kufi", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Crimson;
            this.label1.Location = new System.Drawing.Point(348, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 28);
            this.label1.TabIndex = 79;
            this.label1.Text = "الي:";
            // 
            // btn_search
            // 
            this.btn_search.Appearance.BackColor = System.Drawing.Color.Lime;
            this.btn_search.Appearance.BackColor2 = System.Drawing.Color.Lime;
            this.btn_search.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_search.Appearance.Font = new System.Drawing.Font("Droid Arabic Kufi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_search.Appearance.Options.UseBackColor = true;
            this.btn_search.Appearance.Options.UseBorderColor = true;
            this.btn_search.Appearance.Options.UseFont = true;
            this.btn_search.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightTop;
            this.btn_search.Location = new System.Drawing.Point(32, 61);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(183, 33);
            this.btn_search.TabIndex = 81;
            this.btn_search.Text = "بحث";
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rptntechnical);
            this.groupBox1.Controls.Add(this.btn_search);
            this.groupBox1.Controls.Add(this.cbx_technical);
            this.groupBox1.Controls.Add(this.dtp_datefrom);
            this.groupBox1.Controls.Add(this.rptnbloodtype);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cbx_Bloodtype);
            this.groupBox1.Controls.Add(this.dtp_dateto);
            this.groupBox1.Controls.Add(this.rptnuser);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txt_user);
            this.groupBox1.Controls.Add(this.rptnalldata);
            this.groupBox1.Location = new System.Drawing.Point(178, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(737, 100);
            this.groupBox1.TabIndex = 82;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_waitforResult);
            this.groupBox2.Controls.Add(this.btn_save);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.cbx_BloodTypeUpdate);
            this.groupBox2.Location = new System.Drawing.Point(12, 390);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(324, 114);
            this.groupBox2.TabIndex = 83;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "تعديل";
            // 
            // btn_waitforResult
            // 
            this.btn_waitforResult.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_waitforResult.Appearance.BackColor2 = System.Drawing.Color.Red;
            this.btn_waitforResult.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_waitforResult.Appearance.Font = new System.Drawing.Font("Droid Arabic Kufi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_waitforResult.Appearance.Options.UseBackColor = true;
            this.btn_waitforResult.Appearance.Options.UseBorderColor = true;
            this.btn_waitforResult.Appearance.Options.UseFont = true;
            this.btn_waitforResult.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.btn_waitforResult.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightTop;
            this.btn_waitforResult.Location = new System.Drawing.Point(6, 75);
            this.btn_waitforResult.Name = "btn_waitforResult";
            this.btn_waitforResult.Size = new System.Drawing.Size(298, 33);
            this.btn_waitforResult.TabIndex = 85;
            this.btn_waitforResult.Text = "وضع الكيس المحدد في انتظار النتيجة";
            // 
            // btn_save
            // 
            this.btn_save.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_save.Appearance.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_save.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_save.Appearance.Font = new System.Drawing.Font("Droid Arabic Kufi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.Appearance.Options.UseBackColor = true;
            this.btn_save.Appearance.Options.UseBorderColor = true;
            this.btn_save.Appearance.Options.UseFont = true;
            this.btn_save.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.btn_save.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightTop;
            this.btn_save.Location = new System.Drawing.Point(6, 25);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(72, 33);
            this.btn_save.TabIndex = 82;
            this.btn_save.Text = "حفظ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Crimson;
            this.label2.Location = new System.Drawing.Point(191, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 25);
            this.label2.TabIndex = 82;
            this.label2.Text = "تعديل فصيلة الدم:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btn_saveandgetreadr);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.comboBox5);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.comboBox4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.comboBox3);
            this.groupBox3.Location = new System.Drawing.Point(336, 404);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(817, 57);
            this.groupBox3.TabIndex = 84;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "نتيجة التحليل";
            // 
            // btn_saveandgetreadr
            // 
            this.btn_saveandgetreadr.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_saveandgetreadr.Appearance.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_saveandgetreadr.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_saveandgetreadr.Appearance.Font = new System.Drawing.Font("Droid Arabic Kufi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_saveandgetreadr.Appearance.Options.UseBackColor = true;
            this.btn_saveandgetreadr.Appearance.Options.UseBorderColor = true;
            this.btn_saveandgetreadr.Appearance.Options.UseFont = true;
            this.btn_saveandgetreadr.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.btn_saveandgetreadr.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightTop;
            this.btn_saveandgetreadr.Location = new System.Drawing.Point(6, 14);
            this.btn_saveandgetreadr.Name = "btn_saveandgetreadr";
            this.btn_saveandgetreadr.Size = new System.Drawing.Size(192, 33);
            this.btn_saveandgetreadr.TabIndex = 86;
            this.btn_saveandgetreadr.Text = "حفظ وتحويل لجاهز للصرف";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Crimson;
            this.label6.Location = new System.Drawing.Point(298, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 25);
            this.label6.TabIndex = 91;
            this.label6.Text = "تحليل الملاريا:";
            // 
            // comboBox5
            // 
            this.comboBox5.Font = new System.Drawing.Font("Droid Arabic Kufi", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox5.FormattingEnabled = true;
            this.comboBox5.Location = new System.Drawing.Point(204, 17);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(92, 30);
            this.comboBox5.TabIndex = 90;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Crimson;
            this.label5.Location = new System.Drawing.Point(487, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 25);
            this.label5.TabIndex = 89;
            this.label5.Text = "تحليل الايدز:";
            // 
            // comboBox4
            // 
            this.comboBox4.Font = new System.Drawing.Font("Droid Arabic Kufi", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(393, 19);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(92, 30);
            this.comboBox4.TabIndex = 88;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Crimson;
            this.label3.Location = new System.Drawing.Point(666, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 25);
            this.label3.TabIndex = 87;
            this.label3.Text = "تحليل الالتهاب الكبدي:";
            // 
            // comboBox3
            // 
            this.comboBox3.Font = new System.Drawing.Font("Droid Arabic Kufi", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(572, 19);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(92, 30);
            this.comboBox3.TabIndex = 86;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btn_bagdamade);
            this.groupBox4.Controls.Add(this.dateTimePicker2);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.cbx_technicalcontrol);
            this.groupBox4.Location = new System.Drawing.Point(337, 460);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(810, 62);
            this.groupBox4.TabIndex = 85;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "اتلاف الكيس";
            // 
            // btn_bagdamade
            // 
            this.btn_bagdamade.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_bagdamade.Appearance.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_bagdamade.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_bagdamade.Appearance.Font = new System.Drawing.Font("Droid Arabic Kufi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_bagdamade.Appearance.Options.UseBackColor = true;
            this.btn_bagdamade.Appearance.Options.UseBorderColor = true;
            this.btn_bagdamade.Appearance.Options.UseFont = true;
            this.btn_bagdamade.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.btn_bagdamade.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightTop;
            this.btn_bagdamade.Location = new System.Drawing.Point(6, 18);
            this.btn_bagdamade.Name = "btn_bagdamade";
            this.btn_bagdamade.Size = new System.Drawing.Size(186, 33);
            this.btn_bagdamade.TabIndex = 92;
            this.btn_bagdamade.Text = "اتلاف الكيس المحدد";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CalendarFont = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker2.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.Location = new System.Drawing.Point(198, 20);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(155, 32);
            this.dateTimePicker2.TabIndex = 95;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Crimson;
            this.label8.Location = new System.Drawing.Point(356, 23);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 25);
            this.label8.TabIndex = 94;
            this.label8.Text = "تاريخ الاتلاف:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Crimson;
            this.label7.Location = new System.Drawing.Point(660, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(126, 25);
            this.label7.TabIndex = 93;
            this.label7.Text = "اسم الفني المسؤل:";
            // 
            // cbx_technicalcontrol
            // 
            this.cbx_technicalcontrol.Font = new System.Drawing.Font("Droid Arabic Kufi", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_technicalcontrol.FormattingEnabled = true;
            this.cbx_technicalcontrol.Location = new System.Drawing.Point(449, 22);
            this.cbx_technicalcontrol.Name = "cbx_technicalcontrol";
            this.cbx_technicalcontrol.Size = new System.Drawing.Size(209, 30);
            this.cbx_technicalcontrol.TabIndex = 92;
            // 
            // frm_UnReadyBloodBag
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1165, 555);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Dgv_search);
            this.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.LookAndFeel.UseWindowsXPTheme = true;
            this.Margin = new System.Windows.Forms.Padding(8, 12, 8, 12);
            this.Name = "frm_UnReadyBloodBag";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_UnReadyBloodBag";
            this.Load += new System.EventHandler(this.frm_UnReadyBloodBag_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_search)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView Dgv_search;
        private System.Windows.Forms.ComboBox cbx_technical;
        private System.Windows.Forms.RadioButton rptntechnical;
        private System.Windows.Forms.RadioButton rptnbloodtype;
        private System.Windows.Forms.ComboBox cbx_Bloodtype;
        private System.Windows.Forms.RadioButton rptnuser;
        private System.Windows.Forms.ComboBox cbx_BloodTypeUpdate;
        private System.Windows.Forms.RadioButton rptnalldata;
        private System.Windows.Forms.TextBox txt_user;
        private System.Windows.Forms.DateTimePicker dtp_dateto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtp_datefrom;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.SimpleButton btn_search;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private DevExpress.XtraEditors.SimpleButton btn_waitforResult;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox3;
        private DevExpress.XtraEditors.SimpleButton btn_save;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox4;
        private DevExpress.XtraEditors.SimpleButton btn_saveandgetreadr;
        private DevExpress.XtraEditors.SimpleButton btn_bagdamade;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbx_technicalcontrol;
    }
}