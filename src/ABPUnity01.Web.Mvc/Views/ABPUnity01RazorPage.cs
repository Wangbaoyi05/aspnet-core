using Abp.AspNetCore.Mvc.Views;
using Abp.Runtime.Session;
using Microsoft.AspNetCore.Mvc.Razor.Internal;

namespace ABPUnity01.Web.Views
{
    public abstract class ABPUnity01RazorPage<TModel> : AbpRazorPage<TModel>
    {
        [RazorInject]
        public IAbpSession AbpSession { get; set; }

        protected ABPUnity01RazorPage()
        {
            LocalizationSourceName = ABPUnity01Consts.LocalizationSourceName;
        }
    }
}
