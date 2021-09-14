namespace ELMOS7AF.UserControls
{
    partial class Valut
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtnotes = new System.Windows.Forms.TextBox();
            this.btnexecute = new System.Windows.Forms.Button();
            this.radiooutcome = new System.Windows.Forms.RadioButton();
            this.radioincome = new System.Windows.Forms.RadioButton();
            this.txtAdmin = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblremains = new System.Windows.Forms.Label();
            this.lblmoney = new System.Windows.Forms.Label();
            this.lbltottal = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtAmount = new Guna.UI2.WinForms.Guna2TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtremains = new Guna.UI2.WinForms.Guna2TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtmoney = new Guna.UI2.WinForms.Guna2TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.txtsearch = new System.Windows.Forms.TextBox();
            this.paymentsGride = new System.Windows.Forms.DataGridView();
            this.radioAll = new System.Windows.Forms.RadioButton();
            this.radioWithdraw = new System.Windows.Forms.RadioButton();
            this.radioDeposite = new System.Windows.Forms.RadioButton();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.ispaid = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.paymentsGride)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.txtnotes);
            this.groupBox1.Controls.Add(this.btnexecute);
            this.groupBox1.Controls.Add(this.radiooutcome);
            this.groupBox1.Controls.Add(this.radioincome);
            this.groupBox1.Controls.Add(this.txtAdmin);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lblremains);
            this.groupBox1.Controls.Add(this.lblmoney);
            this.groupBox1.Controls.Add(this.lbltottal);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtAmount);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.txtremains);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtmoney);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupBox1.Location = new System.Drawing.Point(1066, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(653, 1010);
            this.groupBox1.TabIndex = 31;
            this.groupBox1.TabStop = false;
            // 
            // txtnotes
            // 
            this.txtnotes.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtnotes.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnotes.Location = new System.Drawing.Point(44, 496);
            this.txtnotes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtnotes.Name = "txtnotes";
            this.txtnotes.Size = new System.Drawing.Size(453, 34);
            this.txtnotes.TabIndex = 86;
            this.txtnotes.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnexecute
            // 
            this.btnexecute.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(50)))), ((int)(((byte)(100)))));
            this.btnexecute.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnexecute.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexecute.ForeColor = System.Drawing.Color.White;
            this.btnexecute.Location = new System.Drawing.Point(199, 654);
            this.btnexecute.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnexecute.Name = "btnexecute";
            this.btnexecute.Size = new System.Drawing.Size(197, 53);
            this.btnexecute.TabIndex = 85;
            this.btnexecute.Text = "تنفيذ العمليه";
            this.btnexecute.UseVisualStyleBackColor = false;
            this.btnexecute.Click += new System.EventHandler(this.btnexecute_Click);
            // 
            // radiooutcome
            // 
            this.radiooutcome.AutoSize = true;
            this.radiooutcome.Checked = true;
            this.radiooutcome.Font = new System.Drawing.Font("Century", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radiooutcome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(50)))), ((int)(((byte)(100)))));
            this.radiooutcome.Location = new System.Drawing.Point(165, 601);
            this.radiooutcome.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radiooutcome.Name = "radiooutcome";
            this.radiooutcome.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.radiooutcome.Size = new System.Drawing.Size(77, 32);
            this.radiooutcome.TabIndex = 84;
            this.radiooutcome.TabStop = true;
            this.radiooutcome.Text = "سحب";
            this.radiooutcome.UseVisualStyleBackColor = true;
            this.radiooutcome.CheckedChanged += new System.EventHandler(this.radiooutcome_CheckedChanged);
            // 
            // radioincome
            // 
            this.radioincome.AutoSize = true;
            this.radioincome.Font = new System.Drawing.Font("Century", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioincome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(50)))), ((int)(((byte)(100)))));
            this.radioincome.Location = new System.Drawing.Point(376, 601);
            this.radioincome.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioincome.Name = "radioincome";
            this.radioincome.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.radioincome.Size = new System.Drawing.Size(72, 32);
            this.radioincome.TabIndex = 84;
            this.radioincome.Text = "ايداع";
            this.radioincome.UseVisualStyleBackColor = true;
            this.radioincome.CheckedChanged += new System.EventHandler(this.radioincome_CheckedChanged);
            // 
            // txtAdmin
            // 
            this.txtAdmin.AutoSize = true;
            this.txtAdmin.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAdmin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(50)))), ((int)(((byte)(100)))));
            this.txtAdmin.Location = new System.Drawing.Point(236, 71);
            this.txtAdmin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtAdmin.Name = "txtAdmin";
            this.txtAdmin.Size = new System.Drawing.Size(69, 26);
            this.txtAdmin.TabIndex = 83;
            this.txtAdmin.Text = "المقدمه";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(561, 71);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 26);
            this.label2.TabIndex = 83;
            this.label2.Text = "المسؤل";
            // 
            // lblremains
            // 
            this.lblremains.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblremains.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(40)))), ((int)(((byte)(100)))));
            this.lblremains.Location = new System.Drawing.Point(36, 446);
            this.lblremains.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblremains.Name = "lblremains";
            this.lblremains.Size = new System.Drawing.Size(444, 21);
            this.lblremains.TabIndex = 82;
            // 
            // lblmoney
            // 
            this.lblmoney.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmoney.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(40)))), ((int)(((byte)(100)))));
            this.lblmoney.Location = new System.Drawing.Point(36, 348);
            this.lblmoney.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblmoney.Name = "lblmoney";
            this.lblmoney.Size = new System.Drawing.Size(444, 21);
            this.lblmoney.TabIndex = 82;
            // 
            // lbltottal
            // 
            this.lbltottal.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltottal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(40)))), ((int)(((byte)(100)))));
            this.lbltottal.Location = new System.Drawing.Point(40, 235);
            this.lbltottal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbltottal.Name = "lbltottal";
            this.lbltottal.Size = new System.Drawing.Size(440, 21);
            this.lbltottal.TabIndex = 82;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(553, 502);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 26);
            this.label6.TabIndex = 81;
            this.label6.Text = "ملحوظات";
            // 
            // txtAmount
            // 
            this.txtAmount.BackColor = System.Drawing.Color.Gray;
            this.txtAmount.BorderColor = System.Drawing.Color.Black;
            this.txtAmount.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAmount.DefaultText = "";
            this.txtAmount.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtAmount.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtAmount.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAmount.DisabledState.Parent = this.txtAmount;
            this.txtAmount.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAmount.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtAmount.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAmount.FocusedState.Parent = this.txtAmount;
            this.txtAmount.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAmount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(45)))), ((int)(((byte)(104)))));
            this.txtAmount.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAmount.HoverState.Parent = this.txtAmount;
            this.txtAmount.Location = new System.Drawing.Point(40, 183);
            this.txtAmount.Margin = new System.Windows.Forms.Padding(15);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.PasswordChar = '\0';
            this.txtAmount.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtAmount.PlaceholderText = "";
            this.txtAmount.ReadOnly = true;
            this.txtAmount.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtAmount.SelectedText = "";
            this.txtAmount.ShadowDecoration.Parent = this.txtAmount;
            this.txtAmount.Size = new System.Drawing.Size(453, 46);
            this.txtAmount.TabIndex = 80;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(571, 192);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(60, 26);
            this.label11.TabIndex = 81;
            this.label11.Text = "المتاح";
            // 
            // txtremains
            // 
            this.txtremains.BackColor = System.Drawing.Color.Gray;
            this.txtremains.BorderColor = System.Drawing.Color.Black;
            this.txtremains.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtremains.DefaultText = "";
            this.txtremains.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtremains.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtremains.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtremains.DisabledState.Parent = this.txtremains;
            this.txtremains.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtremains.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtremains.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtremains.FocusedState.Parent = this.txtremains;
            this.txtremains.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtremains.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(45)))), ((int)(((byte)(104)))));
            this.txtremains.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtremains.HoverState.Parent = this.txtremains;
            this.txtremains.Location = new System.Drawing.Point(40, 384);
            this.txtremains.Margin = new System.Windows.Forms.Padding(15);
            this.txtremains.Name = "txtremains";
            this.txtremains.PasswordChar = '\0';
            this.txtremains.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtremains.PlaceholderText = "";
            this.txtremains.ReadOnly = true;
            this.txtremains.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtremains.SelectedText = "";
            this.txtremains.ShadowDecoration.Parent = this.txtremains;
            this.txtremains.Size = new System.Drawing.Size(453, 46);
            this.txtremains.TabIndex = 78;
            this.txtremains.TextChanged += new System.EventHandler(this.txttottalmoney_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(557, 395);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 26);
            this.label4.TabIndex = 79;
            this.label4.Text = "المتبقي";
            this.label4.Click += new System.EventHandler(this.label10_Click);
            // 
            // txtmoney
            // 
            this.txtmoney.BorderColor = System.Drawing.Color.Black;
            this.txtmoney.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtmoney.DefaultText = "";
            this.txtmoney.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtmoney.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtmoney.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtmoney.DisabledState.Parent = this.txtmoney;
            this.txtmoney.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtmoney.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtmoney.FocusedState.Parent = this.txtmoney;
            this.txtmoney.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmoney.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(45)))), ((int)(((byte)(104)))));
            this.txtmoney.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtmoney.HoverState.Parent = this.txtmoney;
            this.txtmoney.Location = new System.Drawing.Point(40, 287);
            this.txtmoney.Margin = new System.Windows.Forms.Padding(15);
            this.txtmoney.MaxLength = 6;
            this.txtmoney.Name = "txtmoney";
            this.txtmoney.PasswordChar = '\0';
            this.txtmoney.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtmoney.PlaceholderText = "";
            this.txtmoney.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtmoney.SelectedText = "";
            this.txtmoney.ShadowDecoration.Parent = this.txtmoney;
            this.txtmoney.Size = new System.Drawing.Size(453, 46);
            this.txtmoney.TabIndex = 78;
            this.txtmoney.TextChanged += new System.EventHandler(this.txtmoney_TextChanged);
            this.txtmoney.Click += new System.EventHandler(this.txtmoney_Click);
            this.txtmoney.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtmoney_KeyPress);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(571, 299);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(57, 26);
            this.label10.TabIndex = 79;
            this.label10.Text = "المبلغ";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.ispaid);
            this.panel2.Controls.Add(this.dateTimePicker2);
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Controls.Add(this.radioDeposite);
            this.panel2.Controls.Add(this.paymentsGride);
            this.panel2.Controls.Add(this.radioWithdraw);
            this.panel2.Controls.Add(this.txtsearch);
            this.panel2.Controls.Add(this.radioAll);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(7, 6);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1719, 1010);
            this.panel2.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(40)))), ((int)(((byte)(100)))));
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.panel1.Size = new System.Drawing.Size(1733, 1022);
            this.panel1.TabIndex = 3;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // txtsearch
            // 
            this.txtsearch.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(101)))), ((int)(((byte)(172)))));
            this.txtsearch.Location = new System.Drawing.Point(567, 26);
            this.txtsearch.Margin = new System.Windows.Forms.Padding(4);
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtsearch.Size = new System.Drawing.Size(422, 39);
            this.txtsearch.TabIndex = 35;
            this.txtsearch.Text = "ابحث هنا";
            this.txtsearch.TextChanged += new System.EventHandler(this.txtsearch_TextChanged);
            this.txtsearch.Enter += new System.EventHandler(this.txtsearch_Enter);
            // 
            // paymentsGride
            // 
            this.paymentsGride.AllowUserToAddRows = false;
            this.paymentsGride.AllowUserToDeleteRows = false;
            this.paymentsGride.AllowUserToResizeColumns = false;
            this.paymentsGride.AllowUserToResizeRows = false;
            this.paymentsGride.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.paymentsGride.BackgroundColor = System.Drawing.Color.White;
            this.paymentsGride.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.paymentsGride.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.paymentsGride.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.paymentsGride.Location = new System.Drawing.Point(-8, 93);
            this.paymentsGride.Margin = new System.Windows.Forms.Padding(4);
            this.paymentsGride.MultiSelect = false;
            this.paymentsGride.Name = "paymentsGride";
            this.paymentsGride.ReadOnly = true;
            this.paymentsGride.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.paymentsGride.Size = new System.Drawing.Size(1066, 913);
            this.paymentsGride.TabIndex = 21;
            this.paymentsGride.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.paymentsGride_CellDoubleClick);
            // 
            // radioAll
            // 
            this.radioAll.AutoSize = true;
            this.radioAll.BackColor = System.Drawing.Color.Transparent;
            this.radioAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioAll.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioAll.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(50)))), ((int)(((byte)(100)))));
            this.radioAll.Location = new System.Drawing.Point(3, 33);
            this.radioAll.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioAll.Name = "radioAll";
            this.radioAll.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.radioAll.Size = new System.Drawing.Size(95, 27);
            this.radioAll.TabIndex = 96;
            this.radioAll.TabStop = true;
            this.radioAll.Text = "عرض الكل";
            this.radioAll.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.radioAll.UseVisualStyleBackColor = false;
            this.radioAll.CheckedChanged += new System.EventHandler(this.radioAll_CheckedChanged);
            // 
            // radioWithdraw
            // 
            this.radioWithdraw.AutoSize = true;
            this.radioWithdraw.BackColor = System.Drawing.Color.Transparent;
            this.radioWithdraw.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioWithdraw.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioWithdraw.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(50)))), ((int)(((byte)(100)))));
            this.radioWithdraw.Location = new System.Drawing.Point(154, 33);
            this.radioWithdraw.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioWithdraw.Name = "radioWithdraw";
            this.radioWithdraw.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.radioWithdraw.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.radioWithdraw.Size = new System.Drawing.Size(72, 27);
            this.radioWithdraw.TabIndex = 97;
            this.radioWithdraw.TabStop = true;
            this.radioWithdraw.Text = "ايداع";
            this.radioWithdraw.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.radioWithdraw.UseVisualStyleBackColor = false;
            this.radioWithdraw.CheckedChanged += new System.EventHandler(this.radioWithdraw_CheckedChanged);
            // 
            // radioDeposite
            // 
            this.radioDeposite.AutoSize = true;
            this.radioDeposite.BackColor = System.Drawing.Color.Transparent;
            this.radioDeposite.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioDeposite.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioDeposite.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(50)))), ((int)(((byte)(100)))));
            this.radioDeposite.Location = new System.Drawing.Point(278, 33);
            this.radioDeposite.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioDeposite.Name = "radioDeposite";
            this.radioDeposite.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.radioDeposite.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.radioDeposite.Size = new System.Drawing.Size(75, 27);
            this.radioDeposite.TabIndex = 98;
            this.radioDeposite.TabStop = true;
            this.radioDeposite.Text = "سحب";
            this.radioDeposite.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.radioDeposite.UseVisualStyleBackColor = false;
            this.radioDeposite.CheckedChanged += new System.EventHandler(this.radioDeposite_CheckedChanged);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(40)))), ((int)(((byte)(100)))));
            this.dateTimePicker2.CalendarTitleBackColor = System.Drawing.Color.Aquamarine;
            this.dateTimePicker2.CustomFormat = "";
            this.dateTimePicker2.Font = new System.Drawing.Font("Century", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.Location = new System.Drawing.Point(393, 31);
            this.dateTimePicker2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(167, 29);
            this.dateTimePicker2.TabIndex = 96;
            this.dateTimePicker2.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            this.dateTimePicker2.Enter += new System.EventHandler(this.dateTimePicker2_Enter);
            // 
            // ispaid
            // 
            this.ispaid.Animated = true;
            this.ispaid.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(45)))), ((int)(((byte)(104)))));
            this.ispaid.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(45)))), ((int)(((byte)(104)))));
            this.ispaid.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.ispaid.CheckedState.InnerColor = System.Drawing.Color.White;
            this.ispaid.CheckedState.Parent = this.ispaid;
            this.ispaid.Cursor = System.Windows.Forms.Cursors.Default;
            this.ispaid.Location = new System.Drawing.Point(997, 40);
            this.ispaid.Margin = new System.Windows.Forms.Padding(4);
            this.ispaid.Name = "ispaid";
            this.ispaid.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ispaid.ShadowDecoration.Parent = this.ispaid;
            this.ispaid.Size = new System.Drawing.Size(49, 25);
            this.ispaid.TabIndex = 99;
            this.ispaid.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.ispaid.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.ispaid.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.ispaid.UncheckedState.InnerColor = System.Drawing.Color.White;
            this.ispaid.UncheckedState.Parent = this.ispaid;
            this.ispaid.CheckedChanged += new System.EventHandler(this.ispaid_CheckedChanged);
            // 
            // Valut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Valut";
            this.Size = new System.Drawing.Size(1733, 1022);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.paymentsGride)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2TextBox txtmoney;
        private System.Windows.Forms.Label label10;
        private Guna.UI2.WinForms.Guna2TextBox txtAmount;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lbltottal;
        private System.Windows.Forms.TextBox txtnotes;
        private System.Windows.Forms.Button btnexecute;
        private System.Windows.Forms.RadioButton radiooutcome;
        private System.Windows.Forms.RadioButton radioincome;
        private System.Windows.Forms.Label txtAdmin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblremains;
        private System.Windows.Forms.Label lblmoney;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2TextBox txtremains;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.RadioButton radioDeposite;
        private System.Windows.Forms.DataGridView paymentsGride;
        private System.Windows.Forms.RadioButton radioWithdraw;
        private System.Windows.Forms.TextBox txtsearch;
        private System.Windows.Forms.RadioButton radioAll;
        private Guna.UI2.WinForms.Guna2ToggleSwitch ispaid;
    }
}
