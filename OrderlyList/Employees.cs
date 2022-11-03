using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderlyList {
    internal class Employees {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int Ordem { get; set; }

        public Employee(int Ordem, int Id, string Nome) {
            this.Ordem = Ordem;
            this.Id = Id;
            this.Nome = Nome;
        }
        List<Employee> employees = new List<Employee>();
        public void ReceberId(int emp, int idrecebido, string nomerecebido, int Quantos) {
            Console.Write("how many employees does the company have: ");
            emp = int.Parse(Console.ReadLine());

            for (int i = 0; i < Quantos; i++) {
                Console.Write("-----------------------------\n#{0}-Employee ID: ", (i + 1));
                idrecebido = int.Parse(Console.ReadLine());
                Console.Write("#{0}-Employee name: ", (i + 1));
                nomerecebido = Console.ReadLine();
                employees.Add(new Employee(i, idrecebido, nomerecebido));
            }
        }


        override public string ToString() {

            return $"#{Ordem + 1}- ID: {Id}, Name: {Nome}";
        }
    }
}
