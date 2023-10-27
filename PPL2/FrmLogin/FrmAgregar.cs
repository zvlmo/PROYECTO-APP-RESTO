using DiGirolamo.Matias;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrmLogin
{
    /// <summary>
    /// Formulario para agregar un nuevo restaurante a la lista.
    /// </summary>
    public partial class FrmAgregar : Form
    {
        public Restaurante restaurantes;
        public DiGirolamo.Matias.Restaurante restaurante;
        public CadenaRestaurantes listaRestaurantes = new CadenaRestaurantes();


        public FrmAgregar()
        {
            InitializeComponent();
        }
        public FrmAgregar(Restaurante r)
        {
            this.txtNombre.Text = "xxx";
            this.txtCapacidad.Text = "0";
            this.comboBoxReserva.Text = "No";
            this.comboBoxEstado.Text = "Abierto";

        }

        char TipoRestaurante = 'X';
        /// <summary>
        /// Controlador de eventos para el botón "Aceptar".
        /// Valida y agrega un restaurante a la lista de restaurantes.
        /// </summary>
        private void btnAceptar_Click(object sender, EventArgs e)
        {

            if (TipoRestaurante != 'X' && CheckearVacios() == true)
            {
                int capacidad = int.Parse(txtCapacidad.Text);
                switch (TipoRestaurante)
                {
                    case 'P':
                        Parrilla nuevaParrila = new Parrilla(int.Parse(txtParrilla.Text), CheckearBooleano(comboBoxParrilla.Text), CheckearBooleano(comboBoxReserva.Text), capacidad, txtNombre.Text, ComprobarEnumerado());
                        restaurante = nuevaParrila;
                        break;
                    case 'B':
                        Bar nuevoBar = new Bar(int.Parse(txtBar.Text), CheckearBooleano(comboBoxBar.Text), CheckearBooleano(comboBoxReserva.Text), capacidad, txtNombre.Text, ComprobarEnumerado());
                        restaurante = nuevoBar;
                        break;
                    default:
                        FastFood nuevoFastFood = new FastFood(int.Parse(txtFastFood.Text), CheckearBooleano(comboBoxFastFood.Text), CheckearBooleano(comboBoxReserva.Text), capacidad, txtNombre.Text, ComprobarEnumerado());
                        restaurante = nuevoFastFood;

                        break;
                }
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Debes completar todo!");
            }

            this.listaRestaurantes += restaurante;

        }
        /// <summary>
        /// Controlador de eventos para la selección del tipo de restaurante en el ComboBox.
        /// Habilita o deshabilita los campos según el tipo de restaurante seleccionado.
        /// </summary>
        private void comboBoxRest_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBoxRest.SelectedItem.ToString())
            {
                case "Parrilla":
                    comboBoxParrilla.Enabled = true;
                    txtParrilla.Enabled = true;
                    comboBoxFastFood.Enabled = false;
                    txtFastFood.Enabled = false;
                    comboBoxBar.Enabled = false;
                    txtBar.Enabled = false;
                    TipoRestaurante = 'P';
                    break;
                case "Bar":
                    comboBoxParrilla.Enabled = false;
                    txtParrilla.Enabled = false;
                    comboBoxFastFood.Enabled = false;
                    txtFastFood.Enabled = false;
                    comboBoxBar.Enabled = true;
                    txtBar.Enabled = true;
                    TipoRestaurante = 'B';
                    break;
                case "FastFood":
                    comboBoxParrilla.Enabled = false;
                    txtParrilla.Enabled = false;
                    comboBoxFastFood.Enabled = true;
                    txtFastFood.Enabled = true;
                    comboBoxBar.Enabled = false;
                    txtBar.Enabled = false;
                    TipoRestaurante = 'F';
                    break;
            }
        }
        /// <summary>
        /// Convierte una cadena en el enumerado EEstado.
        /// </summary>
        private EEstado ComprobarEnumerado()
        {
            EEstado valor;
            switch (comboBoxEstado.Text)
            {
                case "Abierto":
                    valor = EEstado.Abierto;
                    break;
                case "Cerrado":
                    valor = EEstado.Cerrado;
                    break;
                default:
                    valor = EEstado.Lleno;
                    break;

            }
            return valor;
        }
        /// <summary>
        /// Convierte una cadena en un valor booleano.
        /// </summary>
        private bool CheckearBooleano(string aChequear)
        {

            if (aChequear == "Si")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// Verifica si los campos obligatorios están completos.
        /// </summary>
        private bool CheckearVacios()
        {
            switch (TipoRestaurante)
            {
                case 'P':
                    if (txtParrilla.Text == "" || comboBoxParrilla.Text == "")
                    {
                        return false;
                    }
                    break;
                case 'B':
                    if (txtBar.Text == "" || comboBoxBar.Text == "")
                    {
                        return false;
                    }
                    break;
                default:
                    if (txtFastFood.Text == "" || comboBoxFastFood.Text == "")
                    {
                        return false;
                    }
                    break;
            }

            if (txtNombre.Text == "" || txtCapacidad.Text == "" || comboBoxReserva.Text == "" || comboBoxRest.Text == "" || comboBoxEstado.Text == "")
            {
                return false;
            }

            return true;
        }


        private void FrmAgregar_Load(object sender, EventArgs e)
        {

        }

        private void txtCapacidad_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxReserva_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxParrilla_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtParrilla_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxBar_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtBar_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxFastFood_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtCombos_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
