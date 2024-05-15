using MegaProjeto.Control;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaProjeto.Viwer
{
    public partial class LoginForm : Form
    {
        private LoginController loginController;
        public LoginForm()
        {
            InitializeComponent();
            loginController = new LoginController();
            loginController.SetView(this);
        }

        private void btSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btConfiguracao_Click(object sender, EventArgs e)
        {
            loginController.AbreConfigForm();
        }
    }
}
