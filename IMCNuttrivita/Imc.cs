using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMCNuttrivita
{
    public static class Imc
    {
        public static double CalcularIMC(double peso, double altura)
        {
            return (peso / (altura * altura));
        }

        public static string MostrarResultado(double resultado)
        {
            switch (resultado)
            {
                case < 18.5:
                    return "Abaixo do peso";
                case >= 18.5 and <= 24.9:
                    return "Peso normal";
                case >= 25.0 and <= 29.9:
                    return "Sobrepeso";
                case >= 30.0 and <= 34.9:
                    return "Obesidade grau I";
                case >= 35.0 and <= 39.9:
                    return "Obesidade grau II";
                case >= 40.0:
                    return "Obesidade grau III";
                default:
                    return "Algo de errado";
            }
        }
    }
}
