using Abp.Web.Mvc.Views;

namespace LearnABP.Web.Views
{
    public abstract class LearnABPWebViewPageBase : LearnABPWebViewPageBase<dynamic>
    {

    }

    public abstract class LearnABPWebViewPageBase<TModel> : AbpWebViewPage<TModel>
    {
        protected LearnABPWebViewPageBase()
        {
            LocalizationSourceName = LearnABPConsts.LocalizationSourceName;
        }
    }
}