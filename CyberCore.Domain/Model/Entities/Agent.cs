namespace CyberCore.Domain.Model;
/// <summary>
/// Коммуникационный агент.
/// Используется для представления объектов и субъектов в коммуникационном слое единой киберсреды.
/// </summary>
public class Agent : BaseAgent
{
    public List<ProxyAgent> ProxyAgents { get; set; } = new List<ProxyAgent>();

    public void AddProxyAgent(ProxyAgent proxyAgent)
    {
        if (ProxyAgents.FirstOrDefault(o => o.Id == proxyAgent.ObjectId) == null)
        {
            ProxyAgents.Add(proxyAgent);
        }
        else
        {
            throw new Exception("Such a proxy-agent already exists.");
        }
    }
}