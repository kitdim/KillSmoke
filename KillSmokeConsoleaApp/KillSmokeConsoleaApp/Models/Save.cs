using KillSmokeConsoleaApp.Interfaces;

namespace KillSmokeConsoleaApp.Models
{
    internal class Save : ISave
    {
        private const string PATH_COUNT_DAYS_WITHOUT_CIGARETTYTE = "C:\\KitDim_Program\\KillSmoke\\KillSmokeConsoleaApp\\KillSmokeConsoleaApp\\Data\\days_without_ciga.dat";
        private const string PATH_COUNT_SMOKING_CIGARETTYTE_IN_DAY = "C:\\KitDim_Program\\KillSmoke\\KillSmokeConsoleaApp\\KillSmokeConsoleaApp\\Data\\count_ciga.dat";
        private const string PATH_IS_YOU_SMOKE = "C:\\KitDim_Program\\KillSmoke\\KillSmokeConsoleaApp\\KillSmokeConsoleaApp\\Data\\is_smoke_ciga.dat";
        public void SaveIsSmoke(bool isYouSmoke) 
        {
            using (var writer = new BinaryWriter(File.Open(PATH_IS_YOU_SMOKE, FileMode.OpenOrCreate)))
            {
                writer.Write(isYouSmoke);
            }
        }
        public void SaveCountSmokingСigarettуte(int countCigarettyte) 
        {
            using (var writer = new BinaryWriter(File.Open(PATH_COUNT_SMOKING_CIGARETTYTE_IN_DAY, FileMode.OpenOrCreate)))
            {
                writer.Write(countCigarettyte);
            }
        }
        public void SaveDaysWithoutСigarettуte(int countCigarettyte) 
        {
            using (var writer = new BinaryWriter(File.Open(PATH_COUNT_DAYS_WITHOUT_CIGARETTYTE, FileMode.OpenOrCreate)))
            {
                writer.Write(countCigarettyte);
            }
        }
    }
}
