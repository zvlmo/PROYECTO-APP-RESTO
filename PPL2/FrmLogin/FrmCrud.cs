using DiGirolamo.Matias;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrmLogin
{
    /// <summary>
    /// Formulario principal para administrar restaurantes.
    /// </summary>
    public partial class FrmCrud : Form
    {


        private List<Restaurante> restauranteList;
        public Usuario usuarioIngreso = new Usuario();
        /// <summary>
        /// Constructor del formulario.
        /// </summary>
        /// <param name="usuarioIngresado">Usuario que ha iniciado sesión en la aplicación.</param>
        public FrmCrud(Usuario usuarioIngresado)
        {
            InitializeComponent();
            this.restauranteList = new List<Restaurante>();
            this.usuarioIngreso = usuarioIngresado;
            lblFecha.Text = DateTime.Now.ToShortDateString();
            lblNombre.Text = $"Bienvenido, {this.usuarioIngreso.nombre} {this.usuarioIngreso.apellido}";
            UsuariosLog();
        }
        /// <summary>
        /// Actualiza el visor ListBox con la lista de restaurantes.
        /// </summary>
        private void ActualizarVisor()
        {
            this.listBox.Items.Clear();
            foreach (Restaurante restaurante in this.restauranteList)
            {
                listBox.Items.Add(restaurante.ToString());
            }
        }
        /// <summary>
        /// Controlador de eventos para el botón "Agregar Restaurante".
        /// Abre un formulario para agregar un nuevo restaurante a la lista.
        /// </summary>
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FrmAgregar agregar = new FrmAgregar();
            agregar.ShowDialog();
            if (agregar.DialogResult == DialogResult.OK)
            {
                this.restauranteList.Add(agregar.restaurante);
                this.ActualizarVisor();
            }
        }
        /// <summary>
        /// Controlador de eventos para el botón "Modificar Restaurante".
        /// Abre un formulario para modificar un restaurante de la lista.
        /// </summary>
        private void btnModificar_Click(object sender, EventArgs e)
        {
            int indice = this.listBox.SelectedIndex;

            if (indice == -1)
            {
                return;
            }
            Restaurante restaurante = this.restauranteList[indice];

            FrmAgregar rest = new FrmAgregar();
            rest.ShowDialog();
            if (rest.DialogResult == DialogResult.OK)
            {
                this.restauranteList[indice] = rest.restaurante;
                this.ActualizarVisor();
            }
        }

        /// <summary>
        /// Controlador de eventos para el botón "Eliminar Restaurante".
        /// Elimina un restaurante de la lista.
        /// </summary>
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int indice = this.listBox.SelectedIndex;

            if (indice == -1)
            {
                return;
            }


            this.restauranteList.RemoveAt(indice);//recibe un entero 
            this.ActualizarVisor();

        }

        private void listBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblNombre_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Controlador de eventos para el botón "Guardar Datos".
        /// Serializa la lista de restaurantes y guarda los datos en un archivo JSON.
        /// </summary>
        private void btnGuardar_Click(object sender, EventArgs e)
        {

            DataSerializer(this.restauranteList);

        }
        /// <summary>
        /// Controlador de eventos para el botón "Cargar Datos".
        /// Deserializa los datos de restaurantes desde un archivo JSON.
        /// </summary>
        private void btnCargar_Click(object sender, EventArgs e)
        {
            DataDeserializer();
        }
        /// <summary>
        /// Serializa la lista de restaurantes y guarda los datos en un archivo JSON.
        /// </summary>
        private void DataSerializer(List<Restaurante> resto)
        {
            string rutaArchivoLog = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            rutaArchivoLog = Path.Join(rutaArchivoLog, "PPL2", "restaurantes.json");
            using (StreamWriter sw = new StreamWriter(rutaArchivoLog, true))
            {
                string json = JsonConvert.SerializeObject(resto, Formatting.Indented);
                sw.WriteLine(json);
                MessageBox.Show("Datos serializados");


            }
        }
        /// <summary>
        /// DEBERIA Deserializar los datos de restaurantes desde un archivo JSON.
        /// </summary>
        private void DataDeserializer()
        {

            MessageBox.Show("Aun no hemos implementado ese metodo!!, lo haremos pronto!");

        }
        /// <summary>
        /// Ordena la lista de restaurantes alfabéticamente de forma ascendente.
        /// </summary>
        private void btnAlfabetica_Click(object sender, EventArgs e)
        {
            CadenaRestaurantes listaOrdenada = new CadenaRestaurantes();
            foreach (Restaurante restaurante in this.restauranteList)
            {
                listaOrdenada += restaurante;
            }
            listaOrdenada.LocalesRestaurantes.Sort(CadenaRestaurantes.OrdenarRestaurantesAlfabeticamenteAscendente);
            this.restauranteList = listaOrdenada.LocalesRestaurantes;
            ActualizarVisor();
        }
        /// <summary>
        /// Ordena la lista de restaurantes por capacidad de forma descendente.
        /// </summary>
        private void btnCapacidad_Click(object sender, EventArgs e)
        {
            CadenaRestaurantes listaOrdenada = new CadenaRestaurantes();
            foreach (Restaurante restaurante in this.restauranteList)
            {
                listaOrdenada += restaurante;
            }
            listaOrdenada.LocalesRestaurantes.Sort(CadenaRestaurantes.OrdenarRestaurantesPorCapacidadDescendente);
            this.restauranteList = listaOrdenada.LocalesRestaurantes;
            ActualizarVisor();
        }

        private void btnAlfebeticamenteDescendente_Click(object sender, EventArgs e)
        {
            CadenaRestaurantes listaOrdenada = new CadenaRestaurantes();
            foreach (Restaurante restaurante in this.restauranteList)
            {
                listaOrdenada += restaurante;
            }
            listaOrdenada.LocalesRestaurantes.Sort(CadenaRestaurantes.OrdenarRestaurantesAlfabeticamenteDescendente);
            this.restauranteList = listaOrdenada.LocalesRestaurantes;
            ActualizarVisor();
        }

        private void btnCapacidadAscendente_Click(object sender, EventArgs e)
        {
            CadenaRestaurantes listaOrdenada = new CadenaRestaurantes();
            foreach (Restaurante restaurante in this.restauranteList)
            {
                listaOrdenada += restaurante;
            }
            listaOrdenada.LocalesRestaurantes.Sort(CadenaRestaurantes.OrdenarRestaurantesPorCapacidadAscendente);
            this.restauranteList = listaOrdenada.LocalesRestaurantes;
            ActualizarVisor();
        }
        /// <summary>
        /// Registra los datos de acceso del usuario en un archivo de registro.
        /// </summary>
        private void UsuariosLog()
        {
            DateTime fechaHoraActual = DateTime.Now;
            string fechaHoraFormateada = fechaHoraActual.ToString("yyyy-MM-dd HH:mm:ss");
            string rutaArchivoLog = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            rutaArchivoLog = Path.Join(rutaArchivoLog, "PPL2", "usuarios.log");
            try
            {
                using (StreamWriter sw = File.AppendText(rutaArchivoLog))
                {
                    sw.WriteLine($"Legajo: {this.usuarioIngreso.legajo} - Nombre completo: {this.usuarioIngreso.nombre} {this.usuarioIngreso.apellido} - Perfil: {this.usuarioIngreso.perfil} -- Ingreso:{fechaHoraFormateada} ");
                }
            }
            catch (IOException ex)
            {
                Console.WriteLine($"Error al escribir en el archivo de registro: {ex.Message}");
            }
        }
        /// <summary>
        /// Controlador de eventos para el botón "Ver Logs".
        /// Abre un formulario para ver los registros de acceso de usuarios.
        /// </summary>
        private void btnLogs_Click(object sender, EventArgs e)
        {
            FrmLogs frmLog = new FrmLogs();
            frmLog.Show();
        }
    }
}
