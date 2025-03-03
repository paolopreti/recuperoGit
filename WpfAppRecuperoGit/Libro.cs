using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfAppRecuperoGit
{
    internal class Libro
    {

        private string casaEditrice, titolo;
        private List<Partita> partite;
        private int numPagine;

        public Libro(string casaEditrice, string titolo, int numPagine, List<Partita> partite)
        {
            this.casaEditrice = casaEditrice;
            this.titolo = titolo;
            this.numPagine = numPagine;
            this.partite = partite;
        }

        public string CasaEditrice { get { return casaEditrice; } }
        public string Titolo { get { return titolo; } }
        public int NumPagine { get { return numPagine; } }


        public void aggiungiPartita(Partita partita)
        {
            this.partite.Add(partita);
        }

        public Partita cercaPartitaConAnno(int anno)
        {
            List<string> marcatoridefault = new List<string>();
            Partita partitaDefault = new Partita("c'e stato un errore", "", -1, "", marcatoridefault); 
            for (int i = 0; i < partite.Count; i++)
            {
                if (partite[i].anno == anno) return partite[i];
            }
            return partitaDefault;
        }

        public int numPartite()
        {
            return this.partite.Count;
        }
    }
}
