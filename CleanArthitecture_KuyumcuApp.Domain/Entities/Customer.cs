using CleanArthitecture_KuyumcuApp.Domain.Common;

namespace CleanArthitecture_KuyumcuApp.Domain.Entities;
public class Customer : BaseEntity
{
    public string FullName { get; set; }
    public string PhoneNumber { get; set; }

    public string? Email { get; set; }
    public DateTime? BirthDate { get; set; }

    public bool IsPremium { get; set; } = false; // Sadakat müşterisi mi? (Kampanya tanımlamalarında kullanıcam)
    public string? Notes { get; set; }          // Müşterileri not alabilmeek adına oluşturdum. 
}
