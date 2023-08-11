using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsInput;
using WindowsInput.Native;
using System.Threading;


namespace FATALITY_MACROS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            InputSimulator inputSimulator = new InputSimulator();
            int a = 100000;
            while (a != 0)
            {
                Random rnd = new Random();
                int c = rnd.Next(-50, 50);  // creates a number between 1 and 12
                int d = rnd.Next(-50, 50);
                inputSimulator.Mouse.MoveMouseBy(c, d);
                System.Threading.Thread.Sleep(100);
                a -= 1;
            }
        }
    }
}
