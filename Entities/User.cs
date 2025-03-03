using System;

public class User
{
    
    public int Id { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
    public DateTime CreatedAt { get; set; }

  
 
    public User(int id, string name, string email, string password)
    {
        Id = id;
        Name = name;
        Email = email;
        Password = password;
        CreatedAt = DateTime.Now;
    }

 
    public void ShowInfo()
    {
        Console.WriteLine($"ID: {Id}");
        Console.WriteLine($"Name: {name}");
        Console.WriteLine($"Email: {Email}");
        Console.WriteLine($"CreatedAt: {CreatedAt}");
    }
}