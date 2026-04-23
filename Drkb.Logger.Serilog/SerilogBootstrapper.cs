using Serilog;

namespace Drkb.Logger.Serilog;

public static class SerilogBootstrapper
{
    public static void CreateBootstrapLogger()
    {
        Log.Logger = new LoggerConfiguration()
            .WriteTo.Console()
            .CreateBootstrapLogger();
    }
}