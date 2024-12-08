namespace CyberCore.Domain.Model;
/// <summary>
/// Отношение прокси-агента (ко-агента, представленного проски-агентом) к агенту.
/// </summary>
public class Relation
{
    public Guid Id { get; set; }
    public string TypeName { get; set; } = string.Empty;
    public int TypeCode { get; set; }
    public RelationState State { get; set; }
    public string Description { get; set; } = string.Empty;
    public DateTime? CreationTime { get; set; }
    public DateTime? RequestedTime { get; set; }
    public DateTime? BeginActualTime { get; set; }
    public DateTime? EndActualTime { get; set; }
}
