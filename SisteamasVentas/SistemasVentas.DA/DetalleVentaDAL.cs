using SistemasVentas.Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemasVentas.DAL
{
    public class DetalleVentaDAL
    {
        public DataTable ListarDetalleVentaDal()
        {
            string consulta = "SELECT PE.NOMBRE + ' ' + PE.APELLIDO AS NOMBRECLIENTE, U.NOMBREUSER AS VENDEDOR, V.FECHA, V.TOTAL, TP.NOMBRE AS TIPOPRODUCTO, P.NOMBRE AS NOMBREPRODUCTO, P.CODIGOBARRA, P.IDMARCA, P.DESCRIPCION, DV.CANTIDAD, DV.PRECIOVENTA, DV.SUBTOTAL, DV.ESTADO\r\nFROM DETALLEVENTA DV\r\n\tINNER JOIN PRODUCTO P ON DV.IDPRODUCTO = P.IDPRODUCTO\r\n\tINNER JOIN VENTA V ON V.IDVENTA = DV.IDVENTA\r\n\tINNER JOIN TIPOPROD TP ON TP.IDTIPOPROD = P.IDTIPOPROD\r\n\tINNER JOIN CLIENTE C ON C.IDCLIENTE = V.IDCLIENTE\r\n\tINNER JOIN USUARIO U ON U.IDUSUARIO = V.IDVENDEDOR\r\n\tINNER JOIN PERSONA PE ON PE.IDPERSONA = C.IDPERSONA";
            DataTable Lista = conexion.EjecutarDataTabla(consulta, "tabla");
            return Lista;
        }
        public void InsertarDetalleVentaDAL(DetalleVenta detalleventa)
        {
            string consulta = "insert into detalleventa values(" + detalleventa.IdVenta + "," +
                                                          "" + detalleventa.IdProducto + "," +
                                                          "'" + detalleventa.Cantidad + "'," +
                                                          "'" + detalleventa.PrecioVenta + "'," +
                                                          "'" + detalleventa.SubTotal + "'," +
                                                          "'Exitoso')";
            conexion.Ejecutar(consulta);
        }
        DetalleVenta p = new DetalleVenta();
        public DetalleVenta ObtenerDetalleVentaIdDal(int id)
        {
            string consulta = "select * from detalleventa where iddetalleventa=" + id;
            DataTable tabla = conexion.EjecutarDataTabla(consulta, "asdas");
            if (tabla.Rows.Count > 0)
            {
                p.IdDetaleVenta = Convert.ToInt32(tabla.Rows[0]["iddetalleventa"]);
                p.IdVenta = Convert.ToInt32(tabla.Rows[0]["idventa"]);
                p.IdProducto = Convert.ToInt32(tabla.Rows[0]["idproducto"]);
                p.Cantidad = Convert.ToInt32(tabla.Rows[0]["cantidad"]);
                p.PrecioVenta = Convert.ToDecimal(tabla.Rows[0]["precioventa"]);
                p.SubTotal = Convert.ToDecimal(tabla.Rows[0]["subtotal"]);
                p.Estado = tabla.Rows[0]["estado"].ToString();
            }
            return p;
        }
        public void EditarDetalleVentaDal(DetalleVenta p)
        {
            string consulta = "update detalleventa set idventa=" + p.IdVenta + "," +
                                                        "idproducto=" + p.IdProducto + "," +
                                                        "cantidad=" + p.Cantidad + "," +
                                                        "precioventa=" + p.PrecioVenta + "," +
                                                        "subtotal=" + p.SubTotal + " " +
                                                "where iddetalleventa=" + p.IdDetaleVenta;
            conexion.Ejecutar(consulta);
        }
        public void EliminarDetalleVentaDal(int id)
        {
            string consulta = "delete from detalleventa where iddetalleventa=" + id;
            conexion.Ejecutar(consulta);
        }
    }
}
