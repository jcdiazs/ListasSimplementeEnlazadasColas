using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListasSimplementeEnlazadas
{
    class ListaSimplementeEnlazada
    {

        public Nodo primero = null;
        public Nodo ultimo = null;

        private bool VaciaCola()
        {
            if (ultimo == null)
                return true;
            else
                return false;
        }

        public void InsertarCola(int elemento)
        {
            Nodo p;
            if(VaciaCola())
            {
                ultimo = new Nodo();
                ultimo.Informacion = elemento;
                ultimo.Enlace = null;
                primero = ultimo;
            }
            else
            {
                p = new Nodo();
                p.Informacion = elemento;
                //p.Enlace = ultimo;
                ultimo.Enlace = p;
                ultimo = p;
            }
        }

        public void EliminarCola()
        {
            Nodo p;
            if (VaciaCola())
                MessageBox.Show("La cola esta vacia. no se puede eliminar mas elementos");
            else
            {
                MessageBox.Show("Elemento eliminado es:" + primero.Informacion);
                p = primero;
                primero = primero.Enlace;
                p.Enlace = null;
                p = null;
            }
        }
    }
}
