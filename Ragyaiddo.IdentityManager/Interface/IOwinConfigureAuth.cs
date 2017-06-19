using Owin;

namespace Ragyaiddo.IdentityManager.Interface
{
    public interface IOwinConfigureAuth
    {
        void ConfigureAuth(IAppBuilder app);
    }
}
