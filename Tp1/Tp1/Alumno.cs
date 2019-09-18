using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp1
{   //Creo la clase alumno
    public class Alumno
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Curso { get; set; }
        //Genero un constructor para los objetos
        public Alumno(int id, string nombre, string apellido, string curso)
        {
            this.Id = id;
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Curso = curso;
        }
        //Realizo un override del metodo ToString para poder mostrarlo en la lbx
        public override string ToString()
        {
            return Id + ", " + Nombre + ", " + Apellido + ", " + Curso;
        }
    }
}
