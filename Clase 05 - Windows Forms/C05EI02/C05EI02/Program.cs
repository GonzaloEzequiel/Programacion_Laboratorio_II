/*
 *  Ejercicio I02 - Registrate
 * 
 *  Crear un proyecto de tipo Windows Forms App y un proyecto de biblioteca de clases.
 *  Agregar al proyecto de biblioteca de clases la clase Ingresante tal como describe el siguiente diagrama:
 *  
 *  INRGESANTE
 *      Fields
 *      (private) cursos : string[]
 *      (private) direccion : string
 *      (private) edad : int
 *      (private) genero : string
 *      (private) nombre : string
 *      (private) pais : string
 *      Methods
 *      Ingresante(string nombre, string direccion, string genero, string pais, string[] cursos, int edad)
 *      Mostrar() : string;
 *      
 *  El constructor inicializar� todos los atributos de la clase.
 *  El m�todo Mostrar expondr� todos los atributos de la clase al exterior, utilizar StringBuilder e interpolaci�n de strings.
 *  
 *  El proyecto de Windows Forms contar� con los siguientes controles:
 *  Un control de tipo GroupBox que contendr� dos controles de tipo TextBox para cargar el nombre y la direcci�n, y un NumericUpDown para cargar la edad del usuario con sus respectivos Label.
 *  Un segundo control de tipo GroupBox que contendr� tres RadioButton que determinar�n el g�nero del usuario (masculino, femenino o no binario).
 *  Un �ltimo control de tipo GroupBox contendr� tres controles de tipo CheckBox con los distintos cursos a elegir (C#, C++ o JavaScript). 
 *  Se deben poder elegir todos los cursos, ninguno o algunos.
 *  Un control de tipo ListBox que tendr� los paises para que el usuario escoja (Argentina, Chile o Uruguay).
 *  Por �ltimo, un bot�n que al accionarse deber� mostrar toda la informaci�n del usuario registrado.
 *  
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C05EI02
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
            Application.Run(new FrmRegistro());
        }
    }
}
