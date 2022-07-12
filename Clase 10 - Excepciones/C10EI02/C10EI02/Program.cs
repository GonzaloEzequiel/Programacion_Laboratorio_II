/*
 *  Ejercicio I02 - Atrapame si puedes...
 * 
 *  Consigna
 *  Crear una aplicaci�n de Windows Forms que pueda realizar un c�lculo de consumo entre kilometros y litros.
 *  
 *  El formulario deber� contener:
 *      2x Labels
 *      2x TextBox
 *      1x Button
 *      1x RichTextbox
 *      
 *  El formulario debe levantar en el centro de la pantalla, no debe tener los botones de maximizar, minimizar y no se le tiene que poder modificar el tama�o.
 *  El RichTextbox no tiene que poder editarse.
 *  El formulario debe validar que los dos par�metros ingresados no est�n vac�os y en caso de estar se deber� lanzar una nueva excepci�n 
 *      de tipo ParametrosVaciosException e informar al usuario.
 *  Una vez que los par�metros fueron cargados validar si la conversi�n es posible (utilizar int.Parse), de lo contrario capturar la excepci�n correspondiente.
 *  Crear una clase est�tica llamada Calculador con un metodo est�tico Calcular que recibe dos enteros y retorna su divisi�n tener en cuenta 
 *      que las divisi�n por cero lanza una excepci�n, controlarla.
 *  Todas las excepciones que fueron capturadas deben ser mostradas al usuario de una forma mas entendible ("amigable") por medio del metodo Show 
 *      de la clase MessageBox.
 *      
 *  El programa no debe tener ninguna excepci�n no controlada.
 * 
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C10EI02
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmCalculador());
        }
    }
}
