using System;
using System.Text;
using System.Text.RegularExpressions;

namespace CadenaApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese un texto para procesar: ");

            string cadena = Console.ReadLine();

            string[] splitString = Regex.Split(cadena, @"");

            StringBuilder myStringBuilder = new StringBuilder("");       

            for (int i= (splitString.Length-1); i >0; i--)
            {
                myStringBuilder.Append(splitString[i]);
            }
            Console.WriteLine("El texto procesado es :  " + myStringBuilder);

            Console.ReadLine();
        }
    }
}
