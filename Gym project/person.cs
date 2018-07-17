using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Gym_project
{
    class person
    {
        public int id;
        public string name;
        public person(){
            id = 0;
            name = " ";

       
    }
        public person(int i, string n)
        {
            id = i;
            name = n;
        }

        public virtual  void add(){
 }
        public virtual void update()
        {
        }
        public virtual void delete() { }
        //public abstract DataTable search(string name);
        //public abstract DataTable display();
    }

    class Customers : person
    {
        SqlConnection con = new SqlConnection("Data Source=(local);Initial Catalog=GYM;Integrated Security=True");
        SqlCommand cmd;
        SqlDataReader reader;
        public DateTime froms, tos;
        public int cost;
        public int kind_of_exer;
        public Customers()
        {
            this.name = " ";
            this.cost = 0;
            this.froms = DateTime.Now;
            this.tos = DateTime.Now;
            this.kind_of_exer = 1;
        }

        public Customers(int id, string name, int cost, DateTime froms, DateTime tos, int kind_of_exer)
        {
            this.name = name;
            this.cost = cost;
            this.froms = DateTime.Now;
            this.tos = DateTime.Now;
            this.kind_of_exer = kind_of_exer;
        }
        public virtual void add(Customers c1)
        {
            con.Open();
            cmd = new SqlCommand("insert into customer values('" + c1.name + "','" + c1.cost + "','" + c1.froms + "','" + c1.tos + "','" + c1.kind_of_exer + "'); ", con);
            cmd.CommandType = CommandType.Text;
            reader = cmd.ExecuteReader();
            MessageBox.Show("Your Registeration was sucsessful");
            reader.Close();
            con.Close();
        }


        public virtual void update(Customers c1, string n)
        {
            SqlCommand cmd;
            SqlDataReader reader;
            con.Open();
            cmd = new SqlCommand("update Customer set name='" + c1.name + "', cost='" + c1.cost + "', froms='" + c1.froms + "', Tos='" + c1.tos + "', kind_of_exer_id='" + c1.kind_of_exer + "'", con);
            cmd.CommandType = CommandType.Text;
            reader = cmd.ExecuteReader();
            MessageBox.Show("Your Update was sucsessful");
            reader.Close();
            con.Close();
        }
        public virtual void delete(Customers c1, string n)
        {
             con.Open();
            cmd = new SqlCommand("delete from Customer where Customers_Name='" + name + "'", con);
            cmd.CommandType = CommandType.Text;
            reader = cmd.ExecuteReader();
            MessageBox.Show("Your delete was sucsessful");
            reader.Close();
            con.Close();

        }

        //public override DataTable search(string name)
        //{

            

        //    DataTable dt_grid_info = new DataTable();
        //    SqlDataAdapter da_show_info;
        //    con.Open();
        //    dt_grid_info.Clear();
        //    da_show_info = new SqlDataAdapter("select Customer.ID,Customer.Customers_Name,Customer.Cost,Customer.Froms,Customer.Tos,Kind_of_equip_or_exer.kind_Name,Customer.Acount,Customer.Passwords,Gender.Kind from Customer inner join Kind_of_equip_or_exer on Customer.kind_of_exer_id=Kind_of_equip_or_exer.ID inner join Gender on Customer.gender_id=Gender.ID where Customers_Name='" + name + "'", con);
        //    da_show_info.Fill(dt_grid_info);
        //    con.Close();
        //    return dt_grid_info;
        //}


        //public override DataTable display()
        //{

            
        //    DataTable dt_grid_info = new DataTable();
        //    SqlDataAdapter da_show_info;
        //    con.Open();
        //    dt_grid_info.Clear();
        //    da_show_info = new SqlDataAdapter("select Customer.ID,Customer.Customers_Name,Customer.Cost,Customer.Froms,Customer.Tos,Kind_of_equip_or_exer.kind_Name,Customer.Acount,Customer.Passwords,Gender.Kind from Customer inner join Kind_of_equip_or_exer on Customer.kind_of_exer_id=Kind_of_equip_or_exer.ID inner join Gender on Customer.gender_id=Gender.ID", con);
        //    da_show_info.Fill(dt_grid_info);
        //    con.Close();
        //    return dt_grid_info;

        //}
            

        }
    }

