using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Introduccion_C_.Models
{/*
  * class [nombre]{
  * [atributos o variables]
  * [metodos o funciones] 
  */
    internal class Practica2
    {
        string nombre;
        private int edad;
        protected string carrera;
        public void IngresarDatos()
        {
            Console.WriteLine("Ingresa tu nonmbre: ");
            nombre = Console.ReadLine();
            Console.WriteLine("Ingresa tu edad: ");
            edad = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingresa tu carrera: ");
            carrera = Console.ReadLine();

        }

        public void MostrarDatos()
        {
            Console.WriteLine("Nombre: " + nombre);
            Console.WriteLine("Edad: " + edad);
            Console.WriteLine("Carrera: " + carrera);
        }
        static void Main(String[] args)
        {
            Practica2 p2 = new Practica2();
            p2.IngresarDatos();
            p2.MostrarDatos();
        }
    }
}
