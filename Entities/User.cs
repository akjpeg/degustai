using System;

public class User(int id, string name, string email, string password)
{

    public int Id { get; set; } = id;
    public string Name { get; set; } = name;
    public string Email { get; set; } = email;
    public string Password { get; set; } = password;
    public DateTime CreatedAt { get; set; } = DateTime.Now;

    public void ShowInfo()
    {
        Console.WriteLine($"ID: {Id}");
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Email: {Email}");
        Console.WriteLine($"CreatedAt: {CreatedAt}");
    }
}