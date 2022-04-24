/*
 *  Ejercicio C01 - Cotizador desktop
 *  
 *  Partir del ejercicio Cotizador y agregarle un proyecto de tipo Windows Forms App con el siguiente formato:
 *  
 *  Agregar el m�todo est�tico SetCotizacion en las clases Euro y Peso.
 *  La casilla de cotizaci�n del d�lar deber� permanecer siempre en 1. Utilizar el evento de p�rdida de foco del TextBox para chequear que as� sea.
 *  El formulario debe iniciar centrado en la pantalla, no tener las cajas de maximizar y minimizar y no poder modificarse su tama�o.
 *  Utilizar un ImageList para los dos estados del bot�n (candado cerrado y abierto).
 *  Cerrado: los TextBox txtCotizacion (Euro | D�lar | Pesos) no podr�n ser editados (propiedad Enabled en false).
 *      Descargar icono de candado cerrado
 *  Abierto: los TextBox ser�n editables.
 *      Descargar icono de candado abierto
 *  Al producirse el evento Leave de cada TextBox, editar la cotizaci�n de la moneda correspondiente. Si el dato ingresado no es v�lido, devolver el foco a dicho control.
 *  
 *  Implementarlo de tal forma que al ingresar un valor v�lido en la primer casilla (txtEuro, txtDolar y txtPeso respectivamente) y 
 *  presionar el bot�n del medio (btnConvertEuro, btnConvertDolar y btnConvertPeso) el resultado de la conversi�n se vea reflejado en las casillas de la derecha 
 *  (txtEuroAEuro, txtEuroADolar, txtEuroAPeso, txtDolarAEuro, txtDolarADolar, txtDolarAPeso, txtPesosAEuro, txtPesosADolar y txtPesosAPeso), 
 *  las cuales no podr�n ser editadas/escritas por el usuario.
 * 
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Billetes;

namespace C05EC01
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
            Application.Run(new frmConversor());
        }
    }
}
