using System.Text;

namespace KillSmokeConsoleaApp.Main
{
    internal class Load
    {
        private const string PATH = @"countCig.dat";
        private static int countCig;

        public static int Loading() 
        {
            if (File.Exists(PATH))
            {
                var file = new FileInfo(PATH);
                if (file.Length == 0)
                {
                    countCig = 0;
                }
                else
                {
                    //TODO доделать запись из файла
                }
            }
            else
            {
                File.Create(PATH);
                countCig = 0;
            }

            return countCig;
        }

    }
}
