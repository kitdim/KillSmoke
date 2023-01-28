namespace KillSmokeConsoleaApp.Main
{
    internal class Save
    {
        private const string PATH = @"countCig.dat";
        public static void Saving()
        {
            Smoke[] mySmoke =
            {
                new Smoke(0)
            };
            using (var writer = new BinaryWriter(File.Open(PATH, FileMode.Open)))
            {
                foreach(var item in mySmoke)
                {
                    writer.Write(item.CountDaysWithoutСigarettуte);
                }
            }
        }
        public static void Saving(int zero) 
        {
            Smoke[] mySmoke =
            {
                new Smoke(zero)
            };
            using (var writer = new BinaryWriter(File.Open(PATH, FileMode.Open)))
            {
                foreach (var item in mySmoke)
                {
                    writer.Write(item.CountDaysWithoutСigarettуte);
                }
            }
        }
    }
}
