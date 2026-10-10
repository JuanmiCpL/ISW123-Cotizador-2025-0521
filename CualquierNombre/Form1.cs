using CotizadorVillaCoral;

namespace CualquierNombre
{
    public partial class frmInicio : Form
    {
        public frmInicio()
        {
            InitializeComponent();
        }

        private void btnImperativo_Click(object sender, EventArgs e)
        {
            string huesped = txtHuesped.Text;
            int noches = (int)nudNoches.Value;

            if (!decimal.TryParse(txtTarifa.Text, out decimal tarifa) || tarifa <= 0)
            {
                MessageBox.Show("Ingresa una tarifa válida.");
                return;
            }

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
                EsTemporadaAlta = chkTemporadaAlta.Checked,
                EsFinDeSemana = chkFinSemana.Checked
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
            chkFinSemana.Checked = false;

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

        private void btnNivel1_Click(object sender, EventArgs e)

        {
            int n = 4;
            decimal t = 100m;
            decimal total = n * t * 1.28m;
            lstResultados.Items.Add($"Total: {total:N2}");
        }

        private void btnPesos_Click(object sender, EventArgs e)
        {
            decimal tasa = nudTasa.Value;
            decimal pesos = tasa * Convert.ToDecimal(lblTotal.Text);
            lstResultados.Items.Add($"Total en pesos: RD$ {pesos:N2}");
        }

        private void btnPorPersona_Click(object sender, EventArgs e)
        {
            decimal Total = Convert.ToDecimal(lblTotal.Text);
            decimal personas = nudPersonas.Value;
            decimal totalPorPersona = Total / personas;
            lstResultados.Items.Add($"Total por persona: US$ {totalPorPersona:N2}");
        }

        private void btnDeposito_Click(object sender, EventArgs e)
        {
            decimal total = Convert.ToDecimal(lblTotal.Text);
            decimal deposito = 0.30m * total;
            decimal saldoPendiente = total - deposito;
            lstResultados.Items.Add($"Depósito: US$ {deposito:N2}");
            lstResultados.Items.Add($"Saldo Pendiente: US$ {saldoPendiente:N2}");
        }



        private void btnFinSemana_Click(object sender, EventArgs e)
        {
            decimal total = Convert.ToDecimal(lblTotal.Text);
            decimal recargoFinSemana = 0.15m * total;
            decimal TotalConRecargo = total + recargoFinSemana;
            lstResultados.Items.Add($"Recargo Fin de Semana: US$ {TotalConRecargo:N2}");
        }

        private void btnDesglose_Click(object sender, EventArgs e)
        {
            decimal subtotal = Convert.ToDecimal(lblSubtotal.Text);
            decimal descuento = Convert.ToDecimal(lblDescuento.Text);
            decimal itbis = Convert.ToDecimal(lblItbis.Text);
            decimal servicio = Convert.ToDecimal(lblServicio.Text);
            decimal total = Convert.ToDecimal(lblTotal.Text);

            lstResultados.Items.Add($"Subtotal: US${subtotal:N2}");
            lstResultados.Items.Add($"Descuento: US${descuento:N2}");
            lstResultados.Items.Add($"ITBIS: US${itbis:N2}");
            lstResultados.Items.Add($"Servicio: US${servicio:N2}");
            lstResultados.Items.Add($"Total: US${total:N2}");
        }

        private void btnTraslado_Click(object sender, EventArgs e)
        {
            TrasladoAeropuerto Traslado = new TrasladoAeropuerto
            {
                Pasajeros = int.TryParse(nudPersonas.Text, out int personas) ? personas : 0,
                Nocturno = true
            };

            lstResultados.Items.Add($"Traslado: US${Traslado.Pasajeros:F2}");
            lstResultados.Items.Add($"Subtotal: US${Traslado.Subtotal:F2}");
            lstResultados.Items.Add($"Recargo: US${Traslado.Recargo:F2}");
            lstResultados.Items.Add($"Total: US${Traslado.Total:F2}");
        }

        private void btnExcursion_Click(object sender, EventArgs e)
        {
            Excursion excursion = new Excursion
            {
                Personas = int.TryParse(nudPersonas.Text, out int personas) ? personas : 0,
                PrecioPorPersona = 50m

            };

            lstResultados.Items.Add($"Excursión: US${excursion.Personas:F2}");
            lstResultados.Items.Add($"Subtotal: US${excursion.Subtotal:F2}");
            lstResultados.Items.Add($"Descuento: US${excursion.Descuento:F2}");
            lstResultados.Items.Add($"Total: US${excursion.Total:F2}");
        }

        private void btnMinibar_Click(object sender, EventArgs e)
        {
            ConsumoMinibar minibar = new ConsumoMinibar
            {
                Cantidad = 3,
                PrecioUnitario = 3.50m
            };
            lstResultados.Items.Add($"Consumo en minibar: US${minibar.Cantidad:F2}");
            lstResultados.Items.Add($"Subtotal: US${minibar.Subtotal:F2}");
            lstResultados.Items.Add($"ITBIS: US${minibar.itbis:F2}");
            lstResultados.Items.Add($"Total: US${minibar.Total:F2}");
        }

        private void btnCuentaTotal_Click(object sender, EventArgs e)
        {
            Reserva reserva = new Reserva
            {
                Huesped = txtHuesped.Text.Trim(),
                Noches = (int)nudNoches.Value,
                TarifaPorNoche = decimal.TryParse(txtTarifa.Text, out decimal tarifa) ? tarifa : 0m,
                EsTemporadaAlta = chkTemporadaAlta.Checked,
                EsFinDeSemana = chkFinSemana.Checked
            };

            TrasladoAeropuerto Traslado = new TrasladoAeropuerto
            {
                Pasajeros = int.TryParse(nudPersonas.Text, out int personas) ? personas : 0,
                Nocturno = true
            };
            Excursion excursion = new Excursion
            {
                Personas = int.TryParse(nudPersonas.Text, out int pasajeros) ? pasajeros : 0,
                PrecioPorPersona = 50m
            };
            ConsumoMinibar minibar = new ConsumoMinibar
            {
                Cantidad = 3,
                PrecioUnitario = 3.50m
            };

            lblTotal.Text = reserva.Total.ToString("N2");
            lstResultados.Items.Add($"Reserva: US${reserva.Total:F2}");
            lstResultados.Items.Add($"Traslado: US${Traslado.Total:F2}");
            lstResultados.Items.Add($"Excursión: US${excursion.Total:F2}");
            lstResultados.Items.Add($"Consumo en minibar: US${minibar.Total:F2}");

            lstResultados.Items.Add($"Cuenta total: US${reserva.Total + Traslado.Total + excursion.Total + minibar.Total:F2}");
        }

        private void btnViejo_Click(object sender, EventArgs e)
        {
            lstResultados.Items.Add($"Depósito de 1000: {SistemaViejo.CalcularDeposito(1000m):N2} (debe dar 300.00)");
            lstResultados.Items.Add($"100 USD a tasa 60: {SistemaViejo.APesos(100m, 60m):N2} (debe dar 6,000.00)");
            lstResultados.Items.Add($"Tarifa 200 fin de semana: {SistemaViejo.TarifaFinDeSemana(200m, true):N2} (debe dar 230.00)");
            lstResultados.Items.Add($"Excursión 4 × 50: {SistemaViejo.TotalExcursion(4, 50m):N2} (debe dar 180.00)");
            lstResultados.Items.Add($"Minibar 3 × 4: {SistemaViejo.TotalMinibar(3, 4m):N2} (debe dar 14.16)");
        }

        private void btnFactura_Click(object sender, EventArgs e)
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
                EsTemporadaAlta = chkTemporadaAlta.Checked,
                EsFinDeSemana = chkFinSemana.Checked
            };
            TrasladoAeropuerto Traslado = new TrasladoAeropuerto
            {
                Pasajeros = int.TryParse(nudPersonas.Text, out int personas) ? personas : 0,
                Nocturno = true
            };
            Excursion excursion = new Excursion
            {
                Personas = int.TryParse(nudPersonas.Text, out int Pasajeros) ? Pasajeros : 0,
                PrecioPorPersona = 50m

            };
            ConsumoMinibar minibar = new ConsumoMinibar
            {
                Cantidad = 3,
                PrecioUnitario = 3.50m
            };

            decimal TotalGeneral = reserva.Total + Traslado.Total + excursion.Total + minibar.Total;
            decimal totalPesos = TotalGeneral * nudTasa.Value;
            decimal deposito = SistemaViejo.CalcularDeposito(TotalGeneral);

            lstResultados.Items.Add($"Total de la reserva US$ :{reserva.Total:N2}");
            lstResultados.Items.Add($"Total del traslado US$ :{Traslado.Total:N2}");
            lstResultados.Items.Add($"Total de la excursión US$ :{excursion.Total:N2}");
            lstResultados.Items.Add($"Total del minibar US$ :{minibar.Total:N2}");
            lstResultados.Items.Add($"Total general en US$ : {TotalGeneral:N2}");
            lstResultados.Items.Add($"Total general en RD$ : {totalPesos:N2}");
            lstResultados.Items.Add($"Depósito del 30% US$ : {deposito:N2}");
        }
    }
}
