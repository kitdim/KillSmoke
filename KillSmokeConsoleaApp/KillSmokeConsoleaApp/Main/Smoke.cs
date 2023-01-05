namespace KillSmokeConsoleaApp.Main
{
    internal class Smoke
    {
        private int _countDays;
        public Smoke(int countDays)
        {
            CountDaysWithoutСigarettуte = countDays;
        }
        public int CountDaysWithoutСigarettуte
        {
            get { return _countDays; }
            private set { _countDays = value; }
        }
        public void ShowSmokeInfo()
        {
            Console.WriteLine("Days without cigarettes: {0}", CountDaysWithoutСigarettуte);
        }
    }
}
