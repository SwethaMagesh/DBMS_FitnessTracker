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
    public partial class DietLog : Form
    {
        public static string constr = System.Configuration.ConfigurationManager.ConnectionStrings["myConStr"].ConnectionString;
            MySqlConnection con1 = new MySqlConnection(constr);

        public DietLog()
        {
            InitializeComponent();
        }

       
    }

}
