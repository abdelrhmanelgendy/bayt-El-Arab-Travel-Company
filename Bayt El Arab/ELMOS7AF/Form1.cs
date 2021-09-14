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
    public partial class dashBoard : Form
    {
        
        int x = 0;
        static dashBoard _obj;
        Boolean PANEL_COLLAPCING = true;

        Thread th;
        DataTable mDataTable = new DataTable();
        SqlCommand mCommand;
        SqlDataAdapter mDataAdapter = new SqlDataAdapter();
        DataAccess dataAccess = new DataAccess();
        SqlDataReader dr;


        public dashBoard()
        {
            InitializeComponent();
            PersenceAndApsence user1 = new PersenceAndApsence();
            user1.Dock = DockStyle.Fill;
            panel_container.Controls.Add(user1);
            main_panel_optionbuttons.Width = 51;
            x = 1;
            disableName();

            _obj = this;
        }

        public static dashBoard Instance
        {
            get
            {
                if (_obj == null)
                {
                    _obj = new dashBoard();
                }
                return _obj;
            }
        }
        public Panel PnlContainer
        {
            get { return panel_container; }
            set { panel_container = value; }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            txtTimer.Text = DateTime.Now.ToLongTimeString();
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

        private void btn_HomeMenue_Click(object sender, EventArgs e)
        {
            PersenceAndApsence.mainUserControlupdated = true;
            if (x == 0)
            {
                _obj = this;
                PersenceAndApsence user1 = new PersenceAndApsence();
                user1.Dock = DockStyle.Fill;
                panel_container.Controls.Add(user1);
                x = 1;
            }

            else if (x == 1)
            {
                if (!dashBoard.Instance.PnlContainer.Controls.ContainsKey("PersenceAndApsence"))
                {
                    PersenceAndApsence un = new PersenceAndApsence();
                    un.Dock = DockStyle.Fill;
                    dashBoard.Instance.PnlContainer.Controls.Add(un);
                }
                dashBoard.Instance.PnlContainer.Controls["PersenceAndApsence"].BringToFront();


            }
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

            if (PANEL_COLLAPCING)
            {
                pictureBox4.Visible = true;

                main_panel_optionbuttons.Width = 140;
                PANEL_COLLAPCING = false;
                enableName();
            }
            else
            {
                pictureBox4.Visible = false;
                main_panel_optionbuttons.Width = 51;
                PANEL_COLLAPCING = true;

                disableName();


            }
        }
        void disableName()
        {
            foreach (Bunifu.Framework.UI.BunifuFlatButton item in panel_buttons.Controls)
            {
                item.Text = "";
            }
          


        }
        void enableName()
        {

            btn_HomeMenue.Text = "الرئيسيه";
            bunifuFlatButton1.Text = "اضافة عميل";
            bunifuFlatButton2.Text = "مدفوعات العملاء";
            bunifuFlatButton3.Text = "الخزينه";
            bunifuFlatButton4.Text = "تسجيل الخروج";
            bunifuFlatButton5.Text = "الاعدادات";
            
            bunifuFlatButton7.Text = "تعديل البيانات";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
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


       

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            addnewClient.addBeginAdded = true;

                

                if (x == 0)
                {
                    _obj = this;
                    addnewClient user1 = new addnewClient();
                    user1.Dock = DockStyle.Fill;
                    panel_container.Controls.Add(user1);
                    x = 1;
                }

                else if (x == 1)
                {
                    if (!dashBoard.Instance.PnlContainer.Controls.ContainsKey("addnewClient"))
                    {
                        addnewClient un = new addnewClient();
                        un.Dock = DockStyle.Fill;
                        dashBoard.Instance.PnlContainer.Controls.Add(un);
                    }
                    dashBoard.Instance.PnlContainer.Controls["addnewClient"].BringToFront();


                }
            
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            PaymentUserControl.editBeginUpdate = true;

            if (x == 0)
            {
                _obj = this;
                PaymentUserControl user1 = new PaymentUserControl();
                user1.Dock = DockStyle.Fill;
                panel_container.Controls.Add(user1);
                x = 1;
            }

            else if (x == 1)
            {
                if (!dashBoard.Instance.PnlContainer.Controls.ContainsKey("PaymentUserControl"))
                {
                    PaymentUserControl un = new PaymentUserControl();
                    un.Dock = DockStyle.Fill;
                    dashBoard.Instance.PnlContainer.Controls.Add(un);
                }
                dashBoard.Instance.PnlContainer.Controls["PaymentUserControl"].BringToFront();


            }
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
          
        





        }

        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {

            th = new Thread(openn);
            th.SetApartmentState(ApartmentState.STA);


            this.Close();

            th.Start();






        }
        void openn()
        {

            Application.Run(new LoginForm());

        }

        private void panel_container_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuFlatButton5_Click(object sender, EventArgs e)
        {
            if (x == 0)
            {
                _obj = this;
                Settings user1 = new Settings();
                user1.Dock = DockStyle.Fill;
                panel_container.Controls.Add(user1);
                x = 1;
            }

            else if (x == 1)
            {
                if (!dashBoard.Instance.PnlContainer.Controls.ContainsKey("Settings"))
                {
                    Settings un = new Settings();
                    un.Dock = DockStyle.Fill;
                    dashBoard.Instance.PnlContainer.Controls.Add(un);
                }
                dashBoard.Instance.PnlContainer.Controls["Settings"].BringToFront();


            }


        }

        private void bunifuFlatButton6_Click(object sender, EventArgs e)
        {
            
        }

        private void bunifuFlatButton7_Click(object sender, EventArgs e)
        {
            editeclient.beingUpdate = true;
            if (x == 0)
            {
                _obj = this;
                editeclient user1 = new editeclient();
                user1.Dock = DockStyle.Fill;
                panel_container.Controls.Add(user1);
                x = 1;
            }

            else if (x == 1)
            {
                if (!dashBoard.Instance.PnlContainer.Controls.ContainsKey("editeclient"))
                {
                    editeclient un = new editeclient();
                    un.Dock = DockStyle.Fill;
                    dashBoard.Instance.PnlContainer.Controls.Add(un);
                }
                dashBoard.Instance.PnlContainer.Controls["editeclient"].BringToFront();


            }

        }

        private void panel_buttons_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuFlatButton3_Click_1(object sender, EventArgs e)
        {
            Valut.updating = true;
            checkDay();
            if (!checkDay())
            {
                
                createDay();
            }
            if (x == 0)
            {
                _obj = this;
                Valut user1 = new Valut();
                user1.Dock = DockStyle.Fill;
                panel_container.Controls.Add(user1);
                x = 1;
            }

            else if (x == 1)
            {
                if (!dashBoard.Instance.PnlContainer.Controls.ContainsKey("Valut"))
                {
                    Valut un = new Valut();
                    un.Dock = DockStyle.Fill;
                    dashBoard.Instance.PnlContainer.Controls.Add(un);
                }
                dashBoard.Instance.PnlContainer.Controls["Valut"].BringToFront();


            }
        }

        private void createDay()
        {
            string day = DateTime.Now.Day.ToString();
            string month = DateTime.Now.Month.ToString();
            string year = DateTime.Now.Year.ToString();

            string date = year + "-" + month + "-" + day;
            dataAccess.close();
            mCommand = new SqlCommand("select ending from [dbo].[daysRevenues] where id = (select max (id) from [dbo].[daysRevenues])",dataAccess.sqlconnections);
            dataAccess.open();
            dr = mCommand.ExecuteReader();
            dr.Read();
            double ending =Convert.ToDouble(dr[0].ToString());
            dataAccess.close();
            dr.Close();

            inserday(ending);


        }

        private void inserday(double ending)
        {
            dataAccess.close();
            string day = DateTime.Now.Day.ToString();
            string month = DateTime.Now.Month.ToString();
            string year = DateTime.Now.Year.ToString();

            string date = year + "-" + month + "-" + day;
            mCommand = new SqlCommand("insert into daysRevenues (date,starting,money) values ('"+date+"',"+ending+","+ending+")",dataAccess.sqlconnections);
            dataAccess.open();
            mCommand.ExecuteNonQuery();
            dataAccess.close();
               
             
        }

        private  bool checkDay()
        {
            string day = DateTime.Now.Day.ToString();
            string month = DateTime.Now.Month.ToString();
            string year = DateTime.Now.Year.ToString();

            string date = month + "/" + day + "/" + year;
            dataAccess.close();
            mCommand = new SqlCommand("select date from daysRevenues ",dataAccess.sqlconnections);
            dataAccess.open();
            dr = mCommand.ExecuteReader();
            while (dr.Read())
            {
                DateTime dat = DateTime.Parse(dr[0].ToString());
                if (dat.ToShortDateString().Equals(date))
                {

                    return true;
                }

            }
            return false;





        }
    }
}
