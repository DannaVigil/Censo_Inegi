using Censo_Inegi.Services;
using static Censo_Inegi.Models.AdminModels;
using static Censo_Inegi.Models.UserModels;

namespace Censo_Inegi.Methods
{
    public class AdminMethods
    {

        public dynamic insertRol(insertRol data)
        {
            try
            {
                string nombre = data.NOMBRE != null && data.NOMBRE.Any() ? string.Join("','", data.NOMBRE) : "";
                string qry = $@"INSERT INTO ROLES VALUES('{nombre}');";

                return SQLService.InsertMethod(qry, Coneccion.GetConnectionString());
            }
            catch
            {
                throw;
            }
        }

        public dynamic insertUser(insertUser data)
        {
            try
            {
                string nombre = data.USER_NAME != null && data.USER_NAME.Any() ? string.Join("','", data.USER_NAME) : "";
                string password = data.PASSWORD != null && data.PASSWORD.Any() ? string.Join("','", data.PASSWORD) : "";
                int id_rol = (int)data.ID_ROL;

                string qry = $@"INSERT INTO USERS VALUES('{nombre}','{password}',{id_rol});";

                return SQLService.InsertMethod(qry, Coneccion.GetConnectionString());
            }
            catch
            {
                throw;
            }
        }

        public dynamic insertMunicipio(insertMunicipio data)
        {
            try
            {
                string nombre = data.NOMBRE != null && data.NOMBRE.Any() ? string.Join("','", data.NOMBRE) : "";
                string id = data.ID != null && data.ID.Any() ? string.Join("','", data.ID) : "";
                string qry = $@"INSERT INTO MUNICIPIOS(ID,NOMBRE) VALUES('{id}','{nombre}');";

                return SQLService.InsertMethod(qry, Coneccion.GetConnectionString());
            }
            catch
            {
                throw;
            }
        }

        public dynamic insertLocalidades(insertLocalidades data)
        {
            try
            {
                string nombre = data.NOMBRE != null && data.NOMBRE.Any() ? string.Join("','", data.NOMBRE) : "";
                string id_muni = data.ID_MUNICIPIO != null && data.ID_MUNICIPIO.Any() ? string.Join("','", data.ID_MUNICIPIO) : "";
                string id_localidad = data.ID_LOCALIDAD != null && data.ID_LOCALIDAD.Any() ? string.Join("','", data.ID_LOCALIDAD) : "";
                string qry = $@"INSERT INTO LOCALIDADES VALUES('{id_muni}','{id_localidad}','{nombre}')";

                return SQLService.InsertMethod(qry, Coneccion.GetConnectionString());
            }
            catch
            {
                throw;
            }
        }

        public dynamic insertTipoVivienda(insertRol data)
        {
            try
            {
                string nombre = data.NOMBRE != null && data.NOMBRE.Any() ? string.Join("','", data.NOMBRE) : "";
                string qry = $@"INSERT INTO TIPO_VIVIENDA VALUES('{nombre}');";

                return SQLService.InsertMethod(qry, Coneccion.GetConnectionString());
            }
            catch
            {
                throw;
            }
        }

        public dynamic insertActividad_Economica(insertRol data)
        {
            try
            {
                string nombre = data.NOMBRE != null && data.NOMBRE.Any() ? string.Join("','", data.NOMBRE) : "";
                string qry = $@"INSERT INTO ACTIVIDAD_ECONOMICA VALUES('{nombre}');";

                return SQLService.InsertMethod(qry, Coneccion.GetConnectionString());
            }
            catch
            {
                throw;
            }
        }

        public dynamic insert_Vivienda(insertVivienda data)
        {
            try
            {
                int id__tipo_vivienda = (int)data.ID_TIPO_VIVIENDA;
                string id_municipio = data.ID_MUNICIPIO != null && data.ID_MUNICIPIO.Any() ? string.Join("','", data.ID_MUNICIPIO) : "";
                string id_localidad = data.ID_LOCALIDAD != null && data.ID_LOCALIDAD.Any() ? string.Join("','", data.ID_LOCALIDAD) : "";
                string calle = data.CALLE != null && data.CALLE.Any() ? string.Join("','", data.CALLE) : "";
                string num_ext = data.NUM_EXT != null && data.NUM_EXT.Any() ? string.Join("','", data.NUM_EXT) : "";
                string colonia = data.COLONIA != null && data.COLONIA.Any() ? string.Join("','", data.COLONIA) : "";
                int id_user_captura = (int)data.ID_CAPTURA;

                string qry = $@"INSERT INTO VIVIENDAS VALUES({id__tipo_vivienda},'{id_municipio}','{id_localidad}','{calle}','{num_ext}','{colonia}',{id_user_captura})";

                return SQLService.InsertMethod(qry, Coneccion.GetConnectionString());
            }
            catch
            {
                throw;
            }
        }

        public dynamic insert_Actividades_Viviendas(insertAct_Vivien data)
        {
            try
            {
                int actividad = (int)data.ID_ACTIVIDAD;
                int vivienda = (int)data.ID_VIVIENDAS;

                string qry = $@"INSERT INTO ACTIVIDADES_VIVIENDAS VALUES({actividad},{vivienda})";

                return SQLService.InsertMethod(qry, Coneccion.GetConnectionString());
            }
            catch
            {
                throw;
            }
        }

        public dynamic insert_Personas(insertPersonas data)
        {
            try
            {
                string curp = data.CURP != null && data.CURP.Any() ? string.Join("','", data.CURP) : "";
                int id_vivienda = (int)data.ID_VIVIENDA;
                string nombre = data.NOMBRE != null && data.NOMBRE.Any() ? string.Join("','", data.NOMBRE) : "";
                string paterno = data.PATERNO != null && data.PATERNO.Any() ? string.Join("','", data.PATERNO) : "";
                string materno = data.MATERNO != null && data.MATERNO.Any() ? string.Join("','", data.MATERNO) : "";
                int id_captura = data.ID_CAPTURA;

                string qry = $@"INSERT INTO PERSONAS VALUES('{curp}',{id_vivienda},'{nombre}', '{paterno}','{materno}',{id_captura})";

                return SQLService.InsertMethod(qry, Coneccion.GetConnectionString());
            }
            catch
            {
                throw;
            }
            }

        public IEnumerable<getRol> getRoles()
        {
            try
            {
                string qry = $@"SELECT ID, NOMBRE FROM ROLES";
                return SQLService.SelectMethod<getRol>(qry, Coneccion.GetConnectionString());
            }
            catch
            {
                throw;
            }
        }
        public IEnumerable<getUsers> getUsers()
        {
            try
            {
                string qry = $@"SELECT ID,USER_NAME,ID_ROL FROM USERS";
                return SQLService.SelectMethod<getUsers>(qry, Coneccion.GetConnectionString());
            }
            catch
            {
                throw;
            }
        }

        public IEnumerable<getRol> get_Tipo_Vivienda()
        {
            try
            {
                string qry = $@"SELECT ID, NOMBRE FROM TIPO_VIVIENDA";
                return SQLService.SelectMethod<getRol>(qry, Coneccion.GetConnectionString());
            }
            catch
            {
                throw;
            }
        }

        public IEnumerable<getRol> get_Actividad_Economica()
        {
            try
            {
                string qry = $@"SELECT ID, NOMBRE FROM ACTIVIDAD_ECONOMICA";
                return SQLService.SelectMethod<getRol>(qry, Coneccion.GetConnectionString());
            }
            catch
            {
                throw;
            }
        }

        public IEnumerable<getVivienda> getVivienda()
        {
            try
            {
                string qry = $@"SELECT V.ID,TV.NOMBRE AS TIPO_VIVIENDA, M.NOMBRE AS MUNICIPIO,
                                ID_LOCALIDAD AS LOCALIDAD, CALLE,NUM_EXT, COLONIA,ID_CAPTURA
                                FROM VIVIENDAS V
                                LEFT JOIN TIPO_VIVIENDA TV ON V.ID_TIPO_VIVIENDA = TV.ID
                                LEFT JOIN MUNICIPIOS M ON V.ID_MUNICIPIO = M.ID";
                return SQLService.SelectMethod<getVivienda>(qry, Coneccion.GetConnectionString());
            }
            catch
            {
                throw;
            }
        }

        public IEnumerable<getVivienda_Actividad> get_Vivienda_Actividades()
        {
            try
            {
                string qry = $@"SELECT A.NOMBRE, ID_VIVIENDA
                                FROM ACTIVIDADES_VIVIENDAS AV
                                LEFT JOIN ACTIVIDAD_ECONOMICA A ON A.ID = AV.ID_ACTIVIDAD";
                return SQLService.SelectMethod<getVivienda_Actividad>(qry, Coneccion.GetConnectionString());
            }
            catch
            {
                throw;
            }
        }

        public IEnumerable<get_Personas2> get_Personas()
        {
            try
            {
                string qry = $@"SELECT CURP, ID_VIVIENDA,NOMBRE, PATERNO, MATERNO, U.USER_NAME 
                                FROM PERSONAS P
                                LEFT JOIN USERS U ON U.ID = P.ID_CAPTURA";
                return SQLService.SelectMethod<get_Personas2>(qry, Coneccion.GetConnectionString());
            }
            catch
            {
                throw;
            }
        }


        public IEnumerable<getRol> get_Unique_Rol(getRolID data)
        {
            try
            {
                int id = (int)data.ID;


                string qry = $@"SELECT ID, NOMBRE 
                                FROM ROLES
                                WHERE ID ={id}";

                return SQLService.SelectMethod<getRol>(qry, Coneccion.GetConnectionString());
            }
            catch
            {
                throw;
            }
        }

        public dynamic update_Roles(updateRoles data)
        {
            try
            {
                int id = (int)data.ID;
                string nombre = data.NOMBRE != null && data.NOMBRE.Any() ? string.Join("','", data.NOMBRE) : "";

                string qry = $@"UPDATE ROLES SET NOMBRE ='{nombre}'
                                WHERE ID = {id}";

                return SQLService.InsertMethod(qry, Coneccion.GetConnectionString());
            }
            catch
            {
                throw;
            }
        }

        public IEnumerable<getUserID> get_Unique_User(getRolID data)
        {
            try
            {
                int id = (int)data.ID;


                string qry = $@"SELECT U.ID,USER_NAME,R.NOMBRE
                                FROM USERS U
                                LEFT JOIN ROLES R ON U.ID_ROL = R.ID
                                WHERE U.ID = {id}";

                return SQLService.SelectMethod<getUserID>(qry, Coneccion.GetConnectionString());
            }
            catch
            {
                throw;
            }
        }

        public dynamic update_Users(updateUsers data)
        {
            try
            {
                int id = (int)data.ID;
                string user_name = data.USER_NAME != null && data.USER_NAME.Any() ? string.Join("','", data.USER_NAME) : "";
                int id_rol = (int)data.ID_ROL;

                string qry = $@"UPDATE USERS
                                SET USER_NAME ='{user_name}', ID_ROL ={id_rol}
                                WHERE ID ={id}";

                return SQLService.InsertMethod(qry, Coneccion.GetConnectionString());
            }
            catch
            {
                throw;
            }
        }

        public IEnumerable<getMunicipioUnique> get_Unique_Municipio(getMunicipioID data)
        {
            try
            {
                string id = data.ID != null && data.ID.Any() ? string.Join("','", data.ID) : "";


                string qry = $@"SELECT ID, NOMBRE
                                FROM MUNICIPIOS
                                WHERE ID= '{id}'";

                return SQLService.SelectMethod<getMunicipioUnique>(qry, Coneccion.GetConnectionString());
            }
            catch
            {
                throw;
            }
        }

        public dynamic update_Municipio(getMunicipioUnique data)
        {
            try
            {
                string id = data.ID != null && data.ID.Any() ? string.Join("','", data.ID) : "";
                string nombre = data.NOMBRE != null && data.NOMBRE.Any() ? string.Join("','", data.NOMBRE) : "";

                string qry = $@"UPDATE MUNICIPIOS
                                SET NOMBRE ='{nombre}'
                                WHERE ID='{id}'";

                return SQLService.InsertMethod(qry, Coneccion.GetConnectionString());
            }
            catch
            {
                throw;
            }
        }

        public IEnumerable<getMunicipioUnique> get_Unique_TipoVivienda(getRolID data)
        {
            try
            {
                int id = (int)data.ID;


                string qry = $@"SELECT ID, NOMBRE
                                FROM TIPO_VIVIENDA
                                WHERE ID ={id}";

                return SQLService.SelectMethod<getMunicipioUnique>(qry, Coneccion.GetConnectionString());
            }
            catch
            {
                throw;
            }
        }

        public dynamic update_Tipo_Vivienda(updateRoles data)
        {
            try
            {
                int id = (int)data.ID;
                string nombre = data.NOMBRE != null && data.NOMBRE.Any() ? string.Join("','", data.NOMBRE) : "";

                string qry = $@"UPDATE TIPO_VIVIENDA
                                SET NOMBRE ='{nombre}'
                                WHERE ID ={id}";

                return SQLService.InsertMethod(qry, Coneccion.GetConnectionString());
            }
            catch
            {
                throw;
            }
        }

        public IEnumerable<getActividadUnique> get_Unique_ActividadEconomica(getRolID data)
        {
            try
            {
                int id = (int)data.ID;


                string qry = $@"SELECT ID,NOMBRE
                                FROM ACTIVIDAD_ECONOMICA
                                WHERE ID={id}";

                return SQLService.SelectMethod<getActividadUnique>(qry, Coneccion.GetConnectionString());
            }
            catch
            {
                throw;
            }
        }

        public dynamic update_Actividad_Economica(updateRoles data)
        {
            try
            {
                int id = (int)data.ID;
                string nombre = data.NOMBRE != null && data.NOMBRE.Any() ? string.Join("','", data.NOMBRE) : "";

                string qry = $@"UPDATE ACTIVIDAD_ECONOMICA
                                SET NOMBRE ='{nombre}'
                                WHERE ID = {id}";

                return SQLService.InsertMethod(qry, Coneccion.GetConnectionString());
            }
            catch
            {
                throw;
            }
        }

        public IEnumerable<getUniqueAct_Viv> get_Unique_Actividades_Viviendas(getRolID data)
        {
            try
            {
                int id = (int)data.ID;


                string qry = $@"SELECT AE.NOMBRE, AV.ID_VIVIENDA
                                FROM ACTIVIDADES_VIVIENDAS AV
                                LEFT JOIN ACTIVIDAD_ECONOMICA AE ON AV.ID_ACTIVIDAD = AE.ID
                                WHERE AV.ID ={id}";

                return SQLService.SelectMethod<getUniqueAct_Viv>(qry, Coneccion.GetConnectionString());
            }
            catch
            {
                throw;
            }
        }

        public dynamic update_Actividad_Vivienda(uppdateActividad_Vivienda data)
        {
            try
            {
                int id = (int)data.ID;
                int id_actividad = data.ID_ACTIVIDAD;

                string qry = $@"UPDATE ACTIVIDADES_VIVIENDAS
                                    SET ID_ACTIVIDAD ={id_actividad}
                                    WHERE ID = {id}";

                return SQLService.InsertMethod(qry, Coneccion.GetConnectionString());
            }
            catch
            {
                throw;
            }
        }

        public IEnumerable<getVivienda> get_Unique_Viviendas(getRolID data)
        {
            try
            {
                int id = (int)data.ID;


                string qry = $@"SELECT V.ID,TV.NOMBRE AS TIPO_VIVIENDA, M.NOMBRE AS MUNICIPIO,
                                ID_LOCALIDAD AS LOCALIDAD, CALLE,NUM_EXT, COLONIA,ID_CAPTURA
                                FROM VIVIENDAS V
                                LEFT JOIN TIPO_VIVIENDA TV ON V.ID_TIPO_VIVIENDA = TV.ID
                                LEFT JOIN MUNICIPIOS M ON V.ID_MUNICIPIO = M.ID
								WHERE V.ID={id}";

                return SQLService.SelectMethod<getVivienda>(qry, Coneccion.GetConnectionString());
            }
            catch
            {
                throw;
            }
        }
        public dynamic update_Vivienda(updateViivienda data)
        {
            try
            {
                int id_tipo_vivienda = (int)data.ID_TIPO_VIVIENDA;
                string id_municipio = data.ID_MUNICIPIO != null && data.ID_MUNICIPIO.Any() ? string.Join("','", data.ID_MUNICIPIO) : "";
                string id_localidad = data.ID_LOCALIDAD != null && data.ID_LOCALIDAD.Any() ? string.Join("','", data.ID_LOCALIDAD) : "";
                string calle = data.CALLE != null && data.CALLE.Any() ? string.Join("','", data.CALLE) : "";
                string num_ext = data.NUM_EXT != null && data.NUM_EXT.Any() ? string.Join("','", data.NUM_EXT) : "";
                string colonia = data.COLONIA != null && data.COLONIA.Any() ? string.Join("','", data.COLONIA) : "";
                int id = (int)data.ID;

                string qry = $@"UPDATE VIVIENDAS
                                SET ID_TIPO_VIVIENDA = {id_tipo_vivienda}, ID_MUNICIPIO='{id_municipio}', ID_LOCALIDAD ='{id_localidad}',
                                CALLE ='{calle}',NUM_EXT ='{num_ext}', COLONIA ='{colonia}'
                                WHERE ID= {id}";

                return SQLService.InsertMethod(qry, Coneccion.GetConnectionString());
            }
            catch
            {
                throw;
            }
        }

        public IEnumerable<getUniquePersona> get_Unique_Personas(curp data)
        {
            try
            {
                string cur = data.CURP != null && data.CURP.Any() ? string.Join("','", data.CURP) : "";


                string qry = $@"SELECT ID_VIVIENDA, NOMBRE,PATERNO, MATERNO
                                FROM PERSONAS
                                WHERE CURP='{cur}'";

                return SQLService.SelectMethod<getUniquePersona>(qry, Coneccion.GetConnectionString());
            }
            catch
            {
                throw;
            }
        }

        public dynamic update_Persona(updatePerona data)
        {
            try
            {
                int id_vivienda = (int)data.ID_VIVIENDA;
                string nombre = data.NOMBRE != null && data.NOMBRE.Any() ? string.Join("','", data.NOMBRE) : "";
                string paterno = data.PATERNO != null && data.PATERNO.Any() ? string.Join("','", data.PATERNO) : "";
                string materno = data.MATERNO != null && data.MATERNO.Any() ? string.Join("','", data.MATERNO) : "";
                string curp = data.CURP != null && data.CURP.Any() ? string.Join("','", data.CURP) : "";


                string qry = $@"UPDATE PERSONAS
                                SET ID_VIVIENDA = {id_vivienda},
                                NOMBRE='{nombre}', PATERNO='{paterno}',MATERNO='{materno}'
                                WHERE CURP ='{curp}'";

                return SQLService.InsertMethod(qry, Coneccion.GetConnectionString());
            }
            catch
            {
                throw;
            }
        }

        public dynamic delete_Rol(getRolID data)
        {
            try
            {
                int id = (int)data.ID;


                string qry = $@"DELETE ROLES
                                WHERE ID={id}";

                return SQLService.DeleteMethod(qry, Coneccion.GetConnectionString());
            }
            catch
            {
                throw;
            }
        }
    }
}
