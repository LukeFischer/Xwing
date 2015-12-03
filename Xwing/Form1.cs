using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Xwing
{
    public partial class Form1 : Form
    {
        Graphics g;

        public Form1()
        {
            InitializeComponent();
            g = this.CreateGraphics();
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            Xwing (0, 0, 100);
        }
        public void Xwing(float x, float y, float pixels)
        {
            Pen exPen = new Pen(Color.White);
            g.DrawLine(exPen, 232, 115, 180, 50);
            g.DrawLine(exPen, 100, 115, 230, 115);

        }
    }
}
