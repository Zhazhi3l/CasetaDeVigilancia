using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasetaDeVigilancia.src.Datos.Datos.Modelos
{
    public class Residente
    {
        public int ResidenteID { get; set; }
        public string Nombre { get; set; }
        public string ApellidoPaterno { get; set; }
        public string ApellidoMaterno { get; set; }
        public int NumeroCasa { get; set; }
        public string Calle { get; set; }
        public string Telefono { get; set; }
        public string Correo { get; set; }
        public DateTime FechaRegistro { get; set; }

        // Relaciones
        public virtual ICollection<Invitado> Invitados { get; set; }
        public virtual ICollection<HistorialAcceso> Historiales { get; set; }

    }
}
