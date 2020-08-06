using System;
using System.Net.Mail;

namespace envio_correo
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                Console.WriteLine("No se enviaron parametros");
            }
            else
            {
                string folio = "1010101";
                string empleado = "Juan Perez Lopez";
                string aprobador = "Maria Sanchez Marquez";
                string destino = args.Length == 2 ? args[1] : "rodrigo290883@gmail.com";
                string solicitud = "Vacaciones";
                string fecha_inicio = "2020-07-18";
                string fecha_fin = "2020-07-23";
                string fecha_solicitud = "2020-06-29";
                string observacion = "Prueba de envio de correos";
                string observacion_aprobador = "Prueba de envio de correos";
                string estatus = "Pendiente";

                

                if (args[0] == "1")
                {
                    try
                    {
                        string origen = "envio.correos.sistemas@gmail.com";

                        string pass = "244466666";
                        string asunto = "Recordatorio de Solicitud pendiente de Aprobacion Folio:" + folio;
                        string mensage = "<head><style>img{width:100%;padding:0px;margin:0px;}tr{background-image:url('https://i.postimg.cc/FzTgvcWz/cuerpo-mail.png'); background-repeat: repeat-y;background-size:100% 100%; padding:0px; margin:0px;}td{padding:0px; margin:0px;}</style></head><table style='padding:0px;marging:0px;border:0px;border-collapse: collapse;border-spacing:0px;'><tr><td><img src='https://i.postimg.cc/1319y6Dv/encabezado-mail.png' /></td></tr><tr><td style='padding:5% 5%; color:#b41547; font-size: 18px; text-align: center;'>Se realizo una solicitud de vacaciones por parte de:<br>" + empleado + "</td></tr><tr><td style='padding:0% 5%; color: #5c2a7e; font-size: 18px; text-align: left;'>Tipo Solicitud: " + solicitud + "</td></tr><tr><td style='padding:0% 5%; color: #5c2a7e; font-size: 18px; text-align: left;'>Fecha Inicio: " + fecha_inicio + "</td></tr><tr><td style=' padding:0% 5%; color: #5c2a7e; font-size: 18px; text-align: left;'>Fecha Fin: " + fecha_fin + "</td></tr><tr><td style=' padding:0% 5%; color: #5c2a7e; font-size: 18px; text-align: left;'>Observacion Solicitante: " + observacion + "</td></tr><tr><td style=' padding:5% 5%; color:#b41547; font-size: 18px; text-align: center; '>Favor de ingresar al sitio de <a href='#'>vacaciones</a> para su aprobacion.</td></tr><tr><td><img src='https://i.postimg.cc/hvSK9qPN/pie-mail.png' /></td></tr></table>";


                        MailMessage correo = new MailMessage(origen, destino);
                        correo.IsBodyHtml = true;
                        correo.Subject = asunto;
                        correo.Body = mensage;

                        SmtpClient cliente = new SmtpClient();
                        cliente.Host = "smtp.gmail.com";
                        cliente.EnableSsl = true;
                        cliente.Port = 587;
                        cliente.UseDefaultCredentials = false;
                        cliente.Credentials = new System.Net.NetworkCredential(origen, pass);

                        cliente.Send(correo);
                        cliente.Dispose();

                        Console.WriteLine("Correo de Solicitud Enviado");


                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Error: " + ex.ToString());
                    }
                }
                else
                {
                    try
                    {
                        string origen = "envio.correos.sistemas@gmail.com";

                        string pass = "244466666";
                        string asunto = "Cambio de Estatus de la Solicitud Folio:" + folio;
                        string mensage = "<head><style>img{width:100%;padding:0px;margin:0px;}tr{background-image:url('https://i.postimg.cc/FzTgvcWz/cuerpo-mail.png'); background-repeat: repeat-y;background-size:100% 100%; padding:0px; margin:0px;}td{padding:0px; margin:0px;}</style></head><table style='padding:0px;marging:0px;border:0px;border-collapse: collapse;border-spacing:0px;'><tr><td><img src='https://i.postimg.cc/1319y6Dv/encabezado-mail.png' /></td></tr><tr><td style='padding:5% 5%; color:#b41547; font-size: 18px; text-align: center;'>Se realizo un cambio de estatus de la  solicitud de vacaciones, por parte de:<br>" + aprobador + "</td></tr><tr><td style='padding:0% 5%; color: #5c2a7e; font-size: 18px; text-align: left;'>Solicitante: " + empleado + "</td></tr><tr><td style='padding:0% 5%; color: #5c2a7e; font-size: 18px; text-align: left;'>Tipo Solicitud: " + solicitud + "</td></tr><tr><td style='padding:0% 5%; color: #5c2a7e; font-size: 18px; text-align: left;'>Fecha Solicitud: " + fecha_solicitud + "</td><tr><td style='padding:0% 5%; color: #5c2a7e; font-size: 18px; text-align: left;'>Fecha Inicio: " + fecha_inicio + "</td></tr><tr><td style=' padding:0% 5%; color: #5c2a7e; font-size: 18px; text-align: left;'>Fecha Fin: " + fecha_fin + "</td></tr><tr><td style=' padding:0% 5%; color: #5c2a7e; font-size: 18px; text-align: left;'>Observacion Solicitante: " + observacion + "</td></tr><tr><td style=' padding:5% 5% 0% 5%; color:#b41547; font-size: 18px; text-align: center; '>Nuevo estatus: " + estatus + "</td></tr><tr><td style=' padding:0% 5%; color:#b41547; font-size: 18px; text-align: left; '> Observacion Aprobador: " + observacion_aprobador + "</td></tr><tr><td><img src='https://i.postimg.cc/hvSK9qPN/pie-mail.png' /></td></tr></table>";


                        MailMessage correo = new MailMessage(origen, destino);
                        correo.IsBodyHtml = true;
                        correo.Subject = asunto;
                        correo.Body = mensage;

                        SmtpClient cliente = new SmtpClient();
                        cliente.Host = "smtp.gmail.com";
                        cliente.EnableSsl = true;
                        cliente.Port = 587;
                        cliente.UseDefaultCredentials = false;
                        cliente.Credentials = new System.Net.NetworkCredential(origen, pass);

                        cliente.Send(correo);
                        cliente.Dispose();

                        Console.WriteLine("Correo de Aprobacion Enviado");

                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Error: " + ex.ToString());
                    }
                }


            }
                
            
        }
    }
}
