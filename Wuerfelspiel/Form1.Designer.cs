namespace Wuerfelspiel
{
    partial class Form1
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
            this.uc_Wuerfel1 = new Wuerfelspiel.Uc_Wuerfel();
            this.uc_Wuerfel2 = new Wuerfelspiel.Uc_Wuerfel();
            this.SuspendLayout();
            // 
            // uc_Wuerfel1
            // 
            this.uc_Wuerfel1.Location = new System.Drawing.Point(431, 82);
            this.uc_Wuerfel1.Name = "uc_Wuerfel1";
            this.uc_Wuerfel1.Size = new System.Drawing.Size(102, 102);
            this.uc_Wuerfel1.TabIndex = 0;
            // 
            // uc_Wuerfel2
            // 
            this.uc_Wuerfel2.Location = new System.Drawing.Point(233, 82);
            this.uc_Wuerfel2.Name = "uc_Wuerfel2";
            this.uc_Wuerfel2.Size = new System.Drawing.Size(83, 83);
            this.uc_Wuerfel2.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.uc_Wuerfel2);
            this.Controls.Add(this.uc_Wuerfel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private Uc_Wuerfel uc_Wuerfel1;
        private Uc_Wuerfel uc_Wuerfel2;
    }
}

