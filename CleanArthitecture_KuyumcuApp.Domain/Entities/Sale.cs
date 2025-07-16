using CleanArthitecture_KuyumcuApp.Domain.Common;

namespace CleanArthitecture_KuyumcuApp.Domain.Entities;
public class Sale : BaseEntity              // Kuyumcuda 1 satış işlemi olur (SALE)
{
    public Guid CustomerId { get; set; }
    public Customer Customer { get; set; }

    public decimal TotalAmount { get; set; }
    public bool IsPaidInInstallments { get; set; } // Taksitli mi?

    public ICollection<SaleItem> Items { get; set; } = new List<SaleItem>();  // 1 satış'da birden fazla ürün olabilir (SALEITEM)
}
