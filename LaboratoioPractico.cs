using System;

namespace MyApp// Note: actual namespace depends on the project name.
{
    internal class Program
    {
         static void Main(string[] args)
        {
            // declaracion de varibales de texto
        string? departamento ;
        string? municipio;
        string? ciudad;

        // Declaracion de variables de texto desde codigo
        string? coloniaDondeVive = "    Barrio el centro ";
        string? colorCasa = "cafe claro";

    
        // Declaracion de variables de tipo enteras desde codigo
        int añosDeResidencia = 11 ;
        int edadActual = 23;

       

        // Declaracion de variables de tiempo o tiempo
        DateTime FechaActual = DateTime.Now ;
        DateTime FechaEspecifica = new DateTime(2000, 4, 2 ,8 , 34, 00);



        //obtencion de datos desde la terminal
        Console.WriteLine("ingrese su departamento:");
        departamento = Convert.ToString(Console.ReadLine());
        Console.WriteLine();

        Console.WriteLine("ingrese su munipio:");
        municipio = Convert.ToString(Console.ReadLine());
        Console.WriteLine();

        Console.WriteLine("ingrese su ciudad:");
        ciudad = Convert.ToString(Console.ReadLine());
        Console.WriteLine();


        // Impresion de datos
        Console.WriteLine ("Su Departamento es : " + departamento);
        Console.WriteLine ("Su municipio  es: " + municipio);
        Console.WriteLine ("Su ciudad es es: " + ciudad);
        Console.WriteLine ("La colonia donde vive es: " + coloniaDondeVive);
        Console.WriteLine ("es color de su casa es: " + colorCasa);
        Console.WriteLine ("Los años que a vivido en esa casa son: " + añosDeResidencia);
        Console.WriteLine ("su edad actual es " + edadActual);   
        Console.WriteLine ("******************Fin de impresion***********************");


        Console.WriteLine ("***********************Inicio de impresion*************************");
        // Aplicacion de funciones en cadena

        // Funcion de comparacion cadenas de texto
        bool cadenaComparativa = departamento == municipio;

        // Funcion concatenado
        string? cadenaConcatenada = municipio + " " + ciudad ;

        //funcion limpiado de cadena
        string? cadenaLimpia = coloniaDondeVive.Trim();

        // Funcion de mayuscula
        string? funcionMayuscula1 = coloniaDondeVive.ToUpper();

        // Funcion de tamaño de cadena
        int llongitudCdena1 = colorCasa.Length;
        int llongitudCdena2 = coloniaDondeVive.Length;

        //Formateo de fecha
        string fechaFormateada = FechaEspecifica.ToString ("dd/mm/yyyy");
        string fechaFormateada2 = FechaActual.ToString ("dd/mm/yyyy");

        //adicionar 2 semanas
        DateTime fechaSumada = FechaActual.AddDays(14);
        DateTime fechaSumada2 = FechaEspecifica.AddDays(14);




        Console.WriteLine ("Comparacion: "+ cadenaComparativa);
        Console.WriteLine ("Mayuscula Colonia donde vivo: "+ funcionMayuscula1);
        Console.WriteLine ("Concatenacion: "+ cadenaConcatenada);
        Console.WriteLine ("La cadena limpia se veria asi: "+ cadenaLimpia);
        Console.WriteLine ("La longitus de datos de el color de casa es: "+ llongitudCdena1);
        Console.WriteLine ("La longitus de datos de la colonia donde vivo es: "+ llongitudCdena2);
        Console.WriteLine ("La fecha y tiempo de impresion de datos es " + FechaActual);
        Console.WriteLine ("Su fecha de nacimiento es : " + FechaEspecifica);
        Console.WriteLine ("Fecha actual + Suma de 2 semanas " + fechaSumada);
        Console.WriteLine ("Fecha especifica + Suma de 2 semanas: " + fechaSumada2);
        Console.WriteLine (FechaActual > FechaEspecifica);
        Console.WriteLine (FechaActual < FechaEspecifica);
        Console.WriteLine ("*****************Fin de la impresion********************");
        }
    }
}
//AutoEvaluacion = 10;