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
            this.lblWuerfelEins = new System.Windows.Forms.Label();
            this.lblWuerfelZwei = new System.Windows.Forms.Label();
            this.lblWuerfelDrei = new System.Windows.Forms.Label();
            this.lblWuerfelVier = new System.Windows.Forms.Label();
            this.lblWuerfelFuenf = new System.Windows.Forms.Label();
            this.tbxWuerfelEins = new System.Windows.Forms.TextBox();
            this.tbxWuerfelZwei = new System.Windows.Forms.TextBox();
            this.tbxWuerfelFuenf = new System.Windows.Forms.TextBox();
            this.tbxWuerfelDrei = new System.Windows.Forms.TextBox();
            this.tbxWuerfelVier = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tbxSumme
            // 
            this.tbxSumme.Location = new System.Drawing.Point(164, 363);
            this.tbxSumme.Name = "tbxSumme";
            this.tbxSumme.Size = new System.Drawing.Size(100, 26);
            this.tbxSumme.TabIndex = 0;
            this.tbxSumme.TextChanged += new System.EventHandler(this.tbxSumme_TextChanged);
            // 
            // lblSume
            // 
            this.lblSume.AutoSize = true;
            this.lblSume.Location = new System.Drawing.Point(94, 369);
            this.lblSume.Name = "lblSume";
            this.lblSume.Size = new System.Drawing.Size(68, 20);
            this.lblSume.TabIndex = 1;
            this.lblSume.Text = "Summe:";
            // 
            // btnWuerfeln
            // 
            this.btnWuerfeln.Location = new System.Drawing.Point(349, 471);
            this.btnWuerfeln.Name = "btnWuerfeln";
            this.btnWuerfeln.Size = new System.Drawing.Size(83, 30);
            this.btnWuerfeln.TabIndex = 2;
            this.btnWuerfeln.Text = "Würfeln";
            this.btnWuerfeln.UseVisualStyleBackColor = true;
            this.btnWuerfeln.Click += new System.EventHandler(this.btnWuerfeln_Click);
            // 
            // lblWuerfelEins
            // 
            this.lblWuerfelEins.AutoSize = true;
            this.lblWuerfelEins.Location = new System.Drawing.Point(82, 401);
            this.lblWuerfelEins.Name = "lblWuerfelEins";
            this.lblWuerfelEins.Size = new System.Drawing.Size(76, 20);
            this.lblWuerfelEins.TabIndex = 3;
            this.lblWuerfelEins.Text = "1. Würfel:";
            // 
            // lblWuerfelZwei
            // 
            this.lblWuerfelZwei.AutoSize = true;
            this.lblWuerfelZwei.Location = new System.Drawing.Point(82, 439);
            this.lblWuerfelZwei.Name = "lblWuerfelZwei";
            this.lblWuerfelZwei.Size = new System.Drawing.Size(76, 20);
            this.lblWuerfelZwei.TabIndex = 4;
            this.lblWuerfelZwei.Text = "2. Würfel:";
            // 
            // lblWuerfelDrei
            // 
            this.lblWuerfelDrei.AutoSize = true;
            this.lblWuerfelDrei.Location = new System.Drawing.Point(82, 479);
            this.lblWuerfelDrei.Name = "lblWuerfelDrei";
            this.lblWuerfelDrei.Size = new System.Drawing.Size(76, 20);
            this.lblWuerfelDrei.TabIndex = 5;
            this.lblWuerfelDrei.Text = "3. Würfel:";
            // 
            // lblWuerfelVier
            // 
            this.lblWuerfelVier.AutoSize = true;
            this.lblWuerfelVier.Location = new System.Drawing.Point(82, 516);
            this.lblWuerfelVier.Name = "lblWuerfelVier";
            this.lblWuerfelVier.Size = new System.Drawing.Size(76, 20);
            this.lblWuerfelVier.TabIndex = 6;
            this.lblWuerfelVier.Text = "4. Würfel:";
            // 
            // lblWuerfelFuenf
            // 
            this.lblWuerfelFuenf.AutoSize = true;
            this.lblWuerfelFuenf.Location = new System.Drawing.Point(82, 554);
            this.lblWuerfelFuenf.Name = "lblWuerfelFuenf";
            this.lblWuerfelFuenf.Size = new System.Drawing.Size(76, 20);
            this.lblWuerfelFuenf.TabIndex = 7;
            this.lblWuerfelFuenf.Text = "5. Würfel:";
            // 
            // tbxWuerfelEins
            // 
            this.tbxWuerfelEins.Location = new System.Drawing.Point(164, 395);
            this.tbxWuerfelEins.Name = "tbxWuerfelEins";
            this.tbxWuerfelEins.Size = new System.Drawing.Size(100, 26);
            this.tbxWuerfelEins.TabIndex = 8;
            // 
            // tbxWuerfelZwei
            // 
            this.tbxWuerfelZwei.Location = new System.Drawing.Point(164, 436);
            this.tbxWuerfelZwei.Name = "tbxWuerfelZwei";
            this.tbxWuerfelZwei.Size = new System.Drawing.Size(100, 26);
            this.tbxWuerfelZwei.TabIndex = 9;
            // 
            // tbxWuerfelFuenf
            // 
            this.tbxWuerfelFuenf.Location = new System.Drawing.Point(164, 548);
            this.tbxWuerfelFuenf.Name = "tbxWuerfelFuenf";
            this.tbxWuerfelFuenf.Size = new System.Drawing.Size(100, 26);
            this.tbxWuerfelFuenf.TabIndex = 12;
            // 
            // tbxWuerfelDrei
            // 
            this.tbxWuerfelDrei.Location = new System.Drawing.Point(164, 473);
            this.tbxWuerfelDrei.Name = "tbxWuerfelDrei";
            this.tbxWuerfelDrei.Size = new System.Drawing.Size(100, 26);
            this.tbxWuerfelDrei.TabIndex = 13;
            // 
            // tbxWuerfelVier
            // 
            this.tbxWuerfelVier.Location = new System.Drawing.Point(164, 513);
            this.tbxWuerfelVier.Name = "tbxWuerfelVier";
            this.tbxWuerfelVier.Size = new System.Drawing.Size(100, 26);
            this.tbxWuerfelVier.TabIndex = 14;
            // 
            // FrmWuerfelspiel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 944);
            this.Controls.Add(this.tbxWuerfelVier);
            this.Controls.Add(this.tbxWuerfelDrei);
            this.Controls.Add(this.tbxWuerfelFuenf);
            this.Controls.Add(this.tbxWuerfelZwei);
            this.Controls.Add(this.tbxWuerfelEins);
            this.Controls.Add(this.lblWuerfelFuenf);
            this.Controls.Add(this.lblWuerfelVier);
            this.Controls.Add(this.lblWuerfelDrei);
            this.Controls.Add(this.lblWuerfelZwei);
            this.Controls.Add(this.lblWuerfelEins);
            this.Controls.Add(this.btnWuerfeln);
            this.Controls.Add(this.lblSume);
            this.Controls.Add(this.tbxSumme);
            this.Name = "FrmWuerfelspiel";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FrmWuerfelspiel_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.FrmWuerfelspiel_Paint);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxSumme;
        private System.Windows.Forms.Label lblSume;
        private System.Windows.Forms.Button btnWuerfeln;
        private System.Windows.Forms.Label lblWuerfelEins;
        private System.Windows.Forms.Label lblWuerfelZwei;
        private System.Windows.Forms.Label lblWuerfelDrei;
        private System.Windows.Forms.Label lblWuerfelVier;
        private System.Windows.Forms.Label lblWuerfelFuenf;
        private System.Windows.Forms.TextBox tbxWuerfelEins;
        private System.Windows.Forms.TextBox tbxWuerfelZwei;
        private System.Windows.Forms.TextBox tbxWuerfelFuenf;
        private System.Windows.Forms.TextBox tbxWuerfelDrei;
        private System.Windows.Forms.TextBox tbxWuerfelVier;
    }
}

