using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace uygulama_9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Gray;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Purple;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Navy;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Yellow;
        }
    }
}
