using System;

public class TaskItem {
    public string Id { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public string Priority { get; set; } //Baixa, Média, Alta
    public string Status { get; set; } //Pendente, Em Andamento, Concluída
    public DateTime CreatedAt { get; set; }

    public TaskItem(string title, string description, string priority) {
        Id = Guid.NewGuid().ToString(); //Gera um ID único
        Title = title;
        Description = description;
        Priority = priority;
        Status = "Pendente";
        CreatedAt = DateTime.Now;
    }

    public void DisplayTask() {
        Console.WriteLine($"[{Status}] {Title} - {Priority}");
        Console.WriteLine($"Descrição: {Description}");
        Console.WriteLine($"Criada em: {CreatedAt}\n");
    }
}
