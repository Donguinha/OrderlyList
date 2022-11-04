using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;

namespace OrderlyList {
    internal class Employee {
        public int Quantity { get; set; }
        public int Id { get; set; }
        public string Nome { get; set; }

        public Employee(int Quantity, int Id, string Nome) {
            this.Quantity = Quantity;
            this.Id = Id;
            this.Nome = Nome;
        }
        


        override public string ToString() {

            return $"#{Quantity + 1}- ID: {Id}, Name: {Nome}";
        }
    }
}
