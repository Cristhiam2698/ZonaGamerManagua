using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ZonaGamerN.Data;

namespace ZonaGamerN.IRepositorio
{
    public interface IProductoRepositorio
    {
        List<Producto> GetProductos();
        Producto GetById(int Idproducto);
        Producto SaveOrUpdate(Producto oProducto);
        string Delete(int Idproducto);


    }
}
