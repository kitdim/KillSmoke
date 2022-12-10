using KillSmokeConsoleaApp.Interfaces;

namespace KillSmokeConsoleaApp.Models
{
    internal class Load : ILoad
    {
        private const string PATH_COUNT_DAYS_WITHOUT_CIGARETTYTE = "C:\\KitDim_Program\\KillSmoke\\KillSmokeConsoleaApp\\KillSmokeConsoleaApp\\Data\\days_without_ciga.dat";
        private const string PATH_COUNT_SMOKING_CIGARETTYTE_IN_DAY = "C:\\KitDim_Program\\KillSmoke\\KillSmokeConsoleaApp\\KillSmokeConsoleaApp\\Data\\count_ciga.dat";
        private const string PATH_IS_YOU_SMOKE = "C:\\KitDim_Program\\KillSmoke\\KillSmokeConsoleaApp\\KillSmokeConsoleaApp\\Data\\is_smoke_ciga.dat";

        private int _countDays;
        private int _countCigaretty;
        private bool _isYouSmoke;

        private int LoadIsSmoke() 
        {
            using (var infoCountDays = new BinaryReader(File.Open(PATH_COUNT_DAYS_WITHOUT_CIGARETTYTE, FileMode.OpenOrCreate)))
            {
                _countDays = infoCountDays.ReadInt32();
            }
            return _countDays;
        }
        private int LoadCountSmokingСigarettуte() 
        {
            using (var infocountCigaretty = new BinaryReader(File.Open(PATH_COUNT_SMOKING_CIGARETTYTE_IN_DAY, FileMode.OpenOrCreate)))
            {
                _countCigaretty = infocountCigaretty.ReadInt32();
            }
            return _countCigaretty;
        }
        private bool LoadDaysWithoutСigarettуte() 
        {
            using (var InfoisYouSmoke = new BinaryReader(File.Open(PATH_IS_YOU_SMOKE, FileMode.OpenOrCreate)))
            {
                _isYouSmoke = InfoisYouSmoke.ReadBoolean();
            }
            return _isYouSmoke;
        }
    }
}
