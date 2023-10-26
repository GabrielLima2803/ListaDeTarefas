using System;
using System.Collections.Generic;

class Program
{
    static List<string> tasks = new List<string>();

    static void Main()
    {
        Console.WriteLine("Bem-vindo ao aplicativo de lista de tarefas!");

        while (true)
        {
            Console.WriteLine("\nEscolha uma opção:");
            Console.WriteLine("1. Adicionar tarefa");
            Console.WriteLine("2. Exibir tarefas");
            Console.WriteLine("3. Sair");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.Write("Digite a tarefa: ");
                    string task = Console.ReadLine();
                    tasks.Add(task);
                    break;

                case "2":
                    Console.WriteLine("Tarefas:");
                    for (int i = 0; i < tasks.Count; i++)
                    {
                        Console.WriteLine($"{i + 1}. {tasks[i]}");
                    }
                    break;

                case "3":
                    Console.WriteLine("Obrigado por usar o aplicativo de lista de tarefas. Adeus!");
                    return;

                default:
                    Console.WriteLine("Opção inválida. Tente novamente.");
                    break;
            }
        }
    }
}
