using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Entidades;
using DAL;

namespace Servicios
{
    public class TranslatorManager
    {
        static public Dictionary<string, string> Diccionario;

        public static void TraducirTodo(int pKeyIdioma, Form pForm)
        {
            DAL_TranslatorManager DAL_Translator = new DAL_TranslatorManager();
            Diccionario = DAL_Translator.Traducir(pForm.Name, pKeyIdioma);
            pForm.Text = Diccionario[pForm.Name];
            foreach (Control C in pForm.Controls)
            {
                
                if (C is Label || C is Button || C is Form)
                {
                   C.Text = Diccionario[C.Name];
                   continue;
                }

                if (C is DataGridView)
                {
                    DataGridView DGV = C as DataGridView;

                    foreach (DataGridViewColumn DC in DGV.Columns)
                    {
                        DC.HeaderText = Diccionario[DC.Name];
                        continue;
                    }         
                }

                if (C is RadioButton)
                {
                    C.Text = Diccionario[C.Name];
                }

                if (C is GroupBox)
                {
                    GroupBox GP = C as GroupBox;

                    GP.Text = Diccionario[GP.Name];

                    foreach (Control item in GP.Controls)
                    {
                        item.Text = Diccionario[item.Name];
                    }
                }

                if (C is Panel)
                {
                    Panel P = C as Panel;

                    foreach (Control item in P.Controls)
                    {
                        if (!(item is TextBox || item is PictureBox|| item is NumericUpDown))
                        {
                            item.Text = Diccionario[item.Name];
                        }                        
                    }
                }

                if (C is StatusStrip)
                {
                    StatusStrip S = C as StatusStrip;

                    foreach (ToolStripLabel item in S.Items)
                    {
                        if (item.Name == "toolStripStatusLabelNombreUsuario" || item.Name == "toolStripStatusLabelRol")
                        {
                            item.Text = Diccionario[item.Name];
                        }              
                    }
                }

                if (C is MenuStrip)
                {
                    MenuStrip MS = C as MenuStrip;

                    foreach (ToolStripMenuItem item in MS.Items)
                    {
                        item.Text = Diccionario[item.Name];
                        if (item.HasDropDownItems)
                        {
                            TraducirItem(item.DropDownItems, pKeyIdioma, pForm);
                        }
                    }
                }  
                
            }

            foreach (Form _Form in pForm.MdiChildren)
            {
                if (_Form != null)
                {
                    TraducirTodo(pKeyIdioma, _Form);
                }
            }
        }

        private static void TraducirItem(ToolStripItemCollection subItem, int pKeyIdioma, Form pForm)
        {
            foreach (ToolStripMenuItem i in subItem)
            {
                i.Text = Diccionario[i.Name];

                if (i.HasDropDownItems)
                {
                    TraducirItem(i.DropDownItems, pKeyIdioma, pForm);
                }
            }
        }

        public static int ObtenerIdiomaDeUsuario(int pKeyID)
        {
            DAL_TranslatorManager DAL_Translator = new DAL_TranslatorManager();
            return DAL_Translator.ObtenerIdiomaDeUsuario(pKeyID);
        }

        public static int CambiarIdioma(int pKeyID, int pLangID)
        {
            DAL_TranslatorManager DAL_Translator = new DAL_TranslatorManager();
            return DAL_Translator.CambiarIdioma(pKeyID, pLangID);
        }


    }
}
