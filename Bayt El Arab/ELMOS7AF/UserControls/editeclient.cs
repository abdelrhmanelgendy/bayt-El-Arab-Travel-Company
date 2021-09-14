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
    public partial class editeclient : UserControl
    {
       

        DataTable mDataTable = new DataTable();
        SqlCommand mCommand;
        SqlDataAdapter mDataAdapter = new SqlDataAdapter();
        DataAccess dataAccess = new DataAccess();
        SqlDataReader dr;
        public static Boolean beingUpdate = false;

    public static    String ImagePath ;
public static        String ClientName;
        string DirectoryPath = Properties.Settings.Default.ImagesPath;
        public static string MainID;
        string passportname = "";
        string ssdname = "";
        string personalname = "";





        public editeclient()
        {
            InitializeComponent();
            fillGrid();
            txtssd.MaxLength = 14;
            txtphonenumber.MaxLength = 11;
            completeAdree();




        }
      
            void fillGrid()
        {
                mDataTable.Clear();
                dataAccess.close();

                mDataAdapter = new SqlDataAdapter("select id as الكود ,ssd as الرقم_القومي ,name as الاسم ,phone as التليون ,tottalmoney as المبلغ_المطلوب , remains from clients order by Id Desc", dataAccess.sqlconnections);
                mDataAdapter.Fill(mDataTable);
                clientGride.DataSource = mDataTable;
            gridSetup();

            }
        void gridSetup()
        {
            clientGride.Columns[5].Visible = false;
            if (ispaid.Checked==true)
            {
                for (int i = 0; i < clientGride.Rows.Count; i++)
                {
                    try
                    {
                        if (Convert.ToInt32(clientGride.Rows[i].Cells[5].Value.ToString()) == 0)
                        {
                            clientGride.Rows[i].DefaultCellStyle.BackColor = Properties.Settings.Default.paid;


                        }
                        else
                        {
                            clientGride.Rows[i].DefaultCellStyle.BackColor = Properties.Settings.Default.nopaid;
                        }
                    }
                    catch (Exception)
                    {

                        return;
                    }
                

                }
            }
       

            clientGride.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            clientGride.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(5, 40, 100);
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

        
        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void clientGride_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            clear();
            int id =Convert.ToInt32(clientGride.CurrentRow.Cells[0].Value.ToString());
            getdata(id);
        }
        string passportpath;
        string personalPath;
        string ssdPath;
        private void getdata(int id)
        {

            dataAccess.close();
            mCommand = new SqlCommand("select ssd,name,phone,passport,ssdphoto,personalimage,notes,tottalmoney,paid,remains,updated,address from clients where id ="+id+"",dataAccess.sqlconnections);
            //mCommand = new SqlCommand("select passport from client where id =" + id + "", dataAccess.sqlconnections);
            dataAccess.open();
            dr = mCommand.ExecuteReader();
            dr.Read();
            string ssd = dr[0].ToString();
            string name = dr[1].ToString();
            string phone = dr[2].ToString();
            string tottalmoney = dr[7].ToString();
            string paid = dr[8].ToString();
            string remains = dr[9].ToString();
            string notes = dr[6].ToString();
            string updated = dr[10].ToString();
            ssdPath = dr[4].ToString();
             passportpath = dr[3].ToString();
            personalPath = dr[5].ToString();
            string address = dr[11].ToString();
            txtid.Text = id.ToString();

            txtname.Text = name;
            txtaddress.Text = address;
            txtssd.Text = ssd;
            txtphonenumber.Text = phone;
            if (passportpath!="")
            {
                try
                {
                    imgPassport.Image = Image.FromFile(@passportpath);
                    printpassport.Enabled = true;
                }
                catch (Exception)
                {

                    
                }
         
            }
            else if (passportpath == "")
            {
                try
                {

                    imgPassport.Image = Properties.Resources.mPassport;
                    printpassport.Enabled = false;
                }
                catch (Exception)
                {


                }

            }
            if (personalPath != "")
            {
                imgPersonalImage.Image = Image.FromFile(@personalPath);
                printpersonal.Enabled = true;
            }
            else if (personalPath == "")
            {
                imgPersonalImage.Image = Properties.Resources.mPersonal;
                printpersonal.Enabled = false;
            }
            if (ssdPath != "")
            {
                imgSSD.Image = Image.FromFile(@ssdPath);
                printssd.Enabled = true;
            }
            else if (ssdPath == "")
            {
                imgSSD.Image = Properties.Resources.mSSD;
                printssd.Enabled = false;
            }





            txttottal.Text = tottalmoney;
            txtpaid.Text = paid;
            txtremains.Text = remains;
            txtdate.Value =DateTime.Parse(updated);

            txtNotes.Text = notes;
            ClientName = txtname.Text;
            MainID = txtid.Text;
            lblpay.Text = N2C.ConvertN2C.ConvertNow(Convert.ToDouble(txtpaid.Text), "جنيه", "قرش").ToString();
            lblpaid.Text = N2C.ConvertN2C.ConvertNow(Convert.ToDouble(txttottal.Text), "جنيه", "قرش").ToString();
            lblremains.Text= N2C.ConvertN2C.ConvertNow(Convert.ToDouble(txtremains.Text), "جنيه", "قرش").ToString();




        }

        private void printpassport_Click(object sender, EventArgs e)
        {

            ImagePath = passportpath;

            
            imagePrinting print = new imagePrinting();
            print.Show();
        }

        private void printssd_Click(object sender, EventArgs e)
        {

            ImagePath = ssdPath;
            
            imagePrinting print = new imagePrinting();
            print.Show();

        }

        private void printpersonal_Click(object sender, EventArgs e)
        {

            ImagePath = personalPath;
            
            imagePrinting print = new imagePrinting();
            print.Show();
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

        private void imgPersonalImage_Click(object sender, EventArgs e)
        {
            String fileName = getImageName();
            if (fileName != null)
            {
                imgPersonalImage.Image = Image.FromFile(fileName);
                personalname = fileName;
            }
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

        private void imgPassport_Click(object sender, EventArgs e)
        {

            String fileName = getImageName();
            if (fileName != null)
            {
                imgPassport.Image = Image.FromFile(fileName);
                passportname = fileName;
            }
        }

        string finalPassportPath = "";
        string finalSSDPath = "";
        string finalPersonalPath = "";
        private void savepassport()
        {
           
            if (passportname != "")
            {
                

                string id = txtid.Text;
                string name = "passport" + ".jpg";

                string folder = DirectoryPath + "\\Client" + id;
                string fullpath = System.IO.Path.Combine(folder, name);
                try
                {
                    imgPassport.Image.Save(fullpath);
                }
                catch (Exception)
                {
                DialogResult result=    MessageBox.Show("الصوره موجوده بالفعل برجاء غلق البرنامج و حذها اولا","Error Message!",MessageBoxButtons.OKCancel,MessageBoxIcon.Stop);
                    if (result==DialogResult.OK)
                    {
                        //clear();
                        System.Diagnostics.Process prc = new System.Diagnostics.Process();
                        prc.StartInfo.FileName = Path.GetDirectoryName(fullpath);
                        prc.Start();
                    }
                    else
                    {
                        return;
                    }
                    
                }
               
                finalPassportPath = fullpath;
            }



            if (ssdname != "")
            {
                string id = txtid.Text;
                string name = "SSD" + ".jpg";

                string folder = DirectoryPath + "\\Client" + id;
                string fullpath = System.IO.Path.Combine(folder, name);

                try
                {
                    imgSSD.Image.Save(fullpath);
                }
                catch (Exception)
                {
                    DialogResult result = MessageBox.Show("الصوره موجوده بالفعل برجاء غلق البرنامج و حذها اولا", "Error Message!", MessageBoxButtons.OKCancel, MessageBoxIcon.Stop);
                    if (result == DialogResult.OK)
                    {
                        //clear();
                        System.Diagnostics.Process prc = new System.Diagnostics.Process();
                        prc.StartInfo.FileName = Path.GetDirectoryName(fullpath);
                        prc.Start();
                    }
                    else
                    {
                        return;
                    }

                }
         
                finalSSDPath = fullpath;
            }

            if (personalname != "")
            {
                string id = txtid.Text;
                string name = "PersonalImage" + ".jpg";

                string folder = DirectoryPath + "\\Client" + id;
                string fullpath = System.IO.Path.Combine(folder, name);
                try
                {
                    imgPersonalImage.Image.Save(fullpath);
                }
                catch (Exception)
                {
                    DialogResult result = MessageBox.Show("الصوره موجوده بالفعل برجاء غلق البرنامج و حذها اولا", "Error Message!", MessageBoxButtons.OKCancel, MessageBoxIcon.Stop);
                    if (result == DialogResult.OK)
                    {
                        //clear();
                        System.Diagnostics.Process prc = new System.Diagnostics.Process();
                        prc.StartInfo.FileName = Path.GetDirectoryName(fullpath);
                        prc.Start();
                    }
                    else
                    {
                        return;
                    }

                }
           
                finalPersonalPath = fullpath;
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {

            clear();




        }

        private void button1_Click(object sender, EventArgs e)
        {
            DirectoryInfo dd = Directory.CreateDirectory(DirectoryPath + "\\Client" + txtid.Text);
            if (txtremains.Text != "" && txtmoney.Text != "")
            {
                if ( Convert.ToInt32(txtremains.Text)<0)
                {
                    MessageBox.Show("المبلغ غير صحيح", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtmoney.Focus();
                    txtmoney.SelectAll();
                    return;
                }
            }

            if (txtssd.Text == "")
            {
                MessageBox.Show("الرقم القومي فارغا", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtssd.Focus();
                return;
            }
            if (txtssd.TextLength != 14)
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


            savepassport();
            update();
            payments();

            getdata(Convert.ToInt32(txtid.Text));

            txtmoney.Text = "";
            completeAdree();
            fillGrid();
            
        }
        private void payments()
        {
            if (txtmoney.Text != "")
            {
                if (Convert.ToDouble(txtmoney.Text) > 0)
                {
                    dataAccess.close();
                    int id = Convert.ToInt32(txtid.Text);
                    string name = txtname.Text;
                    string date = DateTime.Now.ToShortDateString();
                    string notes = txtNotes.Text;
                    double amount = Convert.ToDouble(txtmoney.Text);
                    mCommand = new SqlCommand("Insert into payments (id,Name,date , amount,annotations) values (" + id + ",'" + name + "','" + date + "'," + amount + ",'" + notes + "')", dataAccess.sqlconnections);
                    dataAccess.open();
                    mCommand.ExecuteNonQuery();
                    dataAccess.close();
                    insertRevenue();
                    updatedaysRevenue();

                }
            }

        }

        private void updatedaysRevenue()
        {


            string day = DateTime.Now.Day.ToString();
            string month = DateTime.Now.Month.ToString();
            string year = DateTime.Now.Year.ToString();

            string date = year + "-" + month + "-" + day;

            
            double amount = Convert.ToDouble(txtmoney.Text);
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
            if (dr[1].ToString()!="")
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
            double amount = Convert.ToDouble(txtmoney.Text);


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

        void update()
        {
           
            dataAccess.close();
            double paid = 0;
            if (txtpaid.Text != "")
            {
                paid = Convert.ToDouble(txtpaid.Text);
            }
            double paying = 0;
            if (txtmoney.Text != "")
            {
                paying = Convert.ToDouble(txtmoney.Text);
            }

            double tottalpaid = paid + paying;
            double remains = 0;
            if (txtremains.Text!="")
            {
                remains=     Convert.ToDouble(txtremains.Text);
            }
       
            mCommand = new SqlCommand("update clients set SSD='" + txtssd.Text + "',name ='" + txtname.Text + "',address='" + txtaddress.Text + "',phone ='" + txtphonenumber.Text + "',Passport='" + finalPassportPath + "',ssdphoto='" + finalSSDPath + "',personalimage='" + finalPersonalPath + "',paid=" + tottalpaid + ",remains=" + remains + ",updated='" + DateTime.Now.ToShortDateString() + "',notes='" + txtNotes.Text + "' where id =" + Convert.ToInt32(txtid.Text) + "", dataAccess.sqlconnections);
            dataAccess.open();
            mCommand.ExecuteNonQuery();
            dataAccess.close();

        }

        private void txtmoney_TextChanged(object sender, EventArgs e)
        {
            double tottalMoney = 0;
            if (txttottal.Text!="")
            {
               tottalMoney= Convert.ToDouble(txttottal.Text);
            }
            double paid = 0;
            if (txtpaid.Text!="")
            {
               paid= Convert.ToDouble(txtpaid.Text);
            }
            double paying = 0;
            if (txtmoney.Text!="")
            {
              paying=  Convert.ToDouble(txtmoney.Text);
            }

            txtremains.Text =(tottalMoney - paid - paying).ToString();
            lblremains.Text = N2C.ConvertN2C.ConvertNow((tottalMoney - paid - paying), "جنيه", "قرش").ToString();
        }

        private void clientGride_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        void clear()
        {
            txtaddress.Clear();
            txtssd.Clear();
            txtname.Clear();
            txtNotes.Clear();
            txtphonenumber.Clear();
            txttottal.Clear();
            txtpaid.Clear();
            txtremains.Clear();
            imgPassport.Image = Properties.Resources.mPassport;
            imgPersonalImage.Image = Properties.Resources.mPersonal;
            imgSSD.Image = Properties.Resources.mSSD;
            ssdname = "";
            personalname = "";
            passportname = "";
            txtmoney.Clear();
            lblremains.Text = "";
            lblpay.Text = "";
            lblpaid.Text = "";
        }

        private void txtremains_TextChanged(object sender, EventArgs e)
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

        private void txtmoney_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) & e.KeyChar != 8 & e.KeyChar != 46)
            {
                e.Handled = true;
            }
        }

        void completeAdree()
        {
            dataAccess.close();
            mCommand = new SqlCommand("select address from clients ",dataAccess.sqlconnections);
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
            if (txtsearch.Text!="")
            {
                searchById();
            }
            else
            {
                fillGrid();
             
            }
        }

        private void searchById()
        {
            String searchTittle = txtsearch.Text;
            Boolean containsDigits = searchTittle.All(char.IsDigit);

            if (containsDigits)
            {
                double id = Convert.ToDouble(searchTittle);
                if (idsearch.Checked == true)
                {
                    
                    idsearching(id);
                }
                else
                {
                    searchById(id);
                }
          

            }
            else if (!containsDigits)
            {
                searchByName(searchTittle);
            }
        }

        private void idsearching(double id)
        {
            mDataTable.Clear();
            dataAccess.close();
            mDataAdapter = new SqlDataAdapter("select id as الكود ,ssd as الرقم_القومي ,name as الاسم ,phone as التليون ,tottalmoney as المبلغ_المطلوب , remains from clients where id =" + id + "", dataAccess.sqlconnections);
            mDataAdapter.Fill(mDataTable);
            clientGride.DataSource = mDataTable;
            gridSetup();
        }

        private void searchByName(string searchTittle)
        {
            mDataTable.Clear(); 
            dataAccess.close();
            mDataAdapter = new SqlDataAdapter("select id as الكود ,ssd as الرقم_القومي ,name as الاسم ,phone as التليون ,tottalmoney as المبلغ_المطلوب  , remains from clients where name+ssd+phone like '%" + searchTittle+"%'", dataAccess.sqlconnections);
            mDataAdapter.Fill(mDataTable);
            clientGride.DataSource = mDataTable;
            gridSetup();
        }

        private void searchById(double id)
        {
            mDataTable.Clear();
            dataAccess.close();
            mDataAdapter = new SqlDataAdapter("select id as الكود ,ssd as الرقم_القومي ,name as الاسم ,phone as التليون ,tottalmoney as المبلغ_المطلوب  , remains from clients where ssd+phone like '%" + id + "%'", dataAccess.sqlconnections);
            mDataAdapter.Fill(mDataTable);

            clientGride.DataSource = mDataTable;
            gridSetup();
        }

        private void guna2ToggleSwitch2_CheckedChanged(object sender, EventArgs e)
        {
            txtsearch.Text = "";
            fillGrid();
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (beingUpdate==true)
            {
                fillGrid();
                beingUpdate = false;
            }
        }
    }
}
