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
    public partial class Form2Admin_Log_In : Form
    {
        private OleDbConnection connection= new OleDbConnection();

        public Form2Admin_Log_In()
        {
            InitializeComponent();
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\User\Desktop\Tiny_Book_Store_Management_System\New Microsoft Access Database.accdb;Persist Security Info=False;";

        }

        private void Form2Admin_Log_In_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            msg.Text = "";
            


            connection.Open();

            OleDbCommand command = new OleDbCommand();
            command.Connection = connection;
            command.CommandText = "select * from AdminLogIn where Admin_id='" + textBox1.Text + "'and password='"+textBox2.Text+"'";
            
            OleDbDataReader reader= command.ExecuteReader();

            int count = 0;
            while(reader.Read())
            {
                count = count + 1;
            }

            connection.Close();
            textBox1.Clear();
            textBox2.Clear();
            if (count==1)
            {
               // MessageBox.Show("user name and password is currect");

                Form12AdminTask obj = new Form12AdminTask();
                obj.Show();
                this.Hide();
            }
            else if (count > 1)
            {
                msg.Text = "Duplicate Admin Name and password";
                // MessageBox.Show("Duplicate user name and password");
            }
            else
            {
                msg.Text = "Admin Name and Password is NO CURRECT";
                // MessageBox.Show("user name and password is NO CURRECT");

            }




           

 
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
