using System;

namespace Introduccion_C_.Models
{
    public class MultiplicacionSuma

    {
        public int NumA { get; set; }
        public int NumB { get; set; }
        public int Resultado { get; set; }
        public string Proceso { get; set; }
        public void Calcular()
        {
            Resultado = 0;
            Proceso = "";
            for (int i = 0; i < NumB; i++)
            {
                Resultado = Resultado + NumA;
                Proceso = Proceso + NumA;
                if (i < NumB - 1)
                {
                    Proceso = Proceso + " + ";
                }
            }
            Proceso = Proceso + " = " + Resultado;
        }
    }
}