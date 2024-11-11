using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Projekt01_Autok
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Adatbazis db = new Adatbazis("localhost", "autok", "root", "");

            List<Sportkocsi> sportkocsiLista = db.Adatlekeres();

            int szelesseg = Screen.PrimaryScreen.Bounds.Width;

            label1.Left = szelesseg / 2;

            List<Image> kepLista = new List<Image>();

            kepLista.Add(Properties.Resources.maserati_01);
            kepLista.Add(Properties.Resources.ferrari_01);
            kepLista.Add(Properties.Resources.lamborghini_01);
            kepLista.Add(Properties.Resources.ferrari_02);
            kepLista.Add(Properties.Resources.maserati_02);
            kepLista.Add(Properties.Resources.lamborghini_02);
            kepLista.Add(Properties.Resources.mclaren_01);
            kepLista.Add(Properties.Resources.ferrari_03);
            kepLista.Add(Properties.Resources.mclaren_02);
            kepLista.Add(Properties.Resources.koenigsegg_01);
            kepLista.Add(Properties.Resources.maserati_03);
            kepLista.Add(Properties.Resources.koenigsegg_02);
            
            int hossz = kepLista.Count;

            for (int i = 0; i < hossz; i++)
            { 
                if (i % 3 == 0)
                {
                    int x = 50;
                    int y = 200 + (i / 3) * 350;

                    GroupBox gb = new GroupBox()
                    {
                        Name = $"gb{i}",
                        Size = new Size(500, 350),
                        Location = new Point(x, y),
                        Text = sportkocsiLista[i].Tipus,
                        Font = new Font(Name, 12.0F),
                    };


                    PictureBox pb = new PictureBox()
                    {
                        Name = $"pb{i}",
                        Size = new Size(200, 200),
                        Location = new Point(10, 30),
                        Image = kepLista[i],
                        SizeMode = PictureBoxSizeMode.Zoom
                    };

                    gb.Controls.Add(pb);

                    Label lb = new Label()
                    {
                        Name = $"lb{i}",
                        Text = $"Ár: {sportkocsiLista[i].Ar} Ft",
                        Location = new Point(10, 250),
                        Width = 300,
                    };

                    gb.Controls.Add(lb);

                    Controls.Add(gb);
                } 
                else if (i % 3 == 1)
                {
                    int x = 600;
                    int y = 200 + (i / 3) * 350;

                    GroupBox gb = new GroupBox()
                    {
                        Name = $"gb{i}",
                        Size = new Size(500, 350),
                        Location = new Point(x, y),
                        Text = sportkocsiLista[i].Tipus,
                        Font = new Font(Name, 12.0F),
                    };

                    PictureBox pb = new PictureBox()
                    {
                        Name = $"pb{i}",
                        Size = new Size(200, 200),
                        Location = new Point(10, 30),
                        Image = kepLista[i],
                        SizeMode = PictureBoxSizeMode.Zoom
                    };

                    gb.Controls.Add(pb);

                    Label lb = new Label()
                    {
                        Name = $"lb{i}",
                        Text = $"Ár: {sportkocsiLista[i].Ar} Ft",
                        Location = new Point(10, 250),
                        Width = 300,
                    };

                    gb.Controls.Add(lb);

                    Controls.Add(gb);
                } 
                else
                {
                    int x = 1150;
                    int y = 200 + (i / 3) * 350;

                    GroupBox gb = new GroupBox()
                    {
                        Name = $"gb{i}",
                        Size = new Size(500, 350),
                        Location = new Point(x, y),
                        Text = sportkocsiLista[i].Tipus,
                        Font = new Font(Name, 12.0F),
                    };

                    PictureBox pb = new PictureBox()
                    {
                        Name = $"pb{i}",
                        Size = new Size(200, 200),
                        Location = new Point(10, 30),
                        Image = kepLista[i],
                        SizeMode = PictureBoxSizeMode.Zoom
                    };

                    gb.Controls.Add(pb);

                    Label lb = new Label()
                    {
                        Name = $"lb{i}",
                        Text = $"Ár: {sportkocsiLista[i].Ar} Ft",
                        Location = new Point(10, 250),
                        Width = 300,
                    };

                    gb.Controls.Add(lb);

                    Controls.Add(gb);
                }
            }
        }
    }
}
