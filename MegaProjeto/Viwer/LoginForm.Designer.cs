namespace MegaProjeto.Viwer
{
    partial class LoginForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbUsuario = new System.Windows.Forms.Label();
            this.lbSenha = new System.Windows.Forms.Label();
            this.txUsuario = new System.Windows.Forms.TextBox();
            this.txSenha = new System.Windows.Forms.TextBox();
            this.btConfirma = new System.Windows.Forms.Button();
            this.btSair = new System.Windows.Forms.Button();
            this.btConfiguracao = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbUsuario
            // 
            this.lbUsuario.AutoSize = true;
            this.lbUsuario.Location = new System.Drawing.Point(13, 13);
            this.lbUsuario.Name = "lbUsuario";
            this.lbUsuario.Size = new System.Drawing.Size(46, 13);
            this.lbUsuario.TabIndex = 0;
            this.lbUsuario.Text = "Usuario:";
            // 
            // lbSenha
            // 
            this.lbSenha.AutoSize = true;
            this.lbSenha.Location = new System.Drawing.Point(13, 39);
            this.lbSenha.Name = "lbSenha";
            this.lbSenha.Size = new System.Drawing.Size(41, 13);
            this.lbSenha.TabIndex = 1;
            this.lbSenha.Text = "Senha:";
            // 
            // txUsuario
            // 
            this.txUsuario.Location = new System.Drawing.Point(65, 10);
            this.txUsuario.Name = "txUsuario";
            this.txUsuario.Size = new System.Drawing.Size(100, 20);
            this.txUsuario.TabIndex = 2;
            // 
            // txSenha
            // 
            this.txSenha.Location = new System.Drawing.Point(65, 39);
            this.txSenha.Name = "txSenha";
            this.txSenha.Size = new System.Drawing.Size(100, 20);
            this.txSenha.TabIndex = 3;
            // 
            // btConfirma
            // 
            this.btConfirma.Location = new System.Drawing.Point(12, 65);
            this.btConfirma.Name = "btConfirma";
            this.btConfirma.Size = new System.Drawing.Size(75, 23);
            this.btConfirma.TabIndex = 4;
            this.btConfirma.Text = "Confirmar";
            this.btConfirma.UseVisualStyleBackColor = true;
            // 
            // btSair
            // 
            this.btSair.Location = new System.Drawing.Point(93, 65);
            this.btSair.Name = "btSair";
            this.btSair.Size = new System.Drawing.Size(75, 23);
            this.btSair.TabIndex = 5;
            this.btSair.Text = "Sair";
            this.btSair.UseVisualStyleBackColor = true;
            this.btSair.Click += new System.EventHandler(this.btSair_Click);
            // 
            // btConfiguracao
            // 
            this.btConfiguracao.Location = new System.Drawing.Point(12, 94);
            this.btConfiguracao.Name = "btConfiguracao";
            this.btConfiguracao.Size = new System.Drawing.Size(23, 23);
            this.btConfiguracao.TabIndex = 6;
            this.btConfiguracao.Text = "*";
            this.btConfiguracao.UseVisualStyleBackColor = true;
            this.btConfiguracao.Click += new System.EventHandler(this.btConfiguracao_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(185, 126);
            this.ControlBox = false;
            this.Controls.Add(this.btConfiguracao);
            this.Controls.Add(this.btSair);
            this.Controls.Add(this.btConfirma);
            this.Controls.Add(this.txSenha);
            this.Controls.Add(this.txUsuario);
            this.Controls.Add(this.lbSenha);
            this.Controls.Add(this.lbUsuario);
            this.Name = "LoginForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbUsuario;
        private System.Windows.Forms.Label lbSenha;
        private System.Windows.Forms.TextBox txUsuario;
        private System.Windows.Forms.TextBox txSenha;
        private System.Windows.Forms.Button btConfirma;
        private System.Windows.Forms.Button btSair;
        private System.Windows.Forms.Button btConfiguracao;
    }
}