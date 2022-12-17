namespace KillSmokeConsoleaApp.Main
{
    internal class Smoke
    {
        private int _countDays;
        private int _countCigarars;
        private Autoload autoload = new Autoload();
        public Smoke(int countDays, int countCigar)
        {
            CountDaysWithoutСigarettуte = countDays;
            CountSmokingСigarettуte = countCigar;
        }
        public int CountDaysWithoutСigarettуte
        {
            get { return _countDays; }
            private set { _countDays = value; }
        }
        public int CountSmokingСigarettуte 
        {   
            get { return _countCigarars; }
            private set { _countCigarars = value; }    
        }

        public void ShowSmokeInfo()
        {
            Console.WriteLine("Days without cigarettes: {0}", CountDaysWithoutСigarettуte);
            Console.WriteLine("Smoked cigarettes: {0}", CountSmokingСigarettуte);
        }
    }
}
