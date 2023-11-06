using System;
using System.Collections.Generic;
using System.Text;

namespace Lab8POS
{
    public class Banca
    {
        /*public void EfectueazaPlata(ContBancar cont, decimal suma)
        {
            try
            {
                cont.ExtrageNumerar(suma);
                Console.WriteLine("Plata efectuata cu succes.");
            }
            catch (ArgumentException e)
            {
                Console.WriteLine($"Eroare: {e.Message}");
            }
            catch (InvalidOperationException e)
            {
                Console.WriteLine($"Eroare: {e.Message}");*/

            private Dictionary<Guid, ContBancar> conturi = new Dictionary<Guid, ContBancar>();
            private Dictionary<Guid, int> numarCarduriEmise = new Dictionary<Guid, int>();

            public Guid CreeazaCont()
            {
                ContBancar cont = new ContBancar();
                conturi.Add(cont.IdCont, cont);
                numarCarduriEmise.Add(cont.IdCont, 0);
                return cont.IdCont;
            }

            public void EmiteCard(Guid idCont)
            {
                if (!conturi.ContainsKey(idCont))
                {
                    throw new ArgumentException("Contul nu exista.");
                }

                if (numarCarduriEmise[idCont] >= 2)
                {
                    throw new InvalidOperationException("Au fost emise deja 2 carduri pentru acest cont.");
                }

                numarCarduriEmise[idCont]++;
                Console.WriteLine($"Card emis pentru contul cu ID-ul {idCont}.");
            }

            public void Plateste(decimal suma, Guid idCont)
            {
                if (!conturi.ContainsKey(idCont))
                {
                    throw new ArgumentException("Contul nu exista.");
                }

                ContBancar cont = conturi[idCont];

                try
                {
                    cont.ExtrageNumerar(suma);
                    Console.WriteLine($"Plata de {suma} lei efectuata cu succes din contul cu ID-ul {idCont}.");
                }
                catch (ArgumentException e)
                {
                    Console.WriteLine($"Eroare: {e.Message}");
                }
                catch (InvalidOperationException e)
                {
                    Console.WriteLine($"Eroare: {e.Message}");
                }
            }
        }
    }
