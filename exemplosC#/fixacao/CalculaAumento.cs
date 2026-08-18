using System;
using System.Collections.Generic;
using System.Text;

namespace exemplosC_.fixacao
{
    internal class CalculaAumento
    {
        internal static double Aumento(double salario, double percentual)
        {
            return salario + (salario * percentual / 100);
        }
    }
}
