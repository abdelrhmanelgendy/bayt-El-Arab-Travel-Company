namespace ELMOS7AF.UserControls
{
    partial class addnewClient
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.clientGride = new System.Windows.Forms.DataGridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label14 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtNotes = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.txtremains = new Guna.UI2.WinForms.Guna2TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtpaid = new Guna.UI2.WinForms.Guna2TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txttottalmoney = new Guna.UI2.WinForms.Guna2TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblremains = new System.Windows.Forms.Label();
            this.lblpaid = new System.Windows.Forms.Label();
            this.lbltottal = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.imgPersonalImage = new System.Windows.Forms.PictureBox();
            this.imgSSD = new System.Windows.Forms.PictureBox();
            this.imgPassport = new System.Windows.Forms.PictureBox();
            this.txtssd = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtphonenumber = new Guna.UI2.WinForms.Guna2TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtaddress = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtname = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtid = new Guna.UI2.WinForms.Guna2TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clientGride)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgPersonalImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgSSD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgPassport)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.clientGride);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(20, 6, 0, 6);
            this.panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.panel1.Size = new System.Drawing.Size(1733, 1022);
            this.panel1.TabIndex = 2;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // clientGride
            // 
            this.clientGride.AllowUserToAddRows = false;
            this.clientGride.AllowUserToDeleteRows = false;
            this.clientGride.AllowUserToResizeColumns = false;
            this.clientGride.AllowUserToResizeRows = false;
            this.clientGride.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.clientGride.BackgroundColor = System.Drawing.Color.White;
            this.clientGride.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.clientGride.Dock = System.Windows.Forms.DockStyle.Left;
            this.clientGride.Location = new System.Drawing.Point(20, 71);
            this.clientGride.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.clientGride.Name = "clientGride";
            this.clientGride.ReadOnly = true;
            this.clientGride.RowTemplate.Height = 24;
            this.clientGride.Size = new System.Drawing.Size(987, 945);
            this.clientGride.TabIndex = 3;
            this.clientGride.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.clientGride_CellDoubleClick);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label14);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(20, 6);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1004, 65);
            this.panel4.TabIndex = 2;
            // 
            // label14
            // 
            this.label14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(50)))), ((int)(((byte)(100)))));
            this.label14.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(0, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(1011, 62);
            this.label14.TabIndex = 0;
            this.label14.Text = "بيانات العملاء";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label14.Click += new System.EventHandler(this.label14_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtNotes);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.txtremains);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.txtpaid);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.txttottalmoney);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.lblremains);
            this.panel2.Controls.Add(this.lblpaid);
            this.panel2.Controls.Add(this.lbltottal);
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
            this.panel2.Location = new System.Drawing.Point(1024, 6);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(709, 1010);
            this.panel2.TabIndex = 0;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // txtNotes
            // 
            this.txtNotes.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNotes.Location = new System.Drawing.Point(0, 818);
            this.txtNotes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNotes.Multiline = true;
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtNotes.Size = new System.Drawing.Size(535, 94);
            this.txtNotes.TabIndex = 91;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.button1);
            this.panel3.Controls.Add(this.button2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 934);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(709, 76);
            this.panel3.TabIndex = 85;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(40)))), ((int)(((byte)(100)))));
            this.button1.Dock = System.Windows.Forms.DockStyle.Left;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(348, 0);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(335, 76);
            this.button1.TabIndex = 0;
            this.button1.Text = "اضافة";
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
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(348, 76);
            this.button2.TabIndex = 1;
            this.button2.Text = "مسح البيانات";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(573, 850);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(89, 26);
            this.label13.TabIndex = 83;
            this.label13.Text = "ملاحظات ";
            // 
            // txtremains
            // 
            this.txtremains.BorderColor = System.Drawing.Color.Black;
            this.txtremains.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtremains.DefaultText = "";
            this.txtremains.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtremains.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtremains.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtremains.DisabledState.Parent = this.txtremains;
            this.txtremains.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtremains.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtremains.FocusedState.Parent = this.txtremains;
            this.txtremains.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtremains.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(45)))), ((int)(((byte)(104)))));
            this.txtremains.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtremains.HoverState.Parent = this.txtremains;
            this.txtremains.Location = new System.Drawing.Point(0, 716);
            this.txtremains.Margin = new System.Windows.Forms.Padding(15, 15, 15, 15);
            this.txtremains.Name = "txtremains";
            this.txtremains.PasswordChar = '\0';
            this.txtremains.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtremains.PlaceholderText = "";
            this.txtremains.ReadOnly = true;
            this.txtremains.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtremains.SelectedText = "";
            this.txtremains.ShadowDecoration.Parent = this.txtremains;
            this.txtremains.Size = new System.Drawing.Size(535, 46);
            this.txtremains.TabIndex = 7;
            this.txtremains.TextChanged += new System.EventHandler(this.txtremains_TextChanged);
            this.txtremains.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtremains_KeyPress);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(587, 731);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(69, 26);
            this.label12.TabIndex = 81;
            this.label12.Text = "المتبقي";
            // 
            // txtpaid
            // 
            this.txtpaid.BorderColor = System.Drawing.Color.Black;
            this.txtpaid.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtpaid.DefaultText = "";
            this.txtpaid.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtpaid.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtpaid.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtpaid.DisabledState.Parent = this.txtpaid;
            this.txtpaid.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtpaid.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtpaid.FocusedState.Parent = this.txtpaid;
            this.txtpaid.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpaid.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(45)))), ((int)(((byte)(104)))));
            this.txtpaid.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtpaid.HoverState.Parent = this.txtpaid;
            this.txtpaid.Location = new System.Drawing.Point(0, 604);
            this.txtpaid.Margin = new System.Windows.Forms.Padding(15, 15, 15, 15);
            this.txtpaid.Name = "txtpaid";
            this.txtpaid.PasswordChar = '\0';
            this.txtpaid.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtpaid.PlaceholderText = "";
            this.txtpaid.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtpaid.SelectedText = "";
            this.txtpaid.ShadowDecoration.Parent = this.txtpaid;
            this.txtpaid.Size = new System.Drawing.Size(535, 46);
            this.txtpaid.TabIndex = 6;
            this.txtpaid.TextChanged += new System.EventHandler(this.txtpaid_TextChanged);
            this.txtpaid.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtpaid_KeyDown);
            this.txtpaid.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtpaid_KeyPress);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(589, 624);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(69, 26);
            this.label11.TabIndex = 79;
            this.label11.Text = "المقدمه";
            // 
            // txttottalmoney
            // 
            this.txttottalmoney.BorderColor = System.Drawing.Color.Black;
            this.txttottalmoney.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txttottalmoney.DefaultText = "";
            this.txttottalmoney.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txttottalmoney.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txttottalmoney.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txttottalmoney.DisabledState.Parent = this.txttottalmoney;
            this.txttottalmoney.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txttottalmoney.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txttottalmoney.FocusedState.Parent = this.txttottalmoney;
            this.txttottalmoney.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttottalmoney.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(45)))), ((int)(((byte)(104)))));
            this.txttottalmoney.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txttottalmoney.HoverState.Parent = this.txttottalmoney;
            this.txttottalmoney.Location = new System.Drawing.Point(0, 524);
            this.txttottalmoney.Margin = new System.Windows.Forms.Padding(15, 15, 15, 15);
            this.txttottalmoney.Name = "txttottalmoney";
            this.txttottalmoney.PasswordChar = '\0';
            this.txttottalmoney.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txttottalmoney.PlaceholderText = "";
            this.txttottalmoney.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txttottalmoney.SelectedText = "";
            this.txttottalmoney.ShadowDecoration.Parent = this.txttottalmoney;
            this.txttottalmoney.Size = new System.Drawing.Size(535, 46);
            this.txttottalmoney.TabIndex = 5;
            this.txttottalmoney.TextChanged += new System.EventHandler(this.txttottalmoney_TextChanged);
            this.txttottalmoney.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txttottalmoney_KeyPress);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(539, 528);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(130, 26);
            this.label10.TabIndex = 77;
            this.label10.Text = "المبلغ المطلوب";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(40)))), ((int)(((byte)(100)))));
            this.label9.Location = new System.Drawing.Point(377, 466);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(105, 23);
            this.label9.TabIndex = 75;
            this.label9.Text = "صورة شخصيه";
            // 
            // lblremains
            // 
            this.lblremains.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblremains.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(40)))), ((int)(((byte)(100)))));
            this.lblremains.Location = new System.Drawing.Point(8, 767);
            this.lblremains.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblremains.Name = "lblremains";
            this.lblremains.Size = new System.Drawing.Size(523, 25);
            this.lblremains.TabIndex = 10;
            this.lblremains.Click += new System.EventHandler(this.label16_Click);
            // 
            // lblpaid
            // 
            this.lblpaid.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpaid.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(40)))), ((int)(((byte)(100)))));
            this.lblpaid.Location = new System.Drawing.Point(7, 672);
            this.lblpaid.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblpaid.Name = "lblpaid";
            this.lblpaid.Size = new System.Drawing.Size(523, 30);
            this.lblpaid.TabIndex = 74;
            this.lblpaid.Click += new System.EventHandler(this.label15_Click);
            // 
            // lbltottal
            // 
            this.lbltottal.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltottal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(40)))), ((int)(((byte)(100)))));
            this.lbltottal.Location = new System.Drawing.Point(11, 574);
            this.lbltottal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbltottal.Name = "lbltottal";
            this.lbltottal.Size = new System.Drawing.Size(499, 21);
            this.lbltottal.TabIndex = 74;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(40)))), ((int)(((byte)(100)))));
            this.label8.Location = new System.Drawing.Point(205, 466);
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
            this.label7.Location = new System.Drawing.Point(53, 466);
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
            this.label5.Location = new System.Drawing.Point(560, 414);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 26);
            this.label5.TabIndex = 72;
            this.label5.Text = "المستندات ";
            // 
            // imgPersonalImage
            // 
            this.imgPersonalImage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imgPersonalImage.Image = global::ELMOS7AF.Properties.Resources.mPersonal;
            this.imgPersonalImage.Location = new System.Drawing.Point(369, 377);
            this.imgPersonalImage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.imgPersonalImage.Name = "imgPersonalImage";
            this.imgPersonalImage.Size = new System.Drawing.Size(113, 80);
            this.imgPersonalImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgPersonalImage.TabIndex = 70;
            this.imgPersonalImage.TabStop = false;
            this.imgPersonalImage.Click += new System.EventHandler(this.imgPersonalImage_Click);
            this.imgPersonalImage.DragDrop += new System.Windows.Forms.DragEventHandler(this.imgPersonalImage_DragDrop);
            this.imgPersonalImage.DragEnter += new System.Windows.Forms.DragEventHandler(this.imgPersonalImage_DragEnter);
            this.imgPersonalImage.MouseHover += new System.EventHandler(this.imgPersonalImage_MouseHover);
            // 
            // imgSSD
            // 
            this.imgSSD.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imgSSD.Image = global::ELMOS7AF.Properties.Resources.mSSD;
            this.imgSSD.Location = new System.Drawing.Point(193, 377);
            this.imgSSD.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.imgSSD.Name = "imgSSD";
            this.imgSSD.Size = new System.Drawing.Size(113, 80);
            this.imgSSD.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgSSD.TabIndex = 71;
            this.imgSSD.TabStop = false;
            this.imgSSD.Click += new System.EventHandler(this.imgSSD_Click);
            this.imgSSD.DragDrop += new System.Windows.Forms.DragEventHandler(this.imgSSD_DragDrop);
            this.imgSSD.DragEnter += new System.Windows.Forms.DragEventHandler(this.imgSSD_DragEnter);
            // 
            // imgPassport
            // 
            this.imgPassport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imgPassport.Image = global::ELMOS7AF.Properties.Resources.mPassport;
            this.imgPassport.Location = new System.Drawing.Point(41, 377);
            this.imgPassport.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.imgPassport.Name = "imgPassport";
            this.imgPassport.Size = new System.Drawing.Size(113, 80);
            this.imgPassport.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgPassport.TabIndex = 69;
            this.imgPassport.TabStop = false;
            this.imgPassport.Click += new System.EventHandler(this.imgPassport_Click);
            this.imgPassport.DragDrop += new System.Windows.Forms.DragEventHandler(this.imgPassport_DragDrop);
            this.imgPassport.DragEnter += new System.Windows.Forms.DragEventHandler(this.imgPassport_DragEnter);
            // 
            // txtssd
            // 
            this.txtssd.BorderColor = System.Drawing.Color.Black;
            this.txtssd.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtssd.DefaultText = "1266554885654";
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
            this.txtssd.IconRightSize = new System.Drawing.Size(40, 30);
            this.txtssd.Location = new System.Drawing.Point(0, 132);
            this.txtssd.Margin = new System.Windows.Forms.Padding(15, 15, 15, 15);
            this.txtssd.Name = "txtssd";
            this.txtssd.PasswordChar = '\0';
            this.txtssd.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtssd.PlaceholderText = "";
            this.txtssd.SelectedText = "";
            this.txtssd.SelectionStart = 13;
            this.txtssd.ShadowDecoration.Parent = this.txtssd;
            this.txtssd.Size = new System.Drawing.Size(527, 46);
            this.txtssd.TabIndex = 1;
            this.txtssd.TextChanged += new System.EventHandler(this.txtssd_TextChanged);
            this.txtssd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtssd_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(548, 132);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 26);
            this.label2.TabIndex = 68;
            this.label2.Text = "الرقم القومي";
            // 
            // txtphonenumber
            // 
            this.txtphonenumber.BorderColor = System.Drawing.Color.Black;
            this.txtphonenumber.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtphonenumber.DefaultText = "01095727518";
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
            this.txtphonenumber.Location = new System.Drawing.Point(0, 305);
            this.txtphonenumber.Margin = new System.Windows.Forms.Padding(15, 15, 15, 15);
            this.txtphonenumber.Name = "txtphonenumber";
            this.txtphonenumber.PasswordChar = '\0';
            this.txtphonenumber.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtphonenumber.PlaceholderText = "";
            this.txtphonenumber.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtphonenumber.SelectedText = "";
            this.txtphonenumber.SelectionStart = 11;
            this.txtphonenumber.ShadowDecoration.Parent = this.txtphonenumber;
            this.txtphonenumber.Size = new System.Drawing.Size(527, 46);
            this.txtphonenumber.TabIndex = 4;
            this.txtphonenumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtphonenumber_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(551, 305);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 26);
            this.label4.TabIndex = 0;
            this.label4.Text = "رقم التليفون";
            // 
            // txtaddress
            // 
            this.txtaddress.BorderColor = System.Drawing.Color.Black;
            this.txtaddress.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtaddress.DefaultText = "egypty,etay elbaroud";
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
            this.txtaddress.Location = new System.Drawing.Point(0, 250);
            this.txtaddress.Margin = new System.Windows.Forms.Padding(15, 15, 15, 15);
            this.txtaddress.Name = "txtaddress";
            this.txtaddress.PasswordChar = '\0';
            this.txtaddress.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtaddress.PlaceholderText = "";
            this.txtaddress.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtaddress.SelectedText = "";
            this.txtaddress.SelectionStart = 20;
            this.txtaddress.ShadowDecoration.Parent = this.txtaddress;
            this.txtaddress.Size = new System.Drawing.Size(527, 46);
            this.txtaddress.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(583, 250);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 26);
            this.label3.TabIndex = 65;
            this.label3.Text = "العنوان";
            // 
            // txtname
            // 
            this.txtname.BorderColor = System.Drawing.Color.Black;
            this.txtname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtname.DefaultText = "abdelrhman elgendy";
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
            this.txtname.Location = new System.Drawing.Point(0, 194);
            this.txtname.Margin = new System.Windows.Forms.Padding(15, 15, 15, 15);
            this.txtname.Name = "txtname";
            this.txtname.PasswordChar = '\0';
            this.txtname.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtname.PlaceholderText = "";
            this.txtname.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtname.SelectedText = "";
            this.txtname.SelectionStart = 18;
            this.txtname.ShadowDecoration.Parent = this.txtname;
            this.txtname.Size = new System.Drawing.Size(527, 46);
            this.txtname.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(595, 196);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 26);
            this.label1.TabIndex = 64;
            this.label1.Text = "الاسم";
            // 
            // txtid
            // 
            this.txtid.BorderColor = System.Drawing.Color.Black;
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
            this.txtid.IconRightSize = new System.Drawing.Size(35, 30);
            this.txtid.Location = new System.Drawing.Point(0, 73);
            this.txtid.Margin = new System.Windows.Forms.Padding(15, 15, 15, 15);
            this.txtid.Name = "txtid";
            this.txtid.PasswordChar = '\0';
            this.txtid.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtid.PlaceholderText = "";
            this.txtid.ReadOnly = true;
            this.txtid.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtid.SelectedText = "";
            this.txtid.ShadowDecoration.Parent = this.txtid;
            this.txtid.Size = new System.Drawing.Size(527, 46);
            this.txtid.TabIndex = 0;
            this.txtid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(563, 73);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 26);
            this.label6.TabIndex = 60;
            this.label6.Text = "كود العميل";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // addnewClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "addnewClient";
            this.Size = new System.Drawing.Size(1733, 1022);
            this.Load += new System.EventHandler(this.addnewClient_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.clientGride)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgPersonalImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgSSD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgPassport)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2TextBox txtpaid;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
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
        private System.Windows.Forms.Label label13;
        private Guna.UI2.WinForms.Guna2TextBox txtremains;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lblremains;
        private System.Windows.Forms.Label lblpaid;
        private Guna.UI2.WinForms.Guna2TextBox txttottalmoney;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lbltottal;
        private System.Windows.Forms.TextBox txtNotes;
        private Guna.UI2.WinForms.Guna2TextBox txtssd;
        public System.Windows.Forms.DataGridView clientGride;
    }
}
