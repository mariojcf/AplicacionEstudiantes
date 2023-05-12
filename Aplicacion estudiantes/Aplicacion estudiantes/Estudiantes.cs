using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacion_estudiantes
{
    public class Estudiantes
    {
        //metodos 
        private String name;
        private String id;
        private Curso[] cursos = new Curso[2];
        //constructor
        public Estudiantes(String name, String id)
        {
            this.name = name;
            this.id = id;
        } // fin del constructor

        //set y get
        public string getId()
        {
            return this.id;
        }

        public String getName()
        {
            return this.name;
        }

        public void setId(String id)
        {
            this.id = id;
        }

        public void setName(String name)
        {
            this.name = name;
        }

        public Curso[] getCursos()
        {
            return this.cursos;
        }
        public void SetCursos(Curso[] cursos)
        {
            this.cursos = cursos;
        }
    }
}
