using Microsoft.AspNetCore.Mvc;

namespace CanalesElectronicosAPV.Controllers
{
    public class SmokeController : Controller
    {
        private const string TestReponse = "Is running...";
        // GET: api/Smoke
        [HttpGet]
        public string Test()
        {
            return TestReponse;
        }
    }
}
