using KillSmokeConsoleaApp.Interfaces;

namespace KillSmokeConsoleaApp.Models
{
    internal class Save : ISave
    {
        private const string PATH_COUNT_DAYS_WITHOUT_CIGARETTYTE = "C:\\KitDim_Program\\KillSmoke\\KillSmokeConsoleaApp\\KillSmokeConsoleaApp\\Data\\days_without_ciga.dat";
        private const string PATH_COUNT_SMOKING_CIGARETTYTE_IN_DAY = "C:\\KitDim_Program\\KillSmoke\\KillSmokeConsoleaApp\\KillSmokeConsoleaApp\\Data\\count_ciga.dat";
        private const string PATH_IS_SMOKE = "C:\\KitDim_Program\\KillSmoke\\KillSmokeConsoleaApp\\KillSmokeConsoleaApp\\Data\\is_smoke_ciga.dat";
        static void SaveIsSmoke() { }
        static void SaveCountSmokingСigarettуte() { }
        static void SaveDaysWithoutСigarettуte() { }
    }
}
