using System.ComponentModel;
using System.Reflection.Metadata.Ecma335;

namespace TTIProject.Models
{
    public class Beteg
    {
        /// <summary>
        /// Beteg neve
        /// </summary>
        private string _nev;
        /// <summary>
        /// Beteg súlya (kg)
        /// </summary>
        private double _suly;
        /// <summary>
        /// Beteg magassága (méter)
        /// </summary>
        private double _magassag;

        /// <summary>
        /// Alapértelmezett konstruktor
        /// </summary>
        public Beteg()
        {
            _nev = string.Empty;
            _suly = 60;
            _magassag = 1.6;
        }

        /// <summary>
        /// Írható tulajdonságok
        /// </summary>
        public string Nev
        {
            get => _nev;
            set => _nev=value;
        }
        public double Suly
        {
            get => _suly;
            set => _suly = value;
            
        }

        public double Magassag
        {
            get => _magassag;
            set => _magassag = value;
        }

        /// <summary>
        /// Olvasható tulajdonságok
        /// Testtömeg index: kg / magasság^2
        /// </summary>
        public double TTI
        {
            get
            {
                double tti = _suly / Math.Pow(_magassag, 2);
                double roundedTTI = Math.Round(tti, 2);
                return roundedTTI;
            }
        }

        public string BetegAdatok
        {
            get
            {
                return $"{_nev} beteg testőmeg indexe:  {TTI}";
            }
        }
    }
}
