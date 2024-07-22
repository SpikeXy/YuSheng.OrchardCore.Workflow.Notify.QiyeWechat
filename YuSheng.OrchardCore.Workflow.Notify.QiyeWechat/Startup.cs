using Microsoft.Extensions.DependencyInjection;
using OrchardCore.Modules;
using OrchardCore.Workflows.Helpers;
using YuSheng.OrchardCore.Workflow.Notify.QiyeWechat.Activities;
using YuSheng.OrchardCore.Workflow.Notify.QiyeWechat.Drivers;

namespace YuSheng.OrchardCore.Workflow.Notify.QiyeWechat
{
    [Feature("YuSheng.OrchardCore.Workflow.Notify.QiyeWechat")]
    public class Startup : StartupBase
    {
        public override void ConfigureServices(IServiceCollection services)
        {

            services.AddActivity<NotifyQiyeWechatTask, NotifyQiyeWechatTaskDisplayDriver>(); ;

        }
    }
}
