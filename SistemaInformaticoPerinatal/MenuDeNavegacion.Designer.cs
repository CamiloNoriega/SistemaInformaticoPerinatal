namespace SistemaInformaticoPerinatal
{
    partial class MenuDeNavegacion
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
            label1 = new Label();
            btnHistoriaClinicaP = new Button();
            bindingSource1 = new BindingSource(components);
            btnAntecedentes = new Button();
            btnEnfermedades = new Button();
            btnCerrarSesion = new Button();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(224, 117);
            label1.Name = "label1";
            label1.Size = new Size(135, 15);
            label1.TabIndex = 0;
            label1.Text = "MENÚ DE NAVEGACION";
            // 
            // btnHistoriaClinicaP
            // 
            btnHistoriaClinicaP.Location = new Point(206, 200);
            btnHistoriaClinicaP.Name = "btnHistoriaClinicaP";
            btnHistoriaClinicaP.Size = new Size(183, 23);
            btnHistoriaClinicaP.TabIndex = 1;
            btnHistoriaClinicaP.Text = "HISTORIA CLINICA PERINATAL";
            btnHistoriaClinicaP.UseVisualStyleBackColor = true;
            btnHistoriaClinicaP.Click += btnHistoriaClinicaP_Click;
            // 
            // btnAntecedentes
            // 
            btnAntecedentes.Location = new Point(236, 260);
            btnAntecedentes.Name = "btnAntecedentes";
            btnAntecedentes.Size = new Size(123, 23);
            btnAntecedentes.TabIndex = 2;
            btnAntecedentes.Text = "ANTECEDENTES";
            btnAntecedentes.UseVisualStyleBackColor = true;
            btnAntecedentes.Click += btnAntecedentes_Click;
            // 
            // btnEnfermedades
            // 
            btnEnfermedades.Location = new Point(236, 320);
            btnEnfermedades.Name = "btnEnfermedades";
            btnEnfermedades.Size = new Size(123, 23);
            btnEnfermedades.TabIndex = 3;
            btnEnfermedades.Text = "ENFERMEDADES";
            btnEnfermedades.UseVisualStyleBackColor = true;
            btnEnfermedades.Click += btnEnfermedades_Click;
            // 
            // btnCerrarSesion
            // 
            btnCerrarSesion.Location = new Point(236, 380);
            btnCerrarSesion.Name = "btnCerrarSesion";
            btnCerrarSesion.Size = new Size(123, 23);
            btnCerrarSesion.TabIndex = 4;
            btnCerrarSesion.Text = "CERRAR SESIÓN";
            btnCerrarSesion.UseVisualStyleBackColor = true;
            btnCerrarSesion.Click += btnCerrarSesion_Click;
            // 
            // MenuDeNavegacion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(584, 424);
            Controls.Add(btnCerrarSesion);
            Controls.Add(btnEnfermedades);
            Controls.Add(btnAntecedentes);
            Controls.Add(btnHistoriaClinicaP);
            Controls.Add(label1);
            Name = "MenuDeNavegacion";
            Text = "MenuDeNavegacion";
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnHistoriaClinicaP;
        private BindingSource bindingSource1;
        private Button btnAntecedentes;
        private Button btnEnfermedades;
        private Button btnCerrarSesion;
    }
}