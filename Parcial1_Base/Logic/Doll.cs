using System.Collections.Generic;

namespace Parcial1_Base.Logic
{
    /// <summary>
    /// Definition for the player's avatar. Players dress up a doll to win the contest.
    /// </summary>
    public class Doll : IClonable<Doll>
    {

       
        /// <summary>
        /// The accessories collection.
        /// </summary>
        private List<Accessory> accessories = new List<Accessory>();

        /// <summary>
        /// The doll's name
        /// </summary>
        public string Name { get; protected set; }

        /// <summary>
        /// Whether the doll can be included in the contest.
        /// </summary>
        public bool CanParticipate
        {
            set
            {
                CanParticipate = value;

            }
            get
            {
                bool resultado = false;
                if (accessories.Contains(Dress))
                {
                    resultado = true;

                }
                return resultado;
            }
        }
             
        /// <summary>
        /// The total accessories count worn by the doll.
        /// </summary>
        public int TotalAccessories {
            get { accessories.Count; }
            set { }


             }

        public int BraceletCount { get { 0; } }

        /// <summary>
        /// The total style score, affected by each worn accessory.
        /// </summary>
        public int Style {
            get {
                int puntosTotales=0;

                for (int i = 0; i < accessories.Count; i++) {
                    puntosTotales += accessories[i].Style;
                }
                return puntosTotales;
            }
            set { Style = value; }

           
        }

        public Doll(string name)
        {
            Name = name;
        }

        /// <summary>
        /// Removes the given accessory.
        /// </summary>
        /// <param name="a">The accessory to be removed</param>
        /// <returns>True if the accessory was being worn, then removed. False otherwise</returns>
        public bool Remove(Accessory a)
        {
            bool result = false;

            return result;
        }

        /// <summary>
        /// Makes the doll wear the given accessory
        /// </summary>
        /// <param name="a">The accessory to be worn by the doll</param>
        /// <returns>True if the doll successfully wore the accessory. False otherwise</returns>
        public bool Wear(Accessory a)
        {

            if (a is Dress) {
                if (accessories.Contains(Dress) == null)
                {
                    accessories.Add(a);
                }
            }
            if (a is Necklace)
            {
                if (accessories.Contains(Necklace) == null)
                {

                    accessories.Add(a);
                    if () { }
                    
                }
            }





            return false;
        }

        /// <summary>
        /// Copies this instance attributes to a new independant one
        /// </summary>
        /// <returns>A new Doll object with the same values of this instance</returns>
        public Doll Copy()
        {
            return new Doll(Name);
        }
    }
}