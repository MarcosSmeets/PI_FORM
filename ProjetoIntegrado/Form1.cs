using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ProjetoIntegrado
{
    public partial class Form1 : Form
    {
        private MySqlConnection mConn;
        private MySqlDataAdapter mAdapter;
        private DataSet mDataSet;


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        

        private void AbrirFormHija(object formhija)
        {
            if(this.panelConteiner.Controls.Count > 0)
                this.panelConteiner.Controls.RemoveAt(0);
            

            Form fh = formhija as Form;

            fh.TopLevel = false;

            fh.Dock = DockStyle.Fill;

            this.panelConteiner.Controls.Add(fh);
            this.panelConteiner.Tag = fh;
            fh.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new Paciente());
        }

        private void Hospital_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new Hospital());
        }

        private void Fornecedor_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new Fornecedor());
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Vacina_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new Vacina());
        }
    }
}
