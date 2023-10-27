namespace FrmLogin
{
    partial class FrmLogin
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
            txtContra = new TextBox();
            txtCorreo = new TextBox();
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            lblError = new Label();
            lblGestiorest = new Label();
            SuspendLayout();
            // 
            // txtContra
            // 
            txtContra.Location = new Point(49, 225);
            txtContra.Name = "txtContra";
            txtContra.PasswordChar = '*';
            txtContra.Size = new Size(150, 23);
            txtContra.TabIndex = 0;
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(49, 122);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(150, 23);
            txtCorreo.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(68, 292);
            button1.Name = "button1";
            button1.Size = new Size(119, 60);
            button1.TabIndex = 2;
            button1.Text = "Ingresar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(49, 104);
            label1.Name = "label1";
            label1.Size = new Size(89, 15);
            label1.TabIndex = 3;
            label1.Text = "Ingresar correo:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(49, 207);
            label2.Name = "label2";
            label2.Size = new Size(113, 15);
            label2.TabIndex = 4;
            label2.Text = "Ingresar contraseña:";
            // 
            // lblError
            // 
            lblError.AutoSize = true;
            lblError.Font = new Font("Segoe MDL2 Assets", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblError.ForeColor = Color.Firebrick;
            lblError.Location = new Point(12, 260);
            lblError.Name = "lblError";
            lblError.Size = new Size(252, 19);
            lblError.TabIndex = 5;
            lblError.Text = "CREDENCIALES INCORRECTAS!!!";
            lblError.Visible = false;
            // 
            // lblGestiorest
            // 
            lblGestiorest.AutoSize = true;
            lblGestiorest.Font = new Font("Sitka Small", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblGestiorest.Location = new Point(39, 19);
            lblGestiorest.Name = "lblGestiorest";
            lblGestiorest.Size = new Size(203, 40);
            lblGestiorest.TabIndex = 27;
            lblGestiorest.Text = "GESTIOREST";
            // 
            // FrmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.RosyBrown;
            ClientSize = new Size(274, 386);
            Controls.Add(lblGestiorest);
            Controls.Add(lblError);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(txtCorreo);
            Controls.Add(txtContra);
            MaximizeBox = false;
            Name = "FrmLogin";
            SizeGripStyle = SizeGripStyle.Hide;
            Text = "GESTIOREST";
            Load += FrmLogin_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtContra;
        private TextBox txtCorreo;
        private Button button1;
        private Label label1;
        private Label label2;
        private Label lblError;
        private Label lblGestiorest;
    }
}