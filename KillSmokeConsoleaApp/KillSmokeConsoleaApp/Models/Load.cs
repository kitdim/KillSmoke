using KillSmokeConsoleaApp.Interfaces;

namespace KillSmokeConsoleaApp.Models
{
    internal class Load : ILoad
    {
        private const string PATH_COUNT_DAYS_WITHOUT_CIGARETTYTE = "C:\\KitDim_Program\\KillSmoke\\KillSmokeConsoleaApp\\KillSmokeConsoleaApp\\Data\\days_without_ciga.dat";
        private const string PATH_COUNT_SMOKING_CIGARETTYTE_IN_DAY = "C:\\KitDim_Program\\KillSmoke\\KillSmokeConsoleaApp\\KillSmokeConsoleaApp\\Data\\count_ciga.dat";
        private const string PATH_IS_SMOKE = "C:\\KitDim_Program\\KillSmoke\\KillSmokeConsoleaApp\\KillSmokeConsoleaApp\\Data\\is_smoke_ciga.dat";
        static void LoadIsSmoke() { }
        static void LoadCountSmokingСigarettуte() { }
        static void LoadDaysWithoutСigarettуte() { }
    }
}
