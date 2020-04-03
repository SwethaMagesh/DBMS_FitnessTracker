﻿using System.Windows.Forms;
using System.Collections.Specialized;
using System;
using MySql.Data.MySqlClient;
using System.Globalization;

namespace DBMS_FitnessTracker
{
   


    public partial class UserPage : Form
    {
        public static string constr = System.Configuration.ConfigurationManager.ConnectionStrings["myConStr"].ConnectionString;
        MySqlConnection con1 = new MySqlConnection(constr);
        public static string res ="1",dob="",cur="";
        public UserPage()
        {
            InitializeComponent();
        }

        public int findUID()
        {
            string cmds = "Select max(userid)+1 as id from ft.user";
            MySqlCommand cmd = new MySqlCommand(cmds, con1);
            try
            {
                con1.Open();
                MySqlDataReader dr = cmd.ExecuteReader();
                
                if (dr.Read() && !dr.IsDBNull(0))
                {

                    res = dr.GetInt16(0).ToString();
                  
                }


            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            con1.Close();
            return 0;
        }
        private void Save_Click(object sender, System.EventArgs e)
        {
            dob = agebox.Value.ToString("yyyy-MM-dd");
            findUID();
            string gender = string.Empty;
            if (male.Checked && female.Checked)
                MessageBox.Show("Select one gender");
            if (male.Checked)
                gender = "Male";
            else if (female.Checked)
                gender = "Female";
            else
                MessageBox.Show("Please select a gender:");
            
            string height = ht.Value.ToString();
            string weight = wt.Value.ToString();
            
            string Query = "insert into user (userid,name,dob,gender,phoneNo,email,height,weight,category) values ("+res+",'" + name.Text + "','" + dob + "','" + gender + "','" + phone.Text + "','" + email.Text + "'," + height + "," + weight +",'"+ category.SelectedItem.ToString()+"');";
            MySqlCommand cmd = new MySqlCommand(Query, con1);


            try 
            {
                
                con1.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Saved Successfully");
                con1.Close();
              //  this.Close();

            }
            catch (MySqlException error)
            {
                MessageBox.Show(error.Message);
            }
            catch (SystemException er)
            {
                MessageBox.Show(er.Message);
            }
            con1.Close();
            

        }

        private void Updatenew_Click(object sender, EventArgs e)
        {
            dob = agebox.Value.ToString("yyyy-MM-dd");

            string gender = string.Empty;
            if (male.Checked && female.Checked)
                MessageBox.Show("Select one gender");
            if (male.Checked)
                gender = "Male";
            else if (female.Checked)
                gender = "Female";
            else
                MessageBox.Show("Please select a gender:");

            string height = ht.Value.ToString();
            string weight = wt.Value.ToString();

            string Query = "update user set dob='" + dob + "',gender='" + gender + "',weight=" + weight + ",height=" + height + ",category='" + category.SelectedItem + "',phoneNo='" + phone.Text + "',email='" + email.Text + "' where name='" + name.Text + "' and userid=" + cur;
            MySqlCommand cmd = new MySqlCommand(Query, con1);


            try
            {

                con1.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Saved Successfully");
                con1.Close();
                //  this.Close();

            }
            catch (MySqlException error)
            {
                MessageBox.Show(error.Message);
            }
            catch (SystemException er)
            {
                MessageBox.Show(er.Message);
            }
            con1.Close();



        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        

        private void UserPage_Load(object sender, EventArgs e)
        {
            findUID();
            string q = "Select dob,gender,height,weight,category,phoneNo,email,userid from user where name='" + Program.userName + "';";
            MySqlCommand cmd = new MySqlCommand(q, con1);
            if(Program.userName!="")
            {
                try
                {
                    con1.Open();
                    MySqlDataReader dr = cmd.ExecuteReader();
                    while(dr.Read())
                    {
                        cur = dr.GetString(7);
                        phone.Text = dr.GetString(5);
                        email.Text = dr.GetString(6);
                        ht.Value = dr.GetInt16(2);
                        wt.Value = dr.GetInt16(3);
                        category.SelectedItem = dr.GetString(4);
                        string temp = dr.GetString(1);
                        if (temp == "Male")
                            male.Checked = true;
                        else
                            female.Checked = true;
                        temp = dr.GetString(0);
                        //MessageBox.Show(temp);
                        DateTime test= DateTime.ParseExact(temp, "dd-MM-yyyy hh:mm:ss", CultureInfo.InvariantCulture);
                        //MessageBox.Show(test.ToString());
                        agebox.Value = test;
                        name.Text = Program.userName;

                    }
                }
                catch(MySqlException er)
                { MessageBox.Show(er.Message); }
                con1.Close();
            }
        }

        

        


    }
}
