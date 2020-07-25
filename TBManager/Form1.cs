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
namespace TBManager
{
    public partial class Form1 : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=""C:\Users\ELDHOS AJI\source\repos\TBManager\TBManager\db.mdf"";Integrated Security = True");
        int ids;
        string ch;
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked==true)
            {
                password.UseSystemPasswordChar = false;
            }
            else
            {
                password.UseSystemPasswordChar = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string pass=null;
                try
                {
                    con.Open();
                    SqlCommand cmd1 = new SqlCommand("SELECT * FROM f_auth WHERE f_id='" + usrname.Text + "'", con);
                    using (SqlDataReader dr = cmd1.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            pass = dr["password"].ToString();
                            ch = dr["ch"].ToString();
                            ids = Convert.ToInt32(dr["f_id"]);
                        }
                    }
                    if (password.Text == pass && ch == "1")
                    {
                        string id = usrname.Text;
                        home h = new home(int.Parse(id), ids);
                        h.ShowDialog();
                        this.Hide();
                    }
                if (password.Text == pass && ch == "0")
                {
                    string id = usrname.Text;
                    userhome h = new userhome(int.Parse(id), ids);
                    h.ShowDialog();
                    this.Hide();
                }

                else
                {
                    MessageBox.Show("Invalid username or password");

                }
                con.Close();
                }
                catch (Exception E1)
                {
                    MessageBox.Show("Invalid username or password");
                this.Close();
                }
            
        }

        private void password_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void usrname_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
