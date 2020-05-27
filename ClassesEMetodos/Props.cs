using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos {

    public class CarroOpcional {
        double desconto = 0.1;

        string nome;
        public string Nome {
            get {
                return "Opcional: " + nome;
            }
            set {
                nome = value;
            }
        }

        //Propriedade autoimplementada
        public double Preco { get; set; }

        //Somente leitura
        public double PrecoComDesconto {
            get => Preco - (desconto * Preco); //Lambda
        }

        public CarroOpcional() {

        }

        public CarroOpcional(string nome, double preco) {
            //Recebi os parâmetros nome e preco e setei dentro das propriedades
            //Nome e Preco
            Nome = nome;
            Preco = preco;
        }
    }

    class Props {

        public static void Executar() {
            var op1 = new CarroOpcional("Ar Condicionado", 3499.9);

            var op2 = new CarroOpcional();
            op2.Nome = "Direção Elétrica";
            op2.Preco = 2349.9;

            Console.WriteLine("Preço com desconto: {0}", op1.PrecoComDesconto);
            Console.WriteLine(op1.Nome);
            Console.WriteLine(op1.Preco);

            Console.WriteLine("Preço com desconto: {0}", op2.PrecoComDesconto);
            Console.WriteLine(op2.Nome);
            Console.WriteLine(op2.Preco);
        }
    }
}
