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
    public partial class STOCK_FILE_DISPLAY : Form

        {

        private OleDbConnection cnn = new OleDbConnection();
        OleDbCommand cmd = new OleDbCommand();
        public STOCK_FILE_DISPLAY()
        {
            InitializeComponent();
            cnn.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\HEINEKEN APP.accdb;Persist Security Info=False";
    }

        private void btnLoadTable_Click(object sender, EventArgs e)
        {
        try
        {
            cnn.Open();
            cmd = new OleDbCommand();
            cmd.Connection = cnn;
            string query = "select * from STOCK_FILE ";
            cmd.CommandText = query;
            cmd.ExecuteNonQuery();

            OleDbDataAdapter sfd = new OleDbDataAdapter(cmd);
            DataTable dt = new DataTable();
            sfd.Fill(dt);
            dataGridView1.DataSource = dt;




        }
        catch (Exception ex)
        {
            MessageBox.Show("Error" + ex);
        }
        finally
        {
            if (cnn.State == ConnectionState.Open)
            {
                cnn.Close();
                cnn.Dispose();


            }


        }
    }

        private void btnBackbtnBack_Click(object sender, EventArgs e)
        {
            STOCK_FILE_DISPLAY form = new STOCK_FILE_DISPLAY();
            form.Hide();
            this.Hide();
            LOGIN LG = new LOGIN();
            LG.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            STOCK_FILE_DISPLAY form = new STOCK_FILE_DISPLAY();
            form.Hide();
            this.Hide();
        }
    }
}
