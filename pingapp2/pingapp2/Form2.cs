using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SnmpSharpNet;
using System.Net;
using System.Net.NetworkInformation;
using System.Diagnostics;
using System.Text.RegularExpressions;

namespace pingapp2
{
    public partial class Form2 : Form
    {
        

        public Form2()
        {
            InitializeComponent();
            comboBox1.Visible = false;
            comboBox21.Visible = false;
            ramBar.Visible = false;
            cpuBar.Visible = false;
            tempBar.Visible = false;
            inkBar.Visible = false;
            label2.Visible = false;
            label31.Visible = false;
            label41.Visible = false;
            label51.Visible = false;
            button13.Enabled = false;
            
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string pattern = @"^([1-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])(\.([0-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])){3}$";
            Regex check = new Regex(pattern);

            if (check.IsMatch(textBox13.Text))
            {
                button13.Enabled = true;
            }
            else
            {
                button13.Enabled = false;
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string pattern = @"^([1-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])(\.([0-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])){3}$";
            Regex check = new Regex(pattern);

            if (check.IsMatch(textBox13.Text))
            {
                Ping ping = new Ping();
                PingReply reply = ping.Send(textBox13.Text, 1000);
                MessageBox.Show(reply.Status.ToString());
            }

            if (printerCheck.Checked)
            {
                
            }


         }

        private void pcCheck_click(object sender, EventArgs e)
        {
            float procesor = cpuBar.Value;
            float temperatura = tempBar.Value;
            float ram = ramBar.Value;

            switch (pcCheck.CheckState)
            {
                case CheckState.Checked:
                    printerCheck.Enabled = false;
                    comboBox1.Visible = false;
                    comboBox21.Visible = true;
                    cpuBar.Visible = true;
                    tempBar.Visible = true;
                    ramBar.Visible = true;
                    cpuBar.Increment(1);
                    label2.Text = procesor + " %" .ToString();
                    label31.Text = temperatura + " °C".ToString();
                    label41.Text = ram + " MB".ToString();
                    label2.Visible = true;
                    label31.Visible = true;
                    label41.Visible = true;
                    label51.Visible = false;
                    break;

                case CheckState.Unchecked:
                    printerCheck.Enabled = true;
                    comboBox1.Visible = false;
                    comboBox21.Visible = false;
                    cpuBar.Visible = false;
                    tempBar.Visible = false;
                    ramBar.Visible = false;
                    label2.Visible = false;
                    label31.Visible = false;
                    label41.Visible = false;
                    label51.Visible = false;
                    break;
            }
        }

  

        private void printerCheck_click(object sender, EventArgs e)
        {
            float toner = inkBar.Value;
            switch (printerCheck.CheckState)
            {
                case CheckState.Checked:
                    pcCheck.Enabled = false;
                    comboBox1.Visible = true;
                    inkBar.Visible = true;
                    label2.Visible = false;
                    label31.Visible = false;
                    label41.Visible = false;
                    label51.Visible = true;
                    label51.Text = toner + " %".ToString();
                    break;
                case CheckState.Unchecked:
                    pcCheck.Enabled = true;
                    comboBox1.Visible = false;
                    inkBar.Visible = false;
                    label2.Visible = false;
                    label31.Visible = false;
                    label41.Visible = false;
                    label51.Visible = false;
                    break;
            }
        }

       

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

    }
}
