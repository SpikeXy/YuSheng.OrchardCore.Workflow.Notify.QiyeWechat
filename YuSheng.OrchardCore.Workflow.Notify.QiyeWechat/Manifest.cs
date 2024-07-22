using OrchardCore.Modules.Manifest;

[assembly: Module(
    Name = "YuSheng OrchardCore Workflow Notify QiyeWechat",
    Author = "spike",
    Website = "",
    Version = "0.0.1"
)]

[assembly: Feature(
    Id = "YuSheng OrchardCore Workflow Notify QiyeWechat",
    Name = "YuSheng OrchardCore Workflow Notify QiyeWechat",
    Description = "Provides qiyewechat notify ",
    Dependencies = new[] { "OrchardCore.Workflows" },
    Category = "Workflows"
)]
