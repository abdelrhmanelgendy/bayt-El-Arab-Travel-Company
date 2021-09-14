using Bunifu.Framework.UI;

namespace ELMOS7AF.UserControls
{
    partial class PersenceAndApsence
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PersenceAndApsence));
            this.panel2 = new System.Windows.Forms.Panel();
            this.label14 = new System.Windows.Forms.Label();
            this.idsearch = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.guna2ToggleSwitch1 = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtsearch = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblarpaid = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbltottal = new System.Windows.Forms.Label();
            this.lblremains = new System.Windows.Forms.Label();
            this.lblpaid = new System.Windows.Forms.Label();
            this.lblartottal = new System.Windows.Forms.Label();
            this.lblarremains = new System.Windows.Forms.Label();
            this.gridData = new System.Windows.Forms.DataGridView();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridData)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(101)))), ((int)(((byte)(172)))));
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.idsearch);
            this.panel2.Controls.Add(this.guna2ToggleSwitch1);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.txtsearch);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1733, 100);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(40)))), ((int)(((byte)(100)))));
            this.label14.Location = new System.Drawing.Point(84, 58);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(100, 19);
            this.label14.TabIndex = 76;
            this.label14.Text = "Id searching";
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
            this.idsearch.Location = new System.Drawing.Point(245, 52);
            this.idsearch.Margin = new System.Windows.Forms.Padding(4);
            this.idsearch.Name = "idsearch";
            this.idsearch.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.idsearch.ShadowDecoration.Parent = this.idsearch;
            this.idsearch.Size = new System.Drawing.Size(49, 25);
            this.idsearch.TabIndex = 75;
            this.idsearch.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.idsearch.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.idsearch.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.idsearch.UncheckedState.InnerColor = System.Drawing.Color.White;
            this.idsearch.UncheckedState.Parent = this.idsearch;
            this.idsearch.CheckedChanged += new System.EventHandler(this.idsearch_CheckedChanged);
            // 
            // guna2ToggleSwitch1
            // 
            this.guna2ToggleSwitch1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.guna2ToggleSwitch1.Animated = true;
            this.guna2ToggleSwitch1.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(45)))), ((int)(((byte)(104)))));
            this.guna2ToggleSwitch1.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(45)))), ((int)(((byte)(104)))));
            this.guna2ToggleSwitch1.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.guna2ToggleSwitch1.CheckedState.InnerColor = System.Drawing.Color.White;
            this.guna2ToggleSwitch1.CheckedState.Parent = this.guna2ToggleSwitch1;
            this.guna2ToggleSwitch1.Cursor = System.Windows.Forms.Cursors.Default;
            this.guna2ToggleSwitch1.Location = new System.Drawing.Point(245, 18);
            this.guna2ToggleSwitch1.Margin = new System.Windows.Forms.Padding(4);
            this.guna2ToggleSwitch1.Name = "guna2ToggleSwitch1";
            this.guna2ToggleSwitch1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.guna2ToggleSwitch1.ShadowDecoration.Parent = this.guna2ToggleSwitch1;
            this.guna2ToggleSwitch1.Size = new System.Drawing.Size(49, 25);
            this.guna2ToggleSwitch1.TabIndex = 42;
            this.guna2ToggleSwitch1.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2ToggleSwitch1.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2ToggleSwitch1.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.guna2ToggleSwitch1.UncheckedState.InnerColor = System.Drawing.Color.White;
            this.guna2ToggleSwitch1.UncheckedState.Parent = this.guna2ToggleSwitch1;
            this.guna2ToggleSwitch1.CheckedChanged += new System.EventHandler(this.guna2ToggleSwitch1_CheckedChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(404, 37);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(72, 35);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 40;
            this.pictureBox1.TabStop = false;
            // 
            // txtsearch
            // 
            this.txtsearch.Font = new System.Drawing.Font("Century", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(101)))), ((int)(((byte)(172)))));
            this.txtsearch.Location = new System.Drawing.Point(393, 33);
            this.txtsearch.Margin = new System.Windows.Forms.Padding(4);
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtsearch.Size = new System.Drawing.Size(704, 44);
            this.txtsearch.TabIndex = 39;
            this.txtsearch.Text = "ابحث هنا";
            this.txtsearch.TextChanged += new System.EventHandler(this.txtsearch_TextChanged);
            this.txtsearch.Enter += new System.EventHandler(this.txtsearch_Enter);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.tableLayoutPanel1);
            this.panel3.Controls.Add(this.gridData);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 100);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1733, 922);
            this.panel3.TabIndex = 2;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(101)))), ((int)(((byte)(172)))));
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset;
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 58.08492F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 41.91508F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 404F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 215F));
            this.tableLayoutPanel1.Controls.Add(this.lblarpaid, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label1, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.label2, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.label3, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.label5, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lbltottal, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblremains, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblpaid, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblartottal, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblarremains, 1, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 796);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1733, 126);
            this.tableLayoutPanel1.TabIndex = 6;
            this.tableLayoutPanel1.Visible = false;
            // 
            // lblarpaid
            // 
            this.lblarpaid.AutoSize = true;
            this.lblarpaid.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblarpaid.ForeColor = System.Drawing.Color.White;
            this.lblarpaid.Location = new System.Drawing.Point(5, 86);
            this.lblarpaid.Name = "lblarpaid";
            this.lblarpaid.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.lblarpaid.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblarpaid.Size = new System.Drawing.Size(255, 24);
            this.lblarpaid.TabIndex = 18;
            this.lblarpaid.Text = "اثنان وتسعون الفل خمسمائه اثنان وثمانون";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(1518, 44);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(80, 10, 5, 5);
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(165, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "الاجمالي";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(1518, 86);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(50, 5, 0, 0);
            this.label2.Size = new System.Drawing.Size(191, 33);
            this.label2.TabIndex = 1;
            this.label2.Text = "الاجمالي بالتفقيم";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(1112, 2);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(200, 8, 5, 5);
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(270, 36);
            this.label3.TabIndex = 2;
            this.label3.Text = "المطلوب";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(648, 2);
            this.label5.Name = "label5";
            this.label5.Padding = new System.Windows.Forms.Padding(150, 8, 5, 5);
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label5.Size = new System.Drawing.Size(214, 36);
            this.label5.TabIndex = 2;
            this.label5.Text = "المدفوع";
            this.label5.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(5, 2);
            this.label6.Name = "label6";
            this.label6.Padding = new System.Windows.Forms.Padding(220, 8, 5, 5);
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label6.Size = new System.Drawing.Size(272, 36);
            this.label6.TabIndex = 2;
            this.label6.Text = "الباقي";
            // 
            // lbltottal
            // 
            this.lbltottal.AutoSize = true;
            this.lbltottal.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltottal.ForeColor = System.Drawing.Color.White;
            this.lbltottal.Location = new System.Drawing.Point(1112, 44);
            this.lbltottal.Name = "lbltottal";
            this.lbltottal.Padding = new System.Windows.Forms.Padding(160, 8, 0, 0);
            this.lbltottal.Size = new System.Drawing.Size(269, 31);
            this.lbltottal.TabIndex = 8;
            this.lbltottal.Text = "100000000";
            this.lbltottal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblremains
            // 
            this.lblremains.AutoSize = true;
            this.lblremains.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblremains.ForeColor = System.Drawing.Color.White;
            this.lblremains.Location = new System.Drawing.Point(648, 44);
            this.lblremains.Name = "lblremains";
            this.lblremains.Padding = new System.Windows.Forms.Padding(160, 8, 0, 0);
            this.lblremains.Size = new System.Drawing.Size(269, 31);
            this.lblremains.TabIndex = 14;
            this.lblremains.Text = "100000000";
            this.lblremains.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblpaid
            // 
            this.lblpaid.AutoSize = true;
            this.lblpaid.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpaid.ForeColor = System.Drawing.Color.White;
            this.lblpaid.Location = new System.Drawing.Point(5, 44);
            this.lblpaid.Name = "lblpaid";
            this.lblpaid.Padding = new System.Windows.Forms.Padding(160, 8, 0, 0);
            this.lblpaid.Size = new System.Drawing.Size(269, 31);
            this.lblpaid.TabIndex = 15;
            this.lblpaid.Text = "100000000";
            this.lblpaid.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblartottal
            // 
            this.lblartottal.AutoSize = true;
            this.lblartottal.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblartottal.ForeColor = System.Drawing.Color.White;
            this.lblartottal.Location = new System.Drawing.Point(1112, 86);
            this.lblartottal.Name = "lblartottal";
            this.lblartottal.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblartottal.Size = new System.Drawing.Size(0, 19);
            this.lblartottal.TabIndex = 16;
            // 
            // lblarremains
            // 
            this.lblarremains.AutoSize = true;
            this.lblarremains.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblarremains.ForeColor = System.Drawing.Color.White;
            this.lblarremains.Location = new System.Drawing.Point(648, 86);
            this.lblarremains.Name = "lblarremains";
            this.lblarremains.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.lblarremains.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblarremains.Size = new System.Drawing.Size(255, 24);
            this.lblarremains.TabIndex = 17;
            this.lblarremains.Text = "اثنان وتسعون الفل خمسمائه اثنان وثمانون";
            this.lblarremains.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // gridData
            // 
            this.gridData.AllowUserToAddRows = false;
            this.gridData.AllowUserToDeleteRows = false;
            this.gridData.AllowUserToResizeColumns = false;
            this.gridData.AllowUserToResizeRows = false;
            this.gridData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridData.BackgroundColor = System.Drawing.Color.White;
            this.gridData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridData.Location = new System.Drawing.Point(0, 0);
            this.gridData.Name = "gridData";
            this.gridData.ReadOnly = true;
            this.gridData.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.gridData.RowTemplate.Height = 35;
            this.gridData.Size = new System.Drawing.Size(1733, 922);
            this.gridData.TabIndex = 5;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // PersenceAndApsence
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "PersenceAndApsence";
            this.Size = new System.Drawing.Size(1733, 1022);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuFlatButton btn_delete;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtsearch;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView gridData;
        private Guna.UI2.WinForms.Guna2ToggleSwitch guna2ToggleSwitch1;
        private System.Windows.Forms.Label label14;
        private Guna.UI2.WinForms.Guna2ToggleSwitch idsearch;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblarpaid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbltottal;
        private System.Windows.Forms.Label lblremains;
        private System.Windows.Forms.Label lblpaid;
        private System.Windows.Forms.Label lblartottal;
        private System.Windows.Forms.Label lblarremains;

        public BunifuFlatButton Btn_delete
        {
            get
            {
                return btn_delete;
            }

            set
            {
                btn_delete = value;
            }
        }
    }
}
