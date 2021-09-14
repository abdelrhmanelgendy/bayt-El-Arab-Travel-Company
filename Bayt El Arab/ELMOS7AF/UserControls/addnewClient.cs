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
using System.Text.RegularExpressions;
using System.IO;

namespace ELMOS7AF.UserControls
{
    public partial class addnewClient : UserControl
    {
        public static Boolean adddNewBeingUpdate = false;
        public static Boolean beingUpdate = false;
        DataTable mDataTable = new DataTable();
        SqlCommand mCommand;
        SqlDataAdapter mDataAdapter = new SqlDataAdapter();
        DataAccess dataAccess = new DataAccess();
        SqlDataReader dr;
        String myName;
        string passportname="";
        string ssdname = "";
        string personalname = "";
        public static bool addBeginAdded = false;


        string passportpath = "";
        string ssdpath= "";
        string personalpath = "";
        string DirectoryPath = Properties.Settings.Default.ImagesPath;

        public static int STUDENT_ID;
        public static String STUDENT_Name;
        public addnewClient()
        {
            InitializeComponent();
            initializeId();
            fillGrid();
            txtssd.MaxLength = 14;
            txtphonenumber.MaxLength = 11;
            imgPassport.Image = Properties.Resources.mPassport;
        


        }

        private void initializeId()
        {


            mCommand = new SqlCommand("select isnull(max(id) + 1, 1)from clients", dataAccess.sqlconnections);
            dataAccess.open();
            dr = mCommand.ExecuteReader();
            dr.Read();
            txtid.Text = dr[0].ToString();
            completeAdree();



        }
 public   void  fillGrid()
        {
            //MessageBox.Show("");
            mDataTable.Clear();
            dataAccess.close();

            mDataAdapter = new SqlDataAdapter("select id as الكود ,ssd as الرقم_القومي ,name as الاسم ,phone as التليون ,tottalmoney as المبلغ_المطلوب from clients order by Id Desc", dataAccess.sqlconnections);
            mDataAdapter.Fill(mDataTable);
            clientGride.DataSource = mDataTable;
            
            clientGride.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            clientGride.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(5,40,100);
            clientGride.EnableHeadersVisualStyles = false;
            clientGride.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            clientGride.ColumnHeadersHeight = 35;


          clientGride.Columns[0].Width = 50;
            clientGride.Columns[1].Width = 100;
            clientGride.Columns[2].Width = 200;
            this.clientGride.Columns[3].Width = 100;
            this.clientGride.Columns[4].Width = 80;

            this.clientGride.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.clientGride.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.clientGride.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.clientGride.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        private void guna2GroupBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        String passportFileName;
        private void imgPassport_Click(object sender, EventArgs e)
        {

          String fileName = getImageName();
            if (fileName!=null)
            {
                imgPassport.Image = Image.FromFile(fileName);
                passportname = fileName;
            }
        }
        string getImageName()
        {
            OpenFileDialog ofd = new OpenFileDialog() { ValidateNames = true, Multiselect = false };
            ofd.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    return ofd.FileName;

                  
                }
            }
            return null;

        }

        private void imgSSD_Click(object sender, EventArgs e)
        {
            String fileName = getImageName();
            if (fileName != null)
            {
                imgSSD.Image = Image.FromFile(fileName);
                ssdname = fileName;
            }
        }

        private void imgPersonalImage_Click(object sender, EventArgs e)
        {
            String fileName = getImageName();
            if (fileName != null)
            {
                imgPersonalImage.Image = Image.FromFile(fileName);
                personalname = fileName;
            }
        }

        private void addnewClient_Load(object sender, EventArgs e)
        {
            imgPersonalImage.AllowDrop = true;
            imgPassport.AllowDrop = true;
            imgSSD.AllowDrop = true;
        }

        private void imgPassport_DragDrop(object sender, DragEventArgs e)
        {
            var data = e.Data.GetData(DataFormats.FileDrop);
            if (data!=null)
            {
                var filename = data as String[];
                if (filename.Length>0)
                {
                    imgPassport.Image = Image.FromFile(filename[0]);
                    passportname = filename[0];
                }
            }
        }

        private void imgPassport_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;

        }

        private void imgSSD_DragDrop(object sender, DragEventArgs e)
        {
            var data = e.Data.GetData(DataFormats.FileDrop);
            if (data != null)
            {
                var filename = data as String[];
                if (filename.Length > 0)
                {
                    imgSSD.Image = Image.FromFile(filename[0]);
                    ssdname = filename[0];
                }
            }
        }

        private void imgSSD_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void imgPersonalImage_DragDrop(object sender, DragEventArgs e)
        {
            var data = e.Data.GetData(DataFormats.FileDrop);
            if (data != null)
            {
                var filename = data as String[];
                if (filename.Length > 0)
                {
                    imgPersonalImage.Image = Image.FromFile(filename[0]);
                    personalname = filename[0];
                }
            }
        }

        private void imgPersonalImage_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void txttottalmoney_TextChanged(object sender, EventArgs e)
        {
            try
            {
 double tottal =Convert.ToDouble(txttottalmoney.Text.ToString());
            double paid=0;
            if (txtpaid.Text!="")
            {
                paid = Convert.ToDouble(txtpaid.Text.ToString());
            }
            txtremains.Text = (tottal-paid).ToString();
            lbltottal.Text = N2C.ConvertN2C.ConvertNow(tottal, "جنيه", "قرش");
            }
            catch (Exception)
            {

                return;
            }


           
         
        
        }

        private void txtpaid_TextChanged(object sender, EventArgs e)
        {
            try
            {
     double paid = Convert.ToDouble(txtpaid.Text.ToString());
            double tottal = Convert.ToDouble(txttottalmoney.Text.ToString());
            txtremains.Text = (tottal - paid).ToString();
            lblpaid.Text = N2C.ConvertN2C.ConvertNow(paid, "جنيه", "قرش");
            }
            catch (Exception)
            {

                return;
            }
       
        }

        private void txtremains_TextChanged(object sender, EventArgs e)
        {

            try
            {
   double tottal = Convert.ToDouble(txtremains.Text.ToString());
            lblremains.Text = N2C.ConvertN2C.ConvertNow(tottal, "جنيه", "قرش");
            }
            catch (Exception)
            {

                return;
            }
         
        }

        private void txttottalmoney_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) & e.KeyChar != 8 &e.KeyChar!=46)
            {
                e.Handled = true;
            }
        }

        private void txtpaid_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) & e.KeyChar != 8 & e.KeyChar != 46)
            {
                e.Handled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtpaid.Text!=""&&txttottalmoney.Text!="")
            {
                if (Convert.ToInt32(txttottalmoney.Text) < Convert.ToInt32(txtpaid.Text))
                {
                    MessageBox.Show("المبلغ غير صحيح", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtpaid.Focus();
                    return;
                }
            }
        
            if (txtssd.Text == "")
            {
                MessageBox.Show("الرقم القومي فارغا", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtssd.Focus();
                return;
            }
            if (txtssd.TextLength!=14)
            {
                MessageBox.Show("خطأ في كتابة الرقم القومي", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtssd.Focus();
                return;
            }
            if (txtname.Text == "")
            {
                MessageBox.Show("الاسم فارغا", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtname.Focus();
                return;
            }
       
            if (txtaddress.Text == "")
            {
                MessageBox.Show(" العوان فارغا", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtaddress.Focus();
                return;
            }

            if (txttottalmoney.Text == "")
            {
                MessageBox.Show("المبلغ فارغا", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txttottalmoney.Focus();
                return;
            }
            if (!checkSSDExcisting())
            {
                MessageBox.Show("الرقم القومي موجود بالفعل", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtssd.Focus();
                return;
            }
            if (!checkNameExcisting())
            {
                MessageBox.Show("الاسم موجود بالفعل", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtname.Focus();
                return;
            }
            stringIntegrity();
            Insert();
            payments();
            fillGrid();
            clear();
            completeAdree();
            initializeId();



        }

        private bool checkNameExcisting()
        {
            dataAccess.close();
            mCommand = new SqlCommand("select name from clients", dataAccess.sqlconnections);
            dataAccess.open();
            dr = mCommand.ExecuteReader();
            while (dr.Read())
            {
                if (txtname.Text.Equals(dr[0].ToString()))
                {
                    return false;
                }
            }
            return true;
        }

        private bool checkSSDExcisting()
        {
            dataAccess.close();
            mCommand = new SqlCommand("select ssd from clients",dataAccess.sqlconnections);
            dataAccess.open();
            dr = mCommand.ExecuteReader();
            while (dr.Read())
            {
                if (txtssd.Text.Equals(dr[0].ToString()))
                {
                    return false;
                }
            }
            return true;
        }
        private void updatedaysRevenue()
        {


            string day = DateTime.Now.Day.ToString();
            string month = DateTime.Now.Month.ToString();
            string year = DateTime.Now.Year.ToString();

            string date = year + "-" + month + "-" + day;


            double amount = Convert.ToDouble(txtpaid.Text);
            double income = 0;
            double tottal = 0;

            dataAccess.close();
            mCommand = new SqlCommand("select incomes,money from daysRevenues where date ='" + date + "'", dataAccess.sqlconnections);
            dataAccess.open();
            dr = mCommand.ExecuteReader();
            dr.Read();
            if (dr[0].ToString() != "")
            {
                income = Convert.ToDouble(dr[0].ToString());
            }
            if (dr[1].ToString() != "")
            {
                tottal = Convert.ToDouble(dr[1].ToString());
            }
            double finalIncome = income + amount;
            double finaltottal = tottal + amount;


            dataAccess.close();



            mCommand = new SqlCommand("update daysRevenues set money =" + finaltottal + ",incomes =" + finalIncome + ",ending =" + finaltottal + " where date ='" + date + "'", dataAccess.sqlconnections);
            dataAccess.open();
            mCommand.ExecuteNonQuery();
            dataAccess.close();
        }

        private void insertRevenue()
        {
            string type;
            double amount = Convert.ToDouble(txtpaid.Text);


            string notess = txtname.Text;
            string date = DateTime.Now.ToShortDateString();
            string hourse = DateTime.Now.Hour.ToString();
            string minutes = DateTime.Now.Minute.ToString();
            string time = DateTime.Now.ToShortTimeString();
            string admin = LoginForm.adminName;
            mCommand = new SqlCommand(@"insert into Revenues (amount,type,annotations,date,hours,minuts,time,safeAdmin) values 
                (" + amount + ",'ايداع','" + notess + "','" + date + "','" + hourse + "','" + minutes + "','" + time + "','" + admin + "')", dataAccess.sqlconnections);
            dataAccess.open();
            mCommand.ExecuteNonQuery();
            dataAccess.close();
            //fillGride();
        }
        private void payments()
        {
            if (txtpaid.Text!="")
            {
                if (Convert.ToDouble(txtpaid.Text) > 0)
                {
                    dataAccess.close();
                    int id = Convert.ToInt32(txtid.Text);
                    string name = txtname.Text;
                    string date = DateTime.Now.ToShortDateString();
                    string notes = txtNotes.Text;
                    double amount = Convert.ToDouble(txtpaid.Text);
                    mCommand = new SqlCommand("Insert into payments (id,Name,date , amount,annotations) values (" + id+",'"+name+"','"+date+"',"+amount+",'"+notes+"')",dataAccess.sqlconnections);
                    dataAccess.open();
                    mCommand.ExecuteNonQuery();
                    dataAccess.close();
                    insertRevenue();
                    updatedaysRevenue();



                }
            }
     
        }

        private void stringIntegrity()
        {
           
        }

        void Insert()
        {
            //DirectoryInfo di = Directory.CreateDirectory("D:\\Bayt El_Arab" + "\\Client" + txtid.Text);
            dataAccess.close();
            string ssd =txtssd.Text.ToString();
            string name = txtname.Text.ToString();
            string address = txtaddress.Text.ToString();
            string phone = txtphonenumber.Text.ToString();
            string notes = txtNotes.Text.ToString();
            string date = DateTime.Now.ToShortDateString();
            double tottalmoney = Convert.ToDouble(txttottalmoney.Text);
            
            double paid = 0;
            if (txtpaid.Text!="")
            {
                paid= Convert.ToDouble(txtpaid.Text);
            }
              
            double remian = Convert.ToDouble(txtremains.Text);
            string updated="";
            if (txtpaid.Text!="")
            {
                updated = DateTime.Now.ToShortDateString();
            }
     
   
      
            dataAccess.open();
            savepassport();
            mCommand = new SqlCommand(@"insert into Clients (ssd,Name,Address,phone,notes,addedat,updated,tottalmoney,paid,remains,passport,ssdphoto,personalimage)
                values('"+ssd+"','"+name+"','"+address+"','"+phone+"','"+notes+"','"+date+"','"+date+"',"+tottalmoney+","+paid+","+remian+",'"+passportpath+"','"+ssdpath+"','"+personalpath+"')",dataAccess.sqlconnections);
      
            mCommand.ExecuteNonQuery();
            dataAccess.close();
            

        }

        private void savepassport()
        {
            DirectoryInfo dd = Directory.CreateDirectory(DirectoryPath + "\\Client" + txtid.Text);
            if (passportname!="")
            {

            
                string id = txtid.Text;
                string name = "passport" + ".jpg";
                
                string folder = DirectoryPath + "\\Client" + id;
                string fullpath = System.IO.Path.Combine(folder, name);
                imgPassport.Image.Save(fullpath);
                passportpath = fullpath;
            }
       
            

            if (ssdname != "")
            {
                string id = txtid.Text;
                string name = "SSD" + ".jpg";
                
                string folder = DirectoryPath + "\\Client" + id;
                string fullpath = System.IO.Path.Combine(folder, name);
                imgSSD.Image.Save(fullpath);
                ssdpath = fullpath;
            }

            if (personalname != "")
            {
                string id = txtid.Text;
                string name = "PersonalImage" + ".jpg";
                
                string folder = DirectoryPath + "\\Client" + id;
                string fullpath = System.IO.Path.Combine(folder, name);
                imgPersonalImage.Image.Save(fullpath);
                personalpath = fullpath;
            }


        }

        byte[] getdata(Image myImage)
        {
            
            byte[] data;
            MemoryStream ms = new MemoryStream();
            
                myImage.Save(ms, System.Drawing.Imaging.ImageFormat.Bmp);
                data = ms.ToArray();
            return data;
            
        }

        private void imgPersonalImage_MouseHover(object sender, EventArgs e)
        {
        
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void txtsearch_Enter(object sender, EventArgs e)
        {

        }

        private void clientGride_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            
            clear();
   
        }
        void clear()
        {
            txtaddress.Clear();
            txtssd.Clear();
            txtname.Clear();
            txtNotes.Clear();
            txtphonenumber.Clear();
            txttottalmoney.Clear();
            txtpaid.Clear();
            txtremains.Clear();
            imgPassport.Image = Properties.Resources.mPassport;
            imgPersonalImage.Image = Properties.Resources.mPersonal;
            imgSSD.Image = Properties.Resources.mSSD;
            ssdname = "";
            personalname = "";
            passportname = "";

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtpaid_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void txtssd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) & e.KeyChar != 8 & e.KeyChar != 46)
            {
                e.Handled = true;
            }
        }

        private void txtphonenumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) & e.KeyChar != 8 & e.KeyChar != 46)
            {
                e.Handled = true;
            }
        }

        private void txtremains_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) & e.KeyChar != 8 & e.KeyChar != 46)
            {
                e.Handled = true;
            }
        }

        void completeAdree()
        {
            dataAccess.close();
            mCommand = new SqlCommand("select address from clients ", dataAccess.sqlconnections);
            dataAccess.open();
            dr = mCommand.ExecuteReader();


            AutoCompleteStringCollection mySource = new AutoCompleteStringCollection();
            while (dr.Read())
            {
                mySource.Add(dr[0].ToString());
            }
            txtaddress.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txtaddress.AutoCompleteCustomSource = mySource;
            txtaddress.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            dataAccess.close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (addBeginAdded==true)
            {
                fillGrid();
                addBeginAdded = false;
            }
        }

        private void txtssd_TextChanged(object sender, EventArgs e)
        {

        }

    }


        }