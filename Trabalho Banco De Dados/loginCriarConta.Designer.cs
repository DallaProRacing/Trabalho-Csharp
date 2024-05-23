namespace Trabalho_Banco_De_Dados
{
    partial class loginCriarConta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(loginCriarConta));
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnSalvarUsuario = new System.Windows.Forms.Button();
            this.txtSenhaCadastro = new System.Windows.Forms.TextBox();
            this.txtUsuarioCadastro = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.checkBox1.Location = new System.Drawing.Point(816, 224);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(93, 17);
            this.checkBox1.TabIndex = 27;
            this.checkBox1.Text = "Mostrar senha";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.SlateGray;
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSair.Location = new System.Drawing.Point(825, 288);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(84, 32);
            this.btnSair.TabIndex = 25;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnSalvarUsuario
            // 
            this.btnSalvarUsuario.BackColor = System.Drawing.Color.Blue;
            this.btnSalvarUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvarUsuario.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSalvarUsuario.Location = new System.Drawing.Point(726, 288);
            this.btnSalvarUsuario.Name = "btnSalvarUsuario";
            this.btnSalvarUsuario.Size = new System.Drawing.Size(84, 32);
            this.btnSalvarUsuario.TabIndex = 24;
            this.btnSalvarUsuario.Text = "Salvar";
            this.btnSalvarUsuario.UseVisualStyleBackColor = false;
            this.btnSalvarUsuario.Click += new System.EventHandler(this.btmCadastrarU_Click);
            // 
            // txtSenhaCadastro
            // 
            this.txtSenhaCadastro.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtSenhaCadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenhaCadastro.Location = new System.Drawing.Point(726, 198);
            this.txtSenhaCadastro.Name = "txtSenhaCadastro";
            this.txtSenhaCadastro.PasswordChar = '*';
            this.txtSenhaCadastro.Size = new System.Drawing.Size(183, 21);
            this.txtSenhaCadastro.TabIndex = 22;
            // 
            // txtUsuarioCadastro
            // 
            this.txtUsuarioCadastro.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtUsuarioCadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuarioCadastro.Location = new System.Drawing.Point(726, 125);
            this.txtUsuarioCadastro.Name = "txtUsuarioCadastro";
            this.txtUsuarioCadastro.Size = new System.Drawing.Size(183, 21);
            this.txtUsuarioCadastro.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(723, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 17);
            this.label3.TabIndex = 20;
            this.label3.Text = "Senha";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(723, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 17);
            this.label2.TabIndex = 19;
            this.label2.Text = "Usuário";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(23, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(627, 412);
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 23F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(684, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(233, 70);
            this.label1.TabIndex = 17;
            this.label1.Text = "     Cadastro \r\n de Colaborador";
            // 
            // loginCriarConta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(969, 435);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnSalvarUsuario);
            this.Controls.Add(this.txtSenhaCadastro);
            this.Controls.Add(this.txtUsuarioCadastro);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Name = "loginCriarConta";
            this.Text = "loginCriarConta";
            this.Load += new System.EventHandler(this.loginCriarConta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnSalvarUsuario;
        private System.Windows.Forms.TextBox txtSenhaCadastro;
        private System.Windows.Forms.TextBox txtUsuarioCadastro;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
    }
}