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

    public partial class Hospital : Form
    {
        private MySqlConnection mConn;
        private MySqlDataAdapter mAdapter;
        private DataSet mDataSet;


        public Hospital()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            mConn = new MySqlConnection("Persist Security Into=False; server=localhost; database=CTRL_VACINA;uid=root");

            mConn.Open();

            string consultasql = String.Format("INSERT INTO HOSPITAL ('CNPJ_HOSPITAL', 'NOME_HOSPITAL', 'END_HOSPITAL') Values ('{0}', '{1}','{2}')",
                txtCNPJ.Text, txtNome.Text, txtEnd.Text);

            MySqlCommand command = new MySqlCommand(consultasql, mConn);
            command.ExecuteNonQuery();

            mConn.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            mDataSet = new DataSet();

            mConn = new MySqlConnection("Persist Security Into=False; server=localhost; database=CTRL_VACINA;uid=root");

            mConn.Open();

            
            try
            {
                mAdapter = new MySqlDataAdapter("SELECT * FROM Hospital WHERE upper (NOME_HOSPITAL) upper ({txtNome.Text})", mConn);
            }
            catch
            {
                MessageBox.Show("Hospital não cadastrado.");
            }

            mAdapter.Fill(mDataSet,"hospital");

            dataGridView1.DataSource = mDataSet;
            dataGridView1.DataMember = "hospital";
        }
    }
}
