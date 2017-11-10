using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculatrice
{
    class Program
    {
        static void Main(string[] args)
        {
            double dblVal1, dblVal2, dblRep = 0;
            bool isOpInCorrect = true;

            Console.WriteLine("Calculatrice");
            Console.WriteLine("------------");

            // Saisie des opérandes, avec vérification de ces dernières
            Console.Write("Saisir la 1ère valeur : ");
            while (!double.TryParse(Console.ReadLine(), out dblVal1))
            {
                Console.Write("Saisir a nouveau la 1ère valeur : ");
            }

            Console.Write("Saisir la 2ème valeur : ");
            while (!double.TryParse(Console.ReadLine(), out dblVal2))
            {
                Console.Write("Saisir a nouveau la 2ème valeur : ");
            }

            // Siaisie du choix de l'opérateur
            Console.Write("Opération a choix [+ - * / ^] : ");
            while (isOpInCorrect)
            {
                string strOp = Console.ReadLine();
                isOpInCorrect = false;
                switch (strOp)
                {
                    default:
                        Console.WriteLine("Opération non reconnue par le système");
                        Console.Write("Veulliez saisir à nouveau l'opérateur [+ - * / ^] : ");
                        isOpInCorrect = true;
                        break;
                    case "+":
                        dblRep = Outils.Addition(dblVal1, dblVal2);
                        Console.Write("La répose : " + dblRep.ToString());
                        break;
                    case "-":
                        dblRep = Outils.Soustraction(dblVal1, dblVal2);
                        Console.Write("La répose : " + dblRep.ToString());
                        break;
                    case "*":
                        dblRep = 0;
                        break;
                    case "/":
                        dblRep = 0;
                        break;
                    case "^":
                        dblRep = 0;
                        break;

                }
            }

            Console.ReadKey();
        }
    }
}
