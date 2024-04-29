using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace guia_VARIABLES
{
    internal class Program
    {
        static void Main(string[] args)

             //PUNTO NUMERO 1 GUIA VARIABLES, CALCULAMOS EL PROMEDIO//
        {
            Console.WriteLine("calculemos el promedio de edades...");
            int edad1 = 8, edad2 = 6, edad3 = 5;
            double sumatoria = (edad1 + edad2 + edad3) / 3;
            Console.WriteLine(" el promedio de edad es " + sumatoria);

            // PUNTO NUMERO DOS, AREA DE UN RECTANGULO//
            // para sacar el area la formula es A= base*altura//

            double vBase, vAltura;
            Console.WriteLine(" ingrese la base del rectangulo ");
            vBase = double.Parse (Console.ReadLine());
            Console.WriteLine(" ingrese la altura del rectangulo ");
            vAltura = double.Parse (Console.ReadLine());
            double vArea = vBase * vAltura;
            Console.WriteLine(" el area resultante es igual a " + vArea);

            // PUNTO NUMERO TRES, DESCUENTO EN UNA TIENDA//

            double pOriginal, pCdesscuento;
            Console.WriteLine(" ingrese el precio ");
            pOriginal = double.Parse (Console.ReadLine());
            Console.WriteLine("ingrese el descuento");
            pCdesscuento = double.Parse (Console.ReadLine());
            double Pfinal = pOriginal * pCdesscuento / 100;
            Console.WriteLine(" el precio final con el descuento es de " + (pOriginal - Pfinal)  );

            // PUNTO CUATRO, EDADES Y SUMATORIA//

            double primedad, segedad, teredad;
            Console.WriteLine("ingrese la primer edad"); 
            primedad = int.Parse (Console.ReadLine());
            Console.WriteLine(" ingrese la segunda edad");  
            segedad = int.Parse (Console.ReadLine());
            Console.WriteLine(" ingrese la tercer edad");
            teredad = int.Parse (Console.ReadLine()); 
            double sumEdades = primedad + segedad + teredad;
            Console.WriteLine("la sumatoria de edades es de " + sumEdades);

            // PUNTO CINCO, TEMPERATURA EN GRADOS FAHRENHEIT//

            double  tempGcel;
            Console.WriteLine("ingrese la temperatura en grados celsius");
            tempGcel = double.Parse (Console.ReadLine());
            double tempGfarh = tempGcel * 1.8 + 32;
            Console.WriteLine("su temperatura en grados fahrenheit es " + tempGfarh);

            //PUNTO SEIS, ALTURA EN PULGADAS//

            double altMET;
            Console.WriteLine("ingrese su altura en metros ");
            altMET = double.Parse (Console.ReadLine());
            double altPUL = (altMET / 0.0254);
            Console.WriteLine(" su altura resultante en`pulgadas es " + altPUL);  
            


            
           
            
            
            



            



           

              
         


            
                
           

                ;
        }
    }
}
