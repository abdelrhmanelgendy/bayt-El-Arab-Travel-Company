using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ELMOS7AF.UserControls
{
    public partial class Valut : UserControl
    {
        DataTable mDataTable = new DataTable();
        SqlCommand mCommand;
        SqlDataAdapter mDataAdapter = new SqlDataAdapter();
        DataAccess dataAccess = new DataAccess();
        SqlDataReader dr;
        public Valut()
        {
            InitializeComponent();
            txtmoney.MaxLength = 6;
            fillGride();
            getmoney();
            completeNotes();
        }

        public void fillGride()
        {
            string date = DateTime.Now.ToShortDateString();
            mDataTable.Clear();
            mDataAdapter = new SqlDataAdapter("select amount As المبلغ,type As [نوع العمليه],date As[ تاريخ العمليه ],time As[ وقت العمليه ],safeAdmin As المسؤل ,annotations As [ملحوظات]  from Revenues where date ='"+date+"' order by id Desc ",dataAccess.sqlconnections);
            mDataAdapter.Fill(mDataTable);
            paymentsGride.DataSource=mDataTable;
            gridSetup();
        }
        public void getmoney()
        {

            dataAccess.close();
            string day = DateTime.Now.Day.ToString();
            string month = DateTime.Now.Month.ToString();
            string year = DateTime.Now.Year.ToString();

            string date = year + "-" + month + "-" + day;

            mCommand = new SqlCommand("select money  from daysRevenues  where date ='"+date+"'", dataAccess.sqlconnections);
            dataAccess.open();
            dr = mCommand.ExecuteReader();
            dr.Read();
     
            txtAmount.Text =dr[0].ToString() ;
            txtremains.Text = dr[0].ToString();
            lbltottal.Text = convertToAr(dr[0].ToString());
            lblremains.Text = convertToAr(dr[0].ToString());
            dr.Close();
            dataAccess.close();
 



        }
        public string convertToAr(string amount)
        {
            if (amount!="")
            {
                return N2C.ConvertN2C.ConvertNow(Convert.ToDouble(amount), "جنيه", "قرش");
            }
            else
            {
                return "";
            }
           

        }


        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void txttottalmoney_TextChanged(object sender, EventArgs e)
        {
            


        }


        void gridSetup()
        {

            if (ispaid.Checked == true)
            {
                for (int i = 0; i < paymentsGride.Rows.Count; i++)
                {
                    try
                    {
                        if (paymentsGride.Rows[i].Cells[1].Value.ToString() == "سحب")
                        {
                            paymentsGride.Rows[i].DefaultCellStyle.BackColor = Properties.Settings.Default.paid;


                        }
                        else
                        {
                            paymentsGride.Rows[i].DefaultCellStyle.BackColor = Properties.Settings.Default.nopaid;
                        }
                    }
                    catch (Exception)
                    {

                        return;
                    }


                }
            }


            foreach (DataGridViewColumn c in paymentsGride.Columns)
            {
                c.DefaultCellStyle.Font = new Font("tahoma", 18F, GraphicsUnit.Pixel);

            }

            paymentsGride.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            paymentsGride.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(5, 40, 100);
            paymentsGride.EnableHeadersVisualStyles = false;
            paymentsGride.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            paymentsGride.ColumnHeadersHeight = 35;

            paymentsGride.RowTemplate.Height = 30;
            paymentsGride.Columns[0].Width = 80;
            paymentsGride.Columns[1].Width = 100;
            paymentsGride.Columns[2].Width = 100;
            this.paymentsGride.Columns[3].Width = 100;
            this.paymentsGride.Columns[4].Width = 100;
            this.paymentsGride.Columns[5].Width = 250;

            this.paymentsGride.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.paymentsGride.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.paymentsGride.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.paymentsGride.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.paymentsGride.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

        }

        private void txtmoney_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) & e.KeyChar != 8 & e.KeyChar != 46)
            {
                e.Handled = true;
            }
        }

        private void txtmoney_Click(object sender, EventArgs e)
        {
           
        }

        private void txtmoney_TextChanged(object sender, EventArgs e)
        {
            if (radioincome.Checked==true)
            {
                lblmoney.Text = convertToAr(txtmoney.Text);
                double paid = 0;

                if (txtmoney.Text != "")
                {
                    paid = Convert.ToDouble(txtmoney.Text);

                }
                double tottal = (Convert.ToDouble(txtAmount.Text) + paid);

                txtremains.Text = tottal + "";
                lblremains.Text = convertToAr(tottal.ToString());
            }
       else     if (radiooutcome.Checked == true)
            {
                lblmoney.Text = convertToAr(txtmoney.Text);
                double paid = 0;

                if (txtmoney.Text != "")
                {
                    paid = Convert.ToDouble(txtmoney.Text);

                }
                double tottal = (Convert.ToDouble(txtAmount.Text) - paid);

                txtremains.Text = tottal + "";
                lblremains.Text = convertToAr(tottal.ToString());
            }






        }

        void completeNotes()
        {
            dataAccess.close();
            mCommand = new SqlCommand("select annotations from Revenues ", dataAccess.sqlconnections);
            dataAccess.open();
            dr = mCommand.ExecuteReader();


            AutoCompleteStringCollection mySource = new AutoCompleteStringCollection();
            while (dr.Read())
            {
                mySource.Add(dr[0].ToString());
            }
            txtnotes.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txtnotes.AutoCompleteCustomSource = mySource;
            txtnotes.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            dataAccess.close();
            dr.Close();
        }

        private void btnexecute_Click(object sender, EventArgs e)
        {
            if (txtmoney.Text=="")
            {
                MessageBox.Show("يحب ادخال المبلغ اولا ","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                txtmoney.Focus();
                return;
            }
            if (Convert.ToDouble(txtremains.Text)<0)
            {
                MessageBox.Show("مبلغ غير صحيح", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtmoney.Focus();
                txtmoney.SelectAll();
                return;
            }
            insertRevenues();
            update();
            completeNotes();
            getmoney();
            clear();
            fillGride();

        }

        private void clear()
        {
            txtmoney.Clear();
            txtnotes.Clear();

        }

        private void update()
        {
          
            if (radiooutcome.Checked==true)
            {
                //outcome 
                //خوارج
                outComeUpdate();



            }
            if (radioincome.Checked == true)
            {
                //income 
                //واردات
               inComeUpdate();

            }



        }

        private void inComeUpdate()
        {
            string day = DateTime.Now.Day.ToString();
            string month = DateTime.Now.Month.ToString();
            string year = DateTime.Now.Year.ToString();

            string date = year + "-" + month + "-" + day;

            double tottal = Convert.ToDouble(txtremains.Text);
            double amount = Convert.ToDouble(txtmoney.Text);
            double income = 0;

            dataAccess.close();
            mCommand=new  SqlCommand("select incomes from daysRevenues where date ='"+date+"'",dataAccess.sqlconnections);
            dataAccess.open();
            dr = mCommand.ExecuteReader();
            dr.Read();
            if (dr[0].ToString()!="")
            {
                income = Convert.ToDouble(dr[0].ToString());
            }
            double finalIncome = income + amount;


            dataAccess.close();

            mCommand = new SqlCommand("update daysRevenues set money ="+tottal+",incomes ="+ finalIncome + ",ending ="+tottal+" where date ='"+date+"'",dataAccess.sqlconnections) ;
            dataAccess.open();
            mCommand.ExecuteNonQuery();
            dataAccess.close();




        }

        private void outComeUpdate()
        {
            string day = DateTime.Now.Day.ToString();
            string month = DateTime.Now.Month.ToString();
            string year = DateTime.Now.Year.ToString();

            string date = year + "-" + month + "-" + day;

            double tottal = Convert.ToDouble(txtremains.Text);
            double amount = Convert.ToDouble(txtmoney.Text);
            double income = 0;

            dataAccess.close();
            mCommand = new SqlCommand("select outcome from daysRevenues where date ='" + date + "'", dataAccess.sqlconnections);
            dataAccess.open();
            dr = mCommand.ExecuteReader();
            dr.Read();
            if (dr[0].ToString() != "")
            {
                income = Convert.ToDouble(dr[0].ToString());
            }
            double finalIncome = income + amount;


            dataAccess.close();

            mCommand = new SqlCommand("update daysRevenues set money =" + tottal + ",outcome =" + finalIncome + ",ending =" + tottal + " where date ='" + date + "'", dataAccess.sqlconnections);
            dataAccess.open();
            mCommand.ExecuteNonQuery();
            dataAccess.close();
        }

        private void insertRevenues()
        {
            string type;
            double amount = Convert.ToDouble(txtmoney.Text);
            if (getType()==null)
            {
                MessageBox.Show("برجاء اختيار نوع العمليه ", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                type = getType();
            }
        
            string notess = txtnotes.Text;
            string date = DateTime.Now.ToShortDateString();
            string hourse = DateTime.Now.Hour.ToString();
            string minutes = DateTime.Now.Minute.ToString();
            string time = DateTime.Now.ToShortTimeString();
            string admin = txtAdmin.Text;
            mCommand = new SqlCommand(@"insert into Revenues (amount,type,annotations,date,hours,minuts,time,safeAdmin) values 
                ("+amount+",'"+type+"','"+notess+ "','"+date+ "','"+hourse+ "','"+minutes+ "','"+time+ "','"+admin+"')",dataAccess.sqlconnections);
            dataAccess.open();
            mCommand.ExecuteNonQuery();
            dataAccess.close();
            //fillGride();
        }

        private string getType()
        {
            if (radioincome.Checked==true)
            {
                return "ايداع";
            }
            else if(radiooutcome.Checked == true)
            {
                return "سحب";
            }
            else
            {
               
                return null;
            }
        }

        private void radiooutcome_CheckedChanged(object sender, EventArgs e)
        {
            lblmoney.Text = convertToAr(txtmoney.Text);
            double paid = 0;

            if (txtmoney.Text != "")
            {
                paid = Convert.ToDouble(txtmoney.Text);

            }
            double tottal = (Convert.ToDouble(txtAmount.Text) - paid);

            txtremains.Text = tottal + "";
            lblremains.Text = convertToAr(tottal.ToString());
        }

        private void radioincome_CheckedChanged(object sender, EventArgs e)
        {
            lblmoney.Text = convertToAr(txtmoney.Text);
            double paid = 0;

            if (txtmoney.Text != "")
            {
                paid = Convert.ToDouble(txtmoney.Text);

            }
            double tottal = (Convert.ToDouble(txtAmount.Text) + paid);

            txtremains.Text = tottal + "";
            lblremains.Text = convertToAr(tottal.ToString());
        }

        private void paymentsGride_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            MessageBox.Show(paymentsGride.CurrentRow.Cells[5].Value.ToString(),"",MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
        }
        public static bool updating=false;
        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            if (txtsearch.Text=="")
            {
                fillGride();
            }
            else
            {
                Search();
            }
        }

        private void Search()
        {
            String searchTittle = txtsearch.Text;
            Boolean containsDigits = searchTittle.All(char.IsDigit);

            if (containsDigits)
            {
                double amount = Convert.ToDouble(txtsearch.Text);

                searchByAount(amount);



            }
            else if (!containsDigits)
            {
                searchByname();
            }
               
            }

        private void searchByAount(double amount)
        {
            

            mDataTable.Clear();

            mDataAdapter = new SqlDataAdapter("select amount As المبلغ,type As [نوع العمليه],date As[ تاريخ العمليه ],time As[ وقت العمليه ],safeAdmin As المسؤل ,annotations As [ملحوظات]  from Revenues where amount like '%"+amount+"%'  order by id Desc ", dataAccess.sqlconnections);
            mDataAdapter.Fill(mDataTable);
            paymentsGride.DataSource = mDataTable;
            gridSetup();
        }

        private void searchByname()
        {
            string name = txtsearch.Text.Trim();

            mDataTable.Clear();
            
            mDataAdapter = new SqlDataAdapter("select amount As المبلغ,type As [نوع العمليه],date As[ تاريخ العمليه ],time As[ وقت العمليه ],safeAdmin As المسؤل ,annotations As [ملحوظات]  from Revenues where safeadmin+annotations like '%"+name+"%'  order by id Desc ", dataAccess.sqlconnections);
            mDataAdapter.Fill(mDataTable);
            paymentsGride.DataSource = mDataTable;
            gridSetup();
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            string date = dateTimePicker2.Value.ToShortDateString();
            mDataTable.Clear();
            mDataAdapter = new SqlDataAdapter("select amount As المبلغ,type As [نوع العمليه],date As[ تاريخ العمليه ],time As[ وقت العمليه ],safeAdmin As المسؤل ,annotations As [ملحوظات]  from Revenues where date ='" + date + "' order by id Desc ", dataAccess.sqlconnections);
            mDataAdapter.Fill(mDataTable);
            paymentsGride.DataSource = mDataTable;
            gridSetup();
        }

        private void txtsearch_Enter(object sender, EventArgs e)
        {
            if (txtsearch.Text== "ابحث هنا")
            {
                txtsearch.Text = "";
            }
            radioAll.Checked = true;
        }

        private void radioWithdraw_CheckedChanged(object sender, EventArgs e)
        {
            
            string date = dateTimePicker2.Value.ToShortDateString();
            mDataTable.Clear();
            mDataAdapter = new SqlDataAdapter("select amount As المبلغ,type As [نوع العمليه],date As[ تاريخ العمليه ],time As[ وقت العمليه ],safeAdmin As المسؤل ,annotations As [ملحوظات]  from Revenues where date ='" + date + "' and type = 'ايداع' order by id Desc", dataAccess.sqlconnections);
            mDataAdapter.Fill(mDataTable);
            paymentsGride.DataSource = mDataTable;
            gridSetup();
        }

        private void radioDeposite_CheckedChanged(object sender, EventArgs e)
        {

            string date = dateTimePicker2.Value.ToShortDateString();
            mDataTable.Clear();
            mDataAdapter = new SqlDataAdapter("select amount As المبلغ,type As [نوع العمليه],date As[ تاريخ العمليه ],time As[ وقت العمليه ],safeAdmin As المسؤل ,annotations As [ملحوظات]  from Revenues where date ='"+date+"' and type ='سحب' order by id Desc", dataAccess.sqlconnections);
            mDataAdapter.Fill(mDataTable);
            paymentsGride.DataSource = mDataTable;
            gridSetup();
        }

        private void radioAll_CheckedChanged(object sender, EventArgs e)
        {
            string date = dateTimePicker2.Value.ToShortDateString();
            mDataTable.Clear();
            mDataAdapter = new SqlDataAdapter("select amount As المبلغ,type As [نوع العمليه],date As[ تاريخ العمليه ],time As[ وقت العمليه ],safeAdmin As المسؤل ,annotations As [ملحوظات]  from Revenues where date ='" + date + "'  order by id Desc", dataAccess.sqlconnections);
            mDataAdapter.Fill(mDataTable);
            paymentsGride.DataSource = mDataTable;
            gridSetup();
        }

        private void dateTimePicker2_Enter(object sender, EventArgs e)
        {
            txtsearch.Clear();
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            if (updating==true  )
            {

                fillGride();
                getmoney();
                updating = false;
            }
        }

        private void ispaid_CheckedChanged(object sender, EventArgs e)
        {
            txtsearch.Text = "";
            fillGride();
        }
    }
}
