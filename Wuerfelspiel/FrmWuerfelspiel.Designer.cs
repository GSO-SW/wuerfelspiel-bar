namespace Wuerfelspiel
{
    partial class FrmWuerfelspiel
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbxSumme = new System.Windows.Forms.TextBox();
            this.lblSume = new System.Windows.Forms.Label();
            this.btnWuerfeln = new System.Windows.Forms.Button();
            this.lblErneutWuerfeln = new System.Windows.Forms.Label();
            this.tbxErneutWuerfeln = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tbxSumme
            // 
            this.tbxSumme.Location = new System.Drawing.Point(98, 19);
            this.tbxSumme.Name = "tbxSumme";
            this.tbxSumme.Size = new System.Drawing.Size(100, 26);
            this.tbxSumme.TabIndex = 0;
            this.tbxSumme.TextChanged += new System.EventHandler(this.tbxSumme_TextChanged);
            // 
            // lblSume
            // 
            this.lblSume.AutoSize = true;
            this.lblSume.Location = new System.Drawing.Point(24, 25);
            this.lblSume.Name = "lblSume";
            this.lblSume.Size = new System.Drawing.Size(68, 20);
            this.lblSume.TabIndex = 1;
            this.lblSume.Text = "Summe:";
            // 
            // btnWuerfeln
            // 
            this.btnWuerfeln.Location = new System.Drawing.Point(218, 170);
            this.btnWuerfeln.Name = "btnWuerfeln";
            this.btnWuerfeln.Size = new System.Drawing.Size(83, 30);
            this.btnWuerfeln.TabIndex = 2;
            this.btnWuerfeln.Text = "Würfeln";
            this.btnWuerfeln.UseVisualStyleBackColor = true;
            this.btnWuerfeln.Click += new System.EventHandler(this.btnWuerfeln_Click);
            // 
            // lblErneutWuerfeln
            // 
            this.lblErneutWuerfeln.AutoSize = true;
            this.lblErneutWuerfeln.Location = new System.Drawing.Point(24, 54);
            this.lblErneutWuerfeln.Name = "lblErneutWuerfeln";
            this.lblErneutWuerfeln.Size = new System.Drawing.Size(397, 20);
            this.lblErneutWuerfeln.TabIndex = 3;
            this.lblErneutWuerfeln.Text = "Mit wievielen Würfeln möchten sie erneut würfeln? (0-3)";
            this.lblErneutWuerfeln.Visible = false;
            // 
            // tbxErneutWuerfeln
            // 
            this.tbxErneutWuerfeln.Location = new System.Drawing.Point(427, 51);
            this.tbxErneutWuerfeln.Name = "tbxErneutWuerfeln";
            this.tbxErneutWuerfeln.Size = new System.Drawing.Size(100, 26);
            this.tbxErneutWuerfeln.TabIndex = 4;
            this.tbxErneutWuerfeln.Visible = false;
            this.tbxErneutWuerfeln.TextChanged += new System.EventHandler(this.tbxErneutWuerfeln_TextChanged);
            // 
            // FrmWuerfelspiel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 392);
            this.Controls.Add(this.tbxErneutWuerfeln);
            this.Controls.Add(this.lblErneutWuerfeln);
            this.Controls.Add(this.btnWuerfeln);
            this.Controls.Add(this.lblSume);
            this.Controls.Add(this.tbxSumme);
            this.Name = "FrmWuerfelspiel";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FrmWuerfelspiel_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxSumme;
        private System.Windows.Forms.Label lblSume;
        private System.Windows.Forms.Button btnWuerfeln;
        private System.Windows.Forms.Label lblErneutWuerfeln;
        private System.Windows.Forms.TextBox tbxErneutWuerfeln;
    }
}

