namespace KillSmokeConsoleaApp.Main
{
    internal static class Load
    {
        private const string PATH = @"data.dat";
        public static int Loading()
        {
            using (var reader = new BinaryReader(File.Open(PATH, FileMode.OpenOrCreate)))
            {
                var countCig = reader.ReadInt32();
                return countCig;
            }
        }

    }
}
