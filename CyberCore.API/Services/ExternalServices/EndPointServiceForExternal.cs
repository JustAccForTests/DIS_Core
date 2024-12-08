using CyberCore.Domain.Model;
using CyberCore.Infrastructrure.ExternalServices;
using CyberCore.Infrastructrure.Repositories;

namespace CyberCore.API.Services.ExternalServices;

public class EndPointServiceForExternal : BaseService
{
    public EndPointServiceForExternal(AgentRepository agentRepository, AgentExternalService agentExternalService)
        : base(agentRepository, agentExternalService) { }

    public async Task<bool> UpdateEndpoints(ProxyAgent proxyAgent)
    {
        return true;
    }
    public async Task<bool> UpdateEndpointSection(ProxyAgent proxyAgent, EndPointSection endPointSection)
    {
        return true;
    }
    public async Task<bool> UpdateEndpoint(ProxyAgent proxyAgent, EndPointSection endPointSection, EndPoint end)
    {
        return true;
    }
}
