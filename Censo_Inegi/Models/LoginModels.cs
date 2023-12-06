
namespace Censo_Inegi.Models
{
    public class LoginModels
    {
        public class validarUser
        {
            public string USERNAME { get; set; }
            public string PASSWORD { get; set; }
        }

        public class getUser
        {
            public int ID { get; set; }
            public string USER_NAME { get; set; }
            public int ID_ROL { get; set; }
        }
    }
}
