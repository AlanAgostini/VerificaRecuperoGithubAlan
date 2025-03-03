using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfAppVerificaRecupero
{
    internal class Libro
    {
        public Libro() 
        {
            //Questo è un commento
            string CasaEditrice;
            int Pagine;
            string Titolo;
            List<Partita> ListaPartite = new List<Partita>();
            static List<Partita> RicercaAnno(int anno)
            {
                List<Partita> soluzione = new List<Partita>();
                for (int i = 0; i < ListaPartite.Count; i++)
                {
                    if (ListaPartite[i].Anno == anno)
                    {
                        soluzione.Add(ListaPartite[i]);
                    }
                }
                return soluzione;
            }
            static void AggiungiPartita(Partita partita)
            {
                ListaPartite.Add(partita);
            }
            static List<Partita> RicercaSquadra()
            {
                List<Partita> soluzione = new List<Partita>();
                return soluzione;
            }
            static int totalePartite()
            {
                return 0;
            }
        }
    }
}
