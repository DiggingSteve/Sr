using Abp.Web.Mvc.Views;

namespace Sr.Web.Views
{
    public abstract class SrWebViewPageBase : SrWebViewPageBase<dynamic>
    {

    }

    public abstract class SrWebViewPageBase<TModel> : AbpWebViewPage<TModel>
    {
        protected SrWebViewPageBase()
        {
            LocalizationSourceName = SrConsts.LocalizationSourceName;
        }
    }
}