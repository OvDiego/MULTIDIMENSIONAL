using System;
using System.Windows.Forms;

namespace FormMultidimensional
{
    public partial class Form1 : Form
    {
        private bool Intro = true;
        private Multidimensional m1;
        private Multidimensional m2;
        private Multidimensional m3;
        private Multidimensional m4;


        public Form1()
        {
            InitializeComponent();
        }

        private void btnIntro_Click(object sender, EventArgs e)
        {
            if (Intro)
            {
                m1 = Multidimensional.Leer(txtbDisplay.Text);
                lbMatriz1.Text = m1.ToString();
                Intro = false;
               
            }
            else
            {
                m2 = Multidimensional.Leer(txtbDisplay.Text);   
                lbMatriz2.Text = m2.ToString();
                Intro=true;
            }
            txtbDisplay.Clear();
           

        }

        private void btnSuma_Click(object sender, EventArgs e)
        {
           
            m3 = m1 + m2;
            lbResultado.Text = m3.ToString();
        }

        private void btnRestar_Click(object sender, EventArgs e)
        {
            
            m3 = m1 - m2;
            lbResultado.Text = m3.ToString();
        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            m3 = m1 * m2;
            lbResultado.Text = m3.ToString();
        }

        private void btnSen_Click(object sender, EventArgs e)
        {
            if (rdbDeg.Checked)
            {
                MessageBox.Show("Seleccionaste Deg");
            }
            m4 =~m3;
            lbResultado.Text = m4.ToString();
        }
    }
}
