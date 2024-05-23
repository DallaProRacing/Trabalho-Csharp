namespace Trabalho_Banco_De_Dados
{
    partial class FrmResultados
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
            this.dataGridViewVendas = new System.Windows.Forms.DataGridView();
            this.btnVerVendas = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVendas)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewVendas
            // 
            this.dataGridViewVendas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewVendas.Location = new System.Drawing.Point(154, 51);
            this.dataGridViewVendas.Name = "dataGridViewVendas";
            this.dataGridViewVendas.Size = new System.Drawing.Size(743, 362);
            this.dataGridViewVendas.TabIndex = 0;
            this.dataGridViewVendas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewVendas_CellClick_1);
            this.dataGridViewVendas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewVendas_CellContentClick);
            // 
            // btnVerVendas
            // 
            this.btnVerVendas.Location = new System.Drawing.Point(16, 51);
            this.btnVerVendas.Name = "btnVerVendas";
            this.btnVerVendas.Size = new System.Drawing.Size(94, 27);
            this.btnVerVendas.TabIndex = 1;
            this.btnVerVendas.Text = "Colsultar Vendas";
            this.btnVerVendas.UseVisualStyleBackColor = true;
            this.btnVerVendas.Click += new System.EventHandler(this.button1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(16, 84);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 27);
            this.button1.TabIndex = 2;
            this.button1.Text = "Gerar Nota";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GrayText;
            this.panel1.Controls.Add(this.btnVerVendas);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(-4, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(124, 441);
            this.panel1.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.GrayText;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(-1, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(984, 32);
            this.panel2.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(384, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(244, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Resultado da Concessionária";
            // 
            // FrmResultados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(969, 435);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridViewVendas);
            this.MaximizeBox = false;
            this.Name = "FrmResultados";
            this.Text = "FrmResultados";
            this.Load += new System.EventHandler(this.FrmResultados_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVendas)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewVendas;
        private System.Windows.Forms.Button btnVerVendas;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
    }
}