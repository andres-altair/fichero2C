using fichero2C.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fichero2C.Servicios
{
    internal class adeudorAcredorImplementacion : aduedorAcredorInterfaz
    {
        public void infoAdeudor(List<pagoDto> pago)
        {
            pagoDto usuario = new pagoDto();

            Console.WriteLine("escribe el nombe");
            usuario.NombreDeudor = Console.ReadLine();
            Console.WriteLine("escribe el apellido");
            usuario.ApellidoDeudor = Console.ReadLine();
            Console.WriteLine("escribe tu direccion");
            usuario.DireccionDeudor = Console.ReadLine();
            Console.WriteLine("escribe el codigo postal");
            usuario.CodPostal2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("escribe la poblacion");
            usuario.Poblacion2 = Console.ReadLine();
            Console.WriteLine("escribe yu provincia/pais (mismo formato al escrito)");
            usuario.ProvinciaPais2 = Console.ReadLine();
            Console.WriteLine("escribe wl swift");
            usuario.Swift = Console.ReadLine();
            Console.WriteLine("escru¡ibe el iban");
            usuario.Iban = Convert.ToInt32(Console.ReadLine());
            usuario.ReferenciaDeOrdenDeDomiciliación1 = crearRefOrdenDomici(pago);

            pago.Add(usuario);
        }

        private int crearRefOrdenDomici(List<pagoDto> pago)
        {
            pagoDto deId = new pagoDto();
            int tamanioLista = pago.Count;
            int nuevaReferencia;
            if (tamanioLista > 0)
            {
                nuevaReferencia = pago[tamanioLista - 1].ReferenciaDeOrdenDeDomiciliación1 + 1;
            }
            else
            {
                nuevaReferencia = 1;
            }

            return nuevaReferencia;
        }

    }
}
