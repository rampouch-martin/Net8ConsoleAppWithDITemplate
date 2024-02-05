namespace ConsoleAppWithDITemplate.Models.Entities.Interfaces;

public interface IMyEntity
{
    int Id { get; set; }
    DateTime CreatedAt { get; set; }
    DateTime? UpdatedAt { get; set; }
    string CreatedBy { get; set; }
    string? UpdatedBy { get; set; }
}
