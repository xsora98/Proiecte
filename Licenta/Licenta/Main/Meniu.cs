using Licenta.Introducere;
using Licenta.Main;
using Licenta.Vizualizare;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Licenta
{
    public partial class Meniu : Form
    {
        public static int id_utilizator;
        public Meniu()
        {
            InitializeComponent();
        }

        private void Meniu_Load(object sender, EventArgs e)
        {
            if (LoginPanel.rol == "Casier")
            {
                introducereDateToolStripMenuItem.Visible = false;
                vizualizareAngajatToolStripMenuItem.Visible = false;
                vizualizareDepartamentToolStripMenuItem.Visible = false;
                vizualizareFuncțieToolStripMenuItem.Visible = false;
                vizualizareUtilizatorToolStripMenuItem.Visible = false;
                vizualizareLogToolStripMenuItem.Visible = false;
                vizualizareSugestiiToolStripMenuItem.Visible = false;
            }
        }

        private void schimbareParolăToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SchimbareParola schimbareParola = new SchimbareParola();
            schimbareParola.ShowDialog();
        }

        private void Logout_Click(object sender, EventArgs e)
        {
            Constante.Log("Logout", DateTime.Now.ToString("dd-MMM-yyyy-HH-mm-ss"), Meniu.id_utilizator);
            this.Visible = false;
            LoginPanel login = new LoginPanel();
            login.ShowDialog();
        }

        private void introducereUtilizatorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IntroducereUtilizator introducereUtilizator = new IntroducereUtilizator();
            introducereUtilizator.ShowDialog();
        }

        private void Meniu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Constante.Log("Logout", DateTime.Now.ToString("dd-MMM-yyyy-HH-mm-ss"), Meniu.id_utilizator);
            Application.Exit();
        }

        private void introducereDepartamentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IntroducereDepartament introducereDepartament = new IntroducereDepartament();
            introducereDepartament.ShowDialog();
        }

        private void introducereFuncțieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IntroducereFunctie introducereFunctie = new IntroducereFunctie();
            introducereFunctie.ShowDialog();
        }

        private void introducereAngajatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IntroducereAngajat introducereAngajat = new IntroducereAngajat();
            introducereAngajat.ShowDialog();
        }

        private void introducereDistribuitorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IntroducereDistribuitor introducereDistribuitor = new IntroducereDistribuitor();
            introducereDistribuitor.ShowDialog();
        }

        private void adaugareProduseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IntroducereProdus introducereProdus = new IntroducereProdus();
            introducereProdus.ShowDialog();
        }

        private void vizualizareProduseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VizualizareProduse vizualizareProduse = new VizualizareProduse();
            vizualizareProduse.ShowDialog();
        }

        private void vizualizareFuncțieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VizualizareFunctie vizualizare = new VizualizareFunctie();
            vizualizare.ShowDialog();
        }

        private void vizualizareUtilizatorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VizualizareUtilizator vizualizareUtilizator = new VizualizareUtilizator();
            vizualizareUtilizator.ShowDialog();
        }

        private void vizualizareAngajatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VizualizareAngajat vizualizareAngajat = new VizualizareAngajat();
            vizualizareAngajat.ShowDialog();
        }

        private void vizualizareDepartamentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VizualizareDepartament vizualizareDepartament = new VizualizareDepartament();
            vizualizareDepartament.ShowDialog();
        }

        private void vizualizareDistribuitorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VizualizareDistribuitor vizualizareDistribuitor = new VizualizareDistribuitor();
            vizualizareDistribuitor.ShowDialog();
        }

        private void vânzareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IntroducereVanzare introducereVanzare = new IntroducereVanzare();
            introducereVanzare.ShowDialog();
        }

        private void vizualizareVanzariToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VizualizareProduseVandute vizualizareProduseVandute = new VizualizareProduseVandute();
            vizualizareProduseVandute.ShowDialog();
        }

        private void vizualizareLivrariToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VizualizareLivrare vizualizareLivrare = new VizualizareLivrare();
            vizualizareLivrare.ShowDialog();
        }

        private void verificareProdusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VerificareProdusScan verificareProdusScan = new VerificareProdusScan();
            verificareProdusScan.ShowDialog();
        }

        private void vizualizareSugestiiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VizualizareSugestii vizualizareSugestii = new VizualizareSugestii();
            vizualizareSugestii.ShowDialog();
        }

        private void vizualizareLogToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VizualizareLog vizualizareLog = new VizualizareLog();
            vizualizareLog.ShowDialog();
        }
    }
}
