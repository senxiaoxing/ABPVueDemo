using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace ABPVue.Controllers
{
    public abstract class ABPVueControllerBase: AbpController
    {
        protected ABPVueControllerBase()
        {
            LocalizationSourceName = ABPVueConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
