using ELMOS7AF.UserControls;
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

namespace ELMOS7AF
{
    public partial class notes : Form
    {

        DataTable mDataTable = new DataTable();
        SqlCommand mCommand;
        SqlDataAdapter mDataAdapter = new SqlDataAdapter();
        DataAccess dataAccess = new DataAccess();
        SqlDataReader dr;
        int id = PaymentUserControl.mainId;
        public notes()
        {
            InitializeComponent();

            gettext();
        }

        private void gettext()
        {
            mCommand = new SqlCommand("select annotations from payments where Autoid ="+id+"",dataAccess.sqlconnections);
            dataAccess.open();
            dr = mCommand.ExecuteReader();
            dr.Read();
            textBox1.Text = dr[0].ToString();

            dr.Close();
            dataAccess.close();
            txtStudentName.Text = PaymentUserControl.name;

        }
        Boolean AutoCollapsing=true;
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            AutoCollapsing = false;
            this.Close();
        }

        private void notes_Deactivate(object sender, EventArgs e)
        {
            if (AutoCollapsing)
            {
                System.Media.SystemSounds.Exclamation.Play();

                this.Close();
            }
        }
    }
}
