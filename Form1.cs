using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Slot
{
    // Driza Enes - Slot v.0.1
    // Note: 
    /* DoWork -> controlla se deve girare e se è
     *           l'ultimo rullo verifica la vittoria.
     * ReportProgress -> rulla
     * RunWorkerCompleted -> stampo le statistiche
     * 
     * Risorsa -> contiene le varie statistiche
     *            della giocata e i rulli.
     *            
     * Start -> avvia il gioco
     * Stop -> blocca il gioco
     * 
     * 9 "figure"
     */
    public partial class frmMain : Form
    {
        List<BackgroundWorker> bgwList;
        List<Image> imgList;
        List<PictureBox> rulliList;
        Risorsa risorsa;
        Random random = new Random();
        Stopwatch stopwatch;
        public const int NUMERO_RULLI = 3;
        
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            this.Text = "Slot";
            this.MaximizeBox = false;

            lblTxtNPartite.BackColor = Color.Transparent;
            lblTctNVittorie.BackColor = Color.Transparent;
            lbl_nPartite.BackColor = Color.Transparent;
            lbl_nVittorie.BackColor = Color.Transparent;
            lblTempo.BackColor = Color.Black;

            lbl_nPartite.ForeColor = Color.White;
            lbl_nVittorie.ForeColor = Color.White;
            lblTempo.ForeColor = Color.White;

            lbl_nPartite.Text = "0";
            lbl_nVittorie.Text = "0";
            lblTempo.Text = "Tempo trascorso 00:00:00";
            btnStop.Enabled = false;

            // lista figure
            imgList = new List<Image>();
            imgList.Add(Properties.Resources.imgAnguria);
            imgList.Add(Properties.Resources.imgArancia);
            imgList.Add(Properties.Resources.imgBanana);
            imgList.Add(Properties.Resources.imgBAR);
            imgList.Add(Properties.Resources.imgCampanella);
            imgList.Add(Properties.Resources.imgCiliegia);
            imgList.Add(Properties.Resources.imgLimone);
            imgList.Add(Properties.Resources.imgNumero7);
            imgList.Add(Properties.Resources.imgUva);

            // lista rulli
            rulliList = new List<PictureBox>();
            rulliList.Add(pcbSlot_A);
            rulliList.Add(pcbSlot_B);
            rulliList.Add(pcbSlot_C);
        }
       

        private void btnStart_Click(object sender, EventArgs e)
        {
            risorsa = new Risorsa(rulliList, 0);
            stopwatch = new Stopwatch();

            btnStop.Enabled = true;
            btnStart.Enabled = false;

            lbl_nPartite.Text = "0";
            lbl_nVittorie.Text = "0";
            lblTempo.Text = "Tempo trascorso 00:00:00";

            // lista bgw 
            bgwList = new List<BackgroundWorker>();
            for (int i = 0; i < NUMERO_RULLI; i++)
            {
                BackgroundWorker bgw = new BackgroundWorker();
                bgw.WorkerReportsProgress = true;
                bgw.WorkerSupportsCancellation = true;
                bgw.DoWork += Bgw_DoWork;
                bgw.ProgressChanged += Bgw_ProgressChanged;
                bgw.RunWorkerCompleted += Bgw_RunWorkerCompleted;

                bgwList.Add(bgw);
            }

            for (int i = 0; i < NUMERO_RULLI; i++)
            {
                bgwList[i].RunWorkerAsync(i); // i = turno (my_turn)
            }
            // stopwatch
            stopwatch.Start();
        }


        private void btnStop_Click(object sender, EventArgs e)
        {
            btnStop.Enabled = false;
            btnStart.Enabled = true;

            foreach (var item in bgwList)
            {
                item.CancelAsync(); 
            }
        }


        private void Bgw_DoWork(object sender, DoWorkEventArgs e)
        {
            var bgw = sender as BackgroundWorker;
            int my_turn = (int)e.Argument;

            do
            {
                var numGIri = random.Next(8, 12); // numero di giri del rullo variabile

                while (numGIri > 0) // finchè devo girare
                {
                    if (bgw.CancellationPending) 
                    {
                        System.Threading.Thread.Sleep(100);
                        return; // termino l'esecuzione
                    }

                    lock (risorsa)
                    {
                        if (risorsa.TURNO == my_turn) // il turno corrispondente al rullo
                        {
                            bgw.ReportProgress(my_turn); // turno rullo

                            System.Threading.Thread.Sleep(100);
                            numGIri--;
                        }
                    }

                }
                // dopo aver finito lo spin controllo se sono l'ultimo rullo
                lock(risorsa)
                {
                    if (risorsa.TURNO == NUMERO_RULLI - 1) // se è l'ultimo round controlo se ho vinto
                    {
                        // controllo se ho vinto
                        if (risorsa.Vittoria())
                        {
                            risorsa.NVITTORIE++; // incremento le vittorie
                            // mostro di aver vinto
                            MessageBox.Show("Vittoria", "HAI VINTO!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        // aggiorno il numero di partite  
                        risorsa.NPARTITE++;
                    }
                    // cambio turno
                    risorsa.TURNO++;
                }              
            } while (true);

        }

        private void Bgw_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            var t = (int)e.ProgressPercentage; // turno

            // RULLO!
            rulliList[t].Image = imgList.ElementAt(random.Next(imgList.Count));
        }


        private void Bgw_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            lock(risorsa)
            {
                // visualizzazione dei dati
                lbl_nVittorie.Text = risorsa.NVITTORIE.ToString();
                lbl_nPartite.Text = risorsa.NPARTITE.ToString();

                risorsa.TURNO = 0; // ricomincio dal primo  
            }

            // stampo la durata delle giocate 
            stopwatch.Stop();
            lblTempo.Text = ("Tempo trascorso" + " " +
                                stopwatch.Elapsed.Minutes.ToString() + ":" +
                                stopwatch.Elapsed.Seconds.ToString() + ":" +
                                stopwatch.Elapsed.Milliseconds.ToString()
                            );
        }


    }


}
