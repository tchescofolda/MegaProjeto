using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MegaProjeto.Control;
using MegaProjeto.DAO;

namespace MegaProjeto.Viwer
{
    public partial class ConfigDBForm : Form
    {
        private ConfigDBController configDBController;
        public ConfigDBForm()
        {
            InitializeComponent();
            configDBController = new ConfigDBController();
            configDBController.SetView(this);
            configDBController.CarregarConfiguracoes();
        }
       
        private void FrmConfigDB_Load(object sender, EventArgs e)
        {

        }

        private void btSair_Click(object sender, EventArgs e)
        {
            configDBController.FechaConfigDBForm();
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            configDBController.SalvarConfiguracoes(this);
            configDBController.conecta();
        }

        private void btTestar_Click(object sender, EventArgs e)
        {
           
            configDBController.conecta();
        }
    }
}
