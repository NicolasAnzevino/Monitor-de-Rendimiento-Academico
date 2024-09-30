﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Servicios;

namespace Monitor_de_Rendimiento_Academico
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            if (DatabaseCreatorManager.VerificarExistenciaArchivo() == false)
            {
                Application.Run(new FormSelectorServidor());
            }
            else
            {
                Application.Run(new FormLogin());
            }

        }
    }
}
