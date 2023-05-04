using ChainStringNumbersLibrary;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;


namespace ChainStringNumbersConsoleApp.IOC
{
    public static class Startup
    {
        public static IHostBuilder CreatHostBuilder()
        {

            return Host.CreateDefaultBuilder()
                .ConfigureServices(service =>
                    {
                        var checkTwoItems = new CheckTwoItems();
                        var checkNumbers = new CheckNumber();
                        var checkPositive = new CheckPositive();
                        checkTwoItems.SetSuccessor(checkNumbers);
                        checkNumbers.SetSuccessor(checkPositive);
                        service.AddSingleton<Validator>(_ => checkTwoItems);
                        service.AddSingleton<Splitter>();
                        service.AddSingleton<Handler>();

                    });
        }
    }
}
