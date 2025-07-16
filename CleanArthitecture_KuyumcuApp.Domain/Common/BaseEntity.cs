namespace CleanArthitecture_KuyumcuApp.Domain.Common;
public abstract class BaseEntity
{
    public Guid Id { get; private set; }
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

    protected BaseEntity()
    {
        Id = Guid.NewGuid(); // Veya CreateVersion7() de olabilir
    }
}
