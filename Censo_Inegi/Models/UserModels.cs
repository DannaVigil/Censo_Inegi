namespace Censo_Inegi.Models
{
    public class UserModels
    {
        public class parameter
        {
            public int ID { get; set; }
        }
        public class parameter2
        {
            public string ID { get; set; }
        }

        public class  getActividad :parameter
        {
            public string NOMBRE { get; set; }
        }
        public class getActividad_Vivienda
        {
            public string ACTIVIDAD { get; set; }
            public int ID_VIVIENDA { get; set; }
        }

        public class getLocalidad : parameter2
        {
            public string NOMBRE { get; set; }
        }
        public class getPersonas
        {
            public string CURP { get; set; }
            public int ID_VIVIENDA { get; set; }
            public string NOMBRE { get; set; }
            public string PATERNO { get; set; }
            public string MATERNO { get; set; }
        }
    }
}
