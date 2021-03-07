using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace realest
{
    public partial class Form1 : Form
    {

        int x, y, h, w; // int coords for height width and starting points
        Pen p = new Pen(Color.Red, 3);

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Form1_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public Form1()
        {
            
            InitializeComponent();
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {


            h = e.X - x; // calculates height when mouse is pressed down
            w = e.Y - y; // calculates width on press down
            
            
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            
            x = e.X; //starting point when mouse is clicked


            y = e.Y; // starting point for when mouse is clicked

            Graphics g = this.CreateGraphics(); //
            Rectangle shape = new Rectangle(x, y, h, w); // dynamic rectangle from generated coords


            if (radioButton1.Checked)
            {
                g.DrawEllipse(p, shape);

                string msg = Convert.ToString(x);

                string msg1 = Convert.ToString(y);





                MessageBox.Show( "X = "+ msg+ " "+ "Y = "+ msg1); 

            }

            else if (radioButton2.Checked)
            {


                string msg = Convert.ToString(x);

                string msg1 = Convert.ToString(y);

                g.DrawRectangle(p, shape);


                

                int c = h * w;
                string msg2 = Convert.ToString(c);

                MessageBox.Show("X = " + msg + " " + "Y = " + msg1 + msg2 );
            }


            else if (radioButton3.Checked)
             {
                
                Point[] a = { new Point(100, 100), new Point(200, 100), new Point(400, 200) }; // 
                g.DrawPolygon(p, a);

            }
        }
    }
}
