using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThreadingMidtermTP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            RunButton.BackColor = ColorTranslator.FromHtml("#3A5A40");
            RunButton.ForeColor = ColorTranslator.FromHtml("#DFE6DA");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.BackColor = ColorTranslator.FromHtml("#F3F3F3");
        }

        private void RunButton_Click(object sender, EventArgs e)
        {
            ThreadStart threadStart = new ThreadStart(MyThreadClass.Thread1);
            Thread ThreadA = new Thread(threadStart);
            Thread ThreadB = new Thread(threadStart);
            Thread ThreadC = new Thread(threadStart);
            Thread ThreadD = new Thread(threadStart);

            ThreadA.Name = "Thread A";
            ThreadB.Name = "Thread B";
            ThreadC.Name = "Thread C";
            ThreadD.Name = "Thread D";

            ThreadA.Start();
            ThreadB.Start();
            ThreadC.Start();
            ThreadD.Start();

        }
    }

    public class MyThreadClass
    {
        public static void Thread1()
        {
            for (int i = 0; i <= 2; i++)
            {
                Thread thread = Thread.CurrentThread;
                Console.WriteLine("Name of Thread: " + thread.Name + " = " + i);
                Thread.Sleep(500);
            }
        }

        public static void Thread2()
        {
            for (int i = 0; i <= 6; i++)
            {
                Thread thread = Thread.CurrentThread;
                Console.WriteLine("Name of Thread: " + thread.Name + " = " + i);
                Thread.Sleep(1500);
            }
        }

    }
}
