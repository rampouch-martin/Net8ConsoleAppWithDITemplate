﻿using ConsoleAppWithDITemplate.Models.Entities.Interfaces;
using System.ComponentModel.DataAnnotations;

namespace ConsoleAppWithDITemplate.Models.Entities.Abstractions;

public class MyEntity : IMyEntity
{
    [Key]
    public int Id { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime? UpdatedAt { get; set; }
    public string CreatedBy { get; set; } = null!;
    public string? UpdatedBy { get; set ; }
}
