using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Perceptron
{
    public partial class Form1 : Form
    {
        double delta;
        double d;
        double y;
        double d1;
        double d2;
        double w1;
        double w2;
        double theta;
        double eta;
        double x1;
        double x2;
        int i = 0;

        public Form1()
        {
            InitializeComponent();
        
            dgv_AND.Rows.Add(1, 1, 1);
            dgv_AND.Rows.Add(1, 0, 0);
            dgv_AND.Rows.Add(0, 1, 0);
            dgv_AND.Rows.Add(0, 0, 0);

            dgv_Test.Rows.Add(1, 1, 1, 1);
            dgv_Test.Rows.Add(1, 0, 0, 0);
            dgv_Test.Rows.Add(0, 1, 0, 0);
            dgv_Test.Rows.Add(0, 0, 0, 0);

            theta = Convert.ToDouble(txt_t.Text);
            eta = Convert.ToDouble(txt_n.Text);
            
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            g.DrawLine(Pens.Black, 123, 97,302,162);
            g.DrawLine(Pens.Black, 123, 240, 302, 182);
            g.DrawEllipse(Pens.Black, 300, 125, 94, 94);
            g.DrawLine(Pens.Black, 395,172,460,172);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (i == 4)
            {
                i = 0;
            }
            grafica.Series["Series2"].Points.Clear();
            txt_x1.Text = dgv_AND.Rows[i].Cells[0].Value.ToString();
            txt_x2.Text = dgv_AND.Rows[i].Cells[1].Value.ToString();
            x1 = Convert.ToDouble(txt_x1.Text);
            x2 = Convert.ToDouble(txt_x2.Text);
            w1 = Convert.ToDouble(txt_w1.Text);
            w2 = Convert.ToDouble(txt_w2.Text);
            d = Convert.ToDouble(dgv_AND.Rows[i].Cells[2].Value.ToString());
            y = funcion(x1, x2, w1, w2, theta);
            txt_D.Text = d.ToString();
            txt_Y.Text = y.ToString();

            double py1 = -(w1 / w2) * 0 + (theta / w2);
            double py2 = -(w1 / w2) * 1 + (theta / w2);
            double py3 = -(w1 / w2) * 2 + (theta / w2);
            grafica.Series["Series2"].Points.AddXY(0, py1);
            grafica.Series["Series2"].Points.AddXY(1, py2);
            grafica.Series["Series2"].Points.AddXY(2, py3);

            dgv_Test.Rows[i].Cells[2].Value = y;
            if (y != Convert.ToInt32(dgv_Test.Rows[i].Cells[3].Value.ToString()))
            {
                dgv_Test.Rows[i].Cells[2].Style.BackColor = Color.Red;
            }
            else
            {
                dgv_Test.Rows[i].Cells[2].Style.BackColor = Color.White;
            }

            //Cálculo del error
            delta = d - y;
            d1 = eta * delta * x1;
            d2 = eta * delta * x2;

            w1 += d1;
            w2 += d2;

            theta = theta - eta * delta;

            lbl1.Text = delta.ToString();
            lbl2.Text = d1.ToString();
            lbl3.Text = d2.ToString();
            lbl4.Text = w1.ToString();
            lbl5.Text = w2.ToString();
            lbl6.Text = theta.ToString();

            txt_w1.Text = w1.ToString();
            txt_w2.Text = w2.ToString();
            txt_t.Text = theta.ToString();

            i++;
            

        }

        private int funcion(double x1, double x2, double w1, double w2, double t)
        {
            double operacion = (x1 * w1 + x2 * w2) - t;
            if (operacion >= 0)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }

        private void btn_iniciar_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
