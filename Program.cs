// See https://aka.ms/new-console-template for more information

using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

var myVar = "a";

Console.WriteLine("Hello, World!");

myVar = "b";
myVar = "c";

var myPoly = new[]
{
    new ParentA(),
    new ChildA(),
    new ChildB(),
};

// No seguro cast, asume que lo estas haciendo correctamente y va a arrojar un error sino es el mismo tipo
var ca = (ChildA) myPoly[0];
// Seguro cast
var ca2 = myPoly[1] as ChildA;
// No puedes convertir un padre en un hijo
var ca3 = myPoly[0] as ChildA;
// No puedes convertir una clase en otra
var ca4 = myPoly[1] as ChildA;
// Para saber si es el mismo tipo usamos is
var ca5 = myPoly[1] is ChildA
? myPoly[1] as ChildA
: new ChildA();

var builder = Host.CreateDefaultBuilder();
var host = builder.ConfigureServices(services =>
{
    services.AddTransient<IDependencyA>(x => {
         return new DependencyA();
         })
    .AddTransient<IDependencyB, DependencyB>()
    .AddTransient<IDependentClassA, DependentClassA>();
}
).Build();

var c = host.Services.GetService<IDependentClassA>();

Console.WriteLine("Hello, World");


