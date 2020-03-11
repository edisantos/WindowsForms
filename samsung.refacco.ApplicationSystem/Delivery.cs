using samsung.refacco.Repository.Entidades;
using samsung.refacco.Repository.Repositories;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace samsung.refacco.ApplicationSystem
{
    public partial class Delivery : Form
    {
        public int ? Codigo { get; set; }
        public string Produto { get; set; }
        public Delivery()
        {
            InitializeComponent();
            
           
        }
        

        //public Delivery(DataGridViewRow linha)
        //{
        //    InitializeComponent();
        //    lblCodigo.Text = string.Empty;
        //    lblCodigo.Text = linha.Cells[0].Value.ToString();
        //}

        private void txtCancelar_Click(object sender, EventArgs e)
        {
            lblCodigo.Text = "";
            this.Close();
        }

        private void Delivery_Load(object sender, EventArgs e)
        {
            lblCodigo.Text = Codigo.ToString();
            lblProduto.Text = Produto;
            GetProdutos();
            //WindowState = FormWindowState.Maximized;
            //MaximizeBox = false;
            //MinimizeBox = false;
            ControlBox = false;

           
        }
        public void GetProdutos()
        {
            try
            {
                string id = lblCodigo.Text;
                RepositoriesPanel rep = new RepositoriesPanel();
                Produtos mod = rep.GetProdutos(id);
                if (mod != null)
                {
                    lblEstoque.Text = Convert.ToString(mod.Estoque);
                    lblValor.Text = Convert.ToString(mod.Valor.ToString("c"));
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bmp, 0, 0);
        }

        Bitmap bmp;

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            bmp = new Bitmap(this.Size.Width, this.Size.Height, g);
            Graphics mg = Graphics.FromImage(bmp);
            mg.CopyFromScreen(this.Location.X, this.Location.Y, 0, 0, this.Size);
            printPreviewDialog1.ShowDialog();
        }
    }
}
