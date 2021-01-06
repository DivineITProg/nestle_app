using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace HEINEKEN_APP
{
    public partial class STOCK_FILE : Form
    
    {
        private OleDbConnection cnn = new OleDbConnection();
        OleDbCommand cmd = new OleDbCommand();

        public STOCK_FILE()
        {
            InitializeComponent();
            cnn.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\HEINEKEN APP.accdb;Persist Security Info=False";
            
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            STOCK_FILE form = new STOCK_FILE();
            form.Hide();
            this.Hide();
            LOGIN LG = new LOGIN();
            LG.Show();

        
        }

        void cleardata()
        {
            txtbrndCD.Clear();
            txtBrndNM.Clear();
            txtQty.Clear();
            txtAmt.Clear();
            txtDst.Clear();
        }

        private void STOCK_FILE_Load(object sender, EventArgs e)
        {
            txtbrndCD.MaxLength = 4;
            txtBrndNM.MaxLength = 12;
            txtQty.MaxLength = 4;
            txtAmt.MaxLength = 9;
            txtDst.MaxLength = 12;
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            if (txtbrndCD.Text == "" || txtBrndNM.Text == "" || txtQty.Text == "" || txtAmt.Text == "" || txtDst.Text == "")
            {
                MessageBox.Show("Please Fill Out All Fields");
                return;
            }

            try
            {
                cnn.Open();
                cmd = new OleDbCommand();
                cmd.Connection = cnn;

                cmd.CommandText = "INSERT INTO STOCK_FILE (BRAND_CODE,[BRAND_NAME],[QUANTITY],[AMOUNT], DISTRIBUTION) values ( '" + txtbrndCD.Text + "', '" + txtBrndNM.Text + "', '" + txtQty.Text + "', '" + txtAmt.Text + "', '" + txtDst.Text + "')";
                cmd.ExecuteNonQuery();
                MessageBox.Show("RECORDS ADDED", "Information", MessageBoxButtons.OK);

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (cnn.State == ConnectionState.Open)
                {
                    cnn.Close();
                    cnn.Dispose();
                    cleardata();

                }



            }

        }
    }
}
