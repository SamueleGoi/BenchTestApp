using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Media3D;

namespace ProceduraCollaudo
{
    public class Collaudo
    {

        public static string rev = "1.0.0 - Marzo 2023";
        /*DATI PER FOGLIO DI COLLAUDO*/
        private static string _comPort = "COM5"; //TODO: per debug (rimuovere)
        public static string comPort
        {
            get { return _comPort; }
            set { _comPort = value; }
        }

        private static int _comBaud = 57600;
        public static int comBaud
        {
            get { return _comBaud; }
            set { _comBaud = value; }
        }

        private static string _matricola = "2303.N.620678"; //TODO: per debug (rimuovere)
        public static string matricola
        {
            get { return _matricola; }
            set { _matricola = value; }
        }

        private static string _operatore = "";
        public static string operatore
        {
            get { return _operatore; }
            set { _operatore = value; }
        }

        private static string _model = "250"; //TODO: per debug (rimuovere)
        public static string model
        {
            get { return _model; }
            set { _model = value; }
        }

        private static string _location = "";
        public static string location
        {
            get { return _location; }
            set { _location = value; }
        }

        private static string _filePath = "";
        public static string filePath
        {
            get { return _filePath; }
            set { _filePath = value; }
        }

        private static string _fileName = "";
        public static string fileName 
        {
            get { return _fileName; }
            set { _fileName = value; }
        }

        private static string _folderPath = "";
        public static string folderPath
        {
            get { return _folderPath; }
            set { _folderPath = value; }
        }

        private static string _folderName = "";
        public static string folderName
        {
            get { return _folderName; }
            set { _folderName = value; }
        }

        private static string _modelProfi = "";
        public static string modelProfi
        {
            get { return _modelProfi; }
            set { _modelProfi = value; }
        }

        private static string _modelIgnition = "1"; //TODO: per debug (rimuovere)
        public static string modelIgnition
        {
            get { return _modelIgnition; }
            set { _modelIgnition = value; }
        }

        /*MESSAGGI E AVVISI*/

        public static string msgError = "Errore";
        public static string msgWarning = "Attenzione";
        public static string msgSuccess = "Successo";

        //public static bool SendCommand(SerialPort, string cmd) 
        //{

        //    return true;
        //}

    }
}
