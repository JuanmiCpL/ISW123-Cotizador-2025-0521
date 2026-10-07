namespace CualquierNombre
{
    partial class frmInicio
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblHuesped = new Label();
            lblNoches = new Label();
            nudNoches = new NumericUpDown();
            lblTarifa = new Label();
            chkTemporadaAlta = new CheckBox();
            btnCalcular = new Button();
            btnLimpiar = new Button();
            gbCotizador = new GroupBox();
            btnCopiar = new Button();
            txtHuesped = new TextBox();
            txtTarifa = new TextBox();
            btnImperativo = new Button();
            gbTotales = new GroupBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            lblTotal = new Label();
            lblServicio = new Label();
            lblItbis = new Label();
            lblDescuento = new Label();
            lblSubtotal = new Label();
            lstResultados = new ListBox();
            btnNivel1 = new Button();
            ((System.ComponentModel.ISupportInitialize)nudNoches).BeginInit();
            gbCotizador.SuspendLayout();
            gbTotales.SuspendLayout();
            SuspendLayout();
            // 
            // lblHuesped
            // 
            lblHuesped.AutoSize = true;
            lblHuesped.Location = new Point(26, 32);
            lblHuesped.Name = "lblHuesped";
            lblHuesped.Size = new Size(71, 20);
            lblHuesped.TabIndex = 0;
            lblHuesped.Text = "Huesped:";
            // 
            // lblNoches
            // 
            lblNoches.AutoSize = true;
            lblNoches.Location = new Point(26, 77);
            lblNoches.Name = "lblNoches";
            lblNoches.Size = new Size(61, 20);
            lblNoches.TabIndex = 1;
            lblNoches.Text = "Noches:";
            // 
            // nudNoches
            // 
            nudNoches.Location = new Point(235, 70);
            nudNoches.Maximum = new decimal(new int[] { 60, 0, 0, 0 });
            nudNoches.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudNoches.Name = "nudNoches";
            nudNoches.Size = new Size(217, 27);
            nudNoches.TabIndex = 1;
            nudNoches.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // lblTarifa
            // 
            lblTarifa.AutoSize = true;
            lblTarifa.Location = new Point(26, 125);
            lblTarifa.Name = "lblTarifa";
            lblTarifa.Size = new Size(159, 20);
            lblTarifa.TabIndex = 2;
            lblTarifa.Text = "Tarifa por Noche (usd):";
            // 
            // chkTemporadaAlta
            // 
            chkTemporadaAlta.AutoSize = true;
            chkTemporadaAlta.Location = new Point(133, 165);
            chkTemporadaAlta.Name = "chkTemporadaAlta";
            chkTemporadaAlta.Size = new Size(190, 24);
            chkTemporadaAlta.TabIndex = 3;
            chkTemporadaAlta.Text = "Temporada Alta (+25%)";
            chkTemporadaAlta.UseVisualStyleBackColor = true;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(183, 195);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(94, 29);
            btnCalcular.TabIndex = 4;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(342, 195);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(94, 29);
            btnLimpiar.TabIndex = 5;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // gbCotizador
            // 
            gbCotizador.Controls.Add(btnNivel1);
            gbCotizador.Controls.Add(btnCopiar);
            gbCotizador.Controls.Add(txtHuesped);
            gbCotizador.Controls.Add(txtTarifa);
            gbCotizador.Controls.Add(btnImperativo);
            gbCotizador.Controls.Add(nudNoches);
            gbCotizador.Controls.Add(btnLimpiar);
            gbCotizador.Controls.Add(lblHuesped);
            gbCotizador.Controls.Add(btnCalcular);
            gbCotizador.Controls.Add(chkTemporadaAlta);
            gbCotizador.Controls.Add(lblNoches);
            gbCotizador.Controls.Add(lblTarifa);
            gbCotizador.Location = new Point(12, 21);
            gbCotizador.Name = "gbCotizador";
            gbCotizador.Size = new Size(458, 280);
            gbCotizador.TabIndex = 11;
            gbCotizador.TabStop = false;
            gbCotizador.Text = "Cotizador";
            // 
            // btnCopiar
            // 
            btnCopiar.Location = new Point(26, 245);
            btnCopiar.Name = "btnCopiar";
            btnCopiar.Size = new Size(410, 29);
            btnCopiar.TabIndex = 13;
            btnCopiar.Text = "Copiar para WhatsApp";
            btnCopiar.UseVisualStyleBackColor = true;
            btnCopiar.Click += btnCopiar_Click;
            // 
            // txtHuesped
            // 
            txtHuesped.Location = new Point(235, 25);
            txtHuesped.Name = "txtHuesped";
            txtHuesped.Size = new Size(217, 27);
            txtHuesped.TabIndex = 12;
            // 
            // txtTarifa
            // 
            txtTarifa.Location = new Point(235, 118);
            txtTarifa.Name = "txtTarifa";
            txtTarifa.Size = new Size(217, 27);
            txtTarifa.TabIndex = 2;
            // 
            // btnImperativo
            // 
            btnImperativo.Location = new Point(26, 195);
            btnImperativo.Name = "btnImperativo";
            btnImperativo.Size = new Size(94, 29);
            btnImperativo.TabIndex = 11;
            btnImperativo.Text = "Imperativo";
            btnImperativo.UseVisualStyleBackColor = true;
            btnImperativo.Click += btnImperativo_Click;
            // 
            // gbTotales
            // 
            gbTotales.Controls.Add(label4);
            gbTotales.Controls.Add(label5);
            gbTotales.Controls.Add(label6);
            gbTotales.Controls.Add(label7);
            gbTotales.Controls.Add(label8);
            gbTotales.Controls.Add(lblTotal);
            gbTotales.Controls.Add(lblServicio);
            gbTotales.Controls.Add(lblItbis);
            gbTotales.Controls.Add(lblDescuento);
            gbTotales.Controls.Add(lblSubtotal);
            gbTotales.Location = new Point(12, 318);
            gbTotales.Name = "gbTotales";
            gbTotales.Size = new Size(458, 205);
            gbTotales.TabIndex = 0;
            gbTotales.TabStop = false;
            gbTotales.Text = "Totales";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ActiveCaptionText;
            label4.Location = new Point(26, 169);
            label4.Name = "label4";
            label4.Size = new Size(88, 20);
            label4.TabIndex = 9;
            label4.Text = "TOTAL USD";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(26, 140);
            label5.Name = "label5";
            label5.Size = new Size(93, 20);
            label5.TabIndex = 8;
            label5.Text = "Servicio 10%";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(26, 104);
            label6.Name = "label6";
            label6.Size = new Size(74, 20);
            label6.TabIndex = 7;
            label6.Text = "ITBIS 18%";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(26, 71);
            label7.Name = "label7";
            label7.Size = new Size(79, 20);
            label7.TabIndex = 6;
            label7.Text = "Descuento";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(26, 41);
            label8.Name = "label8";
            label8.Size = new Size(65, 20);
            label8.TabIndex = 5;
            label8.Text = "Subtotal";
            // 
            // lblTotal
            // 
            lblTotal.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotal.Location = new Point(331, 169);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(40, 20);
            lblTotal.TabIndex = 4;
            lblTotal.Text = "0.00";
            lblTotal.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblServicio
            // 
            lblServicio.Location = new Point(331, 140);
            lblServicio.Name = "lblServicio";
            lblServicio.Size = new Size(36, 20);
            lblServicio.TabIndex = 3;
            lblServicio.Text = "0.00";
            lblServicio.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblItbis
            // 
            lblItbis.Location = new Point(331, 104);
            lblItbis.Name = "lblItbis";
            lblItbis.Size = new Size(36, 20);
            lblItbis.TabIndex = 2;
            lblItbis.Text = "0.00";
            lblItbis.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblDescuento
            // 
            lblDescuento.Location = new Point(331, 41);
            lblDescuento.Name = "lblDescuento";
            lblDescuento.Size = new Size(36, 20);
            lblDescuento.TabIndex = 1;
            lblDescuento.Text = "0.00";
            lblDescuento.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblSubtotal
            // 
            lblSubtotal.Location = new Point(331, 71);
            lblSubtotal.Name = "lblSubtotal";
            lblSubtotal.Size = new Size(36, 20);
            lblSubtotal.TabIndex = 0;
            lblSubtotal.Text = "0.00";
            lblSubtotal.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lstResultados
            // 
            lstResultados.FormattingEnabled = true;
            lstResultados.Location = new Point(494, 19);
            lstResultados.Name = "lstResultados";
            lstResultados.Size = new Size(344, 504);
            lstResultados.TabIndex = 13;
            // 
            // btnNivel1
            // 
            btnNivel1.Location = new Point(342, 151);
            btnNivel1.Name = "btnNivel1";
            btnNivel1.Size = new Size(94, 29);
            btnNivel1.TabIndex = 14;
            btnNivel1.Text = "button1";
            btnNivel1.UseVisualStyleBackColor = true;
            btnNivel1.Click += btnNivel1_Click;
            // 
            // frmInicio
            // 
            AcceptButton = btnCalcular;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(850, 553);
            Controls.Add(lstResultados);
            Controls.Add(gbTotales);
            Controls.Add(gbCotizador);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmInicio";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cotizador Villa Coral - Juan Manuel Contreras - 2025-0521";
            ((System.ComponentModel.ISupportInitialize)nudNoches).EndInit();
            gbCotizador.ResumeLayout(false);
            gbCotizador.PerformLayout();
            gbTotales.ResumeLayout(false);
            gbTotales.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Label lblHuesped;
        private Label lblNoches;
        private NumericUpDown nudNoches;
        private Label lblTarifa;
        private NumericUpDown nudTarifa;
        private CheckBox chkTemporadaAlta;
        private Button btnCalcular;
        private Button btnLimpiar;
        private GroupBox gbCotizador;
        private GroupBox gbTotales;
        private Label lblServicio;
        private Label lblItbis;
        private Label lblDescuento;
        private Label lblSubtotal;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label lblTotal;
        private Button btnImperativo;
        private ListBox lstResultados;
        private TextBox txtTarifa;
        private TextBox txtHuesped;
        private Button btnCopiar;
        private Button button1;
        private Button btnNivel1;
    }
}
