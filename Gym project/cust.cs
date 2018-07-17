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

namespace Gym_project
{
    public partial class cust : Form
    {
        SqlConnection con = new SqlConnection("Data Source=(local);Initial Catalog=GYM;Integrated Security=True");

        public cust()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtname.Text != string.Empty&& kindofexer.Text != string.Empty && combcost.Text != string.Empty&&txtfrom.Text != string.Empty&&txtto.Text != string.Empty)
            {
                string name = txtname.Text;
                string df = txtfrom.Text.ToString();
                string dt = txtto.Text.ToString();
                DateTime dtf = Convert.ToDateTime(df);
                DateTime dtt = Convert.ToDateTime(dt);
               // int cos = Int32.Parse(combcost.Text);
                if (dtt > dtf)
                {
                    MessageBox.Show("rrr");
                    int x = 0,y=0;
                    con.Open();
                    if (combcost.Text.Equals("fitness 120"))
                    {
                        x = 120;
                    }

                    else if (combcost.Text.Equals("body building 140"))
                    {
                        x = 140;
                    }
                    if (kindofexer.Text.Equals("fitness"))
                    {
                        y = 1;
                    }

                    else if (kindofexer.Text.Equals("body building"))
                    {
                        y = 2;
                    }

                    Customers c1 = new Customers();
                    c1.name = txtname.Text;
                    c1.cost = x;
                    c1.froms = dtf;
                    c1.tos = dtt;
                    c1.kind_of_exer = y;
                    c1.add(c1);
                    con.Close();
                }

                else
                {
                    MessageBox.Show("Please check your End Date");
                }
            }

                     else
                    {
                        MessageBox.Show("Please make sure that you have entered all the information");
                    }
            }


        private void cust_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            con.Open();
            Customers c1 = new Customers();
            string name = txtname.Text;
            c1.delete(c1,name);
            con.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (txtname.Text != string.Empty && kindofexer.Text != string.Empty && combcost.Text != string.Empty && txtfrom.Text != string.Empty && txtto.Text != string.Empty)
            {
                string name = txtname.Text;
                string df = txtfrom.Text.ToString();
                string dt = txtto.Text.ToString();
                DateTime dtf = Convert.ToDateTime(df);
                DateTime dtt = Convert.ToDateTime(dt);
                // int cos = Int32.Parse(combcost.Text);
                if (dtt > dtf)
                {
                    int x = 0, y = 0;
                    con.Open();
                    if (combcost.Text.Equals("fitness 120"))
                    {
                        x = 120;
                    }

                    else if (combcost.Text.Equals("body building 140"))
                    {
                        x = 140;
                    }
                    if (kindofexer.Text.Equals("fitness"))
                    {
                        y = 1;
                    }

                    else if (kindofexer.Text.Equals("body building"))
                    {
                        y = 2;
                    }
                    Customers c1 = new Customers();
                    c1.name = txtname.Text;
                    c1.cost = x;
                    c1.froms = dtf;
                    c1.tos = dtt;
                    c1.kind_of_exer = y;
                    c1.update(c1,name);
                    con.Close();
                }

                else
                {
                    MessageBox.Show("Please check your End Date");
                }
            }

            else
            {
                MessageBox.Show("Please make sure that you have entered all the information");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            #region paramter

            DataTable dt_grid_info = new DataTable();
            SqlDataAdapter da_show_info;

            #endregion

            con.Open();
            dt_grid_info.Clear();
            da_show_info = new SqlDataAdapter("select trainer.name,halls.name,trainer.froms,trainer.tos from trainer inner join halls on trainer.halls_id=halls.id", con);
            da_show_info.Fill(dt_grid_info);
            dataGridView1.DataSource = dt_grid_info;
            con.Close();
            
        }

        private void combcost_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        }
    }



