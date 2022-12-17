namespace KillSmokeConsoleaApp.Main
{
    internal  class Autoload
    {
        private const string PATH = @"C:\KitDim_Program\KillSmoke\KillSmokeConsoleaApp\KillSmokeConsoleaApp\Data\data.dat";
        List<Smoke> smokes = new List<Smoke>();

        public List<Smoke> Load() 
        {
            using (var file = new BinaryReader(File.Open(PATH, FileMode.OpenOrCreate)))
            {
                while (file.PeekChar() > -1)
                {
                    var countDays = file.ReadInt32();
                    var countCigar = file.ReadInt32();

                    smokes.Add(new Smoke(countDays, countCigar));
                }
            }
            return smokes;
        }

    }
}
