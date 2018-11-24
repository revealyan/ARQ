using System;
using System.Collections.Generic;
using ARQModules.SubscribeManagement.Interface;
using Common.Database.Interface;
using Common.Logger.Interface;
using Common.Modules.Base;

namespace ARQModules.SubscribeManagement
{
    /// <summary>
    /// Менеджер подписок
    /// </summary>
    public class SubscribeManager : BaseModule, ISubscribeManager
    {
        #region core
        private IDatabase _database;
        private ILogger _logger;
        #endregion

        #region init
        public SubscribeManager(string name, IDictionary<string, string> parameters) : base(name, parameters)
        {
            RegisterInterface<ISubscribeManager>(this);
        }
        #endregion

        #region BaseModule
        public override void Startup()
        {
            base.Startup();
            _logger = ResolveInterface<ILogger>();
            _database = ResolveInterface<IDatabase>();
        }
        public override void Shutdown()
        {
            base.Shutdown();
        }
        #endregion

        #region ISubscribeManager
        /// <summary>
        /// Подписка на новости
        /// </summary>
        /// <param name="email">Мыло</param>
        /// <returns>Удалось подписать или нет</returns>
        public bool SubscribeNews(string email)
        {
            try
            {
                using (var cmd = _database.CreateCommand($"INSERT INTO news_subscribers(email) VALUES('{email}')"))
                {
                    return cmd.ExecuteNonQuery() != 0;
                }
            }
            catch (Exception exc)
            {
                _logger.LogError(exc, "SubscribeManager.SubscribeNews Произошла ошибка при записи в БД");
                return false;
            }
        }

        public bool UnsubscribeNews(string token)
        {
            throw new System.NotImplementedException();
        }
        #endregion
    }
}
