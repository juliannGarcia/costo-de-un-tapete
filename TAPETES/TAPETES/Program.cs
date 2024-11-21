using System;
using System.Windows.Forms;

namespace TAPETES
{
    /// <summary>
    /// Class with program entry point.
    /// </summary>
    internal sealed class Program
    {
        /// <summary>
        /// Program entry point.
        /// </summary>
        [STAThread]
        private static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            
            // Crear una instancia del formulario Portada
            portada portad = new portada();
            
            // Mostrar el formulario Portada
            if (portad.ShowDialog() == DialogResult.OK) // Puedes ajustar la condición según lo necesario
            {
                // Solo inicializar Main Form si el usuario lo necesita
                Application.Run(new MainForm());
            }
        }
    }
}