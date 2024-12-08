namespace CyberCore.Domain.Model;
/// <summary>
/// Лицензия на выполнение разрешенных действий в отношении агента или ко-агента, представляемого прокси-агентом.
/// </summary>
public class License
{
    Guid Id { get; set; }
    public string LicenseName { get; set; } = string.Empty;
    public string LicenseCode { get; set; } = string.Empty;

    public Guid ProxyAgentId { get; set; }
    public ProxyAgent ProxyAgent { get; set; } = null!;
}
