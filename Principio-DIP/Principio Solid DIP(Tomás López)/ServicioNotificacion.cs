using System;
using System.Collections.Generic;
using System.Text;

namespace Principio_Solid_DIP_Tomás_López_
{
    public class ServicioNotificacion
    {
        private readonly IEnviadorMensajes _enviadorMensajes;
    
    public ServicioNotificacion(IEnviadorMensajes enviadorMensajes)
        {
            _enviadorMensajes = enviadorMensajes;
        }
        public void Notificar(string mensaje)
        {
            _enviadorMensajes.EnviarMensaje(mensaje);
        }
    }
}


