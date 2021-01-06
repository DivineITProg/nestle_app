namespace nesto_app
{
    partial class LOGIN
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LOGIN));
            this.butStFile = new System.Windows.Forms.Button();
            this.btnReg = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnStockFileDisplay = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // butStFile
            // 
            this.butStFile.BackColor = System.Drawing.Color.Lime;
            this.butStFile.Font = new System.Drawing.Font("Algerian", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butStFile.Location = new System.Drawing.Point(409, 319);
            this.butStFile.Name = "butStFile";
            this.butStFile.Size = new System.Drawing.Size(146, 50);
            this.butStFile.TabIndex = 14;
            this.butStFile.Text = "STOCK FILE";
            this.butStFile.UseVisualStyleBackColor = false;
            this.butStFile.Click += new System.EventHandler(this.butStFile_Click);
            // 
            // btnReg
            // 
            this.btnReg.BackColor = System.Drawing.Color.Gold;
            this.btnReg.Font = new System.Drawing.Font("Algerian", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReg.Location = new System.Drawing.Point(200, 121);
            this.btnReg.Name = "btnReg";
            this.btnReg.Size = new System.Drawing.Size(153, 50);
            this.btnReg.TabIndex = 15;
            this.btnReg.Text = "REGISTRATION";
            this.btnReg.UseVisualStyleBackColor = false;
            this.btnReg.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Red;
            this.btnExit.Font = new System.Drawing.Font("Algerian", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(200, 502);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(153, 50);
            this.btnExit.TabIndex = 16;
            this.btnExit.Text = "EXIT";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnStockFileDisplay
            // 
            this.btnStockFileDisplay.BackColor = System.Drawing.Color.Aqua;
            this.btnStockFileDisplay.Font = new System.Drawing.Font("Algerian", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStockFileDisplay.Location = new System.Drawing.Point(12, 319);
            this.btnStockFileDisplay.Name = "btnStockFileDisplay";
            this.btnStockFileDisplay.Size = new System.Drawing.Size(171, 50);
            this.btnStockFileDisplay.TabIndex = 17;
            this.btnStockFileDisplay.Text = "STOCK FILE DISPLAY";
            this.btnStockFileDisplay.UseVisualStyleBackColor = false;
            this.btnStockFileDisplay.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // LOGIN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(555, 564);
            this.Controls.Add(this.btnStockFileDisplay);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnReg);
            this.Controls.Add(this.butStFile);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LOGIN";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NESTLE FOODS";
            this.Load += new System.EventHandler(this.LOGIN_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button butStFile;
        private System.Windows.Forms.Button btnReg;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnStockFileDisplay;
    }
}