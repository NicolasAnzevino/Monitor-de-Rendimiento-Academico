using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using Entidades;

namespace DAL
{
    public class DAL_Inasistencia : SQLKit
    {
        public DAL_Inasistencia() : base()
        {

        }
        public decimal Obtener_Cant_Inasistencias(Cursada_de_Alumno pCursada)
        {
            try
            {
                Conectarse();

                Comando.CommandText = "SELECT COALESCE(SUM(Ina_Valor),0) from Inasistencia WHERE Ina_CurAlu_Codigo = @pID";

                Comando.Parameters.Clear();
                Comando.Parameters.AddWithValue("pID", pCursada.Codigo);

                decimal Cantidad = (decimal)Comando.ExecuteScalar();

                Desconectarse();

                return Cantidad;
            }
            catch (Exception ex) { Desconectarse(); throw new Exception(ex.Message); }
        }
        public DataTable Obtener_Inasistencias_Alumnos(Cursada_de_Alumno pCursada)
        {
            try
            {
                Conectarse();

                Comando.CommandText = "SELECT Ina_Codigo, Ina_Fecha, Ina_Descripcion, Ina_Valor, Ina_Justificacion FROM Inasistencia WHERE Ina_CurAlu_Codigo = @pID AND Ina_Fecha = @pFecha";

                Comando.Parameters.Clear();
                Comando.Parameters.AddWithValue("pID", pCursada.Codigo);
                Comando.Parameters.AddWithValue("pFecha", DateTime.Today);

                DataTable DT = new DataTable();

                SqlDataReader Reader = Comando.ExecuteReader();
                DT.Load(Reader);

                Desconectarse();

                return DT;
            }
            catch (Exception ex) { Desconectarse(); throw new Exception(ex.Message); }
        }
        public void Enviar_Inasistencias(Cursada_de_Alumno pCursada, Curso pCurso)
        {
            try
            {
                Conectarse();

                Comando.CommandText = "INSERT INTO Inasistencia(Ina_Fecha, Ina_Descripcion, Ina_Valor, Ina_Justificacion, Ina_CurAlu_Codigo, Ina_Cur_Codigo) VALUES (@pFecha, @pDesc, @pValor, @pJustif, @pID, @pCurID)";

                Comando.Parameters.Clear();
                Comando.Parameters.AddWithValue("pID", pCursada.Codigo);
                Comando.Parameters.AddWithValue("pFecha", DateTime.Today);
                Comando.Parameters.AddWithValue("pDesc", pCursada.VerInasistencias()[0].Descripcion);
                Comando.Parameters.AddWithValue("pValor", pCursada.VerInasistencias()[0].Valor);
                Comando.Parameters.AddWithValue("pJustif", pCursada.VerInasistencias()[0].Justificacion);
                Comando.Parameters.AddWithValue("pCurID", pCurso.Codigo);

                Comando.ExecuteNonQuery();

                Desconectarse();
            }
            catch (Exception ex) { Desconectarse(); throw new Exception(ex.Message); }
        }
        public void Agregar_Inasistencia(Cursada_de_Alumno pCursada, Curso pCurso)
        {
            try
            {
                Conectarse();

                Comando.CommandText = "INSERT INTO Inasistencia(Ina_Fecha, Ina_Descripcion, Ina_Valor, Ina_Justificacion, Ina_CurAlu_Codigo, Ina_Cur_Codigo) VALUES (@pFecha, @pDesc, @pValor, @pJustif, @pID, @pCurID)";

                Comando.Parameters.Clear();
                Comando.Parameters.AddWithValue("pID", pCursada.Codigo);
                Comando.Parameters.AddWithValue("pFecha", pCursada.VerInasistencias()[0].Fecha);
                Comando.Parameters.AddWithValue("pDesc", pCursada.VerInasistencias()[0].Descripcion);
                Comando.Parameters.AddWithValue("pValor", pCursada.VerInasistencias()[0].Valor);
                Comando.Parameters.AddWithValue("pJustif", pCursada.VerInasistencias()[0].Justificacion);
                Comando.Parameters.AddWithValue("pCurID", pCurso.Codigo);

                Comando.ExecuteNonQuery();

                Desconectarse();
            }
            catch (Exception ex) { Desconectarse(); throw new Exception(ex.Message); }
        }
        public void Eliminar_Inasistencias_Actuales(Curso pCurso)
        {
            try
            {
                Conectarse();

                Comando.CommandText = "DELETE Inasistencia WHERE Ina_Fecha = @pFecha AND Ina_Cur_Codigo = @pID";

                Comando.Parameters.Clear();
                Comando.Parameters.AddWithValue("pID", pCurso.Codigo);
                Comando.Parameters.AddWithValue("pFecha", DateTime.Today);

                Comando.ExecuteNonQuery();

                Desconectarse();
            }
            catch (Exception ex) { Desconectarse(); throw new Exception(ex.Message); }
        }
        public DataTable Ver_Inasistencia_Alumno(Cursada_de_Alumno pCursada)
        {
            try
            {
                Conectarse();

                Comando.CommandText = "SELECT Ina_Codigo, Ina_Fecha, Ina_Descripcion, Ina_Valor, Ina_Justificacion FROM Inasistencia WHERE Ina_CurAlu_Codigo = @pID ORDER BY Ina_Fecha";

                Comando.Parameters.Clear();
                Comando.Parameters.AddWithValue("pID", pCursada.Codigo);

                DataTable DT = new DataTable();

                SqlDataReader Reader = Comando.ExecuteReader();
                DT.Load(Reader);

                Desconectarse();

                return DT;
            }
            catch (Exception ex) { Desconectarse(); throw new Exception(ex.Message); }
        }
        public void Eliminar_Inasistencia(Inasistencia pInasistencia)
        {
            try
            {
                Conectarse();

                Comando.CommandText = "DELETE Inasistencia WHERE Ina_Codigo = @pID";

                Comando.Parameters.Clear();
                Comando.Parameters.AddWithValue("pID", pInasistencia.Codigo);

                Comando.ExecuteNonQuery();

                Desconectarse();
            }
            catch (Exception ex) { Desconectarse(); throw new Exception(ex.Message); }
        }
        public void Modificar_Inasistencia(Cursada_de_Alumno pCursada, Inasistencia pInasistencia)
        {
            try
            {
                Conectarse();

                Comando.CommandText = "UPDATE Inasistencia SET Ina_Descripcion = @pDesc, Ina_Valor = @pValor, Ina_Justificacion = @pJustif WHERE Ina_CurAlu_Codigo = @pID AND Ina_Codigo = @pInaID";

                Comando.Parameters.Clear();
                Comando.Parameters.AddWithValue("pID", pCursada.Codigo);
                Comando.Parameters.AddWithValue("pValor", pInasistencia.Valor);
                Comando.Parameters.AddWithValue("pDesc", pInasistencia.Descripcion);
                Comando.Parameters.AddWithValue("pJustif", pInasistencia.Justificacion);
                Comando.Parameters.AddWithValue("pInaID", pInasistencia.Codigo);

                Comando.ExecuteNonQuery();

                Desconectarse();
            }
            catch (Exception ex) { Desconectarse(); throw new Exception(ex.Message); }
        }
        public int Verificar_Inasistencia(Cursada_de_Alumno pCursada, DateTime pFecha)
        {
            try
            {
                Conectarse();

                Comando.CommandText = "SELECT COUNT(Ina_Codigo) FROM Inasistencia WHERE Ina_Fecha = @pFecha AND Ina_CurAlu_Codigo = @pID";

                Comando.Parameters.Clear();
                Comando.Parameters.AddWithValue("pID", pCursada.Codigo);
                Comando.Parameters.AddWithValue("pFecha", pFecha);

                int Cantidad = (int)Comando.ExecuteScalar();

                Desconectarse();

                return Cantidad;
            }
            catch (Exception ex) { Desconectarse(); throw new Exception(ex.Message); }
        }
        public DataTable Ver_Estado_de_Alumnos_de_Curso(Curso pCurso)
        {
            try
            {
                Conectarse();

                Comando.CommandText = "SELECT Alu_Legajo, CurAlu_Libre FROM Alumno, Cursada_de_Alumno WHERE Alu_Legajo = CurAlu_Alu_Legajo AND CurAlu_Cur_Codigo = @pID";

                Comando.Parameters.Clear();
                Comando.Parameters.AddWithValue("pID", pCurso.Codigo);

                DataTable DT = new DataTable();

                SqlDataReader Reader = Comando.ExecuteReader();
                DT.Load(Reader);

                Desconectarse();

                return DT;
            }
            catch (Exception ex) { Desconectarse(); throw new Exception(ex.Message); }
        }

        

    }
}
