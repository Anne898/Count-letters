using System;
using System.Collections.Generic;

namespace CountChars
{
    class Program
    {
        static void Main(string[] args)
        {
           string data = "ksbflewbfa kjncoaienflsjfkanaskjd akjka";
            // string data = "abcabda";

            //Char count by char
            Dictionary<char, int> countByChar = new Dictionary<char, int>();

    	    //Iterar los caracteres uno por uno

            foreach (var caracter in data)
            {
                //Saltearse espacios vacíos
                if (caracter == ' ')
                {
                    continue;
                }

                /*if(caracter=='p'){
                    continue;
                }*/
                //caracter es tipo char

                //1. Revisar si existe en el diccionario

                if (countByChar.ContainsKey(caracter)) {
                    //3. Consultar valor actual del diccionario

                    countByChar.TryGetValue(caracter, out int currentCount);

                    int nextCount = currentCount + 1;


                    //4. Registrar en diccionario

                    //4.1. Borrar registro actual
                    countByChar.Remove(caracter);

                    //4.2. Agregar valor
                    countByChar.Add(caracter, nextCount);
                } else {
                    //2. Agregar a diccionario con valor 1
                    countByChar.Add(caracter, 1);

                    //√ Terminamos esta iteración
                }
            }


            char highestRepeatedChar = ' ';
            int highestRepeatedCount = 0;

            char letraMenosRepite = ' ';
            int   NumeroMenosRepite= 39;

            foreach (var item in countByChar)
            {

                //item es de tipo KeyValuePair<char, int>

                //item.Key es la llave
                //item.Value es el valor

                if (item.Value > highestRepeatedCount) {
                    highestRepeatedChar = item.Key;
                    highestRepeatedCount = item.Value;
                }

                  if (item.Value < NumeroMenosRepite) {
                    letraMenosRepite = item.Key;
                    NumeroMenosRepite = item.Value;
                }



                System.Console.WriteLine($"{item.Key} -> {item.Value}");
            }

            System.Console.WriteLine($"Highest Count: {highestRepeatedChar} -> {highestRepeatedCount}");

            System.Console.WriteLine($"letra que menos se repite: {letraMenosRepite} -> {NumeroMenosRepite}");

            Console.WriteLine("Tamaño del string "+data.Length); 
        }
    }
}





