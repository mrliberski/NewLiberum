using ProFormaUI;
using System.Media;

namespace ProFormaLibrary
{
    // Custom extension method to play the sound
    public static class AssemblyExtensions
    {
        public static void PlaySound(this System.Reflection.Assembly assembly, string soundName, SoundPlayer soundPlayer)
        {
            var resourceStream = assembly.GetManifestResourceStream(assembly.GetName().Name + "." + soundName);
            if (resourceStream != null)
            {
                using (soundPlayer)
                {
                    soundPlayer.Stream = resourceStream;
                    soundPlayer.Play();
                }
            }
        }
    }

    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            System.Windows.Forms.Application.Run(new ProFormaGenerator());
            //System.Windows.Forms.Application.Run(new RemoteSql());
            //Application.Run(new LogonScreenForm());
        }


    }
}