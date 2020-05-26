using System;

namespace CursoCSharp.ClassesEMetodos {
    class Pessoa {

        public string Nome;
        public int Idade;

        public string Apresentar() {
            
            if (Nome != "" || Idade != 0) {
                return string.Format(
                $"Olá! Me chamo {Nome} e tenho {Idade} anos.");
            } else {
                return string.Format("Dados inválidos");
                
            }
        }

        public void ApresentarNoConsole() {
            Console.WriteLine(Apresentar());
        }

        public void Zerar() {
            Nome = "";
            Idade = 0;
        }
    }
}
