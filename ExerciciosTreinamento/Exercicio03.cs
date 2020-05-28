using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ExerciciosTreinamento {

    //Faça um algoritmo que calcule e exiba o salário reajustado de dez funcionários de acordo com a seguinte regra: 
	//.Salário até 300, reajuste de 50%; 
	//.Salários maiores que 300, reajuste de 30%.
    
    class Exercicio03 {
        public static void Executar() {

            int i = 1;
            
            
            while (i <= 10) {
                Console.WriteLine("Digite seu salário: ", i);
                double.TryParse(Console.ReadLine(), out double salario);

                if (salario <= 300) {
                    double reajuste = 0.5;
                    Console.WriteLine("O funcionário {0} que tem o salário atual R${1}, terá o salário reajustado para R${2} com base no reajuste de {3}%",
                        i, salario, salario + (salario * reajuste), reajuste);
                } else {
                    double reajuste = 0.3;
                    Console.WriteLine("O funcionário {0} que tem o salário atual R${1}, terá o salário reajustado para R${2} com base no reajuste de {3}%",
                        i, salario, salario + (salario * reajuste), reajuste);
                }

                i++;
            }

        }
    }
}
