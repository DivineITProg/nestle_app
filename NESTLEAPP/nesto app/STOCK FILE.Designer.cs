namespace nesto_app
{
    partial class STOCK_FILE
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(STOCK_FILE));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtbrndCD = new System.Windows.Forms.TextBox();
            this.txtBrndNM = new System.Windows.Forms.TextBox();
            this.txtQty = new System.Windows.Forms.TextBox();
            this.txtAmt = new System.Windows.Forms.TextBox();
            this.txtDst = new System.Windows.Forms.TextBox();
            this.btnsave = new System.Windows.Forms.Button();
            this.btnback = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.OrangeRed;
            this.label1.Font = new System.Drawing.Font("Bernard MT Condensed", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "BRAND CODE";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Gold;
            this.label2.Font = new System.Drawing.Font("Bernard MT Condensed", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "BRAND NAME";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.DodgerBlue;
            this.label3.Font = new System.Drawing.Font("Bernard MT Condensed", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(31, 258);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "QUANTITY";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Lime;
            this.label4.Font = new System.Drawing.Font("Bernard MT Condensed", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(31, 347);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 22);
            this.label4.TabIndex = 3;
            this.label4.Text = "AMOUNT";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Fuchsia;
            this.label6.Font = new System.Drawing.Font("Bernard MT Condensed", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(22, 444);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(122, 22);
            this.label6.TabIndex = 5;
            this.label6.Text = "DISTRIBUTION";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // txtbrndCD
            // 
            this.txtbrndCD.Location = new System.Drawing.Point(452, 69);
            this.txtbrndCD.Multiline = true;
            this.txtbrndCD.Name = "txtbrndCD";
            this.txtbrndCD.Size = new System.Drawing.Size(246, 20);
            this.txtbrndCD.TabIndex = 7;
            this.txtbrndCD.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtBrndNM
            // 
            this.txtBrndNM.Location = new System.Drawing.Point(452, 154);
            this.txtBrndNM.Multiline = true;
            this.txtBrndNM.Name = "txtBrndNM";
            this.txtBrndNM.Size = new System.Drawing.Size(246, 20);
            this.txtBrndNM.TabIndex = 8;
            this.txtBrndNM.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtQty
            // 
            this.txtQty.Location = new System.Drawing.Point(452, 258);
            this.txtQty.Multiline = true;
            this.txtQty.Name = "txtQty";
            this.txtQty.Size = new System.Drawing.Size(246, 20);
            this.txtQty.TabIndex = 9;
            this.txtQty.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // txtAmt
            // 
            this.txtAmt.Location = new System.Drawing.Point(452, 347);
            this.txtAmt.Multiline = true;
            this.txtAmt.Name = "txtAmt";
            this.txtAmt.Size = new System.Drawing.Size(246, 20);
            this.txtAmt.TabIndex = 10;
            this.txtAmt.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // txtDst
            // 
            this.txtDst.Location = new System.Drawing.Point(452, 448);
            this.txtDst.Multiline = true;
            this.txtDst.Name = "txtDst";
            this.txtDst.Size = new System.Drawing.Size(246, 20);
            this.txtDst.TabIndex = 11;
            this.txtDst.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // btnsave
            // 
            this.btnsave.BackColor = System.Drawing.Color.Chartreuse;
            this.btnsave.Font = new System.Drawing.Font("Gill Sans Ultra Bold Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsave.Location = new System.Drawing.Point(25, 591);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(115, 37);
            this.btnsave.TabIndex = 12;
            this.btnsave.Text = "SAVE ";
            this.btnsave.UseVisualStyleBackColor = false;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // btnback
            // 
            this.btnback.BackColor = System.Drawing.Color.Crimson;
            this.btnback.Font = new System.Drawing.Font("Gill Sans Ultra Bold Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnback.Location = new System.Drawing.Point(607, 603);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(91, 37);
            this.btnback.TabIndex = 13;
            this.btnback.Text = "BACK";
            this.btnback.UseVisualStyleBackColor = false;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // STOCK_FILE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(720, 662);
            this.Controls.Add(this.btnback);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.txtDst);
            this.Controls.Add(this.txtAmt);
            this.Controls.Add(this.txtQty);
            this.Controls.Add(this.txtBrndNM);
            this.Controls.Add(this.txtbrndCD);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "STOCK_FILE";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "STOCK FILE";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtbrndCD;
        private System.Windows.Forms.TextBox txtBrndNM;
        private System.Windows.Forms.TextBox txtQty;
        private System.Windows.Forms.TextBox txtAmt;
        private System.Windows.Forms.TextBox txtDst;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Button btnback;
    }
}