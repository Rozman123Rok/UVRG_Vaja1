using System;
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
        
        float x1 = 0, y1 = 0, x2 = 0, y2 = 0, x3 = 0, y3 = 0, x4 = 0, y4 = 0; // koordinate tock
        bool kx1 = false, ky1 = false, kx2 = false, ky2 = false, kx3 = false, ky3 = false, kx4 = false, ky4 = false; /// ce smo vpisali te koordinate
        int stevec = 0; /// koliko krat smo ze stisnili
        int stevilo_tock = 2; /// koliko tock bomo narisali (3 je tocka in daljica, 4 sta 2 daljici)

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            int i = int.Parse(textBox1.Text);
            //MessageBox.Show("Test: " + i);
            x1 = i;
            kx1 = true;
        }


        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            int i = int.Parse(textBox2.Text);
            //MessageBox.Show("Test: " + i);
            y1 = i;
            ky1 = true;
        }


        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            int i = int.Parse(textBox3.Text);
            //MessageBox.Show("Test: " + i);
            x2 = i;
            kx2 = true;
        }


        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            int i = int.Parse(textBox4.Text);
            //MessageBox.Show("Test: " + i);
            y2 = i;
            ky2 = true;
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            int i = int.Parse(textBox5.Text);
            //MessageBox.Show("Test: " + i);
            x3 = i;
            kx3 = true;
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            int i = int.Parse(textBox6.Text);
            //MessageBox.Show("Test: " + i);
            y3 = i;
            ky3 = true;
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            int i = int.Parse(textBox7.Text);
            //MessageBox.Show("Test: " + i);
            x4 = i;
            kx4 = true;
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            int i = int.Parse(textBox8.Text);
            //MessageBox.Show("Test: " + i);
            y4 = i;
            ky4 = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Brush aBrush = (Brush)Brushes.Black; // za risanje tock
            Pen pen = new Pen(ForeColor); // za risanje daljic med tockama
            Graphics g = this.CreateGraphics();

            /// ko smo vpisali vse potrebne koordinate da narisemo tocke
            if (stevec == 0)
            {
                g.Clear(Color.White); // pocistim vse tocke in daljice ko je zacetek novih koordinat
            }
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
                // bomo narisali 2 tocki
                if (kx1 && ky1 && kx2 && ky2)
                {
                    /// imamo vse koordinate za obe tocki
                    /// narisemo prvo tocko
                    g.FillRectangle(aBrush, x1, y1, 2, 2); // narisemo tocko
                    label2.Text = "Tocka 1: x1: " + x1 + " y1: " + y1;
                    stevec++;
                    /// narisemo drugo tocko
                    label3.Text = "Tocka 2: x2: " + x2 + " y2: " + y2;
                    g.FillRectangle(aBrush, x2, y2, 2, 2); // narisemo tocko
                    stevec = 0;
                    /// izracunamo razdaljo
                    double razdalja;
                    razdalja = Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2));
                    g.DrawLine(pen, x1, y1, x2, y2);// narisemo crto med njima
                    MessageBox.Show("Razdalja je: " + razdalja);
                }
                else
                {
                    // nimamo vseh koordinat
                    MessageBox.Show("Vnesi vse koordinate za tocke");
                }
            }
            else if (stevilo_tock == 3) {
                // narisemo 3 tocke
                if (kx1 && ky1 && kx2 && ky2 && kx3 && ky3)
                {
                    // prva tocka
                    label2.Text = "Tocka 1: x1: " + x1 + " y1: " + y1;
                    g.FillRectangle(aBrush, x1, y1, 2, 2); // narisemo tocko
                    stevec++;
                    /// druga tocka
                    label3.Text = "Tocka 2: x2: " + x2 + " y2: " + y2;
                    g.FillRectangle(aBrush, x2, y2, 2, 2); /// narisemo tocko
                    stevec++;
                    // tretja tocka
                    label4.Text = "Tocka 3: x3: " + x3 + " y3: " + y3;
                    g.FillRectangle(aBrush, x3, y3, 2, 2); // narisemo tocko
                    g.DrawLine(pen, x2, y2, x3, y3);// narisemo crto med njima
                    stevec = 0;

                }
                else
                {
                    // nimamo vseh koordinat
                    MessageBox.Show("Vnesi vse koordinate za tocke");
                }
            }
            else{
                /// stevilo tock je 4
                if (kx1 && ky1 && kx2 && ky2 && kx3 && ky3 && kx4 && ky4) {
                    /// prva tocka
                    label2.Text = "Tocka 1: x1: " + x1 + " y1: " + y1;
                    g.FillRectangle(aBrush, x1, y1, 2, 2); // narisemo tocko
                    // druga tocka
                    label3.Text = "Tocka 2: x2: " + x2 + " y2: " + y2;
                    g.FillRectangle(aBrush, x2, y2, 2, 2); // narisemo tocko
                    g.DrawLine(pen, x1, y1, x2, y2); // narisemo crto med njima
                    // tretja tocka
                    label4.Text = "Tocka 3: x3: " + x3 + " y3: " + y3;
                    g.FillRectangle(aBrush, x3, y3, 2, 2); // narisemo tocko
                    // cetrta tocka
                    label5.Text = "Tocka 4: x4: " + x4 + " y4: " + y4;
                    g.FillRectangle(aBrush, x4, y4, 2, 2); // narisemo tocko
                    g.DrawLine(pen, x3, y3, x4, y4); // narisemo daljico
                }
                else
                {
                    // nimamo vseh koordinat
                    MessageBox.Show("Vnesi vse koordinate za tocke");
                }
            }

        }

        /// koordinate

        private void FormMouse_MouseClick(object sender, MouseEventArgs e)
        {
            Brush aBrush = (Brush)Brushes.Black; // za risanje tock
            Pen pen = new Pen(ForeColor); // za risanje daljic med tockama
            Graphics g = this.CreateGraphics();

            if (stevec == 0)
            { 
                g.Clear(Color.White); // pocistim vse tocke in daljice ko je zacetek novih koordinat
            }
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
                    label2.Text = "Tocka 1: x1: " + x1 + " y1: " + y1;
                    stevec++;
                }
                else
                {
                    x2 = e.X;
                    y2 = e.Y;
                    label3.Text = "Tocka 2: x2: " + x2 + " y2: " + y2;
                    g.FillRectangle(aBrush, x2, y2, 2, 2); // narisemo tocko
                    stevec = 0;

                    /// izracunamo razdaljo
                    double razdalja;
                    razdalja = Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2));
                    g.DrawLine(pen, x1, y1, x2, y2);// narisemo crto med njima
                    MessageBox.Show("Razdalja je: " + razdalja);

                }
            }
            else if (stevilo_tock == 3)
            {
                if (stevec == 0)
                {
                    x1 = e.X;
                    y1 = e.Y;
                    label2.Text = "Tocka 1: x1: " + x1 + " y1: " + y1;
                    g.FillRectangle(aBrush, x1, y1, 2, 2); // narisemo tocko
                    stevec++;
                }
                else if (stevec == 1)
                {
                    x2 = e.X;
                    y2 = e.Y;
                    label3.Text = "Tocka 2: x2: " + x2 + " y2: " + y2;
                    g.FillRectangle(aBrush, x2, y2, 2, 2); /// narisemo tocko
                    stevec++;
                }
                else
                {
                    x3 = e.X;
                    y3 = e.Y;
                    label4.Text = "Tocka 3: x3: " + x3 + " y3: " + y3;
                    g.FillRectangle(aBrush, x3, y3, 2, 2); // narisemo tocko
                    g.DrawLine(pen, x2, y2, x3, y3);// narisemo crto med njima
                    stevec = 0;
                }
            }
            else {
                ///stevilo tock je 4
                if (stevec == 0)
                {
                    x1 = e.X;
                    y1 = e.Y;
                    label2.Text = "Tocka 1: x1: " + x1 + " y1: " + y1;
                    g.FillRectangle(aBrush, x1, y1, 2, 2); // narisemo tocko
                    stevec++;
                }
                else if (stevec == 1)
                {
                    x2 = e.X;
                    y2 = e.Y;
                    label3.Text = "Tocka 2: x2: " + x2 + " y2: " + y2;
                    g.FillRectangle(aBrush, x2, y2, 2, 2); // narisemo tocko
                    g.DrawLine(pen, x1, y1, x2, y2); // narisemo crto med njima
                    stevec++;
                }
                else if(stevec == 2)
                {
                    x3 = e.X;
                    y3 = e.Y;
                    label4.Text = "Tocka 3: x3: " + x3 + " y3: " + y3;
                    g.FillRectangle(aBrush, x3, y3, 2, 2); // narisemo tocko
                    stevec++;
                }
                else
                {
                    x4 = e.X;
                    y4 = e.Y;
                    label5.Text = "Tocka 4: x4: " + x4 + " y4: " + y4;
                    g.FillRectangle(aBrush, x4, y4, 2, 2); // narisemo tocko
                    g.DrawLine(pen, x3, y3, x4, y4); // narisemo daljico
                    stevec = 0;
                }
            }
            /// Tocka 4: x4: 0 y4: 0
            //label2.Text = "Tocka 1: x1: " + x1 + " y1: " + y1;
            //label3.Text = "Tocka 2: x2: " + x2 + " y2: " + y2;
            //label4.Text = "Tocka 3: x3: " + x3 + " y3: " + y3;
            //label5.Text = "Tocka 4: x4: " + x4 + " y4: " + y4;

           
            
        }

    }
}
