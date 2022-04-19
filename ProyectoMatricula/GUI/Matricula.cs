using Negocios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class Matricula : Form
    {

        public SqlConnection conexion = new SqlConnection("Data Source=LAPTOP-M9FCGIJ4\\SQLSERVER_EDD;Initial Catalog=DB_MATRICULA;Integrated Security=True");

        public Matricula()
        {
            InitializeComponent();
        }

        private void Matricula_Load(object sender, EventArgs e)
        {
            ActualizarDataGridHistorial();
            CargarCombos();
        }

        private void ActualizarDataGridHistorial()
        {
            try
            {
                conexion.Open();
            }
            catch (Exception)
            {
                conexion.Open();
            }
        }

        private void CargarCombos()
        {
            //COMBO CARNET
            SqlCommand comandoCarnet = new SqlCommand("SELECT DISTINCT CARNET_ESTUDIANTE,NOMBRE_ESTUDIANTE FROM SCH_ACADEMICO.TBL_ESTUDIANTES", conexion);
            SqlDataAdapter adaptadorCarnet = new SqlDataAdapter(comandoCarnet);
            DataTable dtCarnet = new DataTable();
            adaptadorCarnet.Fill(dtCarnet);
            cmbCarnetEstudiante.ValueMember = "CARNET_ESTUDIANTE";
            cmbCarnetEstudiante.DisplayMember = "NOMBRE_ESTUDIANTE";
            cmbCarnetEstudiante.DataSource = null;
            cmbCarnetEstudiante.DataSource = dtCarnet;

            //COMBO CARRERA
            SqlCommand comandoCarrera = new SqlCommand("SELECT * FROM SCH_ADMINISTRATIVO.TBL_CARRERAS", conexion);
            SqlDataAdapter adaptadorCarrera = new SqlDataAdapter(comandoCarrera);
            DataTable dtCarrera = new DataTable();
            adaptadorCarrera.Fill(dtCarrera);
            cmbNombreCarrera.ValueMember = "COD_CARRERA";
            cmbNombreCarrera.DisplayMember = "NOMBRE_CARRERA";
            cmbNombreCarrera.DataSource = null;
            cmbNombreCarrera.DataSource = dtCarrera;

            //COMBO PERIODOS
            SqlCommand comandoPeriodo = new SqlCommand("SELECT * FROM SCH_ADMINISTRATIVO.TBL_PERIODOS_LECTIVOS", conexion);
            SqlDataAdapter adaptadorPeriodo = new SqlDataAdapter(comandoPeriodo);
            DataTable dtPeriodo = new DataTable();
            adaptadorPeriodo.Fill(dtPeriodo);
            cmbPeriodo.ValueMember = "ID_PERIODO";
            cmbPeriodo.DisplayMember = "NOMBRE_PERIODO";
            cmbPeriodo.DataSource = null;
            cmbPeriodo.DataSource = dtPeriodo;
        }

        private void btn_Insertar_Click(object sender, EventArgs e)
        {
            try
            {
                cls_Direccion objctrl = new cls_Direccion();
                objctrl.setDescripcionCurso(cmbDescripcionCurso.SelectedValue.ToString());
                objctrl.setNombreCarrera(cmbNombreCarrera.SelectedValue.ToString());
                objctrl.setCarnetEstudiante(cmbCarnetEstudiante.SelectedValue.ToString());
                objctrl.setPeriodo(Convert.ToInt32(cmbPeriodo.SelectedValue));

                bool respuesta = objctrl.m_insertar();

                MessageBox.Show("Se ha completado la matrícula correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmbNombreCarrera_SelectedIndexChanged(object sender, EventArgs e)
        {
            //COMBO CURSO
            SqlCommand comandoCurso = new SqlCommand("SCH_ACADEMICO.SP_MATRICULAINSERT", conexion);
            comandoCurso.CommandType = CommandType.StoredProcedure;
            comandoCurso.Parameters.Add("@CodCarrera", SqlDbType.VarChar).Value = cmbNombreCarrera.SelectedValue;
            comandoCurso.Parameters.Add("@CARNETESTUDIANTE", SqlDbType.VarChar).Value = cmbCarnetEstudiante.SelectedValue;
            SqlDataAdapter adaptadorCurso = new SqlDataAdapter(comandoCurso);
            DataTable dtCurso = new DataTable();
            adaptadorCurso.Fill(dtCurso);
            cmbDescripcionCurso.DataSource = null;
            cmbDescripcionCurso.ValueMember = "COD_CURSO";
            cmbDescripcionCurso.DisplayMember = "DESCRIPCION";
            cmbDescripcionCurso.DataSource = dtCurso;
            comandoCurso.ExecuteNonQuery();
        }
    }
}
