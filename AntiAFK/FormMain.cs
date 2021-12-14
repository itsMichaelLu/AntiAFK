using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AutoHotkey.Interop;
using System.Diagnostics;

namespace AntiAFK
{
    public partial class FormMain : Form
    {
        Logger logger;
        int pid = -1;
        string pname = "";
        AutoHotkeyEngine ahk;
        AhkWrapper ahki;
        System.Threading.Thread thread;



        public FormMain()
        {
            InitializeComponent();
            Globals.logger = new Logger(txtbox_Log);
            this.logger = Globals.logger;
            this.ahk = Globals.ahk;
            this.ahki = new AhkWrapper(this.ahk);

            // Main thread
            this.thread = null;
        }
        static public int GetProcessID(String pname)
        {
            //Process p = Process.GetCurrentProcess();
            Process[] p = Process.GetProcessesByName(pname);
            if (p.Length == 1)
            {
                return p[0].Id;
            }
            return -1;
        }
        static public String GetProcessName(String pname)
        {
            Process[] p = Process.GetProcessesByName(pname);
            if (p.Length == 1)
            {
                return p[0].ProcessName;
            }
            return "";
        }



        private void Run()
        {
            var rand = new Random();
            int[] ls = new int[2];
            if (radiobtn_op1.Checked == true)
            {
                // Virtual keys for numpad a and d
                ls[0] = 65;
                ls[1] = 68;
            }
            else if (radiobtn_op2.Checked == true)
            {
                // Virtual keys for numpad 4 and 6
                ls[0] = 100;
                ls[1] = 102;
            }

            while (true)
            {
                this.ahki.KeyPress(ls[0], this.pid);
                Globals.SafeSleep((uint)(20000 + rand.Next(-1000, 1000)));
                this.ahki.KeyPress(ls[1], this.pid);
                Globals.SafeSleep((uint)(20000 + rand.Next(-1000, 1000)));


                if (!Globals.isRunning)
                {
                    logger.Log("Exiting on request of user....");
                    return;
                }
            }

        }


        private void btn_Attach_Click(object sender, EventArgs e)
        {
            if (this.pid >= 0)
            {
                logger.Log("Reattaching Process...");
            }

            int pid = GetProcessID(txtbox_ProcessName.Text);
            string pname = GetProcessName(txtbox_ProcessName.Text);
            if (pid < 0)
            {
                logger.Log($"Error Retrieving PID for process \"{txtbox_ProcessName.Text}\"");
                this.pid = -1;
                this.pname = "";
                lbl_Pid.Text = "-";
                lbl_Process.Text = "-";
            }
            else
            {
                logger.Log("Process found!");
                //logger.Log(String.Format("PID: {0}", pid));
                logger.Log($"PID: {pid}");
                //logger.Log(String.Format("Process name: {0}", pname));
                logger.Log($"Process name: {pname}");

                this.pid = pid;
                this.pname = pname;
                lbl_Pid.Text = this.pid.ToString();
                lbl_Process.Text = this.pname;
            }

        }

        private void btn_Start_Click(object sender, EventArgs e)
        {
            if (this.pid < 0)
            {
                logger.Log("No PID ...");
                return;
            }
            if (this.thread == null)
            {
                this.thread = new System.Threading.Thread(this.Run);
            }
            if (this.thread.IsAlive)
            {
                logger.Log("Macro is already running!!");
                return;
            }

            this.thread = new System.Threading.Thread(this.Run);
            btn_Start.Enabled = false;
            panel_Options.Enabled = false;
            btn_Test.Enabled = false;
            pictureBox2.Visible = true;
            pictureBox1.Visible = false;
            this.Text = "AntiAFK (Running)";
            logger.Log("Running!");
            Globals.isRunning = true;
            this.thread.IsBackground = true;
            this.thread.Start();
        }

        private void btn_Stop_Click(object sender, EventArgs e)
        {
            logger.Log("Stopping!");
            Globals.isRunning = false;
            panel_Options.Enabled = true;
            btn_Test.Enabled = true;
            btn_Start.Enabled = true;
            pictureBox2.Visible = false;
            pictureBox1.Visible = true;
            this.Text = "AntiAFK";

        }

        private void btn_Test_Click(object sender, EventArgs e)
        {
            if (Globals.isRunning == false)
            {
                this.ahki.KeyPress(32, this.pid);
                logger.Log("JUMP TEST! This just pressed space bar");

            }
            else
            {
                logger.Log("Cant test if program is running");
            }

        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            this.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);
            pictureBox2.Visible = false;
            pictureBox1.Visible = true;


        }

        private void picturebox1_Click(object sender, EventArgs e)
        {

        }
    }
}
