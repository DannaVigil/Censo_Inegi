namespace Censo_Inegi.Services
{
    public class Coneccion
    {
        private static string conn = "";

        private Coneccion()
        {
            conn = "Server=LAPTOP-I1ML5UUE\\SQLEXPRESS; Database=Censo; Integrated Security=True; TrustServerCertificate=True";
        }

        public static string GetConnectionString()
        {
            if (conn == "")
            {
                new Coneccion();
            }
            return conn;
        }
    }
}
