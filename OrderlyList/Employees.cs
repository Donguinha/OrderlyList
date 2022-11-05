using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;

namespace OrderlyList {

    internal class Employee {

        public int Id { get; private set; }

        public string Nome { get; private set; }

        public Employee(int Id, string Nome) {

            this.Id = Id;
            this.Nome = Nome;
        }

        public override string ToString() {
            return $"ID: {Id}, Name: {Nome}";
        }
    }
}
