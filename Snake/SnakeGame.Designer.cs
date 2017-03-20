namespace SnakeProject
{
    partial class SnakeGame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SnakeGame));
            this.label1 = new System.Windows.Forms.Label();
            this.labelScore = new System.Windows.Forms.Label();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.gamePanel = new System.Windows.Forms.Panel();
            this.gameOverPanel = new System.Windows.Forms.Panel();
            this.labelSaveOk = new System.Windows.Forms.Label();
            this.labelSaveName = new System.Windows.Forms.Label();
            this.boxPseudo = new System.Windows.Forms.TextBox();
            this.labelRestart = new System.Windows.Forms.Label();
            this.labelSave = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labelEndScore = new System.Windows.Forms.Label();
            this.labelGameOver = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelGroupe = new System.Windows.Forms.Label();
            this.onlineTab = new System.Windows.Forms.Label();
            this.labelPlay = new System.Windows.Forms.Label();
            this.scoresTab = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.labelReduce = new System.Windows.Forms.Label();
            this.labelClose = new System.Windows.Forms.Label();
            this.contentPanel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.gamePanel.SuspendLayout();
            this.gameOverPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.contentPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 20F);
            this.label1.Location = new System.Drawing.Point(511, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "Score :";
            this.label1.Visible = false;
            // 
            // labelScore
            // 
            this.labelScore.AutoSize = true;
            this.labelScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.labelScore.Location = new System.Drawing.Point(604, 49);
            this.labelScore.Name = "labelScore";
            this.labelScore.Size = new System.Drawing.Size(23, 25);
            this.labelScore.TabIndex = 2;
            this.labelScore.Text = "0";
            this.labelScore.Visible = false;
            // 
            // gamePanel
            // 
            this.gamePanel.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.gamePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gamePanel.Controls.Add(this.gameOverPanel);
            this.gamePanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gamePanel.Location = new System.Drawing.Point(9, 9);
            this.gamePanel.Name = "gamePanel";
            this.gamePanel.Size = new System.Drawing.Size(860, 460);
            this.gamePanel.TabIndex = 4;
            // 
            // gameOverPanel
            // 
            this.gameOverPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(126)))), ((int)(((byte)(49)))));
            this.gameOverPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gameOverPanel.Controls.Add(this.labelSaveOk);
            this.gameOverPanel.Controls.Add(this.labelSaveName);
            this.gameOverPanel.Controls.Add(this.boxPseudo);
            this.gameOverPanel.Controls.Add(this.labelRestart);
            this.gameOverPanel.Controls.Add(this.labelSave);
            this.gameOverPanel.Controls.Add(this.label5);
            this.gameOverPanel.Controls.Add(this.labelEndScore);
            this.gameOverPanel.Controls.Add(this.labelGameOver);
            this.gameOverPanel.Location = new System.Drawing.Point(158, 64);
            this.gameOverPanel.Name = "gameOverPanel";
            this.gameOverPanel.Size = new System.Drawing.Size(584, 249);
            this.gameOverPanel.TabIndex = 1;
            this.gameOverPanel.Visible = false;
            // 
            // labelSaveOk
            // 
            this.labelSaveOk.AutoSize = true;
            this.labelSaveOk.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.labelSaveOk.Location = new System.Drawing.Point(29, 179);
            this.labelSaveOk.Name = "labelSaveOk";
            this.labelSaveOk.Size = new System.Drawing.Size(273, 25);
            this.labelSaveOk.TabIndex = 11;
            this.labelSaveOk.Text = "Votre score a été sauvegardé.";
            this.labelSaveOk.Visible = false;
            // 
            // labelSaveName
            // 
            this.labelSaveName.AutoSize = true;
            this.labelSaveName.Location = new System.Drawing.Point(31, 127);
            this.labelSaveName.Name = "labelSaveName";
            this.labelSaveName.Size = new System.Drawing.Size(55, 13);
            this.labelSaveName.TabIndex = 10;
            this.labelSaveName.Text = "Votre nom";
            // 
            // boxPseudo
            // 
            this.boxPseudo.Location = new System.Drawing.Point(34, 143);
            this.boxPseudo.Name = "boxPseudo";
            this.boxPseudo.Size = new System.Drawing.Size(100, 20);
            this.boxPseudo.TabIndex = 9;
            this.boxPseudo.TextChanged += new System.EventHandler(this.boxPseudo_TextChanged);
            // 
            // labelRestart
            // 
            this.labelRestart.AutoSize = true;
            this.labelRestart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelRestart.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.labelRestart.Location = new System.Drawing.Point(431, 127);
            this.labelRestart.Name = "labelRestart";
            this.labelRestart.Size = new System.Drawing.Size(99, 29);
            this.labelRestart.TabIndex = 1;
            this.labelRestart.Text = "Rejouer";
            this.labelRestart.Click += new System.EventHandler(this.labelRestart_Click);
            // 
            // labelSave
            // 
            this.labelSave.AutoSize = true;
            this.labelSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.labelSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.labelSave.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.labelSave.Location = new System.Drawing.Point(29, 178);
            this.labelSave.Name = "labelSave";
            this.labelSave.Size = new System.Drawing.Size(226, 26);
            this.labelSave.TabIndex = 8;
            this.labelSave.Text = "Enregistrer mon score";
            this.labelSave.Click += new System.EventHandler(this.labelSave_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F);
            this.label5.Location = new System.Drawing.Point(29, 89);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(139, 29);
            this.label5.TabIndex = 7;
            this.label5.Text = "Score final :";
            // 
            // labelEndScore
            // 
            this.labelEndScore.AutoSize = true;
            this.labelEndScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.labelEndScore.Location = new System.Drawing.Point(174, 89);
            this.labelEndScore.Name = "labelEndScore";
            this.labelEndScore.Size = new System.Drawing.Size(26, 29);
            this.labelEndScore.TabIndex = 6;
            this.labelEndScore.Text = "0";
            // 
            // labelGameOver
            // 
            this.labelGameOver.AutoSize = true;
            this.labelGameOver.Font = new System.Drawing.Font("Verdana", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGameOver.Location = new System.Drawing.Point(208, 23);
            this.labelGameOver.Name = "labelGameOver";
            this.labelGameOver.Size = new System.Drawing.Size(178, 35);
            this.labelGameOver.TabIndex = 5;
            this.labelGameOver.Text = "Game Over";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.panel1.Controls.Add(this.labelGroupe);
            this.panel1.Controls.Add(this.onlineTab);
            this.panel1.Controls.Add(this.labelPlay);
            this.panel1.Controls.Add(this.scoresTab);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(218, 594);
            this.panel1.TabIndex = 5;
            // 
            // labelGroupe
            // 
            this.labelGroupe.AutoSize = true;
            this.labelGroupe.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelGroupe.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.labelGroupe.Location = new System.Drawing.Point(26, 308);
            this.labelGroupe.Name = "labelGroupe";
            this.labelGroupe.Size = new System.Drawing.Size(100, 25);
            this.labelGroupe.TabIndex = 13;
            this.labelGroupe.Text = "Le groupe";
            this.labelGroupe.Click += new System.EventHandler(this.labelGroupe_Click);
            // 
            // onlineTab
            // 
            this.onlineTab.AutoSize = true;
            this.onlineTab.Cursor = System.Windows.Forms.Cursors.Hand;
            this.onlineTab.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.onlineTab.Location = new System.Drawing.Point(26, 258);
            this.onlineTab.Name = "onlineTab";
            this.onlineTab.Size = new System.Drawing.Size(89, 25);
            this.onlineTab.TabIndex = 12;
            this.onlineTab.Text = "En Ligne";
            // 
            // labelPlay
            // 
            this.labelPlay.AutoSize = true;
            this.labelPlay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelPlay.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.labelPlay.Location = new System.Drawing.Point(26, 164);
            this.labelPlay.Name = "labelPlay";
            this.labelPlay.Size = new System.Drawing.Size(62, 25);
            this.labelPlay.TabIndex = 10;
            this.labelPlay.Text = "Jouer";
            this.labelPlay.Click += new System.EventHandler(this.labelPlay_Click);
            // 
            // scoresTab
            // 
            this.scoresTab.AutoSize = true;
            this.scoresTab.Cursor = System.Windows.Forms.Cursors.Hand;
            this.scoresTab.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.scoresTab.Location = new System.Drawing.Point(26, 210);
            this.scoresTab.Name = "scoresTab";
            this.scoresTab.Size = new System.Drawing.Size(74, 25);
            this.scoresTab.TabIndex = 11;
            this.scoresTab.Text = "Scores";
            this.scoresTab.Click += new System.EventHandler(this.scoresTab_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(126)))), ((int)(((byte)(49)))));
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(218, 113);
            this.panel3.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(31, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(153, 87);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label3);
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(214, 109);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(880, 480);
            this.panel2.TabIndex = 5;
            this.panel2.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.label3.Location = new System.Drawing.Point(348, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 39);
            this.label3.TabIndex = 6;
            this.label3.Text = "Snake";
            // 
            // labelReduce
            // 
            this.labelReduce.AutoSize = true;
            this.labelReduce.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelReduce.Font = new System.Drawing.Font("Tahoma", 24.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelReduce.Location = new System.Drawing.Point(989, 23);
            this.labelReduce.Name = "labelReduce";
            this.labelReduce.Size = new System.Drawing.Size(29, 40);
            this.labelReduce.TabIndex = 6;
            this.labelReduce.Text = "-";
            this.labelReduce.Click += new System.EventHandler(this.reduceLabel_Click);
            // 
            // labelClose
            // 
            this.labelClose.AutoSize = true;
            this.labelClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelClose.Font = new System.Drawing.Font("Tahoma", 24.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelClose.Location = new System.Drawing.Point(1042, 23);
            this.labelClose.Name = "labelClose";
            this.labelClose.Size = new System.Drawing.Size(36, 40);
            this.labelClose.TabIndex = 7;
            this.labelClose.Text = "X";
            this.labelClose.Click += new System.EventHandler(this.labelClose_Click);
            // 
            // contentPanel
            // 
            this.contentPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(126)))), ((int)(((byte)(49)))));
            this.contentPanel.Controls.Add(this.gamePanel);
            this.contentPanel.Location = new System.Drawing.Point(218, 113);
            this.contentPanel.Name = "contentPanel";
            this.contentPanel.Size = new System.Drawing.Size(889, 481);
            this.contentPanel.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 27F);
            this.label2.Location = new System.Drawing.Point(240, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 40);
            this.label2.TabIndex = 8;
            this.label2.Text = "SnakeC#";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label4.Location = new System.Drawing.Point(691, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(155, 27);
            this.label4.TabIndex = 9;
            this.label4.Text = "Pause (ENTER)";
            this.label4.Visible = false;
            // 
            // SnakeGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.ClientSize = new System.Drawing.Size(1099, 594);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.contentPanel);
            this.Controls.Add(this.labelClose);
            this.Controls.Add(this.labelReduce);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.labelScore);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SnakeGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.gamePanel.ResumeLayout(false);
            this.gameOverPanel.ResumeLayout(false);
            this.gameOverPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.contentPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelScore;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.Panel panel1;
        internal System.Windows.Forms.Panel gamePanel;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label labelPlay;
        private System.Windows.Forms.Label labelGroupe;
        private System.Windows.Forms.Label onlineTab;
        private System.Windows.Forms.Label scoresTab;
        private System.Windows.Forms.Panel gameOverPanel;
        private System.Windows.Forms.Label labelReduce;
        private System.Windows.Forms.Label labelClose;
        private System.Windows.Forms.Label labelRestart;
        private System.Windows.Forms.Label labelSave;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelEndScore;
        private System.Windows.Forms.Label labelGameOver;
        internal System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelSaveName;
        private System.Windows.Forms.TextBox boxPseudo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelSaveOk;
        private System.Windows.Forms.Panel contentPanel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
    }
}

