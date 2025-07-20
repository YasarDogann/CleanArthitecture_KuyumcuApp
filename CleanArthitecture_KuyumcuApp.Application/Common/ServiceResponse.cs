namespace CleanArthitecture_KuyumcuApp.Application.Common;
public class ServiceResponse
{
    public bool Success { get; set; }      // İşlem başarılı mı?
    public string Message { get; set; }    // Bilgilendirici mesaj

    // Hızlı cevap üretmek için static yardımcılar
    public static ServiceResponse Ok(string message = "İşlem başarılı.")
        => new ServiceResponse { Success = true, Message = message };

    public static ServiceResponse Fail(string message = "Bir hata oluştu.")
        => new ServiceResponse { Success = false, Message = message };
}
