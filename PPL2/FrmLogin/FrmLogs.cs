using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrmLogin
{
     /// <summary>
     /// Formulario que muestra registros de actividad de usuarios en una lista.
     /// </summary>
    public partial class FrmLogs : Form
    {
        /// <summary>
        /// Constructor de la clase FrmLogs.
        /// Muestra los registros de actividad de usuarios en una lista en el formulario.
        /// </summary>
        public FrmLogs()
        {
            InitializeComponent();
            string rutaArchivoLog = Path.Join("Archivos", "usuarios.log");
            listBox1.Items.Clear();

            if (File.Exists(rutaArchivoLog))
            {
                string[] lineas = File.ReadAllLines(rutaArchivoLog);
                foreach (string linea in lineas)
                {
                    listBox1.Items.Add(linea);
                }
            }
            else { MessageBox.Show("No existe el archivo!"); }

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            

        }
    }
}
