using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos {
    class NotacaoPonto {
        public static void Executar() {
            var saudacao = "olá".ToUpper().
                Insert(3, " World!").
                Replace("World", "Mundo!");
            Console.WriteLine(saudacao);

            Console.WriteLine("Teste".Length);

            string valorImportante = null;
            //? é uma forma de segurança. Inpede que o objeto seja acessado
            //caso ele seja nulo.
            Console.WriteLine(valorImportante?.Length);
        }
    }
}
