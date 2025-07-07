using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasetaDeVigilancia.src.Datos.Datos.Modelos
{
    public class Invitado
    {
        public int InvitadoID { get; set; }
        public string Nombre { get; set; }
        public string ApellidoPaterno { get; set; }
        public string ApellidoMaterno { get; set; }
        public DateTime FechaVigencia { get; set; }
        public bool Estatus { get; set; }

        // FK
        public int ResidenteID { get; set; }
        public Residente Residente { get; set; }
    }
}
