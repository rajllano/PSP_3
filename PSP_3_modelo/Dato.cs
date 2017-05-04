using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PSP_3_modelo
{
    public class Dato
    {
        /// <summary>
        /// Metodo: constructor de la clase, no recibe ningun parametro
        /// </summary>
        public Dato()
        {

        }

        /// <summary>
        /// Metodo (Constructor): recibe dos parametros, el valor de X y Y.
        /// </summary>
        /// <param name="x">Valor de x</param>
        /// <param name="y">Valor de y</param>
        public Dato(Double x, Double y)
        {
            this.x = x;
            this.y = y;
        }

        public Double x { get; set; }

        public Double y { get; set; }
    }
}