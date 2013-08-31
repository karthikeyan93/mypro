using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace mypro
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {


            {
                try
                {
                    SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\Elcot\Documents\contact.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True");
                    con.Open();
                    SqlCommand cmd = new SqlCommand("insert into contactstab(name,class,mobile,deptno,Event)values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','"+textBox5.Text+"')", con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Participant has been saved", "zenith");
                }

                catch
                {
                    MessageBox.Show("your Details is already saved","zenith");
                }

            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
          
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\Elcot\Documents\contact.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True");
            

            SqlDataAdapter sda = new SqlDataAdapter("select * from contactstab", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.Rows.Clear();
            foreach (DataRow row in dt.Rows)
            {
                int n = dataGridView1.Rows.Add();
                dataGridView1.Rows[n].Cells[0].Value = row["name"].ToString();
                dataGridView1.Rows[n].Cells[1].Value = row["class"].ToString();
                dataGridView1.Rows[n].Cells[2].Value = row["mobile"].ToString();
                dataGridView1.Rows[n].Cells[3].Value = row["deptno"].ToString();
                dataGridView1.Rows[n].Cells[4].Value = row["Event"].ToString();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
            Form4 form4 = new Form4();
            form4.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            foreach (Control c in this.Controls)

                if (c is TextBox)

                    (c as TextBox).Clear();

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
