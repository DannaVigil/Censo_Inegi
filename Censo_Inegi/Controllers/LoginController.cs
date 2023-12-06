using Censo_Inegi.Methods;
using Microsoft.AspNetCore.Mvc;
using static Censo_Inegi.Models.LoginModels;

namespace Censo_Inegi.Controllers
{
    [ApiController]
    [Route("Login")]
    public class LoginController: ControllerBase
    {
        LoginMethods methods = new LoginMethods();

        [HttpPost]
        [Route("getUser")]
        public ActionResult getUser(validarUser data)
        {
            string apiName = "getUser";

            try
            {
                return Ok(new { apiName, msg = "OK", data = methods.getUser(data), error = false });
            }
            catch (Exception ex)
            {
                return Ok(new { apiName, msg = ex.Message, error = true });
            }
        }
    }
}
