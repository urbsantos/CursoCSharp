using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ExerciciosTreinamento {
    class Exercicio01 {
        public static void Executar() {
            
            string entrada;

            Console.Write("Digite o número desejado: ");
            entrada = Console.ReadLine();
            int.TryParse(entrada, out int numero);

            if ((numero % 2) == 0) {
                Console.WriteLine("O número {0} é par.", numero);
            } else {
                Console.WriteLine("O número {0} é ímpar.", numero);
            }
        }
    }
}
