using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Management;

namespace WindowsFormsApplication2
{

    public partial class Form1 : Form
    {

        string a, c,b,d;

        bool flag;
        public Form1()
        {

            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
           // button1.Text = radioButton1.Text;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

           
        }

        private void button1_Click(object sender, EventArgs e)
        {


                 if(radioButton1.Checked==true)
                     System.Diagnostics.Process.Start("shutdown", "/s /t 0");
            
                 if(radioButton2.Checked==true)
                     System.Diagnostics.Process.Start("restart", "/r /t 0");

                 if (radioButton3.Checked == true)
                     Application.SetSuspendState(PowerState.Hibernate, true, true);

                if (radioButton4.Checked == true)
                    Application.SetSuspendState(PowerState.Suspend, true, true);

           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Text = DateTime.Now.ToString("HH:mm");
            
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {


        }

        private void timer1_Tick(object sender, EventArgs e)
        {


            b = (DateTime.Now.ToString("HH"));
            d = (DateTime.Now.ToString("mm"));


            if (a == b && c == d && radioButton1.Checked == true)
            {
                timer1.Enabled = false;
                System.Diagnostics.Process.Start("shutdown", "/s /t 0");
            }


            else if (a == b && c == d && radioButton2.Checked == true)
            {
                timer1.Enabled = false;
                System.Diagnostics.Process.Start("restart", "/r /t 0");
            }


            else if (a == b && c == d && radioButton3.Checked == true)
            {
                timer1.Enabled = false;
                Application.SetSuspendState(PowerState.Hibernate, true, true);
            }


            else if (a == b && c == d && radioButton4.Checked == true)
            {
                timer1.Enabled = false;
                Application.SetSuspendState(PowerState.Suspend, true, true);
            }


            

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            textBox1.Text = DateTime.Now.ToString("HH:mm");
        }

        private void button2_Click(object sender, EventArgs e)
        {       
            a = numericUpDown1.Value.ToString();
            switch (a)
            {
                case "0": a = "00"; break;
                case "1": a = "01"; break;
                case "2": a = "02"; break;
                case "3": a = "03"; break;
                case "4": a = "04"; break;
                case "5": a = "05"; break;
                case "6": a = "06"; break;
                case "7": a = "07"; break;
                case "8": a = "08"; break;
                case "9": a = "09"; break;
            }

            c = numericUpDown2.Value.ToString();

            switch (c)
            {
                case "0": c = "00"; break;
                case "1": c = "01"; break;
                case "2": c = "02"; break;
                case "3": c = "03"; break;
                case "4": c = "04"; break;
                case "5": c = "05"; break;
                case "6": c = "06"; break;
                case "7": c = "07"; break;
                case "8": c = "08"; break;
                case "9": c = "09"; break;
            }
            timer1.Enabled = true;
        }

        private void notifyIcon1_MouseClick(object sender, MouseEventArgs e)
        {
            this.Show();
            this.WindowState = FormWindowState.Normal;
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.Hide();
                notifyIcon1.Visible = true;
            }

            else if (this.WindowState == FormWindowState.Normal)
                notifyIcon1.Visible = false;

        }

    }
}
