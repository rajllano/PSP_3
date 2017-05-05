using PSP_3_modelo;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSP_3_control
{
    public static class ControlCalculo
    {
        public static void TamanoRelativo(FileInfo Archivo)
        {
            Iterador i = Aplicacion.getInstancia().ColeccionDato.Iterador();
            Dato d;
            Double LocSobreMetodos = 0;
            Double SumaLogaritmo = 0;
            Double PromedioLogaritmo = 0;
            Double Contador = 0;
            Double Calculo1 = 0;
            Double SumaCalculo1 = 0;
            Double Varianza = 0;
            Double Desviacion = 0;
            Double RangoVS = 0;
            Double RangoS = 0;
            Double RangoM = 0;
            Double RangoL = 0;
            Double RangoVL = 0;

            while (i.tieneSiguiente())
            {
                d = i.Siguiente();

                LocSobreMetodos = d.x / d.y;
                LocSobreMetodos = Math.Log(LocSobreMetodos);

                SumaLogaritmo += LocSobreMetodos;
                Contador++;
            }

            PromedioLogaritmo = SumaLogaritmo / Contador;

            i = Aplicacion.getInstancia().ColeccionDato.Iterador();

            while (i.tieneSiguiente())
            {
                d = i.Siguiente();

                LocSobreMetodos = d.x / d.y;
                LocSobreMetodos = Math.Log(LocSobreMetodos);

                Calculo1 = Math.Pow(LocSobreMetodos - PromedioLogaritmo, 2);
                SumaCalculo1 += Calculo1;
            }

            Varianza = SumaCalculo1 / (Contador - 1);
            Desviacion = Math.Sqrt(Varianza);
            RangoVS = Math.Exp(PromedioLogaritmo - (2 * Desviacion));
            RangoS = Math.Exp(PromedioLogaritmo - Desviacion);
            RangoM = Math.Exp(PromedioLogaritmo);
            RangoL = Math.Exp(PromedioLogaritmo + Desviacion);
            RangoVL = Math.Exp(PromedioLogaritmo + (2 * Desviacion));

            String Respuesta = String.Empty;

            Respuesta = String.Format("{0} *** VS = {1} *** S = {2} *** M = {3} *** L = {4} *** VL = {5}", Archivo.Name, Math.Round(RangoVS,4), Math.Round(RangoS,4), Math.Round(RangoM,4), Math.Round(RangoL,4), Math.Round(RangoVL,4));

            Console.WriteLine(Respuesta);
        }
    }
}
