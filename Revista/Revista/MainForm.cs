using System;
using System.IO;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Diagnostics;

namespace Revista
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        public int lugar_centr = 2;
        private bool liked = false;

        private void PbnextClick(object sender, EventArgs e)
        {
            if (lugar_centr == 10)
            {
                lugar_centr = 1;
            }
            else
            {
                lugar_centr++;
            }

            UpdatePictureBoxes();
            UpdateName();
        }

        private void PictureBox6Click(object sender, EventArgs e)
        {
            if (lugar_centr == 1)
            {
                lugar_centr = 10;
            }
            else
            {
                lugar_centr--;
            }

            UpdatePictureBoxes();
            UpdateName();
        }

        private void PblikrClick(object sender, EventArgs e)
        {
            if (!liked)
            {
                butonlaik();
                liked = true;
            }
            else
            {
                butonlaik();
                liked = false;
            }
        }

        private void BntencuClick(object sender, EventArgs e)
        {
            string url = "https://forms.gle/4TRpoqRZaU7RE5416";
            Process.Start(new ProcessStartInfo(url) { UseShellExecute = true });
        }

        private void butonlaik()
        {
            string basePath = @"C:\Users\CC1_PC47\Documents\Revista-Tapetes\Revista\Images\";
            string imageName = liked ? "like.png" : "likegave.png";
            string location = Path.Combine(basePath, imageName);
            pblikr.Image = null;
            pblikr.ImageLocation = location;
            pblikr.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void UpdatePictureBoxes()
        {
            string centro;
            string left;
            string right;

            switch (lugar_centr)
            {
                case 1:
                    left = "tapete10";
                    centro = "tapete1";
                    right = "tapete2";
                    break;
                case 2:
                    left = "tapete1";
                    centro = "tapete2";
                    right = "tapete3";
                    break;
                case 3:
                    left = "tapete2";
                    centro = "tapete3";
                    right = "tapete4";
                    break;
                case 4:
                    left = "tapete3";
                    centro = "tapete4";
                    right = "tapete5";
                    break;
                case 5:
                    left = "tapete4";
                    centro = "tapete5";
                    right = "tapete6";
                    break;
                case 6:
                    left = "tapete5";
                    centro = "tapete6";
                    right = "tapete7";
                    break;
                case 7:
                    left = "tapete6";
                    centro = "tapete7";
                    right = "tapete8";
                    break;
                case 8:
                    left = "tapete7";
                    centro = "tapete8";
                    right = "tapete9";
                    break;
                case 9:
                    left = "tapete8";
                    centro = "tapete9";
                    right = "tapete10";
                    break;
                case 10:
                    left = "tapete9";
                    centro = "tapete10";
                    right = "tapete1";
                    break;
                default:
                    left = centro = right = "";
                    break;
            }

            string basePath = @"C:\Users\CC1_PC47\Documents\Revista-Tapetes\Revista\Images\";
            picboxtapeteizq.ImageLocation = Path.Combine(basePath, left);
            picboxtapeteizq.SizeMode = PictureBoxSizeMode.StretchImage;

            picboxtapetecen.ImageLocation = Path.Combine(basePath, centro);
            picboxtapetecen.SizeMode = PictureBoxSizeMode.StretchImage;

            picboxtapeteder.ImageLocation = Path.Combine(basePath, right);
            picboxtapeteder.SizeMode = PictureBoxSizeMode.StretchImage;
        }
        
        void UpdateName()
        {
        	string tap1;
            string tap2;
            string tap3;
        	switch (lugar_centr)
        	{
        		case 1:
        			
        			break;
        		default:
        			
        			break;
        	}
        }
    }
}
