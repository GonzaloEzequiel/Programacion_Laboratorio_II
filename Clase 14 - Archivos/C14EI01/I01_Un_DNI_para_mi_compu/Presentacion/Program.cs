/*
 *  Ejercicio I01 - Un DNI para mi compu
 * 
 *  1. Manejar el evento Load del formulario y cambiar la propiedad Text para que contenga el mensaje "Compu de [usuario]". 
 *      Reemplazar el texto entre corchetes por el nombre del usuario conectado al sistema operativo. Obtener el dato a partir de la propiedad que corresponda de la clase Environment.
 *      
 *  2. Crear el m�todo private void ConfigurarLogoSistemaOperativo() y utilizando los m�todos est�ticos de la clase OperatingSystem implementar la siguiente l�gica:
 *      i. Si el sistema es MacOS, asignar Properties.Resources.mac a la propiedad Image del control picboxSistemaOperativo.
 *      ii. Si el sistema es Linux, asignar Properties.Resources.linux a la propiedad Image del control picboxSistemaOperativo.
 *      iii. Si el sistema es Windows, asignar Properties.Resources.windows a la propiedad Image del control picboxSistemaOperativo.
 *  
 *  3. Invocar al m�todo ConfigurarLogoSistemaOperativo del punto anterior dentro del manejador del evento Load.
 *  
 *  4. Dentro del manejador del evento Load modificar la propiedad Text del label lblSistemaOperativo y cargar el mensaje "Sistema operativo: [Plataforma y versi�n del sistema operativo]".
 *      Reemplazar el texto entre corchetes por la descripci�n del sistema operativo sobre el que se est� ejecutando la aplicaci�n. 
 *      Obtener el dato a partir de la propiedad que corresponda de la clase Environment.
 *  
 *  5. Dentro del manejador del evento Load modificar la propiedad Text del label lblNombreMaquina y cargar el mensaje "Nombre de la m�quina: [Nombre de la m�quina]". 
 *      Reemplazar el texto entre corchetes por el nombre de la m�quina sobre la que se est� ejecutando la aplicaci�n. 
 *      Obtener el dato a partir de la propiedad que corresponda de la clase Environment.
 *      
 *  6. Crear el m�todo private void ConfigurarArquitectura() y utilizando la propiedad est�tica que corresponda de la clase Environment implementar la siguiente l�gica:
 *      i. Si el sistema es de 64 bits, modificar la propiedad Text del label lblArquitectura y cargar el mensaje "Arquitectura: 64 bits".
 *      ii. Si el sistema es de 32 bits, modificar la propiedad Text del label lblArquitectura y cargar el mensaje "Arquitectura: 32 bits".
 *      
 *  7. Dentro del manejador del evento Load modificar la propiedad Text del label lblCantProcesadores y cargar el mensaje "Cant. procesadores: 
 *      [cantidad de procesadores l�gicos] procesadores l�gicos". Reemplazar el texto entre corchetes por la cantidad de procesadores l�gicos que tiene la m�quina 
 *      sobre la que se est� ejecutando la aplicaci�n. Obtener el dato a partir de la propiedad que corresponda de la clase Environment.
 *      
 *  8. Dentro del manejador del evento Load modificar la propiedad Text del label lblDirectorioActual y:
 *      i. Cargarle el mensaje "Identificaci�n ejecutada en: [Salto de l�nea]". Reemplazar el texto entre corchetes por un salto de l�nea que sea agn�stico al sistema operativo 
 *          sobre el que se ejecuta la aplicaci�n, para eso se deber� utilizar la propiedad que corresponda de la clase Environment.
 *      ii. A continuaci�n del salto de l�nea generado en el punto anterior, incorporar al texto la ruta absoluta del directorio sobre el que se est� ejecutando la aplicaci�n. 
 *          Obtener el dato con la propiedad CurrentDirectory de la clase Environment.
 *          
 *  9. Crear el m�todo private void ConfigurarEspacioTotalYDisponible() y utilizando el m�todo est�tico GetDrives de la clase DriveInfo:
 *      i. Modificar la propiedad Text del label lblEspacioTotal y cargar el mensaje "Espacio total: [espacio total] Gigabytes". Reemplazar el texto entre corchetes 
 *          por la suma del espacio total de todas las unidades de almacenamiento de la computadora. Mostrar el dato en gygabytes redondeado al entero m�s cercano.
 *      ii. Modificar la propiedad Text del label lblEspacioDisponible y cargar el mensaje "Espacio disponible: [espacio disponible] Gigabytes". 
 *          Reemplazar el texto entre corchetes por la suma del espacio disponible en todas las unidades de almacenamiento de la computadora. M
 *          ostrar el dato en gygabytes redondeado al entero m�s cercano.* 
 * 
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
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
            Application.Run(new FrmIdentificacionComputadora());
        }
    }
}
