namespace JWTToken.API.Models
{
    public class UserConstants
    {
        public static List<UserModel> Users = new()
            {
                    new UserModel(){ Username="poc",Password="poc_admin",Role="Admin"}
            };
    }
}
