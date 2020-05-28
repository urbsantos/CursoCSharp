using System;
using System.Collections.Generic;
using System.Runtime.Serialization.Formatters;
using System.Text;

namespace CursoCSharp.ExerciciosTreinamento {

    // Faça um algoritmo que exiba quantas pessoas possuem mais de 18 anos. O algoritmo deverá ler a idade de 10 pessoas.

    class Exercicio02 {
        public static void Executar() {

            int i = 1;
            int maiorDeDezoito = 0;

            while(i <= 10) {
                Console.WriteLine("Digite a idade da pessoa {0}", i);
                int.TryParse(Console.ReadLine(), out int idade);

                if(idade >= 18) {
                    maiorDeDezoito++;
                }
                i++;
            }

            Console.WriteLine("Pessoa(as) com mais de 18 anos: {0}", maiorDeDezoito);

        }
    }
}
