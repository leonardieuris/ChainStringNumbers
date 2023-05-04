using ChainStringNumbersConsoleApp.IOC;
using ChainStringNumbersLibrary;
using Microsoft.Extensions.DependencyInjection;

var host = Startup.CreatHostBuilder().Build();
var handler = host.Services.GetService<Handler>();

Console.WriteLine($"4,5=>{handler?.GetResult("4,5")}");

//Console.WriteLine($"4,5=>{handler.GetResult("4,-5")}");
