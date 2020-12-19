using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Slot
{
    public class Risorsa
    {
        // attributi
        private List<PictureBox> rulli;
        private int turno;
        private int nPartite;
        private int nVittorie;

        // costruttore
        public Risorsa()
        {
            rulli = null;
            turno = -1;
            nPartite = 0;
            nVittorie = 0;
        }
        public Risorsa(List<PictureBox> r, int t)
        {
            rulli = r;
            turno = t;
            nPartite = 0;
            nVittorie = 0;
        }

        // proprietà
        public List<PictureBox> RULLI
        {
            get { return rulli; }
            set { rulli = value; }
        }

        public int TURNO
        {
            get { return turno; }
            set { turno = turno == 2 ? 0 : value; }
        }

        public int NPARTITE
        {
            get { return nPartite; }
            set { nPartite = value; }
        }

        public int NVITTORIE
        {
            get { return nVittorie; }
            set { nVittorie = value; }
        }

        // metodi
        public bool Vittoria()
        {
            if (rulli[0].Image == rulli[1].Image && rulli[1].Image == rulli[2].Image)
                return true;

            return false;
        }


    }
}
