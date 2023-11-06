using System;
using System.Collections.Generic;
using System.Text;

namespace Lab8POS
{
    public class Card
    {
        private Guid idCont;

        public void IntroduCard(Guid idCont)
        {
            this.idCont = idCont;
            Console.WriteLine($"Cardul a fost introdus pentru contul cu ID-ul {idCont}.");
        }

        public Guid GetCardData()
        {
            return idCont;
        }

        public void ExtrageCard()
        {
            Console.WriteLine($"Cardul a fost extras pentru contul cu ID-ul {idCont}.");
            idCont = Guid.Empty; // "Golim" id-ul pentru a marca cardul ca extras
        }
    }
}
