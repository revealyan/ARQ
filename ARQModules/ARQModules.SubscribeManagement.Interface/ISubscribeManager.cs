namespace ARQModules.SubscribeManagement.Interface
{
    public interface ISubscribeManager
    {
        bool SubscribeNews(string email);
        bool UnsubscribeNews(string token);
    }
}
