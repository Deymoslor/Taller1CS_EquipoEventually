using System;
using System.Collections;

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

            //Punto 2.
            // decimal num1, num2, suma, resta, multiplicacion, division;

            // Console.Write("Ingrese número 1: ");
            // num1 = decimal.Parse(Console.ReadLine());

            // Console.Write("Ingrese número 2: ");
            // num2 = decimal.Parse(Console.ReadLine());

            // suma = num1 + num2;
            // resta = num1 - num2;
            // multiplicacion = num1 * num2;
            // division = num1 / num2;

            // Console.Write($"\nEl número 1 es: {num1} y el número 2 es: {num2}.\n\nLa suma de los dos números es: {suma}.\nLa resta de los dos números es: {resta}.\nLa multiplicación de los dos números es: {multiplicacion}.\nLa división de los dos números es: {division}.\n");
            // ----- PUNTO 3 -----
            // Console.WriteLine("");
            // Console.WriteLine("Ingrese su nota: ");
            // float n1 = float.Parse(Console.ReadLine());
            // Console.WriteLine("Ingrese su nota: ");
            // float n2 = float.Parse(Console.ReadLine());
            // Console.WriteLine("Ingrese su nota: ");
            // float n3 = float.Parse(Console.ReadLine());
            // float nt = (n1 + n2 + n3) / 3;
            // Console.WriteLine("La nota definitiva es: " + nt);
            // Console.WriteLine("");
            //Punto 4.
            

            //Punto 5.

            // double distancia, tiempo;

            // Console.WriteLine("Ingrese la distancia en KiloMetros recorrida por el coche:");
            // distancia = double.Parse(Console.ReadLine());
            // Console.WriteLine("Ingrese el tiempo en horas que le tomo al coche recorrer el trayecto:");
            // tiempo = double.Parse(Console.ReadLine());

            // Console.WriteLine($"La velocidad alcanzada durante el trayecto fue de: {distancia / tiempo} Km/H");

            //Punto 6.
            // decimal valor,iva,total,descuento,val;
            // String respuesta;

            // Console.Write("Ingrese el valor de la compra: ");
            // valor = decimal.Parse(Console.ReadLine());

            // Console.Write("Autoriza el descuento: ");
            // respuesta = Console.ReadLine();

            // if ((respuesta == "SI")||(respuesta == "Si")|| (respuesta == "si"))
            // {
            //     descuento = valor*0.10m;
            //     val = valor - descuento;
            //     iva = val * 0.19m;
            //     total = val + iva;

            //     Console.Write($"\nEl valor de la compra es de: ${valor.ToString("N0")}, al cual se le autorizó un descuento de ${descuento.ToString("N0")}, el Iva de este producto es de: {iva.ToString("N0")}, lo cual da para un valor a pagar de ${total.ToString("N0")}.");
            // }
            // else
            // {
            //     iva = valor * 0.19m;
            //     total = valor + iva;

            //     Console.Write($"\nEl valor de la compra es de: ${valor.ToString("N0")}, el cual tiene un iva de ${iva.ToString("N0")}; para un total a pagar de  ${total.ToString("N0")}");
            // }
            // ----- PUNTO 7 -----
            // Console.WriteLine("");
            // int hora, minuto, segundo;
            // Console.WriteLine("Ingrese la hora: ");
            // hora = int.Parse(Console.ReadLine());
            // Console.WriteLine("Ingrese los minutos: ");
            // minuto = int.Parse(Console.ReadLine());
            // Console.WriteLine("Ingrese los segundos: ");
            // segundo = int.Parse(Console.ReadLine());
            // hora = hora * 60;
            // minuto = (minuto * 60) + (hora * 60);
            // segundo = segundo + minuto;
            // Console.WriteLine("");
            // Console.WriteLine("El total de segundos son: " + segundo + "s");
            // Console.WriteLine("");
            //Punto 9.

            // double sueldoB = 980000, ventas = 3, comision = 0.1, totalComi;


            // Console.WriteLine($"El total de dinero en comision es de: ${totalComi = (sueldoB * comision) * ventas}.");

            // Console.WriteLine($"El total de su sueldo mas comisiones es de: ${ sueldoB + totalComi }.");

            //Punto 10.
            // decimal valor, total,descuento;
            // Console.Write("Ingrese el valor de la compra: ");
            // valor = decimal.Parse(Console.ReadLine());
            // descuento = valor * 0.15m;
            // total = valor - descuento;

            // Console.Write($"\nEl valor de su compra es de ${valor.ToString("N0")}, el cual tiene un descuento de ${descuento.ToString("N0")}; lo cual da un valor a pagar de ${total.ToString("N0")}.\n");
            // ----- PUNTO 11 -----
            // Console.WriteLine("");
            // Console.WriteLine("Ingrese su nota parcial: ");
            // float nota1 = float.Parse(Console.ReadLine());
            // Console.WriteLine("Ingrese su nota parcial: ");
            // float nota2 = float.Parse(Console.ReadLine());
            // Console.WriteLine("Ingrese su nota parcial: ");
            // float nota3 = float.Parse(Console.ReadLine());
            // Console.WriteLine("Ingrese la nota del examen final: ");
            // float ef = float.Parse(Console.ReadLine());
            // Console.WriteLine("Ingrese la nota del trabajo final: ");
            // float tf = float.Parse(Console.ReadLine());
            // double npf = ((nota1 + nota2 + nota3) / 3) * 0.55;
            // double etf = ef * 0.3;
            // double ttf = tf * 0.15;
            // Console.WriteLine("Su nota final es: " + (npf + etf + ttf));
            // Console.WriteLine("");

            //Punto 13.

            // int horas;
            // double valorH, salario;

            // Console.WriteLine("Ingrese porfavor las horas trabajadas:");
            // horas = int.Parse(Console.ReadLine());
            // Console.WriteLine("Ingrese porfavor el valor de la hora trabajada:");
            // valorH = int.Parse(Console.ReadLine());

            // Console.WriteLine($"Su salario es: { salario = horas * valorH}");

            //Punto 14.

            // ArrayList articulos = new ArrayList();
            // ArrayList valor = new ArrayList();
            // ArrayList selecionado = new ArrayList();
            // int cant;
            // decimal iva, total = 0;

            // Console.Write("Ingrese cuantos articulos desea agregar: ");
            // cant = int.Parse(Console.ReadLine());

            // articulos.Add("Sepillo de dientes");
            // articulos.Add("Colino");
            // articulos.Add("Jabón");
            // articulos.Add("Desodrante");
            // articulos.Add("Crema para afeitar");
            // articulos.Add("Cuchilla de afeitar");

            // valor.Add(1000);
            // valor.Add(2000);
            // valor.Add(3000);
            // valor.Add(10000);
            // valor.Add(12000);
            // valor.Add(5000);


            // Console.Write("          Articulos          ");
            // for ( int i = 0; i < articulos.Count; i++)
            // {
            //     Console.Write($"\n{i+1}. {articulos[i]}      ${((Convert.ToDecimal(valor[i])).ToString("N0"))}");
            // }

            // for (int i = 0; i < cant; i++)
            // {
            //     Console.Write($"\nIngrese el número del {i + 1} articulo a agregar: ");
            //     selecionado.Add((int.Parse(Console.ReadLine()))-1);
            // }

            // Console.Write("Los productos que usted adquirio: \n");
            // for (int i = 0; i < cant; i++)
            // {
            //     iva = (Convert.ToDecimal(valor[i])) * 0.19m;
            //     Console.Write($"\n El {i+1} articulo es {articulos[i]} con un valor de ${((Convert.ToDecimal(valor[i])).ToString("N0"))} y con un iva de ${iva.ToString("N0")} para un total de ${((Convert.ToDecimal(valor[i]))+iva).ToString("N0")}.");
            //     total = total + ((Convert.ToDecimal(valor[i])) + iva);
            // }
            // Console.Write($"\nPara pagar un total de ${total.ToString("N0")}.\n");

            // ----- PUNTO 15 -----
            // Console.WriteLine("");
            // double tt = 0, tta = 0;
            // String pregunta;
            // do
            // {
            //     Console.WriteLine("Ingrese el precio del producto: ");
            //     tt = double.Parse(Console.ReadLine());
            //     Console.WriteLine("¿Quieres volver a ingresar? R// ");
            //     pregunta = Console.ReadLine();
            //     tta = tta + tt;
            // } while (pregunta.Equals("si"));
            // tta = (tta * 0.19) + tta;
            // Console.WriteLine("");
            // Console.WriteLine("El total a pagar: " + tta);
            // Console.WriteLine("");
            // Console.WriteLine("Ingrese el dinero en efectivo: ");
            // double r = double.Parse(Console.ReadLine());
            // Console.WriteLine("Su cambio es: " + (tta - r));
            // Console.WriteLine("");
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

            //Punto 18.

            // decimal valor, primera, segunda, tercera, cuarta;

            // Console.Write("Ingrese el valor de la mátricula: ");
            // valor = decimal.Parse(Console.ReadLine());

            // primera = valor * 0.40m;
            // segunda = valor * 0.25m;
            // tercera = valor * 0.20m;
            // cuarta = valor * 0.15m;

            // Console.Write($"\nLas cuotas que deben pagar el estudiante son:\n  - Primera cuota (40%): ${primera.ToString("N0")}\n  - segunda cuota (25%): ${segunda.ToString("N0")}\n  - Tercera cuota (20%): ${tercera.ToString("N0")}\n  - Cuarta cuota (15%): ${cuarta.ToString("N0")}\n  **El valor a pagar es de ${valor.ToString("N0")}**");

            // ----- PUNTO 19 -----
            // Console.WriteLine("");
            // Console.WriteLine("Ingrese su nombre: ");
            // String name = Console.ReadLine();
            // Console.WriteLine("Ingrese su programa de formaciòn: ");
            // String formacion = Console.ReadLine();
            // Console.WriteLine("Ingrese su ficha de formaciòn: ");
            // String ficha = Console.ReadLine();
            // Console.WriteLine("Ingrese la nota: ");
            // double nn1 = double.Parse(Console.ReadLine());
            // Console.WriteLine("Ingrese la nota: ");
            // double nn2 = double.Parse(Console.ReadLine());
            // Console.WriteLine("Ingrese la nota: ");
            // double nn3 = double.Parse(Console.ReadLine());
            // Console.WriteLine("Ingrese la nota: ");
            // double nn4 = double.Parse(Console.ReadLine());
            // Console.WriteLine("Ingrese la nota: ");
            // double nn5 = double.Parse(Console.ReadLine());
            // double nnt = ((nn1 + nn2 + nn3 + nn4 + nn5) / 5);
            // Console.WriteLine("");
            // Console.WriteLine("NOMBRE:                " + name);
            // Console.WriteLine("PROGRAMA DE FORMACIÒN: " + formacion);
            // Console.WriteLine("FICHA DE FORMACIÒN:    " + ficha);
            // Console.WriteLine("NOTA FINAL:            " + nnt);
            // Console.WriteLine("");
            //Punto 21.

            // int anno;
            // String nombre, direccion;

            // Console.Write("Ingrese porfavor su nombre: ");
            // nombre = Console.ReadLine();
            // Console.Write("Ingrese porfavor la direccion de su residencia: ");
            // direccion = Console.ReadLine();

            // Console.Write("Ingrese porfavor el año de su nacimiento: ");
            // anno = int.Parse(Console.ReadLine());

            // Console.WriteLine($"Buenas { nombre }, su direccion es [{ direccion }] con edad de { 2021 - anno } años");


            //Punto 22.
            // int opcion, litros;
            // decimal  tiempo;

            // Console.WriteLine("Menú");
            // Console.WriteLine("  1. Saber el tiempo de llenado del balde.\n  2. Saber el tamaño del balde.\nIngrese la opción que desea: ");
            // opcion = int.Parse(Console.ReadLine());

            // switch (opcion)
            // {
            //     case 1:
            //         Console.Write("Ingrese el tamaño del balde en litros, los baldes disponibles son: 1 litro, 3 litros, 5 litros.");
            //         litros = int.Parse(Console.ReadLine());

            //         if ((litros ==1) || (litros == 3) || (litros == 5))
            //         {
            //             switch (litros)
            //             {
            //                 case 1:
            //                     Console.Write($"El balde es de {litros} litros, el cual se llena en una hora y media.");
            //                     break;
            //                 case 3:
            //                     Console.Write($"El balde es de {litros} litros, el cual se llena en tres horas.");
            //                     break;
            //                 case 5:
            //                     Console.Write($"El balde es de {litros} litros, el cual se llena en cuatro horas y media.");
            //                     break;
            //             }
                        
            //         }
            //         else
            //         {
            //             Console.Write("La selección que ha ingresado no es valida.");
            //         }
            //         break;
            //     case 2:
            //         Console.Write("Ingrese la opción de tiempo en que se llena:\n 1.1.30\n 2. 3\n . 4.30:");
            //         tiempo = decimal.Parse(Console.ReadLine());

            //         switch (tiempo)
            //         {
            //             case 1:
            //                 Console.Write($"El balde es de un litro.");
            //                 break;
            //             case 2:
            //                 Console.Write($"El balde es de  tres litros.");
            //                 break;
            //             case 3:
            //                 Console.Write($"El balde es de  cinco litros.");
            //                 break;
            //         }
            //         break;
            // }
            // ----- PUNTO 23 -----
            // Console.WriteLine("");
            // Console.WriteLine("Ingrese la cantidad de metros que decea subir: ");
            // float mm = float.Parse(Console.ReadLine());
            // float hh = (float)0.714285714286;
            // float mh = mm * hh;
            // Console.WriteLine("El tiempo que tardarà es: " + mh + " horas");
        }
    }
}
