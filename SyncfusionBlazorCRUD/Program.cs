using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using SyncfusionBlazorCRUD;
using Syncfusion.Blazor;
using SyncfusionBlazorCRUD.Shared;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("Ngo9BigBOggjHTQxAR8/V1JEaF1cWmhIfkx1WmFZfVtgdVdMZV9bQHFPMyBoS35Rc0VqWXtecHRWQmleUkN/VEFd");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddSingleton<EmployeeService>();
builder.Services.AddSyncfusionBlazor(); // Add Syncfusion Blazor

await builder.Build().RunAsync();

