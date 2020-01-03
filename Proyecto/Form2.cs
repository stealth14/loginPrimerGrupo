using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Connection String   
            SqlConnection con = new SqlConnection(@"Data Source=localhost;Initial Catalog=NORTHWIND;User ID=xavier;Password=inmejia1998");
            SqlCommand cmd = new SqlCommand("select * from Userlogins where UserName=@UserName and Password =@Password", con);
            cmd.Parameters.AddWithValue("@UserName", textBox1.Text);
            cmd.Parameters.AddWithValue("@Password", textBox2.Text);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            //Connection open here   
            con.Open();
            int i = cmd.ExecuteNonQuery();
            con.Close();
            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("Successfully loged in");
                //after successful it will redirect  to next page .

                Form1 f1 = new Form1();
                f1.Show();

                Form3 f3 = new Form3();
                f3.Show();

                this.Hide();
            }
            else
            {
                MessageBox.Show("Please enter Correct Username and Password");
            }

        }



    }
}
