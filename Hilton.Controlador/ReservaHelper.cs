using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hilton.Modelo;

namespace Hilton.Controlador
{
    public class ReservaHelper
    {

        Datos cnGeneral = null;
        Reserva objReserva = null;
        DataTable tblDatos = null;


        public ReservaHelper(Reserva parReserva)
        {
            objReserva = parReserva;
        }


        public DataTable Listar()
        {

            tblDatos = new DataTable();

            try
            {
                cnGeneral = new Datos();

                SqlParameter[] parParameter = new SqlParameter[1];

                parParameter[0] = new SqlParameter();
                parParameter[0].ParameterName = "@opc";
                parParameter[0].SqlDbType = SqlDbType.Int;
                parParameter[0].SqlValue = objReserva.Opc;


                tblDatos = cnGeneral.RetornaTabla(parParameter, "SPReserva");

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return tblDatos;
        }

        public void Guardar()
        {
            try
            {
                cnGeneral = new Datos();

                SqlParameter[] parParameter = new SqlParameter[10];

                parParameter[0] = new SqlParameter();
                parParameter[0].ParameterName = "@opc";
                parParameter[0].SqlDbType = SqlDbType.Int;
                parParameter[0].SqlValue = objReserva.Opc;

                parParameter[1] = new SqlParameter();
                parParameter[1].ParameterName = "@codigoReservacion";
                parParameter[1].SqlDbType = SqlDbType.VarChar;
                parParameter[1].Size = 30;
                parParameter[1].SqlValue = objReserva.CodigoReservacion;

                parParameter[2] = new SqlParameter();
                parParameter[2].ParameterName = "@cedula";
                parParameter[2].SqlDbType = SqlDbType.VarChar;
                parParameter[2].Size = 30;
                parParameter[2].SqlValue = objReserva.Cedula;

                parParameter[3] = new SqlParameter();
                parParameter[3].ParameterName = "@nombreCliente";
                parParameter[3].SqlDbType = SqlDbType.VarChar;
                parParameter[3].Size = 30;
                parParameter[3].SqlValue = objReserva.NombreCliente;

                parParameter[4] = new SqlParameter();
                parParameter[4].ParameterName = "@nombreHotel";
                parParameter[4].SqlDbType = SqlDbType.VarChar;
                parParameter[4].Size = 30;
                parParameter[4].SqlValue = objReserva.NombreHotel;

                parParameter[5] = new SqlParameter();
                parParameter[5].ParameterName = "@numeroHabitacion";
                parParameter[5].SqlDbType = SqlDbType.VarChar;
                parParameter[5].Size = 30;
                parParameter[5].SqlValue = objReserva.NumeroHabitacion;

                parParameter[6] = new SqlParameter();
                parParameter[6].ParameterName = "@desdeFecha";
                parParameter[6].SqlDbType = SqlDbType.VarChar;
                parParameter[6].Size = 30;
                parParameter[6].SqlValue = objReserva.DesdeFecha;

                parParameter[7] = new SqlParameter();
                parParameter[7].ParameterName = "@hastaFecha";
                parParameter[7].SqlDbType = SqlDbType.VarChar;
                parParameter[7].Size = 30;
                parParameter[7].SqlValue = objReserva.HastaFecha;

                parParameter[8] = new SqlParameter();
                parParameter[8].ParameterName = "@porcentajeTarifa";
                parParameter[8].SqlDbType = SqlDbType.VarChar;
                parParameter[8].Size = 30;
                parParameter[8].SqlValue = objReserva.PorcentajeTarifa;

                parParameter[9] = new SqlParameter();
                parParameter[9].ParameterName = "@tarifa";
                parParameter[9].SqlDbType = SqlDbType.VarChar;
                parParameter[9].Size = 30;
                parParameter[9].SqlValue = objReserva.Tarifa;

                cnGeneral.EjecutarSP(parParameter, "SPReserva");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }


        }

        public void Actualizar()
        {
            try
            {
                cnGeneral = new Datos();

                SqlParameter[] parParameter = new SqlParameter[5];

                parParameter[0] = new SqlParameter();
                parParameter[0].ParameterName = "@opc";
                parParameter[0].SqlDbType = SqlDbType.Int;
                parParameter[0].SqlValue = objReserva.Opc;
                
                parParameter[1] = new SqlParameter();
                parParameter[1].ParameterName = "@numeroHabitacion";
                parParameter[1].SqlDbType = SqlDbType.VarChar;
                parParameter[1].Size = 30;
                parParameter[1].SqlValue = objReserva.NumeroHabitacion;

                parParameter[2] = new SqlParameter();
                parParameter[2].ParameterName = "@desdeFecha";
                parParameter[2].SqlDbType = SqlDbType.VarChar;
                parParameter[2].Size = 30;
                parParameter[2].SqlValue = objReserva.DesdeFecha;

                parParameter[3] = new SqlParameter();
                parParameter[3].ParameterName = "@hastaFecha";
                parParameter[3].SqlDbType = SqlDbType.VarChar;
                parParameter[3].Size = 30;
                parParameter[3].SqlValue = objReserva.HastaFecha;

                parParameter[4] = new SqlParameter();
                parParameter[4].ParameterName = "@codigoReservacion";
                parParameter[4].SqlDbType = SqlDbType.VarChar;
                parParameter[4].Size = 30;
                parParameter[4].SqlValue = objReserva.CodigoReservacion;

                cnGeneral.EjecutarSP(parParameter, "SPReserva");

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }


        }

        public void Eliminar()
        {

            try
            {
                cnGeneral = new Datos();

                SqlParameter[] parParameter = new SqlParameter[2];

                parParameter[0] = new SqlParameter();
                parParameter[0].ParameterName = "@opc";
                parParameter[0].SqlDbType = SqlDbType.Int;
                parParameter[0].SqlValue = objReserva.Opc;

                parParameter[1] = new SqlParameter();
                parParameter[1].ParameterName = "@codigoReservacion";
                parParameter[1].SqlDbType = SqlDbType.VarChar;
                parParameter[1].Size = 30;
                parParameter[1].SqlValue = objReserva.CodigoReservacion;

                cnGeneral.EjecutarSP(parParameter, "SPReserva");


            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }

        public DataTable Buscar()
        {

            tblDatos = new DataTable();

            try
            {
                cnGeneral = new Datos();

                SqlParameter[] parParameter = new SqlParameter[2];

                parParameter[0] = new SqlParameter();
                parParameter[0].ParameterName = "@opc";
                parParameter[0].SqlDbType = SqlDbType.Int;
                parParameter[0].SqlValue = objReserva.Opc;

                parParameter[1] = new SqlParameter();
                parParameter[1].ParameterName = "@nombreHotel";
                parParameter[1].SqlDbType = SqlDbType.VarChar;
                parParameter[1].Size = 30;
                parParameter[1].SqlValue = objReserva.NombreHotel;


                tblDatos = cnGeneral.RetornaTabla(parParameter, "SPReserva");

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return tblDatos;
        }
    }
}
