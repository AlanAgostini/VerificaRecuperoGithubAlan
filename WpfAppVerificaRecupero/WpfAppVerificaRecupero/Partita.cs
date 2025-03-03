using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfAppVerificaRecupero
{
    internal class Partita
    {

        class Partita(string squadraCasa, string squadraOspite, int anno, int[] Risultato, string NominativiMarcatori)
        {
            static string SquadraCasa = "";
            static string SquadraOspite = "";
            static int Anno = 0;
            static int[] Risultato = new int[2];
            static string NominativiMarcatori = "";
            static void toString()
            {

                Console.WriteLine("Squadra in casa = {0}, Squadra ospite = {1}, Anno = {2}, Risultato = {3}, NominativiMarcatori = {4}", SquadraCasa, SquadraOspite, Anno, Risultato, NominativiMarcatori);
            }
            static void qualitàPartita()
            {
                int sommaGol = 0;
                for (int i = 0; i < Risultato.Length; i++)
                {
                    sommaGol += Risultato[i];
                }
                if (sommaGol == 0)
                {
                    Console.WriteLine("Partita noiosa");
                }
                else if (sommaGol > 4)
                {
                    Console.WriteLine("Partita divertente");
                }
                else
                {
                    Console.WriteLine("Partita normale");
                }
            }
        }
    }
}
