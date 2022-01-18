using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ukol1retezce
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sifra;
            int okolik = int.Parse(textBox1.Text);
            string zasifrovat = textBox2.Text;
            int vys = zasifrovat.Length;
            for (int i = 0; i < vys; i++)
            {
                sifra = zasifrovat + okolik;
            }
            label_sifra = sifra.To;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
