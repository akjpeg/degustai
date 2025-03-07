namespace DegustAi.Entities;

public class Photo
{
    public int Id { get; set; }
    public string ImagePath { get; set; }
    public DateTime UploadAt { get; set; }
    public int UserId { get; set; }
    public User User { get; set; }
    public Review Review { get; set; }
}