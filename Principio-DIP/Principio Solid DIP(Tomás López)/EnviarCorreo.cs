using System;
using System.Collections.Generic;
using System.Text;

namespace Principio_Solid_DIP_Tomás_López_
{
    public class EnviarCorreo : IEnviadorMensajes
    {
        public void EnviarMensaje(string mensaje)
        {
            Console.WriteLine($"Enviando correo con el mensaje: {mensaje}");
        }
    }
}
