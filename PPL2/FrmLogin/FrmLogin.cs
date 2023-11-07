using System.Text.Json;
using System.Text.Json.Serialization;
using Newtonsoft.Json;


namespace FrmLogin
{
    /// <summary>
    /// Formulario de inicio de sesión que permite a los usuarios autenticarse.
    /// </summary>
    public partial class FrmLogin : Form
    {
        List<Usuario> listaUsuarios = new List<Usuario>();
        public Usuario usuarioIngresado = new Usuario();

        public FrmLogin()
        {
            InitializeComponent();

        }
        /// <summary>
        /// Maneja el evento de clic del botón "Iniciar Sesión".
        /// Comprueba las credenciales del usuario y muestra el formulario de Crud si las credenciales son válidas.
        /// </summary>
        private void button1_Click(object sender, EventArgs e)
        {
            this.listaUsuarios = DescerializarJSON();
            foreach (Usuario usuario in this.listaUsuarios)
            {
                if (usuario.correo == txtCorreo.Text && usuario.clave == txtContra.Text)
                {
                    this.usuarioIngresado.nombre = usuario.nombre;
                    this.usuarioIngresado.apellido = usuario.apellido;
                    this.usuarioIngresado.perfil = usuario.perfil;
                    this.usuarioIngresado.legajo = usuario.legajo;
                    FrmCrud frmCrud = new FrmCrud(this.usuarioIngresado);
                    frmCrud.Show();
                    this.Hide();
                    lblError.Visible = false;


                }
                else
                {
                    lblError.Visible = true;
                }
            }

        }


        private void FrmLogin_Load(object sender, EventArgs e)
        {


        }
        /// <summary>
        /// Deserializa datos de usuarios desde un archivo JSON y los almacena en una lista.
        /// </summary>
        /// <returns>Una lista de usuarios deserializada desde un archivo JSON.</returns>
        private List<Usuario> DescerializarJSON()
        {
            string path = Path.Join("Archivos", "MOCK_DATA.json");
            listaUsuarios = JsonConvert.DeserializeObject<List<Usuario>>(File.ReadAllText(path));
            return listaUsuarios;
        }

        

    }
}
