using fichero2C.Dtos;
using fichero2C.Servicios;
using System.Collections.Concurrent;

namespace fichero2C.Controladores
{
    class Program
    {
        static void Main(string[] args)
        {
            string rutaFichero = "C:\\Users\\Trabajo\\Desktop\\";
            List<pagoDto> adeuda = new List<pagoDto>();
            pagoDto usuario = new pagoDto();
            aduedorAcredorInterfaz aa = new adeudorAcredorImplementacion();
       
            
            string respuesta;
            do
            {
                aa.infoAdeudor(adeuda);
                Console.WriteLine("¿Introducirá otro cliente? (s/n): ");
                respuesta = Console.ReadLine();

            } while (respuesta.Equals("s"));
            string rutaArchivo = usuario.NombreDeudor + usuario.ApellidoDeudor;
            
            string contenido =
            "------------------------------------------------------------------------------------------------\n" +
            "Referencia de la Orden de Domiciliacion        " + usuario.ReferenciaDeOrdenDeDomiciliación1 + "\n" +
            "Identificador del Acredor                     " + usuario.IdentificadorDelAcreedor1 + "\n" +
            "Nombre del Acreedor                           " + usuario.NombreDelAcredor + "\n" +
            "Direccion                                     " + usuario.Direccion + "\n" +
            "Codigo Postal-Poblacion-Provincia/Pais        " + usuario.CodPostal + " " + usuario.Poblacion + " " + usuario.ProvinciaPais + "\n" +
            "------------------------------------------------------------------------------------------------" + "\n" +
            "Nombre del Deudor/es/                          " + usuario.NombreDeudor + "\n" +
            "Direccion del deudor                           " + usuario.DireccionDeudor + "\n" +
            "Codigo Postal-Poblacion-Provincia/Pais        " + usuario.CodPostal2 + " " + usuario.Poblacion2 + " " + usuario.ProvinciaPais2 + "\n" +
            "Numero de cuanta - IBAN                                   Swift \n" +
            "" + usuario.Iban + "                                      " + usuario.Swift + "\n" +
            "                                     " + "Tipo de pago" + "          R             U\n" +
            "-------------------------------------------------------------------------------------------------";

            foreach (pagoDto cliente in adeuda)
            {
                string[] nombreDesagregado = cliente.NombreDeudor.Split(" ");
                string nombreFichero = nombreDesagregado[0] + nombreDesagregado[1] + ".txt";
                string rutaCompletaFichero = rutaFichero + nombreFichero;

                using (StreamWriter ficheroAdeudo = new StreamWriter(rutaCompletaFichero))
                {
                    ficheroAdeudo.Write(contenido);
                };
            }

        }
    }
}