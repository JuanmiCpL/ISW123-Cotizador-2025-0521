using CotizadorVillaCoral;

namespace CualquierNombre
{
    public partial class frmInicio : Form
    {
        public frmInicio()
        {
            InitializeComponent();
        }


        private void nudTarifa_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnImperativo_Click(object sender, EventArgs e)
        {
            string huesped = txtHuesped.Text;
            int noches = (int)nudNoches.Value;
            decimal tarifa = Convert.ToDecimal(nudTarifa.Value);

            decimal subtotal = noches * tarifa;
            decimal descuento = 0m;

            if (noches >= 7)
            {
                descuento = subtotal * 0.10m;

            }
            decimal baseImponible = subtotal - descuento;
            decimal itbis = baseImponible * 0.18m;
            decimal servicio = baseImponible * 0.10m;
            decimal total = baseImponible + itbis + servicio;

            lstResultados.Items.Add($"[Imperativo] {huesped}: US$ {total:N2}");

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {

        }

    }
}
