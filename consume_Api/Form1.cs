using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using API;

namespace consume_Api
{
    public partial class Form1 : Form
    {
        API.API api = new API.API();
        public Form1()
        {
            InitializeComponent();
            button1.Click += Button1_Click;
            txthost.ForeColor= SystemColors.GrayText;
            txthost.Text = "-- HOST --";
            txthost.Leave += new System.EventHandler(this.Txthost_Leave);
            txthost.Enter += new System.EventHandler(this.Txthost_Enter);


        }

        private void Txthost_Enter(object sender, EventArgs e)
        {
            if (txthost.Text== "-- HOST --")
            {
                txthost.Text =string.Empty;
                txthost.ForeColor = SystemColors.WindowText;
            }
        }

        private void Txthost_Leave(object sender, EventArgs e)
        {
            if (txthost.Text.Length==0)
            {
                txthost.Text = "-- HOST --";
                txthost.ForeColor = SystemColors.GrayText;
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            var message = api.postJson(txthost.Text,textBox1.Text);
            textBox2.Text = message.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
