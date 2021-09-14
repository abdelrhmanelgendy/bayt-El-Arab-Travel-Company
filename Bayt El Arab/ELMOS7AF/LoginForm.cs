using ELMOS7AF.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ELMOS7AF
{
    public partial class LoginForm : Form
    {
        Boolean PANEL_COLLAPCING = true;
        Thread th;
        DataTable mDataTable = new DataTable();
        SqlCommand mCommand;
        public SqlDataAdapter mDataAdapter = new SqlDataAdapter();
        DataAccess dataAccess = new DataAccess();
        SqlDataReader dr;
        public DataTable dt = new DataTable();
        static LoginForm _obj;
        public static string adminName;
        int x = 0;
        public LoginForm()
        {
            InitializeComponent();
            bunifuFlatButton1.Normalcolor = Color.FromArgb(11, 160, 71);
            if (Properties.Settings.Default.mainAccount!="")
            {
                serverName.Text = Properties.Settings.Default.mainAccount;
                txtpass.Text = Properties.Settings.Default.mainPassword;
            }
            _obj = this;
            USERNAME.Text= Properties.Settings.Default.mainAccount  ;


            serverName.Text=      Properties.Settings.Default.Server.ToString() ;
       txtDataBase.Text=     Properties.Settings.Default.DataBase ;
            if (Properties.Settings.Default.Mode=="sql")
            {
                SQL.Checked = true;
                txtUserName.Text = Properties.Settings.Default.ID.ToString();
                txtPassWord.Text = Properties.Settings.Default.Password;
            }
            if (Properties.Settings.Default.Mode == "windows")
            {
                Windows.Checked = true;
                txtUserName.Text = "";
                txtPassWord.Text = "";
            }

        }
        public static LoginForm Instance
        {
            get
            {
                if (_obj == null)
                {
                    _obj = new LoginForm();
                }
                return _obj;
            }
        }
        public Panel PnlContainer
        {
            get { return panel_container; }
            set { panel_container = value; }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            String myCurrentLang = InputLanguage.CurrentInputLanguage.Culture.Name;
            if (myCurrentLang == "en-US")
            {
                btn_language_eng.Visible = true;
                btn_lag_ar.Visible = false;
            }
            else
            {
                btn_language_eng.Visible = false;
                btn_lag_ar.Visible = true;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            txtTimer.Text = DateTime.Now.ToLongTimeString();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

          
        }

        private void btn_language_eng_Click(object sender, EventArgs e)
        {

            InputLanguage.CurrentInputLanguage = InputLanguage.InstalledInputLanguages[1];
            btn_lag_ar.Visible = true;
            btn_language_eng.Visible = false;
        }

        private void btn_lag_ar_Click(object sender, EventArgs e)
        {
            InputLanguage.CurrentInputLanguage = InputLanguage.InstalledInputLanguages[0];
            btn_lag_ar.Visible = false;
            btn_language_eng.Visible = true;

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (passlogIn())
            {
                Saving();
            }
            logIn();
            
        }

        private Boolean userlogIn()
        {
            dataAccess.close();
            String userName = USERNAME.Text;
      


            mCommand = new SqlCommand("select userName from security",dataAccess.sqlconnections);
            dataAccess.open();
            dr = mCommand.ExecuteReader();
            while (dr.Read())
            {
                if (dr[0].ToString()==userName)
                {
                    return true;
                }


            }

            return false;

        }
        private Boolean passlogIn()
        {
            if (userlogIn())
            {
                dataAccess.close();
                String userName = USERNAME.Text;


                String passWord = txtpass.Text;


                mCommand = new SqlCommand("select Password from security where username='" + userName + "'", dataAccess.sqlconnections);
                dataAccess.open();
                dr = mCommand.ExecuteReader();
                while (dr.Read())
                {
                    if (dr[0].ToString() == passWord)
                    {
                        
                        return true;

                    }


                }

            }


            return false;

        }



        void logIn()
        {
            if (!passlogIn())
            {
                label5.Text = "خطأ في اسم المستخدم او كلمة المرور";
            }

            else
            {
                adminName = "Mostafa";
                th = new Thread(openn);
                th.SetApartmentState(ApartmentState.STA);


                this.Close();

                th.Start();

            }
           




        }
        void openn()
        {
            try
            {
                Application.Run(new dashBoard());
            }
            catch (Exception)
            {

                return;
            }



        }




        private void Saving()
        {
            if (checkBox2.Checked == true)
            {
                Properties.Settings.Default.mainAccount = USERNAME.Text;
                Properties.Settings.Default.mainPassword = txtpass.Text;
                Properties.Settings.Default.Save();

            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.CheckState == CheckState.Checked)
            {
                txtpass.isPassword = false;


            }
            else
            {
                txtpass.isPassword = true;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txtuser_Enter(object sender, EventArgs e)
        {
            if (txtUserName.Text== "اسم المستخدم")
            {
                txtUserName.Text = "";
            }
        }

        private void txtpass_Enter(object sender, EventArgs e)
        {

        }

        private void txtuser_OnValueChanged(object sender, EventArgs e)
        {
            label5.Text = "";
        }

        private void txtpass_OnValueChanged(object sender, EventArgs e)
        {

            label5.Text = "";
        }

        private void txtpass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                button1.PerformClick();
            }

      
        }

        private void txtuser_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                txtpass.Focus();
                txtpass.Select();
  
            }
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            
            panelServerSettings.Visible = false;
            panelLogin.Visible = true;
        }

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //    if (guna2ComboBox1.Text== "SQL Server Authentication")
            //    {
            //        txtUserName.Enabled = true;
            //        txtPassWord.Enabled = true;
            //    }
            //    else
            //    {
            //        txtUserName.Enabled = false;
            //        txtPassWord.Enabled = false;
            //    }
        }

        private void SQL_CheckedChanged(object sender, EventArgs e)
        {
            if (SQL.Checked==true)
            {
                txtUserName.Enabled = true;
                txtPassWord.Enabled = true;
            }
        }

        private void Windows_CheckedChanged(object sender, EventArgs e)
        {
            if (Windows.Checked==true)
            {
                txtUserName.Enabled = false;
                txtPassWord.Enabled = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Windows.Checked==true)
            {
                Properties.Settings.Default.Mode = "windows";
                Properties.Settings.Default.Server = serverName.Text;
                Properties.Settings.Default.DataBase = txtDataBase.Text;

                Properties.Settings.Default.Save();


            }
            else if (SQL.Checked == true)
            {
                Properties.Settings.Default.Mode = "sql";
                Properties.Settings.Default.Server = serverName.Text;
                Properties.Settings.Default.DataBase = txtDataBase.Text;
                Properties.Settings.Default.ID = txtUserName.Text;
                Properties.Settings.Default.Password = txtPassWord.Text;
                Properties.Settings.Default.Save();


            }
            label8.Visible = true;
        }

        private void bunifuFlatButton5_Click(object sender, EventArgs e)
        {
            bunifuFlatButton1.Normalcolor = Color.FromArgb(5, 40, 100);
            panelServerSettings.Visible = true;
            panelLogin.Visible = false;
        }
    }
}
