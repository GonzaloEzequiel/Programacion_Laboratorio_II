/*
 *  Ejercicio I01 - La lista del super
 *  
 *  El objetivo ser� crear una aplicaci�n que maneje una lista de supermercado. Se podr� agregar, eliminar y modificar los elementos de la lista.
 * 
 *  Crear un proyecto de Windows Forms con un formulario llamado FrmAltaModificacion que se vea como el siguiente: *imagen*
 *  
 *  1. Deber� iniciar centrado en la pantalla (propiedad StartPosition).
 *  2. No deber� tener men� de control (propiedad ControlBox).
 *  3. No deber� poder cambiar de tama�o (propiedad FormBorderStyle).
 *  4. No tendr� �cono (propiedad ShowIcon).
 *  5. Tendr� un TextBox llamado txtObjeto, un Button llamado btnConfirmar y un Button llamado btnCancelar.
 *  6. El txtObjeto no deber� poder contener un texto de m�s de 50 caracteres (propiedad MaxLength).
 *  7. Tendr� una propiedad Objeto p�blica y de s�lo lectura que retornar� el contenido del txtObjeto.
 *  8. Al instanciarse deber� configurarse de acuerdo a la siguiente informaci�n que recibir� como argumentos en su constructor:
 *      El t�tulo del formulario.
 *      El texto que contendr� el txtObjeto.
 *      El texto del btnConfirmar.
 *  9. Si se presiona el btnConfirmar o la tecla enter (posicionados dentro del TextBox):
 *      Validar que el txtObjeto no se encuentre vac�o.
 *      Si se encuentra vac�o mostrar una advertencia y no avanzar.
 *      Si es v�lido, cargar la propiedad DialogResult con el valor DialogResult.OK y cerrar el formulario.
 *      
 *  TIP
 *  El evento KeyPress se acciona cuando el usuario est� haciendo foco en el control que es due�o del evento y presiona una tecla.
 *  Uno de los par�metros de entrada del manejador de dicho evento es de tipo KeyPressEventArgs y contiene una propiedad KeyChar que tendr� como valor 
 *  el caracter correspondiente a la tecla presionada por el usuario.
 *  Por ejemplo, para saber si el usuario presion� la tecla enter podemos hacer lo siguiente:
 *  
 *      if (e.KeyChar == (char)13) // 13 es el c�digo ASCII que representa a ENTER.
 *      {
 *          // ...
 *      }
 *      
 *      Si queremos saber si el usuario presion� s o S (shift + s) podemos hacer lo siguiente:
 *      
 *      if (e.KeyChar == 's' || e.KeyChar == 'S') 
 *      {
 *          // ...
 *      }
 *      
 *  10. Si se presiona el btnCancelar o la tecla escape (posicionados dentro del TextBox), se deber� cargar la propiedad DialogResult con el valor DialogResult.Cancel y cerrar el formulario.
 *  
 *  
 *  Agregar otro formulario llamado FrmListaSuper que se vea como el siguiente: *imagen*
 * 
 *  1. Deber� ser el formulario que se muestra al iniciar la aplicaci�n.
 *  2. Tendr� un atributo listaSupermercado de tipo List<string> que contendr� los elementos de la lista del supermercado.
 *  3. Deber� iniciar centrado en la pantalla (propiedad StartPosition).
 *  4. Tendr� un ListBox llamado lstObjetos.
 *      Mostrar� la lista de objetos pendientes de comprar en el supermercado.
 *      Mostar� anclado a todos los bordes del formulario (propiedad Anchor).
 *  5. Tendr� un Button llamado btnAgregar cuyo texto ser� "+" y al pasar por encima deber� mostrar un tooltip con el texto "Agregar objeto".
 *      Deber� estar anclado arriba y a la derecha (propiedad Anchor).
 *      Al accionarlo instanciar� un FrmAltaModificacion y lo mostrar� de forma modal.
 *          El t�tulo ser� "Agregar objeto".
 *          El contenido del txtObjeto ser� un texto vac�o.
 *          El texto del btnConfirmar ser� "Agregar".
 *      Si la propiedad DialogResult de la instancia de FrmAltaModificacion vale DialogResult.OK, agregar el elemento retornado por la propiedad Objeto a la lista del supermercado. 
 *      Caso contrario, no hacer nada.
 *  6. Tendr� un Button llamado btnEliminar cuyo texto ser� "-" y al pasar por encima deber� mostrar un tooltip con el texto "ELiminar objeto".
 *      Deber� estar anclado arriba y a la derecha (propiedad Anchor).
 *      Al accionarlo deber� borrar el objeto seleccionado en la lista. Si no hay nada seleccionado, no hacer nada y mostrar un cartel informando que 
 *      se debe seleccionar un elemento de la lista.
 *  7. Tendr� un Button llamado btnModificar cuyo texto ser� "M" y al pasar por encima deber� mostrar un tooltip con el texto "Modificar objeto".
 *      Deber� estar anclado arriba y a la derecha (propiedad Anchor).
 *      Al accionarlo instanciar� un FrmAltaModificacion y lo mostrar� de forma modal.
 *          El t�tulo ser� "Modificar objeto".
 *          El contenido del txtObjeto ser� el elemento seleccionado en lstObjetos. Si no hay nada seleccionado, no hacer nada y mostrar un cartel 
 *          informando que se debe seleccionar un elemento de la lista.
 *          El texto del btnConfirmar ser� "Modificar".
 *      Si la propiedad DialogResult de la instancia de FrmAltaModificacion vale DialogResult.OK, modificar el objeto en la lista del supermercado asign�ndole 
 *      el valor de la propiedad Objeto. Caso contrario, no hacer nada.
 *  8. En el manejador del evento Load se deber� buscar el archivo listaSupermercado.xml en la carpeta de datos de aplicaciones (Environment.SpecialFolder.ApplicationData) 
 *     y, si existe, deserializarla desde formato XML como una lista de string.
 *      Cargar lstObjetos con los elementos de la lista.
 *      Si el archivo no existe, no hacer nada.
 *  9. Ante cualquier acci�n se deber� actualizar el contenido de lstObjetos y el archivo listaSupermercado.xml, que contendr� la lista de objetos serializada a formato XML y se encontrar� en la ubicaci�n antes nombrada
 *  
 *      TIP
 *    Para actualizar el contenido de un ListBox se debe cargar la propiedad DataSource como null y luego asignarle a la misma la colecci�n de elementos:
 *      listBox.DataSource = null;
 *      listBox.DataSource = listaSupermercado;
 *      
 *      IMPORTANTE
 *    Cualquier excepci�n deber� ser manejada mostrando un MessageBox con el mensaje y el stack trace.
 *    Reutilizar c�digo en todo el proyecto siguiendo el principio DRY.
 *    
 */


using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C15EI01
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
            Application.Run(new FrmListaSuper());
        }
    }
}
