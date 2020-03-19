using System;
using System.Collections.Generic;
using System.Globalization;

namespace ListaFuncionarios
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Quantos funcionários serão registrados? ");
            int n = int.Parse(Console.ReadLine());
            List<Funcionario> lista = new List<Funcionario>();

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine();
                Console.WriteLine($"Funcionário  #{i}:");
                Console.WriteLine("ID: ");
                int id = int.Parse(Console.ReadLine());
                Console.WriteLine("Nome: ");
                string nome = Console.ReadLine();
                Console.WriteLine("Salário: ");
                double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                lista.Add(new Funcionario(id, nome, salario));
            }

            Console.WriteLine("Insira  o ID do funcionário que ira receber aumento: ");
            int funcionarioID = int.Parse(Console.ReadLine());

            Funcionario temp = lista.Find(x => x.ID == funcionarioID);
            if(temp != null)
            {
                Console.WriteLine("Insira a porcentagem do aumento: ");
                double aumento = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                temp.AumentarSalario(aumento);
            }
            else
            {
                Console.WriteLine("Esse ID não existe");
            }

            Console.WriteLine("-----------------");
            Console.WriteLine("Lista atualizada dos funcionários: ");
            foreach(Funcionario obj in lista)
            {
                Console.WriteLine(obj);
            }

        }
    }
}
