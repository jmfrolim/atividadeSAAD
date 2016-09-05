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





        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            ArrayList comboTemp = new ArrayList();
            comboTemp.Add("Hot");
            comboTemp.Add("Mild");
            comboTemp.Add("Cool");
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            ArrayList comboHumi = new ArrayList();
            comboHumi.Add("High");
            comboHumi.Add("Normal");
        }
    }
}
