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
    public partial class Form10Delete_Book_Stock : Form
    {
        OleDbConnection conn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\User\Desktop\Tiny_Book_Store_Management_System\New Microsoft Access Database.accdb;Persist Security Info=False;");

        public Form10Delete_Book_Stock()
        {
            InitializeComponent();
        }

        private void button2Delete_Click(object sender, EventArgs e)
        {

        }

        private void button1Delete_Click(object sender, EventArgs e)
        {
            ds.Text = "";
            mgss.Text = "";
            if(listbox.Text.Length==0 || textBox1.Text.Length==0)
            {
                mgss.Text = "Please Enter All book Information";
                return;
            }
            try
            {
                conn.Open();

                OleDbCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;

                 if (listbox.Text == "BookName")
                 {
                     //cmd.CommandText = "Select * from Book Where BookName='" + textBox1.Text + "'";//'"+comboBox1.Text+"'
                     cmd.CommandText = "delete from Book where BookName= '" + textBox1.Text + "'";
                 }

                 else if (listbox.Text == "BookPublishYear")
                 {
                     //cmd.CommandText = "Select * from Book Where BookPublishYear='" + textBox1.Text + "'";//'"+comboBox1.Text+"'
                     cmd.CommandText = "delete from Book where BookPublishYear= '" + textBox1.Text + "'";


                 }

                 else if (listbox.Text == "WriterName")
                 {
                    // cmd.CommandText = "Select * from Book Where WriterName='" + textBox1.Text + "'";//'"+comboBox1.Text+"'
                     cmd.CommandText = "delete from Book where WriterName= '" + textBox1.Text + "'";

                 }
                 else if (listbox.Text == "Chatagory")
                 {
                     //cmd.CommandText = "Select * from Book Where Chatagory='" + textBox1.Text + "'";//'"+comboBox1.Text+"'
                     cmd.CommandText = "delete from Book where Chatagory= '" + textBox1.Text + "'";

                 }





                int f = 0;
                f=cmd.ExecuteNonQuery();

                conn.Close();
                if(f!=0)
                {
                    ds.Text = "Deleted successfully";
                    textBox1.Clear();
                }
                else
                {
                    ds.Text = "Entered Wrong Information";
                    textBox1.Clear();

                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("Deleted error  " + ex);
            }
        }

        private void button2Back_Click(object sender, EventArgs e)
        {
            Form11ManagerTask obj = new Form11ManagerTask();
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
