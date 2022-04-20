using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace Something.Controllers
{
    public abstract class SomethingControllerBase: AbpController
    {
        protected SomethingControllerBase()
        {
            LocalizationSourceName = SomethingConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
