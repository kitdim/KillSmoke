namespace KillSmokeConsoleaApp.Interfaces
{
    internal interface ISmoking
    {
        bool IsSmoke { get; set; }
        int CountDaysWithoutСigarettуte { get; set; }
        int CountSmokingСigarettуte { get; set; }

        void ShowSmokeInfo();
    }
}
