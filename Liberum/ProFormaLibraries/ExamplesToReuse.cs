using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProFormaLibraries
{
    internal class ExamplesToReuse
    {
        // BELOW AN EXAMPLE OF APPLICATION OF AWAIT ASYNC FOR DUMMIES
        // I DO NOT KNOW WAHAT I AM DOING
        //
        //
        //
        private async void JustAnExample()
        {
            Task<int> task = new Task<int>(CountCharacters);
            task.Start();

            int count = await task;
        }

        private int CountCharacters()
        {
            int count = 0;
            using (StreamReader reader = new StreamReader("c:\\Data\\Data.txt"))
            {
                string content = reader.ReadToEnd();
                count += content.Length;    
                Thread.Sleep(1000);
            }

            return count;

            //System.Diagnostics.Process.Start("explorer.exe", @".\Matrix");
            //System.Diagnostics.Debug.WriteLine("Possibly it went OK");
        }



        private void DoNotAct()
        {
            if (!Environment.UserName.Equals("PANLI", StringComparison.OrdinalIgnoreCase))
            {
                throw new NotImplementedException();
            }
        }
    }
}
