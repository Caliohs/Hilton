using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hilton.Modelo;

namespace Hilton.Controlador
{
    public class HotelHelper
    {
        Datos cnGeneral = null;
        Hotel objHotel = null;
        DataTable tblDatos = null;


        public HotelHelper(Hotel parHotel)
        {
            objHotel = parHotel;
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
                parParameter[0].SqlValue = objHotel.Opc;


                tblDatos = cnGeneral.RetornaTabla(parParameter, "SPHotel");

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

                SqlParameter[] parParameter = new SqlParameter[8];

                parParameter[0] = new SqlParameter();
                parParameter[0].ParameterName = "@opc";
                parParameter[0].SqlDbType = SqlDbType.Int;
                parParameter[0].SqlValue = objHotel.Opc;

                parParameter[1] = new SqlParameter();
                parParameter[1].ParameterName = "@codigo";
                parParameter[1].SqlDbType = SqlDbType.VarChar;
                parParameter[1].Size = 30;
                parParameter[1].SqlValue = objHotel.Codigo;

                parParameter[2] = new SqlParameter();
                parParameter[2].ParameterName = "@nombre";
                parParameter[2].SqlDbType = SqlDbType.VarChar;
                parParameter[2].Size = 30;
                parParameter[2].SqlValue = objHotel.Nombre;

                parParameter[3] = new SqlParameter();
                parParameter[3].ParameterName = "@pais";
                parParameter[3].SqlDbType = SqlDbType.VarChar;
                parParameter[3].Size = 30;
                parParameter[3].SqlValue = objHotel.Pais;

                parParameter[4] = new SqlParameter();
                parParameter[4].ParameterName = "@estado";
                parParameter[4].SqlDbType = SqlDbType.VarChar;
                parParameter[4].Size = 30;
                parParameter[4].SqlValue = objHotel.Estado;

                parParameter[5] = new SqlParameter();
                parParameter[5].ParameterName = "@cantidad";
                parParameter[5].SqlDbType = SqlDbType.VarChar;
                parParameter[5].Size = 30;
                parParameter[5].SqlValue = objHotel.CantidadHabi;

                parParameter[6] = new SqlParameter();
                parParameter[6].ParameterName = "@especializacion";
                parParameter[6].SqlDbType = SqlDbType.VarChar;
                parParameter[6].Size = 30;
                parParameter[6].SqlValue = objHotel.Especializacion;

                parParameter[7] = new SqlParameter();
                parParameter[7].ParameterName = "@presupuesto";
                parParameter[7].SqlDbType = SqlDbType.VarChar;
                parParameter[7].Size = 30;
                parParameter[7].SqlValue = objHotel.Presupuesto;

                cnGeneral.EjecutarSP(parParameter, "SPHotel");



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

                SqlParameter[] parParameter = new SqlParameter[7];

                parParameter[0] = new SqlParameter();
                parParameter[0].ParameterName = "@opc";
                parParameter[0].SqlDbType = SqlDbType.Int;
                parParameter[0].SqlValue = objHotel.Opc;

                parParameter[1] = new SqlParameter();
                parParameter[1].ParameterName = "@codigo";
                parParameter[1].SqlDbType = SqlDbType.VarChar;
                parParameter[1].Size = 30;
                parParameter[1].SqlValue = objHotel.Codigo;

                parParameter[2] = new SqlParameter();
                parParameter[2].ParameterName = "@nombre";
                parParameter[2].SqlDbType = SqlDbType.VarChar;
                parParameter[2].Size = 30;
                parParameter[2].SqlValue = objHotel.Nombre;

                parParameter[3] = new SqlParameter();
                parParameter[3].ParameterName = "@pais";
                parParameter[3].SqlDbType = SqlDbType.VarChar;
                parParameter[3].Size = 30;
                parParameter[3].SqlValue = objHotel.Pais;

                parParameter[4] = new SqlParameter();
                parParameter[4].ParameterName = "@estado";
                parParameter[4].SqlDbType = SqlDbType.VarChar;
                parParameter[4].Size = 30;
                parParameter[4].SqlValue = objHotel.Estado;

                parParameter[5] = new SqlParameter();
                parParameter[5].ParameterName = "@cantidad";
                parParameter[5].SqlDbType = SqlDbType.VarChar;
                parParameter[5].Size = 30;
                parParameter[5].SqlValue = objHotel.CantidadHabi;
            
                parParameter[6] = new SqlParameter();
                parParameter[6].ParameterName = "@presupuesto";
                parParameter[6].SqlDbType = SqlDbType.VarChar;
                parParameter[6].Size = 30;
                parParameter[6].SqlValue = objHotel.Presupuesto;

                cnGeneral.EjecutarSP(parParameter, "SPHotel");

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
                parParameter[0].SqlValue = objHotel.Opc;

                parParameter[1] = new SqlParameter();
                parParameter[1].ParameterName = "@especializacion";
                parParameter[1].SqlDbType = SqlDbType.VarChar;
                parParameter[1].Size = 30;
                parParameter[1].SqlValue = objHotel.Especializacion;



                tblDatos = cnGeneral.RetornaTabla(parParameter, "SPHotel");

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return tblDatos;
        }

        public DataTable BuscarHotel()
        {

            tblDatos = new DataTable();

            try
            {
                cnGeneral = new Datos();

                SqlParameter[] parParameter = new SqlParameter[2];

                parParameter[0] = new SqlParameter();
                parParameter[0].ParameterName = "@opc";
                parParameter[0].SqlDbType = SqlDbType.Int;
                parParameter[0].SqlValue = objHotel.Opc;

                parParameter[1] = new SqlParameter();
                parParameter[1].ParameterName = "@nombre";
                parParameter[1].SqlDbType = SqlDbType.VarChar;
                parParameter[1].Size = 30;
                parParameter[1].SqlValue = objHotel.Nombre;



                tblDatos = cnGeneral.RetornaTabla(parParameter, "SPHotel");

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return tblDatos;
        }

    }
}
