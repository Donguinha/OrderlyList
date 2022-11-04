using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text.Json.Serialization;

namespace OrderlyList {


    class Program {
        static void Main(string[] args) {

            List<Employee> employees = DataReceive();

            var employeesorder = Ordenar(employees);
            Printar(employeesorder);


        }
        public static List<Employee> DataReceive() {

            Console.Write("how many employees does the company have: ");
            int Quantity = int.Parse(Console.ReadLine());

            var list = new List<Employee>();


            for (int i = 0; i < Quantity; i++) {

                Console.Write("-----------------------------\n#{0}-Employee ID: ", (i + 1));
                int IdReceived = int.Parse(Console.ReadLine());
                Console.Write("#{0}-Employee name: ", (i + 1));
                string NameReceived = Console.ReadLine();
                list.Add(new Employee(Quantity, IdReceived, NameReceived));

            }
            return list;
        }
        public static List<Employee> Ordenar(List<Employee> employees) {

            var ordenados = new int[employees.Count];


            foreach (Employee cada in employees) {
                for (int i = 0; i < ordenados.Length; i++) {
                    if (cada.Id  <   ordenados[i]  || ordenados[i] == 0 ) {


                        if (ordenados[i] != 0) {
                            ordenados[i + 1] = ordenados[i];
                        }

                        ordenados[i] = cada.Id;
                        break;
                    }
                }
            }
            var listanova = new List<Employee>();
            foreach (int Id in ordenados) {
                listanova.Add(employees.First(x => x.Id == Id));
            }

            return listanova;

        }
        public static void Printar(List<Employee> employees) {

            foreach (Employee cada in employees) {

                Console.WriteLine(cada);

            }


        }
    }
}