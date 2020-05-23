using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FProjects
{
    public class Centro : Usuario
    {
        private int idCentro;
        private String nombreCentro;
        private String direccion;
        private String telefono;
        private int idUsuario;
        private String contraseniaCentro;
        private List<Alumno> arrayAlumno;
        private List<Ciclo> arrayCiclo;


        public Centro(int idUsuario, string nombre, string correo, string contrasenia, int codRecContr, string tipoUsario, Image fotoUsuario, DateTime fechaCodRecContr, int idCentro, string nombreCentro, string direccion, string telefono, string contraseniaCentro, List<Alumno> arrayAlumno, List<Ciclo> arrayCiclo) : base(idUsuario, nombre, correo, contrasenia, codRecContr, tipoUsario, fotoUsuario, fechaCodRecContr)
        {
            this.idCentro = idCentro;
            this.nombreCentro = nombreCentro;
            this.direccion = direccion;
            this.telefono = telefono;
            this.idUsuario = idUsuario;
            this.contraseniaCentro = contraseniaCentro;
            this.arrayAlumno = arrayAlumno;
            this.arrayCiclo = arrayCiclo;
        }

        public Centro()
        {
            this.idCentro = 0;
            this.nombreCentro = "";
            this.direccion = "";
            this.telefono = "";
            this.idUsuario = 0;
            this.contraseniaCentro = "";
            this.arrayAlumno = new List<Alumno>();
            this.arrayCiclo = new List<Ciclo>();
        }

        public int IdCentro { get => idCentro; set => idCentro = value; }
        public string NombreCentro { get => nombreCentro; set => nombreCentro = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public int IdUsuario1 { get => idUsuario; set => idUsuario = value; }
        public string ContraseniaCentro { get => contraseniaCentro; set => contraseniaCentro = value; }
        public List<Ciclo> ArrayCiclo { get => arrayCiclo; set => arrayCiclo = value; }
        public List<Alumno> ArrayAlumno { get => arrayAlumno; set => arrayAlumno = value; }

        public override bool Equals(object obj)
        {
            return obj is Centro centro &&
                   base.Equals(obj) &&
                   idCentro == centro.idCentro &&
                   nombreCentro == centro.nombreCentro &&
                   direccion == centro.direccion &&
                   telefono == centro.telefono &&
                   idUsuario == centro.idUsuario &&
                   contraseniaCentro == centro.contraseniaCentro &&
                   EqualityComparer<List<Alumno>>.Default.Equals(arrayAlumno, centro.arrayAlumno) &&
                   EqualityComparer<List<Ciclo>>.Default.Equals(arrayCiclo, centro.arrayCiclo) &&
                   IdCentro == centro.IdCentro &&
                   NombreCentro == centro.NombreCentro &&
                   Direccion == centro.Direccion &&
                   Telefono == centro.Telefono &&
                   IdUsuario1 == centro.IdUsuario1 &&
                   ContraseniaCentro == centro.ContraseniaCentro &&
                   EqualityComparer<List<Ciclo>>.Default.Equals(ArrayCiclo, centro.ArrayCiclo) &&
                   EqualityComparer<List<Alumno>>.Default.Equals(ArrayAlumno, centro.ArrayAlumno);
        }

        public override int GetHashCode()
        {
            var hashCode = -2092815445;
            hashCode = hashCode * -1521134295 + base.GetHashCode();
            hashCode = hashCode * -1521134295 + idCentro.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(nombreCentro);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(direccion);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(telefono);
            hashCode = hashCode * -1521134295 + idUsuario.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(contraseniaCentro);
            hashCode = hashCode * -1521134295 + EqualityComparer<List<Alumno>>.Default.GetHashCode(arrayAlumno);
            hashCode = hashCode * -1521134295 + EqualityComparer<List<Ciclo>>.Default.GetHashCode(arrayCiclo);
            hashCode = hashCode * -1521134295 + IdCentro.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(NombreCentro);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Direccion);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Telefono);
            hashCode = hashCode * -1521134295 + IdUsuario1.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(ContraseniaCentro);
            hashCode = hashCode * -1521134295 + EqualityComparer<List<Ciclo>>.Default.GetHashCode(ArrayCiclo);
            hashCode = hashCode * -1521134295 + EqualityComparer<List<Alumno>>.Default.GetHashCode(ArrayAlumno);
            return hashCode;
        }
    }
}
