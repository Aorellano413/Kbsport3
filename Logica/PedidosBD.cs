﻿using Entidades;
using Persistencia;
using System;
using System.Collections.Generic;
using System.Data;
namespace Logica
{
    public class PedidosBD
    {
        DatosPedido datos = new DatosPedido();
        DatosInventario inventarioBD = new DatosInventario();
        public int CrearPedido(Pedido pedido)
        {
            return datos.InsertarPedido(pedido);
        }
        public void AgregarDetallePedido(DetallePedido detalle)
        {
            if (detalle.Cantidad > 0)
            {

                if (detalle.Precio == 0)
                {
                    detalle.Precio = datos.ObtenerPrecioCamisa(detalle.IdCamisa);
                }

                datos.InsertarDetallePedido(detalle, detalle.IdPedido);
                inventarioBD.DescontarStockTela(detalle.IdCamisa, detalle.Cantidad);
            }
        }


        public DataTable ObtenerPedidos()
        {
            return datos.ObtenerPedidos();
        }
        public DataTable ObtenerDetallesPedido(int idPedido)
        {
            return datos.ObtenerDetallesPedido(idPedido);
        }

        public DataTable ObtenerPedidosPorRangoFechas(DateTime fechaInicio, DateTime fechaFin)
        {
            return datos.ObtenerPedidosPorRangoFechas(fechaInicio, fechaFin);
        }

        public DataTable ObtenerPedidosPorAnoKB(int ano)
        {
            return datos.ObtenerPedidosPorAnoKB(ano); 
        }


    }
}