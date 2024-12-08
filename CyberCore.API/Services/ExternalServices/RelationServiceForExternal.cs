using CyberCore.Domain.Model;
using CyberCore.Infrastructrure.ExternalServices;
using CyberCore.Infrastructrure.Repositories;

namespace CyberCore.API.Services.ExternalServices;
/// <summary>
/// External relationship manager between agents.
/// Processes requests sent by a co-agent (represented by a proxy agent to the agent).
/// </summary>
public class RelationServiceForExternal : BaseService
{
    public RelationServiceForExternal(AgentRepository agentRepository, AgentExternalService agentExternalService)
        : base(agentRepository, agentExternalService) { }


    /// <summary>
    /// /// <summary>
    /// Starts the process of establishing a relationship between the agent and the co-agent, which will be represented by the proxy agent.
    /// A proxy agent is created with the status "Requires confirmation".
    /// </summary>
    /// <param name="proxyAgent"></param>
    /// <returns></returns>
    public async Task<ProxyAgent> RequestToEstablishInitialRelationship(ProxyAgent proxyAgent)
    {
        return new ProxyAgent();
    }
    public async Task<ProxyAgent> RequestToEstablishRelationship(ProxyAgent proxyAgent, Relation relation, Relation backRelation)
    {
        return proxyAgent;
    }
    public async Task<ProxyAgent> RequestToEstablishRelation(ProxyAgent proxyAgent, Relation relation)
    {
        return proxyAgent;
    }
    public async Task<ProxyAgent> ConfirmInitialRelationship(ProxyAgent proxyAgent)
    {
        return proxyAgent;
    }
    public async Task<ProxyAgent> ConfermRelation(ProxyAgent proxyAgent, Relation relation, Relation backRelation)
    {
        return proxyAgent;
    }
    public async Task<ProxyAgent> ConfirmRelation(ProxyAgent proxyAgent, Relation relation)
    {
        return proxyAgent;
    }

}
