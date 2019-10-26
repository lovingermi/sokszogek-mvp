using Sokszogek_MVP.Presenters;
using Sokszogek_MVP.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sokszogek_MVP
{
    public partial class Form1 : Form,ISokszogView,IHaromszog,INegyzetView
    {
        private SokszogPresenter presenter;
        public Form1()
        {
            presenter = new SokszogPresenter(this,this,this);


            InitializeComponent();
        }

        public string oldalA
        {
            get => textBoxOldalA.Text;
            set => textBoxOldalA.Text = value;
        }
        public string oldalB
        {
            get => textBoxOldalB.Text;
            set => textBoxOldalB.Text = value;
        }
        public string Kerulet
        {
            get => textBoxKerulet.Text;
            set => textBoxKerulet.Text = value;
        }
        public string Terulet
        {
            get => textBoxTerulet.Text;
            set => textBoxTerulet.Text = value;
        }
        public IList<string> SokszogList
        {
            get => (List<string>)comboBoxSokszog.DataSource;
            set => comboBoxSokszog.DataSource = value;
        }
        public string oldalC
        {
            get => textBoxOldalC.Text;
            set => textBoxOldalC.Text = value;
        }

        private void buttonSzamol_Click(object sender, EventArgs e)
        {
            presenter.Calculate();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            presenter.LoadData();
            textBoxOldalC.Hide();
            labelOldalC.Hide();
            textBoxOldalB.Hide();
            labelOldalB.Hide();
        }

        private void comboBoxSokszog_SelectedIndexChanged(object sender, EventArgs e)
        {
            presenter.ShowOldal(comboBoxSokszog.SelectedIndex);
            if (!presenter.oldal_B_Letezik)
            {
                textBoxOldalB.Hide();
                labelOldalB.Hide();
            }
            else
            {
                textBoxOldalB.Show();
                labelOldalB.Show();
            }
            if (!presenter.oldal_C_Letezik)
            {
                textBoxOldalC.Hide();
                labelOldalC.Hide();
            }
            else
            {
                textBoxOldalC.Show();
                labelOldalC.Show();
            }
        }
    }
}
