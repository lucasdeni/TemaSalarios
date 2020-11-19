using System;
using System.Globalization;
using System.Collections.Generic;

namespace TemaSalarios
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Salario> funcionario = new List<Salario>(); // Lista dos funcionários
            Console.Write("Quantos funcionários serão registrados? "); // Entrada do número de funcionários
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++) // Repetição para cada funcionário
            {
                Console.WriteLine("Funcionário #" + i + ":");
                Console.Write("Id: "); // Id do usuário
                int id = int.Parse(Console.ReadLine());
                Console.Write("Nome: "); // Nome do usuário
                string nome = Console.ReadLine();
                Console.Write("Salário: "); // Salário do usuário
                double salario = double.Parse(Console.ReadLine());
                Console.WriteLine("--------------------------------------------");
                Salario s = new Salario(id, nome, salario);
                funcionario.Add(s);
            }
            Console.Write("\nId do funcionário que receberá aumento: "); // Verá qual funcionário irá receber aumento
            int Id = int.Parse(Console.ReadLine());
            Salario f = funcionario.Find(x => x.ID == Id); // Procurar o funcionário na lista
            if (f != null) // Ver se o funcionário existe
            {
                Console.Write("Porcentagem de aumento de salário: "); // Realizar o aumento de salário
                f.aumentarSalario(double.Parse(Console.ReadLine())); 
            }
            else // Funcionario inexistente
            {
                Console.WriteLine("Este funcionário não existe!");
            }
            Console.WriteLine("\nLista atualizada dos funcionários:"); // Lista atualizada
            foreach (Salario obj in funcionario)
            {
                Console.WriteLine(obj.ID.ToString("D3") + ", " + obj.Nome + ", " + obj.Pagamento.ToString("F2", CultureInfo.InvariantCulture));
            }
            Console.ReadKey();
        }
    }
}
