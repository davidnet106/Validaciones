using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace validaciones
{
    public partial class Form1 : Form
    {

        ValidarCajas validacion = new ValidarCajas();
        public Form1()
        {
            InitializeComponent();
        }        

        // funcion para limpiar las cajas de texto 
        private void limpiarCajas()
        {
            nombreIn.Clear();
            codigoIn.Clear();
            correoIn.Clear();
            passwordIn.Clear();
        }

        private void btnValidacion_Click_1(object sender, EventArgs e)
        {
            if (!validacion.Vacio(nombreIn, errorM, "El nombre no puede ser vacío"))
                if (validacion.TipoTexto(nombreIn, errorM, "Debe digitar texto"))
                    if (!validacion.Vacio(codigoIn, errorM, "El codigo no puede ser vacío"))
                        if (validacion.TipoNumero(codigoIn, errorM, "Debe digitar numeros"))
                            if (!validacion.Vacio(correoIn, errorM, "El correo no puede ser vacío"))
                                if (validacion.TipoCorreo(correoIn, errorM, "El correo no cumple con el formato"))
                                {
                                    salida.Text = "Todos los valores cumplen con el formato";
                                    limpiarCajas();
                                }
        }

        private void btnValPass_Click(object sender, EventArgs e)
        {
            if(!validacion.Vacio(passwordIn, errorM, "El campo no puede estar vacío"))
                if(validacion.TipoPassword(passwordIn, errorM, ""))
                    {
                        lblValidacionPass.Text = "El password es correcto";
                    limpiarCajas();
                    }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            salida.Text = "---";
            lblValidacionPass.Text = "---";
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Seguro(a) que desea salir del sistema?", "Consulta",
                  MessageBoxButtons.YesNo,
                  MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}

