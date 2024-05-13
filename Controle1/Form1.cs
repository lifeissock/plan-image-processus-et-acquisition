using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Controle1
{
    public partial class Form1 : Form
    {
        string[] imageFiles; // avoir le chemin de l'image
        string loadedImagePath; // chemin de l'image chargée
        int currentIndex = 0; // indice de l'image actuellement affichée

        public Form1()
        {
            InitializeComponent();

            timer1 = new Timer();
            timer1.Interval = 200; // Intervalle en millisecondes
            timer1.Tick += Timer1_Tick;

            button_analyse.Enabled = false;
        }

        private void ProcessImage(Bitmap originalImage)
        {
            DateTime startTime = DateTime.Now; // Heure de début du traitement

            // Extraction des plans de couleur
            Bitmap redPlane = ExtractColorPlane(originalImage, Color.Red);
            Bitmap greenPlane = ExtractColorPlane(originalImage, Color.Green);
            Bitmap bluePlane = ExtractColorPlane(originalImage, Color.Blue);

            // Seuillage des plans de couleur
            Bitmap binaryRed = ApplyThreshold(redPlane, 0); // Seuillage pour le rouge
            Bitmap binaryGreen = ApplyThreshold(greenPlane, 0); // Seuillage pour le vert
            Bitmap binaryBlue = ApplyThreshold(bluePlane, 0); // Seuillage pour le bleu

            // Affichage des images binaires dans les PictureBox
            pictureBox_rouge.Image = binaryRed;
            pictureBox_verte.Image = binaryGreen;
            pictureBox_bleue.Image = binaryBlue;

            TimeSpan processingTime = DateTime.Now - startTime; // Calcul du temps de traitement
            label_temps_traitement.Text = $"Temps de traitement : {processingTime.TotalMilliseconds} ms";
        }

        private Bitmap ApplyThreshold(Bitmap colorPlane, int threshold)
        {
            Bitmap binaryImage = new Bitmap(colorPlane.Width, colorPlane.Height);

            for (int y = 0; y < colorPlane.Height; y++)
            {
                for (int x = 0; x < colorPlane.Width; x++)
                {
                    Color pixelColor = colorPlane.GetPixel(x, y);

                    // Seuillage
                    if (pixelColor.R > threshold || pixelColor.G > threshold || pixelColor.B > threshold)
                    {
                        binaryImage.SetPixel(x, y, Color.White); // Blanc si une composante est supérieure au seuil
                    }
                    else
                    {
                        binaryImage.SetPixel(x, y, Color.Black); // Noir sinon
                    }
                }
            }

            return binaryImage;
        }

        private Bitmap ExtractColorPlane(Bitmap originalImage, Color color)
        {
            Bitmap colorPlane = new Bitmap(originalImage.Width, originalImage.Height);

            for (int y = 0; y < originalImage.Height; y++)
            {
                for (int x = 0; x < originalImage.Width; x++)
                {
                    Color pixelColor = originalImage.GetPixel(x, y);
                    // Vérification si la couleur du pixel correspond à la couleur spécifiée
                    bool isColor = (color == Color.Red && pixelColor.R > pixelColor.G && pixelColor.R > pixelColor.B) ||
                                   (color == Color.Green && pixelColor.G > pixelColor.R && pixelColor.G > pixelColor.B) ||
                                   (color == Color.Blue && pixelColor.B > pixelColor.R && pixelColor.B > pixelColor.G);
                    // Si la couleur correspond, le pixel est conservé, sinon il est mis à noir
                    colorPlane.SetPixel(x, y, isColor ? pixelColor : Color.Black);
                }
            }
            return colorPlane;
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            // Changer d'image automatiquement toutes les 200 ms
            currentIndex = (currentIndex + 1) % imageFiles.Length;
            loadedImagePath = imageFiles[currentIndex];
            Bitmap loadedImage = new Bitmap(loadedImagePath);
            ProcessImage(loadedImage);
            pictureBox_image.Image = loadedImage;
        }

        private void button_init_Click(object sender, EventArgs e)
        {
            // Choix du dossier contenant les images
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                // Charger toutes les images du dossier sélectionné
                imageFiles = Directory.GetFiles(folderBrowserDialog1.SelectedPath, "*.png");
                if (imageFiles.Length > 0)
                {
                    // Afficher la première image dans la PictureBox
                    loadedImagePath = imageFiles[0];
                    pictureBox_image.Image = Image.FromFile(loadedImagePath);
                    button_analyse.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Aucune image trouvée dans le dossier sélectionné.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button_analyse_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(loadedImagePath))
            {
                Bitmap loadedImage = new Bitmap(loadedImagePath);
                ProcessImage(loadedImage);

                // Démarrer le minuteur pour changer d'image automatiquement
                timer1.Start();
                button_analyse.Enabled = false;
            }
            else
            {
                MessageBox.Show("Veuillez d'abord choisir une image.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_arret_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled)
            {
                // Arrêter l'analyse
                timer1.Stop();
                button_arret.Text = "Relancer"; // Changer le texte du bouton en "Relancer"
            }
            else
            {
                // Relancer l'analyse
                timer1.Start();
                button_arret.Text = "Arrêter"; // Changer le texte du bouton en "Arrêter"
            }
        }

        private void button_fermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
