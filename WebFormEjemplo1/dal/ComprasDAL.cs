using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebFormEjemplo1.base2;
using WebFormEjemplo1.dto;

namespace WebFormEjemplo1.dal
{
    public class ComprasDAL
    {
        public static Compras Leer(int compraId)
        {
            var compra=new Compras();
            using(var grupo=new Model1())
            {
                compra=grupo.Compras.FirstOrDefault(c=>c.CompraId==compraId);
            }
            return compra;
        }

        public static void Eliminar(int compraId)
        {
            var compra = new Compras();
            using (var grupo = new Model1())
            {
                compra = grupo.Compras.FirstOrDefault(c => c.CompraId == compraId);
                grupo.Compras.Remove(compra); // marco el objeto compra para eliminar
                grupo.SaveChanges();
            }
        }
        public static void Modificar(Compras compra)
        {
            using (var grupo = new Model1())
            {
                Compras compraAntigua = grupo.Compras
                    .FirstOrDefault(c => c.CompraId == compra.CompraId); // prpxy

                compraAntigua.CompraId=compra.CompraId;
                compraAntigua.Cantidad=compra.Cantidad;
                compraAntigua.PrecioUnitario=compra.PrecioUnitario;
                compraAntigua.Producto=compra.Producto;

                grupo.SaveChanges();
            }
        }

        public static int Contar()
        {
            int total=0;
            using (var grupo = new Model1())
            {
                total=grupo.Compras.Count();
            }
            return total;
        }
        public static List<Compras> Listar2()
        {
            var resultado = new List<Compras>();
            using (var grupo = new Model1())
            {
                resultado=grupo.Database.SqlQuery<Compras>("select * from compras")
                    .ToList();
            }
            return resultado;
        }

        public static List<CompraDto> Listar3()
        {
            var resultado = new List<CompraDto>();
            string sql= @"select country.country Pais,count(*) Cantidad from city 
                        inner join country on city.country_id = country.country_id
                        group by country.country";
            using (var grupo = new Model1())
            {
                resultado = grupo.Database.SqlQuery<CompraDto>(sql)
                    .ToList();
            }
            return resultado;
        }

        public static void Insertar(Compras compra)
        {
            using(var grupo=new Model1() )
            {
                grupo.Compras.Add(compra);
                grupo.SaveChanges();
            }
        }
        public static List<Compras> Listar()
        {
            var resultado=new List<Compras>();
            using (var grupo = new Model1())
            {
                resultado=grupo.Compras.Include("Usuario").ToList();
               // grupo.SaveChanges();
            }
            return resultado;
        }
    }
}