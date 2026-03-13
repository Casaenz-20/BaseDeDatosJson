using BaseDeDatosJson.Properties;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaseDeDatosJson
{
    public partial class Form1 : Form
    {
        public static List<JObject> Usuarios = new List<JObject>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (!ArchivoUsuarioExiste(Settings.Default.UserLogin))
            {
                CreaArchivo(Settings.Default.UserLogin);

            }
            Usuarios = LeerUsuarios(Settings.Default.UserLogin);
        }

       
        Func<string, bool> ArchivoUsuarioExiste = (ruta) => File.Exists(ruta);

        private List<JObject> LeerUsuarios(string usuariosLogin)
        {
            string contenido_usuario_tex = File.ReadAllText(usuariosLogin);
            return JsonConvert.DeserializeObject<List<JObject>>(contenido_usuario_tex) ?? new List<JObject>();
        }


        private void CreaArchivo(string usuariosLogin)
        {
            File.WriteAllText(usuariosLogin, "[]");
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {

        }

        private void btnCrearUsuario_Click(object sender, EventArgs e)
        {
            RegistroUsuarios registroUsuarios = new RegistroUsuarios();
            registroUsuarios.Show();
            this.Hide();
        }
    }
}
