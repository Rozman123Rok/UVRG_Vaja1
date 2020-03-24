﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vaja1
{
    public partial class FormMouse : Form
    {
        public FormMouse()
        {
            InitializeComponent();
        }

        private void label1_MouseClick(object sender, MouseEventArgs e)
        {
            label1.Text = "X: " + e.X + " Y: " + e.Y;
        }
        int x1 = 0, y1 = 0, x2 = 0, y2 = 0, x3 = 0, y3 = 0, x4 = 0, y4 = 0; /// koordinate
        int stevec = 0; /// koliko krat smo ze stisnili
        int stevilo_tock = 2; /// koliko tock bomo narisali (3 je tocka in daljica, 4 sta 2 daljici)
        private void FormMouse_MouseClick(object sender, MouseEventArgs e)
        {
            Brush aBrush = (Brush)Brushes.Black;
            Graphics g = this.CreateGraphics();
            ///g.Clear(Color.White); // pocistimo tocke
            if (stevec == 0) { g.Clear(Color.White); }
            /// preverimo kero opcijo smo izbrali
            if (radioButton1.Checked == true)
            {
                stevilo_tock = 2;
            }
            else if (radioButton2.Checked == true)
            {
                stevilo_tock = 3;
            }
            else
            {
                stevilo_tock = 4;
            }

            if (stevilo_tock == 2)
            {
                if (stevec == 0)
                {
                    x1 = e.X;
                    y1 = e.Y;
                    g.FillRectangle(aBrush, x1, y1, 2, 2); // narisemo tocko
                    stevec++;
                }
                else
                {
                    x2 = e.X;
                    y2 = e.Y;
                    g.FillRectangle(aBrush, x2, y2, 2, 2); // narisemo tocko
                    stevec = 0;
                }
            }
            else if (stevilo_tock == 3)
            {
                if (stevec == 0)
                {
                    x1 = e.X;
                    y1 = e.Y;
                    g.FillRectangle(aBrush, x1, y1, 2, 2); // narisemo tocko
                    stevec++;
                }
                else if (stevec == 1)
                {
                    x2 = e.X;
                    y2 = e.Y;
                    g.FillRectangle(aBrush, x2, y2, 2, 2); /// narisemo tocko
                    stevec++;
                }
                else
                {
                    x3 = e.X;
                    y3 = e.Y;
                    g.FillRectangle(aBrush, x3, y3, 2, 2); // narisemo tocko
                    // narisemo crto med njima
                    stevec = 0;
                }
            }
            else {
                ///stevilo tock je 4
                if (stevec == 0)
                {
                    x1 = e.X;
                    y1 = e.Y;
                    g.FillRectangle(aBrush, x1, y1, 2, 2); // narisemo tocko
                    stevec++;
                }
                else if (stevec == 1)
                {
                    x2 = e.X;
                    y2 = e.Y;
                    g.FillRectangle(aBrush, x2, y2, 2, 2); // narisemo tocko
                    // narisemo crto med njima
                    stevec++;
                }
                else if(stevec == 2)
                {
                    x3 = e.X;
                    y3 = e.Y;
                    g.FillRectangle(aBrush, x3, y3, 2, 2); // narisemo tocko
                    stevec++;
                }
                else
                {
                    x4 = e.X;
                    y4 = e.Y;
                    g.FillRectangle(aBrush, x4, y4, 2, 2); // narisemo tocko
                    // narisemo daljico
                    stevec = 0;
                }
            }
            /// Tocka 4: x4: 0 y4: 0
            label2.Text = "Tocka 1: x1: " + x1 + " y1: " + y1;
            label3.Text = "Tocka 2: x2: " + x2 + " y2: " + y2;
            label4.Text = "Tocka 3: x3: " + x3 + " y3: " + y3;
            label5.Text = "Tocka 4: x4: " + x4 + " y4: " + y4;

           
            
        }

    }
}
