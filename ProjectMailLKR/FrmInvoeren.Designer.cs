namespace ProjectMailLKR
{
    partial class FrmInvoeren
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAnnuleren = new System.Windows.Forms.Button();
            this.btnToevoegen = new System.Windows.Forms.Button();
            this.lblVoornaam = new System.Windows.Forms.Label();
            this.lblAchternaam = new System.Windows.Forms.Label();
            this.txtVoornaam = new System.Windows.Forms.TextBox();
            this.txtAchternaam = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnAnnuleren
            // 
            this.btnAnnuleren.Location = new System.Drawing.Point(273, 163);
            this.btnAnnuleren.Name = "btnAnnuleren";
            this.btnAnnuleren.Size = new System.Drawing.Size(178, 52);
            this.btnAnnuleren.TabIndex = 3;
            this.btnAnnuleren.Text = "Annuleren";
            this.btnAnnuleren.UseVisualStyleBackColor = true;
            this.btnAnnuleren.Click += new System.EventHandler(this.btnAnnuleren_Click);
            // 
            // btnToevoegen
            // 
            this.btnToevoegen.Location = new System.Drawing.Point(12, 163);
            this.btnToevoegen.Name = "btnToevoegen";
            this.btnToevoegen.Size = new System.Drawing.Size(178, 52);
            this.btnToevoegen.TabIndex = 2;
            this.btnToevoegen.Text = "Toevoegen";
            this.btnToevoegen.UseVisualStyleBackColor = true;
            this.btnToevoegen.Click += new System.EventHandler(this.btnToevoegen_Click);
            // 
            // lblVoornaam
            // 
            this.lblVoornaam.AutoSize = true;
            this.lblVoornaam.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVoornaam.Location = new System.Drawing.Point(12, 29);
            this.lblVoornaam.Name = "lblVoornaam";
            this.lblVoornaam.Size = new System.Drawing.Size(215, 24);
            this.lblVoornaam.TabIndex = 4;
            this.lblVoornaam.Text = "Voer jouw voornaam in: ";
            // 
            // lblAchternaam
            // 
            this.lblAchternaam.AutoSize = true;
            this.lblAchternaam.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAchternaam.Location = new System.Drawing.Point(12, 108);
            this.lblAchternaam.Name = "lblAchternaam";
            this.lblAchternaam.Size = new System.Drawing.Size(225, 24);
            this.lblAchternaam.TabIndex = 5;
            this.lblAchternaam.Text = "Voer jouw achternaam in:";
            // 
            // txtVoornaam
            // 
            this.txtVoornaam.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVoornaam.Location = new System.Drawing.Point(272, 26);
            this.txtVoornaam.Name = "txtVoornaam";
            this.txtVoornaam.Size = new System.Drawing.Size(179, 29);
            this.txtVoornaam.TabIndex = 6;
            // 
            // txtAchternaam
            // 
            this.txtAchternaam.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAchternaam.Location = new System.Drawing.Point(272, 105);
            this.txtAchternaam.Name = "txtAchternaam";
            this.txtAchternaam.Size = new System.Drawing.Size(179, 29);
            this.txtAchternaam.TabIndex = 7;
            // 
            // FrmInvoeren
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 234);
            this.ControlBox = false;
            this.Controls.Add(this.txtAchternaam);
            this.Controls.Add(this.txtVoornaam);
            this.Controls.Add(this.lblAchternaam);
            this.Controls.Add(this.lblVoornaam);
            this.Controls.Add(this.btnAnnuleren);
            this.Controls.Add(this.btnToevoegen);
            this.Name = "FrmInvoeren";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Toevoegen Leerkrachten";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAnnuleren;
        private System.Windows.Forms.Button btnToevoegen;
        private System.Windows.Forms.Label lblVoornaam;
        private System.Windows.Forms.Label lblAchternaam;
        private System.Windows.Forms.TextBox txtVoornaam;
        private System.Windows.Forms.TextBox txtAchternaam;
    }
}