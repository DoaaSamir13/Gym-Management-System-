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
    public partial class welcome : Form
    {
        public welcome()
        {
            InitializeComponent();

            #region paramter
            SqlConnection con = new SqlConnection("Data Source=(local);Initial Catalog=GYM;Integrated Security=True");
            DataTable dt_grid_info = new DataTable();
            SqlDataAdapter da_show_info;

            #endregion

            //con.Open();
            //dt_grid_info.Clear();
            //da_show_info = new SqlDataAdapter("select trainer.id,trainer.name,halls.name,manager.name from trainer inner join halls on trainer.halls_id=halls.id inner join manager on trainer.manager_id=manager.id", con);
            //da_show_info.Fill(dt_grid_info);
            //dataGridView1.DataSource = dt_grid_info;
            con.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            cust f2 = new cust();
            f2.ShowDialog();
        }
    }
}
