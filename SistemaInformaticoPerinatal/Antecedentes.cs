using Microsoft.Win32;
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
    public partial class Antecedentes : Form
    {
        public Antecedentes()
        {
            InitializeComponent();
        }

        private void btnContinuar_Click(object sender, EventArgs e)
        {
            bool radioButtonChecked = true;

            // Limpiar cualquier mensaje de error previo
            erpBoton.Clear();

            // Validar cada grupo de RadioButtons y establecer mensajes de error si no están seleccionados
            if (!(rbnFTBCNo.Checked || rbnFTBCSi.Checked))
            {
                erpBoton.SetError(gbxFamiliaresTBC, "Seleccione una opción.");
                radioButtonChecked = false;
            }
            if (!(rbnFDiabetesNo.Checked || rbnFDiabetesSi.Checked))
            {
                erpBoton.SetError(gbxFamiliaresDiabetes, "Seleccione una opción.");
                radioButtonChecked = false;
            }
            if (!(rbnFHipertensionNo.Checked || rbnFHipertensionSi.Checked))
            {
                erpBoton.SetError(gbxFamiliaresHipertension, "Seleccione una opción.");
                radioButtonChecked = false;
            }
            if (!(rbnFPreeclampsiaNo.Checked || rbnFPreeclampsiaSi.Checked))
            {
                erpBoton.SetError(gbxFamiliaresPreeclampsia, "Seleccione una opción.");
                radioButtonChecked = false;
            }
            if (!(rbnFEclampsiaNo.Checked || rbnFEclampsiaSi.Checked))
            {
                erpBoton.SetError(gbxFamiliaresEclampsia, "Seleccione una opción.");
                radioButtonChecked = false;
            }
            if (!(rbnFOCMGraveNo.Checked || rbnFOCMGraveSi.Checked))
            {
                erpBoton.SetError(gbxFamiliaresOCMGrave, "Seleccione una opción.");
                radioButtonChecked = false;
            }
            if (!(rbnPTBCNo.Checked || rbnPTBCSi.Checked))
            {
                erpBoton.SetError(gbxPersonalesTBC, "Seleccione una opción.");
                radioButtonChecked = false;
            }
            if (!(rbnPDiabetesNo.Checked || rbnPDiabetesI.Checked || rbnPDiabetesII.Checked || rbnPDiabetesG.Checked))
            {
                erpBoton.SetError(gbxPersonalesDiabetes, "Seleccione una opción.");
                radioButtonChecked = false;
            }
            if (!(rbnPHipertensionNo.Checked || rbnPHipertensionSi.Checked))
            {
                erpBoton.SetError(gbxPersonalesHipertension, "Seleccione una opción.");
                radioButtonChecked = false;
            }
            if (!(rbnPPreeclampsiaNo.Checked || rbnPPreeclampsiaSi.Checked))
            {
                erpBoton.SetError(gbxPersonalesPreeclampsia, "Seleccione una opción.");
                radioButtonChecked = false;
            }
            if (!(rbnPOCMGraveNo.Checked || rbnPOCMGraveSi.Checked))
            {
                erpBoton.SetError(gbxPersonalesOCMGrave, "Seleccione una opción.");
                radioButtonChecked = false;
            }
            if (!(rbnPEclampsiaNo.Checked || rbnPEclampsiaSi.Checked))
            {
                erpBoton.SetError(gbxPersonalesEclampsia, "Seleccione una opción.");
                radioButtonChecked = false;
            }
            if (!(rbnCirugiaGUNo.Checked || rbnCirugiaGUSi.Checked))
            {
                erpBoton.SetError(gbxObstetricosCGUrinaria, "Seleccione una opción.");
                radioButtonChecked = false;
            }
            if (!(rbnInfertilidadNo.Checked || rbnInfertilidadSi.Checked))
            {
                erpBoton.SetError(gbxObstetricosInfertilidad, "Seleccione una opción.");
                radioButtonChecked = false;
            }
            if (!(rbnCardiopatiaNo.Checked || rbnCardiopatiaSi.Checked))
            {
                erpBoton.SetError(gbxObstetricosCardiopatia, "Seleccione una opción.");
                radioButtonChecked = false;
            }
            if (!(rbnNefropatiaNo.Checked || rbnNefropatiaSi.Checked))
            {
                erpBoton.SetError(gbxObstetricosNefropatia, "Seleccione una opción.");
                radioButtonChecked = false;
            }
            if (!(rbnViolenciaNo.Checked || rbnViolenciaSi.Checked))
            {
                erpBoton.SetError(gbxObstetricosViolencia, "Seleccione una opción.");
                radioButtonChecked = false;
            }
            if (!(rbnVIHNo.Checked || rbnVIHSi.Checked))
            {
                erpBoton.SetError(gbxObstetricosVIH, "Seleccione una opción.");
                radioButtonChecked = false;
            }
            if (!(rbnGemelaresSi.Checked || rbnGemelaresNo.Checked))
            {
                erpBoton.SetError(gbxAntecedentesGemelares, "Seleccione una opción.");
                radioButtonChecked = false;
            }
            if (!(rbnPesoNc.Checked || rbnPeso4000.Checked || rbnPesoM2500.Checked || rbnPesoNormal.Checked))
            {
                erpBoton.SetError(gbxPesoNacido, "Seleccione una opción.");
                radioButtonChecked = false;
            }
            if (!(rbnEmbarazoPlaneadoSi.Checked || rbnEmbarazoPlaneadoNo.Checked))
            {
                erpBoton.SetError(gbxEmbarazoPlaneado, "Seleccione una opción.");
                radioButtonChecked = false;
            }



#pragma warning disable CS0219 // La variable está asignada pero nunca se usa su valor
            bool comboBoxSelected = true;
#pragma warning restore CS0219 // La variable está asignada pero nunca se usa su valor
            erpListas.Clear();
            if (cmbFMetodoAnticonseptivo.SelectedIndex == -1)
            {
                erpListas.SetError(cmbFMetodoAnticonseptivo, "Seleccione un elemento.");
                comboBoxSelected = false;
            }




            bool TextBoxcheked = true;
            //validar abortos
            if (string.IsNullOrEmpty(txtAbortos.Text) || !ValidarSoloNumeros(txtAbortos, erpNumeros))
            {
                erpNumeros.SetError(txtAbortos, "debe ingresar solo numeros");
                TextBoxcheked = false;

            }
            // validar gestas previas
            if (string.IsNullOrEmpty(txtGestasPrevias.Text) || !ValidarSoloNumeros(txtGestasPrevias, erpNumeros))
            {
                erpNumeros.SetError(txtGestasPrevias, "debe ingresar solo numeros"); ;
                TextBoxcheked = false;

            }
            // validar embarazo etopico
            if (string.IsNullOrEmpty(txtEmbEtopico.Text) || !ValidarSoloNumeros(txtEmbEtopico, erpNumeros))
            {
                erpNumeros.SetError(txtEmbEtopico, "debe ingresar solo numeros");
                TextBoxcheked = false;

            }
            // validar partos
            if (string.IsNullOrEmpty(txtNumeroPartos.Text) || !ValidarSoloNumeros(txtNumeroPartos, erpNumeros))
            {
                erpNumeros.SetError(txtNumeroPartos, "debe ingresar solo numeros");
                TextBoxcheked = false;

            }
            // validar vaginales
            if (string.IsNullOrEmpty(txtVaginales.Text) || !ValidarSoloNumeros(txtVaginales, erpNumeros))
            {
                erpNumeros.SetError(txtVaginales, "debe ingresar solo numeros");
                TextBoxcheked = false;

            }
            //validar cesareas
            if (string.IsNullOrEmpty(txtCesarea.Text) || !ValidarSoloNumeros(txtCesarea, erpNumeros))
            {
                erpNumeros.SetError(txtCesarea, "debe ingresar solo numeros");
                TextBoxcheked = false;

            }
            //validar nacidos vivos 
            if (string.IsNullOrEmpty(txtNacidosVivos.Text) || !ValidarSoloNumeros(txtNacidosVivos, erpNumeros))
            {
                erpNumeros.SetError(txtNacidosVivos, "debe ingresar solo numeros");
                TextBoxcheked = false;

            }
            //validar muertos 1sem
            if (string.IsNullOrEmpty(txtNacidosMuertos.Text) || !ValidarSoloNumeros(txtNacidosMuertos, erpNumeros))
            {
                erpNumeros.SetError(txtNacidosMuertos, "debe ingresar solo numeros");
                TextBoxcheked = false;

            }
            //validar nacidos muertos
            if (string.IsNullOrEmpty(txtMuertesPrimeraSemana.Text) || !ValidarSoloNumeros(txtMuertesPrimeraSemana, erpNumeros))
            {
                erpNumeros.SetError(txtMuertesPrimeraSemana, "debe ingresar solo numeros");
                TextBoxcheked = false;

            }

            //validar viven 
            if (string.IsNullOrEmpty(txtViven.Text) || !ValidarSoloNumeros(txtViven, erpNumeros))
            {
                erpNumeros.SetError(txtViven, "debe ingresar solo numeros");
                TextBoxcheked = false;

            }

            // Mostrar mensaje de advertencia si algún grupo no está seleccionado
            if (!radioButtonChecked || !TextBoxcheked)
            {
                MessageBox.Show("Corrija los errores antes de continuar, y verifique que todos los campos esten diligenciados");
                return;
            }



            Enfermedades ven4 = new Enfermedades();
            ven4.Show();
            this.Hide();
        }

        //funcion para validadr en interacciones
        private bool ValidarSoloNumeros(TextBox textBox, ErrorProvider errorProvider)
        {
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

        private void txtGestasPrevias_TextChanged(object sender, EventArgs e)
        {
            ValidarSoloNumeros(txtGestasPrevias, erpNumeros);
        }

        private void txtNacidosVivos_TextChanged(object sender, EventArgs e)
        {
            ValidarSoloNumeros(txtNacidosVivos, erpNumeros);
        }

        private void txtViven_TextChanged(object sender, EventArgs e)
        {
            ValidarSoloNumeros(txtViven, erpNumeros);
        }

        private void txtNacidosMuertos_TextChanged(object sender, EventArgs e)
        {
            ValidarSoloNumeros(txtNacidosMuertos, erpNumeros);
        }

        private void txtMuertesPrimeraSemana_TextChanged(object sender, EventArgs e)
        {
            ValidarSoloNumeros(txtMuertesPrimeraSemana, erpNumeros);
        }

        private void txtEmbEtopico_TextChanged(object sender, EventArgs e)
        {
            ValidarSoloNumeros(txtEmbEtopico, erpNumeros);
        }

        private void txtNumeroPartos_TextChanged(object sender, EventArgs e)
        {
            ValidarSoloNumeros(txtNumeroPartos, erpNumeros);
        }

        private void txtVaginales_TextChanged(object sender, EventArgs e)
        {
            ValidarSoloNumeros(txtVaginales, erpNumeros);
        }

        private void txtCesarea_TextChanged(object sender, EventArgs e)
        {
            ValidarSoloNumeros(txtCesarea, erpNumeros);
        }

        private void txtAbortos_TextChanged(object sender, EventArgs e)
        {
            ValidarSoloNumeros(txtAbortos, erpNumeros);
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            InicioDeSesion ven1 = new InicioDeSesion();
            ven1.Show();
            this.Hide();
            MessageBox.Show("Su sesion ha sido cerrada exitosamente");
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            MenuDeNavegacion ven2 = new MenuDeNavegacion();
            ven2.Show();
            this.Hide();
        }
    }
}
