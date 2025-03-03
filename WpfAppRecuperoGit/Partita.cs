using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Animation;

namespace WpfAppRecuperoGit
{
    internal class Partita
    {
        private string squadraInCasa, squadraInTrasferta, risultato;
        private List<string> marcatori;
        private int anno;

        public Partita(string squadraInCasa, string squadraInTrasferta, string risultato, List<string> marcatori, int anno)
        {
            this.squadraInCasa = squadraInCasa;
            this.squadraInTrasferta = squadraInTrasferta;
            this.risultato = risultato;
            this.marcatori = marcatori;
            this.anno = anno;
            
        }

        public string SquadraInCasa { get {  return squadraInCasa; } }
        public string SquadraInTrasferta {  get {return squadraInTrasferta; } }
        public string Risultato { get { return risultato; } }
        public int Anno { get { return anno; } }    

        public string toString()
        {
            string stringaFinale = $"squadra in casa: {squadraInCasa}, squadra in trasferta: {squadraInTrasferta}, risultato: {risultato}, marcatori:";

            for (int i = 0; i < marcatori.Count; i++) stringaFinale += marcatori[i];

            return stringaFinale;
        }

        public string qualitàPartita()
        {
            //TODO
        }
    }
}
