using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CMS
{
    public partial class student : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=D:\SEM-4\Programming with C#\MAM program\CMS\CMS\cms.mdf;Integrated Security = True");
        string g;
        public student()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                g = "male";
            }
            else
            {
                g = "female";
            }
            con.Open();
            string q = "insert into student(studentname,mobile,email,gender) values('" + textBox1.Text + "'," + textBox2.Text + ",'" + textBox3.Text + "','" + g + "')";
            SqlCommand cmd = new SqlCommand(q, con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Record Inserted");
            con.Close();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
