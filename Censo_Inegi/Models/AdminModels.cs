namespace Censo_Inegi.Models
{
    public class AdminModels
    {
        public class parameter
        {
            public int ID { get; set; }
        }
        public class parameter2
        {
            public string NOMBRE { get; set; }
        }

        public class insertUser
        {
            public string USER_NAME { get; set; }
            public string PASSWORD { get; set; }
            public int ID_ROL { get; set; }

        }
        public class insertMunicipio : parameter2
        {
            public string ID { get; set; }

        }
        public class insertLocalidades : parameter2
        {
            public string ID_MUNICIPIO { get; set; }
            public string ID_LOCALIDAD { get; set; }
        }

        public class insertVivienda
        {
            public int ID_TIPO_VIVIENDA { get; set; }
            public string ID_MUNICIPIO { get; set; }
            public string ID_LOCALIDAD { get; set; }
            public string CALLE { get; set; }
            public string NUM_EXT { get; set; }
            public string COLONIA { get; set; }
            public int ID_CAPTURA { get; set; }
        }
        public class insertAct_Vivien
        {
            public int ID_ACTIVIDAD { get; set; }
            public int ID_VIVIENDAS { get; set; }
        }
        public class insertPersonas : parameter2
        {
            public string CURP { get; set; }
            public int ID_VIVIENDA { get; set; }
            public string PATERNO { get; set; }
            public string MATERNO { get; set; }
            public int ID_CAPTURA { get; set; }
        }

        public class insertRol
        {
            public string NOMBRE { get; set; }
        }
        public class getRol
        {
            public int ID { get; set; }
            public string NOMBRE { get; set; }
        }

        public class getUsers
        {
            public int ID { get; set; }
            public string USER_NAME { get; set; }
            public int ID_ROL { get; set; }
        }

        public class getVivienda
        {
            public int ID { get; set; }
            public string TIPO_VIVIENDA { get; set; }
            public string MUNICIPIO { get; set; }
            public string LOCALIDAD { get; set; }
            public string CALLE { get; set; }
            public string NUM_EXT { get; set; }
            public string COLONIA { get; set; }
            public int ID_CAPTURA { get; set; }
        }

        public class getVivienda_Actividad
        {
            public string NOMBRE { get; set; }
            public int ID_VIVIENDA { get; set; }
        }

        public class get_Personas2
        {
            public string CURP { get; set; }
            public int ID_VIVIENDA { get; set; }
            public string NOMBRE { get; set; }
            public string PATERNO { get; set; }
            public string MATERNO { get; set; }
            public string USER_NAME { get; set; }
        }

        public class getRolID
        {
            public int ID { get; set; }
        }
        public class  updateRoles
        {
            public int ID { get; set; }
            public string NOMBRE { get; set; }
        }

        public class getUserID
        {
            public int ID { get; set; }
            public string USER_NAME { get; set; }
            public string NOMBRE { get; set; }
        }

        public class updateUsers
        {
            public int ID_ROL { get; set; }
            public string USER_NAME { get; set; }
            public int ID { get; set; }
        }

        public class getMunicipioID
        {
            public string ID { get; set; }
        }
        public class getMunicipioUnique
        {
            public string ID { get; set; }
            public string NOMBRE { get; set; }
        }
        public class getUniqueAct_Viv
        {
            public string NOMBRE { get; set; }
            public int ID_VIVIENDA { get; set; }
        }
        public class uppdateActividad_Vivienda
        {
            public int ID { get; set; }
            public int ID_ACTIVIDAD { get; set; }
        }
        public class updateViivienda
        {
            public int ID { get; set; }
            public int ID_TIPO_VIVIENDA { get; set; }
            public string ID_MUNICIPIO { get; set; }
            public string ID_LOCALIDAD { get; set; }
            public string CALLE { get; set; }
            public string NUM_EXT { get; set; }
            public string COLONIA { get; set; }
        }

        public class curp
        {
            public string CURP { get; set;}
        }

        public class getUniquePersona
        {
            public int ID_VIVIENDA { get; set; }
            public string NOMBRE { get; set; }
            public string PATERNO { get; set; }
            public string MATERNO { get; set; }
        }
        public class updatePerona: getUniquePersona
        {
            public string CURP { get; set;}
        }

        public class getActividadUnique
        {
            public int ID { get; set; }
            public string NOMBRE { get; set; }
        }
        public class dash
        {
            public string NOMBRE { get; set; }
            public int PERSONAS { get; set; }
        }
    }
}
