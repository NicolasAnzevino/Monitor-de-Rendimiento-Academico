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
    public class DAL_TranslatorManager : SQLKit
    {
        public DAL_TranslatorManager() : base()
        {

        }

        public Dictionary<string, string> Traducir(string pNombreForm, int pIDIdioma)
        {
            Conectarse();

            Dictionary<string, string> Diccionario = new Dictionary<string, string>();

            DataTable DT = new DataTable();

            Comando.CommandText = "SELECT DISTINCT CTRL_Nombre, CTRL_Idio_Traduccion FROM Control, Control_Idioma, Idioma WHERE CTRL_Idio_CTRL_Codigo = CTRL_Codigo AND CTRL_Idio_Idio_Codigo = @IdiomaID AND CTRL_Padre = @FormNombre AND CTRL_Idio_Idio_Codigo = Idio_Codigo";

            Comando.Parameters.Clear();
            Comando.Parameters.Add("@FormNombre", SqlDbType.VarChar);
            Comando.Parameters.Add("@IdiomaID", SqlDbType.Int);

            Comando.Parameters["@FormNombre"].Value = pNombreForm;
            Comando.Parameters["@IdiomaID"].Value = pIDIdioma;

            SqlDataReader Reader = Comando.ExecuteReader();
            DT.Load(Reader);

            foreach (DataRow DR in DT.Rows)
            {
                //if (!(Diccionario.ContainsKey(DR.Field<string>(0))))
                //{
                    Diccionario.Add(DR.Field<string>(0), DR.Field<string>(1));
                //}                
            }

            Desconectarse();

            return Diccionario;
        }
        public int CambiarIdioma(int pUserID, int pLangID)
        {
            Conectarse();

            int LangKey = 0;

            if (pLangID == 1) { LangKey = 2; }
            else { LangKey = 1; }

            Comando.CommandText = "UPDATE Usuario SET User_Idio_Codigo = @LangID WHERE User_Codigo = @UserID";

            Comando.Parameters.Clear();

            Comando.Parameters.AddWithValue("LangID", LangKey);
            Comando.Parameters.AddWithValue("UserID", pUserID);

            Comando.ExecuteNonQuery();

            Desconectarse();

            return LangKey;
        }

        public int ObtenerIdiomaDeUsuario(int pKeyID)
        {
            Conectarse();

            int LangKey = 0;            

            Comando.CommandText = "SELECT User_Idio_Codigo FROM Usuario WHERE User_Codigo = @UserID";

            Comando.Parameters.Clear();         

            Comando.Parameters.AddWithValue("UserID", pKeyID);

            LangKey = (int)Comando.ExecuteScalar();

            Desconectarse();

            return LangKey;
        }
    }
}
