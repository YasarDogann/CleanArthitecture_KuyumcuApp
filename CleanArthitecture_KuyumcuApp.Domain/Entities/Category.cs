using CleanArthitecture_KuyumcuApp.Domain.Common;

namespace CleanArthitecture_KuyumcuApp.Domain.Entities;
public class Category : BaseEntity
{
    public string Name { get; set; } // Örn: Bilezik, Kolye
    public string? Description { get; set; } // Açıklama (opsiyonel)

    // İleri seviye: ICollection<Product> Products { get; set; }
}
