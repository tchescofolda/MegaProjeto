using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MegaProjeto.Viwer;

namespace MegaProjeto.Control
{
    public class LoginController
    {
        private LoginForm view;


        //Seta o form LoginForm
        public void SetView(LoginForm view)
        {
            this.view = view;
        }
        //Funcao abre o ConfigDBForm
        public void AbreConfigForm()
        {
            try
            {
                ConfigDBForm dbForm = new ConfigDBForm();
                dbForm.Show();
                view.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu uma exceção: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }
    }
}