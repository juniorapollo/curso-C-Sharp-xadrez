using System;
using System.Globalization;



namespace curso_C_Sharp_xadrez
{
    class Triangulo{      

        public double a,b,c;

        public double calculaArea(){
                double p = (a + b + c) / 2.0;
                return Math.Sqrt(p* ( p - a ) * ( p - b ) * ( p - c ));
        }


    }
}