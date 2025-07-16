using CleanArthitecture_KuyumcuApp.Domain.Common;

namespace CleanArthitecture_KuyumcuApp.Domain.Entities;
public class SaleItem : BaseEntity
{
    public Guid SaleId { get; set; }
    public Sale Sale { get; set; }

    public Guid ProductId { get; set; }
    public Product Product { get; set; }

    public decimal UnitPrice { get; set; }    // O anki fiyat
    public decimal Quantity { get; set; }     // Genelde gram olarak
    public decimal Total => UnitPrice * Quantity;
}
