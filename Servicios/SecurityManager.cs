using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using DAL;

namespace Servicios
{
    public class SecurityManager
    {
        public static string CreateMD5(string input)
        {
            // Use input string to calculate MD5 hash
            using (System.Security.Cryptography.MD5 md5 = System.Security.Cryptography.MD5.Create())
            {
                byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(input);
                byte[] hashBytes = md5.ComputeHash(inputBytes);

                // Convert the byte array to hexadecimal string
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < hashBytes.Length; i++)
                {
                    sb.Append(hashBytes[i].ToString("X2"));
                }
                
                return sb.ToString();
            }
        }

        public static bool Verificar_Digitos_Verificadores()
        {
            bool B = false;

            if (Verificar_Digito_Horizontal_Usuario() == false || Verificar_Digito_Vertical_Usuario() == false || Verificar_Digito_Horizontal_Evaluacion_Alu() == false || Verificar_Digito_Vertical_Evaluacion_Alu() == false)
            {
                B = true;
            }

            return B;
        }

        public static string HashearRegistro(DataRow pDR) //El de 1 Fila
        {
            string toHash = "";

            for (int i = 0; i < pDR.ItemArray.Length - 1; i++)
            {
                toHash += pDR[i].ToString();
            }

            return CreateMD5(toHash);
        }

        public static bool Verificar_Digito_Horizontal_Usuario()
        {
            try
            {
                DAL_Usuario ABD = new DAL_Usuario();

                bool B = true; //Falso si algo pasó. Verdadero si todo bien.

                DataTable DT = ABD.Retornar_Usuarios();

                foreach (DataRow DR in DT.Rows)
                {
                    if (Array.FindLast(DR.ItemArray, X => X == X).ToString() != HashearRegistro(DR))
                    {
                        B = false;
                        break;
                    }
                }

                return B;
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }

        public static string HashearTabla(DataTable pDT) //El general por Tabla
        {
            string toHash = "";

            foreach (DataRow DR in pDT.Rows)
            {
                toHash += Array.FindLast(DR.ItemArray, X => X == X).ToString();
            }

            return CreateMD5(toHash);
        }

        public static bool Verificar_Digito_Vertical_Usuario()
        {
            try
            {
                DAL_Usuario ABD = new DAL_Usuario();

                bool B = false; //Falso si algo pasó. Verdadero si todo bien.

                DataTable DT = ABD.Retornar_Usuarios();

                DataTable DT2 = ABD.Retornar_DVV("Usuario");

                if (DT2.Rows[0].Field<string>(2) == HashearTabla(DT))
                {
                    B = true;
                }

                return B;
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }
        public static bool Verificar_Digito_Horizontal_Evaluacion_Alu()
        {
            try
            {
                DAL_Evaluacion_de_Alumno ABD = new DAL_Evaluacion_de_Alumno();

                bool B = true; //Falso si algo pasó. Verdadero si todo bien.

                DataTable DT = ABD.Retornar_Evaluaciones_de_Alumno();

                foreach (DataRow DR in DT.Rows)
                {
                    if (Array.FindLast(DR.ItemArray, X => X == X).ToString() != HashearRegistro(DR))
                    {
                        B = false;
                        break;
                    }
                }

                return B;
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }
        public static bool Verificar_Digito_Vertical_Evaluacion_Alu()
        {
            try
            {
                DAL_Evaluacion_de_Alumno ABD = new DAL_Evaluacion_de_Alumno();

                bool B = false; //Falso si algo pasó. Verdadero si todo bien.

                DataTable DT = ABD.Retornar_Evaluaciones_de_Alumno();

                DataTable DT2 = ABD.Retornar_DVV("Evaluacion_de_Alumno");

                if (DT2.Rows[0].Field<string>(2) == HashearTabla(DT))
                {
                    B = true;
                }

                return B;
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }
    }
}
