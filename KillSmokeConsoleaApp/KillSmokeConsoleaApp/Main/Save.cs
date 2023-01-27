namespace KillSmokeConsoleaApp.Main
{
    internal class Save
    {
        private const string PATH = @"countCig.dat";
        private static int countCig;
        public static void Saving()
        {
            using (var reader = new BinaryWriter(File.Open(PATH, FileMode.Open)))
            {
                reader.Write(0);
            }
        }
    }
}
