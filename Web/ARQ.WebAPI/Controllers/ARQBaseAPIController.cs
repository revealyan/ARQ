using Common.Logger.Interface;
using System.Web.Http;

namespace ARQ.WebAPI.Controllers
{
    public class ARQBaseAPIController : ApiController
    {
        #region core
        protected ILogger Logger { get; }
        #endregion

        #region init
        public ARQBaseAPIController(ILogger logger)
        {
            Logger = logger;
        }
        #endregion
    }
}
