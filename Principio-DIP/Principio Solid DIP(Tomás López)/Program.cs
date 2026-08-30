using Principio_Solid_DIP_Tomás_López_;

IEnviadorMensajes enviador = new EnviarCorreo();
ServicioNotificacion servicio = new ServicioNotificacion(enviador);
servicio.Notificar("Hola, este es un mensaje de prueba");
