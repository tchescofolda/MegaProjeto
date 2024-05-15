using System;
using System.Windows.Forms;
using Newtonsoft.Json;
using MegaProjeto.Model;
using MegaProjeto.Viwer;
using System.IO;

namespace MegaProjeto.Control
{
    public class ConfigDBController
    {
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
            string caminhoArquivo = @"C:\Users\Tchesco\source\repos\MegaProjeto\MegaProjeto\config.json";

            try
            {
                // Escreve o JSON no arquivo
                File.WriteAllText(caminhoArquivo, json);

                MessageBox.Show("Configurações salvas com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao salvar as configurações: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
