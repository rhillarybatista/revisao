using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace revisao
{
    public partial class divisao : Form
    {
        public divisao()
        {
            InitializeComponent();
            lbresul.Text = " ";
        }

        private void divisao_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int a = Convert.ToInt32(textBox1.Text);
                int b = Convert.ToInt32(textBox2.Text);

                int c = a / b;
                lbresul.Text = c.ToString();
                //MessageBox.Show(c.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show("erro");
            }
            finally
            {
                MessageBox.Show("vai executar do mesmo jeito");
            }
        }
    }
}
