namespace FrmLogin
{
    partial class FrmCrud
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnAgregar = new Button();
            btnModificar = new Button();
            btnEliminar = new Button();
            listBox = new ListBox();
            label1 = new Label();
            lblNombre = new Label();
            lblFecha = new Label();
            lblGestiorest = new Label();
            btnGuardar = new Button();
            btnCargar = new Button();
            btnAlfabetica = new Button();
            btnCapacidad = new Button();
            btnCapacidadAscendente = new Button();
            btnAlfebeticamenteDescendente = new Button();
            btnLogs = new Button();
            SuspendLayout();
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(25, 504);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(171, 76);
            btnAgregar.TabIndex = 0;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(323, 504);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(190, 76);
            btnModificar.TabIndex = 1;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(649, 504);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(176, 76);
            btnEliminar.TabIndex = 2;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // listBox
            // 
            listBox.BackColor = SystemColors.ButtonFace;
            listBox.FormattingEnabled = true;
            listBox.ItemHeight = 15;
            listBox.Location = new Point(25, 84);
            listBox.Name = "listBox";
            listBox.Size = new Size(800, 319);
            listBox.TabIndex = 3;
            listBox.SelectedIndexChanged += listBox_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(0, 471);
            label1.Name = "label1";
            label1.Size = new Size(0, 21);
            label1.TabIndex = 4;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.BackColor = Color.Transparent;
            lblNombre.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblNombre.Location = new Point(3, 584);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(16, 21);
            lblNombre.TabIndex = 5;
            lblNombre.Text = "-";
            lblNombre.Click += lblNombre_Click;
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.BackColor = Color.Transparent;
            lblFecha.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblFecha.Location = new Point(893, 584);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(78, 21);
            lblFecha.TabIndex = 6;
            lblFecha.Text = "xx/xx/xxxx";
            // 
            // lblGestiorest
            // 
            lblGestiorest.AutoSize = true;
            lblGestiorest.Font = new Font("Sitka Small", 24F, FontStyle.Bold, GraphicsUnit.Point);
            lblGestiorest.ImageAlign = ContentAlignment.TopCenter;
            lblGestiorest.Location = new Point(393, 18);
            lblGestiorest.Name = "lblGestiorest";
            lblGestiorest.Size = new Size(240, 48);
            lblGestiorest.TabIndex = 27;
            lblGestiorest.Text = "GESTIOREST";
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(831, 128);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(123, 84);
            btnGuardar.TabIndex = 29;
            btnGuardar.Text = "Guardar datos";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnCargar
            // 
            btnCargar.Location = new Point(831, 275);
            btnCargar.Name = "btnCargar";
            btnCargar.Size = new Size(123, 85);
            btnCargar.TabIndex = 30;
            btnCargar.Text = "Cargar datos";
            btnCargar.UseVisualStyleBackColor = true;
            btnCargar.Click += btnCargar_Click;
            // 
            // btnAlfabetica
            // 
            btnAlfabetica.Location = new Point(25, 409);
            btnAlfabetica.Name = "btnAlfabetica";
            btnAlfabetica.Size = new Size(118, 67);
            btnAlfabetica.TabIndex = 31;
            btnAlfabetica.Text = "Ordenar alfabeticamente de forma ascendente";
            btnAlfabetica.UseVisualStyleBackColor = true;
            btnAlfabetica.Click += btnAlfabetica_Click;
            // 
            // btnCapacidad
            // 
            btnCapacidad.Location = new Point(504, 409);
            btnCapacidad.Name = "btnCapacidad";
            btnCapacidad.Size = new Size(129, 67);
            btnCapacidad.TabIndex = 32;
            btnCapacidad.Text = "Ordenar por capacidad de mayor a menor";
            btnCapacidad.UseVisualStyleBackColor = true;
            btnCapacidad.Click += btnCapacidad_Click;
            // 
            // btnCapacidadAscendente
            // 
            btnCapacidadAscendente.Location = new Point(698, 409);
            btnCapacidadAscendente.Name = "btnCapacidadAscendente";
            btnCapacidadAscendente.Size = new Size(127, 67);
            btnCapacidadAscendente.TabIndex = 33;
            btnCapacidadAscendente.Text = "Ordenar por capacidad de menor a mayor";
            btnCapacidadAscendente.UseVisualStyleBackColor = true;
            btnCapacidadAscendente.Click += btnCapacidadAscendente_Click;
            // 
            // btnAlfebeticamenteDescendente
            // 
            btnAlfebeticamenteDescendente.Location = new Point(173, 409);
            btnAlfebeticamenteDescendente.Name = "btnAlfebeticamenteDescendente";
            btnAlfebeticamenteDescendente.Size = new Size(118, 67);
            btnAlfebeticamenteDescendente.TabIndex = 34;
            btnAlfebeticamenteDescendente.Text = "Ordenar alfabeticamente de forma descendente";
            btnAlfebeticamenteDescendente.UseVisualStyleBackColor = true;
            btnAlfebeticamenteDescendente.Click += btnAlfebeticamenteDescendente_Click;
            // 
            // btnLogs
            // 
            btnLogs.Location = new Point(910, 504);
            btnLogs.Name = "btnLogs";
            btnLogs.Size = new Size(61, 60);
            btnLogs.TabIndex = 35;
            btnLogs.Text = "Ver Logs";
            btnLogs.UseVisualStyleBackColor = true;
            btnLogs.Click += btnLogs_Click;
            // 
            // FrmCrud
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.RosyBrown;
            ClientSize = new Size(983, 608);
            Controls.Add(btnLogs);
            Controls.Add(btnAlfebeticamenteDescendente);
            Controls.Add(btnCapacidadAscendente);
            Controls.Add(btnCapacidad);
            Controls.Add(btnAlfabetica);
            Controls.Add(btnCargar);
            Controls.Add(btnGuardar);
            Controls.Add(lblGestiorest);
            Controls.Add(lblFecha);
            Controls.Add(lblNombre);
            Controls.Add(label1);
            Controls.Add(listBox);
            Controls.Add(btnEliminar);
            Controls.Add(btnModificar);
            Controls.Add(btnAgregar);
            MaximizeBox = false;
            Name = "FrmCrud";
            Text = "GESTIOREST";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAgregar;
        private Button btnModificar;
        private Button btnEliminar;
        private ListBox listBox;
        private Label label1;
        private Label lblNombre;
        private Label lblFecha;
        private Label lblGestiorest;
        private Button btnGuardar;
        private Button btnCargar;
        private Button btnAlfabetica;
        private Button btnCapacidad;
        private Button btnCapacidadAscendente;
        private Button btnAlfebeticamenteDescendente;
        private Button btnLogs;
    }
}