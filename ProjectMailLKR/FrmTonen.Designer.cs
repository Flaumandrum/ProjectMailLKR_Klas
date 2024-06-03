namespace ProjectMailLKR
{
    partial class FrmTonen
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
            this.btnBevestigen = new System.Windows.Forms.Button();
            this.btnAnnuleren = new System.Windows.Forms.Button();
            this.grbTonen = new System.Windows.Forms.GroupBox();
            this.rdbSpecifiekeLeerkracht = new System.Windows.Forms.RadioButton();
            this.rdbAllesTonen = new System.Windows.Forms.RadioButton();
            this.cmbLeerkracht = new System.Windows.Forms.ComboBox();
            this.lblTonen = new System.Windows.Forms.Label();
            this.txtTonen = new System.Windows.Forms.TextBox();
            this.grbTonen.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBevestigen
            // 
            this.btnBevestigen.Location = new System.Drawing.Point(408, 12);
            this.btnBevestigen.Name = "btnBevestigen";
            this.btnBevestigen.Size = new System.Drawing.Size(178, 52);
            this.btnBevestigen.TabIndex = 0;
            this.btnBevestigen.Text = "Bevestigen";
            this.btnBevestigen.UseVisualStyleBackColor = true;
            this.btnBevestigen.Click += new System.EventHandler(this.btnBevestigen_Click);
            // 
            // btnAnnuleren
            // 
            this.btnAnnuleren.Location = new System.Drawing.Point(408, 70);
            this.btnAnnuleren.Name = "btnAnnuleren";
            this.btnAnnuleren.Size = new System.Drawing.Size(178, 52);
            this.btnAnnuleren.TabIndex = 1;
            this.btnAnnuleren.Text = "Annuleren";
            this.btnAnnuleren.UseVisualStyleBackColor = true;
            this.btnAnnuleren.Click += new System.EventHandler(this.btnAnnuleren_Click);
            // 
            // grbTonen
            // 
            this.grbTonen.Controls.Add(this.rdbSpecifiekeLeerkracht);
            this.grbTonen.Controls.Add(this.rdbAllesTonen);
            this.grbTonen.Location = new System.Drawing.Point(12, 12);
            this.grbTonen.Name = "grbTonen";
            this.grbTonen.Size = new System.Drawing.Size(178, 85);
            this.grbTonen.TabIndex = 2;
            this.grbTonen.TabStop = false;
            // 
            // rdbSpecifiekeLeerkracht
            // 
            this.rdbSpecifiekeLeerkracht.AutoSize = true;
            this.rdbSpecifiekeLeerkracht.Location = new System.Drawing.Point(7, 52);
            this.rdbSpecifiekeLeerkracht.Name = "rdbSpecifiekeLeerkracht";
            this.rdbSpecifiekeLeerkracht.Size = new System.Drawing.Size(129, 17);
            this.rdbSpecifiekeLeerkracht.TabIndex = 1;
            this.rdbSpecifiekeLeerkracht.TabStop = true;
            this.rdbSpecifiekeLeerkracht.Text = "Specifieke Leerkracht";
            this.rdbSpecifiekeLeerkracht.UseVisualStyleBackColor = true;
            this.rdbSpecifiekeLeerkracht.CheckedChanged += new System.EventHandler(this.rdbSpecifiekeLeerkracht_CheckedChanged);
            // 
            // rdbAllesTonen
            // 
            this.rdbAllesTonen.AutoSize = true;
            this.rdbAllesTonen.Location = new System.Drawing.Point(7, 20);
            this.rdbAllesTonen.Name = "rdbAllesTonen";
            this.rdbAllesTonen.Size = new System.Drawing.Size(77, 17);
            this.rdbAllesTonen.TabIndex = 0;
            this.rdbAllesTonen.TabStop = true;
            this.rdbAllesTonen.Text = "Alles tonen";
            this.rdbAllesTonen.UseVisualStyleBackColor = true;
            this.rdbAllesTonen.CheckedChanged += new System.EventHandler(this.rdbAllesTonen_CheckedChanged);
            // 
            // cmbLeerkracht
            // 
            this.cmbLeerkracht.FormattingEnabled = true;
            this.cmbLeerkracht.Location = new System.Drawing.Point(200, 60);
            this.cmbLeerkracht.Name = "cmbLeerkracht";
            this.cmbLeerkracht.Size = new System.Drawing.Size(177, 21);
            this.cmbLeerkracht.TabIndex = 3;
            // 
            // lblTonen
            // 
            this.lblTonen.AutoSize = true;
            this.lblTonen.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTonen.Location = new System.Drawing.Point(196, 26);
            this.lblTonen.Name = "lblTonen";
            this.lblTonen.Size = new System.Drawing.Size(132, 24);
            this.lblTonen.TabIndex = 4;
            this.lblTonen.Text = "Kies leekracht:";
            // 
            // txtTonen
            // 
            this.txtTonen.AllowDrop = true;
            this.txtTonen.Location = new System.Drawing.Point(12, 128);
            this.txtTonen.Multiline = true;
            this.txtTonen.Name = "txtTonen";
            this.txtTonen.ReadOnly = true;
            this.txtTonen.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtTonen.Size = new System.Drawing.Size(574, 241);
            this.txtTonen.TabIndex = 5;
            // 
            // FrmTonen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 381);
            this.ControlBox = false;
            this.Controls.Add(this.txtTonen);
            this.Controls.Add(this.lblTonen);
            this.Controls.Add(this.cmbLeerkracht);
            this.Controls.Add(this.grbTonen);
            this.Controls.Add(this.btnAnnuleren);
            this.Controls.Add(this.btnBevestigen);
            this.Name = "FrmTonen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tonen leerkrachten";
            this.Load += new System.EventHandler(this.FrmTonen_Load);
            this.grbTonen.ResumeLayout(false);
            this.grbTonen.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBevestigen;
        private System.Windows.Forms.Button btnAnnuleren;
        private System.Windows.Forms.GroupBox grbTonen;
        private System.Windows.Forms.RadioButton rdbSpecifiekeLeerkracht;
        private System.Windows.Forms.RadioButton rdbAllesTonen;
        private System.Windows.Forms.ComboBox cmbLeerkracht;
        private System.Windows.Forms.Label lblTonen;
        private System.Windows.Forms.TextBox txtTonen;
    }
}