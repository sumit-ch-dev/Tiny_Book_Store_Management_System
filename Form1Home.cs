using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Tiny_Book_Store_Management_System
{
    public partial class Form1Home : Form
    {
        public Form1Home()
        {
            InitializeComponent();
        }

        private void button1Admin_Click(object sender, EventArgs e)
        {
            Form2Admin_Log_In obj = new Form2Admin_Log_In();
            
            obj.Show();
            this.Hide();
        }

        private void button2Manager_Click(object sender, EventArgs e)
        {
            Form3Manager_Log_In obj = new Form3Manager_Log_In();
            obj.Show();
            this.Hide();
        }

        private void Form1Home_Load(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
