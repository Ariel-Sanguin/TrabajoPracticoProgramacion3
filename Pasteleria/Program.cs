using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Pasteleria
{
    [Serializable]
    static class Program
    {
        private static Principal PR; 

        public static Principal getSistema()
        {
            return PR;
        }

        [STAThread]
        static void Main()
        {
            PR = new Principal();

            //Creacion del archivo de serializacion
            if (!File.Exists("datos.bin"))
            {
                Stream flujo2 = File.Create("datos.bin");
                BinaryFormatter serializer = new BinaryFormatter();
                serializer.Serialize(flujo2, PR);
                flujo2.Close();
                MessageBox.Show("Archivo creado de resguardo (serializacion) por primera vez");
                //return; //termina el Main
            }

            try
            {
                Stream flujo = File.OpenRead("datos.bin");
                BinaryFormatter deserializer = new BinaryFormatter();
                PR = (Principal)deserializer.Deserialize(flujo);
                flujo.Close();
            }
            catch (Exception E)
            {
                //Si falla lo anterior es porque no está creado el archivo, no se puede continuar.
                MessageBox.Show("Descomentar bloque del main para crear el archivo por primera vez. Terminando programa.");
                //Por si acaso hay otro error ver detalle de la excepcion.
                MessageBox.Show(E.ToString());
                return; //Termina el Main
            }

            Application.ApplicationExit += new System.EventHandler(SerializarAlSalir);
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmInicio(PR));
        }

        public static void SerializarAlSalir(object sender, EventArgs e)
        {
            Stream flujo2 = File.Create("datos.bin");
            BinaryFormatter serializer = new BinaryFormatter();
            serializer.Serialize(flujo2, PR); 
            flujo2.Close();
            MessageBox.Show("Objeto serializado ok. Terminando programa.");
        }

    }


}
