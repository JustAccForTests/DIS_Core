using CyberCore.Domain.Model;
using CyberCore.Infrastructrure.ExternalServices;
using CyberCore.Infrastructrure.Repositories;

namespace CyberCore.API.Services.InternalServices;

public class EndPointServiceForInternal : BaseService
{
    public EndPointServiceForInternal(AgentRepository agentRepository, AgentExternalService agentExternalService)
        : base(agentRepository, agentExternalService) { }
    /// <summary>
    /// Выполняет обновление конечных точек у всех коагентов.
    /// </summary>
    /// <param name="agent"></param>
    /// <returns></returns>
    public async Task<bool> UpdateEndpoints(Agent agent)
    {
        return true;
    }
    public async Task<bool> UpdateEndpointSection(Agent agent, EndPointSection endPointSection)
    {
        return true;
    }
    public async Task<bool> UpdateEndpoint(Agent agent, EndPointSection endPointSection, EndPoint endPoint)
    {
        return true;
    }
}
