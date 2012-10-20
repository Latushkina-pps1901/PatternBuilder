using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Collections;

namespace PatternBuilder
{
    public partial class Form1 : Form
    {
        public static List<Image> blouses = new List<Image>();
        public static List<Image> skirts = new List<Image>();
        public static List<Image> shoes = new List<Image>();

        public Form1()
        {
            InitializeComponent();
            blouses.Add(Image.FromFile(@"images/s_blouse1.png"));
            blouses.Add(Image.FromFile(@"images/w_blouse1.png"));
            blouses.Add(Image.FromFile(@"images/d_blouse2.png"));
            blouses.Add(Image.FromFile(@"images/p_dress1.png"));

            skirts.Add(Image.FromFile(@"images/s_trousers1.png"));
            skirts.Add(Image.FromFile(@"images/w_skirt1.png"));
            skirts.Add(Image.FromFile(@"images/d_skirt1.png"));

            shoes.Add(Image.FromFile(@"images/s_shoes1.png"));
            shoes.Add(Image.FromFile(@"images/w_shoes1.jpg"));
            shoes.Add(Image.FromFile(@"images/d_shoes1.png"));
            
            
        }

        private void btnUniver_Click(object sender, EventArgs e)
        {
            BuilderBlouse blouse = new BuilderBlouse("s");
            BuilderSkirt skirt = new BuilderSkirt("s");
            BuilderShoes shoes = new BuilderShoes("s");
            Graphics g = pictureBox1.CreateGraphics();
            g.DrawImage(Image.FromFile(@"images/Girl.jpg"), 0, 0);
            
            skirt.dress(g);
            blouse.dress(g);shoes.dress(g);


        }

        class BuilderBlouse
        {
            Image b;
            public BuilderBlouse(string style)
            {
                switch (style)
                {
                    case "s":   b = blouses[0];
                        break;
                    case "w": b = blouses[1];
                        break;
                    case "d": b = blouses[2];
                        break;
                    case "p": b = blouses[3];
                        break;

                }
            }

            public void dress(Graphics g)
            {
               g.DrawImage(b, new Point(29, 72));
            }
        }

        class BuilderSkirt
        {
            Image s;
            public BuilderSkirt(string style)
            {
                switch (style)
                {
                    case "s": s = skirts[0];
                        break;
                    case "w": s = skirts[1];
                        break;
                    case "d": s = skirts[2];
                        break;
                    case "p": s = skirts[3];
                        break;

                }
            }

            public void dress(Graphics g)
            {
                g.DrawImage(s, new Point(47, 180));
            }
        }

        class BuilderShoes
        {
            Image s;
            public BuilderShoes(string style)
            {
                switch (style)
                {
                    case "s": s = shoes[0];
                        break;
                    case "w": s = shoes[1];
                        break;
                    case "d": s = shoes[2];
                        break;
                    case "p": s = shoes[3];
                        break;

                }
            }

            public void dress(Graphics g)
            {
                g.DrawImage(s, new Point(60, 400));
            }
        }

        private void btnWork_Click(object sender, EventArgs e)
        {
            BuilderBlouse blouse = new BuilderBlouse("w");
            BuilderSkirt skirt = new BuilderSkirt("w");
            BuilderShoes shoes = new BuilderShoes("w");

            Graphics g = pictureBox1.CreateGraphics();
            g.DrawImage(Image.FromFile(@"images/Girl.jpg"), 0, 0);
            shoes.dress(g);
            skirt.dress(g);
            blouse.dress(g);
        }

        private void btnDisco_Click(object sender, EventArgs e)
        {
            BuilderBlouse blouse = new BuilderBlouse("d");
            BuilderSkirt skirt = new BuilderSkirt("d");
            BuilderShoes shoe = new BuilderShoes("d");

            Graphics g = pictureBox1.CreateGraphics();
            g.DrawImage(Image.FromFile(@"images/Girl.jpg"), 0,0);
            shoe.dress(g);
            skirt.dress(g);
            blouse.dress(g);
        }

        private void btnSleep_Click(object sender, EventArgs e)
        {
            BuilderBlouse blouse = new BuilderBlouse("p");
            Graphics g = pictureBox1.CreateGraphics();
            g.DrawImage(Image.FromFile(@"images/Girl.jpg"), 0, 0);
            blouse.dress(g);
        }


    }
}
