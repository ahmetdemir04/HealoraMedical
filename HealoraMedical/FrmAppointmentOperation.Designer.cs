namespace HealoraMedical
{
    partial class FrmAppointmentOperation
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.BtnExit = new Guna.UI2.WinForms.Guna2CircleButton();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.gridAppointment = new System.Windows.Forms.DataGridView();
            this.CmbSicilNo = new Guna.UI2.WinForms.Guna2ComboBox();
            this.dtApointHours = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.DtApointDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.ChYearApo = new Guna.UI2.WinForms.Guna2CustomRadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.ChMonthApo = new Guna.UI2.WinForms.Guna2CustomRadioButton();
            this.ChWeekApo = new Guna.UI2.WinForms.Guna2CustomRadioButton();
            this.BtnList = new Guna.UI2.WinForms.Guna2GradientButton();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.ChAllApo = new Guna.UI2.WinForms.Guna2CustomRadioButton();
            this.ChTodayApo = new Guna.UI2.WinForms.Guna2CustomRadioButton();
            this.CmbPolyclinic = new Guna.UI2.WinForms.Guna2ComboBox();
            this.BtnUpdateAppointment = new Guna.UI2.WinForms.Guna2GradientButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtApointId = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.BtnAddAppointment = new Guna.UI2.WinForms.Guna2GradientButton();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridAppointment)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // BtnExit
            // 
            this.BtnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnExit.Animated = true;
            this.BtnExit.BackColor = System.Drawing.Color.Transparent;
            this.BtnExit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnExit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnExit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnExit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnExit.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(57)))), ((int)(((byte)(65)))));
            this.BtnExit.Font = new System.Drawing.Font("Lato", 8.25F);
            this.BtnExit.ForeColor = System.Drawing.Color.White;
            this.BtnExit.Location = new System.Drawing.Point(1095, 6);
            this.BtnExit.Margin = new System.Windows.Forms.Padding(4);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.BtnExit.Size = new System.Drawing.Size(32, 27);
            this.BtnExit.TabIndex = 23;
            this.BtnExit.Text = "X";
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(0, 35);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.gridAppointment);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.CmbSicilNo);
            this.splitContainer1.Panel2.Controls.Add(this.dtApointHours);
            this.splitContainer1.Panel2.Controls.Add(this.DtApointDate);
            this.splitContainer1.Panel2.Controls.Add(this.groupBox1);
            this.splitContainer1.Panel2.Controls.Add(this.CmbPolyclinic);
            this.splitContainer1.Panel2.Controls.Add(this.BtnUpdateAppointment);
            this.splitContainer1.Panel2.Controls.Add(this.label3);
            this.splitContainer1.Panel2.Controls.Add(this.label4);
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Panel2.Controls.Add(this.TxtApointId);
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Panel2.Controls.Add(this.label5);
            this.splitContainer1.Panel2.Controls.Add(this.BtnAddAppointment);
            this.splitContainer1.Size = new System.Drawing.Size(1131, 479);
            this.splitContainer1.SplitterDistance = 270;
            this.splitContainer1.TabIndex = 24;
            // 
            // gridAppointment
            // 
            this.gridAppointment.AllowUserToAddRows = false;
            this.gridAppointment.AllowUserToDeleteRows = false;
            this.gridAppointment.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridAppointment.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(80)))), ((int)(((byte)(107)))));
            this.gridAppointment.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.gridAppointment.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(48)))), ((int)(((byte)(77)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(3);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(80)))), ((int)(((byte)(130)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridAppointment.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gridAppointment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(91)))), ((int)(((byte)(150)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(91)))), ((int)(((byte)(180)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridAppointment.DefaultCellStyle = dataGridViewCellStyle2;
            this.gridAppointment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridAppointment.EnableHeadersVisualStyles = false;
            this.gridAppointment.Location = new System.Drawing.Point(0, 0);
            this.gridAppointment.Name = "gridAppointment";
            this.gridAppointment.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(80)))), ((int)(((byte)(107)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(80)))), ((int)(((byte)(130)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridAppointment.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.gridAppointment.RowHeadersVisible = false;
            this.gridAppointment.Size = new System.Drawing.Size(1131, 270);
            this.gridAppointment.TabIndex = 2;
            this.gridAppointment.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridAppointment_CellClick);
            // 
            // CmbSicilNo
            // 
            this.CmbSicilNo.BackColor = System.Drawing.Color.Transparent;
            this.CmbSicilNo.BorderRadius = 10;
            this.CmbSicilNo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.CmbSicilNo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbSicilNo.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CmbSicilNo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CmbSicilNo.Font = new System.Drawing.Font("Lato", 12F);
            this.CmbSicilNo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.CmbSicilNo.ItemHeight = 17;
            this.CmbSicilNo.Items.AddRange(new object[] {
            "Erkek",
            "Kız"});
            this.CmbSicilNo.Location = new System.Drawing.Point(132, 60);
            this.CmbSicilNo.Name = "CmbSicilNo";
            this.CmbSicilNo.Size = new System.Drawing.Size(193, 23);
            this.CmbSicilNo.TabIndex = 1;
            // 
            // dtApointHours
            // 
            this.dtApointHours.BorderRadius = 10;
            this.dtApointHours.Checked = true;
            this.dtApointHours.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(91)))), ((int)(((byte)(150)))));
            this.dtApointHours.Font = new System.Drawing.Font("Lato", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtApointHours.ForeColor = System.Drawing.Color.White;
            this.dtApointHours.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtApointHours.Location = new System.Drawing.Point(133, 162);
            this.dtApointHours.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtApointHours.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtApointHours.Name = "dtApointHours";
            this.dtApointHours.Size = new System.Drawing.Size(187, 31);
            this.dtApointHours.TabIndex = 4;
            this.dtApointHours.Value = new System.DateTime(2025, 6, 20, 12, 24, 44, 50);
            // 
            // DtApointDate
            // 
            this.DtApointDate.BorderRadius = 10;
            this.DtApointDate.Checked = true;
            this.DtApointDate.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(91)))), ((int)(((byte)(150)))));
            this.DtApointDate.Font = new System.Drawing.Font("Lato", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtApointDate.ForeColor = System.Drawing.Color.White;
            this.DtApointDate.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.DtApointDate.Location = new System.Drawing.Point(133, 125);
            this.DtApointDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.DtApointDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.DtApointDate.Name = "DtApointDate";
            this.DtApointDate.Size = new System.Drawing.Size(187, 31);
            this.DtApointDate.TabIndex = 3;
            this.DtApointDate.Value = new System.DateTime(2025, 6, 20, 12, 24, 44, 50);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.ChYearApo);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.ChMonthApo);
            this.groupBox1.Controls.Add(this.ChWeekApo);
            this.groupBox1.Controls.Add(this.BtnList);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.ChAllApo);
            this.groupBox1.Controls.Add(this.ChTodayApo);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(645, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(443, 179);
            this.groupBox1.TabIndex = 79;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filitreler";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label10.Location = new System.Drawing.Point(62, 106);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(149, 19);
            this.label10.TabIndex = 84;
            this.label10.Text = "Bu Gün Randevuları";
            // 
            // ChYearApo
            // 
            this.ChYearApo.BackColor = System.Drawing.Color.Transparent;
            this.ChYearApo.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            this.ChYearApo.CheckedState.BorderThickness = 0;
            this.ChYearApo.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            this.ChYearApo.CheckedState.InnerColor = System.Drawing.Color.White;
            this.ChYearApo.ForeColor = System.Drawing.Color.White;
            this.ChYearApo.Location = new System.Drawing.Point(230, 42);
            this.ChYearApo.Name = "ChYearApo";
            this.ChYearApo.Size = new System.Drawing.Size(20, 20);
            this.ChYearApo.TabIndex = 10;
            this.ChYearApo.Text = "merhaba";
            this.ChYearApo.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.ChYearApo.UncheckedState.BorderThickness = 2;
            this.ChYearApo.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.ChYearApo.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.ChYearApo.UseTransparentBackground = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label8.Location = new System.Drawing.Point(62, 42);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(121, 19);
            this.label8.TabIndex = 80;
            this.label8.Text = "Tüm Randevular";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label9.Location = new System.Drawing.Point(256, 74);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(158, 19);
            this.label9.TabIndex = 82;
            this.label9.Text = "Bu Hafta Randevuları";
            // 
            // ChMonthApo
            // 
            this.ChMonthApo.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            this.ChMonthApo.CheckedState.BorderThickness = 0;
            this.ChMonthApo.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            this.ChMonthApo.CheckedState.InnerColor = System.Drawing.Color.White;
            this.ChMonthApo.ForeColor = System.Drawing.Color.White;
            this.ChMonthApo.Location = new System.Drawing.Point(36, 74);
            this.ChMonthApo.Name = "ChMonthApo";
            this.ChMonthApo.Size = new System.Drawing.Size(20, 20);
            this.ChMonthApo.TabIndex = 8;
            this.ChMonthApo.Text = "merhaba";
            this.ChMonthApo.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.ChMonthApo.UncheckedState.BorderThickness = 2;
            this.ChMonthApo.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.ChMonthApo.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            // 
            // ChWeekApo
            // 
            this.ChWeekApo.BackColor = System.Drawing.Color.Transparent;
            this.ChWeekApo.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            this.ChWeekApo.CheckedState.BorderThickness = 0;
            this.ChWeekApo.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            this.ChWeekApo.CheckedState.InnerColor = System.Drawing.Color.White;
            this.ChWeekApo.ForeColor = System.Drawing.Color.White;
            this.ChWeekApo.Location = new System.Drawing.Point(230, 74);
            this.ChWeekApo.Name = "ChWeekApo";
            this.ChWeekApo.Size = new System.Drawing.Size(20, 20);
            this.ChWeekApo.TabIndex = 11;
            this.ChWeekApo.Text = "merhaba";
            this.ChWeekApo.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.ChWeekApo.UncheckedState.BorderThickness = 2;
            this.ChWeekApo.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.ChWeekApo.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.ChWeekApo.UseTransparentBackground = true;
            // 
            // BtnList
            // 
            this.BtnList.BackColor = System.Drawing.Color.Transparent;
            this.BtnList.BorderRadius = 10;
            this.BtnList.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnList.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnList.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnList.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnList.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnList.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(172)))), ((int)(((byte)(235)))));
            this.BtnList.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(235)))), ((int)(((byte)(222)))));
            this.BtnList.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnList.ForeColor = System.Drawing.Color.White;
            this.BtnList.Location = new System.Drawing.Point(32, 141);
            this.BtnList.Name = "BtnList";
            this.BtnList.Size = new System.Drawing.Size(166, 25);
            this.BtnList.TabIndex = 12;
            this.BtnList.Text = "Listele";
            this.BtnList.Click += new System.EventHandler(this.BtnList_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label6.Location = new System.Drawing.Point(62, 73);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(136, 19);
            this.label6.TabIndex = 75;
            this.label6.Text = "Bu Ay Randevuları";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label7.Location = new System.Drawing.Point(256, 42);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(139, 19);
            this.label7.TabIndex = 77;
            this.label7.Text = "Bu Yıl Ramdevuları";
            // 
            // ChAllApo
            // 
            this.ChAllApo.Checked = true;
            this.ChAllApo.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            this.ChAllApo.CheckedState.BorderThickness = 0;
            this.ChAllApo.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            this.ChAllApo.CheckedState.InnerColor = System.Drawing.Color.White;
            this.ChAllApo.ForeColor = System.Drawing.Color.White;
            this.ChAllApo.Location = new System.Drawing.Point(36, 42);
            this.ChAllApo.Name = "ChAllApo";
            this.ChAllApo.Size = new System.Drawing.Size(20, 20);
            this.ChAllApo.TabIndex = 7;
            this.ChAllApo.Text = "merhaba";
            this.ChAllApo.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.ChAllApo.UncheckedState.BorderThickness = 2;
            this.ChAllApo.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.ChAllApo.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            // 
            // ChTodayApo
            // 
            this.ChTodayApo.BackColor = System.Drawing.Color.Transparent;
            this.ChTodayApo.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            this.ChTodayApo.CheckedState.BorderThickness = 0;
            this.ChTodayApo.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            this.ChTodayApo.CheckedState.InnerColor = System.Drawing.Color.White;
            this.ChTodayApo.ForeColor = System.Drawing.Color.White;
            this.ChTodayApo.Location = new System.Drawing.Point(36, 106);
            this.ChTodayApo.Name = "ChTodayApo";
            this.ChTodayApo.Size = new System.Drawing.Size(20, 20);
            this.ChTodayApo.TabIndex = 9;
            this.ChTodayApo.Text = "merhaba";
            this.ChTodayApo.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.ChTodayApo.UncheckedState.BorderThickness = 2;
            this.ChTodayApo.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.ChTodayApo.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.ChTodayApo.UseTransparentBackground = true;
            // 
            // CmbPolyclinic
            // 
            this.CmbPolyclinic.BackColor = System.Drawing.Color.Transparent;
            this.CmbPolyclinic.BorderRadius = 10;
            this.CmbPolyclinic.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.CmbPolyclinic.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbPolyclinic.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CmbPolyclinic.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CmbPolyclinic.Font = new System.Drawing.Font("Lato", 12F);
            this.CmbPolyclinic.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.CmbPolyclinic.ItemHeight = 17;
            this.CmbPolyclinic.Items.AddRange(new object[] {
            "Erkek",
            "Kız"});
            this.CmbPolyclinic.Location = new System.Drawing.Point(131, 94);
            this.CmbPolyclinic.Name = "CmbPolyclinic";
            this.CmbPolyclinic.Size = new System.Drawing.Size(193, 23);
            this.CmbPolyclinic.TabIndex = 2;
            // 
            // BtnUpdateAppointment
            // 
            this.BtnUpdateAppointment.BackColor = System.Drawing.Color.Transparent;
            this.BtnUpdateAppointment.BorderRadius = 10;
            this.BtnUpdateAppointment.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnUpdateAppointment.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnUpdateAppointment.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnUpdateAppointment.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnUpdateAppointment.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnUpdateAppointment.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(172)))), ((int)(((byte)(235)))));
            this.BtnUpdateAppointment.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(235)))), ((int)(((byte)(222)))));
            this.BtnUpdateAppointment.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnUpdateAppointment.ForeColor = System.Drawing.Color.White;
            this.BtnUpdateAppointment.Location = new System.Drawing.Point(386, 112);
            this.BtnUpdateAppointment.Name = "BtnUpdateAppointment";
            this.BtnUpdateAppointment.Size = new System.Drawing.Size(166, 36);
            this.BtnUpdateAppointment.TabIndex = 6;
            this.BtnUpdateAppointment.Text = "Randevu Güncelle";
            this.BtnUpdateAppointment.Click += new System.EventHandler(this.BtnUpdateAppointment_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(243)))), ((int)(((byte)(250)))));
            this.label3.Location = new System.Drawing.Point(11, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 19);
            this.label3.TabIndex = 45;
            this.label3.Text = "Randevu Tarihi:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(243)))), ((int)(((byte)(250)))));
            this.label4.Location = new System.Drawing.Point(11, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 19);
            this.label4.TabIndex = 43;
            this.label4.Text = "Randevu Saati:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(243)))), ((int)(((byte)(250)))));
            this.label2.Location = new System.Drawing.Point(33, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 19);
            this.label2.TabIndex = 39;
            this.label2.Text = "Randevu ID:";
            // 
            // TxtApointId
            // 
            this.TxtApointId.BackColor = System.Drawing.Color.Transparent;
            this.TxtApointId.BorderRadius = 10;
            this.TxtApointId.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtApointId.DefaultText = "";
            this.TxtApointId.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TxtApointId.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TxtApointId.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtApointId.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtApointId.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtApointId.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtApointId.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtApointId.Location = new System.Drawing.Point(131, 27);
            this.TxtApointId.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TxtApointId.MaxLength = 16;
            this.TxtApointId.Name = "TxtApointId";
            this.TxtApointId.PlaceholderText = "";
            this.TxtApointId.ReadOnly = true;
            this.TxtApointId.SelectedText = "";
            this.TxtApointId.Size = new System.Drawing.Size(194, 22);
            this.TxtApointId.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(243)))), ((int)(((byte)(250)))));
            this.label1.Location = new System.Drawing.Point(61, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 19);
            this.label1.TabIndex = 37;
            this.label1.Text = "Doktor:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(243)))), ((int)(((byte)(250)))));
            this.label5.Location = new System.Drawing.Point(22, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 19);
            this.label5.TabIndex = 35;
            this.label5.Text = "Poliklinik No:";
            // 
            // BtnAddAppointment
            // 
            this.BtnAddAppointment.BackColor = System.Drawing.Color.Transparent;
            this.BtnAddAppointment.BorderRadius = 10;
            this.BtnAddAppointment.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnAddAppointment.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnAddAppointment.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnAddAppointment.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnAddAppointment.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnAddAppointment.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(172)))), ((int)(((byte)(235)))));
            this.BtnAddAppointment.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(235)))), ((int)(((byte)(222)))));
            this.BtnAddAppointment.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAddAppointment.ForeColor = System.Drawing.Color.White;
            this.BtnAddAppointment.Location = new System.Drawing.Point(386, 69);
            this.BtnAddAppointment.Name = "BtnAddAppointment";
            this.BtnAddAppointment.Size = new System.Drawing.Size(166, 36);
            this.BtnAddAppointment.TabIndex = 5;
            this.BtnAddAppointment.Text = "Randevu Ekle";
            this.BtnAddAppointment.Click += new System.EventHandler(this.BtnAddAppointment_Click);
            // 
            // FrmAppointmentOperation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(18)))), ((int)(((byte)(61)))));
            this.ClientSize = new System.Drawing.Size(1133, 519);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.BtnExit);
            this.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmAppointmentOperation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmAppointmentOperation";
            this.Load += new System.EventHandler(this.FrmAppointmentOperation_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridAppointment)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2CircleButton BtnExit;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView gridAppointment;
        private Guna.UI2.WinForms.Guna2ComboBox CmbPolyclinic;
        private Guna.UI2.WinForms.Guna2GradientButton BtnUpdateAppointment;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox TxtApointId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2GradientButton BtnAddAppointment;
        private System.Windows.Forms.GroupBox groupBox1;
        private Guna.UI2.WinForms.Guna2GradientButton BtnList;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2CustomRadioButton ChAllApo;
        private Guna.UI2.WinForms.Guna2CustomRadioButton ChTodayApo;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtApointHours;
        private Guna.UI2.WinForms.Guna2DateTimePicker DtApointDate;
        private Guna.UI2.WinForms.Guna2ComboBox CmbSicilNo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private Guna.UI2.WinForms.Guna2CustomRadioButton ChMonthApo;
        private Guna.UI2.WinForms.Guna2CustomRadioButton ChWeekApo;
        private System.Windows.Forms.Label label10;
        private Guna.UI2.WinForms.Guna2CustomRadioButton ChYearApo;
    }
}