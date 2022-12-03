namespace KillSmokeConsoleaApp.Interfaces
{
    internal interface ISmoking
    {
        int CountСigarettуte { get; set; }
        int CountDateWithoutСigarettуte { get; set; }
        int CountSmokingСigarettуte { get; set; }

        void ShowSmokeInfo();
    }
}
