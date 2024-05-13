
namespace Controle1
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pictureBox_image = new System.Windows.Forms.PictureBox();
            this.button_init = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.button_analyse = new System.Windows.Forms.Button();
            this.pictureBox_rouge = new System.Windows.Forms.PictureBox();
            this.pictureBox_verte = new System.Windows.Forms.PictureBox();
            this.pictureBox_bleue = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button_arret = new System.Windows.Forms.Button();
            this.button_fermer = new System.Windows.Forms.Button();
            this.label_temps_traitement = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_image)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_rouge)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_verte)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_bleue)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox_image
            // 
            this.pictureBox_image.Location = new System.Drawing.Point(106, 35);
            this.pictureBox_image.Name = "pictureBox_image";
            this.pictureBox_image.Size = new System.Drawing.Size(311, 315);
            this.pictureBox_image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_image.TabIndex = 0;
            this.pictureBox_image.TabStop = false;
            // 
            // button_init
            // 
            this.button_init.Location = new System.Drawing.Point(12, 379);
            this.button_init.Name = "button_init";
            this.button_init.Size = new System.Drawing.Size(105, 35);
            this.button_init.TabIndex = 1;
            this.button_init.Text = "Initialisation";
            this.button_init.UseVisualStyleBackColor = true;
            this.button_init.Click += new System.EventHandler(this.button_init_Click);
            // 
            // button_analyse
            // 
            this.button_analyse.Location = new System.Drawing.Point(123, 379);
            this.button_analyse.Name = "button_analyse";
            this.button_analyse.Size = new System.Drawing.Size(101, 35);
            this.button_analyse.TabIndex = 2;
            this.button_analyse.Text = "Analyse";
            this.button_analyse.UseVisualStyleBackColor = true;
            this.button_analyse.Click += new System.EventHandler(this.button_analyse_Click);
            // 
            // pictureBox_rouge
            // 
            this.pictureBox_rouge.Location = new System.Drawing.Point(468, 12);
            this.pictureBox_rouge.Name = "pictureBox_rouge";
            this.pictureBox_rouge.Size = new System.Drawing.Size(205, 121);
            this.pictureBox_rouge.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_rouge.TabIndex = 3;
            this.pictureBox_rouge.TabStop = false;
            // 
            // pictureBox_verte
            // 
            this.pictureBox_verte.Location = new System.Drawing.Point(468, 139);
            this.pictureBox_verte.Name = "pictureBox_verte";
            this.pictureBox_verte.Size = new System.Drawing.Size(205, 121);
            this.pictureBox_verte.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_verte.TabIndex = 4;
            this.pictureBox_verte.TabStop = false;
            // 
            // pictureBox_bleue
            // 
            this.pictureBox_bleue.Location = new System.Drawing.Point(468, 266);
            this.pictureBox_bleue.Name = "pictureBox_bleue";
            this.pictureBox_bleue.Size = new System.Drawing.Size(205, 121);
            this.pictureBox_bleue.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_bleue.TabIndex = 5;
            this.pictureBox_bleue.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 200;
            // 
            // button_arret
            // 
            this.button_arret.Location = new System.Drawing.Point(230, 379);
            this.button_arret.Name = "button_arret";
            this.button_arret.Size = new System.Drawing.Size(101, 35);
            this.button_arret.TabIndex = 6;
            this.button_arret.Text = "Arret";
            this.button_arret.UseVisualStyleBackColor = true;
            this.button_arret.Click += new System.EventHandler(this.button_arret_Click);
            // 
            // button_fermer
            // 
            this.button_fermer.Location = new System.Drawing.Point(337, 379);
            this.button_fermer.Name = "button_fermer";
            this.button_fermer.Size = new System.Drawing.Size(101, 35);
            this.button_fermer.TabIndex = 7;
            this.button_fermer.Text = "Fermer";
            this.button_fermer.UseVisualStyleBackColor = true;
            this.button_fermer.Click += new System.EventHandler(this.button_fermer_Click);
            // 
            // label_temps_traitement
            // 
            this.label_temps_traitement.AutoSize = true;
            this.label_temps_traitement.Location = new System.Drawing.Point(512, 394);
            this.label_temps_traitement.Name = "label_temps_traitement";
            this.label_temps_traitement.Size = new System.Drawing.Size(0, 20);
            this.label_temps_traitement.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label_temps_traitement);
            this.Controls.Add(this.button_fermer);
            this.Controls.Add(this.button_arret);
            this.Controls.Add(this.pictureBox_bleue);
            this.Controls.Add(this.pictureBox_verte);
            this.Controls.Add(this.pictureBox_rouge);
            this.Controls.Add(this.button_analyse);
            this.Controls.Add(this.button_init);
            this.Controls.Add(this.pictureBox_image);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_image)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_rouge)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_verte)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_bleue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox_image;
        private System.Windows.Forms.Button button_init;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button button_analyse;
        private System.Windows.Forms.PictureBox pictureBox_rouge;
        private System.Windows.Forms.PictureBox pictureBox_verte;
        private System.Windows.Forms.PictureBox pictureBox_bleue;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button_arret;
        private System.Windows.Forms.Button button_fermer;
        private System.Windows.Forms.Label label_temps_traitement;
    }
}

