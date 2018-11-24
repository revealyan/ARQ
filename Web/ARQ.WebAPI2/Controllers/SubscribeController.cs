using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ARQ.WebAPI.Controllers
{
    public class SubscribeController : ApiController
    {
        #region core
        private ISubscribeManager _subscribeManager;
        #endregion

        #region init
        public SubscribeController(ISubscribeManager subscribeManager)
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
            //TODO: 
        }
        /// <summary>
        /// Unsubscribe
        /// </summary>
        /// <param name="token"></param>
        public void Delete(string token)
        {
            //TODO:
        }
        #endregion

    }
}
