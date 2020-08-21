using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TransaccionPao
{
    public partial class Form2 : Form
    {

        public Form2()
        {
            InitializeComponent();
        }


        ConexionDb conectandose = new ConexionDb();
        private void button4_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = conectandose.Consultar();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                conectandose.NuevoCliente(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, Convert.ToInt32(textBox5.Text));
            }
            catch
            {
                MessageBox.Show("Sus datos son incorrectos");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                conectandose.EditarCliente(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, Convert.ToInt32(textBox5.Text));
            }
            catch
            {
                MessageBox.Show("Sus datos son incorrectos");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                conectandose.EliminarCliente(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, Convert.ToInt32(textBox5.Text));
            }
            catch
            {
                MessageBox.Show("Sus datos se eliminaron correctamente");
            }
        }

    }
}
