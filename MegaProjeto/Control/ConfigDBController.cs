using System;
using System.Windows.Forms;
using Newtonsoft.Json;
using MegaProjeto.Model;
using MegaProjeto.Viwer;
using System.IO;
using System.Windows.Shapes;
using MegaProjeto.DAO;

namespace MegaProjeto.Control
{
    public class ConfigDBController : MainController

    {
        
        MainController _controller = new MainController();
        SocktDAO _conector = new SocktDAO();
        private ConfigDBForm view;
        //Seta o form ConfigDBForm
        public void SetView(ConfigDBForm view)
        {
            this.view = view;
        }

        //Funcao abre o ConfigDBForm
        public void FechaConfigDBForm()
        {
            try
            {
                LoginForm loginForm = new LoginForm();
                loginForm.Show();
                view.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu uma exceção: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void SalvarConfiguracoes(ConfigDBForm view)
        {
            // Cria um objeto ConfigDBModel e popula com os dados dos campos do formulário
            var configDBModel = new ConfigDBModel{
                Servidor = view.txServidor.Text,
                Porta = int.Parse(view.txPorta.Text),
                Banco = view.txBanco.Text,
                Usuario = view.txUser.Text,
                Senha = view.txSenha.Text
            };

            // Converte o objeto configDBModel para uma string JSON
            string json = JsonConvert.SerializeObject(configDBModel);

            // Define o caminho completo do arquivo de configuração

            try
            {
                // Escreve o JSON no arquivo
                File.WriteAllText(_controller.caminhoConfig, json);

                MessageBox.Show("Configurações salvas com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao salvar as configurações: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void CarregarConfiguracoes()
        {
            

            try
            {
                //var json = File.ReadAllText(_controller.caminhoConfig);
                //var config = JsonConvert.DeserializeObject<ConfigDBModel>(json);
                var config = _controller.RetonaConfBDJson();
                // Preencher os TextBoxes com as informações do arquivo JSON

                view.txServidor.Text = config.Servidor;
                view.txPorta.Text = config.Porta.ToString();
                view.txBanco.Text = config.Banco;
                view.txUser.Text = config.Usuario;
                view.txSenha.Text = config.Senha;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar configurações: " + ex.Message);
            }
        }

        public void conecta()
        {
            _conector.conectar();
        }
    }
}
