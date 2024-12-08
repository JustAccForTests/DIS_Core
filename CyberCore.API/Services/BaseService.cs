using CyberCore.Infrastructrure.ExternalServices;
using CyberCore.Infrastructrure.Repositories;

namespace CyberCore.API.Services
{
    public class BaseService
    {
        protected AgentRepository _agentRepository;
        protected AgentExternalService _agentExternalService;
        public BaseService(AgentRepository agentRepository, AgentExternalService agentExternalService)
        {
            _agentRepository = agentRepository ?? throw new ArgumentNullException(nameof(agentRepository));
            _agentExternalService = agentExternalService ?? throw new ArgumentException(nameof(agentExternalService));
        }
    }
}
