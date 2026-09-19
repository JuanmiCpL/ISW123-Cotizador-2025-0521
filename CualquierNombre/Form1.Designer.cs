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
            label1 = new Label();
            lblHuesped = new Label();
            texHuesped = new TextBox();
            lblNoches = new Label();
            nudNoches = new NumericUpDown();
            lblTarifa = new Label();
            nudTarifa = new NumericUpDown();
            ckTemporada = new CheckBox();
            btnCalcular = new Button();
            btnLimpiar = new Button();
            gbCotizador = new GroupBox();
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
            ((System.ComponentModel.ISupportInitialize)nudNoches).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudTarifa).BeginInit();
            gbCotizador.SuspendLayout();
            gbTotales.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(635, 104);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 1;
            label1.Text = "label1";
            // 
            // lblHuesped
            // 
            lblHuesped.AutoSize = true;
            lblHuesped.Location = new Point(26, 32);
            lblHuesped.Name = "lblHuesped";
            lblHuesped.Size = new Size(71, 20);
            lblHuesped.TabIndex = 2;
            lblHuesped.Text = "Huesped:";
            // 
            // texHuesped
            // 
            texHuesped.Location = new Point(235, 25);
            texHuesped.Name = "texHuesped";
            texHuesped.Size = new Size(217, 27);
            texHuesped.TabIndex = 3;
            texHuesped.Visible = false;
            // 
            // lblNoches
            // 
            lblNoches.AutoSize = true;
            lblNoches.Location = new Point(26, 77);
            lblNoches.Name = "lblNoches";
            lblNoches.Size = new Size(61, 20);
            lblNoches.TabIndex = 4;
            lblNoches.Text = "Noches:";
            // 
            // nudNoches
            // 
            nudNoches.Location = new Point(235, 70);
            nudNoches.Name = "nudNoches";
            nudNoches.Size = new Size(217, 27);
            nudNoches.TabIndex = 5;
            // 
            // lblTarifa
            // 
            lblTarifa.AutoSize = true;
            lblTarifa.Location = new Point(26, 125);
            lblTarifa.Name = "lblTarifa";
            lblTarifa.Size = new Size(159, 20);
            lblTarifa.TabIndex = 6;
            lblTarifa.Text = "Tarifa por Noche (usd):";
            // 
            // nudTarifa
            // 
            nudTarifa.Location = new Point(235, 118);
            nudTarifa.Name = "nudTarifa";
            nudTarifa.Size = new Size(217, 27);
            nudTarifa.TabIndex = 7;
            // 
            // ckTemporada
            // 
            ckTemporada.AutoSize = true;
            ckTemporada.Location = new Point(134, 173);
            ckTemporada.Name = "ckTemporada";
            ckTemporada.Size = new Size(190, 24);
            ckTemporada.TabIndex = 8;
            ckTemporada.Text = "Temporada Alta (+25%)";
            ckTemporada.UseVisualStyleBackColor = true;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(73, 226);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(94, 29);
            btnCalcular.TabIndex = 9;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(280, 226);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(94, 29);
            btnLimpiar.TabIndex = 10;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // gbCotizador
            // 
            gbCotizador.Controls.Add(nudNoches);
            gbCotizador.Controls.Add(btnLimpiar);
            gbCotizador.Controls.Add(lblHuesped);
            gbCotizador.Controls.Add(btnCalcular);
            gbCotizador.Controls.Add(texHuesped);
            gbCotizador.Controls.Add(ckTemporada);
            gbCotizador.Controls.Add(lblNoches);
            gbCotizador.Controls.Add(nudTarifa);
            gbCotizador.Controls.Add(lblTarifa);
            gbCotizador.Location = new Point(12, 21);
            gbCotizador.Name = "gbCotizador";
            gbCotizador.Size = new Size(458, 280);
            gbCotizador.TabIndex = 11;
            gbCotizador.TabStop = false;
            gbCotizador.Text = "Cotizador";
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
            gbTotales.TabIndex = 12;
            gbTotales.TabStop = false;
            gbTotales.Text = "Totales";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(26, 169);
            label4.Name = "label4";
            label4.Size = new Size(42, 20);
            label4.TabIndex = 9;
            label4.Text = "Total";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(26, 140);
            label5.Name = "label5";
            label5.Size = new Size(59, 20);
            label5.TabIndex = 8;
            label5.Text = "servicio";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(26, 104);
            label6.Name = "label6";
            label6.Size = new Size(37, 20);
            label6.TabIndex = 7;
            label6.Text = "Itbis";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(26, 41);
            label7.Name = "label7";
            label7.Size = new Size(79, 20);
            label7.TabIndex = 6;
            label7.Text = "Descuento";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(26, 71);
            label8.Name = "label8";
            label8.Size = new Size(65, 20);
            label8.TabIndex = 5;
            label8.Text = "Subtotal";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(181, 169);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(42, 20);
            lblTotal.TabIndex = 4;
            lblTotal.Text = "Total";
            // 
            // lblServicio
            // 
            lblServicio.AutoSize = true;
            lblServicio.Location = new Point(181, 140);
            lblServicio.Name = "lblServicio";
            lblServicio.Size = new Size(59, 20);
            lblServicio.TabIndex = 3;
            lblServicio.Text = "servicio";
            // 
            // lblItbis
            // 
            lblItbis.AutoSize = true;
            lblItbis.Location = new Point(181, 104);
            lblItbis.Name = "lblItbis";
            lblItbis.Size = new Size(37, 20);
            lblItbis.TabIndex = 2;
            lblItbis.Text = "Itbis";
            // 
            // lblDescuento
            // 
            lblDescuento.AutoSize = true;
            lblDescuento.Location = new Point(181, 41);
            lblDescuento.Name = "lblDescuento";
            lblDescuento.Size = new Size(79, 20);
            lblDescuento.TabIndex = 1;
            lblDescuento.Text = "Descuento";
            // 
            // lblSubtotal
            // 
            lblSubtotal.AutoSize = true;
            lblSubtotal.Location = new Point(181, 71);
            lblSubtotal.Name = "lblSubtotal";
            lblSubtotal.Size = new Size(65, 20);
            lblSubtotal.TabIndex = 0;
            lblSubtotal.Text = "Subtotal";
            // 
            // frmInicio
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(482, 553);
            Controls.Add(gbTotales);
            Controls.Add(gbCotizador);
            Controls.Add(label1);
            Enabled = false;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmInicio";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cotizador Villa Coral - Juan Manuel Contreras - 2025-0521";
            ((System.ComponentModel.ISupportInitialize)nudNoches).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudTarifa).EndInit();
            gbCotizador.ResumeLayout(false);
            gbCotizador.PerformLayout();
            gbTotales.ResumeLayout(false);
            gbTotales.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label lblHuesped;
        private TextBox texHuesped;
        private Label lblNoches;
        private NumericUpDown nudNoches;
        private Label lblTarifa;
        private NumericUpDown nudTarifa;
        private CheckBox ckTemporada;
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
    }
}
