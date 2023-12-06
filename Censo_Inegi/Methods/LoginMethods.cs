using Censo_Inegi.Services;
using static Censo_Inegi.Models.LoginModels;



namespace Censo_Inegi.Methods
{
    public class LoginMethods
    {
        public getUser getUser(validarUser data)
        {
            try
            {
                string username = data.USERNAME != null && data.USERNAME.Any() ? string.Join("','", data.USERNAME) : "";
                string pass = data.PASSWORD != null && data.PASSWORD.Any() ? string.Join("','", data.PASSWORD) : "";

                string qry = $@"SELECT ID,USER_NAME,ID_ROL 
                                FROM USERS
                                WHERE USER_NAME ='{username}'
                                AND PASSWORD ='{pass}'";
                return SQLService.SelectMethod<getUser>(qry, Coneccion.GetConnectionString()).FirstOrDefault();
            }
            catch
            {
                throw;
            }
        }
    }
}
