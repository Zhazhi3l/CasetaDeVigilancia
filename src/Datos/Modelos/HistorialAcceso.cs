using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasetaDeVigilancia.src.Datos.Datos.Modelos
{
    public class HistorialAcceso
    {
        public int HistorialID { get; set; }
        public DateTime FechaEntrada { get; set; }
        public DateTime? FechaSalida { get; set; }

        // FK a Residente/Usuario
        public int ResidenteID { get; set; }
        public virtual Residente Residente { get; set; }

        // FK a Invitado
        public int InvitadoID { get; set; }
        public virtual Invitado Invitado { get; set; }
    }
}
