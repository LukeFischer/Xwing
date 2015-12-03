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
            Xwing (0, 0, 90, 24);
        }
        public void Xwing(float x, float y, float width, float height)
        {
            Pen exPen = new Pen(Color.White);
            float scale = width / 100;
            float scaley = height / 100;

            //Wing 1
            g.DrawLine(exPen, 232 * scale + x, 115 * scaley + y, 180 * scale + x, 50 * scaley + y);
            g.DrawLine(exPen, 140 * scale + x, 50 * scaley + y, 180 * scale + x, 50 * scaley + y);

            //Body of Xwing
            g.DrawLine(exPen, 100 * scale + x, 115 * scaley + y, 230 * scale + x, 115  * scaley + y);

            //Wing 2
            g.DrawLine(exPen, 232 * scale + x , 115 * scaley + y, 180 * scale + x, 180 * scaley + y);
            g.DrawLine(exPen, 140 * scale + x, 180 * scaley + y, 180 * scale + x, 180 * scaley + y);

            //Cockpit
            g.DrawArc(exPen, 150 * scale + x, 87 * scaley + y, 40 * scale, 35 * scaley, 150, 240);
        }
    }
}
