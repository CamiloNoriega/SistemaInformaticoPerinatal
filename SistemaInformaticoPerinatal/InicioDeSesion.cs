

using Negocio;

namespace SistemaInformaticoPerinatal
{
    public partial class InicioDeSesion : Form

    {
        IServicioSeguridad servicioSeguridad = new ServicioSeguridad();
        public InicioDeSesion()
        {
            InitializeComponent();
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            if (servicioSeguridad.ValidarUsuario(new Entidades.Usuario() { Clave = txtContraseña.Text, NombreUsuario = txtUsuario.Text }))
            {
                var form = new MenuDeNavegacion();
                form.Show();
                Hide();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña no válidos");
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
