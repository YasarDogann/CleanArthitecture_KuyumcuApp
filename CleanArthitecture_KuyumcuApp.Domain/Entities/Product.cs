using CleanArthitecture_KuyumcuApp.Domain.Common;

namespace CleanArthitecture_KuyumcuApp.Domain.Entities;
public class Product : BaseEntity
{
    public string Name { get; set; }     // Ürün adı
    public decimal Price { get; set; }   // Satış fiyatı
    public decimal Weight { get; set; }  // Gramaj
    public string MetalType { get; set; } // Altın/Gümüş
    public string Carat { get; set; }     // Ayar (22 Ayar vs.)

    public Guid CategoryId { get; set; }         // Foreign Key (FK)
    public Category Category { get; set; }       // Navigation Property
}
