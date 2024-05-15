using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MegaProjeto.Control;
using MegaProjeto.Viwer;

namespace MegaProjeto.Model
{
    
    public class ConfigDBModel
    {
        public string Servidor { get; set; }
        public int Porta { get; set; }
        public string Banco { get; set; }
        public string Usuario { get; set; }
        public string Senha { get; set; }
    }
}
