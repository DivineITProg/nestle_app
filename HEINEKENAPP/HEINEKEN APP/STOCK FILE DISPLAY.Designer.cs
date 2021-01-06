namespace HEINEKEN_APP
{
    partial class STOCK_FILE_DISPLAY
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
            this.btnLoadTable = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnBackbtnBack = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLoadTable
            // 
            this.btnLoadTable.BackColor = System.Drawing.Color.Orange;
            this.btnLoadTable.Location = new System.Drawing.Point(261, 423);
            this.btnLoadTable.Name = "btnLoadTable";
            this.btnLoadTable.Size = new System.Drawing.Size(115, 39);
            this.btnLoadTable.TabIndex = 0;
            this.btnLoadTable.Text = "LOAD TABLE";
            this.btnLoadTable.UseVisualStyleBackColor = false;
            this.btnLoadTable.Click += new System.EventHandler(this.btnLoadTable_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(27, 26);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(582, 391);
            this.dataGridView1.TabIndex = 1;
            // 
            // btnBackbtnBack
            // 
            this.btnBackbtnBack.BackColor = System.Drawing.Color.LightCoral;
            this.btnBackbtnBack.Location = new System.Drawing.Point(27, 423);
            this.btnBackbtnBack.Name = "btnBackbtnBack";
            this.btnBackbtnBack.Size = new System.Drawing.Size(115, 39);
            this.btnBackbtnBack.TabIndex = 2;
            this.btnBackbtnBack.Text = "BACK";
            this.btnBackbtnBack.UseVisualStyleBackColor = false;
            this.btnBackbtnBack.Click += new System.EventHandler(this.btnBackbtnBack_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Red;
            this.btnExit.Location = new System.Drawing.Point(494, 423);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(115, 39);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // STOCK_FILE_DISPLAY
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.ForestGreen;
            this.ClientSize = new System.Drawing.Size(637, 474);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnBackbtnBack);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnLoadTable);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "STOCK_FILE_DISPLAY";
            this.Text = "STOCK_FILE_DISPLAY";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLoadTable;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnBackbtnBack;
        private System.Windows.Forms.Button btnExit;
    }
}