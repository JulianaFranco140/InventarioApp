// ============================================================
// SISTEMA DE INVENTARIO - Clase 1.1
// Estado: Mensaje de bienvenida
// ============================================================

using System.Reflection;

var assembly = Assembly.GetExecutingAssembly();
var version = assembly.GetName().Version;

Console.WriteLine("==========================================");
Console.WriteLine("    SISTEMA DE GESTIÓN DE INVENTARIO      ");
Console.WriteLine("==========================================");
Console.WriteLine();
Console.WriteLine($"Versión: {version}");
Console.WriteLine($"Plataforma: {Environment.OSVersion}");
Console.WriteLine($".NET Version: {Environment.Version}");
Console.WriteLine();
Console.WriteLine($"Estado: Proyecto inicializado");
Console.WriteLine();
Console.WriteLine("Estructura del proyecto");
Console.WriteLine("Configuración .csproj");
Console.WriteLine("Carpeta /src creada");
Console.WriteLine("Metadatos configurados");
Console.WriteLine();
Console.WriteLine("Próximo paso: Agregar argumnetos CLI");
Console.WriteLine();
Console.WriteLine("Estrcutura del proyecto:");
Console.WriteLine("     /InventarioApp");
Console.WriteLine("     |--Program.cs");
Console.WriteLine("     |--InventarioApp.csproj");
Console.WriteLine("     |--.gitignore");
Console.WriteLine("     |--README.md");
Console.WriteLine("     |--src/");
Console.WriteLine("         |--models/");
Console.WriteLine("             |--.gitkeep");
Console.WriteLine("Próximo paso: Checkpoint")





