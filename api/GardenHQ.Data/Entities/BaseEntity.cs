using System;
using System.ComponentModel.DataAnnotations;

namespace GardenHQ.Data.Entities;

public abstract class BaseEntity
{
    public Guid Id { get; set; }
    private DateTime? createdOn;

    public Guid CreatedBy { get; set; }

    [DataType(DataType.DateTime)]
    public DateTime? CreatedOn
    {
        get { return createdOn ?? DateTime.UtcNow; }
        set { createdOn = value; }
    }

    private DateTime? lastUpdated;

    public Guid LastUpdatedBy { get; set; }

    [DataType(DataType.DateTime)]
    public DateTime? LastUpdated
    {
        get { return lastUpdated ?? DateTime.UtcNow; }
        set { lastUpdated = value; }
    }

    public void Create(Guid author)
    {
        this.CreatedBy = author;
        this.CreatedOn = DateTime.UtcNow;
        this.LastUpdatedBy = author;
        this.LastUpdated = DateTime.UtcNow;
    }

    public void Update(Guid author)
    {
        this.LastUpdatedBy = author;
        this.LastUpdated = DateTime.UtcNow;
    }
}