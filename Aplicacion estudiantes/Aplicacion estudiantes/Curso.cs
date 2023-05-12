using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacion_estudiantes
{
    public class Curso
    {
        String name;
        int grade; 

        public Curso(String name, int grade)
        {
            this.name = name;
            this.grade = grade;
        }

        public String getName()
        {
            return name;
        }
        public int getGrade()
        {
            return grade;
        }

        public String setName()
        {
            return name;
        }
        public int SetGrade()
        {
            return grade;
        }

        public void SetGrade(int grade)
        {
            this.grade = grade;
        }

        public void SetName(String name)
        {
            this.name = name;
        }
    }
}
