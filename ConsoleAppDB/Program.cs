using ConsoleAppDB.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

var builder = Host.CreateDefaultBuilder().ConfigureServices(services =>
{


    services.AddDbContext<DataContext>(x=> x.UseSqlServer(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Projects\ConsoleAppDB\ConsoleAppDB\Data\database.mdf;Integrated Security=True;Connect Timeout=30"));


}).Build();
