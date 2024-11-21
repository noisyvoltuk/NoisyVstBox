using Microsoft.Extensions.DependencyInjection;
using System;
using System.Windows.Forms;
using NoisyVstBox.Host.Services;

namespace NoisyVstBox.Host;

static class Program
{
    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
        var services = new ServiceCollection();

        // Register services
        services.AddSingleton<IRemoteIOService, RemoteIOService>(); // Registering a service
        services.AddSingleton<MainForm>();  // Registering the main form

        // Build the service provider
        var serviceProvider = services.BuildServiceProvider();

        // Run the application with DI
        Application.SetCompatibleTextRenderingDefault(false);
        Application.SetHighDpiMode(HighDpiMode.SystemAware);
        Application.EnableVisualStyles();


        Application.Run(serviceProvider.GetRequiredService<MainForm>());
        //
        //
      
       //Application.Run(new MainForm());
    }
}
