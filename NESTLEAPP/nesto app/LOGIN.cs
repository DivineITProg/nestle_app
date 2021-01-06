using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace nesto_app
{
    public partial class LOGIN : Form
    {
        
        public LOGIN()
        {
            InitializeComponent();

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LOGIN form = new LOGIN();
            form.Hide();
            this.Hide();
            NESTLE_APP np = new NESTLE_APP();
            np.Show();
        }

        private void butStFile_Click(object sender, EventArgs e)
        {
            LOGIN form = new LOGIN();
            form.Hide();
            this.Hide();
            STOCK_FILE sf = new STOCK_FILE();
            sf.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            LOGIN form = new LOGIN();
            form.Hide();
            this.Hide();
        }

        private void LOGIN_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            LOGIN form = new LOGIN();
            form.Hide();
            this.Hide();
            STOCKFILEDISPLAY LG = new STOCKFILEDISPLAY();
            LG.Show();
        }
    }
}
