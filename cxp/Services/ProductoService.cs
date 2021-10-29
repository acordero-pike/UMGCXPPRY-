<<<<<<< HEAD
﻿using cxp.data.Repository;
using cxp.Data;
using cxp.Interface;
using cxp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
=======
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using cxp.Model;
using cxp.Interfaces;
using System.Data.SqlClient;
using cxp.Data;
using cxp.data;


>>>>>>> main

namespace cxp.Services
{
    public class ProductoService : IProductoService
    {
        private readonly SqlConfiguration _configuration;
<<<<<<< HEAD
        private IProductoRepository _productoRepository;

        public ProductoService(SqlConfiguration configuration)
        {
            _configuration = configuration;
            _productoRepository = new ProductoRepository(configuration.ConnectionString);
        }

        public Task<IEnumerable<Productos>> GetAllProductos()
        {
            return _productoRepository.GetAllProductos();
        }

        public Task<Productos> GetProductosDetalles(int id)
        {
            return _productoRepository.GetProductosDetalles(id);
        }
    }
}
=======
        private IProductoRepository _ProductoRepository; 
        public ProductoService(SqlConfiguration configuration)
        {
            _configuration = configuration;
            _ProductoRepository = new ProductoRepository(configuration.ConnectionString);
        }
        public Task<bool> DeleteProducto(int id)
        {
            return _ProductoRepository.DeleteProducto(id);
        }

        public Task<IEnumerable<Producto>> GetAllProducto()
        {
            return _ProductoRepository.GetAllProducto();
        }

        public Task<Producto> GetProductoDetails(int id)
        {
            return _ProductoRepository.GetProductoDetails(id);
        }

        public Task<bool> SaveProducto(Producto producto)
        {
            if (producto.IDProducto == 0)
                return _ProductoRepository.InsertProducto(producto);
            else
                return _ProductoRepository.UpdateProducto(producto);
        }
    }




}

>>>>>>> main
