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
    public partial class Form7New_Book_Entry : Form
    {
        OleDbConnection conn = new OleDbConnection();
        public Form7New_Book_Entry()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2Ok_Click(object sender, EventArgs e)
        {

        }

        private void Form7New_Book_Entry_Load(object sender, EventArgs e)
        {

        }
        private void clearT()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            drop.Text = "";
        }
        private bool allfill()
        {
            if (drop.Text.Length == 0 || textBox4.Text.Length == 0 || textBox3.Text.Length == 0 || textBox2.Text.Length == 0 || textBox1.Text.Length == 0)
                return true;
            else return false;
        }
        public bool IsNumeric(string str)
        {
            return str.All(c => "0123456789".Contains(c));
        }
        private void button2Ok_Click_1(object sender, EventArgs e)
        {
            added.Text = "";
            if(allfill())
            {
                added.Text = "Fill up the ALL TEXT BOX";
                return;
            }


            if (!(IsNumeric(textBox4.Text)))
             {
               added.Text = "Enter Number in the Quantity Box";
               return;
             }
            



            try
            {
                conn.Close();
                conn.Open();

                OleDbCommand command = new OleDbCommand();
                command.Connection = conn;
                command.CommandText = "insert into Book(BookName,BookPublishYear,WriterName,Quantity,Chatagory,AvaliableBook)values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + drop.Text + "','" + textBox4.Text + "')";
                int v = command.ExecuteNonQuery();

                conn.Close();
                added.Text = "New Book Added";
                clearT();
                // MessageBox.Show("Data inserted!");

            }
            catch (Exception exs)
            {
                MessageBox.Show("insert error" + "  " + exs.ToString());
            }
        }

        private void Form7New_Book_Entry_Load_1(object sender, EventArgs e)
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

        private void button1Back_Click(object sender, EventArgs e)
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
