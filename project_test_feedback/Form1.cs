using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace project_test_feedback
{
    public partial class Form1 : Form
    {


        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-G1BVA5AN;Initial Catalog=master;Integrated Security=True");


        SqlCommand cmd1;



        public Form1()
        {
            InitializeComponent();
            

    }
   
        public string Communication()
        {
            if (comboBox1.Text == "Listening")
                comboBox1.Text = "You have good listening skill.";
            if (comboBox1.Text == "Negotiation")
                comboBox1.Text = "Your's negotiation skill is quite good.";

            if (comboBox1.Text == "Presentation")
                comboBox1.Text = "You are good at presentation skill.";
            if (comboBox1.Text == "Storytelling")
                comboBox1.Text = "You are quite good at storytelling.";
            if (comboBox1.Text == "Bad")
                comboBox1.Text = "sorry but your communication skills are bad";

            return comboBox1.Text;
        }

        public string Critical_thinking()
        {
            if (comboBox2.Text == "Adaptablity")
                comboBox2.Text = "You have good adaptablity.";
            if (comboBox2.Text == "Creative")
                comboBox2.Text = "You are quite creative.";
            if (comboBox2.Text == "Problemsolving")
                comboBox2.Text = "You are quite good at problem solving tasks.";

            if (comboBox2.Text == "Logicalthinking")
                comboBox2.Text = "You are good at Logical Thinking.";
            if (comboBox2.Text == "You ")
                comboBox2.Text = "You are quite good at storytelling.";
            if (comboBox2.Text == "Bad")
                comboBox2.Text = "sorry but you are bad at creative thinking.";

            return comboBox2.Text;
        }
        public string Leadership()
        {
            if (comboBox3.Text == "Dealmaking")
                comboBox3.Text = "You have good in deal making which is good gor company.";
            if (comboBox3.Text == "Decissionmaking")
                comboBox3.Text = "You are quite good at decision making.";

            if (comboBox3.Text == "Management")
                comboBox3.Text = "Your's management skill is very good.";
            if (comboBox3.Text == "Motivating")
                comboBox3.Text = "You are quite motivating.";
            if (comboBox3.Text == "Bad")
                comboBox3.Text = "sorry but you are bad at Leadership Skills.";

            return comboBox3.Text;
        }
        public string Ethics()
        {
            if (comboBox4.Text == "Collaboration")
                comboBox4.Text = "You have good in colloboration which is good for company.";
            if (comboBox4.Text == "Persuasion")
                comboBox4.Text = "You are very good at perssuarative.";

            if (comboBox4.Text == "Teamwork")
                comboBox4.Text = "You are good at team work.";
            if (comboBox4.Text == "Bad")
                comboBox4.Text = "sorry but you are bad in work ethics.";

            return comboBox4.Text;
        }

        
        public string WorkExpreance()
        {
            if (comboBox5.Text == "No")
                comboBox5.Text = "Accorsing to your cv you haven't work in any place.";
            if (comboBox5.Text == "Yes")
                comboBox5.Text = "You have prior working expreance which is very good.";

            return comboBox5.Text;
        }


        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Communication();
            richTextBox1.AppendText("Hellow "+textBox1.Text+"\n\n");
            richTextBox1.AppendText(comboBox1.Text + "\n");
        }

        private void button2_Click(object sender, EventArgs e)
        {

            Critical_thinking();
            
            richTextBox1.AppendText(comboBox2.Text + "\n");
        }

        private void button3_Click(object sender, EventArgs e)
        {

            Leadership();

            richTextBox1.AppendText(comboBox3.Text + "\n");
        }

        private void button6_Click(object sender, EventArgs e)
        {

            Ethics();

            richTextBox1.AppendText(comboBox4.Text + "\n");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            WorkExpreance();
            

            richTextBox1.AppendText(comboBox5.Text + "\n");
        }

        private void button4_Click(object sender, EventArgs e)
        {
           

           
         

         
            con.Open();
            cmd1 = new SqlCommand("INSERT INTO UserName (Name) VALUES (@Name)", con);
            cmd1.Parameters.Add("@name",textBox1.Text);
            cmd1.ExecuteNonQuery();
            con.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
             con.Open();
            cmd1 = new SqlCommand("INSERT INTO FeedbackTable (Communication,Thinking,Leadership,Ethics,Experience) VALUES (@Communication,@Thinking,@Leadership,@Ethics,@Experience)", con);
            cmd1.Parameters.AddWithValue("@Communication", comboBox1.Text.ToString());
            cmd1.Parameters.AddWithValue("@Thinking", comboBox1.Text.ToString());
            cmd1.Parameters.AddWithValue("@Leadership", comboBox1.Text.ToString());
            cmd1.Parameters.AddWithValue("@Ethics", comboBox1.Text.ToString());
            cmd1.Parameters.AddWithValue("@Experience", comboBox1.Text.ToString());
            cmd1.ExecuteNonQuery();
            con.Close();
            MessageBox.Show($"Applicant {textBox1.Text} Feedback saved");
        }
    }
}
