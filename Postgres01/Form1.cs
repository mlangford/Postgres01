using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

using Npgsql;

namespace Postgres01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        NpgsqlConnection dbConnection;

        private void btnOpen_Click(object sender, EventArgs e)
        {
            try
            {          
                // make a connection object using the SQLite dataprovider
                if (rbHome.Checked) { 
                 dbConnection = new NpgsqlConnection(dbSource.home);
                }
                else {
                 dbConnection = new NpgsqlConnection(dbSource.work);
                }

                //try to open the connection
                dbConnection.Open();
                label1.Text = "Connection state: " + dbConnection.State.ToString();
                btnOpen.Enabled = false;
                btnClose.Enabled = true;
            }
            catch (Exception msg)
            {
                MessageBox.Show(msg.ToString());
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            //try to close the connection
            dbConnection.Close();
            label1.Text = "Connection state: " + dbConnection.State.ToString();
            btnOpen.Enabled = true;
            btnClose.Enabled = false;
        }
    }
}
