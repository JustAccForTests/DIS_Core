namespace CyberCore.Domain.Model;
/// <summary>
/// Прокси-агент, через который агенты взаимодейтсвуют с ассоциированными ко-агентами.
/// Содержит всю необъодимую информацию об отношении ко-агнета, данным прокси-агентом к агенту.
/// </summary>
public class ProxyAgent : BaseAgent
{
    /// <summary>
    /// Глобально-уникальный идентификатор агента (ко-агента), представленного прокси-агентом.
    /// </summary>
    public Guid ObjectId { get; set; }
    /// <summary>
    /// Флаг, указывающий, что между агентом и ко-агентом установлена двусторонняя связь.
    /// </summary>
    public bool RelationshipsEstablished { get; set; } = false;
    /// <summary>
    /// Тип прокси-агента:
    /// Proxy-Agent type:
    /// UnconnectedAgentm - агент, с которым не установлено соединение. В общем случае может быть и не зарегистрирован в киберсреде. Некий "симулякр".
    /// Bookmark - агент добавлен в закладки. При добавлении в закладки агент, представленный прокси-агентом, не уведомляется об этом событии.
    /// Observable - агент, для которого текущий агент является подписчиком (двусторонняя связь, так как агент извещает своего подписчика об событиях, прописанных в лицензии).
    /// CoAgent - агент, с которым установлена ​​двусторонняя связь.
    /// </summary>
    public ProxyAgentType ProxyAgentType { get; set; }
    /// <summary>
    /// Список отношений прокси-агента (ко-агента, представленного проски-агентом) к агенту.
    /// </summary>
    public List<Relation> Relations { get; set; } = [];
    /// <summary>
    /// Список лицензий, назначенных ко-агентом, представленным прокси-агентом, агенту.
    /// </summary>
    public List<License> GrantedToAgentLicenses { get; set; } = [];
    /// <summary>
    /// Список лицензий, назначенных агентом ко-агенту, представленному проски-агентом.
    /// Лицензии используются в управлении правами доступом ко-агента к ресурсам агента.
    /// </summary>
    public List<License> GrantedToProxyAgentLicenses { get; set; } = [];

    public Guid AgentId { get; set; }
    public Agent Agent { get; set; } = null!;

    public void AddRelation(Relation relation)
    {
        if (Relations.FirstOrDefault((o => o.TypeCode == relation.TypeCode 
                    && o.State != RelationState.End 
                    && o.State != RelationState.Declined)) == null)
        {
            Relations.Add(relation);
        }
        else
        {
            throw new Exception("This type of relationship with the status \"current\" or awaiting confirmation of such status already exists.");
        }
    }
}