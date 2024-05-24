using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace figurageometrica
{
    // Definición de la clase Cuadrado que hereda de la clase Figura
    class Cuadrado : Figura
    {
        //el cuadrado solo usa un lado y lo toma del padre
        public Cuadrado(float lado1)
        {
            //lado se va a leer de la caja de texto con 
            //usando el boton guardar 
            this.Lado1 = lado1;  //arista se va a leer de la caja de texto con
            //usando el boton guardar
        }
        public override float area()
        {
            return Lado1 * Lado1;//Regresa o cacha el valor de la variable Lado1
        }
        public override float perimetro()
        {
            return Lado1 * 4;//Regresa o cacha el valor de la variable Lado1
        }
        public override float volumen()
        {
            throw new NotImplementedException();
            //ESTO ES UNA EXCEPCION DE USO DEFAULT DEL SISTEMA 
        }
    }
}
