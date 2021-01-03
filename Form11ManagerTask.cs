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
    public partial class Form11ManagerTask : Form
    {
        public Form11ManagerTask()
        {
            InitializeComponent();
        }

        private void button3Free_Book_Search_Click(object sender, EventArgs e)
        {
            Form9Free_Book_Search obj = new Form9Free_Book_Search();
            obj.Show();
            this.Hide();
        }

        private void button1New_Book_Entry_Click(object sender, EventArgs e)
        {
            Form7New_Book_Entry obj = new Form7New_Book_Entry();
            obj.Show();
            this.Hide();
        }

        private void button2Update_Book_Stock_Click(object sender, EventArgs e)
        {
            Form8Update_Book_Stock obj = new Form8Update_Book_Stock();
            obj.Show();
            this.Hide();
        }

        private void button4Delete_Book_Stock_Click(object sender, EventArgs e)
        {
            Form10Delete_Book_Stock obj = new Form10Delete_Book_Stock();
            obj.Show();
            this.Hide();
        }

        private void viewbook_Click(object sender, EventArgs e)
        {
            Form13_View_All_books obj = new Form13_View_All_books();
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
