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
    public class UsuarioHelper
    {
        Datos cnGeneral = null;
        Usuario objUsuario = null;
        DataTable tblDatos = null;

        public UsuarioHelper(Usuario parObjUsuario)
        {
            objUsuario = parObjUsuario;
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
                parParameter[0].SqlValue = objUsuario.Opc;


                tblDatos = cnGeneral.RetornaTabla(parParameter, "SPUsuario");

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

                SqlParameter[] parParameter = new SqlParameter[9];

                parParameter[0] = new SqlParameter();
                parParameter[0].ParameterName = "@opc";
                parParameter[0].SqlDbType = SqlDbType.Int;
                parParameter[0].SqlValue = objUsuario.Opc;

                parParameter[1] = new SqlParameter();
                parParameter[1].ParameterName = "@cedula";
                parParameter[1].SqlDbType = SqlDbType.VarChar;
                parParameter[1].Size = 30;
                parParameter[1].SqlValue = objUsuario.Cedula;

                parParameter[2] = new SqlParameter();
                parParameter[2].ParameterName = "@nombre";
                parParameter[2].SqlDbType = SqlDbType.VarChar;
                parParameter[2].Size = 30;
                parParameter[2].SqlValue = objUsuario.Nombre;

                parParameter[3] = new SqlParameter();
                parParameter[3].ParameterName = "@genero";
                parParameter[3].SqlDbType = SqlDbType.VarChar;
                parParameter[3].Size = 30;
                parParameter[3].SqlValue = objUsuario.Genero;

                parParameter[4] = new SqlParameter();
                parParameter[4].ParameterName = "@fechaNacimiento";
                parParameter[4].SqlDbType = SqlDbType.VarChar;
                parParameter[4].Size = 30;
                parParameter[4].SqlValue = objUsuario.FechaNacimiento;

                parParameter[5] = new SqlParameter();
                parParameter[5].ParameterName = "@correo";
                parParameter[5].SqlDbType = SqlDbType.VarChar;
                parParameter[5].Size = 30;
                parParameter[5].SqlValue = objUsuario.Correo;

                parParameter[6] = new SqlParameter();
                parParameter[6].ParameterName = "@perfil";
                parParameter[6].SqlDbType = SqlDbType.VarChar;
                parParameter[6].Size = 30;
                parParameter[6].SqlValue = objUsuario.Perfil;

                parParameter[7] = new SqlParameter();
                parParameter[7].ParameterName = "@usuario";
                parParameter[7].SqlDbType = SqlDbType.VarChar;
                parParameter[7].Size = 30;
                parParameter[7].SqlValue = objUsuario.User;

                parParameter[8] = new SqlParameter();
                parParameter[8].ParameterName = "@clave";
                parParameter[8].SqlDbType = SqlDbType.VarChar;
                parParameter[8].Size = 30;
                parParameter[8].SqlValue = objUsuario.Clave;   

                cnGeneral.EjecutarSP(parParameter, "SPUsuario");

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

                SqlParameter[] parParameter = new SqlParameter[8];

                parParameter[0] = new SqlParameter();
                parParameter[0].ParameterName = "@opc";
                parParameter[0].SqlDbType = SqlDbType.Int;
                parParameter[0].SqlValue = objUsuario.Opc;

                parParameter[1] = new SqlParameter();
                parParameter[1].ParameterName = "@cedula";
                parParameter[1].SqlDbType = SqlDbType.VarChar;
                parParameter[1].Size = 30;
                parParameter[1].SqlValue = objUsuario.Cedula;

                parParameter[2] = new SqlParameter();
                parParameter[2].ParameterName = "@nombre";
                parParameter[2].SqlDbType = SqlDbType.VarChar;
                parParameter[2].Size = 30;
                parParameter[2].SqlValue = objUsuario.Nombre;

                parParameter[3] = new SqlParameter();
                parParameter[3].ParameterName = "@genero";
                parParameter[3].SqlDbType = SqlDbType.VarChar;
                parParameter[3].Size = 30;
                parParameter[3].SqlValue = objUsuario.Genero;


                parParameter[4] = new SqlParameter();
                parParameter[4].ParameterName = "@correo";
                parParameter[4].SqlDbType = SqlDbType.VarChar;
                parParameter[4].Size = 30;
                parParameter[4].SqlValue = objUsuario.Correo;

                parParameter[5] = new SqlParameter();
                parParameter[5].ParameterName = "@perfil";
                parParameter[5].SqlDbType = SqlDbType.VarChar;
                parParameter[5].Size = 30;
                parParameter[5].SqlValue = objUsuario.Perfil;

                parParameter[6] = new SqlParameter();
                parParameter[6].ParameterName = "@usuario";
                parParameter[6].SqlDbType = SqlDbType.VarChar;
                parParameter[6].Size = 30;
                parParameter[6].SqlValue = objUsuario.User;

                parParameter[7] = new SqlParameter();
                parParameter[7].ParameterName = "@clave";
                parParameter[7].SqlDbType = SqlDbType.VarChar;
                parParameter[7].Size = 30;
                parParameter[7].SqlValue = objUsuario.Clave;

                cnGeneral.EjecutarSP(parParameter, "SPUsuario");
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
                parParameter[0].SqlValue = objUsuario.Opc;

                parParameter[1] = new SqlParameter();
                parParameter[1].ParameterName = "@cedula";
                parParameter[1].SqlDbType = SqlDbType.VarChar;
                parParameter[1].Size = 30;
                parParameter[1].SqlValue = objUsuario.Cedula;

                cnGeneral.EjecutarSP(parParameter, "SPUsuario");

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public DataTable validarLogin()
        {

            tblDatos = new DataTable();

            try
            {
                cnGeneral = new Datos();

                SqlParameter[] parParameter = new SqlParameter[3];

                parParameter[0] = new SqlParameter();
                parParameter[0].ParameterName = "@opc";
                parParameter[0].SqlValue = objUsuario.Opc;

                parParameter[1] = new SqlParameter();
                parParameter[1].ParameterName = "@usuario";
                parParameter[1].SqlDbType = SqlDbType.VarChar;
                parParameter[1].Size = 30;
                parParameter[1].SqlValue = objUsuario.User;

                parParameter[2] = new SqlParameter();
                parParameter[2].ParameterName = "@clave";
                parParameter[2].SqlDbType = SqlDbType.VarChar;
                parParameter[2].Size = 30;
                parParameter[2].SqlValue = objUsuario.Clave;

                tblDatos = cnGeneral.RetornaTabla(parParameter, "SPUsuario");

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return tblDatos;
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
                parParameter[0].SqlValue = objUsuario.Opc;

                parParameter[1] = new SqlParameter();
                parParameter[1].ParameterName = "@nombre";
                parParameter[1].SqlDbType = SqlDbType.VarChar;
                parParameter[1].Size = 30;
                parParameter[1].SqlValue = objUsuario.Nombre;


                tblDatos = cnGeneral.RetornaTabla(parParameter, "SPUsuario");

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return tblDatos;
        }

    }
}
