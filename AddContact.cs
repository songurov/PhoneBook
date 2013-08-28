using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Finisar.SQLite;

namespace PhoneBook
{
    public partial class AddContact : Form
    {
        workDataBase work = new workDataBase();
        
        public AddContact()
        {
            InitializeComponent();
            string txtSQLQuery = "SELECT * FROM data ";
            Select(txtSQLQuery);
        }
        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        public bool AddUser()
        {	
            string txtSQLQuery = "insert into  data (fam,name,prename,telefon) values ('" + textBox2.Text + "','" + textBox1.Text + "','" + textBox3.Text + "','" + textBox4.Text + "')";
            work.ExecuteQuery(txtSQLQuery);
            return true;
        }
        public bool DeleteUser()
        {
            string txtSQLQuery = "DELETE FROM data WHERE ID = '" + listView1.FocusedItem.Text + "'";
            work.ExecuteQuery(txtSQLQuery);  
            return true;
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
        	
			if (AddUser() == true)
            {
			
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();

                textBox2.Focus();
            }
            else
            {
                MessageBox.Show("Probleme cu Baza de date.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DeleteUser();
        }
        public void Select(string txtguery)
        {
            work.SetConnection();
            work.sql_con.Open();
            work.sql_cmd = work.sql_con.CreateCommand();
            work.sql_cmd.CommandText = txtguery;
            work.sql_read = work.sql_cmd.ExecuteReader();

            while (work.sql_read.Read())
            {
                ListViewItem s = listView1.Items.Add(work.sql_read["id"].ToString());
                s.SubItems.Add(work.sql_read["fam"].ToString());
                s.SubItems.Add(work.sql_read["name"].ToString());
                s.SubItems.Add(work.sql_read["prename"].ToString());
                s.SubItems.Add(work.sql_read["telefon"].ToString());
            }

            work.sql_con.Close();


        }
        private void button4_Click(object sender, EventArgs e)
        {
            
        }
    }
}
