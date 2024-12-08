using CyberCore.Domain.Model;
using CyberCore.Infrastructrure.ExternalServices;
using CyberCore.Infrastructrure.Repositories;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.VisualBasic;
using System.Buffers.Text;
using System.Net;

namespace CyberCore.API.Services.InternalServices;
/// <summary>
/// Управляет отношениями между агентами на базе запросов, инициируемых текущим микроприложением (отсюда - Internal).
/// </summary>
public class RelationServiceForInternal : BaseService
{
    public RelationServiceForInternal(AgentRepository agentRepository, AgentExternalService agentExternalService) 
        : base(agentRepository, agentExternalService) { }

    /// <summary>
    /// Инициирует процесс установления отношений между агентами, которые не имели до этого каки-либо отношений.
    /// В роли аргументов выступают:
    /// 1) endPoint - конечная точка, содержащая в качестве параметра идентификатор агента, с которым устанавливается начальное отношение.
    /// Данная конечная точка ассоциирована с методом, который возвращает информацию о коагенте и коллекцию конечных точек, отвечающих за коммуникацию.
    /// 2) relation - объект "отношение", который содержит информацию о том, кем является коагент по отношению к агенту, инициирующему установление отношений.
    /// 3) backRelation - объект "обратное отношение", который содержит информацию о том, кем является агент по отношению к коагенту.
    /// Алгоритм:
    /// Шаг 1. Выполняется вызов удаленного метода по endPoint для получения информацию о коагенте, включая конечные точки, отвечающие за коммуникацию внутри гловальной киберсреды.
    /// Шаг 2. На базе полученной информации создается прокси-агент, представлеющий коагента.
    /// Шаг 3. Выполняется запрос на установление отношения с коагентом, для чего используется информация из коллекции конечных точек, полученных на первом шаге.
    /// </summary>
    /// <param name="endPoint"></param>
    /// <param name="relation"></param>
    /// <param name="backRelation"></param>
    /// <returns></returns>
    public async Task<ProxyAgent> RequestToEstablishInitialRelationship(string endPoint, Relation relation, Relation backRelation)
    {
        //Получение информации об агенте, с которым устанавливаются отношения, включая информацию об EndPoints
        return new ProxyAgent();
    }
    /// <summary>
    /// Добавляет информацию о коагенте в закладки без установления отношений и без информирования о данном процессе коагента.
    /// Шаг 1. Выполняется запрос по адресу endPoint для получения информации о коагенте, которая будет добавлена в закладки, включая информацию о конечных точках.
    /// Шаг 2. Базируясь на полученной информации, создается прокси-агент со статусом "Bookmark". В дальнейшем на базе данной инфомации может быть установлено отношение с коагентом.
    /// </summary>
    /// <param name="endPoint"></param>
    /// <returns></returns>
    public async Task<ProxyAgent> AddToBookmarks(string endPoint)
    {
        return new ProxyAgent();
    }
    /// <summary>
    /// Выполняется запрос на установление отношений на основе информации, хранящейся в закладках.
    /// Для установления отношения используется метод RequestToEstablishInitialRelationship.
    /// </summary>
    /// <param name="proxyAgent"></param>
    /// <returns></returns>
    public async Task<bool> RequestToEstablishInitialRelationFromBookmark(ProxyAgent proxyAgent, Relation relation, Relation backRelation)
    {
        return true;
    }
    /// <summary>
    /// Запрос на установление сязи заданного типа.
    /// </summary>
    /// <param name="proxyAgent"></param>
    /// <param name="relation"></param>
    /// <param name="backRelation"></param>
    /// <returns></returns>
    public async Task<ProxyAgent> RequestToEstablishRelation(ProxyAgent proxyAgent, Relation relation, Relation backRelation)
    {
        return proxyAgent;
    }
    /// <summary>
    /// A request to establish a relationship of a certain type.
    /// </summary>
    /// <param name="proxyAgent"></param>
    /// <param name="relation"></param>
    /// <returns></returns>
    public async Task<ProxyAgent> RequestToEstablishRelation(ProxyAgent proxyAgent, Relation relation)
    {
        return proxyAgent;
    }
    /// <summary>
    /// Метод, подтверждающий установление отношений
    /// </summary>
    /// <param name="proxyAgent"></param>
    /// <returns></returns>
    public async Task<ProxyAgent> ConfirmInitialRelationship(ProxyAgent proxyAgent)
    {
        return proxyAgent;
    }
    /// <summary>
    /// Мпетод, подвтерждающий установление отношения определенного типа
    /// </summary>
    /// <param name="proxyAgent"></param>
    /// <param name="relation"></param>
    /// <param name="backRelation"></param>
    /// <returns></returns>
    public async Task<ProxyAgent> ConfermRelation(ProxyAgent proxyAgent, Relation relation, Relation backRelation)
    {
        return proxyAgent;
    }
    public async Task<ProxyAgent> ConfirmRelation(ProxyAgent proxyAgent, Relation relation)
    {
        return proxyAgent;
    }
}
