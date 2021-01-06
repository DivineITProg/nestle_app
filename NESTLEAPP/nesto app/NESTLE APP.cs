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
    public partial class NESTLE_APP : Form
    {
        private OleDbConnection cnn = new OleDbConnection();
        OleDbCommand cmd = new OleDbCommand();


        public NESTLE_APP()
        {
            InitializeComponent();

            cnn.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\NESTLE APP.accdb;Persist Security Info=False";
            
        }

       

        private void Form1_Load(object sender, EventArgs e)
        {
            txtcusCode.MaxLength = 3;
            txtoutLet.MaxLength = 20;
            txtAdd.MaxLength = 25;
            txtPhNum.MaxLength = 10;
            txtReg.MaxLength = 12;
        }

        void cleardata()
        {
            txtcusCode.Clear();
            txtoutLet.Clear();
            txtAdd.Clear();
            txtPhNum.Clear();
            txtReg.Clear();
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            NESTLE_APP form = new NESTLE_APP();
            form.Hide();
            this.Hide();
            LOGIN LG = new LOGIN();
            LG.Show();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {

            if (txtcusCode.Text == "" || txtoutLet.Text == "" || txtAdd.Text == "" || txtPhNum.Text == "" || txtReg.Text == "")
            {
                MessageBox.Show("Please Fill Out All Fields");
                return;
            }


                try
            {
                cnn.Open();
                cmd = new OleDbCommand();
                cmd.Connection = cnn;

                cmd.CommandText = "INSERT INTO NESTLE_APP (CUSTOMER_CODE,[OUTLET_NAME],[ADDRESS],[PHONE_NUMBER], REGISTRATION) values ( '" + txtcusCode.Text + "', '" + txtoutLet.Text + "', '" + txtAdd.Text + "', '" + txtPhNum.Text + "', '" + txtReg.Text + "')";
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
