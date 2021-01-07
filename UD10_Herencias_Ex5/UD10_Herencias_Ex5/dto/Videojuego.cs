using System;
using System.Collections.Generic;
using System.Text;

namespace UD10_Herencias_Ex5
{
    class Videojuego : Entregable
    {
        // ATRIBUTOS
        private string titulo;
        private int horasEstimadas;
        private Boolean entregado;
        private string genero;
        private string compañia;

        private const int horasEstimadasDefecto = 10;
        private const Boolean entregadoDefecto = false;

        // GETTERS Y SETTERS
        public string _Titulo
        {
            get { return titulo; }
            set { titulo = value; }
        }
        public int _HorasEstimadas
        {
            get { return horasEstimadas; }
            set { horasEstimadas = value; }
        }
        public string _Genero
        {
            get { return genero; }
            set { genero = value; }
        }
        public string _Compañia
        {
            get { return compañia; }
            set { compañia = value; }
        }

        // CONSTRUCTORES
        public Videojuego()
        {
            _Titulo = "";
            _HorasEstimadas = horasEstimadasDefecto;
            this.entregado = entregadoDefecto;
            _Genero = "";
            _Compañia = "";
        }
        public Videojuego(string titulo, int horasEstimadas)
        {
            _Titulo = titulo;
            _HorasEstimadas = horasEstimadas;
            this.entregado = entregadoDefecto;
            _Genero = "";
            _Compañia = "";
        }
        public Videojuego(string titulo, int horasEstimadas, bool entregado, string genero, string compañia)
        {
            _Titulo = titulo;
            _HorasEstimadas = horasEstimadas;
            this.entregado = entregado;
            _Genero = genero;
            _Compañia = compañia;
        }

        // METODOS
        public override string ToString()
        {
            Console.WriteLine("Titulo: {0}", _Titulo);
            Console.WriteLine("Horas del videojuego: {0}", _HorasEstimadas);
            Console.WriteLine("Entregado: {0}", this.entregado);
            Console.WriteLine("Genero: {0}", _Genero);
            Console.WriteLine("Compañia: {0}", _Compañia);
            return "";
        }

        public void entregar() // asignamos valor ture a entregado
        {
            this.entregado = true;
        }

        public void devolver() // asignamos valos false a entregado
        {
            this.entregado = false;
        }

        public bool isEntregado() // devolvemos el valor de entregado
        {
            return this.entregado;
        }


        public Boolean compareTo(object a) //Compara las horas estimadas en los videojuegos y en las series el numero de temporadas.
        {
            Videojuego v = (Videojuego)a; //casteamos objeto para que sea una serie

            if (this.horasEstimadas <= v._HorasEstimadas)
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
