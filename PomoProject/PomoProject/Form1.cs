using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PomoProject
{
    public partial class Form1 : Form
    {
        private int WorkTime = 0;
        private int BreakTime = 0;
        private int Counter = 0;
        private bool WorkFlag = false;
        public Form1()
        {
            InitializeComponent();
            timer1.Enabled = true;
            timer1.Interval = 1000;
            WorkTime = ConvertInt32(WorkTimeTextBox.Text);
            BreakTime = ConvertInt32(BreakTimeTextBox.Text);
            WorkFlag = true;
            Counter = WorkTime;
            CurrTime.Text = Counter.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void RealTimeText_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            RealTimeText.Text = DateTime.Now.ToString("T", CultureInfo.CreateSpecificCulture("en-US"));
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            //timer2 = new System.Windows.Forms.Timer();
            //timer2.Tick += new(KeyEventHandler(timer2_Tick));

            timer2.Enabled = true;
            timer2.Interval = 1000;
            timer2.Start();

            CurrTime.Text = Counter.ToString();
            //timer2.Interval = 60000;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            Counter--;
            if(Counter == 0)
            {
                timer2.Stop();
                if (WorkFlag)
                {
                    Counter = BreakTime;
                    WorkFlag = false;
                } else
                {
                    Counter = WorkTime;
                    WorkFlag = true;
                }
            }
            CurrTime.Text = Counter.ToString();
        }

        private void WorkTimeTextBox_TextChanged(object sender, EventArgs e)
        {
            if (WorkFlag)
            {
                WorkTime = ConvertInt32(WorkTimeTextBox.Text);
                Counter = WorkTime;
                CurrTime.Text = Counter.ToString();
            }
            else
            {
                WorkTime = ConvertInt32(WorkTimeTextBox.Text);
            }
        }

        private void BreakTimeTextBox_TextChanged(object sender, EventArgs e)
        {
            if (!WorkFlag)
            {
                BreakTime = ConvertInt32(BreakTimeTextBox.Text);
                Counter = BreakTime;
                CurrTime.Text = Counter.ToString();
            } else
            {
                BreakTime = ConvertInt32(BreakTimeTextBox.Text);
            }
        }

        private Int32 ConvertInt32 (String value)
        {
            try { return Convert.ToInt32(value); }
            catch { return 0; }
        }
    }
}
