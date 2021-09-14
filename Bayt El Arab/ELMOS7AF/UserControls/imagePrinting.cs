using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ELMOS7AF.UserControls
{
    public partial class imagePrinting : Form
    {
        string filePath = editeclient.ImagePath;
        string clientname = editeclient.ClientName;
        public imagePrinting()
        {
            InitializeComponent();
            imgCombo.Text = "Zoom";
            txtStudentName.Text = clientname;
            
            try
            {
                pictureBox2.Image = Image.FromFile(filePath);
            }
            catch (Exception)
            {

                return;
            }
           

        }

        private void imagePrinting_Deactivate(object sender, EventArgs e)
        {
            if (AutoCollapsing)
            {
                System.Media.SystemSounds.Exclamation.Play();

                this.Close();
            }
    
        }
        Boolean timerenable=true;
        private void timer1_Tick(object sender, EventArgs e)
        {
      
            
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void imgCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (imgCombo.Text)
            {
                case "Zoom":
                    pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
                    break;
                case "CentralImage":
                    pictureBox2.SizeMode = PictureBoxSizeMode.CenterImage;
                    break;
                case "AutoSize":
                    pictureBox2.SizeMode = PictureBoxSizeMode.AutoSize;
                    break;
                case "Normal":
                    pictureBox2.SizeMode = PictureBoxSizeMode.Normal;
                    break;
                case "StreachImage":
                    pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
               


            }
        }
        Boolean AutoCollapsing = true;
        private void print_Click(object sender, EventArgs e)
        {
            AutoCollapsing = false;
            PrintDialog pd = new PrintDialog();
            PrintDocument doc = new PrintDocument();
            doc.PrintPage += Doc_PrintPage;
            pd.Document = doc;
            if (pd.ShowDialog() == DialogResult.OK)
                doc.Print();
            AutoCollapsing = true;
        }
        private void Doc_PrintPage(object sender, PrintPageEventArgs e)
        {
            //Print image
            Bitmap bm = new Bitmap(pictureBox2.Width, pictureBox2.Height);
            pictureBox2.DrawToBitmap(bm, new Rectangle(0, 0, pictureBox2.Width, pictureBox2.Height));
            e.Graphics.DrawImage(bm, 10, 10);
            bm.Dispose();
            
        }

        private void open_Click(object sender, EventArgs e)
        {
            AutoCollapsing = false;
            Process.Start(filePath);
            AutoCollapsing = true;

        }

        private void OPenFolder_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process prc = new System.Diagnostics.Process();
            prc.StartInfo.FileName = Path.GetDirectoryName(filePath);
            prc.Start();

        }
    }
}
