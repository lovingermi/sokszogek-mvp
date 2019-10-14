using sokszogek_mvp.view;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sokszogek_mvp
{
    public partial class Form1 : Form ,iSokszog
    {
        public Form1()
        {
            InitializeComponent();
        }

        public string oldalA { get => textBoxOldalA.Text; set => textBoxOldalA.Text=value; }
        public string oldalB { get => textBoxOldalB.Text; set => textBoxOldalB.Text = value; }
        public string Kerulet { get => textBoxKerulet.Text; set => textBoxKerulet.Text = value; }
        public string Terulet { get => textBoxTerulet.Text; set => textBoxTerulet.Text = value; }
        public IList<string> SokszogList { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        private void Form1_Load(object sender, EventArgs e)
        {
            ///
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonKiszamol_Click(object sender, EventArgs e)
        {

        }
    }
}
