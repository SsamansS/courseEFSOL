using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EFcore_lesson1_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<User> list = new MyContext().Users.ToList();
            dataGridView1[0, 0].Value = list[0];
        }

        private BindingSource bindingSource1 = new BindingSource();
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.DataSource = new MyContext().Users.ToList();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
