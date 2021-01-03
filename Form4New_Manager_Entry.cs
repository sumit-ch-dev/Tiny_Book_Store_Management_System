using System;
using System.Data.OleDb;
using System.Windows.Forms;
namespace Tiny_Book_Store_Management_System
{
    public partial class Form4New_Manager_Entry : Form
    {
        OleDbConnection conn = new OleDbConnection();

        public Form4New_Manager_Entry()
        {
            InitializeComponent();

        }

        private void label2Manager_Name_Click(object sender, EventArgs e)
        {

        }

        private void button1Create_Click(object sender, EventArgs e)
        {
            mgs.Text = "";
            
            string s1 = textBox1.Text;
            string s2 = textBox2.Text;
            if(s1.Length==0 || s2.Length==0)
            {
                mgs.Text = "Please fill up all information";
                return;
            }
            if (textBox2.Text.Length < 6)
            {
                mgs.Text = "Please Set The Password to 6 Character or More";
                return;
            }

            try
            {
                conn.Close();
                conn.Open();

                OleDbCommand command = new OleDbCommand();
                command.Connection = conn;
                command.CommandText = "insert into ManagerLogin(MANAGER_ID,MPassword)values('" + textBox1.Text + "','" + textBox2.Text + "')";
                int v=command.ExecuteNonQuery();

                conn.Close();
                mgs.Text = "Manager Created";
                textBox1.Clear();
                textBox2.Clear();
               // MessageBox.Show("Data inserted!");

            }
            catch (Exception exs)
            {
                MessageBox.Show("insert error" + "  " + exs.ToString());
            }

        }

        private void Form4New_Manager_Entry_Load(object sender, EventArgs e)
        {
            try
            {

                conn.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\User\Desktop\Tiny_Book_Store_Management_System\New Microsoft Access Database.accdb;Persist Security Info=False;";
                conn.Open();

               // MessageBox.Show("connection successful!");

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("error" + ex.ToString());
            }
        }

        private void Back_Click(object sender, EventArgs e)
        {
            Form12AdminTask obj = new Form12AdminTask();
            obj.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void logout_Click(object sender, EventArgs e)
        {
            Form1Home obj = new Form1Home();
            obj.Show();
            this.Hide();
        }
    }
}

