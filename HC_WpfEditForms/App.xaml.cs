using Azure.AI.OpenAI;
using DevExpress.AIIntegration;
using DevExpress.Xpf.Core;
using Microsoft.Extensions.AI;
using System;
using System.Runtime;
using System.Windows;

namespace HC_WpfEditForms;

/// <summary>
/// Interaction logic for App.xaml
/// </summary>
public partial class App : Application
{
    static App()
    {
        CompatibilitySettings.UseLightweightThemes = true;
        //#if (shell == none)
        ApplicationThemeHelper.Preload(PreloadCategories.Core);
        //#endif
        ApplicationThemeHelper.ApplicationThemeName = LightweightTheme.Win11Light.Name;

        //Enable Multi Core JIT to improve startup performance
        ProfileOptimization.SetProfileRoot(AppContext.BaseDirectory);
        ProfileOptimization.StartProfile("Startup.Profile");

        ClearAutomationEventsHelper.IsEnabled = false;

        //IChatClient asChatClient = new AzureOpenAIClient(new Uri("[YOUR AZURE ENDPOINT URL]"),
        //   new System.ClientModel.ApiKeyCredential("[YOUR KEY]"))
        //   .AsChatClient("[YOUR MODEL NAME]");
        //AIExtensionsContainerDesktop.Default.RegisterChatClient(asChatClient);
    }


}

