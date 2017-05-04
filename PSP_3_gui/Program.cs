using PSP_3_control;
using System;

namespace PSP_3_gui
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("************************************************");
            Console.WriteLine("*** PSP3 - Tabla de tamaño relativo          ***");
            Console.WriteLine("************************************************");
            Console.WriteLine("Para procesar un conjunto de valores X y Y debe");
            Console.WriteLine("crear un archivo de texto con la extención .txt");
            Console.WriteLine(@"y guardarlos en el directorio C:\PSP3");
            Console.WriteLine(@"La estructura del archivo debe ser:");
            Console.WriteLine(@"ValorX;ValorY");
            Console.WriteLine(@"Ejemplo:");
            Console.WriteLine(@"1;5");
            Console.WriteLine(@"4;6");
            Console.WriteLine(@"6,7;7,7");
            Console.WriteLine("---Presione una tecla para iniciar el procesamiento---");
            Console.ReadKey();

            ControlArchivo.LeerDirectorio(@"C:\PSP3");
            Console.ReadKey();
        }
    }
}
