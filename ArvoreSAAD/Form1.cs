using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArvoreSAAD
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ArrayList combo = new ArrayList();
            combo.Add(new drop("Sunny", "Sunny"));
            combo.Add(new drop("OverCast", "OverCast"));
            combo.Add(new drop("Rain", "Rain"));
            cboTempo.DataSource = combo;
            cboTempo.DisplayMember = "Nome";
            cboTempo.ValueMember = "Valor";

            ArrayList comboTemp = new ArrayList();
            comboTemp.Add(new drop("Hot", "Hot"));
            comboTemp.Add(new drop("Mild", "Mild"));
            comboTemp.Add(new drop("Cool", "Cool"));
            cboTemperatura.DataSource = comboTemp;
            cboTemperatura.DisplayMember = "Nome";
            cboTemperatura.ValueMember = "Valor";


            ArrayList comboHumi = new ArrayList();
            comboHumi.Add(new drop("High", "High"));
            comboHumi.Add(new drop("Normal","Normal"));
            cboUmidade.DataSource = comboHumi;
            cboUmidade.DisplayMember = "Nome";
            cboUmidade.ValueMember = "Valor";

            ArrayList comboVento = new ArrayList();
            comboVento.Add(new drop("Strong", "Strong"));
            comboVento.Add(new drop("Weak", "Weak"));
            cboVento.DataSource = comboVento;
            cboVento.DisplayMember = "Nome";
            cboVento.ValueMember = "Valor";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void buttonPlayTennis_Click(object sender, EventArgs e)
        {
            PlayTennis play = new PlayTennis();
            string temperatura = (string) cboTemperatura.SelectedValue;
            string tempo = (string) cboTempo.SelectedValue;
            string umidade = (string) cboUmidade.SelectedValue;
            string vento = (string) cboVento.SelectedValue;

            if (play.possoJogar(tempo,umidade,temperatura,vento))
            {
                MessageBox.Show("Pode Jogar Sim!");
            }
            else
            {
                MessageBox.Show("Não pode Jogar");
            }
            
        }
    }
}
