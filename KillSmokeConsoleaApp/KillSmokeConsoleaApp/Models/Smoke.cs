using KillSmokeConsoleaApp.Interfaces;

namespace KillSmokeConsoleaApp.Models
{
    internal class Smoke : ISmoking
    {
        public Load load;
        private Save save;
        public int CountDaysWithoutСigarettуte { get => load.LoadDaysWithoutСigarettуte(); }
        public int CountSmokingСigarettуte { get => load.LoadCountSmokingСigarettуte(); }
        public bool IsSmoke { get => load.LoadIsSmoke(); }

        public Smoke()
        {
            
        }

        public void ShowSmokeInfo()
        {
            throw new NotImplementedException();
        }
    }
}
