// See https://aka.ms/new-console-template for more information

using PersonasYGrupos.Models;

Console.WriteLine("Hello, World!");
IListaBuilder MiGenerador = new InicialBuilder();
var elementos = MiGenerador.dameEmpleados();


//Mostrar todos los empleados que son chicos.
//Mostrar todos los empleados que tienen más de 16 años.
//Mostrar todos los empleados que son chicas, ordenado por FName.
//Mostrar los empleados cuyo nombre comience por j y sea chico, ordenar por edad
//Sacar los empleados agrupados por Sex.
//Sacar los empleados ordenados por FName y Agrupados por Sex.

Console.WriteLine("1. Mostrar todos los empleados que son chicos.");

var SoloChicos = from empleados in elementos
    where empleados.Sex == 'M'
    select empleados;

foreach (var chico in SoloChicos)
{
    Console.WriteLine($"Id: {chico.ID}, Nombre: {chico.FName}, {chico.MName}, {chico.LName}, Nacimiento: {chico.DOB}, Sexo: {chico.Sex}");
}

Console.WriteLine("2. Mostrar todos los empleados que tienen más de 16 años.");
var Mas16 = from empleados in elementos
    where empleados.DOB.AddYears(-16) > DateTime.Now
    select empleados;

foreach (var empleado in Mas16)
{
    Console.WriteLine($"Id: {empleado.ID}, Nombre: {empleado.FName}, {empleado.MName}, {empleado.LName}, Nacimiento: {empleado.DOB}, Sexo: {empleado.Sex}");
}
Console.WriteLine("3. Mostrar todos los empleados que son chicas, ordenado por FName.");
var Chicas = from empleados in elementos
    where empleados.Sex == 'F'
    orderby empleados.FName
    select empleados;

foreach (var empleado in Chicas)
{
    Console.WriteLine($"Id: {empleado.ID}, Nombre: {empleado.FName}, {empleado.MName}, {empleado.LName}, Nacimiento: {empleado.DOB}, Sexo: {empleado.Sex}");
}
Console.WriteLine("4. Mostrar los empleados cuyo nombre comience por j y sea chico, ordenar por edad.");
var EmpiezaJ = from empleados in elementos
    where empleados.FName.ToUpper().StartsWith("J")
    orderby empleados.DOB
    select empleados;

foreach (var empleado in EmpiezaJ)
{
    Console.WriteLine($"Id: {empleado.ID}, Nombre: {empleado.FName}, {empleado.MName}, {empleado.LName}, Nacimiento: {empleado.DOB}, Sexo: {empleado.Sex}");
}
Console.WriteLine("5. Sacar los empleados agrupados por Sex.");
var GroupBySex = from empleados in elementos
    group empleados by empleados.Sex into grupo
    select grupo;

foreach (var grupo in GroupBySex)
{
    Console.WriteLine($"Agrupado por sexo: {grupo.Key}");
    foreach (var empleado in grupo)
    {
        Console.WriteLine($"Id: {empleado.ID}, Nombre: {empleado.FName}, {empleado.MName}, {empleado.LName}, Nacimiento: {empleado.DOB}, Sexo: {empleado.Sex}");
    }
}
Console.WriteLine("6. Sacar los empleados ordenados por FName y Agrupados por Sex.");

var GroupByOrdenado = from empleados in elementos
    orderby empleados.FName
    group empleados by empleados.Sex into grupo
    select grupo;

foreach (var grupo in GroupByOrdenado)
{
    Console.WriteLine($"Agrupado por sexo: {grupo.Key}");
    foreach (var empleado in grupo)
    {
        Console.WriteLine($"Id: {empleado.ID}, Nombre: {empleado.FName}, {empleado.MName}, {empleado.LName}, Nacimiento: {empleado.DOB}, Sexo: {empleado.Sex}");
    }
}