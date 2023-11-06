using System;
using System.Collections.Generic;
using System.Text;

namespace Lab8POS
{
    public class ContBancar
    {
        private Guid idCont;
        private decimal sold;

        public ContBancar()
        {
            idCont = Guid.NewGuid();
            sold = 0;
        }

        public Guid IdCont
        {
            get { return idCont; }
        }

        public decimal Sold
        {
            get { return sold; }
        }

        public void DepuneNumerar(decimal suma)
        {
            if (suma <= 0)
            {
                throw new ArgumentException("Suma depusa trebuie sa fie mai mare decat 0.");
            }

            sold += suma;
            Console.WriteLine($"Ati depus {suma} lei in contul cu ID-ul {idCont}.");
        }

        public void ExtrageNumerar(decimal suma)
        {
            if (suma <= 0)
            {
                throw new ArgumentException("Suma extrasa trebuie sa fie mai mare decat 0.");
            }

            if (suma > sold)
            {
                throw new InvalidOperationException("Fonduri insuficiente in cont.");
            }

            sold -= suma;
            Console.WriteLine($"Ati retras {suma} lei din contul cu ID-ul {idCont}.");
        }
    }
}
