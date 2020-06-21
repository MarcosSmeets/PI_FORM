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
    public partial class Vacina : Form
    {
        private MySqlConnection mConn;
        private MySqlDataAdapter mAdapter;
        private DataSet mDataSet;

        public Vacina()
        {
            InitializeComponent();
        }

        private void Cadastrar_Click(object sender, EventArgs e)
        {
            mConn = new MySqlConnection("Persist Security Into=False; server=localhost; database=CTRL_VACINA;uid=root");

            mConn.Open();

            string consultasql =
                String.Format("INSERT INTO VACINA ('PAIS_ORG_VACINA', 'DATA_FAB_VACINA', 'NOME_VACINA', 'VALID_VACINA') values ('{0}', '{1}', '{2}','{3}')",
                txtPais.Text, txtFab.Text,txtNome, txtValid.Text);

            MySqlCommand command = new MySqlCommand(consultasql, mConn);
            command.ExecuteNonQuery();

            mConn.Close();
        }

        private void Consultar_Click(object sender, EventArgs e)
        {
            mDataSet = new DataSet();

            mConn = new MySqlConnection("Persist Security Into=False; server=localhost; database=CTRL_VACINA;uid=root");

            mConn.Open();

            
            try
            {
                mAdapter = new MySqlDataAdapter("SELECT * FROM VACINA WHERE upper(NOME_VACINA) like upper({txtNome.Text})", mConn);
            }
            catch
            {
                MessageBox.Show("Vacina não cadastrada.");
            }

            mAdapter.Fill(mDataSet, "vacina");

            dataGridView1.DataSource = mDataSet;
            dataGridView1.DataMember = "vacina";
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
