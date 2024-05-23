namespace Trabalho_Banco_De_Dados
{
    partial class frmCliente
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
            this.components = new System.ComponentModel.Container();
            this.label7 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.btnSalvarC = new System.Windows.Forms.Button();
            this.txtNomeCli = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.statusStrip2 = new System.Windows.Forms.StatusStrip();
            this.ToolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.txtIdade = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.mtxPhone = new System.Windows.Forms.MaskedTextBox();
            this.txtAltura = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mtxCPF = new System.Windows.Forms.MaskedTextBox();
            this.statusStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(283, 147);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 15);
            this.label7.TabIndex = 55;
            this.label7.Text = "Nome Completo";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 23F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label16.Location = new System.Drawing.Point(351, 64);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(286, 35);
            this.label16.TabIndex = 53;
            this.label16.Text = "Cadastro de Cliente";
            // 
            // btnSalvarC
            // 
            this.btnSalvarC.BackColor = System.Drawing.Color.White;
            this.btnSalvarC.Location = new System.Drawing.Point(477, 367);
            this.btnSalvarC.Name = "btnSalvarC";
            this.btnSalvarC.Size = new System.Drawing.Size(75, 23);
            this.btnSalvarC.TabIndex = 52;
            this.btnSalvarC.Text = "Salvar";
            this.btnSalvarC.UseVisualStyleBackColor = false;
            this.btnSalvarC.Click += new System.EventHandler(this.btnSalvarC_Click);
            // 
            // txtNomeCli
            // 
            this.txtNomeCli.Location = new System.Drawing.Point(386, 142);
            this.txtNomeCli.MaxLength = 60;
            this.txtNomeCli.Name = "txtNomeCli";
            this.txtNomeCli.Size = new System.Drawing.Size(285, 20);
            this.txtNomeCli.TabIndex = 48;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label18.Location = new System.Drawing.Point(345, 199);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(30, 15);
            this.label18.TabIndex = 47;
            this.label18.Text = "CPF";
            // 
            // statusStrip2
            // 
            this.statusStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripStatusLabel2,
            this.toolStripStatusLabel1});
            this.statusStrip2.Location = new System.Drawing.Point(0, 413);
            this.statusStrip2.Name = "statusStrip2";
            this.statusStrip2.Size = new System.Drawing.Size(969, 22);
            this.statusStrip2.TabIndex = 58;
            this.statusStrip2.Text = "statusStrip1";
            this.statusStrip2.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.statusStrip2_ItemClicked);
            // 
            // ToolStripStatusLabel2
            // 
            this.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2";
            this.ToolStripStatusLabel2.Size = new System.Drawing.Size(0, 17);
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Click += new System.EventHandler(this.toolStripStatusLabel1_Click);
            // 
            // txtIdade
            // 
            this.txtIdade.Location = new System.Drawing.Point(386, 168);
            this.txtIdade.MaxLength = 50;
            this.txtIdade.Name = "txtIdade";
            this.txtIdade.Size = new System.Drawing.Size(87, 20);
            this.txtIdade.TabIndex = 60;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(345, 168);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 15);
            this.label1.TabIndex = 59;
            this.label1.Text = "Idade";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(520, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 15);
            this.label2.TabIndex = 61;
            this.label2.Text = "Altura em cm";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(326, 225);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 15);
            this.label3.TabIndex = 63;
            this.label3.Text = "Contato";
            // 
            // mtxPhone
            // 
            this.mtxPhone.Location = new System.Drawing.Point(386, 224);
            this.mtxPhone.Mask = "(99) 00000-0000";
            this.mtxPhone.Name = "mtxPhone";
            this.mtxPhone.Size = new System.Drawing.Size(87, 20);
            this.mtxPhone.TabIndex = 64;
            // 
            // txtAltura
            // 
            this.txtAltura.Location = new System.Drawing.Point(605, 168);
            this.txtAltura.Name = "txtAltura";
            this.txtAltura.Size = new System.Drawing.Size(66, 20);
            this.txtAltura.TabIndex = 65;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // mtxCPF
            // 
            this.mtxCPF.Location = new System.Drawing.Point(386, 198);
            this.mtxCPF.Mask = "000.000.000-00";
            this.mtxCPF.Name = "mtxCPF";
            this.mtxCPF.Size = new System.Drawing.Size(87, 20);
            this.mtxCPF.TabIndex = 67;
            // 
            // frmCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(969, 435);
            this.Controls.Add(this.mtxCPF);
            this.Controls.Add(this.txtAltura);
            this.Controls.Add(this.mtxPhone);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtIdade);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.statusStrip2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.btnSalvarC);
            this.Controls.Add(this.txtNomeCli);
            this.Controls.Add(this.label18);
            this.Name = "frmCliente";
            this.Text = "frmCliente";
            this.Load += new System.EventHandler(this.frmCliente_Load);
            this.statusStrip2.ResumeLayout(false);
            this.statusStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button btnSalvarC;
        private System.Windows.Forms.TextBox txtNomeCli;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.StatusStrip statusStrip2;
        private System.Windows.Forms.ToolStripStatusLabel ToolStripStatusLabel2;
        private System.Windows.Forms.TextBox txtIdade;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox mtxPhone;
        private System.Windows.Forms.TextBox txtAltura;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.MaskedTextBox mtxCPF;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
    }
}