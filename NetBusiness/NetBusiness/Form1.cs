using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NetBusiness
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
            label1.Text = "Москва, Россия, понедельник, 11 июля 2022";
            timer1.Tick += timer1_Tick;
            timer1.Interval = 1000;
            timer1.Enabled = true;
            timer1.Start();
        }

        Timer timer1 = new Timer();
        DateTime startTime = new DateTime(2022, 7, 11, 12, 0, 0);

        private void Form1_Load(object sender, EventArgs e)
        {
            //label1.Text = DateTime.Now.ToString();
        }
        void timer1_Tick(object sender, EventArgs e)
        {
            TimeSpan TimeRemaining = startTime - DateTime.Now;
            label2.Text = 
                TimeRemaining.Days + " дней " + 
                TimeRemaining.Hours + " часов и " + 
                TimeRemaining.Minutes + " минут  до старта марафона!";
        }

        private void sponsor_btn_Click(object sender, EventArgs e)
        {

        }
    }
}
