using System;
using System.Collections.Generic;
using System.Text;

namespace UD10_Herencias_Ex5
{
    class Series : Entregable
    {
        // ATRIBUOS
        private string titulo;
        private int numeroTemporadas;
        private Boolean entregado;
        private string genero;
        private string creador;

        private const int numeroTemporadasDefecto = 3;
        private const Boolean entregadoDefecto = false;

        // GETTERS Y SETTERS
        public string _Titulo
        {
            get { return titulo; }
            set { titulo = value; }
        }
        public int _NumeroTemporadas
        {
            get { return numeroTemporadas; }
            set { numeroTemporadas = value; }
        }
        public string _Genero
        {
            get { return genero; }
            set { genero = value; }
        }
        public string _Creador
        {
            get { return creador; }
            set { creador = value; }
        }


        // CONSTRUCTORES
        public Series()
        {
            _Titulo = "";
            _NumeroTemporadas = numeroTemporadasDefecto;
            this.entregado = entregadoDefecto;
            _Genero = "";
            _Creador = "";
        }

        public Series(string titulo, string creador)
        {
            _Titulo = titulo;
            _NumeroTemporadas = numeroTemporadasDefecto;
            this.entregado = entregadoDefecto;
            _Genero = "";
            _Creador = creador;
        }

        public Series(string titulo, int numeroTemporadas, bool entregado, string genero, string creador)
        {
            _Titulo = titulo;
            _NumeroTemporadas = numeroTemporadas;
            this.entregado = entregado;
            _Genero = genero;
            _Creador = creador;
        }

        // METODOS
        public override string ToString()
        {
            Console.WriteLine("Titulo: {0}", _Titulo);
            Console.WriteLine("Numero de Temporadas: {0}", _NumeroTemporadas);
            Console.WriteLine("Entregado: {0}", this.entregado);
            Console.WriteLine("Genero: {0}", _Genero);
            Console.WriteLine("Creador: {0}", _Creador);
            return "";
        }

        public void entregar() // asignamos valor ture a entregado
        {
            this.entregado = true;
        }

        public void devolver()  // asignamos valos false a entregado
        {
            this.entregado = false;
        }

        public bool isEntregado()  // devolvemos el valor de entregado
        {
            return this.entregado;
        }


        public Boolean compareTo(object a) //Compara las horas estimadas en los videojuegos y en las series el numero de temporadas.
        {
            Series s = (Series)a; //casteamos objeto para que sea una serie

            if (this.numeroTemporadas <= s._NumeroTemporadas)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

    }
}
