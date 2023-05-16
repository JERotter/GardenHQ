using System;
namespace GardenHQ.Data.Entities;

public class Comment : BaseEntity
{
    public string? CommentBody { get; set; }
}