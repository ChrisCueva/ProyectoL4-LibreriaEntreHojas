using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntreHojas.BL
{
    public class ProductosBL
    {
        Contexto _contexto = new Contexto();

        public ProductosBL()
        {
            _contexto = new Contexto();
        }

        public List<Producto> ObtenerProductos()
        {
            _contexto.Productos.ToList();

            var producto1 = new Producto();
            producto1.Id = 1;
            producto1.Descripcion = "Hombres sin Mujeres";
            producto1.Autor = "Haruki Murakami";
            producto1.Precio = 450;
            producto1.Existencia = 15;

            var producto2 = new Producto();
            producto2.Id = 2;
            producto2.Descripcion = "Norwegian Wood";
            producto2.Autor = "Haruki Murakami";
            producto2.Precio = 350;
            producto2.Existencia = 20;

            var producto3 = new Producto();
            producto3.Id = 3;
            producto3.Descripcion = "A Wild Sheep Chase";
            producto3.Autor = "Haruki Murakami";
            producto3.Precio = 380;
            producto3.Existencia = 10;

            var producto4 = new Producto();
            producto4.Id = 4;
            producto4.Descripcion = "El Perfume";
            producto4.Autor = "Patrick Süsckind";
            producto4.Precio = 480;
            producto4.Existencia = 30;

            var producto5 = new Producto();
            producto5.Id = 5;
            producto5.Descripcion = "The Fifth Wave";
            producto5.Autor = "Rick Yancey";
            producto5.Precio = 345;
            producto5.Existencia = 5;

            var producto6 = new Producto();
            producto6.Id = 6;
            producto6.Descripcion = "The Infinite Sea";
            producto6.Autor = "Rick Yancey";
            producto6.Precio = 300;
            producto6.Existencia = 15;

            var listadeProductos = new List<Producto>();
            listadeProductos.Add(producto1);
            listadeProductos.Add(producto2);
            listadeProductos.Add(producto3);
            listadeProductos.Add(producto4);
            listadeProductos.Add(producto5);
            listadeProductos.Add(producto6);

            return listadeProductos;
        }
    }
}
