using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FProjects
{
    public class Alumno : Usuario
    {
        private int idAlumno;
        private String nombreAlumno;
        private String telefono;
        private List<Centro> arrayCentros;


        public Alumno(int idUsuario, string nombre, string correo, string contrasenia, int codRecContr, string tipoUsario, Image fotoUsuario, DateTime fechaCodRecContr,int idAlumno, string nombreAlumno, string telefono, List<Centro> arrayCentros) : base(idUsuario,nombre, correo,contrasenia, codRecContr,tipoUsario,fotoUsuario,fechaCodRecContr)
        {
            this.idAlumno = idAlumno;
            this.nombreAlumno = nombreAlumno;
            this.telefono = telefono;
            this.arrayCentros = arrayCentros;

        }

        public Alumno()
        {
            this.idAlumno = 0;
            this.nombreAlumno = "";
            this.telefono = "";
            this.arrayCentros=new List<Centro>();

        }

        public int IdAlumno { get => idAlumno; set => idAlumno = value; }
        public string NombreAlumno { get => nombreAlumno; set => nombreAlumno = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public List<Centro> ArrayCentros { get => arrayCentros; set => arrayCentros = value; }

        public override bool Equals(object obj)
        {
            return obj is Alumno alumno &&
                   base.Equals(obj) &&
                   idAlumno == alumno.idAlumno &&
                   nombreAlumno == alumno.nombreAlumno &&
                   telefono == alumno.telefono &&
                   EqualityComparer<List<Centro>>.Default.Equals(arrayCentros, alumno.arrayCentros) &&
                   IdAlumno == alumno.IdAlumno &&
                   NombreAlumno == alumno.NombreAlumno &&
                   Telefono == alumno.Telefono &&
                   EqualityComparer<List<Centro>>.Default.Equals(ArrayCentros, alumno.ArrayCentros);
        }

        public override int GetHashCode()
        {
            var hashCode = 262567168;
            hashCode = hashCode * -1521134295 + base.GetHashCode();
            hashCode = hashCode * -1521134295 + idAlumno.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(nombreAlumno);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(telefono);
            hashCode = hashCode * -1521134295 + EqualityComparer<List<Centro>>.Default.GetHashCode(arrayCentros);
            hashCode = hashCode * -1521134295 + IdAlumno.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(NombreAlumno);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Telefono);
            hashCode = hashCode * -1521134295 + EqualityComparer<List<Centro>>.Default.GetHashCode(ArrayCentros);
            return hashCode;
        }
    }
}
