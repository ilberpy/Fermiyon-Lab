using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fermiyon_Lab
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bu bir Fermiyon Lab Uygulamasıdır. \n\nDeveloped by: İlber BAKŞİ || Yiğit Zafer COŞKUN \nVersion: 1.0", "Fermiyon Lab Hakkında", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
