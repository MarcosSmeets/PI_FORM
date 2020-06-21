namespace ProjetoIntegrado
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.Vacina = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.Fornecedor = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Hospital = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.panelConteiner = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.Vacina);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.Fornecedor);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.Hospital);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 448);
            this.panel1.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel5.Location = new System.Drawing.Point(0, 264);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(21, 40);
            this.panel5.TabIndex = 5;
            // 
            // Vacina
            // 
            this.Vacina.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Vacina.FlatAppearance.BorderSize = 0;
            this.Vacina.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Vacina.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Vacina.ForeColor = System.Drawing.Color.White;
            this.Vacina.Location = new System.Drawing.Point(12, 264);
            this.Vacina.Name = "Vacina";
            this.Vacina.Size = new System.Drawing.Size(188, 40);
            this.Vacina.TabIndex = 6;
            this.Vacina.Text = "Vacina";
            this.Vacina.UseVisualStyleBackColor = false;
            this.Vacina.Click += new System.EventHandler(this.Vacina_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel4.Location = new System.Drawing.Point(0, 193);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(21, 40);
            this.panel4.TabIndex = 3;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // Fornecedor
            // 
            this.Fornecedor.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Fornecedor.FlatAppearance.BorderSize = 0;
            this.Fornecedor.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Fornecedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Fornecedor.ForeColor = System.Drawing.Color.White;
            this.Fornecedor.Location = new System.Drawing.Point(12, 193);
            this.Fornecedor.Name = "Fornecedor";
            this.Fornecedor.Size = new System.Drawing.Size(188, 40);
            this.Fornecedor.TabIndex = 4;
            this.Fornecedor.Text = "Fornecedor";
            this.Fornecedor.UseVisualStyleBackColor = false;
            this.Fornecedor.Click += new System.EventHandler(this.Fornecedor_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel3.Location = new System.Drawing.Point(0, 116);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(21, 40);
            this.panel3.TabIndex = 1;
            // 
            // Hospital
            // 
            this.Hospital.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Hospital.FlatAppearance.BorderSize = 0;
            this.Hospital.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Hospital.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Hospital.ForeColor = System.Drawing.Color.White;
            this.Hospital.Location = new System.Drawing.Point(12, 116);
            this.Hospital.Name = "Hospital";
            this.Hospital.Size = new System.Drawing.Size(188, 40);
            this.Hospital.TabIndex = 2;
            this.Hospital.Text = "Hospital";
            this.Hospital.UseVisualStyleBackColor = false;
            this.Hospital.Click += new System.EventHandler(this.Hospital_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel2.Location = new System.Drawing.Point(0, 45);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(21, 40);
            this.panel2.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveBorder;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(12, 45);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(188, 40);
            this.button1.TabIndex = 0;
            this.button1.Text = "Paciente";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panelConteiner
            // 
            this.panelConteiner.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panelConteiner.Location = new System.Drawing.Point(197, 0);
            this.panelConteiner.Name = "panelConteiner";
            this.panelConteiner.Size = new System.Drawing.Size(878, 448);
            this.panelConteiner.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1077, 450);
            this.Controls.Add(this.panelConteiner);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelConteiner;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button Hospital;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button Fornecedor;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button Vacina;
    }
}

