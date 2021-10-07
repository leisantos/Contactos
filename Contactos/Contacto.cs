using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contactos
{
    class Contacto
    {

        private int contactoId;
        private string nombre;
        private string apellido;
        private int numeroTelefono;
        private string direccion;


        public void setcontactoId(int ContactoId)
        {
            contactoId = ContactoId;
        }

        public int getcontactoId()
        {
            return contactoId;
        }

        public void setnombre(string Nombre)
        {
            nombre = Nombre;
        }

        public string getnombre()
        {
            return nombre;
        }

        public void setapellido(string Apellido)
        {
            apellido = Apellido;
        }

        public string getapellido()
        {
            return apellido;
        }

        public void setnumeroTelefono(int NumeroTelefono)
        {
            numeroTelefono = NumeroTelefono;
        }

        public int getnumeroTelefono()
        {
            return numeroTelefono;
        }

        public void setdireccion(string Direccion)
        {
            direccion = Direccion;
        }

        public string getdireccion()
        {
            return direccion;
        }
    }
}
