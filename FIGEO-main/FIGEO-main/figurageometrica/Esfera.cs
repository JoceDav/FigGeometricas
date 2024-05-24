using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace figurageometrica
{
    // Definición de la clase Esfera que hereda de la clase Figura
    class Esfera : Figura
    {
        public Esfera(float arista)
        {//arista se va a leer de la caja de texto con
            //usando el boton guardar
            Lado1 = arista;
        }
        //vamos a usar los metodos de la clase padre
        //vamos a sobresalir el comportamiento d estos
        public override float area()
        {
            return 4 * 3.1416F * Lado1 * Lado1;//Regresa o cacha el valor de la variable Lado1
        } //agregamos f al final de un numero cuando
          //es una constante no definida en una variable 
          //previamente

        public override float perimetro()
        {
            throw new NotImplementedException();
        }

        public override float volumen()
        {
            return (4 * (3.1416F * (Lado1 * Lado1 * Lado1))) / 3;//Regresa o cacha el valor de la variable Lado1
            //agregamos f al final de un numero cuando
            //es una constante no definida en una variable 
            //previamente
        }
    }
}
