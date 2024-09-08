using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SistemaInformaticoPerinatal
{
    public partial class InicioDeSesion : Form
    {
        public InicioDeSesion()
        {
            InitializeComponent();
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "" && txtContraseña.Text == "")
            {
                MessageBox.Show("BIENVENIDO");
                MenuDeNavegacion ven2 = new MenuDeNavegacion();
                ven2.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("ACCESO DENEGADO");
                txtUsuario.Clear();
                txtContraseña.Clear();

            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
