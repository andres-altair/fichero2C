using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fichero2C.Dtos
{
    internal class pagoDto
    {
        int ReferenciaDeOrdenDeDomiciliación;
        int IdentificadorDelAcreedor = 1124343454;
        string nombreDelAcredor = "aaaaaa";
        string direccion = "aaaaaaa";
        int codPostal = 41008;
        string poblacion = "Sevilla";
        string provinciaPais = "Sevilla/Espania";
        string nombreDeudor = "aaaaaa";
        string apellidoDeudor = "aaaaa";
        string direccionDeudor = "aaaaaa";
        int codPostal2 = 12345;
        string poblacion2 = "aaaaaa";
        string provinciaPais2 = "aaaaaaa";
        int iban = 112345678;
        string swift = "aaaaa";

        
        public pagoDto() { }

        public pagoDto(int referenciaDeOrdenDeDomiciliación, int identificadorDelAcreedor, string nombreDelAcredor, string direccion, int codPostal, string poblacion, string provinciaPais, string nombreDeudor, string apellidoDeudor, string direccionDeudor, int codPostal2, string poblacion2, string provinciaPais2, int iban, string swift)
        {
            ReferenciaDeOrdenDeDomiciliación = referenciaDeOrdenDeDomiciliación;
            IdentificadorDelAcreedor = identificadorDelAcreedor;
            this.nombreDelAcredor = nombreDelAcredor;
            this.direccion = direccion;
            this.codPostal = codPostal;
            this.poblacion = poblacion;
            this.provinciaPais = provinciaPais;
            this.nombreDeudor = nombreDeudor;
            this.apellidoDeudor = apellidoDeudor;
            this.direccionDeudor = direccionDeudor;
            this.codPostal2 = codPostal2;
            this.poblacion2 = poblacion2;
            this.provinciaPais2 = provinciaPais2;
            this.iban = iban;
            this.swift = swift;
        }

        public int ReferenciaDeOrdenDeDomiciliación1 { get => ReferenciaDeOrdenDeDomiciliación; set => ReferenciaDeOrdenDeDomiciliación = value; }
        public int IdentificadorDelAcreedor1 { get => IdentificadorDelAcreedor; set => IdentificadorDelAcreedor = value; }
        public string NombreDelAcredor { get => nombreDelAcredor; set => nombreDelAcredor = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public int CodPostal { get => codPostal; set => codPostal = value; }
        public string Poblacion { get => poblacion; set => poblacion = value; }
        public string ProvinciaPais { get => provinciaPais; set => provinciaPais = value; }
        public string NombreDeudor { get => nombreDeudor; set => nombreDeudor = value; }
        public string ApellidoDeudor { get => apellidoDeudor; set => apellidoDeudor = value; }
        public string DireccionDeudor { get => direccionDeudor; set => direccionDeudor = value; }
        public int CodPostal2 { get => codPostal2; set => codPostal2 = value; }
        public string Poblacion2 { get => poblacion2; set => poblacion2 = value; }
        public string ProvinciaPais2 { get => provinciaPais2; set => provinciaPais2 = value; }
        public int Iban { get => iban; set => iban = value; }
        public string Swift { get => swift; set => swift = value; }
    }
}
