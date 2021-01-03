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
    public partial class Form13_View_All_books : Form
    {
        OleDbConnection conn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\User\Desktop\Tiny_Book_Store_Management_System\New Microsoft Access Database.accdb;Persist Security Info=False;");

        public Form13_View_All_books()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form13_View_All_books_Load(object sender, EventArgs e)
        {

            try
            {
                conn.Open();

                OleDbCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "Select * from Book";
                cmd.ExecuteNonQuery();

                DataTable dt = new DataTable();
                OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                da.Fill(dt);
                dataGridView1.DataSource = dt;


                conn.Close();
                // MessageBox.Show("New Manager Added");
                // Form12AdminTask ob = new Form12AdminTask();
                // ob.Show();
                // this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Insert error  " + ex);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form12AdminTask obj = new Form12AdminTask();
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
