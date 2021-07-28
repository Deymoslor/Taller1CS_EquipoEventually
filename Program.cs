using System;

namespace taller1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Punto 1.
            // int num1, num2, num3;

            // Console.WriteLine("Ingrese a continuacion 3 numeros porfavor:");
            // num1 = int.Parse(Console.ReadLine());
            // num2 = int.Parse(Console.ReadLine());
            // num3 = int.Parse(Console.ReadLine());

            // Console.WriteLine($"La suma de estos es: {num1 + num2 + num3}.");

            //Punto 4.
            //Codigo.

            //Punto 5.

            // double distancia, tiempo;

            // Console.WriteLine("Ingrese la distancia en KiloMetros recorrida por el coche:");
            // distancia = double.Parse(Console.ReadLine());
            // Console.WriteLine("Ingrese el tiempo en horas que le tomo al coche recorrer el trayecto:");
            // tiempo = double.Parse(Console.ReadLine());

            // Console.WriteLine($"La velocidad alcanzada durante el trayecto fue de: {distancia / tiempo} Km/H");

            //Punto 9.

            // double sueldoB = 980000, ventas = 3, comision = 0.1, totalComi;


            // Console.WriteLine($"El total de dinero en comision es de: ${totalComi = (sueldoB * comision) * ventas}.");

            // Console.WriteLine($"El total de su sueldo mas comisiones es de: ${ sueldoB + totalComi }.");

            //Punto 13.

            // int horas;
            // double valorH, salario;

            // Console.WriteLine("Ingrese porfavor las horas trabajadas:");
            // horas = int.Parse(Console.ReadLine());
            // Console.WriteLine("Ingrese porfavor el valor de la hora trabajada:");
            // valorH = int.Parse(Console.ReadLine());

            // Console.WriteLine($"Su salario es: { salario = horas * valorH}");

            //Punto 17.


            // double salarioE, ahorroM, eps, fondoP;

            // Console.WriteLine("Ingrese porfavor el salario del empleado: ");
            // salarioE = double.Parse(Console.ReadLine());
            // Console.WriteLine("Ingrese porfavor el ahorro mensual programado del empleado: ");
            // ahorroM = double.Parse(Console.ReadLine());
            // eps = salarioE * 0.125;
            // fondoP = salarioE * 0.16;

            // Console.WriteLine("----------- COLILLA DE PAGO -----------");
            // Console.WriteLine("Salario Base: " + salarioE + "\n");
            // Console.WriteLine("Valor de Ahorro mensual: " + ahorroM + "\n");
            // Console.WriteLine("El total para el aporte de la salud es de: " + eps + "\n");
            // Console.WriteLine("El total para el aporte para el fondo de pensiones: " + fondoP + "\n");

            // Console.WriteLine("-------------------------------------------------------");
            // Console.WriteLine("-------------------------------------------------------" + "\n");
            // Console.WriteLine("El total del pago es de: $" + (((salarioE - ahorroM) - eps) - fondoP));
            // Console.WriteLine("FIN");

            //Punto 21.

            int anno;
            String nombre, direccion;

            Console.Write("Ingrese porfavor su nombre: ");
            nombre = Console.ReadLine();
            Console.Write("Ingrese porfavor la direccion de su residencia: ");
            direccion = Console.ReadLine();

            Console.Write("Ingrese porfavor el año de su nacimiento: ");
            anno = int.Parse(Console.ReadLine());

            Console.WriteLine($"Buenas { nombre }, su direccion es [{ direccion }] con edad de { 2021 - anno } años");

        }
    }
}
