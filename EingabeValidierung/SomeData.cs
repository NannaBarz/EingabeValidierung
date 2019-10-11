using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EingabeValidierung
{
    public class SomeData
    {
        private int _wert;

        private string _wert2;
        //nur wert zwischen 5 und 12
        public int Zahl
        {
            get => _wert;
            set
            {
                //Validierungsregeln

                if (value >= 5 && value <= 12)
                {
                    _wert = value;
                }
                else
                {
                    //exception mit Fehlermeldung auslösen
                    throw new Exception("Wert mus zwischen 5 und 12 liegen!");
                }

            }
        }

        public override string ToString()
        {
            return $"Inhalt des Objektes: {Zahl}, {Alpha}";
        }

        //Inhalt muss mindestens 3  stellen lang sein
        public string Alpha
        {
            get => _wert2;
            set
            {
                if (value.Length >= 3)
                {
                    _wert2 = value;
                }

                else
                {
                    //exception mit Fehlermeldung auslösen
                    throw new Exception("Muss mindestens 3 Zeichen haben!");
                }
            }

        }

    }
}
