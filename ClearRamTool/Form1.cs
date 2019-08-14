using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ClearRamTool
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public int hours, minutes, seconds;
        public TimeSpan timeSpan, timeSpanStrart;
        TimeSpan timeSpan2 = new TimeSpan(0, 0, 1);
        int count = 0;
        bool isRunning = false;
        public void ExecuteCommandSync(string command)
        {
            try
            {
                System.Diagnostics.ProcessStartInfo procStartInfo = new System.Diagnostics.ProcessStartInfo("RUN.exe", command);

                // The following commands are needed to redirect the standard output.
                // This means that it will be redirected to the Process.StandardOutput StreamReader.
                procStartInfo.RedirectStandardOutput = true;
                procStartInfo.Verb = "runas";
                procStartInfo.UseShellExecute = false;
                // Do not create the black window.
                procStartInfo.CreateNoWindow = true;
                // Now we create a process, assign its ProcessStartInfo and start it
                System.Diagnostics.Process proc = new System.Diagnostics.Process();
                proc.StartInfo = procStartInfo;
                proc.Start();
                // Get the output into a string
                string result = proc.StandardOutput.ReadToEnd();
                // Display the command output.
                MessageBox.Show("It done, please check your RAM usuage", "Notification");
            }
            catch (Exception objException)
            {
                // Log the exception
                MessageBox.Show(objException.ToString());
            }
        }

        public void ExecuteCommandSyncSilent(string command)
        {
            try
            {
                System.Diagnostics.ProcessStartInfo procStartInfo = new System.Diagnostics.ProcessStartInfo("RUN.exe", command);

                // The following commands are needed to redirect the standard output.
                // This means that it will be redirected to the Process.StandardOutput StreamReader.
                procStartInfo.RedirectStandardOutput = true;
                procStartInfo.Verb = "runas";
                procStartInfo.UseShellExecute = false;
                // Do not create the black window.
                procStartInfo.CreateNoWindow = true;
                // Now we create a process, assign its ProcessStartInfo and start it
                System.Diagnostics.Process proc = new System.Diagnostics.Process();
                proc.StartInfo = procStartInfo;
                proc.Start();
                // Get the output into a string
                string result = proc.StandardOutput.ReadToEnd();
                // Display the command output.
               
            }
            catch (Exception objException)
            {
                // Log the exception
                MessageBox.Show(objException.ToString());
            }
        }

        private void btn_lv1_Click(object sender, EventArgs e)
        {
            ExecuteCommandSync("workingsets pause");
        }

        private void btn_Level2_Click(object sender, EventArgs e)
        {
            ExecuteCommandSync("modifiedpagelist");
        }

        private void btn_lv3_Click(object sender, EventArgs e)
        {
            ExecuteCommandSync("standbylist");
        }

        private void btn_lv4_Click(object sender, EventArgs e)
        {
            ExecuteCommandSync("priority0standbylist");
        }
        void ShowRam()
        {
            Process proc = Process.GetCurrentProcess();
            this.label1.Text = (proc.WorkingSet64).ToString();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            //timer1.Start();
            System.Diagnostics.Process.Start("taskmgr");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            ShowRam();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://fb.com/hoalaxanh123");
        }

        private void button_settimer_Click(object sender, EventArgs e)
        {
            if (button_settimer.Text == "Running...")
            {
                isRunning = false;
                timer2.Stop();
                Set(false);
                button_settimer.Text = "Start";
                return;
            }
            count = 0;
            hours = (int)numericUpDown_Hour.Value;
            minutes = (int)numericUpDown_Minute.Value;
            seconds = (int)numericUpDown_Second.Value;

            timeSpan = new TimeSpan(hours, minutes, seconds);
            timeSpanStrart = timeSpan;

            timer2.Start();
            isRunning = true;

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            timeSpan = timeSpan - timeSpan2;

            this.label_Remain.Text = String.Format("Remain: {0} hours {1} minutes {2} seconds", timeSpan.Hours, timeSpan.Minutes, timeSpan.Seconds);
            label_TimeOfClean.Text = "Cleaned: " + count + " time(s).";

            if (timeSpan.TotalSeconds == 0)
            {
                timeSpan = timeSpanStrart;
                count++;
                ExecuteCommandSyncSilent("workingsets");
            }
            CheckAndDisableFunction();
        }
        void Set(bool yes)
        {
            this.numericUpDown_Hour.ReadOnly = yes;
            this.numericUpDown_Minute.ReadOnly = yes;
            this.numericUpDown_Second.ReadOnly = yes;
        }
        void CheckAndDisableFunction()
        {
            Set(isRunning);
            if (isRunning)
            {
                this.button_settimer.Text = "Running...";
            }
            else
            {
                this.button_settimer.Text = "Strart";
            }
        }
    }
}
