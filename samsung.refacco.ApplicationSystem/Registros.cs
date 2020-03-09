using samsung.refacco.Repository.Repositories;
using System;
using System.Windows.Forms;

namespace samsung.refacco.ApplicationSystem
{
    public partial class Registros : Form
    {
        RepositoriesPanel rep = new RepositoriesPanel();
        public Registros()
        {
            InitializeComponent();
            ListarAll();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if(MenuVertical.Width == 250)
            {
                MenuVertical.Width = 70;
                btnRegistro.Visible = false;
            }
            else
            {
                MenuVertical.Width = 250;
                btnRegistro.Visible = true;
            }

        }

        //private void pictureBox3_Click(object sender, EventArgs e)
        //{
        //    Application.Exit();
        //    //this.Close();
        //}

        private void pictureBox4_Click(object sender, EventArgs e)
        {
           // this.WindowState = FormWindowState.Maximized;
            this.WindowState = System.Windows.Forms.FormWindowState.Normal;
        }

        public void ListarAll()
        {
            try
            {
                GridProdutos.AutoGenerateColumns = false;
                GridProdutos.DataSource = rep.Listar();
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
    
        private void GridProdutos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           // int codigo = (int)GridProdutos.Rows[0].Cells[0].Value;
            // Delivery delivery = new Delivery(GridProdutos.Rows[0]);
            //int cod = (int)GridProdutos.SelectedCells[0].Value;
           Delivery delivery = new Delivery();
            delivery.Opacity = .75;
            delivery.StartPosition = FormStartPosition.CenterScreen;
            delivery.Codigo = Convert.ToInt32(GridProdutos.CurrentRow.Cells[0].Value);
            delivery.Produto = GridProdutos.CurrentRow.Cells[2].Value.ToString();
            delivery.Show();
            

        }

        private void Registros_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            
            ControlBox = false;
        }

        private void pcbSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMonitoring_Click(object sender, EventArgs e)
        {
            Monitoring mot = new Monitoring();
            mot.Show();
        }

        private void pctMenuRetratio_Click(object sender, EventArgs e)
        {
            if (MenuVertical.Width == 250)
            {
                MenuVertical.Width = 70;
                btnRegistro.Visible = false;
            }
            else
            {
                MenuVertical.Width = 250;
                btnRegistro.Visible = true;
            }
        }

        //private void picbMinimize_Click(object sender, EventArgs e)
        //{
        //    this.WindowState = FormWindowState.Maximized;
        //}

        //private void pictureBox5_Click(object sender, EventArgs e)
        //{
        //    this.WindowState = FormWindowState.Maximized;
        //}
    }
}
