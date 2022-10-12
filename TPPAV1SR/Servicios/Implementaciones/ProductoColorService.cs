using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPPav1.Datos.Daos;
using TPPav1.Datos.Interfaces;
using TPPav1.Entidades;
using TPPav1.Servicios.Interfaces;

namespace TPPav1.Servicios.Implementaciones
{
    class ProductoColorService : IProductoColorService
    {
        private IPColor dao;
        public ProductoColorService()
        {
            dao = new PColorDao();
        }
        public List<ProductoColor> traerTodosPrC()
        {
            return dao.RecuperarTodosPrC();
        }
    }
}
