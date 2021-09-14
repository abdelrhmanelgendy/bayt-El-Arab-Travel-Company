using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ELMOS7AF.UserControls
{
    public partial class reporting : Form
    {
        DataTable mDataTable = new DataTable();
        SqlCommand mCommand;
        SqlDataAdapter mDataAdapter = new SqlDataAdapter();
        DataAccess dataAccess = new DataAccess();
        public static string SQLSTATEMENT;
        public reporting()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            mDataTable.Clear();
            mDataAdapter = new SqlDataAdapter(SQLSTATEMENT, dataAccess.sqlconnections);

       

            this.mDataAdapter.Fill(this.baytElArabDataSet.Payments);
       reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

     

        }

        private void studentsTableBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void baytElArabDataSetBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void PaymentsBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}
