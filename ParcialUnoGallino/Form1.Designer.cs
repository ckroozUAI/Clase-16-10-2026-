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
            button1 = new Button();
            button2 = new Button();
            label12 = new Label();
            lblPendiente = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvAlquileres).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.Location = new Point(30, 21);
            label1.Name = "label1";
            label1.Size = new Size(98, 15);
            label1.TabIndex = 1;
            label1.Text = "Agregar Alquiler";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.Location = new Point(266, 21);
            label2.Name = "label2";
            label2.Size = new Size(106, 15);
            label2.TabIndex = 2;
            label2.Text = "Modificar Alquiler";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.Location = new Point(501, 21);
            label3.Name = "label3";
            label3.Size = new Size(97, 15);
            label3.TabIndex = 3;
            label3.Text = "Eliminar Alquiler";
            // 
            // dgvAlquileres
            // 
            dgvAlquileres.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAlquileres.Location = new Point(683, 21);
            dgvAlquileres.Margin = new Padding(3, 2, 3, 2);
            dgvAlquileres.Name = "dgvAlquileres";
            dgvAlquileres.RowHeadersWidth = 51;
            dgvAlquileres.Size = new Size(424, 394);
            dgvAlquileres.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(30, 70);
            label4.Name = "label4";
            label4.Size = new Size(78, 15);
            label4.TabIndex = 5;
            label4.Text = "Tipo Bicicleta";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(30, 112);
            label5.Name = "label5";
            label5.Size = new Size(65, 15);
            label5.TabIndex = 6;
            label5.Text = "Dni Cliente";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(30, 153);
            label6.Name = "label6";
            label6.Size = new Size(49, 15);
            label6.TabIndex = 7;
            label6.Text = "Importe";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(30, 196);
            label7.Name = "label7";
            label7.Size = new Size(104, 15);
            label7.TabIndex = 8;
            label7.Text = "Fecha Alquiler Fin.";
            // 
            // btnAgregarAlquiler
            // 
            btnAgregarAlquiler.Location = new Point(34, 253);
            btnAgregarAlquiler.Margin = new Padding(3, 2, 3, 2);
            btnAgregarAlquiler.Name = "btnAgregarAlquiler";
            btnAgregarAlquiler.Size = new Size(82, 44);
            btnAgregarAlquiler.TabIndex = 9;
            btnAgregarAlquiler.Text = "Guardar";
            btnAgregarAlquiler.UseVisualStyleBackColor = true;
            btnAgregarAlquiler.Click += btnAgregarAlquiler_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(266, 112);
            label8.Name = "label8";
            label8.Size = new Size(49, 15);
            label8.TabIndex = 10;
            label8.Text = "Importe";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(266, 153);
            label9.Name = "label9";
            label9.Size = new Size(104, 15);
            label9.TabIndex = 11;
            label9.Text = "Fecha Alquiler Fin.";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(266, 70);
            label10.Name = "label10";
            label10.Size = new Size(61, 15);
            label10.TabIndex = 12;
            label10.Text = "Id Alquiler";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(501, 70);
            label11.Name = "label11";
            label11.Size = new Size(61, 15);
            label11.TabIndex = 13;
            label11.Text = "Id Alquiler";
            // 
            // btnModificarAlquiler
            // 
            btnModificarAlquiler.Location = new Point(284, 203);
            btnModificarAlquiler.Margin = new Padding(3, 2, 3, 2);
            btnModificarAlquiler.Name = "btnModificarAlquiler";
            btnModificarAlquiler.Size = new Size(82, 44);
            btnModificarAlquiler.TabIndex = 14;
            btnModificarAlquiler.Text = "Modificar Alquiler";
            btnModificarAlquiler.UseVisualStyleBackColor = true;
            btnModificarAlquiler.Click += btnModificarAlquiler_Click;
            // 
            // btnEliminarAlquiler
            // 
            btnEliminarAlquiler.Location = new Point(521, 124);
            btnEliminarAlquiler.Margin = new Padding(3, 2, 3, 2);
            btnEliminarAlquiler.Name = "btnEliminarAlquiler";
            btnEliminarAlquiler.Size = new Size(82, 44);
            btnEliminarAlquiler.TabIndex = 15;
            btnEliminarAlquiler.Text = "Eliminar Alquiler";
            btnEliminarAlquiler.UseVisualStyleBackColor = true;
            btnEliminarAlquiler.Click += btnEliminarAlquiler_Click;
            // 
            // cbIdEliminar
            // 
            cbIdEliminar.FormattingEnabled = true;
            cbIdEliminar.Location = new Point(501, 87);
            cbIdEliminar.Margin = new Padding(3, 2, 3, 2);
            cbIdEliminar.Name = "cbIdEliminar";
            cbIdEliminar.Size = new Size(133, 23);
            cbIdEliminar.TabIndex = 16;
            // 
            // cbIdModificar
            // 
            cbIdModificar.FormattingEnabled = true;
            cbIdModificar.Location = new Point(266, 87);
            cbIdModificar.Margin = new Padding(3, 2, 3, 2);
            cbIdModificar.Name = "cbIdModificar";
            cbIdModificar.Size = new Size(133, 23);
            cbIdModificar.TabIndex = 17;
            // 
            // cbTipoAgregar
            // 
            cbTipoAgregar.FormattingEnabled = true;
            cbTipoAgregar.Location = new Point(30, 87);
            cbTipoAgregar.Margin = new Padding(3, 2, 3, 2);
            cbTipoAgregar.Name = "cbTipoAgregar";
            cbTipoAgregar.Size = new Size(133, 23);
            cbTipoAgregar.TabIndex = 18;
            // 
            // tbImporteModificar
            // 
            tbImporteModificar.Location = new Point(266, 130);
            tbImporteModificar.Margin = new Padding(3, 2, 3, 2);
            tbImporteModificar.Name = "tbImporteModificar";
            tbImporteModificar.Size = new Size(110, 23);
            tbImporteModificar.TabIndex = 19;
            // 
            // tbImporteAgregar
            // 
            tbImporteAgregar.Location = new Point(30, 170);
            tbImporteAgregar.Margin = new Padding(3, 2, 3, 2);
            tbImporteAgregar.Name = "tbImporteAgregar";
            tbImporteAgregar.Size = new Size(133, 23);
            tbImporteAgregar.TabIndex = 20;
            // 
            // tbDniAgregar
            // 
            tbDniAgregar.Location = new Point(30, 130);
            tbDniAgregar.Margin = new Padding(3, 2, 3, 2);
            tbDniAgregar.Name = "tbDniAgregar";
            tbDniAgregar.Size = new Size(133, 23);
            tbDniAgregar.TabIndex = 21;
            // 
            // dtFechaAlquilerAgregar
            // 
            dtFechaAlquilerAgregar.Location = new Point(34, 214);
            dtFechaAlquilerAgregar.Margin = new Padding(3, 2, 3, 2);
            dtFechaAlquilerAgregar.Name = "dtFechaAlquilerAgregar";
            dtFechaAlquilerAgregar.Size = new Size(128, 23);
            dtFechaAlquilerAgregar.TabIndex = 22;
            // 
            // dtFechaAlquilerModificar
            // 
            dtFechaAlquilerModificar.Location = new Point(266, 170);
            dtFechaAlquilerModificar.Margin = new Padding(3, 2, 3, 2);
            dtFechaAlquilerModificar.Name = "dtFechaAlquilerModificar";
            dtFechaAlquilerModificar.Size = new Size(128, 23);
            dtFechaAlquilerModificar.TabIndex = 23;
            // 
            // button1
            // 
            button1.Location = new Point(12, 361);
            button1.Name = "button1";
            button1.Size = new Size(158, 23);
            button1.TabIndex = 24;
            button1.Text = "Agregar Alquiler";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(12, 390);
            button2.Name = "button2";
            button2.Size = new Size(158, 23);
            button2.TabIndex = 25;
            button2.Text = "Confirmar Guardado";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(191, 369);
            label12.Name = "label12";
            label12.Size = new Size(139, 15);
            label12.TabIndex = 26;
            label12.Text = "Pendiente de guardado : ";
            // 
            // lblPendiente
            // 
            lblPendiente.AutoSize = true;
            lblPendiente.Location = new Point(191, 394);
            lblPendiente.Name = "lblPendiente";
            lblPendiente.Size = new Size(0, 15);
            lblPendiente.TabIndex = 27;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1131, 436);
            Controls.Add(lblPendiente);
            Controls.Add(label12);
            Controls.Add(button2);
            Controls.Add(button1);
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
        private Button button1;
        private Button button2;
        private Label label12;
        private Label lblPendiente;
    }
}
