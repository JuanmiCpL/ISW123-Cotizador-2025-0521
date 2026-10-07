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
            if (string.IsNullOrWhiteSpace(txtHuesped.Text))
            {
                MessageBox.Show("Escribe el nombre del huésped.", "Falta un dato",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtHuesped.Focus();
                return;
            }

            if (!decimal.TryParse(txtTarifa.Text, out decimal tarifa) || tarifa <= 0)
            {
                MessageBox.Show("La tarifa debe ser un número mayor que cero.", "Dato incorrecto",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTarifa.Focus();
                txtTarifa.SelectAll();
                return;
            }

            var reserva = new Reserva
            {
                Huesped = txtHuesped.Text.Trim(),
                Noches = (int)nudNoches.Value,
                TarifaPorNoche = tarifa,
                EsTemporadaAlta = chkTemporadaAlta.Checked
            };

            lblSubtotal.Text = reserva.Subtotal.ToString("N2");
            lblDescuento.Text = "-" + reserva.Descuento.ToString("N2");
            lblItbis.Text = reserva.Itbis.ToString("N2");
            lblServicio.Text = reserva.Servicio.ToString("N2");
            lblTotal.Text = reserva.Total.ToString("N2");
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtHuesped.Clear();
            txtTarifa.Clear();
            nudNoches.Value = 1;
            chkTemporadaAlta.Checked = false;

            lblSubtotal.Text = lblDescuento.Text = lblItbis.Text =
                lblServicio.Text = lblTotal.Text = "0.00";

            txtHuesped.Focus();
        }

        private void btnCopiar_Click(object sender, EventArgs e)
        {
            if (lblTotal.Text == "0.00")
            {
                MessageBox.Show("Primero calcula una cotización.", "Nada que copiar",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var texto = $"""
        *Cotización Villa Coral*
        Huésped: {txtHuesped.Text}
        Noches: {nudNoches.Value}
        Subtotal: US$ {lblSubtotal.Text}
        Descuento: US$ {lblDescuento.Text}
        ITBIS 18%: US$ {lblItbis.Text}
        Servicio 10%: US$ {lblServicio.Text}
        *TOTAL: US$ {lblTotal.Text}*
        """;

            Clipboard.SetText(texto);

            MessageBox.Show("Cotización copiada. Ya puedes pegarla en WhatsApp.", "Listo",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
