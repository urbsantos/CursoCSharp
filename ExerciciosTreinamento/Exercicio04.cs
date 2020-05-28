using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ExerciciosTreinamento {

    //   Reimplementar o Exercício03 nos modelos de Orientação a objetos, tendo as seguintes premissas :
    //    .Deverá conter uma classe Person representando uma pessoa, com os seguintes atributos : Nome, Salario
    //   .Método para o reajuste do salário
    //   .Método para impressão do nome e salário reajustado

    class Person {
        public string Name { get; set; }
        public double Salary { get; set; }

        public Person(string name, double salary) {
            this.Name = name;
            this.Salary = salary;
        }
    }

    class Exercicio04 {

        private const double SALARY_50 = 1.50;
        private const double SALARY_30 = 1.30;

        public static void Executar() {
            for (int i = 0; i < 10; i++) {
                Console.Write("Insert name: ");
                var name = Console.ReadLine();

                Console.Write("Insert salary: ");
                var salary = Convert.ToDouble(Console.ReadLine());

                Person person = new Person(name, salary);

                var percent = salary <= 300 ? SALARY_50 : SALARY_30;
                person.Salary = ReadjustSalary(person.Salary, percent);

                Print(person);
            }

            Console.ReadKey();
        }

        public static double ReadjustSalary(double salary, double margim) {
            return salary * margim;
        }

        public static void Print(Person person) {
            Console.WriteLine("Name: " + person.Name);
            Console.WriteLine("Salary: " + person.Salary);
        }
    }
}

