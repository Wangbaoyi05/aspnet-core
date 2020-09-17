using Abp.AspNetCore.Mvc.ViewComponents;

namespace ABPUnity01.Web.Views
{
    public abstract class ABPUnity01ViewComponent : AbpViewComponent
    {
        protected ABPUnity01ViewComponent()
        {
            LocalizationSourceName = ABPUnity01Consts.LocalizationSourceName;
        }
    }
}
