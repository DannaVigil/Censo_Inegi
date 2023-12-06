using Censo_Inegi.Methods;
using Microsoft.AspNetCore.Mvc;
using static Censo_Inegi.Models.UserModels;

namespace Censo_Inegi.Controllers
{
    [ApiController]
    [Route("User")]
    public class UserController: ControllerBase
    {
        UserMethods methods = new UserMethods();

        [HttpGet]
        [Route("getActividad")]
        public ActionResult getActividad()
        {
            string apiName = "getActividad";

            try
            {
                return Ok(new { apiName, msg = "OK", data = methods.getActividad(), error = false });
            }
            catch (Exception ex)
            {
                return Ok(new { apiName, msg = ex.Message, error = true });
            }
        }

        [HttpGet]
        [Route("getActividad_Vivienda")]
        public ActionResult getActividad_Vivienda()
        {
            string apiName = "getActividad_Vivienda";

            try
            {
                return Ok(new { apiName, msg = "OK", data = methods.getActividad_Vivienda(), error = false });
            }
            catch (Exception ex)
            {
                return Ok(new { apiName, msg = ex.Message, error = true });
            }
        }

        [HttpPost]
        [Route("getLocalidad")]
        public ActionResult getLocalidad(parameter2 data)
        {
            string apiName = "getLocalidad";

            try
            {
                return Ok(new { apiName, msg = "OK", data = methods.getLocalidad(data), error = false });
            }
            catch (Exception ex)
            {
                return Ok(new { apiName, msg = ex.Message, error = true });
            }
        }

        [HttpGet]
        [Route("getMunicipios")]
        public ActionResult getMunicipios()
        {
            string apiName = "getMunicipios";

            try
            {
                return Ok(new { apiName, msg = "OK", data = methods.getMunicipios(), error = false });
            }
            catch (Exception ex)
            {
                return Ok(new { apiName, msg = ex.Message, error = true });
            }
        }

        [HttpGet]
        [Route("getPeronas")]
        public ActionResult getPeronas()
        {
            string apiName = "getPeronas";

            try
            {
                return Ok(new { apiName, msg = "OK", data = methods.getPeronas(), error = false });
            }
            catch (Exception ex)
            {
                return Ok(new { apiName, msg = ex.Message, error = true });
            }
        }
    }
}
