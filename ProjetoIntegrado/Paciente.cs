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
    public partial class Paciente : Form
    {
        private MySqlConnection mConn;
        private MySqlDataAdapter mAdapter;
        private DataSet mDataSet;

        public Paciente()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            mConn = new MySqlConnection("Persist Security Into=False; server=localhost; database=CTRL_VACINA;uid=root");

            mConn.Open();

            string consultasql =
                String.Format("INSERT INTO Paciente ('CPF_PACIENTE', 'NOME_PACIENTE', 'END_PACIENTE', 'DATA-NASCT_PACIENTE') values ('{0}', '{1}', '{2}', '{3}')",
                txtCpf.Text, txtNome.Text, txtEnd.Text, txtData.Text);

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
                mAdapter = new MySqlDataAdapter("select  A.COD_PACIENTE, A.CPF_PACIENTE, A.NOME_PACIENTE, A.END_PACIENTE, A.DATA_NASCT_PACIENTE, C.NOME_VACINA, C.VALID_VACINA, E.NOME_HOSPITAL from paciente A inner join registro B on A.COD_PACIENTE = B.PACIENTE_COD_PACIENTE inner join vacina C on C.COD_VACINA = B.VACINA_COD_VACINA inner join vacina_hospital D on D.VACINA_COD_VACINA = C.COD_VACINA inner join hospital E on E.COD_HOSPITAL = D.HOSPITAL_COD_HOSPITAL WHERE (A.CPF_PACIENTE = txtCpf.Text or upper(NOME_PACIENTE) like upper ('%txtNome.Text%'))", mConn);
            }
            catch
            {
                MessageBox.Show("Paciente não Cadastrado Ou Dados incorretos");

            }
            

            mAdapter.Fill(mDataSet, "paciente");

            dataGridView1.DataSource = mDataSet;
            dataGridView1.DataMember = "paciente";
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
