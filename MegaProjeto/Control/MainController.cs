using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json;
using MegaProjeto.Model;

namespace MegaProjeto.Control
{
    public class MainController
    {
        public string caminhoConfig = @"C:\Users\Tchesco\source\repos\MegaProjeto\MegaProjeto\config.json";
      

        public ConfigDBModel RetonaConfBDJson()
        {
            try {
                var json = File.ReadAllText(caminhoConfig);
                var config = JsonConvert.DeserializeObject<ConfigDBModel>(json);
                return config;
            }
            catch (Exception ex) {
                MessageBox.Show("Erro ao carregar configurações: " + ex.Message);
                throw;
            }
            
        }

    }


    
}
