using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text.Json.Serialization;

namespace OrderlyList {

    class Program {

        static void Main(string[] args) {

            List<Employee> employees = ReceberDados();
            var employeesorder = Ordenar(employees);
            Printar(employeesorder);
        }

        static List<Employee> ReceberDados() {

            Console.Write("how many employees does the company have: ");
            int quantosemp = int.Parse(Console.ReadLine());

            var listarecebe = new List<Employee>();

            for (int i = 0; i < quantosemp; i++) {
                Console.Write("-----------------------------\n#{0}-Employee ID: ", (i + 1));
                int idfuncionario = int.Parse(Console.ReadLine());

                Console.Write("#{0}-Employee name: ", (i + 1));
                string nomefuncionario = Console.ReadLine();

                listarecebe.Add(new Employee(idfuncionario, nomefuncionario));
            }

            return listarecebe;
        }

        static List<Employee> Ordenar(List<Employee> employe) {

            var ordenados = new int[employe.Count];
            int x = 0;

            foreach (Employee cada in employe) {
                ordenados[x] = cada.Id;
                x++;
            }

            for (int i = 0; i < ordenados.Length - 1; i++) {
                for (int j = 0; j < ordenados.Length - 1; j++) {
                    if (ordenados[j] > ordenados[j + 1]) {
                        int troca = ordenados[j];
                        ordenados[j] = ordenados[j + 1];
                        ordenados[j + 1] = troca;
                    }
                }
            }

            var listaordenada = new List<Employee>();

            foreach (int Id in ordenados) {
                listaordenada.Add(employe.First(x => x.Id == Id));
            }

            return listaordenada;
        }

        static void Printar(List<Employee> employees) {

            foreach (Employee employee in employees) {
                Console.WriteLine(employee);
            }
        }
    }
}