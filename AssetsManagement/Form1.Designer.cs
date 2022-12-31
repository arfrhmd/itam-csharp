namespace AssetsManagement
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.btnPrintQR = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnTentang = new System.Windows.Forms.Button();
            this.lblMade = new System.Windows.Forms.Label();
            this.btnCheck = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Hanken Grotesk", 35F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(11, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(481, 61);
            this.label1.TabIndex = 0;
            this.label1.Text = "IT ASSETS MANAGER";
            // 
            // btnPrintQR
            // 
            this.btnPrintQR.BackColor = System.Drawing.Color.AliceBlue;
            this.btnPrintQR.Font = new System.Drawing.Font("Hanken Grotesk", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnPrintQR.Location = new System.Drawing.Point(322, 94);
            this.btnPrintQR.Name = "btnPrintQR";
            this.btnPrintQR.Size = new System.Drawing.Size(133, 54);
            this.btnPrintQR.TabIndex = 1;
            this.btnPrintQR.Text = "PRINT\r\nQRCODE";
            this.btnPrintQR.UseVisualStyleBackColor = false;
            this.btnPrintQR.Click += new System.EventHandler(this.btnPrintQR_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.AliceBlue;
            this.btnAdd.Font = new System.Drawing.Font("Hanken Grotesk", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAdd.Location = new System.Drawing.Point(44, 94);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(133, 54);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "ADD";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnTentang
            // 
            this.btnTentang.BackColor = System.Drawing.Color.AliceBlue;
            this.btnTentang.Font = new System.Drawing.Font("Hanken Grotesk", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnTentang.Location = new System.Drawing.Point(44, 154);
            this.btnTentang.Name = "btnTentang";
            this.btnTentang.Size = new System.Drawing.Size(411, 54);
            this.btnTentang.TabIndex = 2;
            this.btnTentang.Text = "TENTANG";
            this.btnTentang.UseVisualStyleBackColor = false;
            this.btnTentang.Click += new System.EventHandler(this.btnTentang_Click);
            // 
            // lblMade
            // 
            this.lblMade.AutoSize = true;
            this.lblMade.BackColor = System.Drawing.Color.MidnightBlue;
            this.lblMade.Font = new System.Drawing.Font("Hanken Grotesk", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMade.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblMade.Location = new System.Drawing.Point(149, 229);
            this.lblMade.Name = "lblMade";
            this.lblMade.Size = new System.Drawing.Size(197, 18);
            this.lblMade.TabIndex = 3;
            this.lblMade.Text = "Made with ❤ by Arif Rahmadi";
            // 
            // btnCheck
            // 
            this.btnCheck.BackColor = System.Drawing.Color.AliceBlue;
            this.btnCheck.Font = new System.Drawing.Font("Hanken Grotesk", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCheck.Location = new System.Drawing.Point(183, 94);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(133, 54);
            this.btnCheck.TabIndex = 4;
            this.btnCheck.Text = "CHECK";
            this.btnCheck.UseVisualStyleBackColor = false;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(497, 281);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.lblMade);
            this.Controls.Add(this.btnTentang);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnPrintQR);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IT Assets Management";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Button btnPrintQR;
        private Button btnAdd;
        private Button btnTentang;
        private Label lblMade;
        private Button btnCheck;
    }
}