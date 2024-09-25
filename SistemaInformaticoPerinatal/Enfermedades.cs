using Entidades;

namespace SistemaInformaticoPerinatal
{
    public partial class Enfermedades : Form
    {
        public Enfermedades()
        {
            InitializeComponent();
        }

        private void btnContinuar_Click(object sender, EventArgs e)
        {
            var enfermedadesMaternas = new EnfermedadesMaternas()
            {
                UnaoMas = rbnEnfermedades1oMas.Checked,
                HTAPrevia = rbnHTApreviaSi.Checked,
                HTAInducidaEmbarazo = rbnHTAindEmbaSi.Checked,
                Preeclampsia = rbnPreeclampsiaSi.Checked,
                Eclampsia = rbnEclampsiaSi.Checked,
                Cardiopatia = rbnCardiopatiaSi.Checked,
                Nefropatia = rbnNefropatiaSi.Checked,
                DiabetesEnfermedades = new DiabetesEnfermedades
                {
                    Id = rbnDiabetesNo.Checked ? (int)Entidades.Enumeraciones.DiabetesEnfermedades.No :
                        rbnDiabetesI.Checked ? (int)Entidades.Enumeraciones.DiabetesEnfermedades.TipoI :
                        rbnDiabetesII.Checked ? (int)Entidades.Enumeraciones.DiabetesEnfermedades.TipoII :
                        (int)Entidades.Enumeraciones.DiabetesEnfermedades.TipoG
                },
                InfeccionObular = rbnInfecObularSi.Checked,
                InfeccionUrinaria = rbnInfecUSi.Checked,
                AmenazaPartoPreter = rbnAmenzaPartoPSi.Checked,
                RCIU = rbnRCIUSi.Checked,
                RoturaPremMembranas = rbnRoturaPremMemSi.Checked,
                Anemia = rbnAnemiaSi.Checked,
                OtraCondGrave = rbnOtraCondGraveSi.Checked,


                //hemooragia 
                HemorragiaPrimerTrimestre = rbn1erTSi.Checked,
                HemorragiaSegundoTrimestre = rbn2doTSi.Checked,
                HemorragiaTercerTrimestre = rbn3erTSi.Checked,
                HemorragiaPostparto = rbnPostpartoSi.Checked,
                HemorragiaInfeccionPuerperal = rbnInfectPSi.Checked,


                //tdpprueba
                TdpSifilis = new TdpSifilis
                {
                    Id = rbnSifilisMenos.Checked ? (int)Entidades.Enumeraciones.TdpSifilis.Negativo :
                        rbnSifilisMas.Checked ? (int)Entidades.Enumeraciones.TdpSifilis.Positivo :
                        rbnSifilisNr.Checked ? (int)Entidades.Enumeraciones.TdpSifilis.Nr :
                        (int)Entidades.Enumeraciones.TdpSifilis.Nc
                },
                TdpVIH = new TdpVIH
                {
                    Id = rbnVIHMenos.Checked ? (int)Entidades.Enumeraciones.TdpVIH.Negativo :
                        rbnVIHMas.Checked ? (int)Entidades.Enumeraciones.TdpVIH.Positivo :
                        rbnVIHNr.Checked ? (int)Entidades.Enumeraciones.TdpVIH.Nr :
                        (int)Entidades.Enumeraciones.TdpVIH.Nc
                },
                TARV = new TARV
                {
                    Id = rbnTARVSi.Checked ? (int)Entidades.Enumeraciones.TRAV.Si :
                        rbnTARVNo.Checked ? (int)Entidades.Enumeraciones.TRAV.No :
                        (int)Entidades.Enumeraciones.TRAV.Nc
                }


            };



            bool radioButtonChecked = true;

            // Limpiar cualquier mensaje de error previo
            erpBoton.Clear();

            // Validar cada grupo de RadioButtons y establecer mensajes de error si no están seleccionados
            if (!(rbnEnfermedades1oMas.Checked || rbnEnfermedadesNinguna.Checked))
            {
                erpBoton.SetError(rbnEnfermedadesNinguna, "Seleccione una opción.");
                radioButtonChecked = false;
            }
            if (!(rbnHTApreviaSi.Checked || rbnHTApreviaNo.Checked))
            {
                erpBoton.SetError(gbxHTAprevia, "Seleccione una opción.");
                radioButtonChecked = false;
            }
            if (!(rbnInfecUNo.Checked || rbnInfecUSi.Checked))
            {
                erpBoton.SetError(gbxHTAInduEmba, "Seleccione una opción.");
                radioButtonChecked = false;
            }
            if (!(rbnPreeclampsiaNo.Checked || rbnPreeclampsiaSi.Checked))
            {
                erpBoton.SetError(gbxPreeclampsia, "Seleccione una opción.");
                radioButtonChecked = false;
            }
            if (!(rbnEclampsiaNo.Checked || rbnEclampsiaSi.Checked))
            {
                erpBoton.SetError(gbxEclampsia, "Seleccione una opción.");
                radioButtonChecked = false;
            }
            if (!(rbnCardiopatiaNo.Checked || rbnCardiopatiaSi.Checked))
            {
                erpBoton.SetError(gbxCardiopatía, "Seleccione una opción.");
                radioButtonChecked = false;
            }
            if (!(rbnNefropatiaNo.Checked || rbnNefropatiaSi.Checked))
            {
                erpBoton.SetError(gbxNefropatia, "Seleccione una opción.");
                radioButtonChecked = false;
            }
            if (!(rbnInfecObularNo.Checked || rbnInfecObularSi.Checked))
            {
                erpBoton.SetError(gbxInfecObular, "Seleccione una opción.");
                radioButtonChecked = false;
            }
            if (!(rbnInfecUNo.Checked || rbnInfecUSi.Checked))
            {
                erpBoton.SetError(gbxInfecU, "Seleccione una opción.");
                radioButtonChecked = false;
            }
            if (!(rbnAmenzaPartoPNo.Checked || rbnAmenzaPartoPSi.Checked))
            {
                erpBoton.SetError(gbxAmenazaPartoP, "Seleccione una opción.");
                radioButtonChecked = false;
            }
            if (!(rbnRCIUNo.Checked || rbnRCIUSi.Checked))
            {
                erpBoton.SetError(gbxRCIU, "Seleccione una opción.");
                radioButtonChecked = false;
            }
            if (!(rbnRoturaPremMemNo.Checked || rbnRoturaPremMemSi.Checked))
            {
                erpBoton.SetError(gbxRoturaPremM, "Seleccione una opción.");
                radioButtonChecked = false;
            }
            if (!(rbnAnemiaNo.Checked || rbnAnemiaSi.Checked))
            {
                erpBoton.SetError(gbxAnemia, "Seleccione una opción.");
                radioButtonChecked = false;
            }
            if (!(rbnOtraCondGraveNo.Checked || rbnOtraCondGraveSi.Checked))
            {
                erpBoton.SetError(gbxOtraCondGrave, "Seleccione una opción.");
                radioButtonChecked = false;
            }
            if (!(rbn1erTNo.Checked || rbn1erTSi.Checked))
            {
                erpBoton.SetError(gbx1erT, "Seleccione una opción.");
                radioButtonChecked = false;
            }
            if (!(rbn2doTNo.Checked || rbn2doTSi.Checked))
            {
                erpBoton.SetError(gbx2doT, "Seleccione una opción.");
                radioButtonChecked = false;
            }
            if (!(rbn3erTNo.Checked || rbn3erTSi.Checked))
            {
                erpBoton.SetError(gbx3erT, "Seleccione una opción.");
                radioButtonChecked = false;
            }
            if (!(rbnPostpartoNo.Checked || rbnPostpartoSi.Checked))
            {
                erpBoton.SetError(gbxPostparto, "Seleccione una opción.");
                radioButtonChecked = false;
            }
            if (!(rbnInfectPNo.Checked || rbnInfectPSi.Checked))
            {
                erpBoton.SetError(gbxInfectP, "Seleccione una opción.");
                radioButtonChecked = false;
            }
            if (!(rbnDiabetesNo.Checked || rbnDiabetesI.Checked || rbnDiabetesII.Checked || rbnDiabetesG.Checked))
            {
                erpBoton.SetError(gbxDiabetes, "Seleccione una opción.");
                radioButtonChecked = false;
            }
            if (!(rbnTARVSi.Checked || rbnTARVNo.Checked || rbnTARVNc.Checked))
            {
                erpBoton.SetError(gbxTARV, "Seleccione una opción.");

                radioButtonChecked = false;
            }
            if (!(rbnSifilisNc.Checked || rbnSifilisNr.Checked || rbnSifilisMenos.Checked || rbnSifilisMas.Checked))
            {
                erpBoton.SetError(gbxSifilis, "Seleccione una opción.");

                radioButtonChecked = false;
            }
            if (!(rbnVIHMas.Checked || rbnVIHMenos.Checked || rbnVIHNc.Checked || rbnVIHNr.Checked))
            {
                erpBoton.SetError(gbxVIH, "Seleccione una opción.");

                radioButtonChecked = false;
            }


            bool textCheked = true;
            //Validar 1er codigo
            if (string.IsNullOrEmpty(txtCodigo1erT.Text) || !ValidarSoloNumeros(txtCodigo1erT, erpNumeros))
            {
                erpNumeros.SetError(txtCodigo1erT, "Debe ingresar solo numeros.");
                textCheked = false;

            }
            //validar txt2do codigo
            if (string.IsNullOrEmpty(txtCodigo2doT.Text) || !ValidarSoloNumeros(txtCodigo2doT, erpNumeros))
            {
                erpNumeros.SetError(txtCodigo2doT, "Debe ingresar solo numeros.");
                textCheked = false;

            }
            //validar txt3er codigo
            if (string.IsNullOrEmpty(txtCodigo3erT.Text) || !ValidarSoloNumeros(txtCodigo3erT, erpNumeros))
            {
                erpNumeros.SetError(txtCodigo3erT, "Debe ingresar solo numeros.");
                textCheked = false;

            }
            //validar txtpostparto
            if (string.IsNullOrEmpty(txtCodigoInfectP.Text) || !ValidarSoloNumeros(txtCodigoInfectP, erpNumeros))
            {
                erpNumeros.SetError(txtCodigoInfectP, "Debe ingresar solo numeros.");
                textCheked = false;

            }
            //validar txtpuerperal
            if (string.IsNullOrEmpty(txtCodigoPostparto.Text) || !ValidarSoloNumeros(txtCodigoPostparto, erpNumeros))
            {
                erpNumeros.SetError(txtCodigoPostparto, "Debe ingresar solo numeros.");
                textCheked = false;
            }
            // Mostrar mensaje de advertencia para botones cajas de texto
            if (!radioButtonChecked || !textCheked)
            {
                MessageBox.Show("Corrija los errores antes de finalizar, y verifique que todos los campos esten diligenciados");
                return;
            }
            InicioDeSesion ven1 = new InicioDeSesion();
            ven1.Show();
            this.Hide();
            MessageBox.Show("El formulario fue diligenciado de forma exitosa.");
        }
        //funcion para vakidar en interacciones
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






        private void btnRegresar_Click(object sender, EventArgs e)
        {
            MenuDeNavegacion ven2 = new MenuDeNavegacion();
            ven2.Show();
            this.Hide();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            InicioDeSesion ven1 = new InicioDeSesion();
            ven1.Show();
            this.Hide();
            MessageBox.Show("Su sesion ha sido cerrada exitosamente");
        }

        private void txtCodigo1erT_TextChanged(object sender, EventArgs e)
        {
            ValidarSoloNumeros(txtCodigo1erT, erpNumeros);
        }

        private void txtCodigo2doT_TextChanged(object sender, EventArgs e)
        {
            ValidarSoloNumeros(txtCodigo2doT, erpNumeros);

        }

        private void txtCodigo3erT_TextChanged(object sender, EventArgs e)
        {
            ValidarSoloNumeros(txtCodigo3erT, erpNumeros);
        }

        private void txtCodigoPostparto_TextChanged(object sender, EventArgs e)
        {
            ValidarSoloNumeros(txtCodigoPostparto, erpNumeros);
        }

        private void txtCodigoInfectP_TextChanged(object sender, EventArgs e)
        {
            ValidarSoloNumeros(txtCodigoInfectP, erpNumeros);
        }

        private void Enfermedades_Load(object sender, EventArgs e)
        {

        }
    }
}
