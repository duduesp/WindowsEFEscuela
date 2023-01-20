using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsEFEscuela.Dac;
using WindowsEFEscuela.Modelos;

namespace WindowsEFEscuela
{
    public partial class frmAlumno : Form
    {
        public frmAlumno()
        {
            InitializeComponent();
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            Profesor profesor = new Profesor() { Nombre = "Paco", Apellido = "Perez", Titulo = "Docente" };
            Alumno alumno = new Alumno() { Nombre = textNombre.Text, Apellido = "Perez", FechaNacimiento = new DateTime(1994, 10, 03), Profesor = profesor };

            int filasAfectadas = AbmAlumno.InsertarAlumno(alumno);
            if (filasAfectadas > 0)
            {
                MessageBox.Show("Insert OK");
                MostarAlumnos();
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Alumno alumno = new Alumno()
            {
                IdAlumno = Convert.ToInt32(textId.Text),
                Nombre = textNombre.Text,
                Apellido = textApellido.Text,
                FechaNacimiento = Convert.ToDateTime(textFecha.Text),
            };

            int filasAfectadas = AbmAlumno.ModificarAlumno(alumno);
            if (filasAfectadas > 0)
            {
                MessageBox.Show("Update ok");
                MostarAlumnos();
            }
        }


        private void btnBuscar_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(textId.Text);
            Alumno alumno = AbmAlumno.SelectAlumno(id);
            MessageBox.Show(alumno.Nombre);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

            Alumno alumno = new Alumno()
            {
                IdAlumno = Convert.ToInt32(textId.Text),
                Nombre = textNombre.Text,
                Apellido = textApellido.Text,
                FechaNacimiento = Convert.ToDateTime(textFecha.Text),
            };

            int filasAfectadas = AbmAlumno.EliminarAlumno(alumno);
            if (filasAfectadas > 0)
            {
                MessageBox.Show("Eliminacion ok");
                MostarAlumnos();
            }


        }
        private void frmAlumno_Load(object sender, EventArgs e)
        {
            MostarAlumnos();
        }

        private void MostarAlumnos()
        {
            gridAlumno.DataSource = AbmAlumno.SelectAll();
        }

        private void textNombre_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
