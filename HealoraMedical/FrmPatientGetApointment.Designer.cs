namespace HealoraMedical
{
    partial class FrmPatientGetApointment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPatientGetApointment));
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.pHeader = new Guna.UI2.WinForms.Guna2Panel();
            this.BtnExit = new Guna.UI2.WinForms.Guna2CircleButton();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.gridAppotiment = new System.Windows.Forms.DataGridView();
            this.BtnGetApointment = new Guna.UI2.WinForms.Guna2GradientButton();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtSymptom = new Guna.UI2.WinForms.Guna2TextBox();
            this.CmbDr = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.DtEnd = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnFilitrele = new Guna.UI2.WinForms.Guna2GradientButton();
            this.DtStart = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.pHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridAppotiment)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.pHeader);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(960, 534);
            this.splitContainer1.SplitterDistance = 27;
            this.splitContainer1.TabIndex = 0;
            // 
            // pHeader
            // 
            this.pHeader.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pHeader.Controls.Add(this.BtnExit);
            this.pHeader.Location = new System.Drawing.Point(0, 0);
            this.pHeader.Name = "pHeader";
            this.pHeader.Size = new System.Drawing.Size(960, 28);
            this.pHeader.TabIndex = 0;
            this.pHeader.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pHeader_MouseDown_1);
            this.pHeader.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pHeader_MouseUp_1);
            // 
            // BtnExit
            // 
            this.BtnExit.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.BtnExit.Animated = true;
            this.BtnExit.BackColor = System.Drawing.Color.Transparent;
            this.BtnExit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnExit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnExit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnExit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnExit.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(57)))), ((int)(((byte)(65)))));
            this.BtnExit.Font = new System.Drawing.Font("Lato", 8.25F);
            this.BtnExit.ForeColor = System.Drawing.Color.White;
            this.BtnExit.Location = new System.Drawing.Point(927, 3);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.BtnExit.Size = new System.Drawing.Size(28, 21);
            this.BtnExit.TabIndex = 24;
            this.BtnExit.Text = "X";
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.gridAppotiment);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.BtnGetApointment);
            this.splitContainer2.Panel2.Controls.Add(this.label1);
            this.splitContainer2.Panel2.Controls.Add(this.TxtSymptom);
            this.splitContainer2.Panel2.Controls.Add(this.CmbDr);
            this.splitContainer2.Panel2.Controls.Add(this.label12);
            this.splitContainer2.Panel2.Controls.Add(this.label6);
            this.splitContainer2.Panel2.Controls.Add(this.DtEnd);
            this.splitContainer2.Panel2.Controls.Add(this.label3);
            this.splitContainer2.Panel2.Controls.Add(this.BtnFilitrele);
            this.splitContainer2.Panel2.Controls.Add(this.DtStart);
            this.splitContainer2.Size = new System.Drawing.Size(960, 503);
            this.splitContainer2.SplitterDistance = 295;
            this.splitContainer2.TabIndex = 0;
            // 
            // gridAppotiment
            // 
            this.gridAppotiment.AllowUserToAddRows = false;
            this.gridAppotiment.AllowUserToDeleteRows = false;
            this.gridAppotiment.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridAppotiment.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridAppotiment.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(80)))), ((int)(((byte)(107)))));
            this.gridAppotiment.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.gridAppotiment.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(48)))), ((int)(((byte)(77)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(3);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(80)))), ((int)(((byte)(130)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridAppotiment.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gridAppotiment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(91)))), ((int)(((byte)(150)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(91)))), ((int)(((byte)(180)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridAppotiment.DefaultCellStyle = dataGridViewCellStyle2;
            this.gridAppotiment.EnableHeadersVisualStyles = false;
            this.gridAppotiment.Location = new System.Drawing.Point(0, 0);
            this.gridAppotiment.Name = "gridAppotiment";
            this.gridAppotiment.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(80)))), ((int)(((byte)(107)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(80)))), ((int)(((byte)(130)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridAppotiment.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.gridAppotiment.RowHeadersVisible = false;
            this.gridAppotiment.Size = new System.Drawing.Size(960, 295);
            this.gridAppotiment.TabIndex = 1;
            this.gridAppotiment.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridAppotiment_CellClick);
            // 
            // BtnGetApointment
            // 
            this.BtnGetApointment.BackColor = System.Drawing.Color.Transparent;
            this.BtnGetApointment.BorderRadius = 10;
            this.BtnGetApointment.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnGetApointment.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnGetApointment.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnGetApointment.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnGetApointment.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnGetApointment.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(172)))), ((int)(((byte)(235)))));
            this.BtnGetApointment.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(235)))), ((int)(((byte)(222)))));
            this.BtnGetApointment.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGetApointment.ForeColor = System.Drawing.Color.White;
            this.BtnGetApointment.Location = new System.Drawing.Point(416, 157);
            this.BtnGetApointment.Name = "BtnGetApointment";
            this.BtnGetApointment.Size = new System.Drawing.Size(169, 29);
            this.BtnGetApointment.TabIndex = 5;
            this.BtnGetApointment.Text = "Randevu Al";
            this.BtnGetApointment.Click += new System.EventHandler(this.BtnGetApointment_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Lato Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(243)))), ((int)(((byte)(250)))));
            this.label1.Location = new System.Drawing.Point(337, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 19);
            this.label1.TabIndex = 93;
            this.label1.Text = "Şikayet:";
            // 
            // TxtSymptom
            // 
            this.TxtSymptom.BackColor = System.Drawing.Color.Transparent;
            this.TxtSymptom.BorderRadius = 10;
            this.TxtSymptom.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtSymptom.DefaultText = "";
            this.TxtSymptom.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TxtSymptom.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TxtSymptom.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtSymptom.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtSymptom.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtSymptom.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtSymptom.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtSymptom.Location = new System.Drawing.Point(416, 21);
            this.TxtSymptom.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TxtSymptom.MaxLength = 200;
            this.TxtSymptom.Multiline = true;
            this.TxtSymptom.Name = "TxtSymptom";
            this.TxtSymptom.PlaceholderText = "";
            this.TxtSymptom.SelectedText = "";
            this.TxtSymptom.Size = new System.Drawing.Size(507, 129);
            this.TxtSymptom.TabIndex = 4;
            // 
            // CmbDr
            // 
            this.CmbDr.BackColor = System.Drawing.Color.Transparent;
            this.CmbDr.BorderRadius = 10;
            this.CmbDr.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.CmbDr.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbDr.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CmbDr.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CmbDr.Font = new System.Drawing.Font("Lato", 12F);
            this.CmbDr.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.CmbDr.ItemHeight = 17;
            this.CmbDr.Items.AddRange(new object[] {
            "Erkek",
            "Kız"});
            this.CmbDr.Location = new System.Drawing.Point(114, 25);
            this.CmbDr.Name = "CmbDr";
            this.CmbDr.Size = new System.Drawing.Size(187, 23);
            this.CmbDr.TabIndex = 0;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Lato Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(243)))), ((int)(((byte)(250)))));
            this.label12.Location = new System.Drawing.Point(38, 25);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(70, 19);
            this.label12.TabIndex = 90;
            this.label12.Text = "Doktor:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Lato Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(37, 116);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 19);
            this.label6.TabIndex = 87;
            this.label6.Text = "Tarih 2:";
            // 
            // DtEnd
            // 
            this.DtEnd.BorderRadius = 10;
            this.DtEnd.Checked = true;
            this.DtEnd.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(91)))), ((int)(((byte)(150)))));
            this.DtEnd.Font = new System.Drawing.Font("Lato", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtEnd.ForeColor = System.Drawing.Color.White;
            this.DtEnd.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.DtEnd.Location = new System.Drawing.Point(114, 108);
            this.DtEnd.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.DtEnd.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.DtEnd.Name = "DtEnd";
            this.DtEnd.Size = new System.Drawing.Size(187, 31);
            this.DtEnd.TabIndex = 2;
            this.DtEnd.Value = new System.DateTime(2025, 6, 20, 11, 0, 7, 339);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lato Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(37, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 19);
            this.label3.TabIndex = 85;
            this.label3.Text = "Tarih 1:";
            // 
            // BtnFilitrele
            // 
            this.BtnFilitrele.BackColor = System.Drawing.Color.Transparent;
            this.BtnFilitrele.BorderRadius = 10;
            this.BtnFilitrele.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnFilitrele.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnFilitrele.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnFilitrele.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnFilitrele.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnFilitrele.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(172)))), ((int)(((byte)(235)))));
            this.BtnFilitrele.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(235)))), ((int)(((byte)(222)))));
            this.BtnFilitrele.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnFilitrele.ForeColor = System.Drawing.Color.White;
            this.BtnFilitrele.Location = new System.Drawing.Point(181, 157);
            this.BtnFilitrele.Name = "BtnFilitrele";
            this.BtnFilitrele.Size = new System.Drawing.Size(120, 29);
            this.BtnFilitrele.TabIndex = 3;
            this.BtnFilitrele.Text = "Filitrele";
            this.BtnFilitrele.Click += new System.EventHandler(this.BtnFilitrele_Click);
            // 
            // DtStart
            // 
            this.DtStart.BorderRadius = 10;
            this.DtStart.Checked = true;
            this.DtStart.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(91)))), ((int)(((byte)(150)))));
            this.DtStart.Font = new System.Drawing.Font("Lato", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtStart.ForeColor = System.Drawing.Color.White;
            this.DtStart.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.DtStart.Location = new System.Drawing.Point(114, 64);
            this.DtStart.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.DtStart.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.DtStart.Name = "DtStart";
            this.DtStart.Size = new System.Drawing.Size(187, 31);
            this.DtStart.TabIndex = 1;
            this.DtStart.Value = new System.DateTime(2025, 6, 20, 12, 24, 44, 50);
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // FrmPatientGetApointment
            // 
            this.AcceptButton = this.BtnGetApointment;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(18)))), ((int)(((byte)(61)))));
            this.ClientSize = new System.Drawing.Size(960, 534);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmPatientGetApointment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Randevu";
            this.Load += new System.EventHandler(this.FrmPatientGetApointment_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.pHeader.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridAppotiment)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private Guna.UI2.WinForms.Guna2CircleButton BtnExit;
        private System.Windows.Forms.DataGridView gridAppotiment;
        private Guna.UI2.WinForms.Guna2Panel pHeader;
        private System.Windows.Forms.Timer timer1;
        private Guna.UI2.WinForms.Guna2ComboBox CmbDr;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2DateTimePicker DtEnd;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2GradientButton BtnFilitrele;
        private Guna.UI2.WinForms.Guna2DateTimePicker DtStart;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox TxtSymptom;
        private Guna.UI2.WinForms.Guna2GradientButton BtnGetApointment;
    }
}