using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework01
{
    class Program
    {
        public enum Sex
        {
            Feminin,
            Masculin
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Cati ani mai ai pana la pensie?");

            Console.WriteLine("Te rog, introdu data nasterii");

            Console.Write("ziua:");
            string stringZiua = Console.ReadLine();
            int ziua = int.Parse(stringZiua);

            Console.Write("luna:");
            string stringLuna = Console.ReadLine();
            int luna = int.Parse(stringLuna);

            Console.Write("anul:");
            string stringAnul = Console.ReadLine();
            int anul = int.Parse(stringAnul);

            Console.Write("sexul (M/F):");
            string stringSex = Console.ReadLine();

            int? sexUtilizator;
            string stringSexLitereMici = stringSex.ToLower();


            switch (stringSexLitereMici)
            {
                case "f":
                    sexUtilizator = (int?)Sex.Feminin;
                    break;
                case "m":
                    sexUtilizator = (int?)Sex.Masculin;
                    break;
                default:
                    sexUtilizator = null;
                    break;
            }


            DateTime dataNasterii = new DateTime(anul, luna, ziua);
            DateTime astazi = DateTime.Today;

            int varsta = 0;

            if (astazi.Year > dataNasterii.Year)
            {
                varsta = astazi.Year - dataNasterii.Year;
                if (dataNasterii.Month >= astazi.Month)
                {
                    varsta--;
                }
            }

            if (sexUtilizator != null && varsta > 0 && varsta < 120) {

            if (varsta > 63 && sexUtilizator.Value == (int?)Sex.Feminin)
            {
                Console.WriteLine("Esti deja pensionara");

            }
            else if (varsta < 63 && sexUtilizator.Value == (int?)Sex.Feminin)
            {
                Console.WriteLine($"Ai {63 - varsta} ani pana la pensie");
            }


            if (varsta > 65 && sexUtilizator.Value == (int?)Sex.Masculin)
            {
                Console.WriteLine("Esti deja pensionar");

            }
            else if (varsta < 65 && sexUtilizator.Value == (int?)Sex.Masculin)
            {
                Console.WriteLine($"Ai {65 - varsta} ani pana la pensie");
            }

            } else {
                Console.WriteLine("Date introduse incorect.");
            }

            Console.WriteLine("Apasa o tasta pentru iesire");
            Console.ReadKey();
        }
    }

}
