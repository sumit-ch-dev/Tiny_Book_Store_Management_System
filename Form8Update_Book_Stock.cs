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
    public partial class Form8Update_Book_Stock : Form
    {
        OleDbConnection conn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\User\Desktop\Tiny_Book_Store_Management_System\New Microsoft Access Database.accdb;Persist Security Info=False;");
        int count = 0;
        string oldcuantity;
        bool findbook = false;
        public Form8Update_Book_Stock()
        {
            InitializeComponent();
        }

        private void label7Entry_Data_Click(object sender, EventArgs e)
        {

        }

        private void Form8Update_Book_Stock_Load(object sender, EventArgs e)
        {

        }

        private void button3Update_Click(object sender, EventArgs e)
        {
            mgs.Text = "";
            // textBox7.Text = " ";
             if (!findbook)
             {
                 mgs.Text = "Please SELECT BOOK FIRST";
                 return;
             }
          //  MessageBox.Show(textBox6.Text.Length.ToString());
            string zero = textBox6.Text;
            if (zero.Length==0)
            {
                mgs.Text = "Please Enter NEW QUANTITY";
                return;
            }


            string newquantity = (Convert.ToInt32(oldcuantity) + Convert.ToInt32(textBox6.Text)).ToString();
            try
            {
                conn.Close();
                conn.Open();

                OleDbCommand cmd = conn.CreateCommand();
                cmd.Connection = conn;


               
                string query = "";
                ///query="UPDATE Book SET Quantity='" + newquantity + "',  AvaliableBook='" + newquantity + "'where BookName='" + textBox7.Text + "'";

                if (comboBox1.Text == "BookName")
                { query = "UPDATE Book SET Quantity='" + newquantity + "',  AvaliableBook='" + newquantity + "'where BookName='" + textBox7.Text + "'"; }
                else if (comboBox1.Text == "BookPublishYear")
                { query = "UPDATE Book SET Quantity='" + newquantity + "',  AvaliableBook='" + newquantity + "'where BookPublishYear='" + textBox7.Text + "'"; }
                else if (comboBox1.Text == "BookWriter")
                { query = "UPDATE Book SET Quantity='" + newquantity + "',  AvaliableBook='" + newquantity + "'where WriterName='" + textBox7.Text + "'"; }
                else if (comboBox1.Text == "Catagory")
                { query = "UPDATE Book SET Quantity='" + newquantity + "',  AvaliableBook='" + newquantity + "'where Chatagory='" + textBox7.Text + "'"; }



                cmd.CommandText = query;


                cmd.ExecuteNonQuery();
                conn.Close();
                mgs.Text = "Qunantity updated";
                textBox6.Text = "";

                textBox8.Text = newquantity;
                findbook = false;

            }
            catch (Exception en)
            {
                MessageBox.Show("Error \n\n" + en);
            }
            // command.CommandText = "UPDATE Tcostumers SET cfname= " + cfname + "clname= " + clname + " WHERE cid = " + cid;

        }

        private void button2Ok_Click(object sender, EventArgs e)
        {

            if(textBox7.Text.Length==0|| comboBox1.Text.Length==0)
            {
                mgs1.Text = "Please fill up the Text Box";
                return;
            }




            try
            {
                mgs.Text = "";
                mgs1.Text = "";
                textBox6.Text = "";
                count = 0;
                conn.Close();
                conn.Open();

                OleDbCommand cmd = conn.CreateCommand();
                cmd.Connection = conn;



                string query = "";

                if (comboBox1.Text == "BookName")
                    { query = "Select * from Book where BookName='" + textBox7.Text + "'"; }
                else if (comboBox1.Text == "BookPublishYear")
                    { query = "Select * from Book where BookPublishYear='" + textBox7.Text + "'"; }
                else if (comboBox1.Text == "BookWriter")
                    { query = "Select * from Book where WriterName='" + textBox7.Text + "'"; }
                else if (comboBox1.Text == "Catagory")
                    { query = "Select * from Book where Chatagory='" + textBox7.Text + "'";}



                cmd.CommandText = query;
                int f = 0;

                OleDbDataReader reader = cmd.ExecuteReader();


                while (reader.Read())
                {
                    f++;
                    textBox1.Text = reader["BookName"].ToString();
                    textBox2.Text = reader["BookPublishYear"].ToString();
                    textBox3.Text = reader["WriterName"].ToString();

                    textBox4.Text = reader["Quantity"].ToString();
                    textBox5.Text = reader["Chatagory"].ToString();
                    textBoxD.Text = reader["Date"].ToString();
                    textBox8.Text = reader["AvaliableBook"].ToString();
                    findbook = true;
                }

                if(f==0)
                {
                    mgs1.Text = "Wrong Information entered";
                    textBox1.Clear();
                    textBox2.Clear();
                    textBox3.Clear();

                    textBox4.Clear();
                    textBox5.Clear();
                    textBox6.Clear();
                    textBox8.Clear();
                    textBoxD.Clear();

                }
              //  MessageBox.Show(f.ToString());
                oldcuantity = textBox4.Text;


                
           
                conn.Close();


               

            }
            catch (Exception ex)
            {
                MessageBox.Show("Insert error  " + ex);
            }

}

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3Back_Click(object sender, EventArgs e)
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
