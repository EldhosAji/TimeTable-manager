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
    public partial class home : Form
    {
        string selectB;
        char d;
        int id;
        string hr;
        SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=""C:\Users\ELDHOS AJI\source\repos\TBManager\TBManager\db.mdf"";Integrated Security = True");
        string p1_s;
        string p1_c;
        string p2_s;
        string p2_c;
        string p3_s;
        string p3_c;
        string p4_s;
        string p4_c;
        string p5_s;
        string p5_c;
        string p6_s;
        string p6_c;
        string p7_s;
        string p7_c;
        bool selected = false;
        int idd;
        public home(int username,int ids)
        {
            idd = ids;
            
            id = username;
            InitializeComponent();
        }

        private void m1_Click(object sender, EventArgs e)
        {
            hr = "p1";
            d = 'm';
            selection(m1);
            selectB =m1.Text;
        }
        public void selection(Button b)
        {
            if (selected == false)
            {
                b.BackColor = Color.Violet;
                selected = true;

            }
            else
            {
                b.BackColor = Color.Transparent;
                selected = false;
            }
        }

        private void m2_Click(object sender, EventArgs e)
        {
            hr = "p2";
            selection(m2);
            d = 'm';
            selectB = m2.Text;
        }

        private void m3_Click(object sender, EventArgs e)
        {
            selection(m3);
            d = 'm';
            hr = "p3";
            selectB = m3.Text;
        }

        private void lev_Click(object sender, EventArgs e)
        {
            code c = new code();
            c.ShowDialog();
        }

        private void button23_Click(object sender, EventArgs e)
        {
            selection(f6);
            d = 'f';
            hr = "p6";
            selectB = f6.Text;
        }

        private void home_Load(object sender, EventArgs e)
        {
            f_id.Text = idd.ToString() ;
            con.Open();
            SqlCommand m = new SqlCommand("SELECT * FROM MONDAY WHERE f_id='"+idd+"'", con);
            SqlCommand t = new SqlCommand("SELECT * FROM TUESDAY WHERE f_id='" + idd + "'", con);
            SqlCommand w = new SqlCommand("SELECT * FROM WENESDAY WHERE f_id='" + idd + "'", con);
            SqlCommand th = new SqlCommand("SELECT * FROM THURSDAY WHERE f_id='" + idd + "'", con);
            SqlCommand f = new SqlCommand("SELECT * FROM FRIDAY WHERE f_id='" + idd + "'", con);
            SqlCommand cmd = new SqlCommand("SELECT f_id FROM f_table", con);
            SqlCommand cmd1 = new SqlCommand("SELECT DAY FROM f_day", con);
            using (SqlDataReader dr = m.ExecuteReader())
            {
                while (dr.Read())
                {
                    m1.Text=dr["p1"].ToString();
                    m2.Text = dr["p2"].ToString();
                    m3.Text = dr["p3"].ToString();
                    m4.Text = dr["p4"].ToString();
                    m5.Text = dr["p5"].ToString();
                    m6.Text = dr["p6"].ToString();
                    m7.Text = dr["p7"].ToString();

                }
            }
            using (SqlDataReader dr = t.ExecuteReader())
            {
                while (dr.Read())
                {
                    t1.Text = dr["p1"].ToString();
                    t2.Text = dr["p2"].ToString();
                    t3.Text = dr["p3"].ToString();
                    t4.Text = dr["p4"].ToString();
                    t5.Text = dr["p5"].ToString();
                    t6.Text = dr["p6"].ToString();
                    t7.Text = dr["p7"].ToString();

                }
            }

            using (SqlDataReader dr = w.ExecuteReader())
            {
                while (dr.Read())
                {
                    w1.Text = dr["p1"].ToString();
                    w2.Text = dr["p2"].ToString();
                    w3.Text = dr["p3"].ToString();
                    w4.Text = dr["p4"].ToString();
                    w5.Text = dr["p5"].ToString();
                    w6.Text = dr["p6"].ToString();
                    w7.Text = dr["p7"].ToString();

                }
            }

            using (SqlDataReader dr = th.ExecuteReader())
            {
                while (dr.Read())
                {
                    th1.Text = dr["p1"].ToString();
                    th2.Text = dr["p2"].ToString();
                    th3.Text = dr["p3"].ToString();
                    th4.Text = dr["p4"].ToString();
                    th5.Text = dr["p5"].ToString();
                    th6.Text = dr["p6"].ToString();
                    th7.Text = dr["p7"].ToString();

                }
            }

            using (SqlDataReader dr = f.ExecuteReader())
            {
                while (dr.Read())
                {
                    f1.Text = dr["p1"].ToString();
                    f2.Text = dr["p2"].ToString();
                    f3.Text = dr["p3"].ToString();
                    f4.Text = dr["p4"].ToString();
                    f5.Text = dr["p5"].ToString();
                    f6.Text = dr["p6"].ToString();
                    f7.Text = dr["p7"].ToString();

                }
            }
            using (SqlDataReader dr = cmd.ExecuteReader())
            {
                while (dr.Read())
                {
                    f_id.Items.Add(dr["f_id"]).ToString();

                }
            }
            using (SqlDataReader dr = cmd1.ExecuteReader())
            {

                while (dr.Read())
                {
                    day.Items.Add(dr["DAY"]).ToString();
                }
            }
            
          
            con.Close();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void insert_Click(object sender, EventArgs e)
        {
            try
            {
                int k = 0 ;
                con.Open();
                string sql = "SELECT * FROM "+day.Text+" WHERE f_id='"+f_id.Text+"'";
                SqlCommand cmd1 = new SqlCommand(sql,con);
                using (SqlDataReader dr = cmd1.ExecuteReader())
                {
                    while (dr.Read())
                    {
                       k++;
                    }
                }
                con.Close();
                string name = day.Text;
                if (k > 0)
                {
                    con.Open();
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "UPDATE  " + name + " SET p1='" + p1.Text + "',p2='" + p2.Text + "',p3='" + p3.Text + "',p4='" + p4.Text + "',p5='" + p5.Text + "',p6='" + p6.Text + "',p7='" + p7.Text + "'  WHERE f_id='" + f_id.Text + "'";
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Time table Updated");
                }
                else
                {
                    con.Open();
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "INSERT INTO  " + name + " VALUES('" + f_id.Text + "','" + p1.Text + "','" + p2.Text + "','" + p3.Text + "','" + p4.Text + "','" + p5.Text + "','" + p6.Text + "','" + p7.Text + "')";
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Inserted");
                    rel();
                }

            }
            catch(Exception E)
            {
                MessageBox.Show(E.Message);
                rel();
            }
           
    }
        public void rel()
        {
            f_id.Text = idd.ToString();
            con.Open();
            SqlCommand m = new SqlCommand("SELECT * FROM MONDAY WHERE f_id='" + idd + "'", con);
            SqlCommand t = new SqlCommand("SELECT * FROM TUESDAY WHERE f_id='" + idd + "'", con);
            SqlCommand w = new SqlCommand("SELECT * FROM WENESDAY WHERE f_id='" + idd + "'", con);
            SqlCommand th = new SqlCommand("SELECT * FROM THURSDAY WHERE f_id='" + idd + "'", con);
            SqlCommand f = new SqlCommand("SELECT * FROM FRIDAY WHERE f_id='" + idd + "'", con);
            SqlCommand cmd = new SqlCommand("SELECT f_id FROM f_table", con);
            SqlCommand cmd1 = new SqlCommand("SELECT DAY FROM f_day", con);
            using (SqlDataReader dr = m.ExecuteReader())
            {
                while (dr.Read())
                {
                    m1.Text = dr["p1"].ToString();
                    m2.Text = dr["p2"].ToString();
                    m3.Text = dr["p3"].ToString();
                    m4.Text = dr["p4"].ToString();
                    m5.Text = dr["p5"].ToString();
                    m6.Text = dr["p6"].ToString();
                    m7.Text = dr["p7"].ToString();

                }
            }
            using (SqlDataReader dr = t.ExecuteReader())
            {
                while (dr.Read())
                {
                    t1.Text = dr["p1"].ToString();
                    t2.Text = dr["p2"].ToString();
                    t3.Text = dr["p3"].ToString();
                    t4.Text = dr["p4"].ToString();
                    t5.Text = dr["p5"].ToString();
                    t6.Text = dr["p6"].ToString();
                    t7.Text = dr["p7"].ToString();

                }
            }

            using (SqlDataReader dr = w.ExecuteReader())
            {
                while (dr.Read())
                {
                    w1.Text = dr["p1"].ToString();
                    w2.Text = dr["p2"].ToString();
                    w3.Text = dr["p3"].ToString();
                    w4.Text = dr["p4"].ToString();
                    w5.Text = dr["p5"].ToString();
                    w6.Text = dr["p6"].ToString();
                    w7.Text = dr["p7"].ToString();

                }
            }

            using (SqlDataReader dr = th.ExecuteReader())
            {
                while (dr.Read())
                {
                    th1.Text = dr["p1"].ToString();
                    th2.Text = dr["p2"].ToString();
                    th3.Text = dr["p3"].ToString();
                    th4.Text = dr["p4"].ToString();
                    th5.Text = dr["p5"].ToString();
                    th6.Text = dr["p6"].ToString();
                    th7.Text = dr["p7"].ToString();

                }
            }

            using (SqlDataReader dr = f.ExecuteReader())
            {
                while (dr.Read())
                {
                    f1.Text = dr["p1"].ToString();
                    f2.Text = dr["p2"].ToString();
                    f3.Text = dr["p3"].ToString();
                    f4.Text = dr["p4"].ToString();
                    f5.Text = dr["p5"].ToString();
                    f6.Text = dr["p6"].ToString();
                    f7.Text = dr["p7"].ToString();

                }
            }
            using (SqlDataReader dr = cmd.ExecuteReader())
            {
                while (dr.Read())
                {
                    f_id.Items.Add(dr["f_id"]).ToString();

                }
            }
            using (SqlDataReader dr = cmd1.ExecuteReader())
            {

                while (dr.Read())
                {
                    day.Items.Add(dr["DAY"]).ToString();
                }
            }


            con.Close();
        }
        private void p1_Click(object sender, EventArgs e)
        {
            int i=0;
            while (i <= 1)
            {
                
                sel s = new sel(out p1_s, out p1_c);
                if(i==0)
                    s.ShowDialog();
                if (p1_s == "null" && p1_c == "null" || p1_s == null && p1_c == null || p1_s == "" || p1_c == "" || p1_s == "null" || p1_c == "null" || p1_s == null || p1_c == null)
                    p1.Text = "-";
                else
                    p1.Text = p1_s + "-" + p1_c;
                i++;
            }
        }

        private void p2_Click(object sender, EventArgs e)
        {
            int i = 0;
            while (i <= 1)
            {
                
                sel s = new sel(out p2_s, out p2_c);
                if (i == 0)
                    s.ShowDialog();
                if (p2_s == "null" && p2_c == "null" || p2_s == null && p2_c == null || p2_s == "" || p2_c == "" || p2_s == "null" || p2_c == "null" || p2_s == null || p2_c == null)
                    p2.Text = "-";
                else
                    p2.Text = p2_s + "-" + p2_c;
                i++;
            }
        }

        private void p3_Click(object sender, EventArgs e)
        {
            int i = 0;
            while (i <= 1)
            {
                
                sel s = new sel(out p3_s, out p3_c);
                if (i == 0)
                    s.ShowDialog();
                if (p3_s == "null" && p3_c == "null" || p3_s == null && p3_c == null || p3_s == "null" || p3_c == "null" || p3_s == null || p3_c == null||p3_s == "" || p3_c == "")
                    p3.Text = "-";
                else
                    p3.Text = p3_s + "-" + p3_c;
                i++;
            }
        }

        private void p4_Click(object sender, EventArgs e)
        {
            int i = 0;
            while (i <= 1)
            {
                
                sel s = new sel(out p4_s, out p4_c);
                if (i == 0)
                    s.ShowDialog();
                if (p4_s == "null" && p4_c == "null" || p4_s == null && p4_c == null || p4_s == "null" || p4_c == "null" || p4_s == null || p4_c == null || p4_s == "" || p4_c == "")
                    p4.Text = "-";
                else
                    p4.Text = p4_s + "-" + p4_c;
                i++;
            }
        }

        private void p5_Click(object sender, EventArgs e)
        {
            int i = 0;
            while (i <= 1)
            {
                
                sel s = new sel(out p5_s, out p5_c);
                if (i == 0)
                    s.ShowDialog();
                if (p5_s == "null" && p5_c == "null" || p5_s == null && p5_c == null || p5_s == "null" || p5_c == "null" || p5_s == null || p5_c == null || p5_s == "" || p5_c == "")
                    p5.Text = "-";
                else
                    p5.Text = p5_s + "-" + p5_c;
                i++;
            }
        }

        private void p6_Click(object sender, EventArgs e)
        {
            int i = 0;
            while (i <= 1)
            {
                
                sel s = new sel(out p6_s, out p6_c);
                if (i == 0)
                    s.ShowDialog();
                if (p6_s == "null" && p6_c == "null" || p6_s == null && p6_c == null || p6_s == "null" || p6_c == "null" || p6_s == null || p6_c == null || p6_s == "" || p6_c == "")
                    p6.Text = "-";
                else
                    p6.Text = p6_s + "-" + p6_c;
                i++;
            }
        }

        private void p7_Click(object sender, EventArgs e)
        {
            int i = 0;
            while (i <= 1)
            {
                
                sel s = new sel(out p7_s, out p7_c);
                if (i == 0)
                    s.ShowDialog();
                if (p7_s == "null" && p7_c == "null" || p7_s == null && p7_c == null || p7_s == "null" || p7_c == "null" || p7_s == null || p7_c == null || p7_s == "" || p7_c == "")
                    p7.Text = "-";
                else
                    p7.Text = p7_s + "-" + p7_c;
                i++;
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void lv_Click(object sender, EventArgs e)
        {

           

            if ((selectB == null) || (selectB == " ") || (selectB == "-")||(selectB).Length<1)
            {
                MessageBox.Show("This hour is free");
            }
            else
            {
                shows s = new shows(selectB,d,idd,hr);
                s.ShowDialog();
            }


        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void w5_Click(object sender, EventArgs e)
        {
            selection(w5);
            d = 'w';
            hr = "p5";
            selectB = w5.Text;

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void m4_Click(object sender, EventArgs e)
        {
            selection(m4);
            d = 'm';
            hr = "p4";
            selectB = m4.Text;
        }

        private void m5_Click(object sender, EventArgs e)
        {
            selection(m5);
            d = 'm';
            hr = "p5";
            selectB = m5.Text;
        }

        private void m6_Click(object sender, EventArgs e)
        {
            selection(m2);
            d = 'm';
            hr = "p6";
            selectB = m2.Text;
        }

        private void m7_Click(object sender, EventArgs e)
        {
            selection(m2);
            d = 'm';
            hr = "p7";
            selectB = m2.Text;
        }

        private void t1_Click(object sender, EventArgs e)
        {
            selection(t1);
            d = 't';
            hr = "p1";
            selectB = t1.Text;
        }

        private void t2_Click(object sender, EventArgs e)
        {
            selection(t2);
            d = 't';
            hr = "p2";
            selectB = t2.Text;
        }

        private void t3_Click(object sender, EventArgs e)
        {
            selection(t3);
            d = 't';
            hr = "p3";
            selectB = t3.Text;
        }

        private void t4_Click(object sender, EventArgs e)
        {
            selection(t4);
            d = 't';
            hr = "p4";
            selectB = t4.Text;
        }

        private void t5_Click(object sender, EventArgs e)
        {
            selection(t5);
            d = 't';
            hr = "p5";
            selectB = t5.Text;
        }

        private void t6_Click(object sender, EventArgs e)
        {
            selection(t6);
            d = 't';
            hr = "p6";
            selectB = t6.Text;
        }

        private void t7_Click(object sender, EventArgs e)
        {
            selection(t7);
            d = 't';
            hr = "p7";
            selectB = t7.Text;
        }

        private void w1_Click(object sender, EventArgs e)
        {
            selection(w1);
            d = 'w';
            hr = "p1";
            selectB = w1.Text;
        }

        private void w2_Click(object sender, EventArgs e)
        {
            selection(w2);
            d = 'w';
            hr = "p2";
            selectB = w2.Text;
        }

        private void w3_Click(object sender, EventArgs e)
        {
            hr = "p3";
            selection(w3);
            d = 'w';
            selectB = w3.Text;
        }

        private void w4_Click(object sender, EventArgs e)
        {
            selection(w4);
            d = 'w';
            hr = "p4";
            selectB = w4.Text;
        }

        private void w6_Click(object sender, EventArgs e)
        {
            selection(w6);
            d = 'w';
            hr = "p6";
            selectB = w6.Text;
        }

        private void w7_Click(object sender, EventArgs e)
        {
            selection(w7);
            d = 'w';
            hr = "p7";
            selectB = w7.Text;
        }

        private void th1_Click(object sender, EventArgs e)
        {
            selection(th1);
            d = 'p';
            hr = "p1";
            selectB = th1.Text;
        }

        private void th2_Click(object sender, EventArgs e)
        {
            selection(th2);
            d = 'p';
            hr = "p2";
            selectB = th2.Text;
        }

        private void th3_Click(object sender, EventArgs e)
        {
            selection(th3);
            d = 'p';
            hr = "p3";
            selectB = th3.Text;
        }

        private void th4_Click(object sender, EventArgs e)
        {
            selection(th4);
            d = 'p';
            hr = "p4";
            selectB = th4.Text;
        }

        private void th5_Click(object sender, EventArgs e)
        {
            selection(th5);
            d = 'p';
            hr = "p5";
            selectB = th5.Text;
        }

        private void th6_Click(object sender, EventArgs e)
        {
            selection(th6);
            d = 'p';
            hr = "p6";
            selectB = th6.Text;
        }

        private void th7_Click(object sender, EventArgs e)
        {
            hr = "p7";
            selection(th7);
            d = 'p';
            selectB = th7.Text;
        }

        private void f1_Click(object sender, EventArgs e)
        {
            selection(f1);
            d = 'f';
            hr = "p1";
            selectB = f1.Text;
        }

        private void f2_Click(object sender, EventArgs e)
        {
            selection(f2);
            d = 'f';
            hr = "p2";
            selectB = f2.Text;
        }

        private void f3_Click(object sender, EventArgs e)
        {
            selection(f3);
            d = 'f';
            hr = "p3";
            selectB = f3.Text;
        }

        private void f4_Click(object sender, EventArgs e)
        {
            selection(f4);
            d = 'f';
            hr = "p4";
            selectB = f4.Text;
        }

        private void f5_Click(object sender, EventArgs e)
        {
            selection(f5);
            hr = "p5";
            d = 'f';
            selectB = f5.Text;

        }

        private void f7_Click(object sender, EventArgs e)
        {
            selection(f7);
            d = 'f';
            hr = "p7";
            selectB = f7.Text;
        }

        private void cb_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            data d = new data();
            d.ShowDialog();
        }
    }
}
