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
    public partial class Form5Manager_Delete : Form
    {
        OleDbConnection conn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\User\Desktop\Tiny_Book_Store_Management_System\New Microsoft Access Database.accdb;Persist Security Info=False;");

        public Form5Manager_Delete()
        {
            InitializeComponent();
        }

        private void button1Delete_Click(object sender, EventArgs e)
        {
            dms.Text = "";
            try
            {
                conn.Open();

                OleDbCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText ="delete from ManagerLogin where Manager_id= '" + textBox1.Text + "'";
               
                int f = 0;
                f = cmd.ExecuteNonQuery();

                conn.Close();
                if (f != 0)
                {
                    dms.Text = "Deleted successfully";
                    textBox1.Clear();
                }
                else
                {
                    dms.Text = "Entered Wrong Information";
                    textBox1.Clear();

                }
               
            }
            catch (Exception ex)
            {
                MessageBox.Show("Deleted error  " + ex);
            }
        }

        private void label1Manager_Id_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Back_Click(object sender, EventArgs e)
        {
            Form12AdminTask ob = new Form12AdminTask();
            ob.Show();
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
