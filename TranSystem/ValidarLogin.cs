using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TranSystem.BO
{
    public class Registrar
    {
        public static Database db = new Database();

        public static int RegistrarUsuario(string login, string password, string repeatpassword, string email)
        {

            if (password.Equals(repeatpassword) && email.Contains("@") &&
               (!String.IsNullOrEmpty(login) || !String.IsNullOrEmpty(email) || !String.IsNullOrEmpty(password) || !String.IsNullOrEmpty(repeatpassword)))
            {
                db.ExecutarComandoSQL("INSERT INTO USUARIO(username,password,email) VALUES(" + login + "," + password + "," + email + ")");
                return 1;
            }
            else
            {
                return 0;
            }

        }

    }
}