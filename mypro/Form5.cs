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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
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

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int t1 = Convert.ToInt32(textBox2.Text);
                int t2 = Convert.ToInt32(textBox3.Text);
                int t3 = Convert.ToInt32(textBox4.Text);
                int t4 = Convert.ToInt32(textBox5.Text);
                int t5 = Convert.ToInt32(textBox6.Text);
                int t6 = Convert.ToInt32(textBox7.Text);
                int t7 = Convert.ToInt32(textBox8.Text);
                int t8 = Convert.ToInt32(textBox9.Text);
                int t9 = Convert.ToInt32(textBox10.Text);
                int t10 = Convert.ToInt32(textBox11.Text);
                int t1total = t1 + t2 + t3 + t4 + t5 + t6 + t7 + t8 + t9 + t10;
                textBox12.Text = t1total.ToString();
                
            }
            catch
             {
                
                 MessageBox.Show("Enter all the fields if the team has not scored specify 0 on the fields ", "Zenith Event Management");
            }









        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\Elcot\Documents\quiz.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into dataentry(team_name,r1,r2,r3,r4,r5,r6,r7,r8,r9,r10,total,place)values('"+textBox1.Text+"','"+textBox2.Text+"','"+textBox3.Text+"','"+textBox4.Text+"','"+textBox5.Text+"','"+textBox6.Text+"','"+textBox7.Text+"','"+textBox8.Text+"','"+textBox9.Text+"','"+textBox10.Text+"','"+textBox11.Text+"','"+textBox12.Text+"')",con);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Team A has been saved");
        }

        private void textBox18_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

            try
            {
                int tt1 = Convert.ToInt32(textBox14.Text);
                int tt2 = Convert.ToInt32(textBox15.Text);
                int tt3 = Convert.ToInt32(textBox16.Text);
                int tt4 = Convert.ToInt32(textBox17.Text);
                int tt5 = Convert.ToInt32(textBox18.Text);
                int tt6 = Convert.ToInt32(textBox19.Text);
                int tt7 = Convert.ToInt32(textBox20.Text);
                int tt8 = Convert.ToInt32(textBox21.Text);
                int tt9 = Convert.ToInt32(textBox22.Text);
                int tt10 = Convert.ToInt32(textBox23.Text);
                int total2 = tt1 + tt2 + tt3 + tt4 + tt5 + tt6 + tt7 + tt8 + tt9 + tt10;
                textBox24.Text = total2.ToString();
            }
            catch
            {
                MessageBox.Show("Enter all the fields if the team has not scored specify 0 on the fields ", "Zenith Event Management");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                int ttt1 = Convert.ToInt32(textBox26.Text);
                int ttt2 = Convert.ToInt32(textBox27.Text);
                int ttt3 = Convert.ToInt32(textBox28.Text);
                int ttt4 = Convert.ToInt32(textBox29.Text);
                int ttt5 = Convert.ToInt32(textBox30.Text);
                int ttt6 = Convert.ToInt32(textBox31.Text);
                int ttt7 = Convert.ToInt32(textBox32.Text);
                int ttt8 = Convert.ToInt32(textBox33.Text);
                int ttt9 = Convert.ToInt32(textBox34.Text);
                int ttt10 = Convert.ToInt32(textBox35.Text);
                int total3 = ttt1 + ttt2 + ttt3 + ttt4 + ttt5 + ttt6 + ttt7 + ttt8 + ttt9 + ttt10;
                textBox36.Text = total3.ToString();
            }
            catch
            {
                MessageBox.Show("Enter all the fields if the team has not scored specify 0 on the fields ", "Zenith Event Management");
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {

                int tttt1 = Convert.ToInt32(textBox38.Text);
                int tttt2 = Convert.ToInt32(textBox39.Text);
                int tttt3 = Convert.ToInt32(textBox40.Text);
                int tttt4 = Convert.ToInt32(textBox41.Text);
                int tttt5 = Convert.ToInt32(textBox42.Text);
                int tttt6 = Convert.ToInt32(textBox43.Text);
                int tttt7 = Convert.ToInt32(textBox44.Text);
                int tttt8 = Convert.ToInt32(textBox45.Text);
                int tttt9 = Convert.ToInt32(textBox46.Text);
                int tttt10 =Convert.ToInt32(textBox47.Text);
                int total4 = tttt1 + tttt2 + tttt3 + tttt4 + tttt5 + tttt6 + tttt7 + tttt8 + tttt9 + tttt10;
                textBox48.Text = total4.ToString();
                

                

              
            }
            catch
            {
                
                MessageBox.Show("Enter all the fields if the team has not scored specify 0 on the fields ", "Zenith Event Management");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\Elcot\Documents\quiz.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into dataentry(team_name,r1,r2,r3,r4,r5,r6,r7,r8,r9,r10,total)values('" + textBox13.Text + "','" + textBox14.Text + "','" + textBox15.Text + "','" + textBox16.Text + "','" + textBox17.Text + "','" + textBox18.Text + "','" + textBox19.Text + "','" + textBox20.Text + "','" + textBox21.Text + "','" + textBox22.Text + "','" + textBox23.Text + "','" + textBox24.Text + "')", con);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show(" Team b  has been saved"); 
        }

        private void button6_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\Elcot\Documents\quiz.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into dataentry(team_name,r1,r2,r3,r4,r5,r6,r7,r8,r9,r10,total)values('" + textBox25.Text + "','" + textBox26.Text + "','" + textBox27.Text + "','" + textBox28.Text + "','" + textBox29.Text + "','" + textBox30.Text + "','" + textBox31.Text + "','" + textBox32.Text + "','" + textBox33.Text + "','" + textBox34.Text + "','" + textBox35.Text + "','" + textBox36.Text + "')", con);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show(" Team c  has been saved"); 
        }

        private void button8_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\Elcot\Documents\quiz.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into dataentry(team_name,r1,r2,r3,r4,r5,r6,r7,r8,r9,r10,total)values('" + textBox37.Text + "','" + textBox38.Text + "','" + textBox39.Text + "','" + textBox40.Text + "','" + textBox41.Text + "','" + textBox42.Text + "','" + textBox43.Text + "','" + textBox44.Text + "','" + textBox45.Text + "','" + textBox46.Text + "','" + textBox47.Text + "','" + textBox48.Text + "')", con);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show(" Team D  has been saved"); 
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form6 form6 = new Form6();
            form6.Show();
            

        }

        private void button10_Click(object sender, EventArgs e)
        {
            
        }

        private void button11_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
