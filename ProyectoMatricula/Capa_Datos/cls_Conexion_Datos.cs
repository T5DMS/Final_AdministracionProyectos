using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Capa_Datos
{
	public class cls_Conexion_Datos
	{

        static SqlDataAdapter Adaptador = new SqlDataAdapter();
        static SqlConnection conectar = new SqlConnection();
        static SqlCommand Comando = new SqlCommand();
        private string cadena_conex = "Data Source=LAPTOP-M9FCGIJ4\\SQLSERVER_EDD;Initial Catalog=DB_MATRICULA;Integrated Security=True"; // CAMBIAR DATASOURCE PARA CADA NOMBRE DE SQL RESPECTIVO
        bool insertar = false;
        bool filtrarPlan = false;

        public bool Conectar()
        {
            bool estado = true;
            try
            {
                conectar.ConnectionString = cadena_conex;
                conectar.Open();
            }
            catch
            {
                estado = false;
                Console.WriteLine("Error al conectar con el servidor");
            }

            return estado;
        }



        public void Desconectar()
        {
            conectar.Close();
        }

        public bool m_InsertarMatricula(string sCarnetEstudiante, string sNombreCarrera, string sDescripcionCurso, int iPeriodo)
        {
            cls_Conexion_Datos objConexion = new cls_Conexion_Datos();


            try
            {
                if (objConexion.Conectar())
                {
                    Comando = new SqlCommand("SCH_ADMINISTRATIVO.SP_INSERT_MATRICULA", conectar);
                    Comando.CommandType = CommandType.StoredProcedure;
                    Comando.Parameters.Add("@Carne", SqlDbType.VarChar).Value = sCarnetEstudiante;
                    Comando.Parameters.Add("@CodCarrera", SqlDbType.VarChar).Value = sNombreCarrera;
                    Comando.Parameters.Add("@CodCurso", SqlDbType.VarChar).Value = sDescripcionCurso;
                    Comando.Parameters.Add("@PeriodoActivo", SqlDbType.Int).Value = iPeriodo;
                    
                    Comando.ExecuteNonQuery();
                    insertar = true;
                    objConexion.Desconectar();
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            return insertar;
        }

        public bool m_EliminaRegistro(int iIdHistorico)
        {
            cls_Conexion_Datos objConexion = new cls_Conexion_Datos();


            try
            {
                if (objConexion.Conectar())
                {
                    Comando = new SqlCommand("SCH_ADMINISTRATIVO.SP_BORRADO_LOGICO", conectar);
                    Comando.CommandType = CommandType.StoredProcedure;
                    Comando.Parameters.Add("@IdHistorico", SqlDbType.Int).Value = iIdHistorico;

                    Comando.ExecuteNonQuery();
                    insertar = true;
                    objConexion.Desconectar();
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            return insertar;
        }


        public bool m_FiltrarPlanEstudios(string sCarnetEstudiante)
        {
            cls_Conexion_Datos objConexion = new cls_Conexion_Datos();


            try
            {
                if (objConexion.Conectar())
                {
                    Comando = new SqlCommand("SCH_ACADEMICO.SP_PLAN_ESTUDIO", conectar);
                    Comando.CommandType = CommandType.StoredProcedure;
                    
                    Comando.Parameters.Add("@CARNETESTUDIANTE", SqlDbType.VarChar).Value = sCarnetEstudiante;

                    Comando.ExecuteNonQuery();
                    filtrarPlan = true;
                    objConexion.Desconectar();
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            return filtrarPlan;
        }

        public bool m_FiltrarHistorico(string sCarnetEstudiante)
        {
            cls_Conexion_Datos objConexion = new cls_Conexion_Datos();


            try
            {
                if (objConexion.Conectar())
                {
                    Comando = new SqlCommand("SCH_ACADEMICO.SP_HISTORICO_ESTUDIANTE", conectar);
                    Comando.CommandType = CommandType.StoredProcedure;

                    Comando.Parameters.Add("@CARNETESTUDIANTE", SqlDbType.VarChar).Value = sCarnetEstudiante;

                    Comando.ExecuteNonQuery();
                    filtrarPlan = true;
                    objConexion.Desconectar();
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            return filtrarPlan;
        }
    }
}
