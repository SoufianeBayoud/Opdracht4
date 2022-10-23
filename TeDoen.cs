using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeDoen
{
    internal class TeDoen
    {
        private static int Id;
        private DateTime? Tijdstip;
        private string Titel;
        private string[] Informatie;

        public TeDoen(string Titel, string[] Informatie, DateTime Tijdstip)
        {
            this.Titel = Titel;
            this.Informatie = Informatie;
            if(Tijdstip >= DateTime.Now)
            {
                this.Tijdstip = Tijdstip;
            }
            else
            {
                this.Tijdstip = null;
            }
            Id++;
        }

        public override string ToString()
        {
            string text = "";

            foreach (string line in Informatie)
            {
                text += line.ToString() + "\n";

            }

            if (Tijdstip == null)
            {
                return "Id: " + Id + "\n Titel : " + Titel + "\n Informatie : " + text;
            }
            else
            {
                return "Tijdstip: " + Tijdstip + "\n Id: " + Id +  "\n Titel : " + Titel + "\n Informatie : " + text;
            }

        }




    }
}
