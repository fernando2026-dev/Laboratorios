using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("=====Ejercicio 1=====");

        //Datos de la nave
        string modelo = "NASA";
        int capacidadCarga = 3000;        
        float nivelCombustible = 80.5f;  
        bool motorSaltoActivo = true;

        //Mostrar los datos de la neve en ua sola linea 
        Console.WriteLine("Modelo: " + modelo +
                  " | Capacidad: " + capacidadCarga +
                  " | Combustible: " + nivelCombustible + "%" +
                  " | Motor de salto activo: " + motorSaltoActivo);


        Console.WriteLine("=====Ejercicio 2=====");

        //expancion de memoria 
        short sensoresActivos = 128;
        int registroProcesador;

        registroProcesador = sensoresActivos;

        double precisionTotal = registroProcesador;

        Console.WriteLine("Precisión total: " + precisionTotal);


        Console.WriteLine("=====Ejercicio 3=====");

        double energiaGenerada = 987.65;
        int energiaLimitada;

        energiaLimitada = (int)energiaGenerada;

        Console.WriteLine("Energia generada: " + energiaGenerada);
        Console.WriteLine("Energia limitada (entero): " + energiaLimitada);

        Console.WriteLine("=====Ejercicio 4=====");

        Console.WriteLine("Ingrese la distancia al planeta mas cercano");
        string entradaRadar = Console.ReadLine();

        int distancia = int.Parse(entradaRadar);
        int resultadoFinal = distancia + 100;

        Console.WriteLine("Distancia con margen de seguridad: " + resultadoFinal);

    }
}

