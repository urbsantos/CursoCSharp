using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos {
    class MetodosEstaticos {
        
        public class CalculadoraEstatica {
            // Método pertence a classe (ou método static), por isso a palavra static. 
            //Com isso, ele pode ser acessado sem precisar criar uma instância
            public static int Multiplicar(int a, int b) {
                return a * b;
            }
            
            //Esse método só é acessível através da instância porque não tem a
            // palavra static
            public int Somar (int a, int b) {
                return a + b;
            }
        }
        
        public static void Executar() {
            var resultado = CalculadoraEstatica.Multiplicar(2, 2);
            Console.WriteLine("Resultado: {0}", resultado);

            CalculadoraEstatica calc = new CalculadoraEstatica();
            Console.WriteLine(calc.Somar(2 , 2));
        }
    }
}
