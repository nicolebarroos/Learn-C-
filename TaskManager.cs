using System;
using System.Collections.Generic;

public class TaskManager {
    private List<TaskItem> tasks;

    public TaskManager() {
        tasks = FileHandler.LoadTasks();
    }

    public void AddTask(string title, string description, string priority) {
        TaskItem task = new TaskItem(title, description, priority);
        tasks.Add(task);
        FileHandler.SaveTasks(tasks);
        Console.WriteLine("✅ Tarefa adicionada com sucesso!\n");
    }

    public void ListTasks() {
        if (tasks.Count == 0) {
            Console.WriteLine("📌 Nenhuma tarefa cadastrada.\n");
            return;
        }

        Console.WriteLine("\n📋 Lista de Tarefas:");
        foreach (var task in tasks) {
            task.DisplayTask();
        }
    }

    public void UpdateTask(string taskId, string newStatus) {
        TaskItem task = tasks.Find(t => t.Id == taskId);
        if (task != null) {
            task.Status = newStatus;
            FileHandler.SaveTasks(tasks);
            Console.WriteLine("✅ Status da tarefa atualizado!\n");
        } else {
            Console.WriteLine("❌ Tarefa não encontrada!\n");
        }
    }

    public void RemoveTask(string taskId) {
        tasks.RemoveAll(t => t.Id == taskId);
        FileHandler.SaveTasks(tasks);
        Console.WriteLine("✅ Tarefa removida com sucesso!\n");
    }
}