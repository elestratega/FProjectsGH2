using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FProjects
{
    public class Proyecto
    {
        private int idProyecto;
        private String nombreProyecto;
        private String descripcion;
        private String archivos;
        private bool estado;
        private int valoracion;
        private Ciclo ciclo;
        private List<Alumno> arrayAlumno;
        private DateTime fecha;


        public Proyecto(int idProyecto, string nombreProyecto, string descripcion, string archivos, bool estado, int valoracion, Ciclo ciclo, List<Alumno> arrayAlumno, DateTime fecha)
        {
            this.idProyecto = idProyecto;
            this.nombreProyecto = nombreProyecto;
            this.descripcion = descripcion;
            this.archivos = archivos;
            this.estado = estado;
            this.valoracion = valoracion;
            this.ciclo = ciclo;
            this.arrayAlumno = arrayAlumno;
            this.fecha = fecha;
        }

        public Proyecto()
        {
            this.idProyecto = 0;
            this.nombreProyecto = "";
            this.descripcion = "";
            this.archivos = "";
            this.estado = false;
            this.valoracion = 0;
            this.ciclo = new Ciclo();
            this.arrayAlumno = new List<Alumno>();
            this.fecha = new DateTime();
        }

        public int IdProyecto { get => idProyecto; set => idProyecto = value; }
        public string NombreProyecto { get => nombreProyecto; set => nombreProyecto = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public string Archivos { get => archivos; set => archivos = value; }
        public bool Estado { get => estado; set => estado = value; }
        public int Valoracion { get => valoracion; set => valoracion = value; }
        public Ciclo Ciclo { get => ciclo; set => ciclo = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }
        public List<Alumno> ArrayAlumno { get => arrayAlumno; set => arrayAlumno = value; }

        public override bool Equals(object obj)
        {
            return obj is Proyecto proyecto &&
                   idProyecto == proyecto.idProyecto &&
                   nombreProyecto == proyecto.nombreProyecto &&
                   descripcion == proyecto.descripcion &&
                   archivos == proyecto.archivos &&
                   estado == proyecto.estado &&
                   valoracion == proyecto.valoracion &&
                   EqualityComparer<Ciclo>.Default.Equals(ciclo, proyecto.ciclo) &&
                   EqualityComparer<List<Alumno>>.Default.Equals(arrayAlumno, proyecto.arrayAlumno) &&
                   fecha == proyecto.fecha &&
                   IdProyecto == proyecto.IdProyecto &&
                   NombreProyecto == proyecto.NombreProyecto &&
                   Descripcion == proyecto.Descripcion &&
                   Archivos == proyecto.Archivos &&
                   Estado == proyecto.Estado &&
                   Valoracion == proyecto.Valoracion &&
                   EqualityComparer<Ciclo>.Default.Equals(Ciclo, proyecto.Ciclo) &&
                   Fecha == proyecto.Fecha &&
                   EqualityComparer<List<Alumno>>.Default.Equals(ArrayAlumno, proyecto.ArrayAlumno);
        }

        public override int GetHashCode()
        {
            var hashCode = -1867734066;
            hashCode = hashCode * -1521134295 + idProyecto.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(nombreProyecto);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(descripcion);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(archivos);
            hashCode = hashCode * -1521134295 + estado.GetHashCode();
            hashCode = hashCode * -1521134295 + valoracion.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<Ciclo>.Default.GetHashCode(ciclo);
            hashCode = hashCode * -1521134295 + EqualityComparer<List<Alumno>>.Default.GetHashCode(arrayAlumno);
            hashCode = hashCode * -1521134295 + fecha.GetHashCode();
            hashCode = hashCode * -1521134295 + IdProyecto.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(NombreProyecto);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Descripcion);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Archivos);
            hashCode = hashCode * -1521134295 + Estado.GetHashCode();
            hashCode = hashCode * -1521134295 + Valoracion.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<Ciclo>.Default.GetHashCode(Ciclo);
            hashCode = hashCode * -1521134295 + Fecha.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<List<Alumno>>.Default.GetHashCode(ArrayAlumno);
            return hashCode;
        }
    }
}
