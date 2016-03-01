using System.Web.Http;
using IdentityManager.Services;

namespace IdentityManager.Controllers
{
    public class IdentityDocumentController : ApiController
    {
        /// <summary>
        /// Generates Random South African Id
        /// </summary>
        /// <returns></returns>
        public string GetRandomRsaId()
        {
            var repo = new IdentityDocumentRepository();
            return repo.GetRandomRsaId();
        }
    }
}
