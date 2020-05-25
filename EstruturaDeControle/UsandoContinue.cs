using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.EstruturaDeControle {
    class UsandoContinue {
        public static void Executar() {
            int internalo = 50;
            Console.WriteLine("Números pares entre 1 e {0}", internalo);

            for (int i = 1; i <= internalo; i++) {
                if (i % 2 == 1) {
                    continue;
                }

                Console.Write(i + " ");
            }
        }
    }
}
