using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PRACTICE_PROJECT_FORMS
{
    public partial class Form1 : Form
    {
        SqlConnection conexao = new SqlConnection("Data Source=IKENAGADELL\\SQLEXPRESS;Initial Catalog=teste;Integrated Security=True");
        SqlCommand comando = new SqlCommand();
        SqlDataReader datareader;

        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comando.Connection = conexao;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "") {
                conexao.Open();
                string a = "INSERT INTO TREINO (CD_TREINO,DT_TREINO,TIPO_TREINO,ABS_TREINO,FLX_TREINO,TIRO_TREINO,RUN_TREINO,OBS_TREINO)VALUES ('" + textBox1.Text + "','" + Convert.ToDateTime(monthCalendar1.SelectionRange) + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text + "','" + textBox7.Text + "');";
                Console.WriteLine(a);
                comando.CommandText = "INSERT INTO TREINO (CD_TREINO,DT_TREINO,TIPO_TREINO,ABS_TREINO,FLX_TREINO,TIRO_TREINO,RUN_TREINO,OBS_TREINO)VALUES ('" + textBox1.Text + "','" + Convert.ToDateTime(monthCalendar1.SelectionRange )+ "','" + textBox2.Text + "','" + textBox3.Text+ "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text + "','" + textBox7.Text + "');";
                comando.ExecuteNonQuery();
                conexao.Close();

                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";
                textBox6.Text = "";
                textBox7.Text = "";
            }
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            Convert.ToInt16(Console.ReadLine());
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            Convert.ToInt16(Console.ReadLine());
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }
    }
}
