using Microsoft.IdentityModel.Tokens;

namespace Core.Utilities.Security.Encryption
{
    public class SigningCredentialsHelper
    {
        //JWT'ların oluşturulabilmesi için credential dediğimiz anahtarı ve hashlemede kullandığımız algoritmayı  kullanarak 
        //imzalama nesnesini oluşturur.
        //JWT sistemini yönetebilmesi için securitykey ve şifrelema algoritmasının bildirilmesidir.
        public static SigningCredentials CreateSigningCredentials(SecurityKey security)
        {
            return new SigningCredentials(security, SecurityAlgorithms.HmacSha512Signature);
        }
    }
}
