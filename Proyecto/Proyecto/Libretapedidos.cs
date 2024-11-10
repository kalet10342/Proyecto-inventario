using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto
{
    public partial class Libretapedidos : Form
    {
        public Libretapedidos()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            string correo = txtCorreo.Text;
            string fono = txtFono.Text;
            string tipo = cmbTipo.Text;

            if (nombre == "" || correo == "" || fono == ""
                 || tipo == "Seleccione tipo")
            {
                MessageBox.Show("Debe completar todos los campos");
            }
            else
            {
               Contactos nuevoContacto = new Contactos(nombre, correo, fono, tipo);
               int fila = nuevoContacto.AgregarContacto();

                if (fila == 1)
                {
                    MessageBox.Show("El registro se agragó correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtNombre.Text = "";
                    txtCorreo.Text = "";
                    txtFono.Text = "";
                    cmbTipo.Text = "Seleccione Tipo";

                }else
                {
                    MessageBox.Show("Ocurió un problema al agregar el registro", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
