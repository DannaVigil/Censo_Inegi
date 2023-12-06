using Censo_Inegi.Services;
using static Censo_Inegi.Models.UserModels;

namespace Censo_Inegi.Methods
{
    public class UserMethods
    {
        public IEnumerable<getActividad> getActividad()
        {
            try
            {
                string qry = $@"SELECT ID, NOMBRE FROM ACTIVIDAD_ECONOMICA";
                return SQLService.SelectMethod<getActividad>(qry, Coneccion.GetConnectionString());
            }
            catch
            {
                throw;
            }
        }

        public IEnumerable<getActividad_Vivienda> getActividad_Vivienda()
        {
            try
            {
                string qry = $@"SELECT A.NOMBRE AS ACTIVIDAD, V.ID AS ID_VIVIENDA
                                FROM ACTIVIDADES_VIVIENDAS AV
                                LEFT JOIN ACTIVIDAD_ECONOMICA A ON AV.ID_ACTIVIDAD = A.ID
                                LEFT JOIN VIVIENDAS V ON AV.ID_VIVIENDA = V.ID";
                return SQLService.SelectMethod<getActividad_Vivienda>(qry, Coneccion.GetConnectionString());
            }
            catch
            {
                throw;
            }
        }

        public IEnumerable<getLocalidad> getLocalidad(parameter2 data)
        {
            try
            {
                string id = data.ID != null && data.ID.Any() ? string.Join("','", data.ID) : "";

                string qry = $@"SELECT ID_LOCALIDAD AS ID, LOCALIDAD AS NOMBRE
                                FROM LOCALIDADES
                                WHERE ID_MUNICIPIO ='{id}'";
                return SQLService.SelectMethod<getLocalidad>(qry, Coneccion.GetConnectionString());
            }
            catch
            {
                throw;
            }
        }
        public IEnumerable<getLocalidad> getMunicipios()
        {
            try
            {

                string qry = $@"SELECT ID, NOMBRE 
                                FROM MUNICIPIOS
                                ORDER BY ID";
                return SQLService.SelectMethod<getLocalidad>(qry, Coneccion.GetConnectionString());
            }
            catch
            {
                throw;
            }
        }

        public IEnumerable<getPersonas> getPeronas()
        {
            try
            {

                string qry = $@"SELECT CURP, ID_VIVIENDA, NOMBRE, PATERNO, MATERNO
                                FROM PERSONAS;";
                return SQLService.SelectMethod<getPersonas>(qry, Coneccion.GetConnectionString());
            }
            catch
            {
                throw;
            }
        }
    }
}
