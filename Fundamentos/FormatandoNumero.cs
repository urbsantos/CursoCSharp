using System;
using System.Globalization;
namespace CursoCSharp.Fundamentos {
    class FormatandoNumero {
        public static void Executar() {
            double valor = 15.175;
            // Uma casa decimal
            Console.WriteLine(valor.ToString("F1"));
            // Transforma na moeda corrente
            Console.WriteLine(valor.ToString("C"));
            // Multiplica por 100 e coloca % (Valor percentual)
            Console.WriteLine(valor.ToString("P"));
            // Um número com 2 casas decimais (Seria o mesmo que "F2")
            Console.WriteLine(valor.ToString("#.##"));

            CultureInfo cultura = new CultureInfo("pt-BR");
            //moeda corrente sem casa decimal
            Console.WriteLine(valor.ToString("C0", cultura));

            int inteiro = 256;
            // D10 -> vai completar com zeros à esquerda 
            //até atingir 10 casas (D = digito não significativo)
            Console.WriteLine(inteiro.ToString("D10"));
        }
    }
}
