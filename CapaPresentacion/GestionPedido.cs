using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaDatos;
using CapaLogica;
using ComponentFactory.Krypton.Toolkit;


namespace CapaPresentacion
{
    public partial class GestionPedido : KryptonForm
    {
        //Referencia de la capa la capa lodica 
        CL_GestionPedidos cl_Gestion = new CL_GestionPedidos();
        CD_GestionPedidos cd_Gestion = new CD_GestionPedidos();
        public GestionPedido()
        {
            InitializeComponent();
        }

        private void kryptonTextBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtCantidad.Text = "0.00";
            MtdImprimirDatosDGV();
        }

        private void cbxMenuProducto_SelectedIndexChanged(object sender, EventArgs e)
        {
            double Precio = cl_Gestion.MtdPrecio(cbxMenuProducto.Text);
            double PrecioTotal = cl_Gestion.MtdTotalPrecio(Convert.ToDouble(txtCantidad.Text), Precio);
            double Propina = cl_Gestion.MtdPropina(cbxMenuProducto.Text, PrecioTotal);
            double TotalPedido = cl_Gestion.MtdPedido(PrecioTotal, Propina);

            txtPrecio.Text = Precio.ToString("c");
            txtPrecioTotal.Text = PrecioTotal.ToString("c");
            txtPropina.Text = Propina.ToString("c");
            txtTotalPedido.Text = TotalPedido.ToString("c");
        }

        private void txtCantidad_TextChanged(object sender, EventArgs e)
        {
            if (double.TryParse(txtCantidad.Text, out double cantidad))
            {

                double Precio = cl_Gestion.MtdPrecio(cbxMenuProducto.Text);
                double PrecioTotal = cl_Gestion.MtdTotalPrecio(Convert.ToDouble(txtCantidad.Text), Precio);
                double Propina = cl_Gestion.MtdPropina(cbxMenuProducto.Text, PrecioTotal);
                double TotalPedido = cl_Gestion.MtdPedido(PrecioTotal, Propina);

                txtPrecio.Text = Precio.ToString("c");
                txtPrecioTotal.Text = PrecioTotal.ToString("c");
                txtPropina.Text = Propina.ToString("c");
                txtTotalPedido.Text = TotalPedido.ToString("c");
            }
            else
            {
                txtPrecio.Text = "0.00";
                txtPrecioTotal.Text = "0.00";
                txtPropina.Text = "0.00";
                txtTotalPedido.Text = "0.00";

            }

        }


        private void MtdImprimirDatosDGV()
        {
            DataTable dt_dgv = cd_Gestion.MtdConsultarTabla();
            dgv_Pedidos.DataSource = dt_dgv;
        }

    }
}
