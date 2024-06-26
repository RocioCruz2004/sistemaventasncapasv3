﻿using SistemasVentas.Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemasVentas.DAL
{
    public class ClienteDAL
    {
        public DataTable ListarClienteDal()
        {
            string consulta = "SELECT P.NOMBRE + ' ' + P.APELLIDO AS [NOMBRE CLIENTE], TIPOCLIENTE, CODIGOCLIENTE, C.ESTADO\r\nFROM CLIENTE C\r\n\tINNER JOIN PERSONA P ON C.IDPERSONA = P.IDPERSONA";
            DataTable Lista = conexion.EjecutarDataTabla(consulta, "tabla");
            return Lista;
        }
        public void InsertarClienteDAL(Cliente cliente)
        {
            string consulta = "insert into cliente values("+cliente.IdPersona+"," +
                                                          "'" + cliente.TipoCliente + "'," +
                                                          "'" + cliente.CodigoCliente + "'," +
                                                          "'Activo')";
            conexion.Ejecutar(consulta);
        }

        public Cliente ObtenerClienteIdDal(int id)
        {
            string consulta = "select * from cliente where idcliente=" + id;
            DataTable tabla = conexion.EjecutarDataTabla(consulta, "asdas");
            Cliente c = new Cliente();
            if (tabla.Rows.Count > 0)
            {
                c.IdCliente = Convert.ToInt32(tabla.Rows[0]["idcliente"]);
                c.IdPersona = Convert.ToInt32(tabla.Rows[0]["idpersona"]);
                c.TipoCliente = tabla.Rows[0]["tipocliente"].ToString();
                c.CodigoCliente = tabla.Rows[0]["codigocliente"].ToString();
                c.Estado = tabla.Rows[0]["estado"].ToString();
            }
            return c;

        }
        public void EditarClienteDal(Cliente c)
        {
            string consulta = "update cliente set idpersona=" + c.IdPersona + "," +
                                                        "tipocliente='" + c.TipoCliente + "'," +
                                                        "codigocliente='" + c.CodigoCliente + "'" +
                                                "where idcliente=" + c.IdCliente;
            conexion.Ejecutar(consulta);
        }
        public void EliminarClienteDal(int id)
        {
            string consulta = "delete from cliente where idcliente=" + id;
            conexion.Ejecutar(consulta);
        }
    }
}
