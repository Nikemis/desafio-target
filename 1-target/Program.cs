 namespace target
{
     class Program
   {
         static int Looping(int i, int k)
        {
            int s = 0; 
             while (k < i)
          {
                s = s + k;
            }
           return s; 
      }

         static void Main(string[] args)
         {
            int indice = 13;
            int k = 0;
            int soma = Looping(indice, k); 
            Console.WriteLine(soma);
        }
    }
}


