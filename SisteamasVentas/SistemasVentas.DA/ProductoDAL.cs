﻿using SistemasVentas.Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace SistemasVentas.DAL
{
    public class ProductoDAL
    {
        public DataTable ListarProductoDal()
        {
            string consulta = "OMBRE AS TIPOPROD, P.NOMBRE, P.CODIGOBARRA, M.NOMBRE, P.UNIDAD, P.DESCRIPCION, P.ESTADO\r\nFROM PRODUCTO P\r\n\tINNER JOIN TIPOPROD TP ON TP.IDTIPOPROD = P.IDTIPOPROD\r\n\tINNER JOIN MARCA M ON M.IDMARCA = P.IDMARCA";
            DataTable Lista = conexion.EjecutarDataTabla(consulta, "tabla");
            return Lista;
        }

        public void InsertarProductoDAL(Producto producto)
        {
            string consulta = "insert into producto values(" + producto.IdTipoProd + "," +
                                                          "" + producto.IdMarca + "," +
                                                          "'" + producto.Nombre + "'," +
                                                          "'" + producto.CodigoBarra + "'," +
                                                          "'" + producto.Unidad + "'," +
                                                          "'" + producto.Descripcion + "'," +
                                                          "'Activo')";
            conexion.Ejecutar(consulta);
        }

        public Producto ObtenerProductoIdDal(int id)
        {
            string consulta = "select * from producto where idproducto=" + id;
            DataTable tabla = conexion.EjecutarDataTabla(consulta, "asdas");
            Producto p= new Producto();
            if (tabla.Rows.Count > 0)
            {
                p.IdProducto = Convert.ToInt32(tabla.Rows[0]["idproducto"]);
                p.IdTipoProd = Convert.ToInt32(tabla.Rows[0]["idtipoprod"]);
                p.IdMarca = Convert.ToInt32(tabla.Rows[0]["idmarca"]);
                p.Nombre = tabla.Rows[0]["nombre"].ToString();
                p.CodigoBarra = tabla.Rows[0]["codigobarra"].ToString();
                p.Unidad = Convert.ToInt32(tabla.Rows[0]["unidad"]);
                p.Descripcion = tabla.Rows[0]["descripcion"].ToString();
                p.Estado = tabla.Rows[0]["estado"].ToString();
            }
            return p;

        }

        public void EditarProductoDal(Producto p)
        {
            string consulta = "update producto set idtipoprod=" + p.IdTipoProd + "," +
                                                        "idmarca=" + p.IdMarca + "," +
                                                        "nombre='" + p.Nombre + "'," +
                                                        "codigobarra='" + p.CodigoBarra + "'," +
                                                        "unidad=" + p.Unidad + "," +
                                                        "descripcion='" + p.Descripcion + "'," +
                                                        "estado='" + p.Estado + "' " +
                                                "where idproducto=" + p.IdProducto;
            conexion.Ejecutar(consulta);
        }
        public void EliminarProductoDal(int id)
        {
            string consulta = "delete from producto where idproducto=" + id;
            conexion.Ejecutar(consulta);
        }
    }
}
