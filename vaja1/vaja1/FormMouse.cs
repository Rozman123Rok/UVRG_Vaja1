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

        /**
         ROK ROZMAN
        */

        float x1 = 0, y1 = 0, x2 = 0, y2 = 0, x3 = 0, y3 = 0, x4 = 0, y4 = 0; // koordinate tock
        bool kx1 = false, ky1 = false, kx2 = false, ky2 = false, kx3 = false, ky3 = false, kx4 = false, ky4 = false; /// ce smo vpisali te koordinate
        int stevec = 0; /// koliko krat smo ze stisnili
        int stevilo_tock = 2; /// koliko tock bomo narisali (3 je tocka in daljica, 4 sta 2 daljici)
        float D, B, A; /// za nalogo 3


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
                    tocka_daljica();

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
                    se_sekata(x1, x2, x3, x4, y1, y2, y3, y4);
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
                    //tocka_daljica(x1, x2, x3, y1, y2, y3);
                    tocka_daljica();
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
                    se_sekata(x1, x2, x3, x4, y1, y2, y3, y4);
                }
            }
    
        }

        private void tocka_daljica()
        {
            Brush asa = (Brush)Brushes.Red; // za risanje tock
            Pen pen1 = new Pen(ForeColor); // za risanje daljic med tockama
            Graphics g = this.CreateGraphics();
            float V1x = x3 - x2; // vektor V1 x koordinata
            float V1y = y3 - y2; // vektor V1 y koordinata
            float V2x = x1 - x2; // vektor V2 x koordinata
            float V2y = y1 - y2; // vektor V2 y koordinata
            float s = (float)Math.Sqrt(Math.Pow(V1x + V1y, 2)); // modul
            //float V1n = V1x + V1y / (float)Math.Sqrt(Math.Pow(V1x + V1y, 2));
            if (s == 0)
            {
                MessageBox.Show("Nicelni vektor");
                return;
            }
            else {
                float Vn_x = V1x / s; // normiran vektor x koordinata
                float Vn_y = V1y / s; // normiran vektor y koordinata
                float sp = Vn_x * V2x + Vn_y * V2y; // skalarni produkt
                float dolzina_V1 = (float)Math.Sqrt(V1x * V1x + V1y * V1y); // dolzina vektorja V1
                float Tp_x = x2 + Vn_x * sp; // tocka TP x koordinata
                float Tp_y = y2 + Vn_y * sp; // tocka TP y koordinata

                if (0 <= sp && sp <=dolzina_V1) {
                    MessageBox.Show("Lezi na daljici");
                    MessageBox.Show("x: " + Tp_x + " y: " + Tp_y); // izpisemo koordinate
                    g.FillRectangle(asa, Tp_x, Tp_y, 2, 2); // narisemo tocko
                    g.DrawLine(pen1, Tp_x, Tp_y, x1, y1); // narisemo daljico
                    double razdalja;
                    razdalja = Math.Sqrt(Math.Pow(x1 - Tp_x, 2) + Math.Pow(y1 - Tp_y, 2));
                    MessageBox.Show("Razdalja: " + razdalja);

                }
                else {
                    MessageBox.Show("Lezi izven daljice");
                    MessageBox.Show("x: " + Tp_x + " y: " + Tp_y); // izpisemo koordinate
                    double razdalja_T2, razdalja_T3; // izracunamo razdaljo do vsake tocke
                    razdalja_T2 = Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2));
                    razdalja_T3 = Math.Sqrt(Math.Pow(x1 - x3, 2) + Math.Pow(y1 - y3, 2));
                    if (razdalja_T2 < razdalja_T3) // primerjamo katera je krajsa
                    {
                        g.DrawLine(pen1, x2, y2, x1, y1); // narisemo daljico
                        MessageBox.Show("Razdalja med T1 in T2: " + razdalja_T2); // izpisemo razdaljo
                    }
                    else {
                        g.DrawLine(pen1, x3, y3, x1, y1); // narisemo daljico
                        MessageBox.Show("Razdalja med T1 in T3: " + razdalja_T3); // izpisemo razdaljo
                    }
                }

            }

        }
        private void se_sekata(float x1, float x2, float x3, float x4, float y1, float y2, float y3, float y4) {

            Brush aBrush = (Brush)Brushes.Red; // za risanje tock
            Pen pen = new Pen(ForeColor); // za risanje daljic med tockama
            Graphics g = this.CreateGraphics();

            D = (x2 - x1) * (y4 - y3) - (x4 - x3) * (y2 - y1);
            A = (x4 - x3) * (y1 - y3) - (x1 - x3) * (y4 - y3);
            B = (x2 - x1) * (y1 - y3) - (x1 - x3) * (y2 - y1);

            //D = A = B = 0
            if (D == A && A == B && B == 0) {
                MessageBox.Show("Vsi trije so enaki! Daljici sovpadata");
                return;
            }

            if (D == 0) {
                MessageBox.Show("Daljici sta vzporedni!");
                return;
            }

            float Ua = A / D;
            float Ub = B / D;
            //0 ≤ Ua ≤ 1
            //0 ≤ Ub ≤ 1
            if (0 <= Ua && Ua <= 1 && 0 <= Ub && Ub <= 1)
            {
                MessageBox.Show("Se sekata!");
                // Izracun presecisca!
                // x = x1 + Ua(x2 - x1) ali x = x3 + Ub(x4 - x3)
                // y = y1 + Ua(y2 - y1) ali y = y3 + Ub(y4 - y3)
                float x_p = x1 + Ua * (x2 - x1);
                float y_p = y1 + Ua * (y2 - y1);
                MessageBox.Show("Koordinate precesisca: x: " + x_p + " y: " + y_p);
                g.FillRectangle(aBrush, x_p-1, y_p-1, 4, 4); // narisemo tocko

            }
            else { 
                MessageBox.Show("Se ne sekata!"); 
            }

        }

    }
}
