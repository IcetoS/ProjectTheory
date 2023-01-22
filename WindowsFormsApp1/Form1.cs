using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Thread th;
        Thread th1;
        Thread th2;
        Thread th3;
        Random rdm;
        private void button1_Click(object sender, EventArgs e)
        {
            th = new Thread(thread);
            th.Start();
        }

        public void thread()
        {
            for (int i = 0; i < 100; i++)
            {
                this.CreateGraphics().DrawRectangle(new Pen(Brushes.Red, 4), new Rectangle(rdm.Next(0, this.Width), rdm.Next(0, this.Height), 20, 40));
                Thread.Sleep(300);
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            th1 = new Thread(thread);
            th1.Start();
            {
                for (int i = 0; i < 100; i++)
                {
                    this.CreateGraphics().DrawRectangle(new Pen(Brushes.BlueViolet, 4), new Rectangle(rdm.Next(0, this.Width), rdm.Next(0, this.Height), 40, 40));
                    Thread.Sleep(200);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            th2 = new Thread(thread);
            th2.Start();
            {
                for (int i = 0; i < 100; i++)
                {
                    Graphics plain;
                    plain = this.CreateGraphics();
                    SolidBrush brush = new SolidBrush(Color.Aquamarine);
                    Point[] points = { new Point(10, 10), new Point(100, 10), new Point(50, 100) };
                    plain.FillPolygon(brush, points);
                    Thread.Sleep(400);

                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            rdm = new Random();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            th3 = new Thread(thread);
            th3.Start();
            {
                for (int i = 0; i < 100; i++)
                {
                    this.CreateGraphics().DrawRectangle(new Pen(Brushes.Yellow, 4), new Rectangle(rdm.Next(0, this.Width), rdm.Next(0, this.Height), 40, 400));
                    Thread.Sleep(600);
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Проблем и факти 1.Отделно работят. 2.Неможах да накарам триъгълника да се показва по случаен принцип 3.Не успях да ги изчертавя с различна големина");

        }
    }
}
