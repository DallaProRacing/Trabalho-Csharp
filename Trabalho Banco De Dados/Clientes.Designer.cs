namespace Trabalho_Banco_De_Dados
{
    partial class Clientes
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
            this.statusStrip2 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.btnBuscarC = new System.Windows.Forms.Button();
            this.btnRecarregarC = new System.Windows.Forms.Button();
            this.cbxBuscarC = new System.Windows.Forms.ComboBox();
            this.btnAlterarC = new System.Windows.Forms.Button();
            this.btnAdicionarC = new System.Windows.Forms.Button();
            this.txtbuscarC = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.imageList3 = new System.Windows.Forms.ImageList(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.statusStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.toolStripContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip2
            // 
            this.statusStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel2});
            this.statusStrip2.Location = new System.Drawing.Point(0, 413);
            this.statusStrip2.Name = "statusStrip2";
            this.statusStrip2.Size = new System.Drawing.Size(969, 22);
            this.statusStrip2.TabIndex = 17;
            this.statusStrip2.Text = "statusStrip1";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(66, 17);
            this.toolStripStatusLabel2.Text = "Mensagem";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(153, 41);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(641, 340);
            this.dataGridView2.TabIndex = 16;
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(150, 150);
            this.toolStripContainer1.Location = new System.Drawing.Point(-3, 260);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.Size = new System.Drawing.Size(150, 175);
            this.toolStripContainer1.TabIndex = 15;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // btnBuscarC
            // 
            this.btnBuscarC.Location = new System.Drawing.Point(689, 12);
            this.btnBuscarC.Name = "btnBuscarC";
            this.btnBuscarC.Size = new System.Drawing.Size(118, 23);
            this.btnBuscarC.TabIndex = 14;
            this.btnBuscarC.Text = "Buscar";
            this.btnBuscarC.UseVisualStyleBackColor = true;
            this.btnBuscarC.Click += new System.EventHandler(this.btnBuscarC_Click);
            // 
            // btnRecarregarC
            // 
            this.btnRecarregarC.Location = new System.Drawing.Point(865, 12);
            this.btnRecarregarC.Name = "btnRecarregarC";
            this.btnRecarregarC.Size = new System.Drawing.Size(75, 23);
            this.btnRecarregarC.TabIndex = 24;
            this.btnRecarregarC.Text = "Recarregar";
            this.btnRecarregarC.UseVisualStyleBackColor = true;
            this.btnRecarregarC.Click += new System.EventHandler(this.btnRecarregarC_Click);
            // 
            // cbxBuscarC
            // 
            this.cbxBuscarC.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.cbxBuscarC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxBuscarC.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxBuscarC.FormattingEnabled = true;
            this.cbxBuscarC.Items.AddRange(new object[] {
            "NomeCli",
            "Idade",
            "CPF",
            "Altura",
            "Contato"});
            this.cbxBuscarC.Location = new System.Drawing.Point(363, 12);
            this.cbxBuscarC.Name = "cbxBuscarC";
            this.cbxBuscarC.Size = new System.Drawing.Size(118, 23);
            this.cbxBuscarC.TabIndex = 21;
            // 
            // btnAlterarC
            // 
            this.btnAlterarC.BackColor = System.Drawing.Color.Yellow;
            this.btnAlterarC.Location = new System.Drawing.Point(622, 387);
            this.btnAlterarC.Name = "btnAlterarC";
            this.btnAlterarC.Size = new System.Drawing.Size(75, 23);
            this.btnAlterarC.TabIndex = 20;
            this.btnAlterarC.Text = "Alterar";
            this.btnAlterarC.UseVisualStyleBackColor = false;
            this.btnAlterarC.Click += new System.EventHandler(this.btnAlterarC_Click);
            // 
            // btnAdicionarC
            // 
            this.btnAdicionarC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnAdicionarC.Location = new System.Drawing.Point(719, 387);
            this.btnAdicionarC.Name = "btnAdicionarC";
            this.btnAdicionarC.Size = new System.Drawing.Size(75, 23);
            this.btnAdicionarC.TabIndex = 19;
            this.btnAdicionarC.Text = "Adicionar";
            this.btnAdicionarC.UseVisualStyleBackColor = false;
            this.btnAdicionarC.Click += new System.EventHandler(this.btnAdicionarC_Click);
            // 
            // txtbuscarC
            // 
            this.txtbuscarC.AccessibleDescription = "";
            this.txtbuscarC.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtbuscarC.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbuscarC.Location = new System.Drawing.Point(487, 12);
            this.txtbuscarC.Name = "txtbuscarC";
            this.txtbuscarC.Size = new System.Drawing.Size(196, 23);
            this.txtbuscarC.TabIndex = 18;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(21, 12);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(919, 23);
            this.textBox2.TabIndex = 22;
            this.textBox2.Text = "                                                                                 " +
    "         Filtrar por:";
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // imageList2
            // 
            this.imageList2.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList2.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // imageList3
            // 
            this.imageList3.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList3.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList3.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.pictureBox1.Location = new System.Drawing.Point(12, 41);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(919, 340);
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            // 
            // Clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(969, 435);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.statusStrip2);
            this.Controls.Add(this.toolStripContainer1);
            this.Controls.Add(this.btnBuscarC);
            this.Controls.Add(this.btnRecarregarC);
            this.Controls.Add(this.cbxBuscarC);
            this.Controls.Add(this.btnAlterarC);
            this.Controls.Add(this.btnAdicionarC);
            this.Controls.Add(this.txtbuscarC);
            this.Controls.Add(this.textBox2);
            this.Name = "Clientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clientes";
            this.Load += new System.EventHandler(this.Clientes_Load);
            this.statusStrip2.ResumeLayout(false);
            this.statusStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.Button btnBuscarC;
        private System.Windows.Forms.Button btnRecarregarC;
        private System.Windows.Forms.ComboBox cbxBuscarC;
        private System.Windows.Forms.Button btnAlterarC;
        private System.Windows.Forms.Button btnAdicionarC;
        private System.Windows.Forms.TextBox txtbuscarC;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ImageList imageList2;
        private System.Windows.Forms.ImageList imageList3;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}