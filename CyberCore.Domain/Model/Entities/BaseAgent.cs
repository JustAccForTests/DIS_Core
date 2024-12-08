namespace CyberCore.Domain.Model;
/// <summary>
/// Базовый класс для агентов и прокси-агентов.
/// </summary>
public class BaseAgent
{
    public Guid Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public ContactInfo ContactInfo { get; set; } =new ContactInfo();
    public DateTime Created { get; set; }
    public DateTime Updated { get; set; }

    public List<EndPointSection> EndPointSections { get; set; } = [];

    public EndPointSection? GetEndPointSectionByName(string sectionName)
    {
        return EndPointSections?.FirstOrDefault(s => s.Name == sectionName);
    }
    public EndPoint? GetEndPointByName(string sectionName, string endPointName)
    {
        return EndPointSections?.FirstOrDefault(s => s.Name == sectionName)?.EndPoints?.FirstOrDefault(o => o.Name == endPointName);
    }

    public EndPoint? InitialRequestEndPoint { get => GetEndPointByName("Initial EndPoints", "Initial Request"); }
    public EndPoint? UpdateEndPointsEndPoint { get => GetEndPointByName("Update EndPoints", "Update EndPoint"); }
}
