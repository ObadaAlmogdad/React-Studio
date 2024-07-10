using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace ReactStudio.BusinessLayer
{
    class ReactProcess
    {
        public static void Start(string fileInput, string fileOutput)
        {
            // Create a new process object
            Process p = new Process();

            // Set the file name to java.exe
            p.StartInfo.FileName = $"\"{Properties.Settings.Default.JAVA_PATH}\"";

            string main_class_path = Path.GetDirectoryName(Properties.Settings.Default.MAIN_CLASS);
            string class_name = Path.GetFileName(Properties.Settings.Default.MAIN_CLASS);
            class_name = class_name.Substring(0, class_name.IndexOf(".class"));


            string fullCommand =
                                " -cp .;" +
                                $"{main_class_path};" +
                                $"{Properties.Settings.Default.ANTLR_PATH} {class_name} " +
                                $"\"{fileInput}\" " +
                                $"\"{fileOutput}\"";

            Clipboard.SetText(p.StartInfo.FileName + fullCommand);

            // Set the arguments to the java command and the user input
            p.StartInfo.Arguments = fullCommand;

            // Start the process
            p.Start();
        }
    }
}
