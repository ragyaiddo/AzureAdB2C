namespace Ragyaiddo.IdentityManager.Services
{
    public interface IAuthenticationService
    {
        void SignUp();
        void Login();
        void Logout();
        void ResetPassword();
    }
}
