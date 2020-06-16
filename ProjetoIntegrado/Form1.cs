﻿using System;
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

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            mConn = new MySqlConnection("Persist Security Into=False; server=localhost; database=CTRL_VACINA;uid=root");

            mConn.Open();

            string consultasql =
                String.Format("INSERT INTO (CPF-PACIENTE, NOME-PACIENTE, END-PACIENTE, DATA-NASCT-PACIENTE) values ('{0}', '{1}', '{2}', {3})",
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

            mAdapter = new MySqlDataAdapter("SELECT * FROM PACIENTE ORDER BY id", mConn);

            mAdapter.Fill(mDataSet, "paciente");

            dataGridView1.DataSource = mDataSet;
            dataGridView1.DataMember = "paciente";

        }
    }
}