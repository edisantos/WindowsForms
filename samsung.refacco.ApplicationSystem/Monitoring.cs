using System;
using System.Windows.Forms;
using samsung.refacco.Repository.Repositories;

namespace samsung.refacco.ApplicationSystem
{
    public partial class Monitoring : Form
    {
        RepositoriesPanel rep = new RepositoriesPanel();
        public Monitoring()
        {
            InitializeComponent();
            Listar();
            
            lblTime.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        public void Listar()
        {
            try
            {
                dataGridView1.DataSource = rep.Listar();
            }
            catch (Exception ex)
            {

                lblTime.Text = ex.Message;
            }
        }

        private void Monitoring_Load(object sender, EventArgs e)
        {
            var timer = new System.Windows.Forms.Timer();
            timer.Interval = 5000;
            timer.Tick += timer1_Tick;
            timer.Enabled = true;
            timer.Start();
            lblTime.Text = DateTime.Now.ToString("dd-MM-yyyy - HH:mm:ss");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString("dd-MM-yyyy - HH:mm:ss");
            Listar();
        }
    }
}
