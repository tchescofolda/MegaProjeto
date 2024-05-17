using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using MegaProjeto.Control;
using MegaProjeto.Model;
using MySql.Data.MySqlClient;
using Newtonsoft.Json;
using static Org.BouncyCastle.Math.EC.ECCurve;

namespace MegaProjeto.DAO
{
    internal class SocktDAO
    {
        MainController _controller = new MainController();
        private string connectionString;
        public SocktDAO()
        {
            //_controller = new MainController();
            //var config = _controller.RetonaConfBDJson();
            //connectionString = $"Server={config.Servidor};Port={config.Porta};Database={config.Banco};Uid={config.Usuario};Pwd={config.Senha};";
        }
        public void conectar()
        {
            try
            {
                _controller = new MainController();
                var config = _controller.RetonaConfBDJson();
                connectionString = $"Server={config.Servidor};Port={config.Porta};Database={config.Banco};Uid={config.Usuario};Pwd={config.Senha};";
                using (var connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    MessageBox.Show("Conectou");
                    connection.Close();
                   
                }
               
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu uma exceção: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
