using System;
using System.Collections.Generic;
using System.Text;

namespace Lab8POS
{
    public class POS
    {
        public void Plateste(decimal suma, Card card, Banca banca)
        {
            card.IntroduCard(card.GetCardData());

            try
            {
                banca.Plateste(suma, card.GetCardData());
            }
            catch
            {
                // Extragem cardul in orice caz
                card.ExtrageCard();
            }
        }
    }
}
