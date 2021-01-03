using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tiny_Book_Store_Management_System
{
    public partial class Form12AdminTask : Form
    {
        public Form12AdminTask()
        {
            InitializeComponent();
        }

        private void button1Add_New_Manager_Entry_Click(object sender, EventArgs e)
        {
            Form4New_Manager_Entry obj = new Form4New_Manager_Entry();
            obj.Show();
            this.Hide();
        }

        private void button2Manager_List_Click(object sender, EventArgs e)
        {
            Form6Manager_List obj = new Form6Manager_List();
            obj.Show();
            this.Hide();
        }

        private void button3Delete_Manager_Click(object sender, EventArgs e)
        {
            Form5Manager_Delete obj = new Form5Manager_Delete();
            obj.Show();
            this.Hide();
        }

        private void logout_Click(object sender, EventArgs e)
        {
            Form1Home obj = new Form1Home();
            obj.Show();
            this.Hide();
        }
    }
}
