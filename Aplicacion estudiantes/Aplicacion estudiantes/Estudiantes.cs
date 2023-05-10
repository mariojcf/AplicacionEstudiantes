using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacion_estudiantes
{
    internal class Estudiantes
    {
        //metodos 
        private String name;
        private String id;
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
    }
}
