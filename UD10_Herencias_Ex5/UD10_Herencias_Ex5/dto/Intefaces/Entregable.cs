using System;
using System.Collections.Generic;
using System.Text;

namespace UD10_Herencias_Ex5
{
    public interface Entregable
    {
        // METODOS

        public void entregar(); // asignamos valor ture a entregado
        /*{
            this.entregado = true;  
        }*/

        public void devolver();  // asignamos valos false a entregado
        /*{
            this.entregado = false; 
        }*/

        public bool isEntregado(); // devolvemos el valor de entregado
        /*{
            return this.entregado; 
        }*/

        public Boolean compareTo(object a); //Compara las horas estimadas en los videojuegos y en las series el numero de temporadas. 
        /* 
         * if (this.numeroTemporadas < s._NumeroTemporadas)
            {
                return false;
            }
            else
            {
                return true;
            }
        */
    }
}
