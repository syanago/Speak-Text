namespace Speak_Text
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
            this.textForSono = new System.Windows.Forms.RichTextBox();
            this.play = new System.Windows.Forms.Button();
            this.pause = new System.Windows.Forms.Button();
            this.stop = new System.Windows.Forms.Button();
            this.resume = new System.Windows.Forms.Button();
            this.btnChooseFile = new System.Windows.Forms.Button();
            this.btnChooseDir = new System.Windows.Forms.Button();
            this.lblChooseFile = new System.Windows.Forms.Label();
            this.lblChooseDir = new System.Windows.Forms.Label();
            this.chooseFile = new System.Windows.Forms.OpenFileDialog();
            this.chooseDir = new System.Windows.Forms.FolderBrowserDialog();
            this.go = new System.Windows.Forms.Button();
            this.logBox = new System.Windows.Forms.RichTextBox();
            this.cmbVoix = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEnregistrer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textForSono
            // 
            this.textForSono.Location = new System.Drawing.Point(12, 12);
            this.textForSono.Name = "textForSono";
            this.textForSono.Size = new System.Drawing.Size(627, 151);
            this.textForSono.TabIndex = 0;
            this.textForSono.Text = "";
            // 
            // play
            // 
            this.play.Location = new System.Drawing.Point(12, 167);
            this.play.Name = "play";
            this.play.Size = new System.Drawing.Size(120, 25);
            this.play.TabIndex = 1;
            this.play.Text = "Jouer";
            this.play.UseVisualStyleBackColor = true;
            this.play.Click += new System.EventHandler(this.Play_Click);
            // 
            // pause
            // 
            this.pause.Location = new System.Drawing.Point(141, 167);
            this.pause.Name = "pause";
            this.pause.Size = new System.Drawing.Size(120, 25);
            this.pause.TabIndex = 2;
            this.pause.Text = "Pause";
            this.pause.UseVisualStyleBackColor = true;
            this.pause.Click += new System.EventHandler(this.Pause_Click);
            // 
            // stop
            // 
            this.stop.Location = new System.Drawing.Point(393, 169);
            this.stop.Name = "stop";
            this.stop.Size = new System.Drawing.Size(120, 25);
            this.stop.TabIndex = 3;
            this.stop.Text = "Stop";
            this.stop.UseVisualStyleBackColor = true;
            this.stop.Click += new System.EventHandler(this.Stop_Click);
            // 
            // resume
            // 
            this.resume.Location = new System.Drawing.Point(267, 167);
            this.resume.Name = "resume";
            this.resume.Size = new System.Drawing.Size(120, 25);
            this.resume.TabIndex = 4;
            this.resume.Text = "Reprendre";
            this.resume.UseVisualStyleBackColor = true;
            this.resume.Click += new System.EventHandler(this.Resume_Click);
            // 
            // btnChooseFile
            // 
            this.btnChooseFile.Location = new System.Drawing.Point(139, 205);
            this.btnChooseFile.Name = "btnChooseFile";
            this.btnChooseFile.Size = new System.Drawing.Size(40, 23);
            this.btnChooseFile.TabIndex = 5;
            this.btnChooseFile.Text = "...";
            this.btnChooseFile.UseVisualStyleBackColor = true;
            this.btnChooseFile.Click += new System.EventHandler(this.BtnChooseFile_Click);
            // 
            // btnChooseDir
            // 
            this.btnChooseDir.Location = new System.Drawing.Point(425, 205);
            this.btnChooseDir.Name = "btnChooseDir";
            this.btnChooseDir.Size = new System.Drawing.Size(40, 23);
            this.btnChooseDir.TabIndex = 6;
            this.btnChooseDir.Text = "...";
            this.btnChooseDir.UseVisualStyleBackColor = true;
            this.btnChooseDir.Click += new System.EventHandler(this.BtnChooseDir_Click);
            // 
            // lblChooseFile
            // 
            this.lblChooseFile.AutoSize = true;
            this.lblChooseFile.Location = new System.Drawing.Point(9, 208);
            this.lblChooseFile.Name = "lblChooseFile";
            this.lblChooseFile.Size = new System.Drawing.Size(129, 17);
            this.lblChooseFile.TabIndex = 7;
            this.lblChooseFile.Text = "Sélectionner fichier";
            // 
            // lblChooseDir
            // 
            this.lblChooseDir.AutoSize = true;
            this.lblChooseDir.Location = new System.Drawing.Point(289, 208);
            this.lblChooseDir.Name = "lblChooseDir";
            this.lblChooseDir.Size = new System.Drawing.Size(137, 17);
            this.lblChooseDir.TabIndex = 8;
            this.lblChooseDir.Text = "Sélectionner dossier";
            // 
            // chooseFile
            // 
            this.chooseFile.DefaultExt = "xls";
            this.chooseFile.FileName = "openFileDialog1";
            this.chooseFile.InitialDirectory = "c:\\";
            this.chooseFile.Title = "Sélectionner un fichier xls";
            // 
            // go
            // 
            this.go.Location = new System.Drawing.Point(496, 205);
            this.go.Name = "go";
            this.go.Size = new System.Drawing.Size(143, 23);
            this.go.TabIndex = 10;
            this.go.Text = "Go!";
            this.go.UseVisualStyleBackColor = true;
            this.go.Click += new System.EventHandler(this.Go_Click);
            // 
            // logBox
            // 
            this.logBox.BackColor = System.Drawing.SystemColors.MenuBar;
            this.logBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.logBox.Location = new System.Drawing.Point(12, 252);
            this.logBox.Name = "logBox";
            this.logBox.ReadOnly = true;
            this.logBox.Size = new System.Drawing.Size(627, 186);
            this.logBox.TabIndex = 11;
            this.logBox.Text = "";
            // 
            // cmbVoix
            // 
            this.cmbVoix.AllowDrop = true;
            this.cmbVoix.FormattingEnabled = true;
            this.cmbVoix.Location = new System.Drawing.Point(642, 34);
            this.cmbVoix.Name = "cmbVoix";
            this.cmbVoix.Size = new System.Drawing.Size(220, 24);
            this.cmbVoix.TabIndex = 12;
            this.cmbVoix.SelectedIndexChanged += new System.EventHandler(this.CmbVoix_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(645, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 17);
            this.label1.TabIndex = 13;
            this.label1.Text = "Choisir une voix";
            // 
            // btnEnregistrer
            // 
            this.btnEnregistrer.Location = new System.Drawing.Point(519, 169);
            this.btnEnregistrer.Name = "btnEnregistrer";
            this.btnEnregistrer.Size = new System.Drawing.Size(120, 25);
            this.btnEnregistrer.TabIndex = 14;
            this.btnEnregistrer.Text = "Enregistrer";
            this.btnEnregistrer.UseVisualStyleBackColor = true;
            this.btnEnregistrer.Click += new System.EventHandler(this.BtnEnregistrer_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 500);
            this.Controls.Add(this.btnEnregistrer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbVoix);
            this.Controls.Add(this.logBox);
            this.Controls.Add(this.go);
            this.Controls.Add(this.lblChooseDir);
            this.Controls.Add(this.lblChooseFile);
            this.Controls.Add(this.btnChooseDir);
            this.Controls.Add(this.btnChooseFile);
            this.Controls.Add(this.resume);
            this.Controls.Add(this.stop);
            this.Controls.Add(this.pause);
            this.Controls.Add(this.play);
            this.Controls.Add(this.textForSono);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox textForSono;
        private System.Windows.Forms.Button play;
        private System.Windows.Forms.Button pause;
        private System.Windows.Forms.Button stop;
        private System.Windows.Forms.Button resume;
        private System.Windows.Forms.Button btnChooseFile;
        private System.Windows.Forms.Button btnChooseDir;
        private System.Windows.Forms.Label lblChooseFile;
        private System.Windows.Forms.Label lblChooseDir;
        private System.Windows.Forms.OpenFileDialog chooseFile;
        private System.Windows.Forms.FolderBrowserDialog chooseDir;
        private System.Windows.Forms.Button go;
        private System.Windows.Forms.RichTextBox logBox;
        private System.Windows.Forms.ComboBox cmbVoix;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEnregistrer;
    }
}

