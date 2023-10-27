namespace FrmLogin
{
    partial class FrmAgregar
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
            comboBoxRest = new ComboBox();
            comboBoxReserva = new ComboBox();
            comboBoxParrilla = new ComboBox();
            comboBoxBar = new ComboBox();
            comboBoxFastFood = new ComboBox();
            lblNombre = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            txtNombre = new TextBox();
            txtCapacidad = new TextBox();
            txtParrilla = new TextBox();
            txtBar = new TextBox();
            txtFastFood = new TextBox();
            btnAceptar = new Button();
            label13 = new Label();
            comboBoxEstado = new ComboBox();
            lblGestiorest = new Label();
            btnCancelar = new Button();
            SuspendLayout();
            // 
            // comboBoxRest
            // 
            comboBoxRest.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxRest.FormattingEnabled = true;
            comboBoxRest.Items.AddRange(new object[] { "Parrilla", "Bar", "FastFood" });
            comboBoxRest.Location = new Point(30, 99);
            comboBoxRest.Name = "comboBoxRest";
            comboBoxRest.Size = new Size(121, 23);
            comboBoxRest.TabIndex = 0;
            comboBoxRest.SelectedIndexChanged += comboBoxRest_SelectedIndexChanged;
            // 
            // comboBoxReserva
            // 
            comboBoxReserva.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxReserva.FormattingEnabled = true;
            comboBoxReserva.Items.AddRange(new object[] { "Si", "No" });
            comboBoxReserva.Location = new Point(30, 316);
            comboBoxReserva.Name = "comboBoxReserva";
            comboBoxReserva.Size = new Size(121, 23);
            comboBoxReserva.TabIndex = 1;
            comboBoxReserva.SelectedIndexChanged += comboBoxReserva_SelectedIndexChanged;
            // 
            // comboBoxParrilla
            // 
            comboBoxParrilla.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxParrilla.FormattingEnabled = true;
            comboBoxParrilla.Items.AddRange(new object[] { "Si", "No" });
            comboBoxParrilla.Location = new Point(259, 158);
            comboBoxParrilla.Name = "comboBoxParrilla";
            comboBoxParrilla.Size = new Size(121, 23);
            comboBoxParrilla.TabIndex = 2;
            comboBoxParrilla.SelectedIndexChanged += comboBoxParrilla_SelectedIndexChanged;
            // 
            // comboBoxBar
            // 
            comboBoxBar.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxBar.FormattingEnabled = true;
            comboBoxBar.Items.AddRange(new object[] { "Si", "No" });
            comboBoxBar.Location = new Point(444, 158);
            comboBoxBar.Name = "comboBoxBar";
            comboBoxBar.Size = new Size(121, 23);
            comboBoxBar.TabIndex = 3;
            comboBoxBar.SelectedIndexChanged += comboBoxBar_SelectedIndexChanged;
            // 
            // comboBoxFastFood
            // 
            comboBoxFastFood.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxFastFood.FormattingEnabled = true;
            comboBoxFastFood.Items.AddRange(new object[] { "Si", "No" });
            comboBoxFastFood.Location = new Point(614, 158);
            comboBoxFastFood.Name = "comboBoxFastFood";
            comboBoxFastFood.Size = new Size(121, 23);
            comboBoxFastFood.TabIndex = 4;
            comboBoxFastFood.SelectedIndexChanged += comboBoxFastFood_SelectedIndexChanged;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(30, 72);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(138, 15);
            lblNombre.TabIndex = 5;
            lblNombre.Text = "Elegir tipo de restaurante";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(259, 107);
            label1.Name = "label1";
            label1.Size = new Size(43, 15);
            label1.TabIndex = 6;
            label1.Text = "Parrilla";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(444, 107);
            label2.Name = "label2";
            label2.Size = new Size(24, 15);
            label2.TabIndex = 7;
            label2.Text = "Bar";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(614, 107);
            label3.Name = "label3";
            label3.Size = new Size(55, 15);
            label3.TabIndex = 8;
            label3.Text = "FastFood";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(30, 149);
            label4.Name = "label4";
            label4.Size = new Size(51, 15);
            label4.TabIndex = 9;
            label4.Text = "Nombre";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(30, 214);
            label5.Name = "label5";
            label5.Size = new Size(66, 15);
            label5.TabIndex = 10;
            label5.Text = "Capacidad:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(30, 286);
            label6.Name = "label6";
            label6.Size = new Size(107, 15);
            label6.TabIndex = 11;
            label6.Text = "Reserva habilitada?";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(259, 131);
            label7.Name = "label7";
            label7.Size = new Size(85, 15);
            label7.TabIndex = 12;
            label7.Text = "Menu vegano?";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(444, 131);
            label8.Name = "label8";
            label8.Size = new Size(75, 15);
            label8.TabIndex = 13;
            label8.Text = "Happy hour?";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(614, 131);
            label9.Name = "label9";
            label9.Size = new Size(92, 15);
            label9.TabIndex = 14;
            label9.Text = "Combo infantil?";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(259, 211);
            label10.Name = "label10";
            label10.Size = new Size(145, 15);
            label10.TabIndex = 15;
            label10.Text = "Cantidad de guarniciones:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(444, 214);
            label11.Name = "label11";
            label11.Size = new Size(110, 15);
            label11.TabIndex = 16;
            label11.Text = "Cantidad de tragos:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(614, 211);
            label12.Name = "label12";
            label12.Size = new Size(120, 15);
            label12.TabIndex = 17;
            label12.Text = "Cantidad de combos:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(30, 176);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(100, 23);
            txtNombre.TabIndex = 18;
            // 
            // txtCapacidad
            // 
            txtCapacidad.Location = new Point(30, 244);
            txtCapacidad.Name = "txtCapacidad";
            txtCapacidad.Size = new Size(51, 23);
            txtCapacidad.TabIndex = 19;
            txtCapacidad.TextChanged += txtCapacidad_TextChanged;
            // 
            // txtParrilla
            // 
            txtParrilla.Location = new Point(259, 244);
            txtParrilla.Name = "txtParrilla";
            txtParrilla.Size = new Size(43, 23);
            txtParrilla.TabIndex = 20;
            txtParrilla.TextChanged += txtParrilla_TextChanged;
            // 
            // txtBar
            // 
            txtBar.Location = new Point(444, 244);
            txtBar.Name = "txtBar";
            txtBar.Size = new Size(39, 23);
            txtBar.TabIndex = 21;
            txtBar.TextChanged += txtBar_TextChanged;
            // 
            // txtFastFood
            // 
            txtFastFood.Location = new Point(614, 244);
            txtFastFood.Name = "txtFastFood";
            txtFastFood.Size = new Size(39, 23);
            txtFastFood.TabIndex = 22;
            txtFastFood.TextChanged += txtCombos_TextChanged;
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(655, 360);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(143, 55);
            btnAceptar.TabIndex = 23;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(30, 360);
            label13.Name = "label13";
            label13.Size = new Size(42, 15);
            label13.TabIndex = 24;
            label13.Text = "Estado";
            // 
            // comboBoxEstado
            // 
            comboBoxEstado.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxEstado.FormattingEnabled = true;
            comboBoxEstado.Items.AddRange(new object[] { "Abierto", "Cerrado", "Lleno" });
            comboBoxEstado.Location = new Point(30, 392);
            comboBoxEstado.Name = "comboBoxEstado";
            comboBoxEstado.Size = new Size(121, 23);
            comboBoxEstado.TabIndex = 25;
            // 
            // lblGestiorest
            // 
            lblGestiorest.AutoSize = true;
            lblGestiorest.Font = new Font("Sitka Small", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblGestiorest.Location = new Point(329, 19);
            lblGestiorest.Name = "lblGestiorest";
            lblGestiorest.Size = new Size(203, 40);
            lblGestiorest.TabIndex = 26;
            lblGestiorest.Text = "GESTIOREST";
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(444, 360);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(143, 55);
            btnCancelar.TabIndex = 27;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // FrmAgregar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.RosyBrown;
            ClientSize = new Size(835, 442);
            Controls.Add(btnCancelar);
            Controls.Add(lblGestiorest);
            Controls.Add(comboBoxEstado);
            Controls.Add(label13);
            Controls.Add(btnAceptar);
            Controls.Add(txtFastFood);
            Controls.Add(txtBar);
            Controls.Add(txtParrilla);
            Controls.Add(txtCapacidad);
            Controls.Add(txtNombre);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lblNombre);
            Controls.Add(comboBoxFastFood);
            Controls.Add(comboBoxBar);
            Controls.Add(comboBoxParrilla);
            Controls.Add(comboBoxReserva);
            Controls.Add(comboBoxRest);
            MaximizeBox = false;
            Name = "FrmAgregar";
            Text = "GESTIOREST";
            Load += FrmAgregar_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBoxRest;
        private ComboBox comboBoxReserva;
        private ComboBox comboBoxParrilla;
        private ComboBox comboBoxBar;
        private ComboBox comboBoxFastFood;
        private Label lblNombre;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private TextBox txtNombre;
        private TextBox txtCapacidad;
        private TextBox txtParrilla;
        private TextBox txtBar;
        private TextBox txtFastFood;
        private Button btnAceptar;
        private Label label13;
        private ComboBox comboBoxEstado;
        private Label lblGestiorest;
        private Button btnCancelar;
    }
}