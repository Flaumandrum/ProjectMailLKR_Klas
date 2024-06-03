using Klasse_Persoon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectMailLKR
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmStartmenu());
        }

        // Tom Adriaens
        // 03/06/2024
        // Project Mail

        //Velden 
        static List<Persoon> _personen = new List<Persoon>();

        //Functies
        /// <summary>
        /// Maakt een object van persoon aan en voegt het toe aan de lijst.
        /// </summary>
        /// <param name="ontvVoorn"></param>
        /// <param name="ontvAchtern"></param>
        static public void PersoonToevoegen(String ontvVoorn, String ontvAchtern)
        {
            // maak een nieuw object van de klasse 
            Persoon nieuwePersoon = new Persoon(ontvVoorn, ontvAchtern);

            // opslaan in de lijst
            _personen.Add(nieuwePersoon);

        }

        /// <summary>
        /// Stuurt een lijst door met alle namen van de personen
        /// </summary>
        /// <returns></returns>
        static public List<String> GetPersonen()
        {
            List<String> antwoord = new List<String>();

            foreach (Persoon p in _personen)
            {
                antwoord.Add(p.VolledigeNaam());
            }

            return antwoord;
        }

        /// <summary>
        /// Toont alle gegevens van alle personen
        /// </summary>
        /// <returns></returns>
        static public String AllesTonen()
        {
            string antwoord = "";

            foreach (Persoon p in _personen)
            { 
                antwoord += p.AlleGegevens();
            }

            return antwoord;
        }

        /// <summary>
        /// Geeft alle gegevens van een specifiek persoon
        /// </summary>
        /// <param name="ontvIndex"></param>
        /// <returns></returns>
        static public String GetGegevensPersoon (int ontvIndex)
        {
            return _personen[ontvIndex].AlleGegevens();
        }
    }
}
