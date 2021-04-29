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
    public class ClienteHelper
    {

        Datos cnGeneral = null;
        Cliente objCliente = null;
        DataTable tblDatos = null;

        public ClienteHelper(Cliente parCliente)
        {
           objCliente = parCliente;
        }
        //RETORA TABLA CON LOS CONTACTOS
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
                parParameter[0].SqlValue = objCliente.Opc;


                tblDatos = cnGeneral.RetornaTabla(parParameter, "SPCliente");

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return tblDatos;
        }

        //GUARDA CONTACTO
        public void Guardar()
        {
            try
            {
                cnGeneral = new Datos();

                SqlParameter[] parParameter = new SqlParameter[7];

                parParameter[0] = new SqlParameter();
                parParameter[0].ParameterName = "@opc";
                parParameter[0].SqlDbType = SqlDbType.Int;
                parParameter[0].SqlValue = objCliente.Opc;

                parParameter[1] = new SqlParameter();
                parParameter[1].ParameterName = "@cedula";
                parParameter[1].SqlDbType = SqlDbType.VarChar;
                parParameter[1].Size = 30;
                parParameter[1].SqlValue = objCliente.Cedula;

                parParameter[2] = new SqlParameter();
                parParameter[2].ParameterName = "@nombre";
                parParameter[2].SqlDbType = SqlDbType.VarChar;
                parParameter[2].Size = 30;
                parParameter[2].SqlValue = objCliente.Nombre;

                parParameter[3] = new SqlParameter();
                parParameter[3].ParameterName = "metodoPago";
                parParameter[3].SqlDbType = SqlDbType.VarChar;
                parParameter[3].Size = 30;
                parParameter[3].SqlValue = objCliente.Metodopago;

                parParameter[4] = new SqlParameter();
                parParameter[4].ParameterName = "@tipoCliente";
                parParameter[4].SqlDbType = SqlDbType.VarChar;
                parParameter[4].Size = 30;
                parParameter[4].SqlValue = objCliente.TipoCliente;

                parParameter[5] = new SqlParameter();
                parParameter[5].ParameterName = "@correo";
                parParameter[5].SqlDbType = SqlDbType.VarChar;
                parParameter[5].Size = 30;
                parParameter[5].SqlValue = objCliente.Correo;

                parParameter[6] = new SqlParameter();
                parParameter[6].ParameterName = "@telefono";
                parParameter[6].SqlDbType = SqlDbType.VarChar;
                parParameter[6].Size = 30;
                parParameter[6].SqlValue = objCliente.Telefono;

                
                cnGeneral.EjecutarSP(parParameter, "SPCliente");


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
                parParameter[0].SqlValue = objCliente.Opc;

                parParameter[1] = new SqlParameter();
                parParameter[1].ParameterName = "@cedula";
                parParameter[1].SqlDbType = SqlDbType.VarChar;
                parParameter[1].Size = 30;
                parParameter[1].SqlValue = objCliente.Cedula;

                parParameter[2] = new SqlParameter();
                parParameter[2].ParameterName = "@nombre";
                parParameter[2].SqlDbType = SqlDbType.VarChar;
                parParameter[2].Size = 30;
                parParameter[2].SqlValue = objCliente.Nombre;

                parParameter[3] = new SqlParameter();
                parParameter[3].ParameterName = "metodoPago";
                parParameter[3].SqlDbType = SqlDbType.VarChar;
                parParameter[3].Size = 30;
                parParameter[3].SqlValue = objCliente.Metodopago;

                parParameter[4] = new SqlParameter();
                parParameter[4].ParameterName = "@tipoCliente";
                parParameter[4].SqlDbType = SqlDbType.VarChar;
                parParameter[4].Size = 30;
                parParameter[4].SqlValue = objCliente.TipoCliente;

                parParameter[5] = new SqlParameter();
                parParameter[5].ParameterName = "@correo";
                parParameter[5].SqlDbType = SqlDbType.VarChar;
                parParameter[5].Size = 30;
                parParameter[5].SqlValue = objCliente.Correo;

                parParameter[6] = new SqlParameter();
                parParameter[6].ParameterName = "@telefono";
                parParameter[6].SqlDbType = SqlDbType.VarChar;
                parParameter[6].Size = 30;
                parParameter[6].SqlValue = objCliente.Telefono;


                cnGeneral.EjecutarSP(parParameter, "SPCliente");




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
                parParameter[0].SqlValue = objCliente.Opc;

                parParameter[1] = new SqlParameter();
                parParameter[1].ParameterName = "@cedula";
                parParameter[1].SqlDbType = SqlDbType.VarChar;
                parParameter[1].Size = 30;
                parParameter[1].SqlValue = objCliente.Cedula;



                cnGeneral.EjecutarSP(parParameter, "SPCliente");



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
                parParameter[0].SqlValue = objCliente.Opc;

                parParameter[1] = new SqlParameter();
                parParameter[1].ParameterName = "@nombre";
                parParameter[1].SqlDbType = SqlDbType.VarChar;
                parParameter[1].Size = 30;
                parParameter[1].SqlValue = objCliente.Nombre;

                tblDatos = cnGeneral.RetornaTabla(parParameter, "SPCliente");

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return tblDatos;
        }

        public DataTable BuscarClientePorCedula()
        {

            tblDatos = new DataTable();

            try
            {
                cnGeneral = new Datos();

                SqlParameter[] parParameter = new SqlParameter[2];

                parParameter[0] = new SqlParameter();
                parParameter[0].ParameterName = "@opc";
                parParameter[0].SqlDbType = SqlDbType.Int;
                parParameter[0].SqlValue = objCliente.Opc;

                parParameter[1] = new SqlParameter();
                parParameter[1].ParameterName = "@cedula";
                parParameter[1].SqlDbType = SqlDbType.VarChar;
                parParameter[1].Size = 30;
                parParameter[1].SqlValue = objCliente.Cedula;

                tblDatos = cnGeneral.RetornaTabla(parParameter, "SPCliente");

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return tblDatos;
        }
    }
}
