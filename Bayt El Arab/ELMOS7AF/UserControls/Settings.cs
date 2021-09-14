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
using System.IO;

namespace ELMOS7AF.UserControls
{
    public partial class Settings : UserControl
    {
        
        DataTable mDataTable = new DataTable();
        SqlCommand mCommand;
        public SqlDataAdapter mDataAdapter = new SqlDataAdapter();
        DataAccess dataAccess = new DataAccess();
        SqlDataReader dr;
        public DataTable dt = new DataTable();
        public Settings()
        {
            InitializeComponent();
            txtpath.Text = Properties.Settings.Default.ImagesPath;
       
            label7.Text = "" + DateTime.Now.ToLongDateString() + "  " + DateTime.Now.ToLongTimeString().Replace(':', '-');
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {

            Properties.Settings.Default.ImagesPath = txtpath.Text;

            Properties.Settings.Default.Save();

            label4.Text = "تم حفظ الاعدادات برجاء اعادة تشغيل البرنامج";
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
 

            Properties.Settings.Default.cellColor = Color.FromArgb(48, 79, 254);
            Properties.Settings.Default.paid = Color.FromArgb(38, 63, 89);
            Properties.Settings.Default.nopaid = Color.FromArgb(255, 255, 0);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtuser.Text=="")
            {
                label5.Text = "اسم المستخدم فارغ";
            }
            else
            {

           
            if (txtuserValidation()&&txtpassValidation()&&txtpassconfirmValidation())
            {
                    dataAccess.close();
                    String userName = txtuser.Text;
                    String passWord = txtpass.Text;
                    mCommand = new SqlCommand("Insert into security(userName,Password) values('"+userName+"','"+passWord+"')", dataAccess.sqlconnections);
                    dataAccess.open();
                    mCommand.ExecuteNonQuery();
                    label5.Text = "تم انشاء حساب جديد بنجاح";
                    dataAccess.close();
                }
            }

        }




        Boolean txtuserValidation()
        {
            dataAccess.close();
            String userName = txtuser.Text;
            String passord = txtpass.Text;
        
                mCommand = new SqlCommand("select UserName from security", dataAccess.sqlconnections);
                dataAccess.open();
                dr = mCommand.ExecuteReader();
                while (dr.Read())
                {
                    if (dr[0].ToString() == userName)
                    {
                    label5.Text = "اسم المستخدم موجود بالفعل";
                        return false;
                    }
                }
              
            


            return true;




        }


        Boolean txtpassValidation()
        {
            String userName = txtuser.Text;
            String passord = txtpass.Text;
            if (txtpass.Text=="")
            {
                label5.Text = "كلمة المرور فارغه";
                txtpass.Focus();
                return false;

            }
            else if(passord.Length<6)
            {
                label5.Text = "كلمة المرور يجب ان تتعدي ال6 حروف";
                txtpass.Focus();
                return false;
            }
            else
            {
                return true;
            }


        }
        Boolean txtpassconfirmValidation()
        {
            if (txtpass.Text==txtPassConfirm.Text)
            {
                return true;
            }
            else
            {
                return false;
            }


        }
        private void txtPassConfirm_OnValueChanged(object sender, EventArgs e)
        {
            String pass = txtpass.Text;
            String passConform = txtPassConfirm.Text;
            if (pass!=passConform)
            {
                label5.Text = "كلمتا المرور غير متطابقتين";
            }
            else
            {
                label5.Text = "";
            }
        }

        private void txtpass_OnValueChanged(object sender, EventArgs e)
        {
            if (txtPassConfirm.Text!="")
            {
                String pass = txtpass.Text;
                String passConform = txtPassConfirm.Text;
                if (pass != passConform)
                {
                    label5.Text = "كلمتا المرور غير متطابقتين";
                }
                else
                {
                    label5.Text = "";
                }
            }
        }

        private void showpassword_CheckedChanged(object sender, EventArgs e)
        {
            if (showpassword.Checked == true)
            {
                txtpass.isPassword = false;
                txtPassConfirm.isPassword = false;
            }
            if (showpassword.Checked == false)
            {
                txtpass.isPassword = true;
                txtPassConfirm.isPassword = true;
            }
        }

        private void txtPassConfirm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData==Keys.Enter)
            {
                btnRegister.PerformClick();
            }
        }

        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {
            
            SaveFileDialog save1 = new SaveFileDialog();
            save1.Filter = "BackUpFile (*.Bak) |*.BAK";
         
            save1.FileName = "" + DateTime.Now.ToLongDateString() + "  " + DateTime.Now.ToLongTimeString().Replace(':', '-');
            if (save1.ShowDialog() == DialogResult.OK)
            {

                mCommand = new SqlCommand("backup DataBase mos7afh To Disk='" + save1.FileName + "'", dataAccess.sqlconnections);


                dataAccess.open();
                mCommand.ExecuteNonQuery();

                dataAccess.close();

                backup.Text = "تم عمل نسخه احتياطيه بنجاح";
            }
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {

            
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "BackUpFile (*.Bak) |*.BAK";


            if (open.ShowDialog() == DialogResult.OK)
            {


                mCommand = new SqlCommand("Alter DataBase mos7afh Set Offline With RollBack Immediate Restore DataBase mos7afh  from  Disk = '" + open.FileName + "' with replace", dataAccess.sqlconnections);
                dataAccess.open();

                mCommand.ExecuteNonQuery();
                dataAccess.close();
                backup.Text = " تم استعادة البيانات كامله بنجاح";

            }
        }

        private void backup_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void picHoliday_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    
                    
                    
                    txtpath.Text = fbd.SelectedPath;

                }
            }
        }
    }
}
