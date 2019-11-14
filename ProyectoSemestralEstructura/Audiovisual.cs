using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoSemestralEstructura
{
      public class Audiovisual : Pelicula
    {
        public Audiovisual(string titulo, int year, string genero, int temporadas, string productor, string descripcion, int ranting)
        {
           
            this.Titulo = titulo;
            this.Year = year;
            this.Genero = genero;
            this.Temporadas = temporadas;
            this.Productor = productor;
            this.Descripcion = descripcion;
            this.Ranting = ranting;
          
        }

        public Audiovisual(string titulo, int year, string sinopsis, string genero, string director, int ranting)
        {
            this.Sinopsis = sinopsis;
            this.Titulo = titulo;
            this.Year = year;
            this.Genero = genero;
            this.Director = director;
            this.Ranting = ranting;
        }



    }
}
