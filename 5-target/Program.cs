using System;

namespace InverterString
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("Insira uma string : ");
            string entrada = Console.ReadLine();

            
            string invertida = InverterString(entrada);

            
            Console.WriteLine("String invertida:{0} ", invertida);
        }

        
        static string InverterString(string str)
        {
            
            if (str == null || str.Length == 0)
            {
                return str;
            }

            
            char[] caracteres = new char[str.Length];

            
            for (int i = 0; i < str.Length; i++)
            {
                caracteres[i] = str[str.Length - 1 - i];
            }

            
            return new string(caracteres);
        }
    }
}
