namespace KillSmokeConsoleaApp.Interfaces
{
    internal interface ISmoking
    {
        bool IsSmoke { get; }
        int CountDaysWithoutСigarettуte { get; }
        int CountSmokingСigarettуte { get; }

        void ShowSmokeInfo();
    }
}
