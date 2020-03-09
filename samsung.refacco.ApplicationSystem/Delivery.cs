using System;
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
            //WindowState = FormWindowState.Maximized;
            //MaximizeBox = false;
            //MinimizeBox = false;
            ControlBox = false;
        }
    }
}
