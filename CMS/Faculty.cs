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
    public partial class Faculty : Form
    {
        public Faculty()
        {
            InitializeComponent();
        }

        private void Faculty_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cmsDataSet.faculty' table. You can move, or remove it, as needed.
            this.facultyTableAdapter.Fill(this.cmsDataSet.faculty);

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = D:\SEM-4\Programming with C#\MAM program\CMS\CMS\cms.mdf; Integrated Security = True");
            con.Open();
            string q = "insert into faculty(facultyname,moblie,email) values('"+txtname.Text+"',"+txtmoblie.Text+",'"+txtemail.Text+"')";
            SqlCommand cmd = new SqlCommand(q, con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Record Inserted");
            con.Close();
        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}
