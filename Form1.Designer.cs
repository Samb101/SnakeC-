namespace WindowsFormsApplication2
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
            this.label1 = new System.Windows.Forms.Label();
            this.labelScore = new System.Windows.Forms.Label();
            this.labelGameOver = new System.Windows.Forms.Label();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.gamePanel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 20F);
            this.label1.Location = new System.Drawing.Point(12, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "Score :";
            // 
            // labelScore
            // 
            this.labelScore.AutoSize = true;
            this.labelScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.labelScore.Location = new System.Drawing.Point(117, 51);
            this.labelScore.Name = "labelScore";
            this.labelScore.Size = new System.Drawing.Size(105, 25);
            this.labelScore.TabIndex = 2;
            this.labelScore.Text = "labelScore";
            // 
            // labelGameOver
            // 
            this.labelGameOver.AutoSize = true;
            this.labelGameOver.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelGameOver.Location = new System.Drawing.Point(290, 290);
            this.labelGameOver.Name = "labelGameOver";
            this.labelGameOver.Padding = new System.Windows.Forms.Padding(10);
            this.labelGameOver.Size = new System.Drawing.Size(93, 35);
            this.labelGameOver.TabIndex = 3;
            this.labelGameOver.Text = "GAME OVER";
            this.labelGameOver.Visible = false;
            // 
            // gamePanel
            // 
            this.gamePanel.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.gamePanel.Location = new System.Drawing.Point(18, 90);
            this.gamePanel.Name = "gamePanel";
            this.gamePanel.Size = new System.Drawing.Size(677, 413);
            this.gamePanel.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(717, 530);
            this.Controls.Add(this.labelGameOver);
            this.Controls.Add(this.gamePanel);
            this.Controls.Add(this.labelScore);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelScore;
        private System.Windows.Forms.Label labelGameOver;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.Panel gamePanel;
    }
}

