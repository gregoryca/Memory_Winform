using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Resources;

namespace WindowsFormApplication1
{
    public partial class Form1 : Form
    {
        #region Globale variabelen Dec. en Int.
        List<PictureBox> speelBord;
        List<string> logischBord;
        List<int> geradenIDBord;

        int spelerKlikken = 0, begin = 0, eind = 15, keuze1 = -1, keuze2 = -1;

        ResourceManager rm = new ResourceManager(typeof(WindowsFormsApplication1.Properties.Resources));
        
        #endregion


        #region Constructors voor Initialisatie
        public Form1()
        {
            InitializeComponent();
            BordenAanmaken();

        }
        #endregion

        #region Benodigde Methoden
        /// <summary>
        /// Genereerd een Willekeurig Getal vanaf begin tot eind
        /// </summary>
        /// <param name="begin">Begin getal</param>
        /// <param name="eind">Eind Getal</param>
        /// <returns></returns>
        int Rol(int begin, int eind)
        {
            Random steen = new Random();
            int randomGetal = steen.Next(begin, eind);
            //Tijd nodig voor variatie
            System.Threading.Thread.Sleep(15);
            return randomGetal;
        }
        /// <summary>
        /// Initialiseerd de drie benodigde Borden
        /// </summary>
        void BordenAanmaken()
        {
            //Het Speelbord, lijst met Pictureboxen, voor de weer te geven figuren, vullen met figuurRug
        speelBord = new List<PictureBox>(eind + 1);
            //Het GeradenBordID Houdt de afgehandelde figuurindexen, van hetlogische bord, bij
        geradenIDBord = new List<int>(eind + 1);
            //Vul het logische bord met 2X een Reeks van 8 figuren, 0 t/m 7, op willekeurige / Random() locaties
              logischBord = new List<string>(eind + 1);
            for (int teller = begin; teller <= eind; teller++)
            {
                string naam = "pictureBox" + (teller + 1).ToString();
                Control[] usercontontrols = this.Controls.Find(naam, true);
                PictureBox pictureBox = (PictureBox)usercontontrols[0];

                pictureBox.Image = (Bitmap)rm.GetObject("A");
                speelBord.Add(pictureBox);

                geradenIDBord.Add(teller);
            }

            for (int teller = begin; teller <= eind; teller++)
            {
                //Genereer een willekeurige index, 0 t/m 15, als lokatie voor het figuur in het logische bord
                int figuurID = Rol(begin, eind + 1);
                    //Controleer als de Index nog niet eerder gebruikt is, Dus in de GeradenBordID
                if (geradenIDBord.Exists(v => v == figuurID))
                {
                //Modolo 8 nodig gezien 2 stes van 8, 0 t/m 15, en slecht de set ID 0t / m7 nodig is
                int ind = figuurID % 8;
                //Voeg het figuur met naam en ID, 0 t/m 8, op de lokatie met index teller
                logischBord.Add("pic" + ind.ToString());
                //Verwijder het gebruikte figuurID uit de lijst geradenIDBord
                geradenIDBord.Remove(figuurID);
                }
                else
                {
                    //figuurID is reeds gebruikt, dus nog 1 keer extra door de lus.
                    teller--;
                }
            }
        }
            /// <summary>
            /// Handelt de zetten van het Memory spel af.
            /// </summary>
            /// <param name="figID">ID van het Speelbordveld begin t/m eind</param>
            /// <returns></returns>
            bool Speel(int figID)
                    {
                        //Het FiguurID, figID, is nog niet geraden, komt niet voor in geradenIDBord Lijst
            if (!geradenIDBord.Exists(v => v == figID))
                        {
                            //Verhoog het aantal gespeelde klikken met 1
                            spelerKlikken++;
                            //Gaat het om de eerste figuur keuze
                            if (keuze1 == -1)
                            {
                                //Onthoudt de eerste figuur keuze
                                keuze1 = figID;
                                //Geef in het speelbord, lokatie id, aan welk fig uit logischbord moet worden weergegeven.
            speelBord[figID].Image = (Bitmap)rm.GetObject(logischBord[figID]);
                            }

                            else
                            {
                                //Om niet geldige, reeds geklikte figuren op te vangen && Spel Keuze2 op te vangen
            if ((figID != keuze1) && (figID != keuze2))
                                {
                                    //Gaat het om de tweede figuur keuze
                                    if (keuze2 == -1)
                                    {
                                        //Onthoudt de tweede figuur keuze
                                        keuze2 = figID;
                                        //Geef in het speelbord, lokatie id, aan welk fig uit logischbord moet worden weergegeven.
            speelBord[figID].Image = (Bitmap)rm.GetObject(logischBord[figID]);
                                    }
                                    else
                                    { //Zijn de twee gekozen figuren het zelfde
                                    if (logischBord[keuze1] == logischBord[keuze2])
                                        {
                                            //Voeg de twee geraden figuren toe aan de lijst MemoryGeradenBordID
                                            geradenIDBord.Add(keuze1);
                                            geradenIDBord.Add(keuze2);
                                            //Verwijder het tweede gekozen figuur
                                            keuze2 = -1;
                                        }
                                        else
                                        {
                                            //Geef aan dat nu het figuurrug nu op de twee gekozen lokaties moet worden weergegeven.
                                              speelBord[keuze1].Image = (Bitmap)rm.GetObject("A");
                                            speelBord[keuze2].Image = (Bitmap)rm.GetObject("A");
                                            //Verwijder het tweede gekozen figuur
                                            keuze2 = -1;
                                        };
                                        //Voeg toe als het eerste gekozen figuur
                                        keuze1 = figID;
                                        //Geef in het speelbord, lokatie id, aan welk fig uit logischbord moet worden weergegeven.
                                           speelBord[figID].Image = (Bitmap)rm.GetObject(logischBord[figID]);
                                    }
                                }
                            };
                        }
                        //Zijn er reeds 7 figurparen geraden, dan is het spel geeindigd
                        if ((geradenIDBord.Count() >= 14) && (keuze2 != -1))
                        {
                            return false;
                        }
                        else
                        {
                            return true;
                        }
            ;
                    }
        #endregion

        #region Event Handlers
        /// <summary>
        /// Dient om de aplicatie te (Her)starten.
        /// </summary>
        /// <param name="sender">De UC die geklikt is</param>
        /// <param name="e">Informatie over het event</param>
        /// 


        private void Figuur_Click(object sender, EventArgs e)
        {
            PictureBox image = (PictureBox)sender;
            textBox1.Text = image.Name;

            Speel(Convert.ToInt32(image.Tag));
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void veldX2ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Herstart_Click(object sender, EventArgs e)
        {
            textBox1.Text = "Spel opnieuw starten";

            BordenAanmaken();
        }
        private void spelbordenToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void bestandenToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }
    }
}
#endregion