using Censo_Inegi.Methods;
using Microsoft.AspNetCore.Mvc;
using static Censo_Inegi.Models.AdminModels;


namespace Censo_Inegi.Controllers
{
    [ApiController]
    [Route("Admin")]
    public class AdminController : ControllerBase
    {
        AdminMethods methods = new AdminMethods();

        [HttpPost]
        [Route("insertRol")]
        public ActionResult insertRol(insertRol data)
        {
            string apiName = "insertRol";

            try
            {
                return Ok(new { apiName, msg = "OK", data = methods.insertRol(data), error = false });
            }
            catch (Exception ex)
            {
                return Ok(new { apiName, msg = ex.Message, error = true });
            }
        }


        [HttpPost]
        [Route("insertUser")]
        public ActionResult insertUser(insertUser data)
        {
            string apiName = "insertUser";

            try
            {
                return Ok(new { apiName, msg = "OK", data = methods.insertUser(data), error = false });
            }
            catch (Exception ex)
            {
                return Ok(new { apiName, msg = ex.Message, error = true });
            }
        }

        [HttpPost]
        [Route("insertMunicipio")]
        public ActionResult insertMunicipio(insertMunicipio data)
        {
            string apiName = "insertMunicipio";

            try
            {
                return Ok(new { apiName, msg = "OK", data = methods.insertMunicipio(data), error = false });
            }
            catch (Exception ex)
            {
                return Ok(new { apiName, msg = ex.Message, error = true });
            }
        }

        [HttpPost]
        [Route("insertLocalidades")]
        public ActionResult insertLocalidades(insertLocalidades data)
        {
            string apiName = "insertLocalidades";

            try
            {
                return Ok(new { apiName, msg = "OK", data = methods.insertLocalidades(data), error = false });
            }
            catch (Exception ex)
            {
                return Ok(new { apiName, msg = ex.Message, error = true });
            }
        }

        [HttpPost]
        [Route("insertTipoVivienda")]
        public ActionResult insertTipoVivienda(insertRol data)
        {
            string apiName = "insertTipoVivienda";

            try
            {
                return Ok(new { apiName, msg = "OK", data = methods.insertTipoVivienda(data), error = false });
            }
            catch (Exception ex)
            {
                return Ok(new { apiName, msg = ex.Message, error = true });
            }
        }

        [HttpPost]
        [Route("insertActividad_Economica")]
        public ActionResult insertActividad_Economica(insertRol data)
        {
            string apiName = "insertActividad_Economica";

            try
            {
                return Ok(new { apiName, msg = "OK", data = methods.insertActividad_Economica(data), error = false });
            }
            catch (Exception ex)
            {
                return Ok(new { apiName, msg = ex.Message, error = true });
            }
        }

        [HttpPost]
        [Route("insert_Vivienda")]
        public ActionResult insert_Vivienda(insertVivienda data)
        {
            string apiName = "insert_Vivienda";

            try
            {
                return Ok(new { apiName, msg = "OK", data = methods.insert_Vivienda(data), error = false });
            }
            catch (Exception ex)
            {
                return Ok(new { apiName, msg = ex.Message, error = true });
            }
        }

        [HttpPost]
        [Route("insert_Actividades_Viviendas")]
        public ActionResult insert_Actividades_Viviendas(insertAct_Vivien data)
        {
            string apiName = "insert_Actividades_Viviendas";

            try
            {
                return Ok(new { apiName, msg = "OK", data = methods.insert_Actividades_Viviendas(data), error = false });
            }
            catch (Exception ex)
            {
                return Ok(new { apiName, msg = ex.Message, error = true });
            }
        }

        [HttpPost]
        [Route("insert_Personas")]
        public ActionResult insert_Personas(insertPersonas data)
        {
            string apiName = "insert_Personas";

            try
            {
                return Ok(new { apiName, msg = "OK", data = methods.insert_Personas(data), error = false });
            }
            catch (Exception ex)
            {
                return Ok(new { apiName, msg = ex.Message, error = true });
            }
        }

        [HttpGet]
        [Route("getRoles")]
        public ActionResult getRoles()
        {
            string apiName = "getRoles";

            try
            {
                return Ok(new { apiName, msg = "OK", data = methods.getRoles(), error = false });
            }
            catch (Exception ex)
            {
                return Ok(new { apiName, msg = ex.Message, error = true });
            }
        }
        [HttpGet]
        [Route("getUsers")]
        public ActionResult getUsers()
        {
            string apiName = "getUsers";

            try
            {
                return Ok(new { apiName, msg = "OK", data = methods.getUsers(), error = false });
            }
            catch (Exception ex)
            {
                return Ok(new { apiName, msg = ex.Message, error = true });
            }
        }

        [HttpGet]
        [Route("get_Tipo_Vivienda")]
        public ActionResult get_Tipo_Vivienda()
        {
            string apiName = "get_Tipo_Vivienda";

            try
            {
                return Ok(new { apiName, msg = "OK", data = methods.get_Tipo_Vivienda(), error = false });
            }
            catch (Exception ex)
            {
                return Ok(new { apiName, msg = ex.Message, error = true });
            }
        }

        [HttpGet]
        [Route("get_Actividad_Economica")]
        public ActionResult get_Actividad_Economica()
        {
            string apiName = "get_Actividad_Economica";

            try
            {
                return Ok(new { apiName, msg = "OK", data = methods.get_Actividad_Economica(), error = false });
            }
            catch (Exception ex)
            {
                return Ok(new { apiName, msg = ex.Message, error = true });
            }
        }

        [HttpGet]
        [Route("getVivienda")]
        public ActionResult getVivienda()
        {
            string apiName = "getVivienda";

            try
            {
                return Ok(new { apiName, msg = "OK", data = methods.getVivienda(), error = false });
            }
            catch (Exception ex)
            {
                return Ok(new { apiName, msg = ex.Message, error = true });
            }
        }
        [HttpGet]
        [Route("get_Vivienda_Actividades")]
        public ActionResult get_Vivienda_Actividades()
        {
            string apiName = "get_Vivienda_Actividades";

            try
            {
                return Ok(new { apiName, msg = "OK", data = methods.get_Vivienda_Actividades(), error = false });
            }
            catch (Exception ex)
            {
                return Ok(new { apiName, msg = ex.Message, error = true });
            }
        }

        [HttpGet]
        [Route("get_Personas")]
        public ActionResult get_Personas()
        {
            string apiName = "get_Personas";

            try
            {
                return Ok(new { apiName, msg = "OK", data = methods.get_Personas(), error = false });
            }
            catch (Exception ex)
            {
                return Ok(new { apiName, msg = ex.Message, error = true });
            }
        }











        [HttpPost]
        [Route("get_Unique_Rol")]
        public ActionResult get_Unique_Rol(getRolID data)
        {
            string apiName = "get_Unique_Rol";

            try
            {
                return Ok(new { apiName, msg = "OK", data = methods.get_Unique_Rol(data), error = false });
            }
            catch (Exception ex)
            {
                return Ok(new { apiName, msg = ex.Message, error = true });
            }
        }

        [HttpPost]
        [Route("update_Roles")]
        public ActionResult update_Roles(updateRoles data)
        {
            string apiName = "update_Roles";

            try
            {
                return Ok(new { apiName, msg = "OK", data = methods.update_Roles(data), error = false });
            }
            catch (Exception ex)
            {
                return Ok(new { apiName, msg = ex.Message, error = true });
            }
        }

        [HttpPost]
        [Route("get_Unique_User")]
        public ActionResult get_Unique_User(getRolID data)
        {
            string apiName = "get_Unique_User";

            try
            {
                return Ok(new { apiName, msg = "OK", data = methods.get_Unique_User(data), error = false });
            }
            catch (Exception ex)
            {
                return Ok(new { apiName, msg = ex.Message, error = true });
            }
        }

        [HttpPost]
        [Route("update_Users")]
        public ActionResult update_Users(updateUsers data)
        {
            string apiName = "update_Users";

            try
            {
                return Ok(new { apiName, msg = "OK", data = methods.update_Users(data), error = false });
            }
            catch (Exception ex)
            {
                return Ok(new { apiName, msg = ex.Message, error = true });
            }
        }

        [HttpPost]
        [Route("get_Unique_Municipio")]
        public ActionResult get_Unique_Municipio(getMunicipioID data)
        {
            string apiName = "get_Unique_Municipio";

            try
            {
                return Ok(new { apiName, msg = "OK", data = methods.get_Unique_Municipio(data), error = false });
            }
            catch (Exception ex)
            {
                return Ok(new { apiName, msg = ex.Message, error = true });
            }
        }

        [HttpPost]
        [Route("update_Municipio")]
        public ActionResult update_Municipio(getMunicipioUnique data)
        {
            string apiName = "update_Municipio";

            try
            {
                return Ok(new { apiName, msg = "OK", data = methods.update_Municipio(data), error = false });
            }
            catch (Exception ex)
            {
                return Ok(new { apiName, msg = ex.Message, error = true });
            }
        }

        [HttpPost]
        [Route("get_Unique_TipoVivienda")]
        public ActionResult get_Unique_TipoVivienda(getRolID data)
        {
            string apiName = "get_Unique_TipoVivienda";

            try
            {
                return Ok(new { apiName, msg = "OK", data = methods.get_Unique_TipoVivienda(data), error = false });
            }
            catch (Exception ex)
            {
                return Ok(new { apiName, msg = ex.Message, error = true });
            }
        }

        [HttpPost]
        [Route("update_Tipo_Vivienda")]
        public ActionResult update_Tipo_Vivienda(updateRoles data)
        {
            string apiName = "update_Tipo_Vivienda";

            try
            {
                return Ok(new { apiName, msg = "OK", data = methods.update_Tipo_Vivienda(data), error = false });
            }
            catch (Exception ex)
            {
                return Ok(new { apiName, msg = ex.Message, error = true });
            }
        }


        [HttpPost]
        [Route("get_Unique_ActividadEconomica")]
        public ActionResult get_Unique_ActividadEconomica(getRolID data)
        {
            string apiName = "get_Unique_ActividadEconomica";

            try
            {
                return Ok(new { apiName, msg = "OK", data = methods.get_Unique_ActividadEconomica(data), error = false });
            }
            catch (Exception ex)
            {
                return Ok(new { apiName, msg = ex.Message, error = true });
            }
        }

        [HttpPost]
        [Route("update_Actividad_Economica")]
        public ActionResult update_Actividad_Economica(updateRoles data)
        {
            string apiName = "update_Actividad_Economica";

            try
            {
                return Ok(new { apiName, msg = "OK", data = methods.update_Actividad_Economica(data), error = false });
            }
            catch (Exception ex)
            {
                return Ok(new { apiName, msg = ex.Message, error = true });
            }
        }

        [HttpPost]
        [Route("get_Unique_Actividades_Viviendas")]
        public ActionResult get_Unique_Actividades_Viviendas(getRolID data)
        {
            string apiName = "get_Unique_Actividades_Viviendas";

            try
            {
                return Ok(new { apiName, msg = "OK", data = methods.get_Unique_Actividades_Viviendas(data), error = false });
            }
            catch (Exception ex)
            {
                return Ok(new { apiName, msg = ex.Message, error = true });
            }
        }

        [HttpPost]
        [Route("update_Actividad_Vivienda")]
        public ActionResult update_Actividad_Vivienda(uppdateActividad_Vivienda data)
        {
            string apiName = "update_Actividad_Vivienda";

            try
            {
                return Ok(new { apiName, msg = "OK", data = methods.update_Actividad_Vivienda(data), error = false });
            }
            catch (Exception ex)
            {
                return Ok(new { apiName, msg = ex.Message, error = true });
            }
        }

        [HttpPost]
        [Route("get_Unique_Viviendas")]
        public ActionResult get_Unique_Viviendas(getRolID data)
        {
            string apiName = "get_Unique_Viviendas";

            try
            {
                return Ok(new { apiName, msg = "OK", data = methods.get_Unique_Viviendas(data), error = false });
            }
            catch (Exception ex)
            {
                return Ok(new { apiName, msg = ex.Message, error = true });
            }
        }

        [HttpPost]
        [Route("update_Vivienda")]
        public ActionResult update_Vivienda(updateViivienda data)
        {
            string apiName = "update_Vivienda";

            try
            {
                return Ok(new { apiName, msg = "OK", data = methods.update_Vivienda(data), error = false });
            }
            catch (Exception ex)
            {
                return Ok(new { apiName, msg = ex.Message, error = true });
            }
        }

        [HttpPost]
        [Route("get_Unique_Personas")]
        public ActionResult get_Unique_Personas(curp data)
        {
            string apiName = "get_Unique_Personas";

            try
            {
                return Ok(new { apiName, msg = "OK", data = methods.get_Unique_Personas(data), error = false });
            }
            catch (Exception ex)
            {
                return Ok(new { apiName, msg = ex.Message, error = true });
            }
        }

        [HttpPost]
        [Route("update_Persona")]
        public ActionResult update_Persona(updatePerona data)
        {
            string apiName = "update_Persona";

            try
            {
                return Ok(new { apiName, msg = "OK", data = methods.update_Persona(data), error = false });
            }
            catch (Exception ex)
            {
                return Ok(new { apiName, msg = ex.Message, error = true });
            }
        }

        [HttpPost]
        [Route("delete_Rol")]
        public ActionResult delete_Rol(getRolID data)
        {
            string apiName = "delete_Rol";

            try
            {
                return Ok(new { apiName, msg = "OK", data = methods.delete_Rol(data), error = false });
            }
            catch (Exception ex)
            {
                return Ok(new { apiName, msg = ex.Message, error = true });
            }
        }
    }
}
