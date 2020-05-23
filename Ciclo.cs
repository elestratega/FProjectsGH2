using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FProjects
{
    public class Ciclo
    {
        private int idCiclo;
        private String nombreCiclo;
        private List<Centro> arrayCentros;



        public Ciclo(int idCiclo, string nombreCiclo, List<Centro> arrayCentros)
        {
            this.idCiclo = idCiclo;
            this.nombreCiclo = nombreCiclo;
            this.arrayCentros = arrayCentros;
        }

        public Ciclo()
        {
            this.idCiclo = 0;
            this.nombreCiclo = "";
            this.arrayCentros = new List<Centro>();
        }
        public int IdCiclo { get => idCiclo; set => idCiclo = value; }
        public string NombreCiclo { get => nombreCiclo; set => nombreCiclo = value; } 
        public List<Centro> ArrayCentros { get => arrayCentros; set => arrayCentros = value; }

        public override bool Equals(object obj)
        {
            return obj is Ciclo ciclo &&
                   idCiclo == ciclo.idCiclo &&
                   nombreCiclo == ciclo.nombreCiclo &&
                   EqualityComparer<List<Centro>>.Default.Equals(arrayCentros, ciclo.arrayCentros) &&
                   IdCiclo == ciclo.IdCiclo &&
                   NombreCiclo == ciclo.NombreCiclo &&
                   EqualityComparer<List<Centro>>.Default.Equals(ArrayCentros, ciclo.ArrayCentros);
        }

        public override int GetHashCode()
        {
            var hashCode = -1598020536;
            hashCode = hashCode * -1521134295 + idCiclo.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(nombreCiclo);
            hashCode = hashCode * -1521134295 + EqualityComparer<List<Centro>>.Default.GetHashCode(arrayCentros);
            hashCode = hashCode * -1521134295 + IdCiclo.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(NombreCiclo);
            hashCode = hashCode * -1521134295 + EqualityComparer<List<Centro>>.Default.GetHashCode(ArrayCentros);
            return hashCode;
        }
    }
}
