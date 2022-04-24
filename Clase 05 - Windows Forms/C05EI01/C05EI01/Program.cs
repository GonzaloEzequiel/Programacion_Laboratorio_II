/*
 *  Ejercicio I01 - �Hola, Windows Forms!
 *  
 *  Parte I
 *  
 *  Crear un proyecto de tipo Windows Forms App que contenga un formulario con los siguientes controles:
 *  Dos controles de tipo TextBox. En uno se ingresar� un nombre y en el otro un apellido.
 *  Sobre cada control debe haber un Label en negrita que indique al usuario el dato que debe ingresar.
 *  Un control de tipo Button con el texto "Saludar".
 *  
 *  Crear otro formulario que reciba como argumentos de su �nico constructor un t�tulo y un mensaje.
 *  
 *  Al presionar el bot�n Saludar se deber� abrir este segundo formulario de forma modal mostrando un mensaje como el siguiente:
 *      �Hola, Windows Forms!
 *      Soy {nombre} {apellido}.
 *      
 *  En negrita, con it�lica y fuente tama�o 14 mostrar� el t�tulo y debajo, con fuente tama�o 12, el mensaje.
 *  Las variables nombre, apellido se deber�n reemplazar con los valores ingresados por el usuario.
 * 
 *  Requisitos
 *  Todos los controles deber�n tener nombres descriptivos, as� como el formulario y los archivos de c�digo fuente. No debe quedar ning�n nombre por defecto.
 *  Ambos formularios deber�n iniciarce en el centro de la pantalla.
 *  El t�tulo del primer formulario deber� ser "�Hola, Windows Forms!".
 *  El t�tulo del segundo formulario deber� ser "Saludo".
 *  No deber� poder maximizarse, minimizarse, ni alterar el tama�o de las ventanas.
 *  
 *  
 *  Parte II
 *  
 *  Agregar un control de tipo ComboBox precargado con los nombres de las materias del primer y segundo cuatrimestre de la carrera. Deber� estar acompa�ado de su respectivo Label.
 *  Modificar el mensaje para que muestre:
 *      �Hola, Windows Forms!
 *      Soy {nombre} {apellido} y mi materia favorita es {materia}.
 *      
 *  Las variables nombre, apellido y materia se deber�n reemplazar con los valores ingresados por el usuario.
 *  
 *  Requisitos
 *  Inicializar el ComboBox en el evento Load del objeto Form.
 *  NO deber� permitir el ingreso de nuevas opciones.
 *  Deber� existir una opci�n seleccionada por defecto al iniciar el formulario (no aparecer en blanco).
 *  
 *  
 *  Parte III
 *  
 *  Al presionar el bot�n Saludar y antes de mostrar la ventana con el mensaje, se deber� validar que se haya ingresado un valor para el nombre y el apellido.
 *  Utilizar el m�todo est�tico IsNullOrWhiteSpace de la clase String para validar.
 *  En caso de que no se haya ingresado, en vez de la ventana habitual mostrar un MessageBox con el texto "Error" de t�tulo, un �cono de error y un s�lo bot�n de OK. 
 *  Deber� contener el siguiente mensaje:
 *      Se deben completar los siguientes campos:
 *      Nombre
 *      Apellido
 *      
 *  S�lo se deber�n mostrar los campos que no contengan ning�n valor. Si el usuario llen� el campo del nombre pero falta el apellido, mostrar solo "Apellido". 
 *  Si no llen� ninguno, mostrar los dos.
 *  
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C05EI01
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
            Application.Run(new FormSaludar());
        }
    }
}
