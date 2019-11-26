using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoSemestralEstructura
{
      public class Audiovisual : Pelicula
    {
        public Audiovisual(string titulo, int year, string genero, string temporadas, string productor, string sinopsis, string ranting)
        {
            this.Titulo = titulo;
            this.Year  = year;
            this.Genero = genero;
            this.Temporadas = temporadas;
            this.Productor = productor;
            this.Sinopsis = sinopsis;
            this.Ranting = ranting;
        }
    }
}
