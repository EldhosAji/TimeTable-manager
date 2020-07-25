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
    public partial class data : Form
    {
        int k;
        SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=""C:\Users\ELDHOS AJI\source\repos\TBManager\TBManager\db.mdf"";Integrated Security = True");
        public data()
        {
            InitializeComponent();
        }

        private void data_Load(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM f_dep", con);
            using (SqlDataReader dr = cmd.ExecuteReader())
            {
                while (dr.Read())
                {
                    f_dep.Items.Add(dr["dep_id"]).ToString();
                }
            }
            con.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dep_TextChanged(object sender, EventArgs e)
        {

        }

        private void sep_insert_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "INSERT INTO  f_dep VALUES('"+dep.Text+"')";
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Inserted");

        }

        private void sec_insert_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "INSERT INTO  f_sec VALUES('" + sec.Text + "')";
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Inserted");
        }

        private void f_dep_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void reg_Click(object sender, EventArgs e)
        {
            try
            {
                if (cb2.Text == "ALL")
                    k = 1;
                else if (cb2.Text == "NOT ALL")
                    k = 0;
                else
                    MessageBox.Show("Select access");

                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "INSERT INTO  f_table VALUES('" + f_id.Text + "','" + f_name.Text + "','" + f_mail.Text + "','" + f_dep.Text + "','" + f_mob.Text + "','" + k + "')";
                cmd.ExecuteNonQuery();
                cmd.CommandText = "INSERT INTO  f_auth VALUES('" + f_id.Text + "','" + f_id.Text + "','" + k + "')";
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Inserted");
            }catch(Exception E)
            {
                MessageBox.Show("ID exits");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "INSERT INTO  cource VALUES('" + c_id.Text + "','" + c_name.Text + "')";
            cmd.ExecuteNonQuery();
            SqlCommand cm=new SqlCommand("CREATE TABLE [dbo].['"+c_id.Text+"'] (    [f_Id] INT NOT NULL,    PRIMARY KEY CLUSTERED([f_Id] ASC))",con);
            cm.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Inserted");
        }
    }
}
