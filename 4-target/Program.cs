using System;

namespace FaturamentoDistribuidora
{
    class Program
    {
        static void Main(string[] args)
        {
            
            float faturamentoSP = 67836.43f;
            float faturamentoRJ = 36678.66f;
            float faturamentoMG = 29229.88f;
            float faturamentoES = 27165.48f;
            float faturamentoOutros = 19849.53f;

            
            float faturamentoTotal = CalcularFaturamentoTotal(faturamentoSP, faturamentoRJ, faturamentoMG, faturamentoES, faturamentoOutros);

           
            ExibirPercentuais(faturamentoSP, faturamentoRJ, faturamentoMG, faturamentoES, faturamentoOutros, faturamentoTotal);
        }

        static float CalcularFaturamentoTotal(float sp, float rj, float mg, float es, float outros)
        {
            return sp + rj + mg + es + outros;
        }

        
        static void ExibirPercentuais(float sp, float rj, float mg, float es, float outros, float total)
        {
            float percentualSP = CalcularPercentual(sp, total);
            float percentualRJ = CalcularPercentual(rj, total);
            float percentualMG = CalcularPercentual(mg, total);
            float percentualES = CalcularPercentual(es, total);
            float percentualOutros = CalcularPercentual(outros, total);

            Console.WriteLine("Percentual de representação por estado:");
            Console.WriteLine("SP: {0}%", percentualSP);
            Console.WriteLine("RJ: {0}%", percentualRJ);
            Console.WriteLine("MG: {0}%", percentualMG);
            Console.WriteLine($"ES: {0}%", percentualES);
            Console.WriteLine($"Outros: {0}%", percentualOutros);
        }

        
        static float CalcularPercentual(float valor, float total)
        {
            return (valor / total) * 100;
        }
    }
}
