using System;
using System.Windows.Forms;
using System.Diagnostics;
using System.Net;
using System.Net.Sockets;
using OpenHardwareMonitor.Hardware;
using System.IO;
using System.Text;
using ConsoleRedirection;

namespace AdminHelperAgent
{
    public partial class Form1 : Form
    {
        const int port = 3333;
        TextWriter writer = null;

        PerformanceCounter perfCPUcounter = new PerformanceCounter("Processor Information", "% User Time", "_Total");
        PerformanceCounter perfMEMcounter = new PerformanceCounter("Memory", "Available MBytes");
        PerformanceCounter perfSyscounter = new PerformanceCounter("System", "System Up Time");
        private TcpListener server = new TcpListener(IPAddress.Any, port);
       

        public  Form1()
        {
            InitializeComponent();

            MaximizeBox = false;

            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }


        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            bool MousePointerNotOnTaskBar = Screen.GetWorkingArea(this).Contains(Cursor.Position);

            string localIP = "?";
            IPHostEntry host;
            host = Dns.GetHostEntry(Dns.GetHostName());

            String hostName = Dns.GetHostName();

            foreach (IPAddress ip in host.AddressList)
            {
                if (ip.AddressFamily.ToString() == "InterNetwork")
                {
                    localIP = ip.ToString();
                }
            }


            if (this.WindowState == FormWindowState.Minimized && MousePointerNotOnTaskBar)
            {

                this.ShowInTaskbar = false;
                notifyIcon1.Visible = true;
                notifyIcon1.Text = "AdminHelperAgent\n" + "Adres IP: " + localIP + "\n" + "Nazwa: " + hostName;

            }
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.WindowState = FormWindowState.Normal;

            if (this.WindowState == FormWindowState.Normal)
            {
                this.ShowInTaskbar = true;
                notifyIcon1.Visible = false;
            }
        }

        

        public class UpdateVisitor : IVisitor
        {
            public void VisitComputer(IComputer computer)
            {
                computer.Traverse(this);
            }
            public void VisitHardware(IHardware hardware)
            {
                hardware.Update();
                foreach (IHardware subHardware in hardware.SubHardware) subHardware.Accept(this);
            }
            public void VisitSensor(ISensor sensor) { }
            public void VisitParameter(IParameter parameter) { }
        }
        static void GetSystemInfo()
        {
            UpdateVisitor updateVisitor = new UpdateVisitor();
            Computer computer = new Computer();
            computer.Open();
            computer.CPUEnabled = true;
            computer.Accept(updateVisitor);
            for (int i = 0; i < computer.Hardware.Length; i++)
            {
                if (computer.Hardware[i].HardwareType == HardwareType.CPU)
                {
                    for (int j = 0; j < computer.Hardware[i].Sensors.Length; j++)
                    {
                        if (computer.Hardware[i].Sensors[j].SensorType == SensorType.Temperature)
                            Console.WriteLine(computer.Hardware[i].Sensors[j].Name + ":" + computer.Hardware[i].Sensors[j].Value.ToString() + "\r");
                            
                    }
                }
            }
            computer.Close();

   
            
        }

        public TimeSpan UpTime
        {
            get
            {
                using ( var uptime = new PerformanceCounter("System", "System Up Time"))
                {
                    uptime.NextValue();
                    return TimeSpan.FromSeconds(uptime.NextValue());
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label3.Text = "CPU Usage: " + " " + (int)perfCPUcounter.NextValue() + " %";
            label4.Text = "Available Memory: " + " " + (int)perfMEMcounter.NextValue() + " MB";
            label5.Text = "System Up Time: " + " " + UpTime   + " Hours";
            label1.Text = "CPU Temp: " ;

            
        }

        private string Console_Load(Form1 form1)
        {
            writer = new TextBoxStreamWriter(textBox1);
            Console.SetOut(writer);
            throw new NotImplementedException();
        }
    }
}
