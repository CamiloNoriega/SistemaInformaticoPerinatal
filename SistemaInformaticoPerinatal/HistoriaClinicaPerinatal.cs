using Entidades;

namespace SistemaInformaticoPerinatal
{
    public partial class HistoriaClinicaPerinatal : Form
    {
        public HistoriaClinicaPerinatal()
        {
            InitializeComponent();
        }

        private void btnContinuar_Click(object sender, EventArgs e)
        {
            var persona = new Paciente()// agregar las demas clases de entidades 
            {
                Nombre = txtNombre.Text,
            };


            //validar listas desplegables
            bool comboBoxSelected = true;
            erpListas.Clear();
            // validar Estado Civil
            if (cmbEstadoCivil.SelectedIndex == -1)
            {
                erpListas.SetError(cmbEstadoCivil, "Seleccione un elemento.");
                comboBoxSelected = false;
            }
            // validar Estudios
            if (cmbEstudios.SelectedIndex == -1)
            {
                erpListas.SetError(cmbEstudios, "Seleccione un elemento.");
                comboBoxSelected = false;
            }
            // validar Etnia
            if (cmbEtnia.SelectedIndex == -1)
            {
                erpListas.SetError(cmbEtnia, "Seleccione un elemento.");
                comboBoxSelected = false;
            }

            //validar botones
            erpBoton.Clear();
            bool radioButtonChecked = true;
            // validar botones para alfabeta

            if (!(rbnAlfabetaNo.Checked || rbnAlfabetaSi.Checked))
            {
                erpBoton.SetError(gbxAlfabeta, "Seleccione una opción.");
                radioButtonChecked = false;
            }
            if (!(rbnViveSolaSi.Checked || rbnViveSolaNo.Checked))
            {
                erpBoton.SetError(gbxViveSola, "Seleccione una opción.");
                radioButtonChecked = false;
            }

            //validar cajas de texto
            bool textBoxcheked = true;
            // Validar TxtAños
            if (string.IsNullOrEmpty(txtAñosCumplidos.Text) || !ValidarSoloNumeros(txtAñosCumplidos, erpTexto))
            {
                erpTexto.SetError(txtAñosCumplidos, "Debe ingresar solo numeros.");
                textBoxcheked = false;
            }

            // Validar txtNombre
            if (string.IsNullOrEmpty(txtNombre.Text) || !ValidarSoloLetras(txtNombre, erpTexto))
            {
                erpTexto.SetError(txtNombre, "Debe ingresar solo caracteres.");
                textBoxcheked = false;
            }
            // Validar txtApellido
            if (string.IsNullOrEmpty(txtApellido.Text) || !ValidarSoloLetras(txtApellido, erpTexto))
            {
                erpTexto.SetError(txtApellido, "Debe ingresar solo caracteres.");
                textBoxcheked = false;
            }
            // Validar TxtTelefono
            if (string.IsNullOrEmpty(txtTelefono.Text) || !ValidarSoloNumeros(txtTelefono, erpTexto))
            {
                erpTexto.SetError(txtTelefono, "Debe ingresar solo numeros.");
                textBoxcheked = false;
            }
            // validar txtLocalidad
            if (string.IsNullOrEmpty(txtLocalidad.Text) || !ValidarSoloLetras(txtLocalidad, erpTexto))
            {
                erpTexto.SetError(txtLocalidad, "Debe ingresar solo caracteres.");
                textBoxcheked = false;
            }
            //valdar txtañosmn
            if (string.IsNullOrEmpty(txtAñoNivelE.Text) || !ValidarSoloNumeros(txtAñoNivelE, erpTexto))
            {
                erpTexto.SetError(txtAñoNivelE, "Debe ingresar solo numeros.");
                textBoxcheked = false;
            }
            //validar txtlugarcontrol
            if (string.IsNullOrEmpty(txtLugarControl.Text) || !ValidarSoloNumeros(txtLugarControl, erpTexto))
            {
                erpTexto.SetError(txtLugarControl, "Debe ingresar solo numeros.");
                textBoxcheked = false;
            }
            //validar txtlugarparto
            if (string.IsNullOrEmpty(txtLugarParto.Text) || !ValidarSoloNumeros(txtLugarParto, erpTexto))
            {
                erpTexto.SetError(txtLugarParto, "Debe ingresar solo numeros.");
                textBoxcheked = false;
            }
            //validar txtnumeroidentidad
            if (string.IsNullOrEmpty(txtNumeroIdentidad.Text) || !ValidarSoloNumeros(txtNumeroIdentidad, erpTexto))
            {
                erpTexto.SetError(txtNumeroIdentidad, "Debe ingresar solo numeros.");
                textBoxcheked = false;
            }
            //validar txtDirección
            if (string.IsNullOrEmpty(txtDireccion.Text))
            {
                erpTexto.SetError(txtDireccion, "Debe diligenciar para continuar");
                textBoxcheked = false;
            }
            // Mostrar mensaje de advertencia para botones y listas
            if (!radioButtonChecked || !comboBoxSelected || !textBoxcheked)
            {
                MessageBox.Show("Corrija los errores antes de continuar, y verifique que todos los campos esten diligenciados");
                return;
            }

            Antecedentes ven3 = new Antecedentes();
            ven3.Show();
            this.Hide();



        }


        //funcion para validar numeros en interacciones
        private bool ValidarSoloNumeros(TextBox textBox, ErrorProvider errorProvider)
        {
            if (string.IsNullOrWhiteSpace(textBox.Text))
            {
                errorProvider.SetError(textBox, "El campo no puede estar vacío");
                return false;
            }
            foreach (char caracter in textBox.Text)
            {
                if (!char.IsDigit(caracter) && caracter != ',')
                {
                    errorProvider.SetError(textBox, "No se admiten letras");
                    return false;
                }
            }

            errorProvider.Clear();
            return true;
        }
        //funcion para validar letras en interacciones
        private bool ValidarSoloLetras(TextBox textBox, ErrorProvider errorProvider)
        {
            if (string.IsNullOrWhiteSpace(textBox.Text))
            {
                errorProvider.SetError(textBox, "El campo no puede estar vacío");
                return false;
            }
            foreach (char caracter in textBox.Text)
            {
                if (char.IsDigit(caracter))
                {
                    errorProvider.SetError(textBox, "No se admiten números");
                    return false;
                }
            }

            errorProvider.Clear();
            return true;
        }

        private void txtApellido_TextChanged(object sender, EventArgs e)
        {
            ValidarSoloLetras(txtApellido, erpTexto);
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            ValidarSoloLetras(txtNombre, erpTexto);
        }

        private void txtTelefono_TextChanged(object sender, EventArgs e)
        {
            ValidarSoloNumeros(txtTelefono, erpTexto);
        }

        private void txtLocalidad_TextChanged(object sender, EventArgs e)
        {
            ValidarSoloLetras(txtLocalidad, erpTexto);
        }

        private void txtAñosCumplidos_TextChanged(object sender, EventArgs e)
        {
            ValidarSoloNumeros(txtAñosCumplidos, erpTexto);
        }

        private void txtAñoNivelE_TextChanged(object sender, EventArgs e)
        {
            ValidarSoloNumeros(txtAñoNivelE, erpTexto);
        }

        private void txtLugarControl_TextChanged(object sender, EventArgs e)
        {
            ValidarSoloNumeros(txtLugarControl, erpTexto);
        }

        private void txtLugarParto_TextChanged(object sender, EventArgs e)
        {
            ValidarSoloNumeros(txtLugarParto, erpTexto);
        }

        private void txtNumeroIdentidad_TextChanged(object sender, EventArgs e)
        {
            ValidarSoloNumeros(txtNumeroIdentidad, erpTexto);
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            MenuDeNavegacion Ven2 = new MenuDeNavegacion();
            Ven2.Show();
            this.Hide();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            InicioDeSesion Ven1 = new InicioDeSesion();
            Ven1.Show();
            this.Hide();
            MessageBox.Show("Su secion ha sido cerrada exitosamente");
        }

    }
}
