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
    public partial class PaymentUserControl : UserControl
    {
        public static bool editBeginUpdate = false;

        DataTable mDataTable = new DataTable();
        SqlCommand mCommand;
        SqlDataAdapter mDataAdapter = new SqlDataAdapter();
        DataAccess dataAccess = new DataAccess();
        SqlDataReader dr;
        DataTable dt = new DataTable();
        public static int mainId;
        public static string name;
        string statement;
        public PaymentUserControl()
        {
            InitializeComponent();
            fillGride();

          


        }

        private void fillGride()
        {
            mDataTable.Clear();
            mDataAdapter = new SqlDataAdapter ("select Autoid,id as كود_العميل, Name as اسم_العميل ,date As تاريخ_الدفع ,amount As المبلغ_المدفوع from payments  order by autoid Desc  ", dataAccess.sqlconnections);
            mDataAdapter.Fill(mDataTable);
            statement= "select *  from payments order by autoid Desc  ";
            gridData.DataSource = mDataTable;
            gridSetup();
        }
        void gridSetup()
        {
            foreach (DataGridViewColumn c in gridData.Columns)
            {
                c.DefaultCellStyle.Font = new Font("tahoma", 18F, GraphicsUnit.Pixel);
             
            }
            gridData.Columns[0].Visible = false;
    
            
        

            gridData.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            gridData.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(5, 40, 100);
            gridData.EnableHeadersVisualStyles = false;
            gridData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            gridData.ColumnHeadersHeight = 35;


            gridData.Columns[1].Width = 100;
            gridData.Columns[2].Width = 250;
            gridData.Columns[3].Width = 150;
            this.gridData.Columns[4].Width = 150;
            

            this.gridData.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.gridData.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.gridData.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.gridData.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            if (txtsearch.Text=="")
            {
                fillGride();
            }
            else
            {
                
                search();
            }
        }

        private void search()
        {

            String searchTittle = txtsearch.Text;
            Boolean containsDigits = searchTittle.All(char.IsDigit);

            //if (containsDigits)
            //{
            //    double id = Convert.ToDouble(searchTittle);
            //    searchByID(id);

            //}
            //else if (!containsDigits)
            //{
                searchByName(searchTittle);
            //}
   
        }

        //private void searchByID(double id)
        //{
        //    mDataTable.Clear();
        //    mDataAdapter = new SqlDataAdapter("select Autoid,id as كود_العميل, Name as اسم_العميل ,date As تاريخ_الدفع ,amount As المبلغ_المدفوع from payments  where id = " + id + " order by autoid Desc ", dataAccess.sqlconnections);
        //    mDataAdapter.Fill(mDataTable);
        //    statement = "select * from payments  where id = " + id + " order by autoid Desc ";
        //    gridData.DataSource = mDataTable;
        //    gridSetup();
        //}

        private void searchByName(string searchTittle)
        {
            mDataTable.Clear();
            mDataAdapter = new SqlDataAdapter("select Autoid,id as كود_العميل, Name as اسم_العميل ,date As تاريخ_الدفع ,amount As المبلغ_المدفوع from payments  where name+convert(varchar, id)+convert(varchar, amount) like '%" + txtsearch.Text+ "%' order by autoid Desc ", dataAccess.sqlconnections);
            mDataAdapter.Fill(mDataTable);
            statement = "select * from payments  where name like '%" + txtsearch.Text + "%' order by autoid Desc ";

            gridData.DataSource = mDataTable;
            gridSetup();
        }

        private void txtsearch_Enter(object sender, EventArgs e)
        {
            if (txtsearch.Text=="ابحث هنا")
            {
                txtsearch.Text = "";
            }
        }

        private void gridData_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
           mainId =Convert.ToInt32( gridData.CurrentRow.Cells[0].Value.ToString());
            name= gridData.CurrentRow.Cells[2].Value.ToString();
            new notes().Show();
                
        }

        private void gunaDateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            txtsearch.Clear();
            string date = gunaDateTimePicker1.Value.ToShortDateString();
            searchbyDate(date);
        }

        private void searchbyDate(string date)
        {
            mDataTable.Clear();
            mDataAdapter = new SqlDataAdapter("select Autoid,id as كود_العميل, Name as اسم_العميل ,date As تاريخ_الدفع ,amount As المبلغ_المدفوع from payments   where date = '" + date + "' order by autoid Desc ", dataAccess.sqlconnections);
            mDataAdapter.Fill(mDataTable);
            statement = "select * from payments   where date = '" + date + "' order by autoid Desc ";
            gridData.DataSource = mDataTable;
            gridSetup();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (editBeginUpdate)
            {
                fillGride();
                editBeginUpdate = false;
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {

            reporting.SQLSTATEMENT = statement;
            new reporting().Show();
           
        }
    }
}
