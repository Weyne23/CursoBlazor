using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp_Razor_Classes.Client.Classes
{
    public class Calculo
    {
        public static int Somar(int n1, int n2) => n1 + n2;
        public static int Subtrair(int n1, int n2) => n1 - n2;
        public static int Multplicar(int n1, int n2) => n1 * n2;
    }
}
