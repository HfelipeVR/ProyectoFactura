using FACTURACION.Modelos.DAO;
using FACTURACION.Modelos.Entidades;
using FACTURACION.Vistas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FACTURACION.Controladores
{
    public class LoginController
    {   
        //Declarar un objeto de LoginView:
        LoginView vista;

        //Creación del Constructor: 
        public LoginController(LoginView view)
        {
            vista = view;
            vista.btnAceptar.Click += new EventHandler(ValidarUsuario);
        }

        //Creación de Método Para validar si el usuario ingresado es correcto:
        private void ValidarUsuario(object serder, EventArgs e)
        {
            UsuarioDAO userDao = new UsuarioDAO();
            Usuario user = new Usuario();
            user.Email = vista.txtEmail.Text;
            user.Clave = EncriptarClave(vista.txtClave.Text);

         
        }

        public static string EncriptarClave(string str)
        {
            string cadena = str + "MiClavePeronal";
            SHA256 sha256 = SHA256Managed.Create();
            ASCIIEncoding encoding = new ASCIIEncoding();
            byte[] stream = null;
            StringBuilder sb = new StringBuilder();
            stream = sha256.ComputeHash(encoding.GetBytes(cadena));
            for (int i = 0; i < stream.Length; i++) sb.AppendFormat("{0:x2}", stream[i]);
            return sb.ToString();
        }
    }
}
