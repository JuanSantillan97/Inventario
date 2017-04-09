using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventario
{
    class Almacen
    {
        private Producto[] _productos = new Producto[15];
        private int contador = 0;

        public string agregarProducto(Producto producto)
        {

            //if (producto.codigo != producto.codigo)
            //{
                if (contador < 15)
                {
                    _productos[contador] = producto;
                    contador++;
                }
            //}
            return "Nuevo producto agregado";
        }
        public Producto buscarProducto(int codigo)
        {
            Producto producto = null;
            for(int i=0;i<contador;i++)
            {
                if (codigo == _productos[i].codigo)
                {
                    producto = _productos[i];
                }
            }
            return producto;
        }
        public string reporte()
        {
            string producto = "";
            for(int i=0;i<contador;i++)
            {
                producto += _productos[i].ToString();
            }
            return producto;
        }
        public void eliminarProducto(int codigo)
        {
            for(int i=0;i<contador;i++)
            {
                if(codigo==_productos[i].codigo)
                {
                    for(int j= i;j<contador-1;j++)
                    {
                        _productos[j] = _productos[j+1];  
                    }
                    _productos[contador - 1] = null;
                    contador--;
                    break;
                }
            }
        }
        public string insertarProducto(int posicion, Producto producto)
        {
            if (contador < 15)
            {
                for (int i = _productos.Length - 1; i >= posicion; i--)
                {
                    _productos[i] = _productos[i - 1];
                }
                _productos[posicion - 1] = producto;
                contador++;
                return "Producto insertado";
            }
            else
                return "El inventario ya esta lleno";
        }
        public override string ToString()
        {
            return Convert.ToString(contador);
        }

    }
}
