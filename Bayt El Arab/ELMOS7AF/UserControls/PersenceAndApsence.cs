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
    public partial class PersenceAndApsence : UserControl
    {

        DataTable mDataTable = new DataTable();
        SqlCommand mCommand;
        SqlDataAdapter mDataAdapter = new SqlDataAdapter();
        DataAccess dataAccess = new DataAccess();
        SqlDataReader dr;
        internal static bool mainUserControlupdated=false;

        public PersenceAndApsence()
        {
            InitializeComponent();
            fillGrid();
          
        }

        private void fillGrid()
        {
            mDataTable.Clear();
            mDataAdapter = new SqlDataAdapter("select id As الكود ,name As اسم_العميل  ,tottalMoney As اجمالي_المطلوب ,paid As المبلغ_الدفوع,remains As الباقي ,addedAt As تاريخ_الاضافه from clients   order by id DESC", dataAccess.sqlconnections);
            mDataAdapter.Fill(mDataTable);
            gridData.DataSource = mDataTable;
            gridSetup();
            
        }

        void gridSetup()
        {
            foreach (DataGridViewColumn c in gridData.Columns)
            {
                c.DefaultCellStyle.Font = new Font("Arial", 18F, GraphicsUnit.Pixel);

            }
            




            gridData.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            gridData.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(5, 40, 100);
            gridData.EnableHeadersVisualStyles = false;
            gridData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            gridData.ColumnHeadersHeight = 35;


            gridData.Columns[0].Width = 70;
            gridData.Columns[1].Width = 200;
            gridData.Columns[2].Width = 100;
            this.gridData.Columns[3].Width = 100;
            this.gridData.Columns[4].Width = 100;
            this.gridData.Columns[5].Width = 100;

            //this.gridData.Columns[6].Width = 100;
            //this.gridData.Columns[7].Width = 100;
            //this.gridData.Columns[8].Width = 100;


            this.gridData.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
      
            this.gridData.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.gridData.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
    


            recollectdata();


        }

        double gettottal()
        {

            double tottal = 0;
            for (int i = 0; i < gridData.Rows.Count; i++)
            {
                tottal = tottal + Convert.ToDouble(gridData.Rows[i].Cells[2].Value.ToString());
            }
            return tottal;
        }
        double getreamins()
        {

            double tottal = 0;
            for (int i = 0; i < gridData.Rows.Count; i++)
            {
                tottal = tottal + Convert.ToDouble(gridData.Rows[i].Cells[3].Value.ToString());
            }
            return tottal;
        }
        double getpaid()
        {

            double tottal = 0;
            for (int i = 0; i < gridData.Rows.Count; i++)
            {
                tottal = tottal + Convert.ToDouble(gridData.Rows[i].Cells[4].Value.ToString());
            }
            return tottal;
        }

        void recollectdata()
        {
            double tottal = gettottal();
            double paid = getpaid();
            double remains = getreamins();

            lbltottal.Text = tottal.ToString();
            lblpaid.Text = paid.ToString();
            lblremains.Text = remains.ToString();

            lblarpaid.Text= N2C.ConvertN2C.ConvertNow(paid, "جنيه", "قرش");
            lblarremains.Text = N2C.ConvertN2C.ConvertNow(remains, "جنيه", "قرش");
            lblartottal.Text = N2C.ConvertN2C.ConvertNow(tottal, "جنيه", "قرش");

        }

        private void guna2ToggleSwitch1_CheckedChanged(object sender, EventArgs e)
        {
            if (guna2ToggleSwitch1.Checked==true)
            {
                tableLayoutPanel1.Visible = true;
            }
            else
            {
                tableLayoutPanel1.Visible = false;
            }
        }

        private void txtsearch_Enter(object sender, EventArgs e)
        {
            if (txtsearch.Text== "ابحث هنا")
            {
                txtsearch.Text = "";
            }
        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            if (txtsearch.Text != "")
            {
                search();
            }
            else
            {
                fillGrid();

            }
        }

        private void search()
        {
            String searchTittle = txtsearch.Text;
            Boolean containsDigits = searchTittle.All(char.IsDigit);

            //if (containsDigits)
            //{
            //    double id = Convert.ToDouble(searchTittle);

            //        searchById(id);



            //}
            //else if (!containsDigits)
            //{
            if (idsearch.Checked==true)
            {
                if (containsDigits)
                {
                    searchById(Convert.ToInt32(txtsearch.Text));


                }
                else if (!containsDigits)
                {
                    searchByName(searchTittle);
                }
                   
            }
            else
            {
                searchByName(searchTittle);
            }
              
            //}
        }

        private void searchByName(string searchTittle)
        {
            mDataTable.Clear();
            mDataAdapter = new SqlDataAdapter("select id As الكود ,name As اسم_العميل  ,tottalMoney As اجمالي_المطلوب ,paid As المبلغ_الدفوع,remains As الباقي ,addedAt As تاريخ_الاضافه  from clients where name+ssd+phone+address+convert(varchar, tottalMoney)+convert(varchar, paid)+convert(varchar, remains)+convert(varchar, id) like '%" + searchTittle+"%' ", dataAccess.sqlconnections);
            mDataAdapter.Fill(mDataTable);
            gridData.DataSource = mDataTable;
            gridSetup();

        }

        private void searchById(double id)
        {
            mDataTable.Clear();
            mDataAdapter = new SqlDataAdapter("select id As الكود ,name As اسم_العميل  ,tottalMoney As اجمالي_المطلوب ,paid As المبلغ_الدفوع,remains As الباقي ,addedAt As تاريخ_الاضافه from clients where id = " + id + "", dataAccess.sqlconnections);
            mDataAdapter.Fill(mDataTable);
            gridData.DataSource = mDataTable;
            gridSetup();
        }

        private void idsearch_CheckedChanged(object sender, EventArgs e)
        {
            txtsearch.Text = "";
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (mainUserControlupdated==true)
            {
                fillGrid();
                mainUserControlupdated = false;
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
