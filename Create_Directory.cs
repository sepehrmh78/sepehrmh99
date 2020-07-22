using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApplication3
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }



        private void button1_Click(object sender, EventArgs e)
        {
           string s = name_txt.Text;
           string a =@address_txt.Text;
           int n = int.Parse(n_txt.Text);
            int i =1;
            string z;

            while(i!=n+1)
                {
                    if (i<= 9)
                    {
                        z = System.IO.Path.Combine(a, s + "0" + i.ToString());

                        if (!Directory.Exists(z))

                            Directory.CreateDirectory(z);
                        else
                            MessageBox.Show(z + " is existed");
                    }

                    else
                    {
                        z = System.IO.Path.Combine(a, s + i.ToString());

                        if (!Directory.Exists(z))

                            Directory.CreateDirectory(z);
                        else
                            MessageBox.Show(z + " is existed");
                    }
                    i++;
                    
                }
        }

        private void browse_btn_Click(object sender, EventArgs e)
        {
            DialogResult result = folderBrowserDialog1.ShowDialog();
            if (result == DialogResult.OK) 
            {
                address_txt.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            if (FormWindowState.Minimized == this.WindowState)
            {
                notifyIcon1.Visible = true;
                
                this.Hide();
            }

            else if (FormWindowState.Normal == this.WindowState)
            {
                notifyIcon1.Visible = false;
            }
        }

        private void notifyIcon1_MouseClick(object sender, MouseEventArgs e)
        {
            this.Show();
            this.WindowState = FormWindowState.Normal;
        }

    }
}
