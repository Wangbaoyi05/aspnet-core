using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace ABPUnity01.Controllers
{
    public abstract class ABPUnity01ControllerBase: AbpController
    {
        protected ABPUnity01ControllerBase()
        {
            LocalizationSourceName = ABPUnity01Consts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
