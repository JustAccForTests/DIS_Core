namespace CyberCore.Domain.Model;

public class EndPoint
{
    public Guid Id { get; set; }
    /// <summary>
    /// Имя точки доступа. Должно оставаться уникальным в рамках EndPointSection.
    /// </summary>
    public string Name { get; set; } = string.Empty;
    public string URL { get; set; } = string.Empty;
    public string Description {  get; set; } = string.Empty;
}
