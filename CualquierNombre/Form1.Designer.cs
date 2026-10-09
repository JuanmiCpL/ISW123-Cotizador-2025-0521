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
            btnDesglose = new Button();
            btnFinSemana = new Button();
            chkFinSemana = new CheckBox();
            btnDeposito = new Button();
            label2 = new Label();
            btnPorPersona = new Button();
            nudPersonas = new NumericUpDown();
            btnPesos = new Button();
            label1 = new Label();
            nudTasa = new NumericUpDown();
            btnNivel1 = new Button();
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
            ((System.ComponentModel.ISupportInitialize)nudNoches).BeginInit();
            gbCotizador.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudPersonas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudTasa).BeginInit();
            gbTotales.SuspendLayout();
            SuspendLayout();
            // 
            // lblHuesped
            // 
            lblHuesped.AutoSize = true;
            lblHuesped.Location = new Point(26, 33);
            lblHuesped.Name = "lblHuesped";
            lblHuesped.Size = new Size(71, 20);
            lblHuesped.TabIndex = 0;
            lblHuesped.Text = "Huesped:";
            // 
            // lblNoches
            // 
            lblNoches.AutoSize = true;
            lblNoches.Location = new Point(26, 74);
            lblNoches.Name = "lblNoches";
            lblNoches.Size = new Size(61, 20);
            lblNoches.TabIndex = 1;
            lblNoches.Text = "Noches:";
            // 
            // nudNoches
            // 
            nudNoches.Location = new Point(203, 67);
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
            lblTarifa.Location = new Point(26, 110);
            lblTarifa.Name = "lblTarifa";
            lblTarifa.Size = new Size(159, 20);
            lblTarifa.TabIndex = 2;
            lblTarifa.Text = "Tarifa por Noche (usd):";
            // 
            // chkTemporadaAlta
            // 
            chkTemporadaAlta.AutoSize = true;
            chkTemporadaAlta.Location = new Point(26, 272);
            chkTemporadaAlta.Name = "chkTemporadaAlta";
            chkTemporadaAlta.Size = new Size(190, 24);
            chkTemporadaAlta.TabIndex = 3;
            chkTemporadaAlta.Text = "Temporada Alta (+25%)";
            chkTemporadaAlta.UseVisualStyleBackColor = true;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(448, 24);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(314, 29);
            btnCalcular.TabIndex = 4;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(448, 65);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(314, 29);
            btnLimpiar.TabIndex = 5;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // gbCotizador
            // 
            gbCotizador.Controls.Add(btnDesglose);
            gbCotizador.Controls.Add(btnFinSemana);
            gbCotizador.Controls.Add(chkFinSemana);
            gbCotizador.Controls.Add(btnDeposito);
            gbCotizador.Controls.Add(label2);
            gbCotizador.Controls.Add(btnPorPersona);
            gbCotizador.Controls.Add(nudPersonas);
            gbCotizador.Controls.Add(btnPesos);
            gbCotizador.Controls.Add(label1);
            gbCotizador.Controls.Add(nudTasa);
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
            gbCotizador.Size = new Size(783, 485);
            gbCotizador.TabIndex = 11;
            gbCotizador.TabStop = false;
            gbCotizador.Text = "Cotizador";
            // 
            // btnDesglose
            // 
            btnDesglose.Location = new Point(448, 315);
            btnDesglose.Name = "btnDesglose";
            btnDesglose.Size = new Size(314, 29);
            btnDesglose.TabIndex = 24;
            btnDesglose.Text = "Desglose";
            btnDesglose.UseVisualStyleBackColor = true;
            btnDesglose.Click += btnDesglose_Click;
            // 
            // btnFinSemana
            // 
            btnFinSemana.Location = new Point(448, 267);
            btnFinSemana.Name = "btnFinSemana";
            btnFinSemana.Size = new Size(314, 29);
            btnFinSemana.TabIndex = 23;
            btnFinSemana.Text = "Fin de Semana";
            btnFinSemana.UseVisualStyleBackColor = true;
            btnFinSemana.Click += btnFinSemana_Click;
            // 
            // chkFinSemana
            // 
            chkFinSemana.AutoSize = true;
            chkFinSemana.Location = new Point(242, 272);
            chkFinSemana.Name = "chkFinSemana";
            chkFinSemana.Size = new Size(178, 24);
            chkFinSemana.TabIndex = 22;
            chkFinSemana.Text = "Fin de semana (+15%)";
            chkFinSemana.UseVisualStyleBackColor = true;
            chkFinSemana.CheckedChanged += chkFinSemana_CheckedChanged;
            // 
            // btnDeposito
            // 
            btnDeposito.Location = new Point(448, 223);
            btnDeposito.Name = "btnDeposito";
            btnDeposito.Size = new Size(314, 29);
            btnDeposito.TabIndex = 21;
            btnDeposito.Text = "Deposito";
            btnDeposito.UseVisualStyleBackColor = true;
            btnDeposito.Click += btnDeposito_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(26, 188);
            label2.Name = "label2";
            label2.Size = new Size(69, 20);
            label2.TabIndex = 20;
            label2.Text = "Personas:";
            // 
            // btnPorPersona
            // 
            btnPorPersona.Location = new Point(448, 179);
            btnPorPersona.Name = "btnPorPersona";
            btnPorPersona.Size = new Size(314, 29);
            btnPorPersona.TabIndex = 19;
            btnPorPersona.Text = "Por persona";
            btnPorPersona.UseVisualStyleBackColor = true;
            btnPorPersona.Click += btnPorPersona_Click;
            // 
            // nudPersonas
            // 
            nudPersonas.Location = new Point(203, 181);
            nudPersonas.Maximum = new decimal(new int[] { 20, 0, 0, 0 });
            nudPersonas.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudPersonas.Name = "nudPersonas";
            nudPersonas.Size = new Size(217, 27);
            nudPersonas.TabIndex = 18;
            nudPersonas.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // btnPesos
            // 
            btnPesos.Location = new Point(448, 139);
            btnPesos.Name = "btnPesos";
            btnPesos.Size = new Size(314, 29);
            btnPesos.TabIndex = 17;
            btnPesos.Text = "Total en RD$";
            btnPesos.UseVisualStyleBackColor = true;
            btnPesos.Click += btnPesos_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 148);
            label1.Name = "label1";
            label1.Size = new Size(104, 20);
            label1.TabIndex = 16;
            label1.Text = "Tasa del dólar:";
            // 
            // nudTasa
            // 
            nudTasa.DecimalPlaces = 2;
            nudTasa.Location = new Point(203, 141);
            nudTasa.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            nudTasa.Name = "nudTasa";
            nudTasa.Size = new Size(217, 27);
            nudTasa.TabIndex = 15;
            // 
            // btnNivel1
            // 
            btnNivel1.Location = new Point(448, 103);
            btnNivel1.Name = "btnNivel1";
            btnNivel1.Size = new Size(314, 29);
            btnNivel1.TabIndex = 14;
            btnNivel1.Text = "Nivel 1";
            btnNivel1.UseVisualStyleBackColor = true;
            btnNivel1.Click += btnNivel1_Click;
            // 
            // btnCopiar
            // 
            btnCopiar.Location = new Point(11, 424);
            btnCopiar.Name = "btnCopiar";
            btnCopiar.Size = new Size(751, 29);
            btnCopiar.TabIndex = 13;
            btnCopiar.Text = "Copiar para WhatsApp";
            btnCopiar.UseVisualStyleBackColor = true;
            btnCopiar.Click += btnCopiar_Click;
            // 
            // txtHuesped
            // 
            txtHuesped.Location = new Point(203, 26);
            txtHuesped.Name = "txtHuesped";
            txtHuesped.Size = new Size(217, 27);
            txtHuesped.TabIndex = 12;
            // 
            // txtTarifa
            // 
            txtTarifa.Location = new Point(203, 103);
            txtTarifa.Name = "txtTarifa";
            txtTarifa.Size = new Size(217, 27);
            txtTarifa.TabIndex = 2;
            // 
            // btnImperativo
            // 
            btnImperativo.Location = new Point(26, 223);
            btnImperativo.Name = "btnImperativo";
            btnImperativo.Size = new Size(394, 29);
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
            gbTotales.Location = new Point(12, 512);
            gbTotales.Name = "gbTotales";
            gbTotales.Size = new Size(783, 205);
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
            lblTotal.Location = new Point(568, 169);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(40, 20);
            lblTotal.TabIndex = 4;
            lblTotal.Text = "0.00";
            lblTotal.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblServicio
            // 
            lblServicio.Location = new Point(568, 140);
            lblServicio.Name = "lblServicio";
            lblServicio.Size = new Size(36, 20);
            lblServicio.TabIndex = 3;
            lblServicio.Text = "0.00";
            lblServicio.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblItbis
            // 
            lblItbis.Location = new Point(568, 104);
            lblItbis.Name = "lblItbis";
            lblItbis.Size = new Size(36, 20);
            lblItbis.TabIndex = 2;
            lblItbis.Text = "0.00";
            lblItbis.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblDescuento
            // 
            lblDescuento.Location = new Point(568, 71);
            lblDescuento.Name = "lblDescuento";
            lblDescuento.Size = new Size(36, 20);
            lblDescuento.TabIndex = 1;
            lblDescuento.Text = "0.00";
            lblDescuento.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblSubtotal
            // 
            lblSubtotal.Location = new Point(568, 41);
            lblSubtotal.Name = "lblSubtotal";
            lblSubtotal.Size = new Size(36, 20);
            lblSubtotal.TabIndex = 0;
            lblSubtotal.Text = "0.00";
            lblSubtotal.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lstResultados
            // 
            lstResultados.FormattingEnabled = true;
            lstResultados.Location = new Point(813, 29);
            lstResultados.Name = "lstResultados";
            lstResultados.Size = new Size(379, 564);
            lstResultados.TabIndex = 13;
            // 
            // frmInicio
            // 
            AcceptButton = btnCalcular;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1204, 729);
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
            ((System.ComponentModel.ISupportInitialize)nudPersonas).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudTasa).EndInit();
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
        private Button btnPesos;
        private Button btnNivel1;
        private Label label1;
        private NumericUpDown nudTasa;
        private Label label2;
        private Button btnPorPersona;
        private NumericUpDown nudPersonas;
        private Button btnDeposito;
        private CheckBox chkFinSemana;
        private Button btnFinSemana;
        private Button btnDesglose;
    }
}
