namespace MegaProjeto.Viwer
{
    partial class ConfigDBForm
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
            this.lbServidor = new System.Windows.Forms.Label();
            this.lbSenha = new System.Windows.Forms.Label();
            this.lbPorta = new System.Windows.Forms.Label();
            this.lbUser = new System.Windows.Forms.Label();
            this.lbBanco = new System.Windows.Forms.Label();
            this.txServidor = new System.Windows.Forms.TextBox();
            this.txPorta = new System.Windows.Forms.TextBox();
            this.txBanco = new System.Windows.Forms.TextBox();
            this.txUser = new System.Windows.Forms.TextBox();
            this.txSenha = new System.Windows.Forms.TextBox();
            this.btSalvar = new System.Windows.Forms.Button();
            this.btSair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbServidor
            // 
            this.lbServidor.AutoSize = true;
            this.lbServidor.Location = new System.Drawing.Point(4, 13);
            this.lbServidor.Name = "lbServidor";
            this.lbServidor.Size = new System.Drawing.Size(49, 13);
            this.lbServidor.TabIndex = 0;
            this.lbServidor.Text = "Servidor:";
            // 
            // lbSenha
            // 
            this.lbSenha.AutoSize = true;
            this.lbSenha.Location = new System.Drawing.Point(134, 59);
            this.lbSenha.Name = "lbSenha";
            this.lbSenha.Size = new System.Drawing.Size(41, 13);
            this.lbSenha.TabIndex = 1;
            this.lbSenha.Text = "Senha:";
            // 
            // lbPorta
            // 
            this.lbPorta.AutoSize = true;
            this.lbPorta.Location = new System.Drawing.Point(18, 36);
            this.lbPorta.Name = "lbPorta";
            this.lbPorta.Size = new System.Drawing.Size(35, 13);
            this.lbPorta.TabIndex = 2;
            this.lbPorta.Text = "Porta:";
            // 
            // lbUser
            // 
            this.lbUser.AutoSize = true;
            this.lbUser.Location = new System.Drawing.Point(21, 59);
            this.lbUser.Name = "lbUser";
            this.lbUser.Size = new System.Drawing.Size(32, 13);
            this.lbUser.TabIndex = 3;
            this.lbUser.Text = "User:";
            // 
            // lbBanco
            // 
            this.lbBanco.AutoSize = true;
            this.lbBanco.Location = new System.Drawing.Point(133, 39);
            this.lbBanco.Name = "lbBanco";
            this.lbBanco.Size = new System.Drawing.Size(41, 13);
            this.lbBanco.TabIndex = 4;
            this.lbBanco.Text = "Banco:";
            // 
            // txServidor
            // 
            this.txServidor.Location = new System.Drawing.Point(53, 10);
            this.txServidor.Name = "txServidor";
            this.txServidor.Size = new System.Drawing.Size(225, 20);
            this.txServidor.TabIndex = 5;
            // 
            // txPorta
            // 
            this.txPorta.Location = new System.Drawing.Point(53, 33);
            this.txPorta.Name = "txPorta";
            this.txPorta.Size = new System.Drawing.Size(75, 20);
            this.txPorta.TabIndex = 6;
            // 
            // txBanco
            // 
            this.txBanco.Location = new System.Drawing.Point(181, 36);
            this.txBanco.Name = "txBanco";
            this.txBanco.Size = new System.Drawing.Size(97, 20);
            this.txBanco.TabIndex = 7;
            // 
            // txUser
            // 
            this.txUser.Location = new System.Drawing.Point(53, 56);
            this.txUser.Name = "txUser";
            this.txUser.Size = new System.Drawing.Size(75, 20);
            this.txUser.TabIndex = 8;
            // 
            // txSenha
            // 
            this.txSenha.Location = new System.Drawing.Point(181, 59);
            this.txSenha.Name = "txSenha";
            this.txSenha.PasswordChar = '*';
            this.txSenha.Size = new System.Drawing.Size(97, 20);
            this.txSenha.TabIndex = 9;
            // 
            // btSalvar
            // 
            this.btSalvar.Location = new System.Drawing.Point(7, 98);
            this.btSalvar.Name = "btSalvar";
            this.btSalvar.Size = new System.Drawing.Size(75, 23);
            this.btSalvar.TabIndex = 10;
            this.btSalvar.Text = "Salvar";
            this.btSalvar.UseVisualStyleBackColor = true;
            this.btSalvar.Click += new System.EventHandler(this.btSalvar_Click);
            // 
            // btSair
            // 
            this.btSair.Location = new System.Drawing.Point(203, 97);
            this.btSair.Name = "btSair";
            this.btSair.Size = new System.Drawing.Size(75, 23);
            this.btSair.TabIndex = 11;
            this.btSair.Text = "Sair";
            this.btSair.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btSair.UseVisualStyleBackColor = true;
            this.btSair.Click += new System.EventHandler(this.btSair_Click);
            // 
            // ConfigDBForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(293, 152);
            this.ControlBox = false;
            this.Controls.Add(this.btSair);
            this.Controls.Add(this.btSalvar);
            this.Controls.Add(this.txSenha);
            this.Controls.Add(this.txUser);
            this.Controls.Add(this.txBanco);
            this.Controls.Add(this.txPorta);
            this.Controls.Add(this.txServidor);
            this.Controls.Add(this.lbBanco);
            this.Controls.Add(this.lbUser);
            this.Controls.Add(this.lbPorta);
            this.Controls.Add(this.lbSenha);
            this.Controls.Add(this.lbServidor);
            this.Name = "ConfigDBForm";
            this.Load += new System.EventHandler(this.FrmConfigDB_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbServidor;
        private System.Windows.Forms.Label lbSenha;
        private System.Windows.Forms.Label lbPorta;
        private System.Windows.Forms.Label lbUser;
        private System.Windows.Forms.Label lbBanco;
        public System.Windows.Forms.TextBox txServidor;
        public System.Windows.Forms.TextBox txPorta;
        public System.Windows.Forms.TextBox txBanco;
        public System.Windows.Forms.TextBox txUser;
        public System.Windows.Forms.TextBox txSenha;
        public System.Windows.Forms.Button btSalvar;
        private System.Windows.Forms.Button btSair;
    }
}