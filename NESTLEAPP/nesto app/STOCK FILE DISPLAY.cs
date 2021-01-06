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

namespace nesto_app
{
    public partial class STOCKFILEDISPLAY : Form
    {
        private OleDbConnection cnn = new OleDbConnection();
        OleDbCommand cmd = new OleDbCommand();
        public STOCKFILEDISPLAY()
        {
            InitializeComponent();
            cnn.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\NESTLE APP.accdb;Persist Security Info=False";
        }

        private void STOCKFILEDISPLAY_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
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

        private void btnback_Click(object sender, EventArgs e)
        {
            STOCKFILEDISPLAY form = new STOCKFILEDISPLAY();
            form.Hide();
            this.Hide();
            LOGIN LG = new LOGIN();
            LG.Show();
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            STOCKFILEDISPLAY form = new STOCKFILEDISPLAY();
            form.Hide();
            this.Hide();
        }
    }
}
