using System;
namespace GardenHQ.Data.Entities;

public class GardenTask : BaseEntity
{
	public string Title { get; set; }
	public string? Description{ get; set; }
	public List<Comment>? Comments { get; set; }
	public Priority priority { get; set; }
	public Guid AssignedTo { get; set; }
	public string? AssignedName { get; set; }
	public bool Completed { get; set; }
}