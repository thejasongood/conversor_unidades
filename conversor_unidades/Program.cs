using System;

namespace ConversorUnidades
{
    public class Program
    {
        public static void Main()
        {
            string seleccion;

            do
            {
                seleccion = ObtenerOpcion();

                switch (seleccion)
                {
                    case "3":
                        Console.Write("Ingrese los kilómetros: ");
                        bool correcto3 = decimal.TryParse(Console.ReadLine(), out decimal kilometros);

                        if (correcto3)
                        {
                            decimal millas = KmAMillas(kilometros);
                            MostrarResultado(kilometros, millas, "km", "millas");
                        }
                        else
                        {
                            Console.WriteLine("Dato inválido.");
                        }
                        break;

                    case "1":
                        Console.Write("Ingrese los grados Celsius: ");
                        bool correcto1 = decimal.TryParse(Console.ReadLine(), out decimal celsius);

                        if (correcto1)
                        {
                            decimal fahrenheit = CelsiusAFahrenheit(celsius);
                            MostrarResultado(celsius, fahrenheit, "°C", "°F");
                        }
                        else
                        {
                            Console.WriteLine("Dato inválido.");
                        }
                        break;

                    case "4":
                        Console.Write("Ingrese las millas: ");
                        bool correcto4 = decimal.TryParse(Console.ReadLine(), out decimal millasIngresadas);

                        if (correcto4)
                        {
                            decimal kilometrosConvertidos = MillasAKm(millasIngresadas);
                            MostrarResultado(
                                millasIngresadas,
                                kilometrosConvertidos,
                                "millas",
                                "km");
                        }
                        else
                        {
                            Console.WriteLine("Dato inválido.");
                        }
                        break;

                    case "2":
                        Console.Write("Ingrese los grados Fahrenheit: ");
                        bool correcto2 = decimal.TryParse(Console.ReadLine(), out decimal fahrenheitIngresados);

                        if (correcto2)
                        {
                            decimal celsiusConvertidos = FahrenheitACelsius(fahrenheitIngresados);
                            MostrarResultado(
                                fahrenheitIngresados,
                                celsiusConvertidos,
                                "°F",
                                "°C");
                        }
                        else
                        {
                            Console.WriteLine("Dato inválido.");
                        }
                        break;

                    case "5":
                        Console.WriteLine("Saliendo del sistema...");
                        break;

                    default:
                        Console.WriteLine("Opción no válida.");
                        break;
                }

            } while (seleccion != "5");
        }

        private static string ObtenerOpcion()
        {
            Console.WriteLine();
            Console.WriteLine("=== CONVERSOR DE UNIDADES ===");
            Console.WriteLine("1. Celsius a Fahrenheit");
            Console.WriteLine("2. Fahrenheit a Celsius");
            Console.WriteLine("3. Kilómetros a Millas");
            Console.WriteLine("4. Millas a Kilómetros");
            Console.WriteLine("5. Salir");
            Console.Write("Seleccione una opción: ");

            return Console.ReadLine();
        }

        private static decimal CelsiusAFahrenheit(decimal celsius)
        {
            return (celsius * 9 / 5) + 32;
        }

        private static decimal FahrenheitACelsius(decimal fahrenheit)
        {
            return (fahrenheit - 32) * 5 / 9;
        }

        private static decimal KmAMillas(decimal kilometros)
        {
            return kilometros * 0.621371m;
        }

        private static decimal MillasAKm(decimal millas)
        {
            return millas * 1.60934m;
        }

        private static void MostrarResultado(
            decimal valorInicial,
            decimal valorFinal,
            string unidadInicial,
            string unidadFinal)
        {
            Console.WriteLine(
                $"{valorInicial:N2} {unidadInicial} = {valorFinal:N2} {unidadFinal}");
        }
    }
}