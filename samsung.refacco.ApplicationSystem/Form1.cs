using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace samsung.refacco.ApplicationSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Teste");
        }

        private void btnMonitoring_Click(object sender, EventArgs e)
        {
            Monitoring m = new Monitoring();
            m.Show();
        }

        private void btnRegistro_Click(object sender, EventArgs e)
        {
            Registros reg = new Registros();
            reg.Show();
        }
    }
}
