using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebFormEjemplo1.base2;

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