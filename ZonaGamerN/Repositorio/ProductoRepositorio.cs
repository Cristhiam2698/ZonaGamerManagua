using Dapper;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using ZonaGamerN.Data;
using ZonaGamerN.IRepositorio;

namespace ZonaGamerN.Repositorio
{
    public class ProductoRepositorio : IProductoRepositorio
    {
        List<Producto> _oProductos = new List<Producto>();
        Producto _oProducto = new Producto();
        public IConfiguration _Configuration { get; }
        public string _connectionString = "";

        public ProductoRepositorio(IConfiguration configuration)
        {
            _Configuration = configuration;
            _connectionString = _Configuration.GetConnectionString("sqlConnection");
        }

        public List<Producto> GetProductos()
        {
            _oProductos = new List<Producto>();
            using (IDbConnection con = new SqlConnection(_connectionString))
            {
                if (con.State == ConnectionState.Closed) con.Open();
                var oProductos = con.Query<Producto>("SELECT * FROM Producto").ToList();
                if (oProductos != null && oProductos.Count() > 0)
                {
                    _oProductos = oProductos;
                }
            }
            return _oProductos;
        }

        public Producto GetById(int Idproducto)
        {
            _oProducto = new Producto();
            using (IDbConnection con = new SqlConnection(_connectionString))
            {
                if (con.State == ConnectionState.Closed) con.Open();
                var oProductos = con.Query<Producto>("SELECT * FROM Producto WHERE Id_Producto=" + Idproducto);
                if (oProductos != null && oProductos.Count() > 0)
                {
                    _oProducto = oProductos.FirstOrDefault();
                }
            }
            return _oProducto;
        }

        public Producto SaveOrUpdate(Producto oProducto)
        {
            _oProducto = new Producto();
            using (IDbConnection con = new SqlConnection(_connectionString))
            {
                if (con.State == ConnectionState.Closed) con.Open();


                int operationType = Convert.ToInt32(oProducto.Id_Producto == 0 ? OperationType.Insert : OperationType.Update);
                var oProductos = con.Query<Producto>("SP_Producto"
                    , this. SetParameters(oProducto, operationType),
                    commandType:CommandType.StoredProcedure);
                if (oProductos != null && oProductos.Count() >0)
                {
                    _oProducto = oProductos.FirstOrDefault();
                }
            }
            return _oProducto;
        }

        public string Delete(int Idproducto)
        {
            string message = "Failed";
            using (IDbConnection con = new SqlConnection(_connectionString))
            {
                _oProducto = new Producto()
                {
                    Id_Producto = Idproducto
                };

                if (con.State == ConnectionState.Closed) con.Open();
               con.Query<Producto>("SP_Producto", this.SetParameters(_oProducto, (int)OperationType.Delete),
                      commandType: CommandType.StoredProcedure);

                message = "Deleted";
            }
            return message;
        }
        private DynamicParameters SetParameters(Producto oProducto, int nOperationtype)
        {
            DynamicParameters obj = new DynamicParameters();
            obj.Add("@Id_Producto", oProducto.Id_Producto);
            obj.Add("@Nombre", oProducto.Nombre);
            obj.Add("@Categoria", oProducto.Categoria);
            obj.Add("@Marca", oProducto.Marca);
            obj.Add("@Precio_Compra", oProducto.Precio_Compra);
            obj.Add("@Precio_Venta", oProducto.Precio_Venta);
            obj.Add("@Descripcion", oProducto.Descripcion);
            obj.Add("@Operationtype", nOperationtype);
            return obj;
        }
    } 
}
 