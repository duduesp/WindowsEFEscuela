using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using WindowsEFEscuela.Data;
using WindowsEFEscuela.Modelos;

namespace WindowsEFEscuela.Dac
{
    public static class AbmAlumno
    {

        //creamos instancia de nuestro dbcontext
        private static DBEscuelaContext context = new DBEscuelaContext();


        public static List<Alumno> SelectAll()
        {
            return context.Alumnos.ToList();

        }


        public static Alumno SelectAlumno(int id)
        {
            return context.Alumnos.Find(id);
        }

        public static int InsertarAlumno(Alumno alumno)
        {
            context.Alumnos.Add(alumno);

            return context.SaveChanges();

        }

        public static int ModificarAlumno(Alumno alumno)
        {
            Alumno alumnoOrigen = context.Alumnos.Find(alumno.IdAlumno);

            alumnoOrigen.Nombre = alumno.Nombre;
            alumnoOrigen.Apellido = alumno.Apellido;
            alumnoOrigen.FechaNacimiento = alumno.FechaNacimiento;
            alumnoOrigen.ProfesorId = alumno.ProfesorId;

            return context.SaveChanges();

        }

        public static int EliminarAlumno(Alumno alumno)
        {
            Alumno alumnoOrigen = context.Alumnos.Find(alumno.IdAlumno);
            if (alumnoOrigen != null)
            {
                context.Alumnos.Remove(alumnoOrigen);
                return context.SaveChanges();

            }
            return 0;

        }



    }
}
