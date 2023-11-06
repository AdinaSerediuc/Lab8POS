using System;
using System.Collections.Generic;
using System.Text;

namespace Lab8POS
{
    class Program
    {
        static void Main(string[] args)
        {
            Banca banca = new Banca();
            Guid idCont = banca.CreeazaCont();
            banca.EmiteCard(idCont);

            Card card = new Card();
            card.IntroduCard(idCont);

            decimal sumaPlata = 500;

            POS pos = new POS();
            pos.Plateste(sumaPlata, card, banca);

            sumaPlata = 700;
            pos.Plateste(sumaPlata, card, banca); // Va arunca o exceptie pentru ca cardul a fost extras

            Console.ReadLine();
        }
    }
}