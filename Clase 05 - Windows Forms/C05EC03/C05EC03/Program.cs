/*
 *  Ejercicio C03 - �Denle una UI a ese conversor binario!
 * 
 *  Partir del ejercicio Conversor binario recargado y agregarle un proyecto de tipo Windows Forms App con el siguiente formato:
 *  Implementarlo de tal forma que al ingresar un valor v�lido en la primer casilla (txtBinario y txtDecimal respectivamente) 
 *  y presionar el bot�n del medio (btnBinToDec y btnDecToBin) el resultado de la conversi�n se vea reflejado en las casillas de la derecha (txtResultadoDec y txtResultadoBin), 
 *  las cuales no podr�n ser editadas/escritas por el usuario.
 *
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using BilbiotecaC04EC01;

namespace C05EC03
{
    static class Program
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
            Application.Run(new FrmConversorNumerico());
        }
    }
}
