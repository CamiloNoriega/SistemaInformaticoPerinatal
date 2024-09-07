using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaInformaticoPerinatal
{
    public partial class MenuDeNavegacion : Form
    {
        public MenuDeNavegacion()
        {
            InitializeComponent();
        }

        private void btnHistoriaClinicaP_Click(object sender, EventArgs e)
        {
            HistoriaClinicaPerinatal ven3 = new HistoriaClinicaPerinatal();
            ven3.Show();
            this.Hide();
        }

        private void btnAntecedentes_Click(object sender, EventArgs e)
        {
            Antecedentes ven4 = new Antecedentes();
            ven4.Show();
            this.Hide();
        }

        private void btnEnfermedades_Click(object sender, EventArgs e)
        {
            Enfermedades ven5 = new Enfermedades();
            ven5.Show();
            this.Hide();
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            InicioDeSesion ven3 = new InicioDeSesion();
            ven3.Show();
            this.Hide();
        }
    }
}
