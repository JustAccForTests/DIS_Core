namespace CyberCore.Domain.Model;
/// <summary>
/// Конечные точки, представляющие методы, связанные с некоторым аспектом. Могут быть сгруппированы по контроллерам REST API.
/// </summary>
public class EndPointSection
{
    public Guid Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public List<EndPoint> EndPoints { get; set; } = [];

    public EndPoint? GetEndpointByName(string name)
    {
        return EndPoints.FirstOrDefault(o => o.Name == name);
    }
}
