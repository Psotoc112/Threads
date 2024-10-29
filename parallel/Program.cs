using parallel;
using System;
using System.Runtime.InteropServices;

// Instancia de ParallelController
ParallelController MyController = new ParallelController();

// Ejecucion del programa eimpresion de la respuesta 



foreach (string outputMessage in MyController.ProcessFile(Environment.GetCommandLineArgs()))
{
	Console.WriteLine(outputMessage);

};
Console.ReadLine();
