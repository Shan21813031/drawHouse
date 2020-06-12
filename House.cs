using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace drawHouse
{
    public partial class House : Form
    {
        /// <summary>
        /// Independent Study Task 6.9
        /// Author: Shan Ahmed 21813031
        /// This application draws a simple house.
        /// </summary>
        /// 

        public House()
        {
            InitializeComponent();
        }

        private void House_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Below creates the necessary shapes and paints them in 
        /// to draw the house
        /// </summary>

        private void House_Paint(object sender, PaintEventArgs e)
        {
            Pen myPen = new Pen(Color.Black, 5);
            Graphics g = e.Graphics;
            int x = 100, y = 100, size = 200;
            g.DrawRectangle(myPen, x, y, size, size);
            g.FillRectangle(Brushes.Brown, x, y, size, size);

            Point[] roof = new Point[]                               
            {
                new Point(100,100),
                new Point(200,0),
                new Point(300,100),
            
            };
            g.DrawPolygon(myPen, roof);                              //Draws Roof
            g.FillPolygon(Brushes.Black,roof);

            g.DrawRectangle(myPen, 180, 230, 40, 70);                //Draws Door
            g.FillRectangle(Brushes.SandyBrown, 180, 230, 40, 70);

            g.DrawRectangle(myPen, 130, 130, 50, 50);                //Draws window
            g.FillRectangle(Brushes.White, 130, 130, 50, 50);

            g.DrawRectangle(myPen, 220, 130, 50, 50);                //Draws window
            g.FillRectangle(Brushes.White, 220, 130, 50, 50);



        }
    }
}
