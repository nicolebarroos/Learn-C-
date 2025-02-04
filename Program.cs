using System;

class Program {
    static void Main() {
        TaskManager manager = new TaskManager();
        
        while (true) {
            Console.WriteLine("\n===== Gerenciador de Tarefas =====");
            Console.WriteLine("1️⃣ Adicionar Tarefa");
            Console.WriteLine("2️⃣ Listar Tarefas");
            Console.WriteLine("3️⃣ Atualizar Status");
            Console.WriteLine("4️⃣ Remover Tarefa");
            Console.WriteLine("5️⃣ Sair");
            Console.Write("Escolha uma opção: ");

            string opcao = Console.ReadLine();

            switch (opcao) {
                case "1":
                    Console.Write("Título: ");
                    string title = Console.ReadLine();
                    Console.Write("Descrição: ");
                    string description = Console.ReadLine();
                    Console.Write("Prioridade (Baixa, Média, Alta): ");
                    string priority = Console.ReadLine();
                    manager.AddTask(title, description, priority);
                    break;

                case "2":
                    manager.ListTasks();
                    break;

                case "3":
                    Console.Write("ID da Tarefa: ");
                    string taskId = Console.ReadLine();
                    Console.Write("Novo Status (Pendente, Em Andamento, Concluída): ");
                    string status = Console.ReadLine();
                    manager.UpdateTask(taskId, status);
                    break;

                case "4":
                    Console.Write("ID da Tarefa a remover: ");
                    string removeId = Console.ReadLine();
                    manager.RemoveTask(removeId);
                    break;

                case "5":
                    Console.WriteLine("🚀 Saindo...");
                    return;

                default:
                    Console.WriteLine("❌ Opção inválida!");
                    break;
            }
        }
    }
}
