using System;
namespace PrimerParcialCalc
{
    class Program
    {
        static void Main(string[] args)
        {
            //Primer Parcial Programacion 1 - Julio Cesar Alcantara Mendoza - 2020-30-01-0041
            double Num1, Num2, Result, Result2; Char Sn1, Sn2, SiNo; bool Decision = true; string Historial = "";
            //Do para que haga todo el proceso primero
            SaltoDeLinea();
            
                SImprimir(" Introduzca el primer numero o porcentaje: ");
                while (!double.TryParse(Console.ReadLine(), out Num1))
                {
                    SImprimir(" El valor ingresado no es válido.\n Ingrese un número: ");
                }
                // Le pasamos el valor de Num1 al Historial
                Historial = Historial + Convert.ToString(Num1)+ " ";
                SaltoDeLinea();
                SImprimir(" Introduzca el operador aritmetico: ");
                Sn1 = Console.ReadLine().ToUpper()[0];
                while (Sn1 != '+' && Sn1 != '-' && Sn1 != '*' && Sn1 != '/' && Sn1 != '%')
                {
                    SImprimir("Ingrese un operador correcto: ");
                    Sn1 = Console.ReadLine().ToUpper()[0];
                }
                // Le concatenamos el signo de la operacion introducido
                Historial = Historial + Sn1.ToString() + " ";
                SaltoDeLinea();
                SImprimir(" Introduzca el segundo numero: ");
                //Num2 = double.Parse(Console.ReadLine());
                while (!double.TryParse(Console.ReadLine(), out Num2))
                {
                    SImprimir(" El valor ingresado no es válido.\n Ingrese un número: ");
                }
                //Le concatenamos el valor de Nm2 ejemplo 1+5;
                Historial = Historial + Convert.ToString(Num2) + "\n";
                SaltoDeLinea();
                Result = Operaciones(Num1, Num2, Sn1);
                Imprimir("El resultado de su operacion es: " + Result.ToString());
                SaltoDeLinea(); SImprimir(" Desea continuar (S/N): "); SiNo = Console.ReadLine().ToUpper()[0]; Decision = (SiNo == 'S') ? true : false; Console.Clear();
                //While para el segundo proceso
                while (Decision)
                {
                    SImprimir(" Introduzca el operador aritmetico: ");
                    Sn1 = Console.ReadLine().ToUpper()[0];
                    while (Sn1 != '+' && Sn1 != '-' && Sn1 != '*' && Sn1 != '/' && Sn1 != '%')
                    {
                        SImprimir("Ingrese un operador correcto: ");
                        Sn1 = Console.ReadLine().ToUpper()[0];
                    }
                    //Concatenamos el operador de la siguiente operacion
                    Historial = Historial+ " " + Sn1.ToString(); 
                    SImprimir(" Introduzca el primer numero o porcentaje: ");
                    while (!double.TryParse(Console.ReadLine(), out Num1))
                    {
                        SImprimir(" El valor ingresado no es válido.\n Ingrese un número: ");
                    }
                    Historial = Historial + " " + Convert.ToString(Num1);
                    SImprimir(" Introduzca el operador aritmetico: ");
                    Sn2 = Console.ReadLine().ToUpper()[0];
                    while (Sn2 != '+' && Sn2 != '-' && Sn2 != '*' && Sn2 != '/' && Sn2 != '%')
                    {
                        SImprimir("Ingrese un operador correcto: ");
                        Sn2 = Console.ReadLine().ToUpper()[0];
                    }
                    // Le concatenamos el signo de la operacion introducido
                    Historial = Historial + " " + Sn2.ToString();
                    SImprimir(" Introduzca el segundo numero: ");
                    while (!double.TryParse(Console.ReadLine(), out Num2))
                    {
                        SImprimir(" El valor ingresado no es válido.\n Ingrese un número: ");
                    }
                    // Le concatenamos el segundo numero introducido y cerramos el parentesis
                    Historial = Historial + " " + Convert.ToString(Num2) + "\n";
                    //Operacion
                    Result2 = Operaciones(Num1, Num2, Sn2);
                    //Operacion de los resultados de la primera y segunda operacion
                    Result = Operaciones(Result, Result2, Sn1);
                    Imprimir("El resultado de su operacion es: " + Result.ToString());
                    //Lle pasamos los resultados de la primera y segunda operacion
                    
                    SaltoDeLinea(); SImprimir(" Desea continuar (S/N): "); SiNo = Console.ReadLine().ToUpper()[0]; Decision = (SiNo == 'S') ? true : false; Console.Clear();
                }

            SaltoDeLinea();
            //Imprimir todo el historial
            Imprimir(" Historial:" + "\n" + Historial + "\n");
            Imprimir(" El total de todas las operaciones es: " + Result);
            SaltoDeLinea();
        }
        static void SImprimir(string text) { Console.Write(text); }
        static void Imprimir(string text) { Console.WriteLine(text); }
        static void SaltoDeLinea() { Imprimir("\n"); }
        //Funciones para operaciones aritmeticas
        static double Suma(double Nm1, double Nm2) { double result = Nm1 + Nm2; return result; }
        static double Resta(double Nm1, double Nm2) { double result = Nm1 - Nm2; return result; }
        static double Producto(double Nm1, double Nm2) { double result = Nm1 * Nm2; return result; }
        static double Division(double Nm1, double Nm2) { double result = Nm1 / Nm2; return result; }
        static double Porcentaje(double Nm1, double Nm2) { double result = Nm1 / 100 * Nm2; return result; }
        static double Operaciones(double Num1, double Num2, char Sn1)
        {
            double Result = 0;
            switch (Sn1)
            {
                case '+':

                    Result = Suma(Num1, Num2);

                    break;
                case '-':

                    Result = Resta(Num1, Num2);

                    break;
                case '*':

                    Result = Producto(Num1, Num2);

                    break;
                case '/':

                    Result = Division(Num1, Num2);

                    break;
                case '%':

                    Result = Porcentaje(Num1, Num2);
                    break;

            }

            return Result;

        }

    }
}
