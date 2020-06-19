namespace ProjetoIntegrado
{
    partial class Vacina
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PaisOrigem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataFab = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValidadVacina = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPais = new System.Windows.Forms.TextBox();
            this.txtFab = new System.Windows.Forms.TextBox();
            this.txtValid = new System.Windows.Forms.TextBox();
            this.Cadastrar = new System.Windows.Forms.Button();
            this.Consultar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.PaisOrigem,
            this.DataFab,
            this.ValidadVacina});
            this.dataGridView1.Location = new System.Drawing.Point(12, 199);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(776, 245);
            this.dataGridView1.TabIndex = 0;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "COD-VACINA";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            // 
            // PaisOrigem
            // 
            this.PaisOrigem.DataPropertyName = "PAIS-ORG-VACINA";
            this.PaisOrigem.HeaderText = "Pais de Origem";
            this.PaisOrigem.Name = "PaisOrigem";
            // 
            // DataFab
            // 
            this.DataFab.DataPropertyName = "DATA-FAB-VACINA";
            this.DataFab.HeaderText = "Data de Fabricação";
            this.DataFab.Name = "DataFab";
            // 
            // ValidadVacina
            // 
            this.ValidadVacina.DataPropertyName = "VALID-VACINA";
            this.ValidadVacina.HeaderText = "Data de Validade";
            this.ValidadVacina.Name = "ValidadVacina";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Pais de Origem";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Data de Fabricação";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Data de Validade";
            // 
            // txtPais
            // 
            this.txtPais.Location = new System.Drawing.Point(155, 40);
            this.txtPais.Name = "txtPais";
            this.txtPais.Size = new System.Drawing.Size(100, 20);
            this.txtPais.TabIndex = 4;
            // 
            // txtFab
            // 
            this.txtFab.Location = new System.Drawing.Point(155, 74);
            this.txtFab.Name = "txtFab";
            this.txtFab.Size = new System.Drawing.Size(100, 20);
            this.txtFab.TabIndex = 5;
            // 
            // txtValid
            // 
            this.txtValid.Location = new System.Drawing.Point(155, 115);
            this.txtValid.Name = "txtValid";
            this.txtValid.Size = new System.Drawing.Size(100, 20);
            this.txtValid.TabIndex = 6;
            // 
            // Cadastrar
            // 
            this.Cadastrar.Location = new System.Drawing.Point(343, 160);
            this.Cadastrar.Name = "Cadastrar";
            this.Cadastrar.Size = new System.Drawing.Size(124, 33);
            this.Cadastrar.TabIndex = 7;
            this.Cadastrar.Text = "Cadastrar";
            this.Cadastrar.UseVisualStyleBackColor = true;
            this.Cadastrar.Click += new System.EventHandler(this.Cadastrar_Click);
            // 
            // Consultar
            // 
            this.Consultar.Location = new System.Drawing.Point(576, 160);
            this.Consultar.Name = "Consultar";
            this.Consultar.Size = new System.Drawing.Size(124, 33);
            this.Consultar.TabIndex = 8;
            this.Consultar.Text = "Consultar";
            this.Consultar.UseVisualStyleBackColor = true;
            this.Consultar.Click += new System.EventHandler(this.Consultar_Click);
            // 
            // Vacina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Consultar);
            this.Controls.Add(this.Cadastrar);
            this.Controls.Add(this.txtValid);
            this.Controls.Add(this.txtFab);
            this.Controls.Add(this.txtPais);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Vacina";
            this.Text = "Vacina";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn PaisOrigem;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataFab;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValidadVacina;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPais;
        private System.Windows.Forms.TextBox txtFab;
        private System.Windows.Forms.TextBox txtValid;
        private System.Windows.Forms.Button Cadastrar;
        private System.Windows.Forms.Button Consultar;
    }
}