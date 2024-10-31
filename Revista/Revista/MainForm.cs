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
            updatetitle();
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
            updatetitle();
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
        
        string tittap1 = "La Loma";
        string infotap1 = "El tapete muestra una imagen de San Miguel Arcángel con un estilo 'Romano' con un fondo anaranjado y con figurar adornandolo, fue hecho igual con aserrín teñido.";

        string tittap2 = "Alfa";
        string infotap2 = "Este tapete lo elaboro el refugio de animales 'Refugio Animal Alfa A. C.',fue hecho con aserrín teñido de diferentes colores y muestra una imagen de varios animales junto al santo 'San Francisco de Asís'";

        string tittap3 = "Señor Padre Santo";
        string infotap3 = "La imagen muestra una representación artística de Jesús orando con el mundo en sus manos.La imagen es una pintura de Jesús en un fondo azul con nubes blancas y un halo amarillo a su alrededor. Está vestido con una túnica marrón y una capa amarilla y azul. Sus manos están juntas en oración y sostiene un globo terráqueo marrón. El cielo es un cielo azul profundo con estrellas blancas, y en la parte superior, se puede ver un poco de la estructura de un edificio. La imagen está llena de colores vivos que se pueden considerar optimistas.";

        string tittap4 = "Nazaret";
        string infotap4 = "El tapete fue elaborado con aserrín de colores, con una imagen de Jesús de Nazaret con una corona de espinas y un fondo azul.";

        string tittap5 = "San José";
        string infotap5 = "El tapete se elaboro con aserrín teñido, muestra una alfombra con mándalas blancos y un rombo al centro con la imagen de 'San José' teniendo en brazos al 'Niño Jesús' rodeados de flores.";

        string tittap6 = "Virgen";
        string infotap6 = "El tapete se hizo igual con aserrín teñido, muestra una imagen de lo que parece ser la Virgen María con un corazón en su mano pero usaron unos colores de diferente tonalidad, y estas rodeada con varias velas de led.";

        string tittap7 = "San Miguel";
        string infotap7 = "Este tapete igual fue hecho con aserrín de diferentes colores, se aprecia la imagen del santo 'San Miguel Arcángel' con el fondo azul, y un marco de diferentes formas blancas, en la parte de arriba lo que parece ser la flor 'Paeonia' y abajo la flor 'Alcatraz'";

        string tittap8 = "Corazón de Jesús";
        string infotap8 = "Este tapete al igual que la mayoría fue hecho con aserrín teñido de diferentes colores, representa una imagen del Sagrado Corazón de Jesús, con un marco blanco de diferentes formas decorando el tapete.";

        string tittap9 = "La Octava";
        string infotap9 = "Este tapete se elaboro con aserrín teñido, diferentes flores, pétalos, maíz pintado y madera, muestra en la parte de arriba la imagen de San Miguel, abajo un marco redondo de colores con el escudo de Uriangato y al final una leyenda 'La Octava Noche' con una linea de flores.";

        string tittap10 = "Paloma de la Paz";
        string infotap10 = "El tapete representa a una paloma con las alas extendidas, en el fondo se ve lo que parece ser un vitral de diferentes colores, fue echo con aserrín de diferentes colores.";
        
        void UpdateName()
        {

        	switch (lugar_centr)
        	{
        		case 1:
        			
        			break;
        		default:
        			
        			break;
        	}
        }

        void updatetitle()
        {
            switch (lugar_centr)
            {
                case 1:
                    lbltapeteizq.Text = tittap10;
                    lbltapetecen.Text = tittap1;
                    lbltapeteder.Text = tittap2;
                    break;
                case 2:
                    lbltapeteizq.Text = tittap1;
                    lbltapetecen.Text = tittap2;
                    lbltapeteder.Text = tittap3;
                    break;
                case 3:
                    lbltapeteizq.Text = tittap2;
                    lbltapetecen.Text = tittap3;
                    lbltapeteder.Text = tittap4;
                    break;
                case 4:
                    lbltapeteizq.Text = tittap3;
                    lbltapetecen.Text = tittap4;
                    lbltapeteder.Text = tittap5;
                    break;
                case 5:
                    lbltapeteizq.Text = tittap4;
                    lbltapetecen.Text = tittap5;
                    lbltapeteder.Text = tittap6;
                    break;
                case 6:
                    lbltapeteizq.Text = tittap5;
                    lbltapetecen.Text = tittap6;
                    lbltapeteder.Text = tittap7;
                    break;
                case 7:
                    lbltapeteizq.Text = tittap6;
                    lbltapetecen.Text = tittap7;
                    lbltapeteder.Text = tittap8;
                    break;
                case 8:
                    lbltapeteizq.Text = tittap7;
                    lbltapetecen.Text = tittap8;
                    lbltapeteder.Text = tittap9;
                    break;
                case 9:
                    lbltapeteizq.Text = tittap8;
                    lbltapetecen.Text = tittap9;
                    lbltapeteder.Text = tittap10;
                    break;
                case 10:
                    lbltapeteizq.Text = tittap9;
                    lbltapetecen.Text = tittap10;
                    lbltapeteder.Text = tittap1;
                    break;
                default:
                    lbltapeteizq.Text = lbltapetecen.Text = lbltapeteder.Text = "";
                    break;
            }		
        }
		
		void BtninfoClick(object sender, EventArgs e)
		{
            switch(lugar_centr)
            {
                case 1:
                    MessageBox.Show(infotap1);
                    break;
                case 2:
                    MessageBox.Show(infotap2);
                    break;
                case 3:
                    MessageBox.Show(infotap3);
                    break;
                case 4:
                    MessageBox.Show(infotap4);
                    break;
                case 5:
                    MessageBox.Show(infotap5);
                    break;
                case 6:
                    MessageBox.Show(infotap6);
                    break;
                case 7:
                    MessageBox.Show(infotap7);
                    break;
                case 8:
                    MessageBox.Show(infotap8);
                    break;
                case 9:
                    MessageBox.Show(infotap9);
                    break;
                case 10:
                    MessageBox.Show(infotap10);
                    break;
            }
		}
    }
}
