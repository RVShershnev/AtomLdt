using Microsoft.AspNetCore.Components.WebAssembly.Authentication;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Syncfusion;
using Syncfusion.Blazor;
using Microsoft.JSInterop;
using System.Globalization;

namespace Atom.Culture.App.Client
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<Atom.Culture.App.Client.App>("#app");

            builder.Services.AddHttpClient("Atom.Culture.App.ServerAPI", client => client.BaseAddress = new Uri(builder.HostEnvironment.BaseAddress))
                .AddHttpMessageHandler<BaseAddressAuthorizationMessageHandler>();

            // Supply HttpClient instances that include access tokens when making requests to the server project
            builder.Services.AddScoped(sp => sp.GetRequiredService<IHttpClientFactory>().CreateClient("Atom.Culture.App.ServerAPI"));

            builder.Services.AddApiAuthorization();

            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("@31382e332e30SGGeGj0ewaVI/T5WqH+MzFMRGZgfwmdNabaVV+aEBHI=");
            builder.Services.AddSyncfusionBlazor();

            #region Localization
            //// Register the Syncfusion locale service to customize the  SyncfusionBlazor component locale culture
            //builder.Services.AddSingleton(typeof(ISyncfusionStringLocalizer), typeof(SyncfusionLocalizer));

            //// Set the default culture of the application
            //CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("en-US");
            //CultureInfo.DefaultThreadCurrentUICulture = new CultureInfo("en-US");

            //// Get the modified culture from culture switcher
            //var host = builder.Build();
            //var jsInterop = host.Services.GetRequiredService<IJSRuntime>();
            //var result = await jsInterop.InvokeAsync<string>("cultureInfo.get");
            //if (result != null)
            //{
            //    // Set the culture from culture switcher
            //    var culture = new CultureInfo(result);
            //    CultureInfo.DefaultThreadCurrentCulture = culture;
            //    CultureInfo.DefaultThreadCurrentUICulture = culture;
            //}
            #endregion

            await builder.Build().RunAsync();
        }
    }
}
