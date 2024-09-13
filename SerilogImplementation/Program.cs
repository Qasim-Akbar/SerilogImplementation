
using Serilog;

Log.Logger = new LoggerConfiguration()
    .WriteTo.Console()
    .CreateLogger();

Log.Information("Starting the application");
Log.Error("Error encountered!");
Log.Information("Shuting Down the application");

Log.CloseAndFlush();