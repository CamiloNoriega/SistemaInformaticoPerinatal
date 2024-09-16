namespace SistemaInformaticoPerinatal
{
    partial class InicioDeSesion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InicioDeSesion));
            btnIniciar = new Button();
            lblUsuario = new Label();
            txtUsuario = new TextBox();
            txtContraseña = new TextBox();
            btnSalir = new Button();
            lblContraseña = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnIniciar
            // 
            btnIniciar.BackColor = Color.LightSkyBlue;
            btnIniciar.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnIniciar.ForeColor = SystemColors.ControlLightLight;
            btnIniciar.Location = new Point(267, 506);
            btnIniciar.Margin = new Padding(4, 5, 4, 5);
            btnIniciar.Name = "btnIniciar";
            btnIniciar.Size = new Size(107, 38);
            btnIniciar.TabIndex = 0;
            btnIniciar.Text = "INICIAR";
            btnIniciar.UseVisualStyleBackColor = false;
            btnIniciar.Click += btnIniciar_Click;
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Font = new Font("Arial Rounded MT Bold", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUsuario.ForeColor = Color.SteelBlue;
            lblUsuario.Location = new Point(113, 314);
            lblUsuario.Margin = new Padding(4, 0, 4, 0);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(103, 23);
            lblUsuario.TabIndex = 1;
            lblUsuario.Text = "USUARIO";
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(267, 306);
            txtUsuario.Margin = new Padding(4, 5, 4, 5);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(141, 31);
            txtUsuario.TabIndex = 2;
            // 
            // txtContraseña
            // 
            txtContraseña.Location = new Point(267, 372);
            txtContraseña.Margin = new Padding(4, 5, 4, 5);
            txtContraseña.Name = "txtContraseña";
            txtContraseña.PasswordChar = '♦';
            txtContraseña.Size = new Size(141, 31);
            txtContraseña.TabIndex = 3;
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.LightSkyBlue;
            btnSalir.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSalir.ForeColor = SystemColors.ControlLightLight;
            btnSalir.Location = new Point(114, 506);
            btnSalir.Margin = new Padding(4, 5, 4, 5);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(107, 38);
            btnSalir.TabIndex = 4;
            btnSalir.Text = "SALIR";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // lblContraseña
            // 
            lblContraseña.AutoSize = true;
            lblContraseña.Font = new Font("Arial Rounded MT Bold", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblContraseña.ForeColor = Color.SteelBlue;
            lblContraseña.Location = new Point(69, 376);
            lblContraseña.Margin = new Padding(4, 0, 4, 0);
            lblContraseña.Name = "lblContraseña";
            lblContraseña.Size = new Size(152, 23);
            lblContraseña.TabIndex = 5;
            lblContraseña.Text = "CONTRASEÑA";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(69, 60);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(406, 192);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // InicioDeSesion
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(556, 645);
            Controls.Add(pictureBox1);
            Controls.Add(lblContraseña);
            Controls.Add(btnSalir);
            Controls.Add(txtContraseña);
            Controls.Add(txtUsuario);
            Controls.Add(lblUsuario);
            Controls.Add(btnIniciar);
            Margin = new Padding(4, 5, 4, 5);
            Name = "InicioDeSesion";
            Text = "InicioDeSesion";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnIniciar;
        private Label lblUsuario;
        private TextBox txtUsuario;
        private TextBox txtContraseña;
        private Button btnSalir;
        private Label lblContraseña;
        private PictureBox pictureBox1;
    }
}