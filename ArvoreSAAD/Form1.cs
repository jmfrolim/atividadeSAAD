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
            PlayTennis play = new PlayTennis();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ArrayList combo = new ArrayList();
            combo.Add(new drop("Sunny", 1));
            combo.Add(new drop("Overcast", 2));
            combo.Add(new drop("Rain", 3));
            cboTempo.DataSource = combo;
            cboTempo.DisplayMember = "Nome";
            cboTempo.ValueMember = "Valor";

            ArrayList comboTemp = new ArrayList();
            comboTemp.Add(new drop("Hot",1));
            comboTemp.Add(new drop("Mild",3));
            comboTemp.Add(new drop("Cool",3));
            cboTemperatura.DataSource = comboTemp;
            cboTemperatura.DisplayMember = "Nome";
            cboTemperatura.ValueMember = "Valor";


            ArrayList comboHumi = new ArrayList();
            comboHumi.Add(new drop("High",1));
            comboHumi.Add(new drop("Normal",2));
            cboHumidade.DataSource = comboHumi;
            cboHumidade.DisplayMember = "Nome";
            cboHumidade.ValueMember = "Valor";

            ArrayList comboVento = new ArrayList();
            comboVento.Add(new drop("Strong", 1));
            comboVento.Add(new drop("Weak", 2));
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
    }
}
