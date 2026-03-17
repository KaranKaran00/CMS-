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
    public partial class studentlogin : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=D:\SEM-4\Programming with C#\MAM program\CMS\CMS\cms.mdf;Integrated Security = True");
        public studentlogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            string q = "select * from studentlogin where " + "username ='" + txtuname.Text + "' and " +
                "password = '" + txtpassword.Text + "'";

            SqlDataAdapter da = new SqlDataAdapter(q, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if(dt.Rows.Count > 0)
            {
                MessageBox.Show("Login Done");
            }
            else
            {
                MessageBox.Show("fail");
            }
            con.Close();
        }
    }
}
