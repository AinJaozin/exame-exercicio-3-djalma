using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exame_exercicio_3_djalma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dentre as três figuras, escolha uma para ser calculada a àrea \n \n \t 1 Triângulo: 2 Losango : 3 Trapézio");

            int numero = Convert.ToInt32(Console.ReadLine());
            string figura = null;


            switch (numero)
            {
                case 1: figura = "Triângulo"; break;
                case 2: figura = "Losango"; break;
                case 3: figura = "Trapézio"; break;

            }

            if (figura == "Triângulo")
            {
                Console.WriteLine("Digite quanto vale a Base:");
                double baset = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Digite quanto vale a Altura:");
                double altura = Convert.ToDouble(Console.ReadLine());

                double area = (baset * altura) / 2;

                Console.WriteLine($"A área do {figura} é de {area} cm2");

            }
            else if (figura == "Losango")
            {
                Console.WriteLine("Digite o valor da Diagonal maior:");
                double diagmaior = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Digite o valor da Diagonal menor:");
                double diaglmenor = Convert.ToDouble(Console.ReadLine());

                double area = (diagmaior * diaglmenor) / 2;

                Console.WriteLine($"A área do {figura} é de {area} cm2");

            }

            if (figura == "Trapézio")
            {
                Console.WriteLine("Digite o valor da Base maior:");
                double basemaior = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Digite o valor da Base maior:");
                double basemenor = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Digite o valor da Altura:");
                double altura = Convert.ToDouble(Console.ReadLine());

                double area = ((basemaior + basemenor) * altura) / 2;
                Console.WriteLine($"A área do {figura} é de {area} cm2");
            }

            Console.WriteLine("\n\t\t Vamos outra vez, porem com outra figura?\n\n Dentre as três figuras, escolha uma para ser calculada a àrea \n \n \t 1 Triângulo: 2 Losango : 3 Trapézio\n");

            switch (numero)
            {
                case 1: figura = "Triângulo"; break;
                case 2: figura = "Losango"; break;
                case 3: figura = "Trapézio"; break;

            }

            if (figura == "Triângulo")
            {
                Console.WriteLine("Digite quanto vale a Base:");
                double baset = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Digite quanto vale a Altura:");
                double altura = Convert.ToDouble(Console.ReadLine());

                double area = (baset * altura) / 2;

                Console.WriteLine($"A área do {figura} é de {area} cm2");

            }
            else if (figura == "Losango")
            {
                Console.WriteLine("Digite o valor da Diagonal maior:");
                double diagmaior = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Digite o valor da Diagonal menor:");
                double diaglmenor = Convert.ToDouble(Console.ReadLine());

                double area = (diagmaior * diaglmenor) / 2;

                Console.WriteLine($"A área do {figura} é de {area} cm2");

            }

            if (figura == "Trapézio")
            {
                Console.WriteLine("Digite o valor da Base maior:");
                double basemaior = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Digite o valor da Base maior:");
                double basemenor = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Digite o valor da Altura:");
                double altura = Convert.ToDouble(Console.ReadLine());

                double area = ((basemaior + basemenor) * altura) / 2;
                Console.WriteLine($"A área do {figura} é de {area} cm2");
            }
        }
    }
}
