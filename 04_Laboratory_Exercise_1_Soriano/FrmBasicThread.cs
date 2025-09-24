using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace _04_Laboratory_Exercise_1_Soriano
{
    public partial class FrmBasicThread : Form
    {
        public FrmBasicThread()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Step 4
            ThreadStart delThread = new ThreadStart(MyThreadClass.Thread1);
            Thread ThreadA = new Thread(delThread);
            Thread ThreadB = new Thread(delThread);

            //Changed the thread names to match the output
            ThreadA.Name = "Thread A Process";
            ThreadB.Name = "Thread B Process";

            Console.WriteLine("- Before starting thread -");
            ThreadA.Start();
            ThreadB.Start();

            //Step 5
            ThreadA.Join();
            ThreadB.Join();
            Console.WriteLine("- End of Thread -");
            label1.Text = "- End of Thread -"; //Change the text of the label
        }
    }
}
