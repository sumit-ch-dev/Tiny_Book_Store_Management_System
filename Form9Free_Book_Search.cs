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
    public partial class Form9Free_Book_Search : Form
    {
        OleDbConnection conn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\User\Desktop\Tiny_Book_Store_Management_System\New Microsoft Access Database.accdb;Persist Security Info=False;");
        int count = 0;
        public Form9Free_Book_Search()
        {
            InitializeComponent();
        }

        private void button1Ok_Click(object sender, EventArgs e)
        {
            labelnotfound.Text = "";
            if(comboBox1.Text.Length==0 || textBox1.Text.Length==0)
            {
                labelnotfound.Text = "Enter all Information";
                return;
            }



            try
            {
                count = 0;
                conn.Open();

                OleDbCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                //MessageBox.Show(comboBox1.Text);
                if (comboBox1.Text == "BookName")
                    {
                    cmd.CommandText = "Select * from Book Where BookName='" + textBox1.Text + "'";//'"+comboBox1.Text+"'
                    }

                else if (comboBox1.Text == "BookPublishYear")
                    { 
                    cmd.CommandText = "Select * from Book Where BookPublishYear='" + textBox1.Text + "'";//'"+comboBox1.Text+"'
                    }

                else if (comboBox1.Text == "WriterName")
                    { 
                     cmd.CommandText = "Select * from Book Where WriterName='" + textBox1.Text + "'";//'"+comboBox1.Text+"'
                    }
                else if (comboBox1.Text == "Chatagory")
                    { 
                    cmd.CommandText = "Select * from Book Where Chatagory='" + textBox1.Text + "'";//'"+comboBox1.Text+"'
                    }

                cmd.ExecuteNonQuery();

                DataTable dt = new DataTable();
                OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                da.Fill(dt);
                count=Convert.ToInt32( dt.Rows.Count.ToString());

                dataGridView1.DataSource = dt;
                conn.Close();
               

                if(count==0)
                {
                    labelnotfound.Text = "Record not FOUND";
                }
                textBox1.Clear();
                //comboBox1.Text = "";

            }
            catch (Exception ex)
            {
                MessageBox.Show("Insert error  " + ex);
            }

        }

        private void Back_Click(object sender, EventArgs e)
        {
            Form11ManagerTask obj = new Form11ManagerTask();
            obj.Show();
            this.Hide();
        }

        private void Form9Free_Book_Search_Load(object sender, EventArgs e)
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
