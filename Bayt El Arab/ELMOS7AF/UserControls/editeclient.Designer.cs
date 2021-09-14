namespace ELMOS7AF.UserControls
{
    partial class editeclient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(editeclient));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel4 = new System.Windows.Forms.Panel();
            this.label14 = new System.Windows.Forms.Label();
            this.ispaid = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.idsearch = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtsearch = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.txtpaid = new Guna.UI2.WinForms.Guna2TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txttottal = new Guna.UI2.WinForms.Guna2TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblpay = new System.Windows.Forms.Label();
            this.lblpaid = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.clientGride = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.txtphonenumber = new Guna.UI2.WinForms.Guna2TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtaddress = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtname = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtid = new Guna.UI2.WinForms.Guna2TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtNotes = new System.Windows.Forms.TextBox();
            this.txtdate = new Guna.UI.WinForms.GunaDateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.printpassport = new System.Windows.Forms.PictureBox();
            this.printssd = new System.Windows.Forms.PictureBox();
            this.printpersonal = new System.Windows.Forms.PictureBox();
            this.txtremains = new Guna.UI2.WinForms.Guna2TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.txtmoney = new Guna.UI2.WinForms.Guna2TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.lblremains = new System.Windows.Forms.Label();
            this.imgPersonalImage = new System.Windows.Forms.PictureBox();
            this.imgSSD = new System.Windows.Forms.PictureBox();
            this.imgPassport = new System.Windows.Forms.PictureBox();
            this.txtssd = new Guna.UI2.WinForms.Guna2TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clientGride)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.printpassport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.printssd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.printpersonal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgPersonalImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgSSD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgPassport)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label14);
            this.panel4.Controls.Add(this.ispaid);
            this.panel4.Controls.Add(this.idsearch);
            this.panel4.Controls.Add(this.pictureBox1);
            this.panel4.Controls.Add(this.txtsearch);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel4.Location = new System.Drawing.Point(20, 6);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1011, 65);
            this.panel4.TabIndex = 2;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(40)))), ((int)(((byte)(100)))));
            this.label14.Location = new System.Drawing.Point(42, 10);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(100, 19);
            this.label14.TabIndex = 74;
            this.label14.Text = "Id searching";
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
            this.ispaid.Location = new System.Drawing.Point(198, 37);
            this.ispaid.Margin = new System.Windows.Forms.Padding(4);
            this.ispaid.Name = "ispaid";
            this.ispaid.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ispaid.ShadowDecoration.Parent = this.ispaid;
            this.ispaid.Size = new System.Drawing.Size(49, 25);
            this.ispaid.TabIndex = 39;
            this.ispaid.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.ispaid.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.ispaid.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.ispaid.UncheckedState.InnerColor = System.Drawing.Color.White;
            this.ispaid.UncheckedState.Parent = this.ispaid;
            this.ispaid.CheckedChanged += new System.EventHandler(this.guna2ToggleSwitch2_CheckedChanged);
            // 
            // idsearch
            // 
            this.idsearch.Animated = true;
            this.idsearch.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(45)))), ((int)(((byte)(104)))));
            this.idsearch.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(45)))), ((int)(((byte)(104)))));
            this.idsearch.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.idsearch.CheckedState.InnerColor = System.Drawing.Color.White;
            this.idsearch.CheckedState.Parent = this.idsearch;
            this.idsearch.Cursor = System.Windows.Forms.Cursors.Default;
            this.idsearch.Location = new System.Drawing.Point(198, 4);
            this.idsearch.Margin = new System.Windows.Forms.Padding(4);
            this.idsearch.Name = "idsearch";
            this.idsearch.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.idsearch.ShadowDecoration.Parent = this.idsearch;
            this.idsearch.Size = new System.Drawing.Size(49, 25);
            this.idsearch.TabIndex = 39;
            this.idsearch.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.idsearch.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.idsearch.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.idsearch.UncheckedState.InnerColor = System.Drawing.Color.White;
            this.idsearch.UncheckedState.Parent = this.idsearch;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(296, 18);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(43, 35);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 38;
            this.pictureBox1.TabStop = false;
            // 
            // txtsearch
            // 
            this.txtsearch.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(101)))), ((int)(((byte)(172)))));
            this.txtsearch.Location = new System.Drawing.Point(293, 16);
            this.txtsearch.Margin = new System.Windows.Forms.Padding(4);
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtsearch.Size = new System.Drawing.Size(718, 39);
            this.txtsearch.TabIndex = 37;
            this.txtsearch.Text = "ابحث هنا";
            this.txtsearch.TextChanged += new System.EventHandler(this.txtsearch_TextChanged);
            this.txtsearch.Enter += new System.EventHandler(this.txtsearch_Enter);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.button1);
            this.panel3.Controls.Add(this.button2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 934);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(702, 76);
            this.panel3.TabIndex = 85;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(40)))), ((int)(((byte)(100)))));
            this.button1.Dock = System.Windows.Forms.DockStyle.Left;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(348, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(345, 76);
            this.button1.TabIndex = 87;
            this.button1.Text = "تعديل";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(40)))), ((int)(((byte)(100)))));
            this.button2.Dock = System.Windows.Forms.DockStyle.Left;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(0, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(348, 76);
            this.button2.TabIndex = 86;
            this.button2.Text = "مسح البيانات";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(580, 872);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(89, 26);
            this.label13.TabIndex = 83;
            this.label13.Text = "ملاحظات ";
            // 
            // txtpaid
            // 
            this.txtpaid.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(45)))), ((int)(((byte)(104)))));
            this.txtpaid.BorderRadius = 4;
            this.txtpaid.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtpaid.DefaultText = "";
            this.txtpaid.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtpaid.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtpaid.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtpaid.DisabledState.Parent = this.txtpaid;
            this.txtpaid.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtpaid.Enabled = false;
            this.txtpaid.FillColor = System.Drawing.Color.Silver;
            this.txtpaid.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtpaid.FocusedState.Parent = this.txtpaid;
            this.txtpaid.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpaid.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(45)))), ((int)(((byte)(104)))));
            this.txtpaid.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtpaid.HoverState.Parent = this.txtpaid;
            this.txtpaid.Location = new System.Drawing.Point(348, 591);
            this.txtpaid.Margin = new System.Windows.Forms.Padding(15);
            this.txtpaid.Name = "txtpaid";
            this.txtpaid.PasswordChar = '\0';
            this.txtpaid.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtpaid.PlaceholderText = "";
            this.txtpaid.ReadOnly = true;
            this.txtpaid.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtpaid.SelectedText = "";
            this.txtpaid.ShadowDecoration.Parent = this.txtpaid;
            this.txtpaid.Size = new System.Drawing.Size(147, 46);
            this.txtpaid.TabIndex = 80;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(604, 606);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(72, 26);
            this.label12.TabIndex = 81;
            this.label12.Text = "المدفوع";
            // 
            // txttottal
            // 
            this.txttottal.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(45)))), ((int)(((byte)(104)))));
            this.txttottal.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txttottal.DefaultText = "";
            this.txttottal.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txttottal.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txttottal.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txttottal.DisabledState.Parent = this.txttottal;
            this.txttottal.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txttottal.Enabled = false;
            this.txttottal.FillColor = System.Drawing.Color.Silver;
            this.txttottal.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txttottal.FocusedState.Parent = this.txttottal;
            this.txttottal.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttottal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(45)))), ((int)(((byte)(104)))));
            this.txttottal.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txttottal.HoverState.Parent = this.txttottal;
            this.txttottal.Location = new System.Drawing.Point(56, 506);
            this.txttottal.Margin = new System.Windows.Forms.Padding(15);
            this.txttottal.Name = "txttottal";
            this.txttottal.PasswordChar = '\0';
            this.txttottal.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txttottal.PlaceholderText = "";
            this.txttottal.ReadOnly = true;
            this.txttottal.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txttottal.SelectedText = "";
            this.txttottal.ShadowDecoration.Parent = this.txttottal;
            this.txttottal.Size = new System.Drawing.Size(443, 46);
            this.txttottal.TabIndex = 78;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(537, 506);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(139, 26);
            this.label11.TabIndex = 79;
            this.label11.Text = "اجمالي المطلوب";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(40)))), ((int)(((byte)(100)))));
            this.label9.Location = new System.Drawing.Point(368, 468);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(105, 23);
            this.label9.TabIndex = 75;
            this.label9.Text = "صورة شخصيه";
            // 
            // lblpay
            // 
            this.lblpay.AutoSize = true;
            this.lblpay.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(40)))), ((int)(((byte)(100)))));
            this.lblpay.Location = new System.Drawing.Point(241, 647);
            this.lblpay.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblpay.Name = "lblpay";
            this.lblpay.Size = new System.Drawing.Size(0, 19);
            this.lblpay.TabIndex = 74;
            // 
            // lblpaid
            // 
            this.lblpaid.AutoSize = true;
            this.lblpaid.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpaid.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(40)))), ((int)(((byte)(100)))));
            this.lblpaid.Location = new System.Drawing.Point(58, 557);
            this.lblpaid.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblpaid.Name = "lblpaid";
            this.lblpaid.Size = new System.Drawing.Size(0, 19);
            this.lblpaid.TabIndex = 74;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(40)))), ((int)(((byte)(100)))));
            this.label8.Location = new System.Drawing.Point(227, 468);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(98, 23);
            this.label8.TabIndex = 74;
            this.label8.Text = "صورة البطاقه";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(40)))), ((int)(((byte)(100)))));
            this.label7.Location = new System.Drawing.Point(96, 468);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 23);
            this.label7.TabIndex = 73;
            this.label7.Text = "جواز السفر";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(585, 412);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 26);
            this.label5.TabIndex = 72;
            this.label5.Text = "المستندات";
            // 
            // clientGride
            // 
            this.clientGride.AllowUserToAddRows = false;
            this.clientGride.AllowUserToDeleteRows = false;
            this.clientGride.AllowUserToResizeColumns = false;
            this.clientGride.AllowUserToResizeRows = false;
            this.clientGride.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.clientGride.BackgroundColor = System.Drawing.Color.White;
            this.clientGride.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.clientGride.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.clientGride.Dock = System.Windows.Forms.DockStyle.Left;
            this.clientGride.Location = new System.Drawing.Point(20, 71);
            this.clientGride.Name = "clientGride";
            this.clientGride.ReadOnly = true;
            this.clientGride.RowTemplate.Height = 24;
            this.clientGride.Size = new System.Drawing.Size(1037, 945);
            this.clientGride.TabIndex = 3;
            this.clientGride.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.clientGride_CellContentClick);
            this.clientGride.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.clientGride_CellDoubleClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(568, 132);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 26);
            this.label2.TabIndex = 68;
            this.label2.Text = "الرقم القومي";
            // 
            // txtphonenumber
            // 
            this.txtphonenumber.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(45)))), ((int)(((byte)(104)))));
            this.txtphonenumber.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtphonenumber.DefaultText = "";
            this.txtphonenumber.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtphonenumber.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtphonenumber.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtphonenumber.DisabledState.Parent = this.txtphonenumber;
            this.txtphonenumber.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtphonenumber.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtphonenumber.FocusedState.Parent = this.txtphonenumber;
            this.txtphonenumber.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtphonenumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(45)))), ((int)(((byte)(104)))));
            this.txtphonenumber.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtphonenumber.HoverState.Parent = this.txtphonenumber;
            this.txtphonenumber.Location = new System.Drawing.Point(56, 305);
            this.txtphonenumber.Margin = new System.Windows.Forms.Padding(15);
            this.txtphonenumber.Name = "txtphonenumber";
            this.txtphonenumber.PasswordChar = '\0';
            this.txtphonenumber.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtphonenumber.PlaceholderText = "";
            this.txtphonenumber.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtphonenumber.SelectedText = "";
            this.txtphonenumber.ShadowDecoration.Parent = this.txtphonenumber;
            this.txtphonenumber.Size = new System.Drawing.Size(443, 46);
            this.txtphonenumber.TabIndex = 63;
            this.txtphonenumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtphonenumber_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(571, 305);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 26);
            this.label4.TabIndex = 66;
            this.label4.Text = "رقم التليفون";
            // 
            // txtaddress
            // 
            this.txtaddress.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtaddress.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(45)))), ((int)(((byte)(104)))));
            this.txtaddress.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtaddress.DefaultText = "";
            this.txtaddress.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtaddress.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtaddress.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtaddress.DisabledState.Parent = this.txtaddress;
            this.txtaddress.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtaddress.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtaddress.FocusedState.Parent = this.txtaddress;
            this.txtaddress.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtaddress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(45)))), ((int)(((byte)(104)))));
            this.txtaddress.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtaddress.HoverState.Parent = this.txtaddress;
            this.txtaddress.Location = new System.Drawing.Point(56, 250);
            this.txtaddress.Margin = new System.Windows.Forms.Padding(15);
            this.txtaddress.Name = "txtaddress";
            this.txtaddress.PasswordChar = '\0';
            this.txtaddress.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtaddress.PlaceholderText = "";
            this.txtaddress.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtaddress.SelectedText = "";
            this.txtaddress.ShadowDecoration.Parent = this.txtaddress;
            this.txtaddress.Size = new System.Drawing.Size(443, 46);
            this.txtaddress.TabIndex = 62;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(603, 250);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 26);
            this.label3.TabIndex = 65;
            this.label3.Text = "العنوان";
            // 
            // txtname
            // 
            this.txtname.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(45)))), ((int)(((byte)(104)))));
            this.txtname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtname.DefaultText = "";
            this.txtname.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtname.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtname.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtname.DisabledState.Parent = this.txtname;
            this.txtname.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtname.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtname.FocusedState.Parent = this.txtname;
            this.txtname.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(45)))), ((int)(((byte)(104)))));
            this.txtname.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtname.HoverState.Parent = this.txtname;
            this.txtname.Location = new System.Drawing.Point(56, 194);
            this.txtname.Margin = new System.Windows.Forms.Padding(15);
            this.txtname.Name = "txtname";
            this.txtname.PasswordChar = '\0';
            this.txtname.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtname.PlaceholderText = "";
            this.txtname.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtname.SelectedText = "";
            this.txtname.ShadowDecoration.Parent = this.txtname;
            this.txtname.Size = new System.Drawing.Size(443, 46);
            this.txtname.TabIndex = 61;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(615, 196);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 26);
            this.label1.TabIndex = 64;
            this.label1.Text = "الاسم";
            // 
            // txtid
            // 
            this.txtid.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(45)))), ((int)(((byte)(104)))));
            this.txtid.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtid.DefaultText = "";
            this.txtid.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtid.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtid.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtid.DisabledState.Parent = this.txtid;
            this.txtid.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtid.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtid.FocusedState.Parent = this.txtid;
            this.txtid.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtid.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(45)))), ((int)(((byte)(104)))));
            this.txtid.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtid.HoverState.Parent = this.txtid;
            this.txtid.Location = new System.Drawing.Point(56, 73);
            this.txtid.Margin = new System.Windows.Forms.Padding(15);
            this.txtid.Name = "txtid";
            this.txtid.PasswordChar = '\0';
            this.txtid.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtid.PlaceholderText = "";
            this.txtid.ReadOnly = true;
            this.txtid.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtid.SelectedText = "";
            this.txtid.ShadowDecoration.Parent = this.txtid;
            this.txtid.Size = new System.Drawing.Size(443, 46);
            this.txtid.TabIndex = 59;
            this.txtid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(582, 78);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 26);
            this.label6.TabIndex = 60;
            this.label6.Text = "كود العميل";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtNotes);
            this.panel2.Controls.Add(this.txtdate);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.printpassport);
            this.panel2.Controls.Add(this.printssd);
            this.panel2.Controls.Add(this.printpersonal);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.txtremains);
            this.panel2.Controls.Add(this.label18);
            this.panel2.Controls.Add(this.txtmoney);
            this.panel2.Controls.Add(this.label17);
            this.panel2.Controls.Add(this.txtpaid);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.txttottal);
            this.panel2.Controls.Add(this.lblremains);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.lblpay);
            this.panel2.Controls.Add(this.lblpaid);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.imgPersonalImage);
            this.panel2.Controls.Add(this.imgSSD);
            this.panel2.Controls.Add(this.imgPassport);
            this.panel2.Controls.Add(this.txtssd);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txtphonenumber);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.txtaddress);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txtname);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.txtid);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(1031, 6);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(702, 1010);
            this.panel2.TabIndex = 0;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // txtNotes
            // 
            this.txtNotes.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNotes.Location = new System.Drawing.Point(56, 828);
            this.txtNotes.Multiline = true;
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtNotes.Size = new System.Drawing.Size(443, 86);
            this.txtNotes.TabIndex = 90;
            // 
            // txtdate
            // 
            this.txtdate.BackColor = System.Drawing.Color.Transparent;
            this.txtdate.BaseColor = System.Drawing.Color.White;
            this.txtdate.BorderColor = System.Drawing.Color.Silver;
            this.txtdate.CustomFormat = "dd,MM,yyyy";
            this.txtdate.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.txtdate.Enabled = false;
            this.txtdate.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtdate.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdate.ForeColor = System.Drawing.Color.Black;
            this.txtdate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtdate.Location = new System.Drawing.Point(56, 591);
            this.txtdate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.txtdate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.txtdate.Name = "txtdate";
            this.txtdate.OnHoverBaseColor = System.Drawing.Color.White;
            this.txtdate.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtdate.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtdate.OnPressedColor = System.Drawing.Color.Black;
            this.txtdate.Radius = 4;
            this.txtdate.Size = new System.Drawing.Size(178, 46);
            this.txtdate.TabIndex = 89;
            this.txtdate.Text = "11/4/2020";
            this.txtdate.Value = new System.DateTime(2020, 11, 4, 0, 0, 0, 0);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(237, 606);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(103, 22);
            this.label10.TabIndex = 88;
            this.label10.Text = "تاريخ اخر دفعه";
            // 
            // printpassport
            // 
            this.printpassport.BackColor = System.Drawing.Color.Transparent;
            this.printpassport.Cursor = System.Windows.Forms.Cursors.Help;
            this.printpassport.Enabled = false;
            this.printpassport.Image = ((System.Drawing.Image)(resources.GetObject("printpassport.Image")));
            this.printpassport.Location = new System.Drawing.Point(159, 415);
            this.printpassport.Name = "printpassport";
            this.printpassport.Size = new System.Drawing.Size(38, 33);
            this.printpassport.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.printpassport.TabIndex = 86;
            this.printpassport.TabStop = false;
            this.printpassport.Click += new System.EventHandler(this.printpassport_Click);
            // 
            // printssd
            // 
            this.printssd.BackColor = System.Drawing.Color.Transparent;
            this.printssd.Cursor = System.Windows.Forms.Cursors.Help;
            this.printssd.Enabled = false;
            this.printssd.Image = ((System.Drawing.Image)(resources.GetObject("printssd.Image")));
            this.printssd.Location = new System.Drawing.Point(309, 415);
            this.printssd.Name = "printssd";
            this.printssd.Size = new System.Drawing.Size(38, 33);
            this.printssd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.printssd.TabIndex = 86;
            this.printssd.TabStop = false;
            this.printssd.Click += new System.EventHandler(this.printssd_Click);
            // 
            // printpersonal
            // 
            this.printpersonal.BackColor = System.Drawing.Color.Transparent;
            this.printpersonal.Cursor = System.Windows.Forms.Cursors.Help;
            this.printpersonal.Enabled = false;
            this.printpersonal.Image = ((System.Drawing.Image)(resources.GetObject("printpersonal.Image")));
            this.printpersonal.Location = new System.Drawing.Point(460, 415);
            this.printpersonal.Name = "printpersonal";
            this.printpersonal.Size = new System.Drawing.Size(38, 33);
            this.printpersonal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.printpersonal.TabIndex = 86;
            this.printpersonal.TabStop = false;
            this.printpersonal.Click += new System.EventHandler(this.printpersonal_Click);
            // 
            // txtremains
            // 
            this.txtremains.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(45)))), ((int)(((byte)(104)))));
            this.txtremains.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtremains.DefaultText = "";
            this.txtremains.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtremains.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtremains.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtremains.DisabledState.Parent = this.txtremains;
            this.txtremains.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtremains.FillColor = System.Drawing.Color.Silver;
            this.txtremains.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtremains.FocusedState.Parent = this.txtremains;
            this.txtremains.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtremains.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(45)))), ((int)(((byte)(104)))));
            this.txtremains.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtremains.HoverState.Parent = this.txtremains;
            this.txtremains.Location = new System.Drawing.Point(56, 752);
            this.txtremains.Margin = new System.Windows.Forms.Padding(15);
            this.txtremains.Name = "txtremains";
            this.txtremains.PasswordChar = '\0';
            this.txtremains.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtremains.PlaceholderText = "";
            this.txtremains.ReadOnly = true;
            this.txtremains.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtremains.SelectedText = "";
            this.txtremains.ShadowDecoration.Parent = this.txtremains;
            this.txtremains.Size = new System.Drawing.Size(443, 46);
            this.txtremains.TabIndex = 80;
            this.txtremains.TextChanged += new System.EventHandler(this.txtremains_TextChanged);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.Black;
            this.label18.Location = new System.Drawing.Point(604, 767);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(69, 26);
            this.label18.TabIndex = 81;
            this.label18.Text = "المتبقي";
            // 
            // txtmoney
            // 
            this.txtmoney.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(45)))), ((int)(((byte)(104)))));
            this.txtmoney.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtmoney.DefaultText = "";
            this.txtmoney.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtmoney.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtmoney.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtmoney.DisabledState.Parent = this.txtmoney;
            this.txtmoney.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtmoney.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtmoney.FocusedState.Parent = this.txtmoney;
            this.txtmoney.Font = new System.Drawing.Font("Times New Roman", 18F);
            this.txtmoney.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(45)))), ((int)(((byte)(104)))));
            this.txtmoney.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtmoney.HoverState.Parent = this.txtmoney;
            this.txtmoney.Location = new System.Drawing.Point(56, 698);
            this.txtmoney.Margin = new System.Windows.Forms.Padding(15);
            this.txtmoney.Name = "txtmoney";
            this.txtmoney.PasswordChar = '\0';
            this.txtmoney.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtmoney.PlaceholderText = "";
            this.txtmoney.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtmoney.SelectedText = "";
            this.txtmoney.ShadowDecoration.Parent = this.txtmoney;
            this.txtmoney.Size = new System.Drawing.Size(443, 46);
            this.txtmoney.TabIndex = 80;
            this.txtmoney.TextChanged += new System.EventHandler(this.txtmoney_TextChanged);
            this.txtmoney.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtmoney_KeyPress);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.Black;
            this.label17.Location = new System.Drawing.Point(604, 713);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(38, 26);
            this.label17.TabIndex = 81;
            this.label17.Text = "دفع";
            // 
            // lblremains
            // 
            this.lblremains.AutoSize = true;
            this.lblremains.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblremains.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(40)))), ((int)(((byte)(100)))));
            this.lblremains.Location = new System.Drawing.Point(60, 806);
            this.lblremains.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblremains.Name = "lblremains";
            this.lblremains.Size = new System.Drawing.Size(0, 19);
            this.lblremains.TabIndex = 74;
            // 
            // imgPersonalImage
            // 
            this.imgPersonalImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imgPersonalImage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imgPersonalImage.Image = ((System.Drawing.Image)(resources.GetObject("imgPersonalImage.Image")));
            this.imgPersonalImage.Location = new System.Drawing.Point(357, 369);
            this.imgPersonalImage.Name = "imgPersonalImage";
            this.imgPersonalImage.Size = new System.Drawing.Size(142, 80);
            this.imgPersonalImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgPersonalImage.TabIndex = 70;
            this.imgPersonalImage.TabStop = false;
            this.imgPersonalImage.Click += new System.EventHandler(this.imgPersonalImage_Click);
            // 
            // imgSSD
            // 
            this.imgSSD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imgSSD.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imgSSD.Image = ((System.Drawing.Image)(resources.GetObject("imgSSD.Image")));
            this.imgSSD.Location = new System.Drawing.Point(206, 369);
            this.imgSSD.Name = "imgSSD";
            this.imgSSD.Size = new System.Drawing.Size(142, 80);
            this.imgSSD.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgSSD.TabIndex = 71;
            this.imgSSD.TabStop = false;
            this.imgSSD.Click += new System.EventHandler(this.imgSSD_Click);
            // 
            // imgPassport
            // 
            this.imgPassport.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imgPassport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imgPassport.Image = ((System.Drawing.Image)(resources.GetObject("imgPassport.Image")));
            this.imgPassport.Location = new System.Drawing.Point(56, 369);
            this.imgPassport.Name = "imgPassport";
            this.imgPassport.Size = new System.Drawing.Size(142, 80);
            this.imgPassport.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgPassport.TabIndex = 69;
            this.imgPassport.TabStop = false;
            this.imgPassport.Click += new System.EventHandler(this.imgPassport_Click);
            // 
            // txtssd
            // 
            this.txtssd.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(45)))), ((int)(((byte)(104)))));
            this.txtssd.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtssd.DefaultText = "";
            this.txtssd.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtssd.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtssd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtssd.DisabledState.Parent = this.txtssd;
            this.txtssd.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtssd.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtssd.FocusedState.Parent = this.txtssd;
            this.txtssd.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtssd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(45)))), ((int)(((byte)(104)))));
            this.txtssd.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtssd.HoverState.Parent = this.txtssd;
            this.txtssd.Location = new System.Drawing.Point(56, 132);
            this.txtssd.Margin = new System.Windows.Forms.Padding(15);
            this.txtssd.Name = "txtssd";
            this.txtssd.PasswordChar = '\0';
            this.txtssd.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtssd.PlaceholderText = "";
            this.txtssd.SelectedText = "";
            this.txtssd.ShadowDecoration.Parent = this.txtssd;
            this.txtssd.Size = new System.Drawing.Size(443, 46);
            this.txtssd.TabIndex = 67;
            this.txtssd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtssd_KeyPress);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.clientGride);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(20, 6, 0, 6);
            this.panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.panel1.Size = new System.Drawing.Size(1733, 1022);
            this.panel1.TabIndex = 3;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // editeclient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "editeclient";
            this.Size = new System.Drawing.Size(1733, 1022);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.clientGride)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.printpassport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.printssd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.printpersonal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgPersonalImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgSSD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgPassport)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtsearch;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label13;
        private Guna.UI2.WinForms.Guna2TextBox txtpaid;
        private System.Windows.Forms.Label label12;
        private Guna.UI2.WinForms.Guna2TextBox txttottal;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblpay;
        private System.Windows.Forms.Label lblpaid;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView clientGride;
        private System.Windows.Forms.PictureBox imgPersonalImage;
        private System.Windows.Forms.PictureBox imgSSD;
        private System.Windows.Forms.PictureBox imgPassport;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox txtphonenumber;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2TextBox txtaddress;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox txtname;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox txtid;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2TextBox txtssd;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox printpersonal;
        private System.Windows.Forms.PictureBox printpassport;
        private System.Windows.Forms.PictureBox printssd;
        private Guna.UI2.WinForms.Guna2TextBox txtremains;
        private System.Windows.Forms.Label label18;
        private Guna.UI2.WinForms.Guna2TextBox txtmoney;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label lblremains;
        private System.Windows.Forms.Label label10;
        private Guna.UI.WinForms.GunaDateTimePicker txtdate;
        private System.Windows.Forms.TextBox txtNotes;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private Guna.UI2.WinForms.Guna2ToggleSwitch ispaid;
        private Guna.UI2.WinForms.Guna2ToggleSwitch idsearch;
        private System.Windows.Forms.Label label14;
    }
}
