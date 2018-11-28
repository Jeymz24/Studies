using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using SnmpSharpNet;


namespace pingapp2
{
    public partial class Form1 : Form
    {
        static string ip = "";
        static string ipGateWay;
        static string okiPrinterIp;
        static string country = "PL00";
        static int countGateWay;
        static int countBos;
        static int countPos01;
        static int countPos02;
        static int countPos03;
        static int countPos04;
        static int countOkiPrinter;
        static int countMusicBox;
        static int countAccessPoint;
        static int countEft1;
        static int countEft2;
        static int countEft3;
        static int countEft4;
        static bool giuseppe = true;
        bool _StillOpen = true;

        public Form1()
        {
            InitializeComponent();
            pictureBox1.Select();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.TextLength == 4)
            {
                button1.Enabled = true;
                button2.Enabled = true;
                button3.Enabled = true;
                button4.Enabled = true;
                button5.Enabled = true;
                button6.Enabled = true;
                button7.Enabled = true;
                
            }
            else
            {
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;
                button6.Enabled = false;
                button7.Enabled = false;
            }

            if (giuseppe == true)
            { 
                if (textBox1.Text.StartsWith("00"))
                {
                    country = "PL11";
                }
                else
                {
                    country = "PL00";
                }
            }
            clearAll();
            
        }

        //Methods


        private void hideFlags()
        {
            pictureBox1.Enabled = false;
            pictureBox2.Enabled = false;
            pictureBox3.Enabled = false;
            pictureBox4.Enabled = false;
            pictureBox5.Enabled = false;
            pictureBox6.Enabled = false;
            pictureBox7.Enabled = false;
            pictureBox8.Enabled = false;
            pictureBox9.Enabled = false;
            pictureBox10.Enabled = false;
        }
        private void showFlags()
        {
            pictureBox1.Enabled = true;
            pictureBox2.Enabled = true;
            pictureBox3.Enabled = true;
            pictureBox4.Enabled = true;
            pictureBox5.Enabled = true;
            pictureBox6.Enabled = true;
            pictureBox7.Enabled = true;
            pictureBox8.Enabled = true;
            pictureBox9.Enabled = true;
            pictureBox10.Enabled = true;
        }
        private void clearAll()
        {
            progressBar1.Value = 0;
            progressBar2.Value = 0;
            progressBar3.Value = 0;
            progressBar4.Value = 0;
            progressBar5.Value = 0;
            progressBar6.Value = 0;
            progressBar7.Value = 0;
            progressBar8.Value = 0;
            progressBar9.Value = 0;
            progressBar10.Value = 0;
            progressBar11.Value = 0;
            progressBar12.Value = 0;
            progressBar13.Value = 0;
            progressBar14.Value = 0;
            richTextBox1.Text = "";
            richTextBox2.Text = "";
            richTextBox3.Text = "";
            richTextBox4.Text = "";
            richTextBox5.Text = "";
            richTextBox6.Text = "";
            richTextBox7.Text = "";
            richTextBox8.Text = "";
            //richTextBox9.Text = "";
            richTextBox10.Text = "";
            richTextBox11.Text = "";
            richTextBox12.Text = "";
            richTextBox13.Text = "";
            richTextBox14.Text = "";
        }

        private string resolveAddress()
        {
            ip = country + textBox1.Text + "POS01";
            IPAddress[] addresslist = Dns.GetHostAddresses(ip);
            string ipRaw = "";
            foreach (IPAddress theaddress in addresslist)
            {
                ipRaw = theaddress.ToString();
                ipRaw = ipRaw.Trim();
                string[] words = ipRaw.Split('.');
                string end = words[3];
                Double endx = Convert.ToDouble(end) - 1;
                ipRaw = words[0] + '.' + words[1] + '.' + words[2] + '.' + endx;
            }
            return ipRaw;
        }

        private string getIpAddress(int ipEnd)
        {
            var ip = ipGateWay.Trim();
            string[] words = ipGateWay.Split('.');
            string end = words[3];
            Double endx = Convert.ToDouble(end) + ipEnd;
            ip = words[0] + '.' + words[1] + '.' + words[2] + '.' + endx;
            return ip;
        }

        public static bool PingHost(string nameOrAddress)
        {
            bool pingable = false;
            int timeout = 10;
            Ping pinger = new Ping();
            try
            {
                PingReply reply = pinger.Send(nameOrAddress, timeout);
                pingable = reply.Status == IPStatus.Success;
            }
            catch (PingException)
            {

                // Discard PingExceptions and return false;
            }
            return pingable;
        }

        //buttonki

        private void button1_Click(object sender, EventArgs e)
        {
            OpenVNC(country + textBox1.Text + "BOS01");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenVNC(country + textBox1.Text + "POS01");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenVNC(country + textBox1.Text + "POS02");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            OpenVNC(country + textBox1.Text + "POS03");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Enabled = false;
            _StillOpen = true;
            ipGateWay = null;
            button5.Enabled = false;
            button7.Enabled = true;

            try
            {
                ipGateWay = resolveAddress();
                richTextBox1.Text = getIpAddress(28);
                richTextBox2.Text = getIpAddress(130);
                richTextBox3.Text = getIpAddress(0);
                richTextBox4.Text = getIpAddress(1);
                richTextBox5.Text = getIpAddress(2);
                richTextBox6.Text = getIpAddress(3);
                richTextBox7.Text = getIpAddress(129);
                richTextBox8.Text = getIpAddress(29);
                //richTextBox9.Text = getIpAddress();
                richTextBox10.Text = getIpAddress(65);
                richTextBox11.Text = getIpAddress(66);
                richTextBox12.Text = getIpAddress(67);
                richTextBox13.Text = getIpAddress(68);
                richTextBox14.Text = getIpAddress(4);
                Application.DoEvents();

            }
            catch (Exception ex)
            {
                //...
            }


            if (ipGateWay != null)
            {
                while (_StillOpen)
                {
                    pingDev();
                    //System.Threading.Thread.Sleep(10);
                    Application.DoEvents();
                }
            }
            else
            {
                MessageBox.Show("DNS Problem");
                textBox1.Text = "";
                textBox1.Enabled = true;
            }
            //hideFlags();

            Application.DoEvents();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            OpenVNC(country + textBox1.Text + "POS04");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            _StillOpen = false;
            textBox1.Enabled = true;
            countGateWay = 0;
            countBos = 0;
            countPos01 = 0;
            countPos02 = 0;
            countPos03 = 0;
            countPos04 = 0;
            countOkiPrinter = 0;
            countMusicBox = 0;
            countAccessPoint = 0;
            countEft1 = 0;
            countEft2 = 0;
            countEft3 = 0;
            countEft4 = 0;
            Application.DoEvents();
            button5.Enabled = true;
            button7.Enabled = false;
            //showFlags();

        }


        static void OpenVNC(string file)
        {
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.FileName = @"C:\Program Files (x86)\RealVNC\VNC4\vncviewer.exe";
            startInfo.Arguments = file;
            Process.Start(startInfo);
        }

        //Ping

        private void pingDev()
        {
            pingGateWay();
            pingBos(28);
            pingPos01(1);
            pingPos02(2);
            pingPos03(3);
            pingPos04(4);
            pingOkiPrinter(29);
            pingEft1(65);
            pingEft2(66);
            pingEft3(67);
            pingEft4(68);
            pingMusicBox(129);
            pingAccessPoint(130);
        }

        private void pingOkiPrinter(int v)
        {
            var ip = getIpAddress(v);
            okiPrinterIp = ip;
            if (PingHost(ip))
            {
                progressBar8.ForeColor = Color.Green;
                progressBar8.Value += 10;
                if (progressBar8.Value == 100)
                {
                    progressBar8.Value = 0;
                }
            }

            else
            {
                countOkiPrinter++;
                if (countOkiPrinter > 5)
                {

                    progressBar8.ForeColor = Color.Maroon;
                    progressBar8.Value += 10;
                    if (progressBar8.Value == 100)
                    {
                        progressBar8.Value = 0;
                        countOkiPrinter = 0;
                    }
                    //MessageBox.Show($"{ip} nie pinga");
                }
                Application.DoEvents();
                progressBar8.ForeColor = Color.Maroon;
                progressBar8.ForeColor = Color.Maroon;
            }
        }

        private void pingMusicBox(int v)
        {
            var ip = getIpAddress(v);
            if (PingHost(ip))
            {
                progressBar9.ForeColor = Color.Green;
                progressBar9.Value += 10;
                if (progressBar9.Value == 100)
                {
                    progressBar9.Value = 0;
                }
            }
            else
            {
                countMusicBox++;

                if (countMusicBox > 5)
                {
                    progressBar9.ForeColor = Color.Maroon;
                    progressBar9.Value += 10;
                    if (progressBar9.Value == 100)
                    {
                        progressBar9.Value = 0;
                        countMusicBox = 0;
                    }
                    //MessageBox.Show($"{ip} nie pinga");
                }
                Application.DoEvents();
            }
        }

        private void pingPos03(int v)
        {
            var ip = getIpAddress(v);
            if (PingHost(ip))
            {
                progressBar4.ForeColor = Color.Green;
                progressBar4.Value += 10;
                if (progressBar4.Value == 100)
                {
                    progressBar4.Value = 0;
                }
            }
            else
            {
                countPos03++;
                if (countPos03 > 5)
                {
                    progressBar4.ForeColor = Color.Maroon;
                    progressBar4.Value += 10;
                    if (progressBar4.Value == 100)
                    {
                        progressBar4.Value = 0;
                        countPos03 = 0;
                    }
                    //MessageBox.Show($"{ip} nie pinga");
                }
            }
            Application.DoEvents();

        }

        private void pingPos04(int v)
        {
            var ip = getIpAddress(v);
            if (PingHost(ip))
            {
                progressBar14.ForeColor = Color.Green;
                progressBar14.Value += 10;
                if (progressBar14.Value == 100)
                {
                    progressBar14.Value = 0;
                }
            }
            else
            {
                countPos04++;
                if (countPos04 > 5)
                {
                    progressBar14.ForeColor = Color.Maroon;
                    progressBar14.Value += 10;
                    if (progressBar14.Value == 100)
                    {
                        progressBar14.Value = 0;
                        countPos04 = 0;
                    }
                    //MessageBox.Show($"{ip} nie pinga");
                }
            }
            Application.DoEvents();

        }

        private void pingPos02(int v)
        {
            var ip = getIpAddress(v);
            if (PingHost(ip))
            {
                progressBar5.ForeColor = Color.Green;
                progressBar5.Value += 10;
                if (progressBar5.Value == 100)
                {
                    progressBar5.Value = 0;
                }
            }
            else
            {
                countPos02++;
                if (countPos02 > 5)
                {
                    progressBar5.ForeColor = Color.Maroon;
                    progressBar5.Value += 10;
                    if (progressBar5.Value == 100)
                    {
                        progressBar5.Value = 0;
                        countPos02 = 0;
                    }
                    //MessageBox.Show($"{ip} nie pinga");
                }
            }
            Application.DoEvents();

        }

        private void pingPos01(int v)
        {
            var ip = getIpAddress(v);
            if (PingHost(ip))
            {
                progressBar6.ForeColor = Color.Green;
                progressBar6.Value += 10;
                if (progressBar6.Value == 100)
                {
                    progressBar6.Value = 0;
                }
            }
            else
            {
                countPos01++;
                if (countPos01 > 5)
                {
                    progressBar6.ForeColor = Color.Maroon;
                    progressBar6.Value += 10;
                    if (progressBar6.Value == 100)
                    {
                        progressBar6.Value = 0;
                        countPos01 = 0;
                    }
                    //MessageBox.Show($"{ip} nie pinga");
                }
            }
            Application.DoEvents();

        }

        private void pingAccessPoint(int v)
        {
            var ip = getIpAddress(v);
            if (PingHost(ip))
            {
                progressBar2.ForeColor = Color.Green;
                progressBar2.Value += 10;
                if (progressBar2.Value == 100)
                {
                    progressBar2.Value = 0;
                }
            }
            else
            {
                countAccessPoint++;
                if (countAccessPoint > 5)
                {
                    progressBar2.ForeColor = Color.Maroon;
                    progressBar2.Value += 10;
                    if (progressBar2.Value == 100)
                    {
                        progressBar2.Value = 0;
                        countAccessPoint = 0;
                    }
                    //MessageBox.Show($"{ip} nie pinga");
                }
            }
            Application.DoEvents();

        }

        private void pingGateWay()
        {
            var ip = ipGateWay;
            if (PingHost(ip))
            {
                progressBar1.ForeColor = Color.Green;
                progressBar1.Value += 10;
                if (progressBar1.Value == 100)
                {
                    progressBar1.Value = 0;
                }
            }
            else
            {
                countGateWay++;
                if (countGateWay > 5)
                {

                    progressBar1.ForeColor = Color.Maroon;
                    progressBar1.Value += 10;
                    if (progressBar1.Value == 100)
                    {
                        progressBar1.Value = 0;
                        countGateWay = 0;
                    }
                    //MessageBox.Show($"{ip} nie pinga");
                }
            }
            Application.DoEvents();

        }

        private void pingBos(int v)
        {
            var ip = getIpAddress(v);
            if (PingHost(ip))
            {
                progressBar3.ForeColor = Color.Green;
                progressBar3.Value += 10;
                if (progressBar3.Value == 100)
                {
                    progressBar3.Value = 0;
                }
            }
            else
            {
                countBos++;
                if (countBos > 5)
                {
                    progressBar3.ForeColor = Color.Maroon;
                    progressBar3.Value += 10;
                    if (progressBar3.Value == 100)
                    {
                        progressBar3.Value = 0;
                        countBos = 0;
                    }
                    //MessageBox.Show($"{ip} nie pinga");
                }
            }
            Application.DoEvents();

        }

        private void pingEft1(int v)
        {
            var ip = getIpAddress(v);
            if (PingHost(ip))
            {
                progressBar12.ForeColor = Color.Green;
                progressBar12.Value += 10;
                if (progressBar12.Value == 100)
                {
                    progressBar12.Value = 0;
                }
            }
            else
            {
                countEft1++;
                if (countEft1 > 5)
                {
                    progressBar12.ForeColor = Color.Maroon;
                    progressBar12.Value += 10;
                    if (progressBar12.Value == 100)
                    {
                        progressBar12.Value = 0;
                        countEft1 = 0;
                    }
                    //MessageBox.Show($"{ip} nie pinga");
                }
            }
            Application.DoEvents();

        }

        private void pingEft2(int v)
        {
            var ip = getIpAddress(v);
            if (PingHost(ip))
            {
                progressBar11.ForeColor = Color.Green;
                progressBar11.Value += 10;
                if (progressBar11.Value == 100)
                {
                    progressBar11.Value = 0;
                }
            }
            else
            {
                countEft2++;
                if (countEft2 > 5)
                {
                    progressBar11.ForeColor = Color.Maroon;
                    progressBar11.Value += 10;
                    if (progressBar11.Value == 100)
                    {
                        progressBar11.Value = 0;
                        countEft2 = 0;

                    }
                    //MessageBox.Show($"{ip} nie pinga");
                }
            }
            Application.DoEvents();

        }

        private void pingEft3(int v)
        {
            var ip = getIpAddress(v);
            if (PingHost(ip))
            {
                progressBar10.ForeColor = Color.Green;
                progressBar10.Value += 10;
                if (progressBar10.Value == 100)
                {
                    progressBar10.Value = 0;
                }
            }
            else
            {
                countEft3++;
                if (countEft3 > 5)
                {
                    progressBar10.ForeColor = Color.Maroon;
                    progressBar10.Value += 10;
                    if (progressBar10.Value == 100)
                    {
                        progressBar10.Value = 0;
                        countEft3 = 0;

                    }
                    //MessageBox.Show($"{ip} nie pinga");
                }
            }
            Application.DoEvents();

        }

        private void pingEft4(int v)
        {
            var ip = getIpAddress(v);
            if (PingHost(ip))
            {
                progressBar13.ForeColor = Color.Green;
                progressBar13.Value += 10;
                if (progressBar13.Value == 100)
                {
                    progressBar13.Value = 0;
                }
            }
            else
            {
                countEft4++;
                if (countEft4 > 5)
                {
                    progressBar13.ForeColor = Color.Maroon;
                    progressBar13.Value += 10;
                    if (progressBar13.Value == 100)
                    {
                        progressBar13.Value = 0;
                        countEft4 = 0;

                    }
                    //MessageBox.Show($"{ip} nie pinga");
                }
            }
            Application.DoEvents();

        }


        //labelki

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://" + okiPrinterIp);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            country = "PL00";
            if (textBox1.Text.StartsWith("00"))
            {
                country = "PL11";
            }
            else
            {
                country = "PL00";
            }
            label14.Text = "PL";
            giuseppe = true;
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;
            pictureBox2.BorderStyle = BorderStyle.None;
            pictureBox3.BorderStyle = BorderStyle.None;
            pictureBox4.BorderStyle = BorderStyle.None;
            pictureBox5.BorderStyle = BorderStyle.None;
            pictureBox6.BorderStyle = BorderStyle.None;
            pictureBox7.BorderStyle = BorderStyle.None;
            pictureBox8.BorderStyle = BorderStyle.None;
            pictureBox9.BorderStyle = BorderStyle.None;
            pictureBox10.BorderStyle = BorderStyle.None;
            clearAll();

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            country = "HR16";
            label14.Text = "HR";
            giuseppe = false;
            pictureBox1.BorderStyle = BorderStyle.None;
            pictureBox2.BorderStyle = BorderStyle.Fixed3D;
            pictureBox3.BorderStyle = BorderStyle.None;
            pictureBox4.BorderStyle = BorderStyle.None;
            pictureBox5.BorderStyle = BorderStyle.None;
            pictureBox6.BorderStyle = BorderStyle.None;
            pictureBox7.BorderStyle = BorderStyle.None;
            pictureBox8.BorderStyle = BorderStyle.None;
            pictureBox9.BorderStyle = BorderStyle.None;
            pictureBox10.BorderStyle = BorderStyle.None;
            clearAll();


        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            country = "SI17";
            label14.Text = "SI";
            giuseppe = false;
            pictureBox1.BorderStyle = BorderStyle.None;
            pictureBox2.BorderStyle = BorderStyle.None;
            pictureBox3.BorderStyle = BorderStyle.Fixed3D;
            pictureBox4.BorderStyle = BorderStyle.None;
            pictureBox5.BorderStyle = BorderStyle.None;
            pictureBox6.BorderStyle = BorderStyle.None;
            pictureBox7.BorderStyle = BorderStyle.None;
            pictureBox8.BorderStyle = BorderStyle.None;
            pictureBox9.BorderStyle = BorderStyle.None;
            pictureBox10.BorderStyle = BorderStyle.None;
            clearAll();

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            country = "SK00";
            if (textBox1.Text.StartsWith("00"))
            {
                country = "SK12";
            }
            else
            {
                country = "SK00";
            }
            label14.Text = "SK";
            giuseppe = false;
            pictureBox1.BorderStyle = BorderStyle.None;
            pictureBox2.BorderStyle = BorderStyle.None;
            pictureBox3.BorderStyle = BorderStyle.None;
            pictureBox4.BorderStyle = BorderStyle.Fixed3D;
            pictureBox5.BorderStyle = BorderStyle.None;
            pictureBox6.BorderStyle = BorderStyle.None;
            pictureBox7.BorderStyle = BorderStyle.None;
            pictureBox8.BorderStyle = BorderStyle.None;
            pictureBox9.BorderStyle = BorderStyle.None;
            pictureBox10.BorderStyle = BorderStyle.None;
            clearAll();

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            country = "CZ00";
            if (textBox1.Text.StartsWith("00"))
            {
                country = "CZ13";
            }
            else
            {
                country = "CZ00";
            }
            label14.Text = "CZ";
            giuseppe = false;
            pictureBox1.BorderStyle = BorderStyle.None;
            pictureBox2.BorderStyle = BorderStyle.None;
            pictureBox3.BorderStyle = BorderStyle.None;
            pictureBox4.BorderStyle = BorderStyle.None;
            pictureBox5.BorderStyle = BorderStyle.Fixed3D;
            pictureBox6.BorderStyle = BorderStyle.None;
            pictureBox7.BorderStyle = BorderStyle.None;
            pictureBox8.BorderStyle = BorderStyle.None;
            pictureBox9.BorderStyle = BorderStyle.None;
            pictureBox10.BorderStyle = BorderStyle.None;
            clearAll();

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            country = "RO00";
            if (textBox1.Text.StartsWith("00"))
            {
                country = "RO14";
            }
            else
            {
                country = "RO00";
            }
            label14.Text = "RO";
            giuseppe = false;
            pictureBox1.BorderStyle = BorderStyle.None;
            pictureBox2.BorderStyle = BorderStyle.None;
            pictureBox3.BorderStyle = BorderStyle.None;
            pictureBox4.BorderStyle = BorderStyle.None;
            pictureBox5.BorderStyle = BorderStyle.None;
            pictureBox6.BorderStyle = BorderStyle.Fixed3D;
            pictureBox7.BorderStyle = BorderStyle.None;
            pictureBox8.BorderStyle = BorderStyle.None;
            pictureBox9.BorderStyle = BorderStyle.None;
            pictureBox10.BorderStyle = BorderStyle.None;
            clearAll();

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            
            country = "HU00";
            if (textBox1.Text.StartsWith("00"))
            {
                country = "HU15";
            }
            else
            {
                country = "HU00";
            }
            label14.Text = "HU";
            giuseppe = false;
            pictureBox1.BorderStyle = BorderStyle.None;
            pictureBox2.BorderStyle = BorderStyle.None;
            pictureBox3.BorderStyle = BorderStyle.None;
            pictureBox4.BorderStyle = BorderStyle.None;
            pictureBox5.BorderStyle = BorderStyle.None;
            pictureBox6.BorderStyle = BorderStyle.None;
            pictureBox7.BorderStyle = BorderStyle.Fixed3D;
            pictureBox8.BorderStyle = BorderStyle.None;
            pictureBox9.BorderStyle = BorderStyle.None;
            pictureBox10.BorderStyle = BorderStyle.None;
            clearAll();


        }

        private void label3_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start(@"\\" + country + textBox1.Text + "BOS01"+@"\c$\");
            }
            catch (Exception exception)
            {
                MessageBox.Show("Brak uprawnień");
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start(@"\\" + country + textBox1.Text + "POS01"+@"\c$\");
            }
            catch (Exception exception)
            {
                MessageBox.Show("Brak uprawnień");
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start(@"\\" + country + textBox1.Text + "POS02"+ @"\c$\");
            }
            catch (Exception exception)
            {
                MessageBox.Show("Brak uprawnień");
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start(@"\\" + country + textBox1.Text + "POS03" + @"\c$\");
            }
            catch (Exception exception)
            {
                MessageBox.Show("Brak uprawnień");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            country = "LT18";
            label14.Text = "LT";
            giuseppe = false;
            pictureBox1.BorderStyle = BorderStyle.None;
            pictureBox2.BorderStyle = BorderStyle.None;
            pictureBox3.BorderStyle = BorderStyle.None;
            pictureBox4.BorderStyle = BorderStyle.None;
            pictureBox5.BorderStyle = BorderStyle.None;
            pictureBox6.BorderStyle = BorderStyle.None;
            pictureBox7.BorderStyle = BorderStyle.None;
            pictureBox8.BorderStyle = BorderStyle.Fixed3D;
            pictureBox9.BorderStyle = BorderStyle.None;
            pictureBox10.BorderStyle = BorderStyle.None;
            clearAll();

        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            country = "LV19";
            label14.Text = "LV";
            giuseppe = false;
            pictureBox1.BorderStyle = BorderStyle.None;
            pictureBox2.BorderStyle = BorderStyle.None;
            pictureBox3.BorderStyle = BorderStyle.None;
            pictureBox4.BorderStyle = BorderStyle.None;
            pictureBox5.BorderStyle = BorderStyle.None;
            pictureBox6.BorderStyle = BorderStyle.None;
            pictureBox7.BorderStyle = BorderStyle.None;
            pictureBox8.BorderStyle = BorderStyle.None;
            pictureBox9.BorderStyle = BorderStyle.Fixed3D;
            pictureBox10.BorderStyle = BorderStyle.None;
            clearAll();

        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            country = "EE20";
            label14.Text = "EE";
            giuseppe = false;
            pictureBox1.BorderStyle = BorderStyle.None;
            pictureBox2.BorderStyle = BorderStyle.None;
            pictureBox3.BorderStyle = BorderStyle.None;
            pictureBox4.BorderStyle = BorderStyle.None;
            pictureBox5.BorderStyle = BorderStyle.None;
            pictureBox6.BorderStyle = BorderStyle.None;
            pictureBox7.BorderStyle = BorderStyle.None;
            pictureBox8.BorderStyle = BorderStyle.None;
            pictureBox9.BorderStyle = BorderStyle.None;
            pictureBox10.BorderStyle = BorderStyle.Fixed3D;
            clearAll();

        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.Show();
            this.WindowState = FormWindowState.Minimized;

        }
    }
}