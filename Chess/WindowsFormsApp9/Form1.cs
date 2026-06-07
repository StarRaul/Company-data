using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp9
{
    public partial class Form1 : Form
    {
        Image tabla;
        Graphics g_tabla;
        int w_tabla;
        int h_tabla;
        int w_camp;
        int h_camp;
        Pion p1;
        int mx, my;
        bool piesa_select = false;
        public Form1()
        {
            InitializeComponent();
            w_tabla = pb.Width - 100;
            h_tabla = pb.Height - 100;
            w_camp = w_tabla / 8;
            h_camp = h_tabla / 8;
            tabla = new Bitmap(pb.Width, pb.Height);
            g_tabla = Graphics.FromImage(tabla);
            p1 = new Pion(Image.FromFile("pion.gif"), 0, 0);
            //MessageBox.Show(w_tabla + " " + h_tabla + " " + w_camp + " " + h_camp);
            
        }
        private void desenare_tabla()
        {
            g_tabla.Clear(Color.Gray);
            Brush br1 = new SolidBrush(Color.AliceBlue);
            Brush br2 = new SolidBrush(Color.Tomato);
            for(int i = 1; i <= 8; i++)
            {
                for (int j = 1; j <= 8; j++)
                {
                    if ((i + j) % 2 == 0)
                    {
                        g_tabla.FillRectangle(br1, i * w_camp, j * h_camp, w_camp, h_camp);
                    }
                    else
                    {
                        g_tabla.FillRectangle(br2, i * w_camp, j * h_camp, w_camp, h_camp);
                    }
                    g_tabla.DrawRectangle(new Pen(Color.Black), i * w_camp, j * h_camp, w_camp, h_camp);
                }
            }
        }

        private void deseneazaTablaDeSah(object sender, EventArgs e)
        {
            desenare_tabla();
            pb.Refresh();
        }

        private void aseazaPionul(object sender, EventArgs e)
        {
            p1.deseneaza(g_tabla,w_camp,h_camp);
            pb.Refresh();
        }

        private void pb_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(tabla, 0, 0);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //this.Width = 700;
            //this.Height = 500;
        }

        private void pb_MouseDown(object sender, MouseEventArgs e)
        {
            piesa_select = p1.selectPion(e.X, e.Y, w_camp, h_camp);
            mx = e.X % w_camp;
            my = e.Y % h_camp;
        }

        private void pb_MouseUp(object sender, MouseEventArgs e)
        {
            if (piesa_select)
            {
                p1.aseaza((e.X / w_camp) * w_camp, (e.Y / h_camp) * h_camp);
                desenare_tabla();
                p1.deseneaza(g_tabla, w_camp, h_camp);
                pb.Refresh();
            }
            piesa_select = false;
        }

        private void iesireToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void despreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"ඞ");
        }

        private void pb_MouseMove(object sender, MouseEventArgs e)
        {
            if (piesa_select)
            {
                p1.X = e.X - mx;
                p1.Y = e.Y - my;
                desenare_tabla();
                p1.deseneaza(g_tabla, w_camp, h_camp);
                pb.Refresh();
            }
        }
    }
    public class Pion
    {
        Image img;
        int x, y;
        bool black = false;
        public Pion(Image img,int x,int y)
        {
            this.img = img;
            this.x = x;
            this.y = y;
        }
        public int X
        {
            get { return x; }
            set { x = value; }
        }
        public int Y
        {
            get { return y; }
            set { y = value; }
        }
        public void aseaza(int x,int y)
        {
            this.x = x;
            this.y = y;
        }
        public bool selectPion(int xm,int ym,int w_camp,int h_camp)
        {
            return (xm - x) / w_camp == 0 && (ym - y) / h_camp == 0;
        }
        public void deseneaza(Graphics g,int w_camp,int h_camp)
        {
            int qw = w_camp / 4;
            int gh = h_camp / 4;

            g.DrawImage(img, x+qw, y+gh);
        }
    }
}
