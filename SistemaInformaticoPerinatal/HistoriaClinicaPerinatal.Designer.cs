namespace SistemaInformaticoPerinatal
{
    partial class HistoriaClinicaPerinatal
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
            components = new System.ComponentModel.Container();
            gbxNombreApellido = new GroupBox();
            txtLocalidad = new TextBox();
            txtApellido = new TextBox();
            txtTelefono = new TextBox();
            txtDireccion = new TextBox();
            lblLocalidad = new Label();
            lblTelefono = new Label();
            lblApellido = new Label();
            lblDireccion = new Label();
            lblNombre = new Label();
            txtNombre = new TextBox();
            gbxFechaEdad = new GroupBox();
            dtpFechaN = new DateTimePicker();
            rbnAños = new RadioButton();
            txtAñosCumplidos = new TextBox();
            lblAñosCumplidos = new Label();
            lblFechaN = new Label();
            gbxEtnia = new GroupBox();
            cmbEtnia = new ComboBox();
            lblEtnia = new Label();
            gbxAlfabeta = new GroupBox();
            rbnAlfabetaSi = new RadioButton();
            rbnAlfabetaNo = new RadioButton();
            lblAlfabeta = new Label();
            gbxEstudios = new GroupBox();
            gbxAñoAlto = new GroupBox();
            txtAñoNivelE = new TextBox();
            lblAñoNivleM = new Label();
            gbxNivelEstudios = new GroupBox();
            cmbEstudios = new ComboBox();
            label2 = new Label();
            gbxEstadoCivil = new GroupBox();
            gbxViveSola = new GroupBox();
            rbnViveSolaSi = new RadioButton();
            rbnViveSolaNo = new RadioButton();
            lblViveSola = new Label();
            cmbEstadoCivil = new ComboBox();
            groupBox7 = new GroupBox();
            txtLugarParto = new TextBox();
            txtNumeroIdentidad = new TextBox();
            txtLugarControl = new TextBox();
            lblNumeroIdentidad = new Label();
            lblLugarParto = new Label();
            lblLugarControl = new Label();
            btnCerrar = new Button();
            btnContinuar = new Button();
            btnRegresar = new Button();
            gbxHistoriaClínicaP = new GroupBox();
            erpBoton = new ErrorProvider(components);
            erpListas = new ErrorProvider(components);
            erpTexto = new ErrorProvider(components);
            gbxNombreApellido.SuspendLayout();
            gbxFechaEdad.SuspendLayout();
            gbxEtnia.SuspendLayout();
            gbxAlfabeta.SuspendLayout();
            gbxEstudios.SuspendLayout();
            gbxAñoAlto.SuspendLayout();
            gbxNivelEstudios.SuspendLayout();
            gbxEstadoCivil.SuspendLayout();
            gbxViveSola.SuspendLayout();
            groupBox7.SuspendLayout();
            gbxHistoriaClínicaP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)erpBoton).BeginInit();
            ((System.ComponentModel.ISupportInitialize)erpListas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)erpTexto).BeginInit();
            SuspendLayout();
            // 
            // gbxNombreApellido
            // 
            gbxNombreApellido.Controls.Add(txtLocalidad);
            gbxNombreApellido.Controls.Add(txtApellido);
            gbxNombreApellido.Controls.Add(txtTelefono);
            gbxNombreApellido.Controls.Add(txtDireccion);
            gbxNombreApellido.Controls.Add(lblLocalidad);
            gbxNombreApellido.Controls.Add(lblTelefono);
            gbxNombreApellido.Controls.Add(lblApellido);
            gbxNombreApellido.Controls.Add(lblDireccion);
            gbxNombreApellido.Controls.Add(lblNombre);
            gbxNombreApellido.Controls.Add(txtNombre);
            gbxNombreApellido.Location = new Point(6, 22);
            gbxNombreApellido.Name = "gbxNombreApellido";
            gbxNombreApellido.Size = new Size(680, 117);
            gbxNombreApellido.TabIndex = 0;
            gbxNombreApellido.TabStop = false;
            gbxNombreApellido.Text = "NOMBRE - APELLIDO";
            // 
            // txtLocalidad
            // 
            txtLocalidad.Location = new Point(575, 81);
            txtLocalidad.Name = "txtLocalidad";
            txtLocalidad.Size = new Size(100, 21);
            txtLocalidad.TabIndex = 9;
            txtLocalidad.TextChanged += txtLocalidad_TextChanged;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(330, 36);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(150, 21);
            txtApellido.TabIndex = 8;
            txtApellido.TextChanged += txtApellido_TextChanged;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(332, 81);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(110, 21);
            txtTelefono.TabIndex = 7;
            txtTelefono.TextChanged += txtTelefono_TextChanged;
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(90, 81);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(144, 21);
            txtDireccion.TabIndex = 6;
            // 
            // lblLocalidad
            // 
            lblLocalidad.AutoSize = true;
            lblLocalidad.Location = new Point(497, 83);
            lblLocalidad.Name = "lblLocalidad";
            lblLocalidad.Size = new Size(64, 14);
            lblLocalidad.TabIndex = 5;
            lblLocalidad.Text = "Localidad";
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.Location = new Point(256, 83);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(57, 14);
            lblTelefono.TabIndex = 4;
            lblTelefono.Text = "Teléfono";
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Location = new Point(256, 38);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(55, 14);
            lblApellido.TabIndex = 3;
            lblApellido.Text = "Apellido";
            // 
            // lblDireccion
            // 
            lblDireccion.AutoSize = true;
            lblDireccion.Location = new Point(17, 83);
            lblDireccion.Name = "lblDireccion";
            lblDireccion.Size = new Size(62, 14);
            lblDireccion.TabIndex = 2;
            lblDireccion.Text = "Direccion";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(17, 38);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(54, 14);
            lblNombre.TabIndex = 1;
            lblNombre.Text = "Nombre";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(79, 36);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(150, 21);
            txtNombre.TabIndex = 0;
            txtNombre.TextChanged += txtNombre_TextChanged;
            // 
            // gbxFechaEdad
            // 
            gbxFechaEdad.Controls.Add(dtpFechaN);
            gbxFechaEdad.Controls.Add(rbnAños);
            gbxFechaEdad.Controls.Add(txtAñosCumplidos);
            gbxFechaEdad.Controls.Add(lblAñosCumplidos);
            gbxFechaEdad.Controls.Add(lblFechaN);
            gbxFechaEdad.Location = new Point(6, 145);
            gbxFechaEdad.Name = "gbxFechaEdad";
            gbxFechaEdad.Size = new Size(680, 81);
            gbxFechaEdad.TabIndex = 1;
            gbxFechaEdad.TabStop = false;
            gbxFechaEdad.Text = "FECHA N. - EDAD";
            // 
            // dtpFechaN
            // 
            dtpFechaN.Format = DateTimePickerFormat.Short;
            dtpFechaN.Location = new Point(161, 38);
            dtpFechaN.Name = "dtpFechaN";
            dtpFechaN.Size = new Size(107, 21);
            dtpFechaN.TabIndex = 10;
            // 
            // rbnAños
            // 
            rbnAños.AutoSize = true;
            rbnAños.Location = new Point(618, 28);
            rbnAños.Name = "rbnAños";
            rbnAños.Size = new Size(46, 32);
            rbnAños.TabIndex = 9;
            rbnAños.TabStop = true;
            rbnAños.Text = ">35\r\n<15";
            rbnAños.UseVisualStyleBackColor = true;
            // 
            // txtAñosCumplidos
            // 
            txtAñosCumplidos.Location = new Point(542, 36);
            txtAñosCumplidos.MaxLength = 2;
            txtAñosCumplidos.Name = "txtAñosCumplidos";
            txtAñosCumplidos.Size = new Size(51, 21);
            txtAñosCumplidos.TabIndex = 8;
            txtAñosCumplidos.TextChanged += txtAñosCumplidos_TextChanged;
            // 
            // lblAñosCumplidos
            // 
            lblAñosCumplidos.AutoSize = true;
            lblAñosCumplidos.Location = new Point(330, 38);
            lblAñosCumplidos.Name = "lblAñosCumplidos";
            lblAñosCumplidos.Size = new Size(195, 14);
            lblAñosCumplidos.TabIndex = 3;
            lblAñosCumplidos.Text = "¿Cuantos años cumplidos tiene?";
            // 
            // lblFechaN
            // 
            lblFechaN.AutoSize = true;
            lblFechaN.Location = new Point(17, 38);
            lblFechaN.Name = "lblFechaN";
            lblFechaN.Size = new Size(128, 14);
            lblFechaN.TabIndex = 1;
            lblFechaN.Text = "Fecha de Nacimiento";
            // 
            // gbxEtnia
            // 
            gbxEtnia.Controls.Add(cmbEtnia);
            gbxEtnia.Controls.Add(lblEtnia);
            gbxEtnia.Location = new Point(6, 241);
            gbxEtnia.Name = "gbxEtnia";
            gbxEtnia.Size = new Size(310, 71);
            gbxEtnia.TabIndex = 2;
            gbxEtnia.TabStop = false;
            gbxEtnia.Text = "ETNIA";
            // 
            // cmbEtnia
            // 
            cmbEtnia.FormattingEnabled = true;
            cmbEtnia.Items.AddRange(new object[] { "Blanca", "Negra", "Indigena", "Mestiza", "Otros" });
            cmbEtnia.Location = new Point(166, 31);
            cmbEtnia.Name = "cmbEtnia";
            cmbEtnia.Size = new Size(121, 22);
            cmbEtnia.TabIndex = 2;
            // 
            // lblEtnia
            // 
            lblEtnia.AutoSize = true;
            lblEtnia.Location = new Point(17, 33);
            lblEtnia.Name = "lblEtnia";
            lblEtnia.Size = new Size(133, 14);
            lblEtnia.TabIndex = 1;
            lblEtnia.Text = "¿Como se considera?";
            // 
            // gbxAlfabeta
            // 
            gbxAlfabeta.Controls.Add(rbnAlfabetaSi);
            gbxAlfabeta.Controls.Add(rbnAlfabetaNo);
            gbxAlfabeta.Controls.Add(lblAlfabeta);
            gbxAlfabeta.Location = new Point(363, 241);
            gbxAlfabeta.Name = "gbxAlfabeta";
            gbxAlfabeta.Size = new Size(310, 71);
            gbxAlfabeta.TabIndex = 3;
            gbxAlfabeta.TabStop = false;
            gbxAlfabeta.Text = "ALFABETA";
            // 
            // rbnAlfabetaSi
            // 
            rbnAlfabetaSi.AutoSize = true;
            rbnAlfabetaSi.Location = new Point(151, 31);
            rbnAlfabetaSi.Name = "rbnAlfabetaSi";
            rbnAlfabetaSi.Size = new Size(36, 18);
            rbnAlfabetaSi.TabIndex = 11;
            rbnAlfabetaSi.TabStop = true;
            rbnAlfabetaSi.Text = "Si";
            rbnAlfabetaSi.UseVisualStyleBackColor = true;
            // 
            // rbnAlfabetaNo
            // 
            rbnAlfabetaNo.AutoSize = true;
            rbnAlfabetaNo.Location = new Point(203, 30);
            rbnAlfabetaNo.Name = "rbnAlfabetaNo";
            rbnAlfabetaNo.Size = new Size(41, 18);
            rbnAlfabetaNo.TabIndex = 10;
            rbnAlfabetaNo.TabStop = true;
            rbnAlfabetaNo.Text = "No";
            rbnAlfabetaNo.UseVisualStyleBackColor = true;
            // 
            // lblAlfabeta
            // 
            lblAlfabeta.AutoSize = true;
            lblAlfabeta.Location = new Point(7, 33);
            lblAlfabeta.Name = "lblAlfabeta";
            lblAlfabeta.Size = new Size(134, 14);
            lblAlfabeta.TabIndex = 1;
            lblAlfabeta.Text = "¿Sabe leer y escribir?";
            // 
            // gbxEstudios
            // 
            gbxEstudios.Controls.Add(gbxAñoAlto);
            gbxEstudios.Controls.Add(gbxNivelEstudios);
            gbxEstudios.Location = new Point(6, 318);
            gbxEstudios.Name = "gbxEstudios";
            gbxEstudios.Size = new Size(680, 117);
            gbxEstudios.TabIndex = 4;
            gbxEstudios.TabStop = false;
            gbxEstudios.Text = "ESTUDIOS";
            // 
            // gbxAñoAlto
            // 
            gbxAñoAlto.Controls.Add(txtAñoNivelE);
            gbxAñoAlto.Controls.Add(lblAñoNivleM);
            gbxAñoAlto.Location = new Point(354, 22);
            gbxAñoAlto.Name = "gbxAñoAlto";
            gbxAñoAlto.Size = new Size(293, 71);
            gbxAñoAlto.TabIndex = 4;
            gbxAñoAlto.TabStop = false;
            // 
            // txtAñoNivelE
            // 
            txtAñoNivelE.Location = new Point(156, 42);
            txtAñoNivelE.MaxLength = 2;
            txtAñoNivelE.Name = "txtAñoNivelE";
            txtAñoNivelE.Size = new Size(62, 21);
            txtAñoNivelE.TabIndex = 9;
            txtAñoNivelE.TextChanged += txtAñoNivelE_TextChanged;
            // 
            // lblAñoNivleM
            // 
            lblAñoNivleM.AutoSize = true;
            lblAñoNivleM.Location = new Point(25, 19);
            lblAñoNivleM.Name = "lblAñoNivleM";
            lblAñoNivleM.Size = new Size(237, 28);
            lblAñoNivleM.TabIndex = 1;
            lblAñoNivleM.Text = "¿Cuál fue el año más alto que aprobó en\r\nese nivel?\r\n";
            // 
            // gbxNivelEstudios
            // 
            gbxNivelEstudios.Controls.Add(cmbEstudios);
            gbxNivelEstudios.Controls.Add(label2);
            gbxNivelEstudios.Location = new Point(17, 22);
            gbxNivelEstudios.Name = "gbxNivelEstudios";
            gbxNivelEstudios.Size = new Size(272, 71);
            gbxNivelEstudios.TabIndex = 3;
            gbxNivelEstudios.TabStop = false;
            // 
            // cmbEstudios
            // 
            cmbEstudios.FormattingEnabled = true;
            cmbEstudios.Items.AddRange(new object[] { "Primaria", "Secundaria", "Universidad", "Ninguno" });
            cmbEstudios.Location = new Point(131, 42);
            cmbEstudios.Name = "cmbEstudios";
            cmbEstudios.Size = new Size(121, 22);
            cmbEstudios.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(25, 19);
            label2.Name = "label2";
            label2.Size = new Size(227, 28);
            label2.TabIndex = 1;
            label2.Text = "¿Cuál fue el nivel de estudios más alto\r\nal que asistió?";
            // 
            // gbxEstadoCivil
            // 
            gbxEstadoCivil.Controls.Add(gbxViveSola);
            gbxEstadoCivil.Controls.Add(cmbEstadoCivil);
            gbxEstadoCivil.Location = new Point(6, 441);
            gbxEstadoCivil.Name = "gbxEstadoCivil";
            gbxEstadoCivil.Size = new Size(431, 68);
            gbxEstadoCivil.TabIndex = 5;
            gbxEstadoCivil.TabStop = false;
            gbxEstadoCivil.Text = "ESTADO CIVIL";
            // 
            // gbxViveSola
            // 
            gbxViveSola.Controls.Add(rbnViveSolaSi);
            gbxViveSola.Controls.Add(rbnViveSolaNo);
            gbxViveSola.Controls.Add(lblViveSola);
            gbxViveSola.Location = new Point(192, 12);
            gbxViveSola.Name = "gbxViveSola";
            gbxViveSola.Size = new Size(200, 43);
            gbxViveSola.TabIndex = 6;
            gbxViveSola.TabStop = false;
            // 
            // rbnViveSolaSi
            // 
            rbnViveSolaSi.AutoSize = true;
            rbnViveSolaSi.Location = new Point(98, 19);
            rbnViveSolaSi.Name = "rbnViveSolaSi";
            rbnViveSolaSi.Size = new Size(36, 18);
            rbnViveSolaSi.TabIndex = 13;
            rbnViveSolaSi.TabStop = true;
            rbnViveSolaSi.Text = "Si";
            rbnViveSolaSi.UseVisualStyleBackColor = true;
            // 
            // rbnViveSolaNo
            // 
            rbnViveSolaNo.AutoSize = true;
            rbnViveSolaNo.Location = new Point(140, 19);
            rbnViveSolaNo.Name = "rbnViveSolaNo";
            rbnViveSolaNo.Size = new Size(41, 18);
            rbnViveSolaNo.TabIndex = 12;
            rbnViveSolaNo.TabStop = true;
            rbnViveSolaNo.Text = "No";
            rbnViveSolaNo.UseVisualStyleBackColor = true;
            // 
            // lblViveSola
            // 
            lblViveSola.AutoSize = true;
            lblViveSola.Location = new Point(24, 20);
            lblViveSola.Name = "lblViveSola";
            lblViveSola.Size = new Size(73, 14);
            lblViveSola.TabIndex = 1;
            lblViveSola.Text = "¿Vive sola?";
            // 
            // cmbEstadoCivil
            // 
            cmbEstadoCivil.FormattingEnabled = true;
            cmbEstadoCivil.Items.AddRange(new object[] { "Soltera", "Casada", "Union Libre", "Otro" });
            cmbEstadoCivil.Location = new Point(14, 29);
            cmbEstadoCivil.Name = "cmbEstadoCivil";
            cmbEstadoCivil.Size = new Size(121, 22);
            cmbEstadoCivil.TabIndex = 2;
            // 
            // groupBox7
            // 
            groupBox7.Controls.Add(txtLugarParto);
            groupBox7.Controls.Add(txtNumeroIdentidad);
            groupBox7.Controls.Add(txtLugarControl);
            groupBox7.Controls.Add(lblNumeroIdentidad);
            groupBox7.Controls.Add(lblLugarParto);
            groupBox7.Controls.Add(lblLugarControl);
            groupBox7.Location = new Point(6, 515);
            groupBox7.Name = "groupBox7";
            groupBox7.Size = new Size(576, 89);
            groupBox7.TabIndex = 6;
            groupBox7.TabStop = false;
            // 
            // txtLugarParto
            // 
            txtLugarParto.Location = new Point(224, 39);
            txtLugarParto.Name = "txtLugarParto";
            txtLugarParto.Size = new Size(144, 21);
            txtLugarParto.TabIndex = 8;
            txtLugarParto.TextChanged += txtLugarParto_TextChanged;
            // 
            // txtNumeroIdentidad
            // 
            txtNumeroIdentidad.Location = new Point(400, 39);
            txtNumeroIdentidad.Name = "txtNumeroIdentidad";
            txtNumeroIdentidad.Size = new Size(144, 21);
            txtNumeroIdentidad.TabIndex = 7;
            txtNumeroIdentidad.TextChanged += txtNumeroIdentidad_TextChanged;
            // 
            // txtLugarControl
            // 
            txtLugarControl.Location = new Point(32, 39);
            txtLugarControl.Name = "txtLugarControl";
            txtLugarControl.Size = new Size(144, 21);
            txtLugarControl.TabIndex = 6;
            txtLugarControl.TextChanged += txtLugarControl_TextChanged;
            // 
            // lblNumeroIdentidad
            // 
            lblNumeroIdentidad.AutoSize = true;
            lblNumeroIdentidad.Location = new Point(403, 21);
            lblNumeroIdentidad.Name = "lblNumeroIdentidad";
            lblNumeroIdentidad.Size = new Size(157, 14);
            lblNumeroIdentidad.TabIndex = 5;
            lblNumeroIdentidad.Text = "NUMERO DE IDENTIDAD ";
            // 
            // lblLugarParto
            // 
            lblLugarParto.AutoSize = true;
            lblLugarParto.Location = new Point(220, 21);
            lblLugarParto.Name = "lblLugarParto";
            lblLugarParto.Size = new Size(183, 14);
            lblLugarParto.TabIndex = 4;
            lblLugarParto.Text = "LUGAR DEL PARTO/ABORTO";
            // 
            // lblLugarControl
            // 
            lblLugarControl.AutoSize = true;
            lblLugarControl.Location = new Point(16, 21);
            lblLugarControl.Name = "lblLugarControl";
            lblLugarControl.Size = new Size(206, 14);
            lblLugarControl.TabIndex = 2;
            lblLugarControl.Text = "LUGAR DE CONTROL PRENATAL";
            // 
            // btnCerrar
            // 
            btnCerrar.Location = new Point(45, 633);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(142, 23);
            btnCerrar.TabIndex = 7;
            btnCerrar.Text = "CERRAR SESIÓN";
            btnCerrar.UseVisualStyleBackColor = true;
            // 
            // btnContinuar
            // 
            btnContinuar.Location = new Point(508, 633);
            btnContinuar.Name = "btnContinuar";
            btnContinuar.Size = new Size(110, 23);
            btnContinuar.TabIndex = 8;
            btnContinuar.Text = "CONTINUAR";
            btnContinuar.UseVisualStyleBackColor = true;
            btnContinuar.Click += btnContinuar_Click;
            // 
            // btnRegresar
            // 
            btnRegresar.Location = new Point(274, 633);
            btnRegresar.Name = "btnRegresar";
            btnRegresar.Size = new Size(147, 23);
            btnRegresar.TabIndex = 9;
            btnRegresar.Text = "REGRESAR AL MENU";
            btnRegresar.UseVisualStyleBackColor = true;
            // 
            // gbxHistoriaClínicaP
            // 
            gbxHistoriaClínicaP.BackColor = SystemColors.GradientInactiveCaption;
            gbxHistoriaClínicaP.Controls.Add(gbxNombreApellido);
            gbxHistoriaClínicaP.Controls.Add(gbxFechaEdad);
            gbxHistoriaClínicaP.Controls.Add(gbxEtnia);
            gbxHistoriaClínicaP.Controls.Add(gbxAlfabeta);
            gbxHistoriaClínicaP.Controls.Add(groupBox7);
            gbxHistoriaClínicaP.Controls.Add(gbxEstudios);
            gbxHistoriaClínicaP.Controls.Add(gbxEstadoCivil);
            gbxHistoriaClínicaP.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            gbxHistoriaClínicaP.Location = new Point(12, 12);
            gbxHistoriaClínicaP.Name = "gbxHistoriaClínicaP";
            gbxHistoriaClínicaP.Size = new Size(707, 610);
            gbxHistoriaClínicaP.TabIndex = 10;
            gbxHistoriaClínicaP.TabStop = false;
            gbxHistoriaClínicaP.Text = "HISTORIA CLINICA PERINATAL";
            // 
            // erpBoton
            // 
            erpBoton.ContainerControl = this;
            // 
            // erpListas
            // 
            erpListas.ContainerControl = this;
            // 
            // erpTexto
            // 
            erpTexto.ContainerControl = this;
            // 
            // HistoriaClinicaPerinatal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(731, 669);
            Controls.Add(gbxHistoriaClínicaP);
            Controls.Add(btnRegresar);
            Controls.Add(btnContinuar);
            Controls.Add(btnCerrar);
            Name = "HistoriaClinicaPerinatal";
            Text = "HistoriaClinicaPerinatal";
            gbxNombreApellido.ResumeLayout(false);
            gbxNombreApellido.PerformLayout();
            gbxFechaEdad.ResumeLayout(false);
            gbxFechaEdad.PerformLayout();
            gbxEtnia.ResumeLayout(false);
            gbxEtnia.PerformLayout();
            gbxAlfabeta.ResumeLayout(false);
            gbxAlfabeta.PerformLayout();
            gbxEstudios.ResumeLayout(false);
            gbxAñoAlto.ResumeLayout(false);
            gbxAñoAlto.PerformLayout();
            gbxNivelEstudios.ResumeLayout(false);
            gbxNivelEstudios.PerformLayout();
            gbxEstadoCivil.ResumeLayout(false);
            gbxViveSola.ResumeLayout(false);
            gbxViveSola.PerformLayout();
            groupBox7.ResumeLayout(false);
            groupBox7.PerformLayout();
            gbxHistoriaClínicaP.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)erpBoton).EndInit();
            ((System.ComponentModel.ISupportInitialize)erpListas).EndInit();
            ((System.ComponentModel.ISupportInitialize)erpTexto).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gbxNombreApellido;
        private TextBox txtLocalidad;
        private TextBox txtApellido;
        private TextBox txtTelefono;
        private TextBox txtDireccion;
        private Label lblLocalidad;
        private Label lblTelefono;
        private Label lblApellido;
        private Label lblDireccion;
        private Label lblNombre;
        private TextBox txtNombre;
        private GroupBox gbxFechaEdad;
        private DateTimePicker dtpFechaN;
        private RadioButton rbnAños;
        private TextBox txtAñosCumplidos;
        private Label lblAñosCumplidos;
        private Label lblFechaN;
        private GroupBox gbxEtnia;
        private Label lblEtnia;
        private ComboBox cmbEtnia;
        private GroupBox gbxAlfabeta;
        private RadioButton rbnAlfabetaSi;
        private RadioButton rbnAlfabetaNo;
        private Label lblAlfabeta;
        private GroupBox gbxEstudios;
        private GroupBox gbxAñoAlto;
        private ComboBox comboBox2;
        private Label lblAñoNivleM;
        private GroupBox gbxNivelEstudios;
        private ComboBox cmbEstudios;
        private Label label2;
        private GroupBox gbxEstadoCivil;
        private GroupBox gbxViveSola;
        private RadioButton rbnViveSolaSi;
        private RadioButton rbnViveSolaNo;
        private Label lblViveSola;
        private ComboBox cmbEstadoCivil;
        private GroupBox groupBox7;
        private TextBox txtLugarParto;
        private TextBox txtNumeroIdentidad;
        private TextBox txtLugarControl;
        private Label lblNumeroIdentidad;
        private Label lblLugarParto;
        private Label lblLugarControl;
        private Button btnCerrar;
        private Button btnContinuar;
        private Button btnRegresar;
        private TextBox txtAñoNivelE;
        private GroupBox gbxHistoriaClínicaP;
        private ErrorProvider erpBoton;
        private ErrorProvider erpListas;
        private ErrorProvider erpTexto;
    }
}