namespace ProjectMailLKR
{
    partial class FrmStartmenu
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
            this.btnInvoer = new System.Windows.Forms.Button();
            this.btnTonen = new System.Windows.Forms.Button();
            this.btnAfsluiten = new System.Windows.Forms.Button();
            this.lblIntro = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnInvoer
            // 
            this.btnInvoer.Location = new System.Drawing.Point(34, 76);
            this.btnInvoer.Name = "btnInvoer";
            this.btnInvoer.Size = new System.Drawing.Size(174, 62);
            this.btnInvoer.TabIndex = 0;
            this.btnInvoer.Text = "Invoer";
            this.btnInvoer.UseVisualStyleBackColor = true;
            this.btnInvoer.Click += new System.EventHandler(this.btnInvoer_Click);
            // 
            // btnTonen
            // 
            this.btnTonen.Location = new System.Drawing.Point(34, 144);
            this.btnTonen.Name = "btnTonen";
            this.btnTonen.Size = new System.Drawing.Size(174, 62);
            this.btnTonen.TabIndex = 1;
            this.btnTonen.Text = "Tonen";
            this.btnTonen.UseVisualStyleBackColor = true;
            this.btnTonen.Click += new System.EventHandler(this.btnTonen_Click);
            // 
            // btnAfsluiten
            // 
            this.btnAfsluiten.Location = new System.Drawing.Point(34, 212);
            this.btnAfsluiten.Name = "btnAfsluiten";
            this.btnAfsluiten.Size = new System.Drawing.Size(174, 62);
            this.btnAfsluiten.TabIndex = 2;
            this.btnAfsluiten.Text = "Afsluiten";
            this.btnAfsluiten.UseVisualStyleBackColor = true;
            this.btnAfsluiten.Click += new System.EventHandler(this.btnAfsluiten_Click);
            // 
            // lblIntro
            // 
            this.lblIntro.AutoSize = true;
            this.lblIntro.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIntro.Location = new System.Drawing.Point(21, 27);
            this.lblIntro.Name = "lblIntro";
            this.lblIntro.Size = new System.Drawing.Size(213, 24);
            this.lblIntro.TabIndex = 3;
            this.lblIntro.Text = "Kies uit volgende menu:";
            // 
            // FrmStartmenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(246, 317);
            this.ControlBox = false;
            this.Controls.Add(this.lblIntro);
            this.Controls.Add(this.btnAfsluiten);
            this.Controls.Add(this.btnTonen);
            this.Controls.Add(this.btnInvoer);
            this.Name = "FrmStartmenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Start menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnInvoer;
        private System.Windows.Forms.Button btnTonen;
        private System.Windows.Forms.Button btnAfsluiten;
        private System.Windows.Forms.Label lblIntro;
    }
}

