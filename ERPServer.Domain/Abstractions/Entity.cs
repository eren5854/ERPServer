namespace ERPServer.Domain.Abstractions;
public abstract class Entity
{
    public Guid Id { get; set; }
    protected Entity()
    {
        Id = Guid.NewGuid();
    }

    public bool IsDeleted { get; set; } = false;
    public bool IsActive {  get; set; } = true;
    public string CreatedBy { get; set; } = string.Empty;
    public DateTime CreatedDate { get; set; }
    public string? UpdatedBy { get; set; }
    public DateTime? UpdateDate { get; set; }
}
