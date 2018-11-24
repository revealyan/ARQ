using ARQModules.SubscribeManagement.Interface;
using Common.Logger.Interface;
using System;

namespace ARQ.WebAPI.Controllers
{
    /// <summary>
    /// Контроллер для подписки(пока что на рассылку новостей)
    /// </summary>
    public class SubscribeController : ARQBaseAPIController
    {
        #region core
        private ISubscribeManager _subscribeManager;
        #endregion

        #region init
        public SubscribeController(ILogger logger, ISubscribeManager subscribeManager) : base(logger)
        {
            _subscribeManager = subscribeManager;
        }
        #endregion

        #region API
        /// <summary>
        /// Subscribe
        /// </summary>
        /// <param name="email"></param>
        public void Post(string email)
        {
            try
            {
                _subscribeManager.SubscribeNews(email);
            }
            catch (Exception exc)
            {
                Logger.LogError(exc, "SubscribeController.Post Ошибка");
            }
        }
        /// <summary>
        /// Unsubscribe
        /// </summary>
        /// <param name="token"></param>
        public void Delete(string token)
        {
            //TODO:недоделано
            try
            {
                _subscribeManager.UnsubscribeNews(token);
            }
            catch (Exception exc)
            {
                Logger.LogError(exc, "SubscribeController.Delete Ошибка");
            }
        }
        #endregion

    }
}
