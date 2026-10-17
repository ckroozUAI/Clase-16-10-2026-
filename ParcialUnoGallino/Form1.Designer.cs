namespace ParcialUnoGallino
{
    partial class Form1
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
            label2 = new Label();
            label3 = new Label();
            dgvAlquileres = new DataGridView();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            btnAgregarAlquiler = new Button();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            btnModificarAlquiler = new Button();
            btnEliminarAlquiler = new Button();
            cbIdEliminar = new ComboBox();
            cbIdModificar = new ComboBox();
            cbTipoAgregar = new ComboBox();
            tbImporteModificar = new TextBox();
            tbImporteAgregar = new TextBox();
            tbDniAgregar = new TextBox();
            dtFechaAlquilerAgregar = new DateTimePicker();
            dtFechaAlquilerModificar = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)dgvAlquileres).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.Location = new Point(34, 28);
            label1.Name = "label1";
            label1.Size = new Size(125, 20);
            label1.TabIndex = 1;
            label1.Text = "Agregar Alquiler";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.Location = new Point(304, 28);
            label2.Name = "label2";
            label2.Size = new Size(135, 20);
            label2.TabIndex = 2;
            label2.Text = "Modificar Alquiler";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.Location = new Point(573, 28);
            label3.Name = "label3";
            label3.Size = new Size(125, 20);
            label3.TabIndex = 3;
            label3.Text = "Eliminar Alquiler";
            // 
            // dgvAlquileres
            // 
            dgvAlquileres.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAlquileres.Location = new Point(781, 28);
            dgvAlquileres.Name = "dgvAlquileres";
            dgvAlquileres.RowHeadersWidth = 51;
            dgvAlquileres.Size = new Size(485, 526);
            dgvAlquileres.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(34, 93);
            label4.Name = "label4";
            label4.Size = new Size(99, 20);
            label4.TabIndex = 5;
            label4.Text = "Tipo Bicicleta";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(34, 150);
            label5.Name = "label5";
            label5.Size = new Size(82, 20);
            label5.TabIndex = 6;
            label5.Text = "Dni Cliente";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(34, 204);
            label6.Name = "label6";
            label6.Size = new Size(62, 20);
            label6.TabIndex = 7;
            label6.Text = "Importe";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(34, 262);
            label7.Name = "label7";
            label7.Size = new Size(129, 20);
            label7.TabIndex = 8;
            label7.Text = "Fecha Alquiler Fin.";
            // 
            // btnAgregarAlquiler
            // 
            btnAgregarAlquiler.Location = new Point(39, 337);
            btnAgregarAlquiler.Name = "btnAgregarAlquiler";
            btnAgregarAlquiler.Size = new Size(94, 59);
            btnAgregarAlquiler.TabIndex = 9;
            btnAgregarAlquiler.Text = "Agregar Alquiler";
            btnAgregarAlquiler.UseVisualStyleBackColor = true;
            btnAgregarAlquiler.Click += btnAgregarAlquiler_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(304, 150);
            label8.Name = "label8";
            label8.Size = new Size(62, 20);
            label8.TabIndex = 10;
            label8.Text = "Importe";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(304, 204);
            label9.Name = "label9";
            label9.Size = new Size(129, 20);
            label9.TabIndex = 11;
            label9.Text = "Fecha Alquiler Fin.";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(304, 93);
            label10.Name = "label10";
            label10.Size = new Size(78, 20);
            label10.TabIndex = 12;
            label10.Text = "Id Alquiler";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(573, 93);
            label11.Name = "label11";
            label11.Size = new Size(78, 20);
            label11.TabIndex = 13;
            label11.Text = "Id Alquiler";
            // 
            // btnModificarAlquiler
            // 
            btnModificarAlquiler.Location = new Point(324, 271);
            btnModificarAlquiler.Name = "btnModificarAlquiler";
            btnModificarAlquiler.Size = new Size(94, 59);
            btnModificarAlquiler.TabIndex = 14;
            btnModificarAlquiler.Text = "Modificar Alquiler";
            btnModificarAlquiler.UseVisualStyleBackColor = true;
            btnModificarAlquiler.Click += btnModificarAlquiler_Click;
            // 
            // btnEliminarAlquiler
            // 
            btnEliminarAlquiler.Location = new Point(595, 165);
            btnEliminarAlquiler.Name = "btnEliminarAlquiler";
            btnEliminarAlquiler.Size = new Size(94, 59);
            btnEliminarAlquiler.TabIndex = 15;
            btnEliminarAlquiler.Text = "Eliminar Alquiler";
            btnEliminarAlquiler.UseVisualStyleBackColor = true;
            btnEliminarAlquiler.Click += btnEliminarAlquiler_Click;
            // 
            // cbIdEliminar
            // 
            cbIdEliminar.FormattingEnabled = true;
            cbIdEliminar.Location = new Point(573, 116);
            cbIdEliminar.Name = "cbIdEliminar";
            cbIdEliminar.Size = new Size(151, 28);
            cbIdEliminar.TabIndex = 16;
            // 
            // cbIdModificar
            // 
            cbIdModificar.FormattingEnabled = true;
            cbIdModificar.Location = new Point(304, 116);
            cbIdModificar.Name = "cbIdModificar";
            cbIdModificar.Size = new Size(151, 28);
            cbIdModificar.TabIndex = 17;
            // 
            // cbTipoAgregar
            // 
            cbTipoAgregar.FormattingEnabled = true;
            cbTipoAgregar.Location = new Point(34, 116);
            cbTipoAgregar.Name = "cbTipoAgregar";
            cbTipoAgregar.Size = new Size(151, 28);
            cbTipoAgregar.TabIndex = 18;
            // 
            // tbImporteModificar
            // 
            tbImporteModificar.Location = new Point(304, 174);
            tbImporteModificar.Name = "tbImporteModificar";
            tbImporteModificar.Size = new Size(125, 27);
            tbImporteModificar.TabIndex = 19;
            // 
            // tbImporteAgregar
            // 
            tbImporteAgregar.Location = new Point(34, 227);
            tbImporteAgregar.Name = "tbImporteAgregar";
            tbImporteAgregar.Size = new Size(151, 27);
            tbImporteAgregar.TabIndex = 20;
            // 
            // tbDniAgregar
            // 
            tbDniAgregar.Location = new Point(34, 173);
            tbDniAgregar.Name = "tbDniAgregar";
            tbDniAgregar.Size = new Size(151, 27);
            tbDniAgregar.TabIndex = 21;
            // 
            // dtFechaAlquilerAgregar
            // 
            dtFechaAlquilerAgregar.Location = new Point(39, 285);
            dtFechaAlquilerAgregar.Name = "dtFechaAlquilerAgregar";
            dtFechaAlquilerAgregar.Size = new Size(146, 27);
            dtFechaAlquilerAgregar.TabIndex = 22;
            // 
            // dtFechaAlquilerModificar
            // 
            dtFechaAlquilerModificar.Location = new Point(304, 227);
            dtFechaAlquilerModificar.Name = "dtFechaAlquilerModificar";
            dtFechaAlquilerModificar.Size = new Size(146, 27);
            dtFechaAlquilerModificar.TabIndex = 23;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1293, 582);
            Controls.Add(dtFechaAlquilerModificar);
            Controls.Add(dtFechaAlquilerAgregar);
            Controls.Add(tbDniAgregar);
            Controls.Add(tbImporteAgregar);
            Controls.Add(tbImporteModificar);
            Controls.Add(cbTipoAgregar);
            Controls.Add(cbIdModificar);
            Controls.Add(cbIdEliminar);
            Controls.Add(btnEliminarAlquiler);
            Controls.Add(btnModificarAlquiler);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(btnAgregarAlquiler);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(dgvAlquileres);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvAlquileres).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label label2;
        private Label label3;
        private DataGridView dgvAlquileres;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Button btnAgregarAlquiler;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Button btnModificarAlquiler;
        private Button btnEliminarAlquiler;
        private ComboBox cbIdEliminar;
        private ComboBox cbIdModificar;
        private ComboBox cbTipoAgregar;
        private TextBox tbImporteModificar;
        private TextBox tbImporteAgregar;
        private TextBox tbDniAgregar;
        private DateTimePicker dtFechaAlquilerAgregar;
        private DateTimePicker dtFechaAlquilerModificar;
    }
}
