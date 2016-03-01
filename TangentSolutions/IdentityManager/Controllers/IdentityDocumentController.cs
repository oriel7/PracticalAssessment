using System.Web.Http;
using IdentityManager.Services;

namespace IdentityManager.Controllers
{
    public class IdentityDocumentController : ApiController
    {
        /// <summary>
        /// Generates Random ZA Id
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public string GetRandomRsaId()
        {
            var repo = new IdentityDocumentRepository();
            return repo.GetRandomRsaId();
        }

        /// <summary>
        /// Validates a ZA Id
        /// </summary>
        /// <param name="rsaId"></param>
        /// <returns></returns>
        [HttpGet]
        public bool IsValidRsaId(string rsaId)
        {
            var repo = new IdentityDocumentRepository();
            return repo.IsValidRsaId(rsaId);
        }
    }
}
