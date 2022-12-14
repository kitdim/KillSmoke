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

        public bool LoadIsSmoke() 
        {
            using (var infoisYouSmoke = new BinaryReader(File.Open(PATH_COUNT_DAYS_WITHOUT_CIGARETTYTE, FileMode.OpenOrCreate)))
            {
                _isYouSmoke = infoisYouSmoke.ReadBoolean();
                
            }
            return _isYouSmoke;
        }
        public int LoadCountSmokingСigarettуte() 
        {
            using (var infoCountCigaretty = new BinaryReader(File.Open(PATH_COUNT_SMOKING_CIGARETTYTE_IN_DAY, FileMode.OpenOrCreate)))
            {
                _countCigaretty = infoCountCigaretty.ReadInt32();
            }
            return _countCigaretty;
        }
        public int LoadDaysWithoutСigarettуte() 
        {
            using (var infoCountsDays = new BinaryReader(File.Open(PATH_IS_YOU_SMOKE, FileMode.OpenOrCreate)))
            {
                _countDays = infoCountsDays.ReadInt32();

                if (_countDays == 0) _countDays = 0;
            }
            return _countDays;
        }
    }
}
