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
            this.label1 = new System.Windows.Forms.Label();
            this.labelScore = new System.Windows.Forms.Label();
            this.labelGameOver = new System.Windows.Forms.Label();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.gamePanel = new System.Windows.Forms.Panel();
            this.buttonRestart = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.playTab = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.scoresTab = new System.Windows.Forms.Label();
            this.onlineTab = new System.Windows.Forms.Label();
            this.groupTab = new System.Windows.Forms.Label();
            this.gamePanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 20F);
            this.label1.Location = new System.Drawing.Point(24, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "Score :";
            // 
            // labelScore
            // 
            this.labelScore.AutoSize = true;
            this.labelScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.labelScore.Location = new System.Drawing.Point(128, 51);
            this.labelScore.Name = "labelScore";
            this.labelScore.Size = new System.Drawing.Size(23, 25);
            this.labelScore.TabIndex = 2;
            this.labelScore.Text = "0";
            // 
            // labelGameOver
            // 
            this.labelGameOver.AutoSize = true;
            this.labelGameOver.BackColor = System.Drawing.SystemColors.HighlightText;
            this.labelGameOver.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelGameOver.ForeColor = System.Drawing.SystemColors.Desktop;
            this.labelGameOver.Location = new System.Drawing.Point(378, 197);
            this.labelGameOver.Name = "labelGameOver";
            this.labelGameOver.Padding = new System.Windows.Forms.Padding(20);
            this.labelGameOver.Size = new System.Drawing.Size(108, 54);
            this.labelGameOver.TabIndex = 3;
            this.labelGameOver.Text = "GAME OVER";
            this.labelGameOver.Visible = false;
            // 
            // gamePanel
            // 
            this.gamePanel.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.gamePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gamePanel.Controls.Add(this.buttonRestart);
            this.gamePanel.Controls.Add(this.labelGameOver);
            this.gamePanel.Font = new System.Drawing.Font("Harabara Mais Demo", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gamePanel.Location = new System.Drawing.Point(218, 113);
            this.gamePanel.Name = "gamePanel";
            this.gamePanel.Size = new System.Drawing.Size(879, 471);
            this.gamePanel.TabIndex = 4;
            // 
            // buttonRestart
            // 
            this.buttonRestart.ForeColor = System.Drawing.SystemColors.Desktop;
            this.buttonRestart.Location = new System.Drawing.Point(378, 269);
            this.buttonRestart.Name = "buttonRestart";
            this.buttonRestart.Size = new System.Drawing.Size(113, 23);
            this.buttonRestart.TabIndex = 4;
            this.buttonRestart.Text = "Recommencer";
            this.buttonRestart.UseVisualStyleBackColor = true;
            this.buttonRestart.Visible = false;
            this.buttonRestart.Click += new System.EventHandler(this.buttonRestart_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel1.Controls.Add(this.groupTab);
            this.panel1.Controls.Add(this.onlineTab);
            this.panel1.Controls.Add(this.scoresTab);
            this.panel1.Controls.Add(this.playTab);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(218, 583);
            this.panel1.TabIndex = 5;
            // 
            // playTab
            // 
            this.playTab.AutoSize = true;
            this.playTab.Font = new System.Drawing.Font("Pixeled", 15F);
            this.playTab.Location = new System.Drawing.Point(55, 182);
            this.playTab.Name = "playTab";
            this.playTab.Size = new System.Drawing.Size(117, 40);
            this.playTab.TabIndex = 10;
            this.playTab.Text = "Jouer";
            this.playTab.Click += new System.EventHandler(this.label2_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(218, 113);
            this.panel3.TabIndex = 5;
            // 
            // scoresTab
            // 
            this.scoresTab.AutoSize = true;
            this.scoresTab.Font = new System.Drawing.Font("Pixeled", 15F);
            this.scoresTab.Location = new System.Drawing.Point(44, 259);
            this.scoresTab.Name = "scoresTab";
            this.scoresTab.Size = new System.Drawing.Size(137, 40);
            this.scoresTab.TabIndex = 11;
            this.scoresTab.Text = "Scores";
            // 
            // onlineTab
            // 
            this.onlineTab.AutoSize = true;
            this.onlineTab.Font = new System.Drawing.Font("Pixeled", 15F);
            this.onlineTab.Location = new System.Drawing.Point(64, 338);
            this.onlineTab.Name = "onlineTab";
            this.onlineTab.Size = new System.Drawing.Size(97, 40);
            this.onlineTab.TabIndex = 12;
            this.onlineTab.Text = "Multi";
            // 
            // groupTab
            // 
            this.groupTab.AutoSize = true;
            this.groupTab.Font = new System.Drawing.Font("Pixeled", 15F);
            this.groupTab.Location = new System.Drawing.Point(23, 413);
            this.groupTab.Name = "groupTab";
            this.groupTab.Size = new System.Drawing.Size(185, 40);
            this.groupTab.TabIndex = 13;
            this.groupTab.Text = "Le groupe";
            // 
            // SnakeGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(1094, 583);
            this.Controls.Add(this.gamePanel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.labelScore);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SnakeGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.gamePanel.ResumeLayout(false);
            this.gamePanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelScore;
        private System.Windows.Forms.Label labelGameOver;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.Button buttonRestart;
        private System.Windows.Forms.Panel panel1;
        internal System.Windows.Forms.Panel gamePanel;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label playTab;
        private System.Windows.Forms.Label groupTab;
        private System.Windows.Forms.Label onlineTab;
        private System.Windows.Forms.Label scoresTab;
    }
}

