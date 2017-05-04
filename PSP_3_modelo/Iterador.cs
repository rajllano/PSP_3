using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PSP_3_modelo
{
    /// <summary>
    /// Interfaz que debe implementar el iterador de la coleccion
    /// </summary>
    public interface Iterador
    {
        Dato Siguiente();

        bool tieneSiguiente();
    }
}