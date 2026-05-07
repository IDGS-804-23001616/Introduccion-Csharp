using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Introduccion_C_.Models
{
    public class OperacionesBasicas
    {
        public int Num1 { get; set; }
        public int Num2 { get; set; }
        public int Resultado { get; set; }


        public void Suma()
        {
            this.Resultado = this.Num1 + this.Num2;
        }

    }
}