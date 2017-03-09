using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Resources;
using WindowsFormsApplication1.Properties;

namespace WindowsFormApplication1
{
    public partial class Form1 : Form
    {
        List<PictureBox> speelBord = new List<PictureBox>(16);
        List<string> logischBord = new List<string>(16);
        List<int> geradenIDBord = new List<int>(16);

        int keuze1 = -1;
        int keuze2 = -1;

        ResourceManager rm = new ResourceManager(typeof(Resources));

        public Form1()
        {
            InitializeComponent();
            BordenAanmaken();
        }

        private int Rol(int begin, int eind)
        {
            Random steen = new Random();
            int randomGetal = steen.Next(begin, eind);
            return randomGetal;
        }

        private void BordenAanmaken()
        {
            for (int i = 0; i < 16; i++)
            {
                string naam = "pictureBox" + (i + 1).ToString();
                Control[] usercontontrols = this.Controls.Find(naam, true);
                PictureBox pictureBox = (PictureBox)usercontontrols[0];

                pictureBox.Image = (Bitmap)rm.GetObject("A");
                speelBord.Add(pictureBox);

                geradenIDBord.Add(i);
            }

            for (int i = 0; i < 16; i++)
            {
                int figuurID = Rol(0, 16);
                if (geradenIDBord.Exists(v => v == figuurID))
                {
                    int ind = figuurID % 8;
                    logischBord.Add("pic" + ind.ToString());
                    geradenIDBord.Remove(figuurID);
                }
                else
                {
                    i--;
                }
            }
        }

        private bool Speel(int figID)
        {
            if (!geradenIDBord.Exists(v => v == figID))
            {
                if (keuze1 == -1)
                {
                    keuze1 = figID;
                    speelBord[figID].Image = (Bitmap)rm.GetObject(logischBord[figID]);
                }
                else
                {
                    if ((figID != keuze1) && (figID != keuze2))
                    {
                        if (keuze2 == -1)
                        {
                            keuze2 = figID;
                            speelBord[figID].Image = (Bitmap)rm.GetObject(logischBord[figID]);
                        }
                        else
                        {
                            if (logischBord[keuze1] == logischBord[keuze2])
                            {
                                geradenIDBord.Add(keuze1);
                                geradenIDBord.Add(keuze2);
                                keuze2 = -1;
                            }
                            else
                            {
                                speelBord[keuze1].Image = (Bitmap)rm.GetObject("A");
                                speelBord[keuze2].Image = (Bitmap)rm.GetObject("A");
                                keuze2 = -1;
                            }

                            keuze1 = figID;
                            speelBord[figID].Image = (Bitmap)rm.GetObject(logischBord[figID]);
                        }
                    }
                }
            }

            if ((geradenIDBord.Count() >= 14) && (keuze2 != -1))
                return false;
            return true;
        }

        private void Figuur_Click(object sender, EventArgs e)
        {
            PictureBox image = (PictureBox)sender;
            textBox1.Text = image.Name;

            Speel(Convert.ToInt32(image.Tag));
        }

        private void Herstart_Click(object sender, EventArgs e)
        {
            textBox1.Text = "Spel opnieuw starten";
            BordenAanmaken();
        }
    }
}