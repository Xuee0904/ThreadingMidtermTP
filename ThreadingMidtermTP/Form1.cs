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
    }

    public class MyThreadClass
    {
        public static void Thread1()
        {

        }

        public static void Thread2()
        {

        }

    }
}
