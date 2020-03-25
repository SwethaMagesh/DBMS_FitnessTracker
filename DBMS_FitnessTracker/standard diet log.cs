﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace DBMS_FitnessTracker
{
    public partial class standard_diet_log : Form
    {
        int i = 1;
        public static string constr1 = System.Configuration.ConfigurationManager.ConnectionStrings["myConStr"].ConnectionString;
        MySqlConnection condatabase = new MySqlConnection(constr1);
        public standard_diet_log()
        {
            InitializeComponent();
            setact();
        }
        void setact()
        {
            
            Label label;
            TextBox textbox;
            condatabase.Open();
            string Query = "select * from ft.mustdo natural join ft.activitymaster;";
            MySqlCommand cmd = new MySqlCommand(Query,condatabase);
            MySqlDataReader myReader;
            myReader = cmd.ExecuteReader();
            while(myReader.Read())
            {
                label = new Label();
                label.Name = "lbl" + i.ToString();
                //label.Tag = i.ToString();
                label.Text = myReader.GetString("ActivityName");
                label.AutoSize = true;
                label.Location = new Point(130, i * 25);
                textbox = new TextBox();
                textbox.Text = myReader.GetString("ActDuration");
                //textbox.Tag = i.ToString();
                textbox.Name = "txt" + i.ToString();
                textbox.Location = new Point(200, i * 25);
                this.Controls.Add(label);
                this.Controls.Add(textbox);
                i++;                 
            }            
            condatabase.Close();         
        }     
        private void standard_diet_log_Load(object sender, EventArgs e)
        {

        }

        private void richTextBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int k;
            string[] t = new string[50];
            string[] s = new string[50];
            for (k = 1; k <i; k++)
            {              
                 t[k] = ((TextBox)this.Controls["txt" + k.ToString()]).Text;
                 s[k] = ((Label)this.Controls["lbl"+k.ToString()]).Text;
            }
            for (int j=1;j<k;j++)
            {
                condatabase.Open();
                string Query = "update  mustdo set Actduration=" +t[j] + " where ActivityID in (select ActivityID from activitymaster where ActivityName='" + s[j]+ "');";
                MySqlCommand cmd = new MySqlCommand(Query, condatabase);
                cmd.ExecuteNonQuery();
                condatabase.Close();
            }
            MessageBox.Show("Saved Successfully");            
        }

        private void label35_Click(object sender, EventArgs e)
        {

        }
    }
}
